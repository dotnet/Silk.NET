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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "__MIDL___MIDL_itf_d3d11_0000_0034_0001")]
    public unsafe partial struct MIDLMIDLItfD3d11000000340001
    {
        public MIDLMIDLItfD3d11000000340001
        (
            uint? protectionEnabled = null,
            uint? overlayOrFullscreenRequired = null,
            uint? reserved = null
        ) : this()
        {
            if (protectionEnabled is not null)
            {
                ProtectionEnabled = protectionEnabled.Value;
            }

            if (overlayOrFullscreenRequired is not null)
            {
                OverlayOrFullscreenRequired = overlayOrFullscreenRequired.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
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
