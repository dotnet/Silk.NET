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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SWAP_CHAIN_DESC")]
    public unsafe partial struct SwapChainDesc
    {
        public SwapChainDesc
        (
            ModeDesc? bufferDesc = null,
            Silk.NET.DXGI.SampleDesc? sampleDesc = null,
            uint? bufferUsage = null,
            uint? bufferCount = null,
            nint? outputWindow = null,
            Silk.NET.Core.Bool32? windowed = null,
            SwapEffect? swapEffect = null,
            uint? flags = null
        ) : this()
        {
            if (bufferDesc is not null)
            {
                BufferDesc = bufferDesc.Value;
            }

            if (sampleDesc is not null)
            {
                SampleDesc = sampleDesc.Value;
            }

            if (bufferUsage is not null)
            {
                BufferUsage = bufferUsage.Value;
            }

            if (bufferCount is not null)
            {
                BufferCount = bufferCount.Value;
            }

            if (outputWindow is not null)
            {
                OutputWindow = outputWindow.Value;
            }

            if (windowed is not null)
            {
                Windowed = windowed.Value;
            }

            if (swapEffect is not null)
            {
                SwapEffect = swapEffect.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "DXGI_MODE_DESC")]
        [NativeName("Type.Name", "DXGI_MODE_DESC")]
        [NativeName("Name", "BufferDesc")]
        public ModeDesc BufferDesc;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public Silk.NET.DXGI.SampleDesc SampleDesc;

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
        public nint OutputWindow;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Windowed")]
        public Silk.NET.Core.Bool32 Windowed;

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
