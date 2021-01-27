![](https://cdn.discordapp.com/attachments/792020806837731361/804018346231726100/Add_a_heading.png)
Hey, welcome to the VALORANT Launcher GitHub page. Thank you for checking it out, and I cannot wait to get you started. 
There are some quirks on the current release, but I am working on fixing them up.

### Set Up
Extract the file, and then just place it any folder (outside of C drive, ideally, but it works fine in C drive). Enter the relevant details. Press sign in. It will auto-fill the next time on boot. The steps to create a shortcut for it is given below.

### Quirks

 - The Username and the Password boxes are currently non-functional. They will soon see purpose when I automate the login onto the offical Riot launcher. Until then, you can type whatever you want, it will not affect functioning.
 
 - The launcher doesn't make an automatic shortcut on the desktop, so you will need to make one manually. The steps are:
 Extract the .zip and look for "launcher.exe". Right-click, press "Create a Shortcut" and place that created shortcut(It will appear in that same folder) at the path "C:\ProgramData\Microsoft\Windows\Start Menu\Programs", which will allow it to come up in the search results. Change the name to whatever you please. Then, you can search it up, and pin to Taskbar if it is convinient, or you can search for it. 
This quirk will hopefully be removed by the next release, and you will have a proper installer instead.

 - The JSON file storing the details about the username, pasword is on the D drive, so you do need to have a D drive for this to work. 
