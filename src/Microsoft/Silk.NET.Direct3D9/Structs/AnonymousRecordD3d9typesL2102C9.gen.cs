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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "__AnonymousRecord_d3d9types_L2102_C9")]
    public unsafe partial struct AnonymousRecordD3d9typesL2102C9
    {
        public AnonymousRecordD3d9typesL2102C9
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
