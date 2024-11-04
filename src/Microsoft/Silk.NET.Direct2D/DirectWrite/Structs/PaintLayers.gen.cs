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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "PAINT_LAYERS")]
    public unsafe partial struct PaintLayers
    {
        public PaintLayers
        (
            uint? childCount = null
        ) : this()
        {
            if (childCount is not null)
            {
                ChildCount = childCount.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "childCount")]
        public uint ChildCount;
    }
}
