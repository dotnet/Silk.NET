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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DPRESENT_PARAMETERS_")]
    public unsafe partial struct PresentParameters
    {
        public PresentParameters
        (
            uint backBufferWidth = default,
            uint backBufferHeight = default,
            Format backBufferFormat = default,
            uint backBufferCount = default,
            MultisampleType multiSampleType = default,
            uint multiSampleQuality = default,
            Swapeffect swapEffect = default,
            IntPtr hDeviceWindow = default,
            int windowed = default,
            int enableAutoDepthStencil = default,
            Format autoDepthStencilFormat = default,
            uint flags = default,
            uint fullScreenRefreshRateInHz = default,
            uint presentationInterval = default
        )
        {
            BackBufferWidth = backBufferWidth;
            BackBufferHeight = backBufferHeight;
            BackBufferFormat = backBufferFormat;
            BackBufferCount = backBufferCount;
            MultiSampleType = multiSampleType;
            MultiSampleQuality = multiSampleQuality;
            SwapEffect = swapEffect;
            HDeviceWindow = hDeviceWindow;
            Windowed = windowed;
            EnableAutoDepthStencil = enableAutoDepthStencil;
            AutoDepthStencilFormat = autoDepthStencilFormat;
            Flags = flags;
            FullScreenRefreshRateInHz = fullScreenRefreshRateInHz;
            PresentationInterval = presentationInterval;
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
        public IntPtr HDeviceWindow;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Windowed")]
        public int Windowed;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EnableAutoDepthStencil")]
        public int EnableAutoDepthStencil;

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
