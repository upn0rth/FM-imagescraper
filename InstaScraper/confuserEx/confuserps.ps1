param (
[string]$ConfuserPath,
[string]$ConfuserConfigurationFile,
[string]$OutputDir,
[string]$ModuleName,
[string]$Preset
)

function replace-file-content([string] $path, [string] $replace, [string] $replaceWith)
{
    (Get-Content $path) |
    Foreach-Object {$_ -replace $replace,$replaceWith}|
    Out-File $path
}

$ConfuserPath = $ConfuserPath.Substring(1,$ConfuserPath.Length-2)
$ConfuserConfigurationFile = $ConfuserConfigurationFile.Substring(1,$ConfuserConfigurationFile.Length-2)
$OutputDir = $OutputDir.Substring(1,$OutputDir.Length-2)
$ModuleName = $ModuleName.Substring(1,$ModuleName.Length-2)
$Preset = $Preset.Substring(1,$Preset.Length-2)


# Let's first copy the configuration file to a temporary directory
echo "Obfuscating..."
$tempFile = [string]::Concat($OutputDir, "confuser.temp.crproj")
echo "Copying " $ConfuserConfigurationFile " to " $tempFile
Copy-Item $ConfuserConfigurationFile -Destination $tempFile

echo "Replacing placeholders..."
replace-file-content $tempFile "{OutputDir}" $OutputDir
replace-file-content $tempFile "{ModuleName}" $ModuleName
replace-file-content $tempFile "{Preset}" $Preset


echo "Performing Obfuscation..."
$parameter = [string]::Concat("""",$tempFile,"""")
$ConfuserPath = [string]::Concat("""",$ConfuserPath,"""")
echo $parameter
#start-process -wait "C:\Programs\ConfuserEx\Confuser.CLI.exe" "$parameter"
start-process -NoNewWindow -wait "$ConfuserPath" "$parameter"
echo "Obfuscation complete."
