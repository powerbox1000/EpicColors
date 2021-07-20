<h1 align="center">EpicColors</h1>
<p align="center">Add custom colors into your Among Us game!</p>

<p align="center">Discord: https://discord.gg/cHDxA93fGc <br/>
Youtube: https://www.youtube.com/channel/UCy4h9UsVcoQV_QU5ew_NeiQ/ <br/>
GitHub: https://github.com/Devs-Us</p>

<p align="center"><img src="https://user-images.githubusercontent.com/82711525/126036715-381947aa-0853-44dc-8da5-5e3cc4122787.gif" alt="BetterColours" width="600" /></p>

<h2 align="center">Which colors were added?</h2>

### Normal colors
|   |   |   |   |
|:-:|:-:|:-:|:-:|
| Acid Green | Aqua Blue | Blood Red | Chocolate |
| Flame | Crimson | Gold | Mint |
| Lavender | Egyptian Blue | Jungle Green | Light Pink |
| Panda | Mustard | Blurple | Navy Blue |
| Midnight Blue | Olive | Peach | Lapis Lazuli |
| Silver | Cadmium Yellow | Brazilwood | Mummybrown |
| Quercitron | Cochineal |  |  |

### Special colors
|   |   |
|----------|-------------|
| Rainbow | Seasonal |

<h2 align="center">Adding your own color (Beta)</h2>

EpicColors allows you to configure additional colors to the game as simple as creating a txt file!\
To get started, make sure you have `CustomColors.txt` file inside your Among Us game directory

#
### Adding colors
- Give a name for your color. If you want to add spaces in your color's name, just use _ to represent them.

      name;Acid_Green
- You are required to have RGB pattern of your custom color to add one. use `main;r,g,b` to specify crewmate's color. 
Here's the example with Red:124 Green:155 and Blue:10

      main;124,155,10
- The shadow of the crewmate will be automatically generated by decreasing the main color by 40%. However, if you wish to put custom RGB for your color's shadow, you can use `shadows;r,g,b` like the example below.

      shadows;101,116,10

#
### Optional options
- Add yourself as an author while in the lobby by using `author;<whatever you want to put under the ping in the lobby>`.

      author;Colors provided by SideSxope
    
- Remove colors that is shipped with EpicColors by using `removeBuiltIn;`
#
Here's an example of a full content of `CustomColors.txt` file

    author;Innersloth (Glitched Colors)

    name;Fortegreen main;29,152,83
    name;SunBurn main;241,247,63 shadow;241,42,47

and TADAA! 
<p align="left"><img src="https://user-images.githubusercontent.com/82711525/126036324-7363d5a9-6893-44b1-8df2-9f86dd746e9d.png" alt="PlayerTab" width="400" />
<img src="https://user-images.githubusercontent.com/82711525/126036369-477859f2-c03a-41ed-b975-353577f45e2c.png" width="400" /></p>

If you add the parameter `removeBuiltIn;`, the built in colors that is shipped with our mod will get excluded! Here's the preview:

<p align="left"><img src="https://user-images.githubusercontent.com/82711525/126036454-915ef977-3be8-48b0-a279-2aca9e85ac04.png" alt="PlayerTab" width="400" />


#
<p align="center">This mod is not affiliated with Among Us or Innersloth LLC, and the content contained therein is not endorsed or otherwise sponsored by Innersloth LLC. Portions of the materials contained herein are property of Innersloth LLC.</p>
<p align="center">© Innersloth LLC.</p>
