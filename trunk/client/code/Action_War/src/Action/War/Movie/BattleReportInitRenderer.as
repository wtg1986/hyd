package Action.War.Movie
{
	import Action.Core.GamePlugins;
	import Action.Display.Drawing.CanvasGraphics;
	import Action.Display.Drawing.IMovieFrameRenderer;
	import Action.Display.Drawing.MoviePlayer;
	import Action.War.BattleDefs;
	import Action.War.BattleHelper;
	import Action.War.Report.BattleReportManager;
	import Action.War.Report.BattleUnitManager;
	
	import flash.geom.Point;
	
	public class BattleReportInitRenderer extends MovieFrameRendererBase implements IMovieFrameRenderer
	{		
		public function BattleReportInitRenderer(reportMgr:BattleReportManager)
		{
			super(reportMgr);
			for each(var bum:BattleUnitManager in _battleReportManager.getBUMS())
			{
				if(bum.isWall)
					continue;
				var offset:int = bum.getInitOffset();
				bum.tempPoint =  BattleHelper.getPaintPoint(bum.POS + offset);
				//graphics.draw(unitMgr.getWaitBitmap(i),	unitMgr.paintPoint);
			}
		}
		
		public function get description():String
		{
			return "战斗开始";
		}
		
		public override function enter(graphics:CanvasGraphics):void
		{
			graphics.container.bindPlayers(_battleReportManager.player1, _battleReportManager.player2);
		}
		
		public function render(graphics:CanvasGraphics):void
		{
			for each(var bum:BattleUnitManager in _battleReportManager.getBUMS())
			{
				if(bum.isWall)
					continue;
				var idx:int = _moviePlayer.currentFrame % 2;
				bum.tempPoint.x += bum.speed;
				if(graphics.contains(bum.tempPoint))
					graphics.drawBitmap(bum.getMoveBitmap(idx), bum.tempPoint);
			}
		}
		
		public function getFrameLength():int
		{
			return BattleDefs.INIT_POS_OFFSET * 10 / BattleDefs.MOVE_POS_OFFSET;
		}
	}
}