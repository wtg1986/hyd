package Action.Core.Page
{
	public interface IGameFrame
	{
		function get currentPage():IGamePage;
		function get loadingPage():IGamePage;
		function changePage(page:IGamePage):void;
		function showDialog(page:IGameDialog):void;
		function alert(text:String):void;
	}
}