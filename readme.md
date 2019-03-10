# Attach to dotnet.exe

Extension for Visual Studio 2017/2019 which makes it easier to attach to the correct dotnet.exe process.

## Features

This extensions adds two commands to Visual Studio:

* Attach to dotnet.exe. The dialog provides a clear view of different running .NET Core applications. 
* Reattach to the previous dotnet.exe process. Useful for scenarios where dotnet watch is used as the process id is changed everytime the code is compiled.

## Screenshots

### With the extension

![Attach to dotnet.exe extension](https://github.com/mikoskinen/AttachToDotnet/raw/master/docs/WithExtension.png "Attach to dotnet.exe extension")

### Without the extensions

![Attach to dotnet.exe without extension](https://github.com/mikoskinen/AttachToDotnet/raw/master/docs/WithoutExtension.png "Attach to dotnet.exe without extension")
