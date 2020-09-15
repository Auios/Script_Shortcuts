package ScriptShortcuts
{
	function mf(%v) {moveForward(%v);}
	function mb(%v) {moveBackward(%v);}
	function ml(%v) {moveLeft(%v);}
	function mr(%v) {moveRight(%v);}
	function cr(%v) {crouch(%v);}
	function sb(%v) {clientCmdShowBricks(%v);}
	
	function cornerJump()
	{
		mb(1);
		ml(1);
		jump(1);
	}
};
activatePackage(ScriptShortcuts);