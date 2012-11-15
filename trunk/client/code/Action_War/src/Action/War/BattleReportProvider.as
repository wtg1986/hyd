package Action.War
{
	import Action.Core.GamePlugins;
	import Action.Core.Util.Base16;
	import Action.Core.Util.Base64;
	import Action.Core.Util.Base64_2;
	import Action.Core.Util.Random;
	import Action.Model.BattleAction;
	import Action.Model.BattleActionType;
	import Action.Model.BattleBout;
	import Action.Model.BattleEffect;
	import Action.Model.BattleEffectType;
	import Action.Model.BattleReport;
	import Action.Model.BattleUnit;
	import Action.Resource.HeroFaceResource;
	import Action.War.Config.BattleConfigFactory;
	import Action.War.Config.BattleHero;
	
	import flash.utils.ByteArray;
	import flash.utils.Endian;
	
	import mx.messaging.AbstractConsumer;

	public class BattleReportProvider
	{
		private static var _current:BattleReportProvider = null;
		public static function get current():BattleReportProvider
		{
			if(_current == null)
				_current = new BattleReportProvider();
			return _current;
		}
		
		public function BattleReportProvider()
		{
		}
		
		public function createBattleReport(text:String):BattleReport
		{
			try
			{
				//Base64_2.defaultEndian = Endian.LITTLE_ENDIAN;
				//var bytes:ByteArray = Base64_2.decodeToByteArray(text);
				var bytes:ByteArray = Base64_2.decodeToByteArray(text);
				var report:BattleReport = new BattleReport();
				report.mergeFrom(bytes);
				debugReport(report);
				return report;
			}
			catch(e:Error)
			{
				trace(e);
			}
			return null;
		}
		
		private function debugBase16(bytes:ByteArray):void
		{
			var i:int=0;
			var str:String = "";
			while(bytes.bytesAvailable)
			{
				str += "[" + i + "]:" + bytes.readUnsignedByte() + "\n";
				i++;
				if(i==100)
					break;
			}
			GamePlugins.console.writeLine(str);
			bytes.position = 0;
		}
		
		private function debugReport(report:BattleReport):void
		{
			GamePlugins.console.writeLine(JSON.stringify(report));
		}
		
		private function $(name:String):BattleHero
		{
			return BattleConfigFactory.findHero(name);
		}
		
		public function createTestReport():BattleReport
		{			
			var report:BattleReport = new BattleReport();
			report.uID = "qwerty123";			
				
			for(var i:int=10; i<60;i++)
			{
				var unit:BattleUnit = new BattleUnit();
				unit.sID = unit.pos = i;
				if(i == 12)
				{
					unit.id = $("吕布").id;
					unit.hP = 404;
				}
				else if(i == 32)
				{
					unit.id = $("曹操").id;		
					unit.hP = 322;
				}
				else if(i == 37)
				{
					unit.id = $("关羽").id;				
					unit.hP = 387;
				}
				else if(i == 33)
				{
					unit.id = $("司马懿").id;				
					unit.hP = 305;
				}
				else if(i == 39)
				{
					unit.id = $("张飞").id;
					unit.hP = 382;
				}
				else if(int(i / 10) == 3)
				{
					unit.id = 802;
					unit.hP = 220
				}
				else if(i < 20 || i > 49)
				{
					unit.id = 804;
					unit.hP = 160;
				}
				else
				{
					unit.id = 801;
					unit.hP = 280;
				}
				unit.mP = 50;
				report.units.push(unit);
			}
			
			for(i=0; i<10; i++)
			{
				unit = new BattleUnit();
				unit.sID = unit.pos = i;
				unit.id = 0;
				unit.hP = 2200;
				unit.mP = 0;
				report.units.push(unit);
			}
			
			for(i=0; i<10; i++)
			{
				unit = new BattleUnit();
				unit.sID = unit.pos = 60 + i;
				unit.id = 0;
				unit.hP = 1600;
				unit.mP = 0;
				report.units.push(unit);
			}
			
			report.bouts.push(createBout1());
			report.bouts.push(createBout2());
			
			return report;
		}
		
		private function createBout1():BattleBout
		{
			var bout:BattleBout = new BattleBout();
			bout.sID = 1;
			
			for(var i:int = 0; i<5; i++)
			{
				var action:BattleAction = new BattleAction();
				action.unitSID = 30 + i;
				action.type = BattleActionType.Cast;
				action.param = 0;
				bout.actions.push(action);
				
				if(action.unitSID == 32)
				{
					action.param = 1;
					for(var j:int=0; j<3; j++)
						addEffect(action, 26 + j, 120, 4);
					for(j=0; j<3; j++)
						addEffect(action, 31 + j, 120, 4);
				}
				else if(action.unitSID == 33)
				{
					action.param = 2;
					for(j = 0; j<3; j++)
						addEffect(action, 37 + j, 75 + j * 20);
					for(j = 0; j<3; j++)
						addEffect(action, 42 + j, 90);
					for(j = 0; j<3; j++)
						addEffect(action, 47 + j, 90);
				}
				else
					addEffect(action, 35 + i, 75);
				
				action = new BattleAction();
				action.unitSID = 35 + i;
				action.type = BattleActionType.Cast;
				action.param = 0;
				bout.actions.push(action);
				
				if(action.unitSID == 37)
				{
					action.param = 4;
					for(j = 0; j<3; j++)
						addEffect(action, 31 + j, j == 0 ? 268 : 137);
				}
				else if(action.unitSID == 39)
				{
					action.param = 5;
					for(j = 0; j<3; j++)
						addEffect(action, 24 + j * 5, j == 0 ? 277 : 232, 3);
				}
				else
					addEffect(action, 30 + i, 75);
			}
			
			for(i=0; i<2; i++)
			{
				action = new BattleAction();
				action.unitSID = 19 - i * 5;
				action.type = BattleActionType.Move;
				action.param = 24 - i * 5;
				bout.actions.push(action);
			}
			
			return bout;
		}
		
		private function createBout2():BattleBout
		{
			var bout:BattleBout = new BattleBout();
			bout.sID = 2;
			
			var action:BattleAction = new BattleAction();
			action.unitSID = 39;
			action.type = BattleActionType.Move;
			action.param = 34;
			bout.actions.push(action);			
			
			action = new BattleAction();
			action.unitSID = 19;
			action.type = BattleActionType.Cast;
			action.param = 0;
			addEffect(action, 39, 25);
			bout.actions.push(action);	
			
			action = new BattleAction();
			action.unitSID = 12;
			action.type = BattleActionType.Cast;
			action.param = 3;
			for(var j:int=0;j<3;j++)
				addEffect(action, 36 + j, 296);
			for(j=0;j<3;j++)
				addEffect(action, 41 + j, 357);
			for(j=0;j<3;j++)
				addEffect(action, 46 + j, 357);
			bout.actions.push(action);
			
			action = new BattleAction();
			action.unitSID = 14;
			action.type = BattleActionType.Cast;
			action.param = 0;
			addEffect(action, 39, 25);
			addEffect(action, 69, 235);
			bout.actions.push(action);	
			
			return bout;
		}
		
		private function addEffect(action:BattleAction, unitSID:int, hurt:int, type:int=-1):void
		{
			var effect:BattleEffect = new BattleEffect();
			effect.unitSID = unitSID;
			effect.type = type < 0 ? Random.generate(0, 3) : type;
			var num:Number = effect.type < 4 ? effect.type / 2 : -1;
			effect.plusHP = -int(Random.generate(hurt, hurt * 1.2) * num);
			effect.plusMP = 5;
			effect.buffId = 0;
			action.effects.push(effect);
		}
	}
}