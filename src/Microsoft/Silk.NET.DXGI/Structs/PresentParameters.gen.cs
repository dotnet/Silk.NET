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
    [NativeName("Name", "DXGI_PRESENT_PARAMETERS")]
    public unsafe partial struct PresentParameters
    {
        public PresentParameters
        (
            uint? dirtyRectsCount = null,
            Silk.NET.Maths.Box2D<int>* pDirtyRects = null,
            Silk.NET.Maths.Box2D<int>* pScrollRect = null,
            Silk.NET.Maths.Vector2D<int>* pScrollOffset = null
        ) : this()
        {
            if (dirtyRectsCount is not null)
            {
                DirtyRectsCount = dirtyRectsCount.Value;
            }

            if (pDirtyRects is not null)
            {
                PDirtyRects = pDirtyRects;
            }

            if (pScrollRect is not null)
            {
                PScrollRect = pScrollRect;
            }

            if (pScrollOffset is not null)
            {
                PScrollOffset = pScrollOffset;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DirtyRectsCount")]
        public uint DirtyRectsCount;

        [NativeName("Type", "RECT *")]
        [NativeName("Type.Name", "RECT *")]
        [NativeName("Name", "pDirtyRects")]
        public Silk.NET.Maths.Box2D<int>* PDirtyRects;

        [NativeName("Type", "RECT *")]
        [NativeName("Type.Name", "RECT *")]
        [NativeName("Name", "pScrollRect")]
        public Silk.NET.Maths.Box2D<int>* PScrollRect;

        [NativeName("Type", "POINT *")]
        [NativeName("Type.Name", "POINT *")]
        [NativeName("Name", "pScrollOffset")]
        public Silk.NET.Maths.Vector2D<int>* PScrollOffset;
    }
}
