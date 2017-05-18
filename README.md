# pluginchecker-rust
A rough windows form application used when figuring out which rust plugins need to be updated. It's rough and does the job, feel free to improve, edit etc

![Plugin Image](https://puu.sh/vU9Pc/e72519c667.png)

We encountered an issue where there was a bunch of plugins on the server that would get updated and it was tedious to track. The large number of plugins and the constant updates and changes to the game caused a lot of overhead when fixing/updating plugins on the server. The solution was...

* Creating a meta file with the plugin name and url link to the plugins oxide webpage
* The current server version of the plugin info was aquired by typing "plugins" into the console
* Using this url the oxide webpage gets scraped for the version number
* Finally everything is displayed 

**The meta file must follow the following format and be of file type .json**

```
{
	"PluginList":[
		{
			"name": "Airstrike",
			"link": "http://oxidemod.org/plugins/airstrike.1489/"
		},
		{
			"name": "AutomaticAuthorization",
			"link": "http://oxidemod.org/plugins/automaticauthorization.2063/"
		},
		{
			"name": "Player corpse duration modifier",
			"link": "http://oxidemod.org/plugins/player-corpse-duration-modifier.778/"
		},
		{
			"name": "Death Notes",
			"link": "http://oxidemod.org/plugins/death-notes.819/"
		},
		{
			"name": "Entity Owner",
			"link": "http://oxidemod.org/plugins/entityowner.1255/"
		},
		{
			"name": "FancyDrop",
			"link": "http://oxidemod.org/plugins/fancydrop.1934/"
		},
		{
			"name": "Finder",
			"link": "http://oxidemod.org/plugins/finder.692/"
		}
	]
}
```

**Sample Console Plugin Data**

```
01 "Airstrike" (0.2.51) by k1lly0u (0.72s)
02 "AutomaticAuthorization" (0.1.8) by k1lly0u (0.00s)
03 "Player corpse duration modifier" (2.0.4) by Mughisi (4.48s)
04 "Death Notes" (5.2.9) by LaserHydra (3.35s)
05 "DoomChat" (2.0.3) by SoftDevAndy & wski (2.27s)
06 "DoomTownDoom" (1.0.0) by wski (0.08s)
07 "DoomTownStore" (1.0.0) by wski (0.00s)
08 "Entity Owner" (3.1.1) by rustservers.io (0.01s)
09 "FancyDrop" (2.6.10) by Fujikura (27.48s)
10 "Finder" (3.0.4) by Reneb (0.04s)
11 "Fishing" (1.2.2) by Colon Blow (0.49s)
12 "FriendlyFire" (2.0.3) by Nogrod (2.44s)
13 "Friends" (2.1.2) by Nogrod (0.06s)
```

# Attribution & Libraries

* [HtmlAgilityPack](https://www.nuget.org/packages/HtmlAgilityPack/)
* [NewtonSoft Json Parser](https://www.nuget.org/packages/newtonsoft.json/)
