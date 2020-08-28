# UIAccess Patch Guide
* This patch enables UIAccess mode which allows super-topmost mode.
* Super-topmost mode allows the patched program to stay on top of almost all windows, including immersive(10) / metro(8) UI, fullscreen UWP/metro app, and games in [optimized fullscreen mode](https://devblogs.microsoft.com/directx/demystifying-full-screen-optimizations/).

## Notice
* This is not guaranteed to work in all programs.
* DRMed programs are likely not to work.
* If the patched program has a native title bar, the game could detect the window even when not focused and minimize itself.

### Tested working properly
* [Rainmeter](https://www.rainmeter.net/)
* [AutoHotkey](https://www.autohotkey.com/)
* [Process Explorer](https://docs.microsoft.com/en-us/sysinternals/downloads/process-explorer)

### Tested not working properly
* [8GadgetPack](https://8gadgetpack.net/)

## Requirements
* Make sure the executable is located in one of these locations: C:\Program Files, C:\Program Files (x86), C:\Windows.
* [Resource Hacker](http://www.angusj.com/resourcehacker/)
* [Self-signing tools](https://github.com/Ingan121/files/raw/master/SelfSignTool.zip)
 
## Instructions
1. Launch Resource Hacker and open the executable to patch.
2. Expand Manifest and click the only item there.
3. Find (Ctrl+F) uiAccess="false" and replace it with uiAccess="true".
4. Click the green play icon on the toolbar or press the F5 key.
5. Select File → Save As... and save it on your desktop.
6. Unzip the self-signing tools and follow the readme.txt there for the executable on your desktop.
7. Rename the original executable in the original folder.
8. Finally, move the patched executable in your desktop to the original folder.
9. Launch the patched program, find for "Always On Top" option (Rainmeter: right-click the widget → Settings → Position → Topmost), then enable it.
10. If there is no such option, use any "Always On Top" program. (just google for it)
11. Use this FocusPreventer program to prevent the patched programs from getting focus on click, if you want to interact with the program in fullscreen games or such.

## Reference
[Windows 8 Layered Windows Over Metro Apps - Stack Overflow](https://stackoverflow.com/a/13497452)
