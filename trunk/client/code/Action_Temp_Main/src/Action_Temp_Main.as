package
{
	import animation.template.UnitAnimationTemplate;
	
	import flash.display.Bitmap;
	import flash.display.BitmapData;
	import flash.display.Sprite;
	import flash.display.StageScaleMode;
	import flash.events.Event;
	
	import res.ResLoaderManager;
	import res.data.ConfigDataManager;
	import res.event.ConfigDataCompleteEvent;
	import res.vo.ResXmlVO;
	
	[SWF(backgroundColor="#000000", frameRate="30", width="800", height="600", pageTitle="ActionTemp")]
	public class Action_Temp_Main extends Sprite
	{
		public function Action_Temp_Main()
		{
			this.stage.scaleMode = StageScaleMode.NO_SCALE;
			
			ConfigDataManager.getInstance().initConfigData();
			ConfigDataManager.getInstance().addEventListener(ConfigDataCompleteEvent.NAME, configDataComplete);
		}

		private function configDataComplete(event:ConfigDataCompleteEvent):void
		{
			
		}
		
		private function enterFrameProcess(event:Event):void
		{
			
		}
	}
}