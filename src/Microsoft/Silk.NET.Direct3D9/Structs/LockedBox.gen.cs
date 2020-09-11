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
    [NativeName("Name", "_D3DLOCKED_BOX")]
    public unsafe partial struct LockedBox
    {
        public LockedBox
        (
            int rowPitch = default,
            int slicePitch = default,
            void* pBits = default
        )
        {
            RowPitch = rowPitch;
            SlicePitch = slicePitch;
            PBits = pBits;
        }


        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "RowPitch")]
        public int RowPitch;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "SlicePitch")]
        public int SlicePitch;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pBits")]
        public void* PBits;
    }
}
