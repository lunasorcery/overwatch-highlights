A rough and messy attempt at reverse-engineering the file format used by the new Highlights feature in Overwatch 1.13 (currently only on the Public Test Region). I've covered the code in dozens of asserts in an attempt to catch any unexpected data. Thus far I've nailed down most of the header structures - very little progress on the actual raw replay data yet. If you run this on your highlight data and one of the asserts fails, consider sending me the highlight file that broke it! The more test data I have access to, the better :)

To use:  
Capture some highlights on Overwatch 1.13+ (PTR only as I write this).  
This will create highlight files in ``%localappdata%/Blizzard Entertainment/Overwatch/<playerid>/Highlights``  
Run this tool without any arguments and it'll dump anything it can from that folder.  
The tool can optionally take paths to specific files/folders you want to inspect.

Notes:  
The game will only load highlights that were created on the current build, if it detects old data it will wipe them. I've taken the precaution of backing up all of my highlight data, you may wish to do the same if you're also investigating this stuff.