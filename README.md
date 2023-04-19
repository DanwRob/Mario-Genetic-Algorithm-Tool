# Mario-Genetic-Algorithm-Tool

<!-- GETTING STARTED -->
## Prerequisites
* [Visual Studio 2022](https://learn.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2022)
* [BizHawk Prerequisites](https://github.com/TASEmulators/BizHawk-Prereqs)
* [BizHawk 2.9](https://github.com/TASEmulators/BizHawk/releases/tag/2.9)

## Installation
Make sure you unzip a copy of BizHawk(full folder) on your current root project folder as shown below:
 ```sh
  Mario-Genetic-Algorithm-Tool
  ├─ BizHawk
  │   ├─ dll
  │   │   ├─ BizHawk.Common.dll
  │   │   └─ ... (other stuff)
  │   ├─ ExternalTools
  │   │   └─ ... (probably empty)
  │   ├─ EmuHawk.exe
  │   └─ ... (other stuff)
  └─ src
  │   └─ GeneticAlgorithmTool.csproj
  └─ .gitignore
  │
  └─ README.md
  ```
  If the ExternalTools folder doesn't exist, you should create it.
<!-- USAGE EXAMPLES -->
## Usage
1. Build solution
2. Run EmuHawk 
3. Open the tool in the toolbar menu: Tools -> External Tools -> Mario Genetic Algorithm Tool
