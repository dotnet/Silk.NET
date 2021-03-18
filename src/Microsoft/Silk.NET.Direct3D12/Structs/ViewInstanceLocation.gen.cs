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
    [NativeName("Name", "D3D12_VIEW_INSTANCE_LOCATION")]
    public unsafe partial struct ViewInstanceLocation
    {
        public ViewInstanceLocation
        (
            uint? viewportArrayIndex = null,
            uint? renderTargetArrayIndex = null
        ) : this()
        {
            if (viewportArrayIndex is not null)
            {
                ViewportArrayIndex = viewportArrayIndex.Value;
            }

            if (renderTargetArrayIndex is not null)
            {
                RenderTargetArrayIndex = renderTargetArrayIndex.Value;
            }
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
