$binDirectory = "..\bin\Release\"
$net472Directory = $binDirectory + "net472\";
$namedDirectory = $binDirectory + "MoreFontSizes\";
$zipLocation = "..\MoreFontSizes.zip";

Rename-Item -Path $net472Directory -NewName "MoreFontSizes";
Compress-Archive -LiteralPath $namedDirectory -DestinationPath $zipLocation -Update;
Rename-Item -Path $namedDirectory -NewName "net472";