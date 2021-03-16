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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_BOX")]
    public unsafe partial struct Box
    {
        public Box
        (
            uint? left = null,
            uint? top = null,
            uint? front = null,
            uint? right = null,
            uint? bottom = null,
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

            if (front is not null)
            {
                Front = front.Value;
            }

            if (right is not null)
            {
                Right = right.Value;
            }

            if (bottom is not null)
            {
                Bottom = bottom.Value;
            }

            if (back is not null)
            {
                Back = back.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "left")]
        public uint Left;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "top")]
        public uint Top;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "front")]
        public uint Front;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "right")]
        public uint Right;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "bottom")]
        public uint Bottom;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "back")]
        public uint Back;
    }
}
