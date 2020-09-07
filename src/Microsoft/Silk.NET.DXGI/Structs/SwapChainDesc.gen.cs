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
    [NativeName("Name", "DXGI_SWAP_CHAIN_DESC")]
    public unsafe partial struct SwapChainDesc
    {
        public SwapChainDesc
        (
            ModeDesc bufferDesc = default,
            SampleDesc sampleDesc = default,
            uint bufferUsage = default,
            uint bufferCount = default,
            IntPtr outputWindow = default,
            int windowed = default,
            SwapEffect swapEffect = default,
            uint flags = default
        )
        {
            BufferDesc = bufferDesc;
            SampleDesc = sampleDesc;
            BufferUsage = bufferUsage;
            BufferCount = bufferCount;
            OutputWindow = outputWindow;
            Windowed = windowed;
            SwapEffect = swapEffect;
            Flags = flags;
        }


        [NativeName("Type", "DXGI_MODE_DESC")]
        [NativeName("Type.Name", "DXGI_MODE_DESC")]
        [NativeName("Name", "BufferDesc")]
        public ModeDesc BufferDesc;

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

        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "OutputWindow")]
        public IntPtr OutputWindow;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Windowed")]
        public int Windowed;

        [NativeName("Type", "DXGI_SWAP_EFFECT")]
        [NativeName("Type.Name", "DXGI_SWAP_EFFECT")]
        [NativeName("Name", "SwapEffect")]
        public SwapEffect SwapEffect;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
