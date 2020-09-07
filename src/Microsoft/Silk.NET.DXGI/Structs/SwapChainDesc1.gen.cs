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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_DESC1")]
    public unsafe partial struct SwapChainDesc1
    {
        public SwapChainDesc1
        (
            uint width = default,
            uint height = default,
            Silk.NET.DXGI.Format format = default,
            int stereo = default,
            SampleDesc sampleDesc = default,
            uint bufferUsage = default,
            uint bufferCount = default,
            Scaling scaling = default,
            SwapEffect swapEffect = default,
            AlphaMode alphaMode = default,
            uint flags = default
        )
        {
            Width = width;
            Height = height;
            Format = format;
            Stereo = stereo;
            SampleDesc = sampleDesc;
            BufferUsage = bufferUsage;
            BufferCount = bufferCount;
            Scaling = scaling;
            SwapEffect = swapEffect;
            AlphaMode = alphaMode;
            Flags = flags;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Stereo")]
        public int Stereo;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public SampleDesc SampleDesc;

        [NativeName("Type", "DXGI_USAGE")]
        [NativeName("Type.Name", "DXGI_USAGE")]
        [NativeName("Name", "BufferUsage")]
        public uint BufferUsage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferCount")]
        public uint BufferCount;

        [NativeName("Type", "DXGI_SCALING")]
        [NativeName("Type.Name", "DXGI_SCALING")]
        [NativeName("Name", "Scaling")]
        public Scaling Scaling;

        [NativeName("Type", "DXGI_SWAP_EFFECT")]
        [NativeName("Type.Name", "DXGI_SWAP_EFFECT")]
        [NativeName("Name", "SwapEffect")]
        public SwapEffect SwapEffect;

        [NativeName("Type", "DXGI_ALPHA_MODE")]
        [NativeName("Type.Name", "DXGI_ALPHA_MODE")]
        [NativeName("Name", "AlphaMode")]
        public AlphaMode AlphaMode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
