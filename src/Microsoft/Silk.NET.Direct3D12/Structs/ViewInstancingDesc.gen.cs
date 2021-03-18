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
    [NativeName("Name", "D3D12_VIEW_INSTANCING_DESC")]
    public unsafe partial struct ViewInstancingDesc
    {
        public ViewInstancingDesc
        (
            uint? viewInstanceCount = null,
            ViewInstanceLocation* pViewInstanceLocations = null,
            ViewInstancingFlags? flags = null
        ) : this()
        {
            if (viewInstanceCount is not null)
            {
                ViewInstanceCount = viewInstanceCount.Value;
            }

            if (pViewInstanceLocations is not null)
            {
                PViewInstanceLocations = pViewInstanceLocations;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ViewInstanceCount")]
        public uint ViewInstanceCount;

        [NativeName("Type", "const D3D12_VIEW_INSTANCE_LOCATION *")]
        [NativeName("Type.Name", "const D3D12_VIEW_INSTANCE_LOCATION *")]
        [NativeName("Name", "pViewInstanceLocations")]
        public ViewInstanceLocation* PViewInstanceLocations;

        [NativeName("Type", "D3D12_VIEW_INSTANCING_FLAGS")]
        [NativeName("Type.Name", "D3D12_VIEW_INSTANCING_FLAGS")]
        [NativeName("Name", "Flags")]
        public ViewInstancingFlags Flags;
    }
}
