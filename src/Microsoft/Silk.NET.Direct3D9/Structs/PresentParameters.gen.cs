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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPRESENT_PARAMETERS_")]
    public unsafe partial struct PresentParameters
    {
        public PresentParameters
        (
            uint? backBufferWidth = null,
            uint? backBufferHeight = null,
            Format? backBufferFormat = null,
            uint? backBufferCount = null,
            MultisampleType? multiSampleType = null,
            uint? multiSampleQuality = null,
            Swapeffect? swapEffect = null,
            nint? hDeviceWindow = null,
            Silk.NET.Core.Bool32? windowed = null,
            Silk.NET.Core.Bool32? enableAutoDepthStencil = null,
            Format? autoDepthStencilFormat = null,
            uint? flags = null,
            uint? fullScreenRefreshRateInHz = null,
            uint? presentationInterval = null
        ) : this()
        {
            if (backBufferWidth is not null)
            {
                BackBufferWidth = backBufferWidth.Value;
            }

            if (backBufferHeight is not null)
            {
                BackBufferHeight = backBufferHeight.Value;
            }

            if (backBufferFormat is not null)
            {
                BackBufferFormat = backBufferFormat.Value;
            }

            if (backBufferCount is not null)
            {
                BackBufferCount = backBufferCount.Value;
            }

            if (multiSampleType is not null)
            {
                MultiSampleType = multiSampleType.Value;
            }

            if (multiSampleQuality is not null)
            {
                MultiSampleQuality = multiSampleQuality.Value;
            }

            if (swapEffect is not null)
            {
                SwapEffect = swapEffect.Value;
            }

            if (hDeviceWindow is not null)
            {
                HDeviceWindow = hDeviceWindow.Value;
            }

            if (windowed is not null)
            {
                Windowed = windowed.Value;
            }

            if (enableAutoDepthStencil is not null)
            {
                EnableAutoDepthStencil = enableAutoDepthStencil.Value;
            }

            if (autoDepthStencilFormat is not null)
            {
                AutoDepthStencilFormat = autoDepthStencilFormat.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (fullScreenRefreshRateInHz is not null)
            {
                FullScreenRefreshRateInHz = fullScreenRefreshRateInHz.Value;
            }

            if (presentationInterval is not null)
            {
                PresentationInterval = presentationInterval.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BackBufferWidth")]
        public uint BackBufferWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BackBufferHeight")]
        public uint BackBufferHeight;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "BackBufferFormat")]
        public Format BackBufferFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BackBufferCount")]
        public uint BackBufferCount;

        [NativeName("Type", "D3DMULTISAMPLE_TYPE")]
        [NativeName("Type.Name", "D3DMULTISAMPLE_TYPE")]
        [NativeName("Name", "MultiSampleType")]
        public MultisampleType MultiSampleType;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "MultiSampleQuality")]
        public uint MultiSampleQuality;

        [NativeName("Type", "D3DSWAPEFFECT")]
        [NativeName("Type.Name", "D3DSWAPEFFECT")]
        [NativeName("Name", "SwapEffect")]
        public Swapeffect SwapEffect;

        [NativeName("Type", "HWND")]
        [NativeName("Type.Name", "HWND")]
        [NativeName("Name", "hDeviceWindow")]
        public nint HDeviceWindow;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Windowed")]
        public Silk.NET.Core.Bool32 Windowed;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableAutoDepthStencil")]
        public Silk.NET.Core.Bool32 EnableAutoDepthStencil;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "AutoDepthStencilFormat")]
        public Format AutoDepthStencilFormat;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Flags")]
        public uint Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FullScreen_RefreshRateInHz")]
        public uint FullScreenRefreshRateInHz;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PresentationInterval")]
        public uint PresentationInterval;
    }
}
