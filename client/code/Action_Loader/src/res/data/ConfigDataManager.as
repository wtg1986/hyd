package res.data
{
	import flash.events.EventDispatcher;
	
	import res.ResLoaderManager;
	import res.data.animation.XmlActionDataModule;
	import res.data.animation.XmlAnimationDataModule;
	import res.data.animation.action.ActionUnitConfig;
	import res.data.animation.bitmap.AnimationConfigVO;
	import res.data.map.BattleMapConfig;
	import res.data.map.SceneMapConfig;
	import res.data.map.XmlBattleMapDataModule;
	import res.data.map.XmlSceneMapDataModule;
	import res.data.res.ResUrlVO;
	import res.data.res.XmlResDataModule;
	import res.data.unit.UnitConfigVO;
	import res.data.unit.XmlUnitDataModule;
	import res.enum.LoaderTypeEnum;
	import res.event.ConfigDataCompleteEvent;
	import res.event.ResXmlLoadEvent;
	import res.vo.ResXmlVO;

	public class ConfigDataManager extends EventDispatcher
	{
		public static const CONFIG_URL:String = "assets/xml/configURL.xml";
		
		private static var _instance:ConfigDataManager;
		public static function getInstance():ConfigDataManager
		{
			if(!_instance)
			{
				_instance = new ConfigDataManager();
			}
			
			return _instance;
		}
		
		private var _preloadConfigXmlList:Array = 
			[
				ConfigUrlEnum.RES_URL,
				ConfigUrlEnum.ANIMATION_CONFIG,
				ConfigUrlEnum.ACTION_CONFIG,
				ConfigUrlEnum.UNIT_CONFIG,
				ConfigUrlEnum.SCENE_MAP_CONFIG,
				ConfigUrlEnum.BATTLE_MAP_CONFIG
			];
		
		private var _configUrlList:Array;
		public function get configUrlList():Array
		{
			return this._configUrlList;
		}
		
		public function ConfigDataManager()
		{
			this._configUrlList = new Array();
		}
		
		public function initConfigData():void
		{
			ResLoaderManager.getInstance().loadXmlByURL(CONFIG_URL, false, configUrlLoadComplete);
		}
		
		private function configUrlLoadComplete(configUrlXmlVO:ResXmlVO):void
		{
			var configUrlXml:XML = configUrlXmlVO.xmlData;
			
			this._configUrlList = new Array();
			for each(var urlXml:XML in configUrlXml.ConfigUrlVO)
			{
				var configUrlVO:ConfigUrlVO = new ConfigUrlVO();
				configUrlVO.initByXML(urlXml);
				
				this._configUrlList.push(configUrlVO);
			}
			
			this.startLoadConfigData();
		}
		
		private function startLoadConfigData():void
		{
			if(this._configUrlList)
			{
				ResLoaderManager.getInstance().addEventListener(ResXmlLoadEvent.NAME, configXmlLoadComplete);
				
				for(var i:int = 0; i < this._configUrlList.length; i++)
				{
					var configUrlVO:ConfigUrlVO = this._configUrlList[i] as ConfigUrlVO;
					switch(configUrlVO.type)
					{
						case LoaderTypeEnum.LOADER_TYPE_XML:
							ResLoaderManager.getInstance().loadXmlByURL(configUrlVO.url, false, null, configUrlVO);
							break;
						
						default:
							break;
					}
				}
			}
		}
		
		private function configXmlLoadComplete(event:ResXmlLoadEvent):void
		{
			var loadedResXmlVO:ResXmlVO = event.resXmlVO;
			if(loadedResXmlVO.passData && loadedResXmlVO.passData is ConfigUrlVO)
			{
				switch(ConfigUrlVO(loadedResXmlVO.passData).configName)
				{
					case ConfigUrlEnum.RES_URL:
						XmlResDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
					
					case ConfigUrlEnum.ANIMATION_CONFIG:
						XmlAnimationDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
					
					case ConfigUrlEnum.ACTION_CONFIG:
						XmlActionDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
					
					case ConfigUrlEnum.UNIT_CONFIG:
						XmlUnitDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
					
					case ConfigUrlEnum.SCENE_MAP_CONFIG:
						XmlSceneMapDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
					
					case ConfigUrlEnum.BATTLE_MAP_CONFIG:
						XmlBattleMapDataModule.getInstance().initModule(loadedResXmlVO.xmlData);
						break;
				}
				
				if(checkXmlLoadComplete(ConfigUrlVO(loadedResXmlVO.passData).configName))
				{
					this.dispatchEvent(new ConfigDataCompleteEvent());
				}
			}
		}
		
		private function checkXmlLoadComplete(urlName:String):Boolean
		{
			for(var i:int = 0; i < this._preloadConfigXmlList.length; i++)
			{
				if(this._preloadConfigXmlList[i] == urlName)
				{
					this._preloadConfigXmlList.splice(i, 1);
					break;
				}
			}
			
			if(this._preloadConfigXmlList.length == 0)
			{
				return true;
			}
			
			return false;
		}
		
		public function getResUrlVOByResClass(resClass:String):ResUrlVO
		{
			return XmlResDataModule.getInstance().getResUrlVOByResClass(resClass);
		}
		
		public function getAnimationConfigVOByType(animationType:String):AnimationConfigVO
		{
			return XmlAnimationDataModule.getInstance().getAnimationConfigVOByType(animationType);
		}
		
		public function getActionUnitConfigByClass(actionClass:String):ActionUnitConfig
		{
			return XmlActionDataModule.getInstance().getActionUnitConfigByClass(actionClass);
		}
		
		public function getUnitConfigVOByUnitId(unitId:int):UnitConfigVO
		{
			return XmlUnitDataModule.getInstance().getUnitConfigVOByUnitId(unitId);
		}
		
		public function getSceneMapConfigById(mapId:int):SceneMapConfig
		{
			return XmlSceneMapDataModule.getInstance().getSceneMapConfigById(mapId);
		}
		
		public function getBattleMapConfigById(mapId:int):BattleMapConfig
		{
			return XmlBattleMapDataModule.getInstance().getBattleMapConfigById(mapId);
		}
	}
}