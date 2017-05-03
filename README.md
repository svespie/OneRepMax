# OneRepMax
A one repetition maximum (often abbreviated 1RM) identifies a weight that a weight lifter can lift only once for a given movement, such as the bench press. This value is often calculated based on strength testing where the lifter lifts a sub-maximal weight for as many repetitions as possible.

It turns out that there are a number of different ways to calculate a 1RM, as depicted on Wikipedia: https://en.wikipedia.org/wiki/One-repetition_maximum. *OneRepMax* simply compiles these formulas into a C# library. In addition to the seven formulas listed in the Wikipedia entry, *OneRepMax* also provides functionality to average all of the formula.

There is a JavaScript version of this library that can be found here: http://svespie.github.io/onerepmax-js/.

There is also an angular 1.x directive based on the JavaScript version of this library that can be found here: http://svespie.github.io/angular-onerepmax/.

## Installation
There is a NuGet package that contains just the library code and that can be imported into your application via Visual Studio in the usual way. 

The direct link to the NuGet package can be found here: https://www.nuget.org/packages/OneRepMax/.

**Note: The NuGet package and the source hosted on this GitHub repo are not in sync.**


### Visual Studio Package Manager Console
From the Package Manager Console, enter the following command: 

```
PM> Install-Package OneRepMax
```

This will automatically install the OneRepMax library assembly and create a reference to it in your project.


### Visual Studio Package Manager GUI
Note, these instructions may vary slightly depending on the version of Visual Studio you are using. If necessary, please consult the documentation to your version of Visual Studio for assistance on how to open and navigate the NuGet Package Manager GUI.

Right click on your project and select "Manage NuGet Packages...". Under Browse, search for OneRepMax.

There are multiple versions of this library. I would recommend you take latest, but feel free to pull down whichever version you like.

Note: I'll only address issues on the latest version, so please keep that in mind when deciding to take an older version.


### Manual Installation
Alternatively, you are free to download the source to use as you see fit. If you want to run the unit tests, this is currently your only option.

**Note: If you want the latest source code available, this is also your only option at the moment.**


## Updates
*May 3, 2017* - Removed the static modifier to the Calculate class and provided a layer of abstraction. The class was also renamed. More work on this is needed.

NuGet package has not been updated. This is a breaking change and the rest of the planned changes will also be breaking changes; I'll update the NuGet package after the re-design.


## TODO
* Apply the Open/Closed and Single Responsibility principles by implementing a strategy pattern.
* Change the testing framework to use xunit.
* Change the demo application to a console application.
* Update the NuGet package.
* Determine if it is feasible or even valuable to make this C# version of the library available via npm.
