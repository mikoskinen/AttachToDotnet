# Attach to dotnet.exe

Extension for Visual Studio 2017/2019 which makes it easier to attach to the correct dotnet.exe process.

## Features

This extensions adds two commands to Visual Studio:

* Attach to dotnet.exe. The dialog provides a clear view of different running .NET Core applications. 
* Reattach to the previous dotnet.exe process. Useful for scenarios where dotnet watch is used as the process id is changed everytime the code is compiled.