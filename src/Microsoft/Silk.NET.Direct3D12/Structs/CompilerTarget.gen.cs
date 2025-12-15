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
    [NativeName("Name", "D3D12_COMPILER_TARGET")]
    public unsafe partial struct CompilerTarget
    {
        public CompilerTarget
        (
            uint? adapterFamilyIndex = null,
            ulong? aBIVersion = null
        ) : this()
        {
            if (adapterFamilyIndex is not null)
            {
                AdapterFamilyIndex = adapterFamilyIndex.Value;
            }

            if (aBIVersion is not null)
            {
                ABIVersion = aBIVersion.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AdapterFamilyIndex")]
        public uint AdapterFamilyIndex;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ABIVersion")]
        public ulong ABIVersion;
    }
}
