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
    [NativeName("Name", "D3D12_VIDEO_PROCESS_TRANSFORM")]
    public unsafe partial struct VideoProcessTransform
    {
        public VideoProcessTransform
        (
            Silk.NET.Maths.Box2D<int>? sourceRectangle = null,
            Silk.NET.Maths.Box2D<int>? destinationRectangle = null,
            VideoProcessOrientation? orientation = null
        ) : this()
        {
            if (sourceRectangle is not null)
            {
                SourceRectangle = sourceRectangle.Value;
            }

            if (destinationRectangle is not null)
            {
                DestinationRectangle = destinationRectangle.Value;
            }

            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }
        }


        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "SourceRectangle")]
        public Silk.NET.Maths.Box2D<int> SourceRectangle;

        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "DestinationRectangle")]
        public Silk.NET.Maths.Box2D<int> DestinationRectangle;

        [NativeName("Type", "D3D12_VIDEO_PROCESS_ORIENTATION")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_ORIENTATION")]
        [NativeName("Name", "Orientation")]
        public VideoProcessOrientation Orientation;
    }
}
