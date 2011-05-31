function Update-PackageVersion
{
    param(
        [parameter(Mandatory=$true)]
        [ValidatePattern("\d\.\d\.\d\.\d{8}|\d\.\d")]
        [string]$version,
        
        [parameter(Mandatory=$true)]
        [ValidateScript({Test-Path $_ -PathType Leaf})]
        [string]$specPath
    )
  
    $spec = [xml] (Get-Content $specPath)

    $spec.Package.Metadata.Version = $version
    $spec.Save($specPath)
	
    Write-Output "ErrorCode=0"
}