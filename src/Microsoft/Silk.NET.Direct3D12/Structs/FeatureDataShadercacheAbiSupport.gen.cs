// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "D3D12_FEATURE_DATA_SHADERCACHE_ABI_SUPPORT")]
    public unsafe partial struct FeatureDataShadercacheAbiSupport
    {
        public FeatureDataShadercacheAbiSupport
        (
            ulong? minimumABISupportVersion = null,
            ulong? maximumABISupportVersion = null,
            VersionNumber? compilerVersion = null,
            VersionNumber? applicationProfileVersion = null
        ) : this()
        {
            if (minimumABISupportVersion is not null)
            {
                MinimumABISupportVersion = minimumABISupportVersion.Value;
            }

            if (maximumABISupportVersion is not null)
            {
                MaximumABISupportVersion = maximumABISupportVersion.Value;
            }

            if (compilerVersion is not null)
            {
                CompilerVersion = compilerVersion.Value;
            }

            if (applicationProfileVersion is not null)
            {
                ApplicationProfileVersion = applicationProfileVersion.Value;
            }
        }

        [NativeName("Type", "WCHAR[128]")]
        [NativeName("Type.Name", "WCHAR[128]")]
        [NativeName("Name", "szAdapterFamily")]
        public fixed char SzAdapterFamily[128];

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MinimumABISupportVersion")]
        public ulong MinimumABISupportVersion;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "MaximumABISupportVersion")]
        public ulong MaximumABISupportVersion;

        [NativeName("Type", "D3D12_VERSION_NUMBER")]
        [NativeName("Type.Name", "D3D12_VERSION_NUMBER")]
        [NativeName("Name", "CompilerVersion")]
        public VersionNumber CompilerVersion;

        [NativeName("Type", "D3D12_VERSION_NUMBER")]
        [NativeName("Type.Name", "D3D12_VERSION_NUMBER")]
        [NativeName("Name", "ApplicationProfileVersion")]
        public VersionNumber ApplicationProfileVersion;
    }
}
