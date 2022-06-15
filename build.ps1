[CmdletBinding()]
Param (
    [switch]$CI, 
    [switch]$NoClean,
    [switch]$NoTest
    )

./build-dotnet `
    -SourceDirectory src `
    -ProjectName BoulesScore `
    -CI:$CI `
    -NoClean:$NoClean `
    -NoTest:$NoTest

