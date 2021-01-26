# ValorantLauncher
A VALORANT Launcher written in C#.

### How to set up.
Extract the file, and then just place it any folder (outside of C drive, ideally, but it works fine in C drive). The steps to link the .lnk is just enter "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Riot Games". And press sign in. It will auto-fill the next time on boot. The steps to create a shortcut for it is given below.

### Quirks in the current Alpha release of the VALORANT launcher:
--> The JSON file storing the details about the username, pasword and the path to the VALORANT.lnk is on the D drive, so you do need to have a D drive for this to work. 

--> The launcher doesn't make an automatic shortcut on the desktop, so you will need to make one manually. The steps are:

Extract the .zip and look for "launcher.exe". Right-click, press "Create a Shortcut" and place that created shortcut(It will appear in that same folder) at the path "C:\ProgramData\Microsoft\Windows\Start Menu\Programs", which will allow it to come up in the search results. Change the name to whatever you please. Then, you can search it up, and pin to Taskbar if it is convinient, or you can search for it. 
This quirk will hopefully be removed by the next release, and you will have a proper installer instead.

--> The launcher does not automatically detect the game .lnk.

This is a very minor thing that I'll be able to solve by the next release. Now, for the Program Path, just enter "C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Riot Games", and it will do the rest.

--> The Username and the Password boxes are currently non-functional. They will soon see purpose when I automate the login onto the offical Riot launcher. Until then, you can type whatever you want, it will not affect functioning.

Thank you for downloading, and I do hope you enjoy!
