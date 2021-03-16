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
    [NativeName("Name", "D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES")]
    public unsafe partial struct FeatureDataProtectedResourceSessionTypes
    {
        public FeatureDataProtectedResourceSessionTypes
        (
            uint? nodeIndex = null,
            uint? count = null,
            Guid* pTypes = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }

            if (pTypes is not null)
            {
                PTypes = pTypes;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Count")]
        public uint Count;

        [NativeName("Type", "GUID *")]
        [NativeName("Type.Name", "GUID *")]
        [NativeName("Name", "pTypes")]
        public Guid* PTypes;
    }
}
