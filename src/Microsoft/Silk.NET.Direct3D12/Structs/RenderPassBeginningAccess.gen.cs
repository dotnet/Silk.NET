// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
    public unsafe partial struct RenderPassBeginningAccess
    {
        public RenderPassBeginningAccess
        (
            RenderPassBeginningAccessType? type = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_TYPE")]
        [NativeName("Name", "Type")]
        public RenderPassBeginningAccessType Type;
    }
}
