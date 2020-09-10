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
    [NativeName("Name", "D3D12_SHADER_RESOURCE_VIEW_DESC")]
    public unsafe partial struct ShaderResourceViewDesc
    {
        public ShaderResourceViewDesc
        (
            Silk.NET.DXGI.Format format = default,
            SrvDimension viewDimension = default,
            uint shader4ComponentMapping = default
        )
        {
            Format = format;
            ViewDimension = viewDimension;
            Shader4ComponentMapping = shader4ComponentMapping;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D12_SRV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public SrvDimension ViewDimension;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Shader4ComponentMapping")]
        public uint Shader4ComponentMapping;
    }
}
