// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint viewInstanceCount = default,
            ViewInstanceLocation* pViewInstanceLocations = default,
            ViewInstancingFlags flags = default
        )
        {
            ViewInstanceCount = viewInstanceCount;
            PViewInstanceLocations = pViewInstanceLocations;
            Flags = flags;
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
