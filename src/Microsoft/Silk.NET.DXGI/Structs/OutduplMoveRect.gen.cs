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
    [NativeName("Name", "DXGI_OUTDUPL_MOVE_RECT")]
    public unsafe partial struct OutduplMoveRect
    {
        public OutduplMoveRect
        (
            Silk.NET.Maths.Vector2D<int>? sourcePoint = null,
            Silk.NET.Maths.Box2D<int>? destinationRect = null
        ) : this()
        {
            if (sourcePoint is not null)
            {
                SourcePoint = sourcePoint.Value;
            }

            if (destinationRect is not null)
            {
                DestinationRect = destinationRect.Value;
            }
        }


        [NativeName("Type", "POINT")]
        [NativeName("Type.Name", "POINT")]
        [NativeName("Name", "SourcePoint")]
        public Silk.NET.Maths.Vector2D<int> SourcePoint;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DestinationRect")]
        public Silk.NET.Maths.Box2D<int> DestinationRect;
    }
}
