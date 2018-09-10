<Query Kind="Statements" />

var dumpDir = @"levelgen\dump";
var isaacPath = @"levelgen\isaac-ng-levelgen.exe";

var isaacDir = Path.GetDirectoryName(isaacPath);
var isaacExe = Path.GetFileNameWithoutExtension(isaacPath);

while (true)
{
	Thread.Sleep(5000);
	var fileCount = new DirectoryInfo(dumpDir).GetFiles().Length;
	if (fileCount > 334)
		return;

	var existing = Process.GetProcessesByName(isaacExe);
	if (existing.Length < 1)
	{
		var newProc = new Process();
		newProc.StartInfo = new ProcessStartInfo 
		{
			Arguments = "--set-stage-type=0 --set-stage=1 --load-room=instapreview.xml --luadebug",
			WindowStyle = ProcessWindowStyle.Hidden,
			WorkingDirectory = isaacDir,
			FileName = isaacPath,	
			CreateNoWindow = true,
		};
		newProc.Start();
		"Started new proc".Dump();
	}
}