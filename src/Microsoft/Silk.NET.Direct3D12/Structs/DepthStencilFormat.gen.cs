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
    [NativeName("Name", "D3D12_DEPTH_STENCIL_FORMAT")]
    public unsafe partial struct DepthStencilFormat
    {
        public DepthStencilFormat
        (
            Silk.NET.DXGI.Format? value = null
        ) : this()
        {
            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DepthStencilFormat")]
        public Silk.NET.DXGI.Format Value;
    }
}
