# Mario-Genetic-Algorithm-Tool

<!-- GETTING STARTED -->
## Prerequisites
* [Visual Studio 2022](https://learn.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2022) only for source Code
* [BizHawk Prerequisites](https://github.com/TASEmulators/BizHawk-Prereqs)
* [BizHawk 2.9](https://github.com/TASEmulators/BizHawk/releases/tag/2.9)

## Source Code Installation
Make sure you unzip a copy of BizHawk(full folder) on your current root project folder, ff the ExternalTools folder doesn't exist, you should create it, as shown below:
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
  
1. Build solution
2. Run EmuHawk 
3. Load Super Mario Bros ROM game (any dump for the Nintendo NES will do) on EmuHawk
3. Open the tool in the toolbar menu: Tools -> External Tools -> Mario Genetic Algorithm Tool

## Release Installation
1. Backup your BizHawk's `config.ini` file.
2. Download and unzip `GeneticAlgorithmTool.zip` from the latest release in [release packages](https://github.com/DanwRob/Mario-Genetic-Algorithm-Tool/releases) to `BizHawk/ExternalTools`, if the ExternalTools folder doesn't exist, you should create it.
3. Load Super Mario Bros ROM game (any dump for the Nintendo NES will do) on EmuHawk
3. Open the tool in the toolbar menu: Tools -> External Tools -> Mario Genetic Algorithm Tool

## Usage
### Game Actions 
Provide three movement actions list `Right only`, `Simple Movement`, and `Complex Movement`.
1. Right only: `[{None}, {Right}, {Right, A}, {Right, B}, {Right, A, B}]`
2. Simple Movement: `[{None}, {Right}, {Right, A}, {Right, B}, {Right, A, B}, {Left}]`
2. Complex Movement: `[{None}, {Right}, {Right, A}, {Right, B}, {Right, A, B}, {Left}, {Left, A}, {Left, B}, {Left, A, B}, {Up}, {Down}]`
