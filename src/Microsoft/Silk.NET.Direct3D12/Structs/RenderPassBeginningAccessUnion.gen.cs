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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L20676_C5")]
    public unsafe partial struct RenderPassBeginningAccessUnion
    {
        public RenderPassBeginningAccessUnion
        (
            RenderPassBeginningAccessClearParameters? clear = null,
            RenderPassBeginningAccessPreserveLocalParameters? preserveLocal = null
        ) : this()
        {
            if (clear is not null)
            {
                Clear = clear.Value;
            }

            if (preserveLocal is not null)
            {
                PreserveLocal = preserveLocal.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS")]
        [NativeName("Name", "Clear")]
        public RenderPassBeginningAccessClearParameters Clear;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_PRESERVE_LOCAL_PARAMETERS")]
        [NativeName("Name", "PreserveLocal")]
        public RenderPassBeginningAccessPreserveLocalParameters PreserveLocal;
    }
}
