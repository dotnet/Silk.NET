// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "DXGI_SWAP_CHAIN_FULLSCREEN_DESC")]
    public unsafe partial struct SwapChainFullscreenDesc
    {
        public SwapChainFullscreenDesc
        (
            Rational? refreshRate = null,
            ModeScanlineOrder? scanlineOrdering = null,
            ModeScaling? scaling = null,
            int? windowed = null
        ) : this()
        {
            if (refreshRate is not null)
            {
                RefreshRate = refreshRate.Value;
            }

            if (scanlineOrdering is not null)
            {
                ScanlineOrdering = scanlineOrdering.Value;
            }

            if (scaling is not null)
            {
                Scaling = scaling.Value;
            }

            if (windowed is not null)
            {
                Windowed = windowed.Value;
            }
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
