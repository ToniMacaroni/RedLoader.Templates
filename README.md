# RedLoader mod templates
A collection of templates for creating mods for the [RedLoader](https://github.com/ToniMacaroni/RedLoader) and Sons of the Forest.

## How to use
1. Install the template using `dotnet new install RedLoader.Templates`
2. Create a new project using `dotnet new sotfmod -n {ModName} -g {GameDir} -o {OutputDir}`

**Example**
```sh
dotnet new install RedLoader.Templates
dotnet new sotfmod -n MyMod -g "F:\SteamLibrary\steamapps\common\Sons Of The Forest" -o MyMod
```