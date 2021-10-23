[CmdletBinding()]
param (
    [Parameter(Mandatory = $true)]
    [ValidateNotNullOrEmpty()]
    [String]
    $packageName,
    [Parameter(Mandatory = $false)]
    [ValidateNotNullOrEmpty()]
    [String]
    $openApiFile="OpenAPI.yaml",
    [Parameter(Mandatory = $false)]
    [String]
    $oagCliPath = ""

)
$oagCommand = "openapi-generator-cli"
if ($oagCliPath -ne $null -and $oagCliPath -ne "") {
    $oagCommand = "$oagCliPath/openapi-generator-cli"
}

$currentLocation = Get-Location

Invoke-Expression "$oagCommand generate -i $currentLocation\docs\api\$openApiFile -g aspnetcore -o $currentLocation\ --package-name $packageName --additional-properties=aspnetCoreVersion=5.0 --additional-properties=operationIsAsync=true --additional-properties=nullableReferenceTypes=true --additional-properties=newtonsoftVersion=5.0.0" 
