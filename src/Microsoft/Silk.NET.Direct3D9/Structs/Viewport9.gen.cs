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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVIEWPORT9")]
    public unsafe partial struct Viewport9
    {
        public Viewport9
        (
            int? x = null,
            int? y = null,
            int? width = null,
            int? height = null,
            float? minZ = null,
            float? maxZ = null
        ) : this()
        {
            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (minZ is not null)
            {
                MinZ = minZ.Value;
            }

            if (maxZ is not null)
            {
                MaxZ = maxZ.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "X")]
        public int X;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Y")]
        public int Y;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Width")]
        public int Width;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Height")]
        public int Height;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MinZ")]
        public float MinZ;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "MaxZ")]
        public float MaxZ;
    }
}
