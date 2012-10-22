package battle.army
{
	import battle.enum.BattleUnitTypeEnum;
	import battle.interfaces.IBattleUnit;
	import battle.unit.FootBattleUnit;
	import battle.unit.GeneralBattleUnit;
	
	import res.data.unit.UnitConfigVO;

	public class BattleArmy
	{
		private var _armyMaxSize:int;
		public function get armyMaxsize():int
		{
			return this._armyMaxSize;
		}
		
		private var _currentArmySize:int;
		public function get currentArmySize():int
		{
			return this._currentArmySize;
		}
		
		public function BattleArmy()
		{
			this._armyMaxSize = 0;
			this._currentArmySize = 0;
		}
		
		public function createBattleArmy(armySize:int):void
		{
			if(armySize > 0)
			{
				this._armyMaxSize = armySize;
			}
		}
		
		public function createNewUnit(unitConfigVO:UnitConfigVO, unitType:String):Boolean
		{
			if(this._currentArmySize < this._armyMaxSize)
			{
				switch(unitType)
				{
					case BattleUnitTypeEnum.BATTLE_UNIT_TYPE_FOOT:
						var footUnit:FootBattleUnit = new FootBattleUnit();
						footUnit.initBattleUnit(unitConfigVO);
						break;
					
					case BattleUnitTypeEnum.BATTLE_UNIT_TYPE_GENERAL:
						var generalUnit:GeneralBattleUnit = new GeneralBattleUnit();
						generalUnit.initBattleUnit(unitConfigVO);
						break;
				}
			}
			
			return false;
		}
	}
}