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
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_SHAPE_INFO")]
    public unsafe partial struct OutduplPointerShapeInfo
    {
        public OutduplPointerShapeInfo
        (
            uint type = default,
            uint width = default,
            uint height = default,
            uint pitch = default,
            Silk.NET.Core.Native.TagPoint hotSpot = default
        )
        {
            Type = type;
            Width = width;
            Height = height;
            Pitch = pitch;
            HotSpot = hotSpot;
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
        public Silk.NET.Core.Native.TagPoint HotSpot;
    }
}
