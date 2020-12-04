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
    [NativeName("Name", "_D3DOVERLAYCAPS")]
    public unsafe partial struct Overlaycaps
    {
        public Overlaycaps
        (
            uint? caps = null,
            uint? maxOverlayDisplayWidth = null,
            uint? maxOverlayDisplayHeight = null
        ) : this()
        {
            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (maxOverlayDisplayWidth is not null)
            {
                MaxOverlayDisplayWidth = maxOverlayDisplayWidth.Value;
            }

            if (maxOverlayDisplayHeight is not null)
            {
                MaxOverlayDisplayHeight = maxOverlayDisplayHeight.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxOverlayDisplayWidth")]
        public uint MaxOverlayDisplayWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxOverlayDisplayHeight")]
        public uint MaxOverlayDisplayHeight;
    }
}
