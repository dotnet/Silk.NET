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
    [NativeName("Name", "CD3D11_RECT")]
    public unsafe partial struct CD3D11Rect
    {
        public CD3D11Rect
        (
            int? left = null,
            int? top = null,
            int? right = null,
            int? bottom = null
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
        }


        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "left")]
        public int Left;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "top")]
        public int Top;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "right")]
        public int Right;

        [NativeName("Type", "LONG")]
        [NativeName("Type.Name", "LONG")]
        [NativeName("Name", "bottom")]
        public int Bottom;
    }
}
