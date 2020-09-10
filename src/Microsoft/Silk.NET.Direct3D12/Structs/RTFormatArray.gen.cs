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
    [NativeName("Name", "D3D12_RT_FORMAT_ARRAY")]
    public unsafe partial struct RTFormatArray
    {
        public RTFormatArray
        (
            uint numRenderTargets = default
        )
        {
           RTFormats_0 = default;
           RTFormats_1 = default;
           RTFormats_2 = default;
           RTFormats_3 = default;
           RTFormats_4 = default;
           RTFormats_5 = default;
           RTFormats_6 = default;
           RTFormats_7 = default;
            NumRenderTargets = numRenderTargets;
        }

        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_0;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_1;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_2;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_3;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_4;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_5;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_6;
        
        [NativeName("Type", "DXGI_FORMAT [8]")]
        [NativeName("Type.Name", "DXGI_FORMAT [8]")]
        [NativeName("Name", "RTFormats")]
        public Silk.NET.DXGI.Format RTFormats_7;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRenderTargets")]
        public uint NumRenderTargets;
    }
}
