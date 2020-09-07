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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "__MIDL___MIDL_itf_d3d11_0000_0034_0001")]
    public unsafe partial struct MIDLMIDLItfD3d11000000340001
    {
        public MIDLMIDLItfD3d11000000340001
        (
            uint protectionEnabled = default,
            uint overlayOrFullscreenRequired = default,
            uint reserved = default
        )
        {
            ProtectionEnabled = protectionEnabled;
            OverlayOrFullscreenRequired = overlayOrFullscreenRequired;
            Reserved = reserved;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProtectionEnabled")]
        public uint ProtectionEnabled;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OverlayOrFullscreenRequired")]
        public uint OverlayOrFullscreenRequired;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Reserved")]
        public uint Reserved;
    }
}
