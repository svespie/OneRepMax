# OneRepMax
A one repetition maximum (often abbreviated 1RM) identifies a weight that a weight lifter can lift only once for a given movement, such as the bench press. This value is often calculated based on strength testing where the lifter lifts a sub-maximal weight for as many repetitions as possible.

It turns out that there are a number of different ways to calculate a 1RM, as depicted on Wikipedia: https://en.wikipedia.org/wiki/One-repetition_maximum. *OneRepMax* provides a calculator to calculate a 1RM based on these formulas. The formulas are implemented as strategies that make it easier to test and you may even provide your own.

There is a JavaScript version of this library that can be found here: http://svespie.github.io/onerepmax-js/.

There is also an angular 1.x module based on the JavaScript version of this library that can be found here: http://svespie.github.io/angular-onerepmax/.

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

*May 4, 2017* - May the 4th be with you! :)

Applied a strategy pattern to represent the various formulas. This simplified the calculator, bringing it to having a single responsibility. It also closed the calculator to modification and opened it to extension. The calculator as a dependency is now much easier to mock for testing and client code may even supply their own formula (strategy), if they so choose.

I dropped the enumeration representing the formulas as well as the average method. I loved the convenience of these, but I'm taking a purist approach to design with this project.

The tests and demo have been updated, however the tests confirming formula functionality are basically based on the previous tests. These tests take a dependency on two objects instead of simply determining if the formula is applied correctly. I'll look at fixing this when I change the testing framework.

Also, I believe any further changes to the library will not be radical, so the NuGet package should be updated soon as well.

Finally, I've re-ordered the TODO list and added a new item. These updates and TODO notes should probably find themselves on the WIKI to keep the readme tidy and to the point.


## TODO
* Change the testing framework to use xunit.
* Update the NuGet package.
* Change the demo application to a console application.
* Determine if it is feasible or even valuable to make this C# version of the library available via npm.
* Move the updates and TODO notes to the repo's wiki.
