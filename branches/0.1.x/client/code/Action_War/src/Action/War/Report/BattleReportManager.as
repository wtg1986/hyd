package Action.War.Report
{
	import Action.Display.Drawing.CanvasGraphics;
	import Action.Display.Drawing.IMovieFrameRenderer;
	import Action.Display.Drawing.Movie;
	import Action.Display.Drawing.MoviePlayer;
	import Action.Model.BattleAction;
	import Action.Model.BattleActionType;
	import Action.Model.BattleBout;
	import Action.Model.BattleReport;
	import Action.Model.BattleUnit;
	import Action.Resource.Flow.LoadHeroFaceResourceActivity;
	import Action.Resource.HeroFaceResource;
	import Action.War.BattleDefs;
	import Action.War.Config.BattleConfigFactory;
	import Action.War.Config.BattleSkill;
	import Action.War.Flow.LoadBattleSkillResourceActivity;
	import Action.War.Flow.LoadBattleUnitResourceActivity;
	import Action.War.Movie.BattleBoutBeginRenderer;
	import Action.War.Movie.BattleBoutDeadRenderer;
	import Action.War.Movie.BattleBoutMoveRenderer;
	import Action.War.Movie.BattleBoutSkillRenderer;
	import Action.War.Movie.BattleReportInitRenderer;
	import Action.War.Movie.BattleReportOverRenderer;
	import Action.War.Resource.BattleSkillResource;
	import Action.War.Resource.BattleUnitResource;
	import Action.War.Strategy.UnitWallResourceStrategy;
	import Action.War.WarPlugins;

	public class BattleReportManager
	{		
		private var _unitsCount1:int;
		public function get unitsCount1():int
		{
			return _unitsCount1;
		}
		
		private var _unitsCount2:int;
		public function get unitsCount2():int
		{
			return _unitsCount2;
		}
		
		private var _moviePlayer:MoviePlayer;
		public function get moviePlayer():MoviePlayer
		{
			return _moviePlayer;
		}
		
		private var _battleReport:BattleReport;		
		private var _buManagers:Array = new Array();
		
		public function getBUMS():Array
		{
			return _buManagers;
		}
		
		public function getDeadBUMS():Array
		{
			var bums:Array = new Array();
			for each(var bum:BattleUnitManager in _buManagers)
			{
				if(bum.isDead)
					bums.push(bum);
			}
			return bums;
		}
		
		public function getBUM(sid:int):BattleUnitManager
		{
			return _buManagers[sid];
		}
		
		public function getBUMbyPos(pos:int):BattleUnitManager
		{
			for each(var bum:BattleUnitManager in _buManagers)
			{
				if(bum.POS == pos)
					return bum;
			}
			return null;
		}
		
		public function delBUM(sid:int):void
		{
			var bum:BattleUnitManager = _buManagers[sid] as BattleUnitManager;
			if(bum != null && !bum.isWall)
			{				
				if(sid < BattleDefs.SPLIT_SID)
					_unitsCount1--;
				else
					_unitsCount2--;
			}
			delete _buManagers[sid];
		}
		
		public function getBattleActions():Array
		{
			var actions:Array = new Array();
			for each(var bout:BattleBout in _battleReport.bouts)
			{
				for each(var action:BattleAction in bout.actions)
					actions.push(action);
			}
			return actions;
		}
		
		public function get player1():String
		{
			return _battleReport.player1;
		}
		
		public function get player2():String
		{
			return _battleReport.player2;
		}
		
		public function get win():Boolean
		{
			return _battleReport.win;
		}
		
		public function BattleReportManager(report:BattleReport)
		{
			_battleReport = report;
			reset();
		}
		
		public function reset():void
		{
			_unitsCount1 = _unitsCount2 = 0;
			for each(var bu:BattleUnit in _battleReport.units)
			{
				var bum:BattleUnitManager = new BattleUnitManager(this, bu);
				bum.resetDir();				
				_buManagers[bum.SID] = bum;
				if(!bum.isWall)
				{
					if(bum.SID < BattleDefs.SPLIT_SID)
						_unitsCount1++;
					else
						_unitsCount2++;
				}
			}
		}
		
		public function createLoadingActivities():Array
		{
			var acts:Array = new Array();
			
			//loading BattleUnitResource and HeroResource
			for each(var bum:BattleUnitManager in _buManagers)
			{
				if(BattleUnitResource.getInstance(bum.unitResId) == null)
				{
					BattleUnitResource.createInstance(bum.unitResId);
					if(bum.isWall)
						acts.push(new LoadBattleUnitResourceActivity(bum.unitResId, 0));
					else
					{
						for(var i:int = 1; i<4; i++)
							acts.push(new LoadBattleUnitResourceActivity(bum.unitResId, i));
					}
				}
				if(HeroFaceResource.getInstance(bum.hero.face) == null)
				{
					HeroFaceResource.createInstance(bum.hero.face);
					acts.push(new LoadHeroFaceResourceActivity(bum.hero.face));
				}
			}
			
			//loading BattleSkillResource
			for each(var action:BattleAction in getBattleActions())
			{
				var skill:BattleSkill = BattleConfigFactory.getSkill(action.param);
				if(skill != null)
				{
					for each(var rid:int in skill.resources)
					{
						if(BattleSkillResource.getInstance(rid) == null)
						{
							BattleSkillResource.createInstance(rid);
							acts.push(new LoadBattleSkillResourceActivity(rid));
						}
					}
				}
			}
			
			//loading BattleSkillResource.State
			var stateResIds:Array = [BattleDefs.STATE_POWERFULL_1, BattleDefs.STATE_POWERFULL_2];
			for each(var srid:int in stateResIds)
			{
				if(BattleSkillResource.getInstance(srid) == null)
				{
					BattleSkillResource.createInstance(srid);
					acts.push(new LoadBattleSkillResourceActivity(srid));
				}
			}
			
			return acts;
		}
		
		public function play(graphics:CanvasGraphics):void
		{
			if(_moviePlayer != null)
				_moviePlayer.stop();
			_moviePlayer = new MoviePlayer(graphics);
			_moviePlayer.load(buildMovie());
			_moviePlayer.start();
			
			/*for each(var bum:BattleUnitManager in _buManagers)
				graphics.drawBitmap(bum.getWaitBitmap(3), bum.getPaintPoint());	*/		
		}
		
		private function buildMovie():Movie
		{
			//绘制初始移动
			var movie:Movie = new Movie();
			movie.appendFrameRenderer(new BattleReportInitRenderer(this));
			
			//绘制每回合的行为
			for each(var bout:BattleBout in _battleReport.bouts)
			{
				movie.appendFrameRenderer(new BattleBoutBeginRenderer(this, bout));				
				for each(var action:BattleAction in bout.actions)
				{
					switch(action.type)
					{
						case BattleActionType.Cast:
							movie.appendFrameRenderer(new BattleBoutSkillRenderer(this, action));
							movie.appendFrameRenderer(new BattleBoutDeadRenderer(this));
							break;
						case BattleActionType.Move:
							movie.appendFrameRenderer(new BattleBoutMoveRenderer(this, action));
							break;
					}
				}
			}
			
			//绘制战斗结果
			movie.appendFrameRenderer(new BattleReportOverRenderer(this));
			return movie;
		}
		
		public function getResult():String
		{
			if(_battleReport.win)
				return "[" + _battleReport.player1 + "] 战胜了 [" + _battleReport.player2 + "]";
			else
				return "[" + _battleReport.player2 + "] 战胜了 [" + _battleReport.player1 + "]";
		}
		
		public function dispose():void
		{
			_buManagers = new Array();
		}
	}
}