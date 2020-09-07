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
    [NativeName("Name", "DXGI_SWAP_CHAIN_FULLSCREEN_DESC")]
    public unsafe partial struct SwapChainFullscreenDesc
    {
        public SwapChainFullscreenDesc
        (
            Rational refreshRate = default,
            ModeScanlineOrder scanlineOrdering = default,
            ModeScaling scaling = default,
            int windowed = default
        )
        {
            RefreshRate = refreshRate;
            ScanlineOrdering = scanlineOrdering;
            Scaling = scaling;
            Windowed = windowed;
        }


        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "RefreshRate")]
        public Rational RefreshRate;

        [NativeName("Type", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Type.Name", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Name", "ScanlineOrdering")]
        public ModeScanlineOrder ScanlineOrdering;

        [NativeName("Type", "DXGI_MODE_SCALING")]
        [NativeName("Type.Name", "DXGI_MODE_SCALING")]
        [NativeName("Name", "Scaling")]
        public ModeScaling Scaling;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Windowed")]
        public int Windowed;
    }
}
