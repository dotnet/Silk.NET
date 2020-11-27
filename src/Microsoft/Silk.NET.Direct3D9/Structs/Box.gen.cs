// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DBOX")]
    public unsafe partial struct Box
    {
        public Box
        (
            uint? left = null,
            uint? top = null,
            uint? right = null,
            uint? bottom = null,
            uint? front = null,
            uint? back = null
        ) : this()
        {
            if (left is not null)
            {
                Left = left.Value;
            }

            if (top is not null)
            {
                Top = top.Value;
            }

            if (right is not null)
            {
                Right = right.Value;
            }

            if (bottom is not null)
            {
                Bottom = bottom.Value;
            }

            if (front is not null)
            {
                Front = front.Value;
            }

            if (back is not null)
            {
                Back = back.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Left")]
        public uint Left;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Top")]
        public uint Top;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Right")]
        public uint Right;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Bottom")]
        public uint Bottom;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Front")]
        public uint Front;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Back")]
        public uint Back;
    }
}
