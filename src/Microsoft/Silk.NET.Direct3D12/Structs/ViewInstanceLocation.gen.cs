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
    [NativeName("Name", "D3D12_VIEW_INSTANCE_LOCATION")]
    public unsafe partial struct ViewInstanceLocation
    {
        public ViewInstanceLocation
        (
            uint viewportArrayIndex = default,
            uint renderTargetArrayIndex = default
        )
        {
            ViewportArrayIndex = viewportArrayIndex;
            RenderTargetArrayIndex = renderTargetArrayIndex;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ViewportArrayIndex")]
        public uint ViewportArrayIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RenderTargetArrayIndex")]
        public uint RenderTargetArrayIndex;
    }
}
