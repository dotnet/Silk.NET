// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Versioning;
using Microsoft.VisualStudio.Setup.Configuration;

namespace SilkTouchX.Clang;

[SupportedOSPlatform("windows")]
internal record struct SetupInstance(ISetupInstance Instance)
{
    public string InstanceId => Instance.GetInstanceId();

    public DateTime InstallDate
    {
        get
        {
            var ft = Instance.GetInstallDate();
            return DateTime.FromFileTime(Unsafe.As<FILETIME, long>(ref ft));
        }
    }

    public string InstallationName => Instance.GetInstallationName();
    public string InstallationPath => Instance.GetInstallationPath();
    public Version InstallationVersion => Version.Parse(Instance.GetInstallationVersion());
    public string? ProductId => (Instance as ISetupInstance2)?.GetProduct().GetId();
    public string? ProductPath => (Instance as ISetupInstance2)?.GetProductPath();
    public InstanceState? State => (Instance as ISetupInstance2)?.GetState();
    public bool IsComplete => (State.GetValueOrDefault() & InstanceState.Complete) != 0;
    public bool? IsLaunchable => (Instance as ISetupInstance2)?.IsLaunchable();
    public bool? IsPrerelease => (Instance as ISetupInstanceCatalog)?.IsPrerelease();
    public bool IsRebootRequired =>
        (State.GetValueOrDefault() & InstanceState.NoRebootRequired) == 0;
    public string DisplayName => Instance.GetDisplayName();
    public string Description => Instance.GetDescription();
    public string? EnginePath => (Instance as ISetupInstance2)?.GetEnginePath();

    public Dictionary<string, object>? Catalog
    {
        get
        {
            var cat = (Instance as ISetupInstanceCatalog)?.GetCatalogInfo();
            return cat?.GetNames().ToDictionary(x => x, x => cat.GetValue(x));
        }
    }

    public Dictionary<string, object>? Properties
    {
        get
        {
            var props = (Instance as ISetupInstance2)?.GetProperties();
            return props?.GetNames().ToDictionary(x => x, x => props.GetValue(x));
        }
    }

    public PackageReference[]? Packages =>
        (Instance as ISetupInstance2)?.GetPackages().Select(x => new PackageReference(x)).ToArray();
}

[SupportedOSPlatform("windows")]
internal record struct PackageReference(ISetupPackageReference Reference)
{
    public string Id => Reference.GetId();
    public string Version => Reference.GetVersion();
    public string Chip => Reference.GetChip();
    public string Language => Reference.GetLanguage();
    public string Branch => Reference.GetBranch();
    public string Type => Reference.GetType();
    public string UniqueId => Reference.GetUniqueId();
    public bool IsExtension => Reference.GetIsExtension();
}

[SupportedOSPlatform("windows")]
internal static class VSWhere
{
    public static SetupInstance[] Instances
    {
        get
        {
            static IEnumerable<SetupInstance> Get()
            {
                ISetupConfiguration2 cfg;
                try
                {
                    cfg = new SetupConfiguration();
                }
                catch
                {
                    yield break;
                }

                var e = cfg.EnumAllInstances();
                int fetched;
                var instances = new ISetupInstance[1];
                do
                {
                    e.Next(1, instances, out fetched);
                    if (fetched > 0)
                    {
                        yield return new SetupInstance(instances[0]);
                    }
                } while (fetched > 0);
            }

            return Get().OrderBy(x => x.InstallationVersion).ToArray();
        }
    }
}
