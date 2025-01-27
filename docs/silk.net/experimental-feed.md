---
{
    "TableOfContents": {
        "Name": "Experimental Feed",
        "Url": "experimental-feed.html"
    }
}
---

# Experimental Feed

> [!WARNING]
> The experimental feed is not recommended for use for anything beyond playing around with the new features. We don't officially support these builds as they may be unstable, and should not be used in production.

> [!NOTE]
> Changes in the experimental feed happen rapidly. We recommend joining the [Silk.NET Discord server](https://discord.gg/DTHHXRt) so that you can keep up with development.

## Configure your project

Right now, your project should look something like this:

```xml
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Silk.NET" Version="1.4.0" />
  </ItemGroup>

</Project>
```

In order to use the experimental feed, you must change this project file slightly. Add the following line to your project:

```xml
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <!-- Add the experimental feed as a restore source -->
    <RestoreAdditionalProjectSources>$(RestoreAdditionalProjectSources);https://dotnet.github.io/Silk.NET/nuget/experimental/index.json</RestoreAdditionalProjectSources>
  </PropertyGroup>
```

## Install an experimental version

Now .NET has access to the experimental feed, it's time to install an experimental package. Check for the latest version on our [GitLab Package Registry](https://gitlab.com/silkdotnet/Silk.NET/-/packages).

At the time of writing, the latest version is `2.0.0-build97.0`. Now to install this package, you can use your IDE's built-in NuGet client, `dotnet package add`, or just modify the project file again like so:

```xml
  <ItemGroup>
    <PackageReference Include="Silk.NET" Version="2.0.0-build97.0" />
  </ItemGroup>
```


> [!WARNING]
> Experimental Feed builds may be deleted without warning at the Silk.NET team's discretion.

Now you have access to bleeding-edge experimental builds of Silk.NET. Have fun!
