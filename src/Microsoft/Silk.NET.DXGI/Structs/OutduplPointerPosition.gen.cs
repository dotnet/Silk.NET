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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTDUPL_POINTER_POSITION")]
    public unsafe partial struct OutduplPointerPosition
    {
        public OutduplPointerPosition
        (
            Silk.NET.Maths.Vector2D<int>? position = null,
            Silk.NET.Core.Bool32? visible = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (visible is not null)
            {
                Visible = visible.Value;
            }
        }


        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "Position")]
        public Silk.NET.Maths.Vector2D<int> Position;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Visible")]
        public Silk.NET.Core.Bool32 Visible;
    }
}
