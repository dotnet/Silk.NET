// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_SHADER_RESOURCE_VIEW_DESC")]
    public unsafe partial struct ShaderResourceViewDesc
    {
        public ShaderResourceViewDesc
        (
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.Core.Native.D3DSrvDimension? viewDimension = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D11_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D11_SRV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public Silk.NET.Core.Native.D3DSrvDimension ViewDimension;
    }
}
