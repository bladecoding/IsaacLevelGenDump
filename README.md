This is the code I used to generate floors in isaac for dumping.

isaac-ng.exe needs to be modified to load IsaacLevelGenDump.dll.
After that you can use runner.linq to continuously start isaac.
There is a memory leak in isaac which is why the process is restarted every 30k floors.