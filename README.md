# FocusPreventer
 Prevent windows from getting focus when clicking
![Screenshot](https://raw.githubusercontent.com/Ingan121/FocusPreventer/master/scrsht.png)

## What you can do with this
* Use Rainmeter (or any other application, untested yet) as a gaming overlay for fullscreen games.
  * Requires [UIAccess patch + resigning with a self-signed certificate](https://github.com/Ingan121/FocusPreventer/blob/master/UIAccessPatch.md).
  * The above process makes them appear on top of fullscreen games; this program just makes it possible to interact with them without minimizing the game.
  * Textboxes may not work.
  * Must be using the enhanced fullscreen mode in Windows 10. Real fullscreen exclusive mode makes UI invisible (but still clickable.)
  * If the game doesn't release the mouse lock without minimizing, you need to get help from other overlay programs like Xbox Game Bar, Steam, Uplay, Overwolf, etc.
  ![Screenshot](https://raw.githubusercontent.com/Ingan121/FocusPreventer/master/gamingoverlay2.png)
  
 ## Command-line arguments
 * FocusPreventer.exe /class (class)
 * FocusPreventer.exe /title (title)
 * FocusPreventer.exe /both (class) (title)
