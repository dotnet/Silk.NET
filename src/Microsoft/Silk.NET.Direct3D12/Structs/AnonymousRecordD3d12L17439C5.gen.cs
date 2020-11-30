// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "__AnonymousRecord_d3d12_L17439_C5")]
    public unsafe partial struct AnonymousRecordD3d12L17439C5
    {
        public AnonymousRecordD3d12L17439C5
        (
            RenderPassBeginningAccessClearParameters? clear = null
        ) : this()
        {
            if (clear is not null)
            {
                Clear = clear.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS")]
        [NativeName("Name", "Clear")]
        public RenderPassBeginningAccessClearParameters Clear;
    }
}
