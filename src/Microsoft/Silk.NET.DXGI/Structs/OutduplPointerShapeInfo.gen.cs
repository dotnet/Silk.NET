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
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_INFO")]
    public unsafe partial struct OutduplPointerShapeInfo
    {
        public OutduplPointerShapeInfo
        (
            uint? type = null,
            uint? width = null,
            uint? height = null,
            uint? pitch = null,
            Silk.NET.Maths.Vector2D<int>? hotSpot = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (pitch is not null)
            {
                Pitch = pitch.Value;
            }

            if (hotSpot is not null)
            {
                HotSpot = hotSpot.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Type")]
        public uint Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Pitch")]
        public uint Pitch;

        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "HotSpot")]
        public Silk.NET.Maths.Vector2D<int> HotSpot;
    }
}
