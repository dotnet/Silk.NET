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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_DIRTY_RECT_INFO")]
    public unsafe partial struct VideoEncoderDirtyRectInfo
    {
        public VideoEncoderDirtyRectInfo
        (
            Silk.NET.Core.Bool32? fullFrameIdentical = null,
            VideoEncoderDirtyRegionsMapValuesMode? mapValuesType = null,
            uint? numDirtyRects = null,
            Silk.NET.Maths.Box2D<int>* pDirtyRects = null,
            uint? sourceDPBFrameReference = null
        ) : this()
        {
            if (fullFrameIdentical is not null)
            {
                FullFrameIdentical = fullFrameIdentical.Value;
            }

            if (mapValuesType is not null)
            {
                MapValuesType = mapValuesType.Value;
            }

            if (numDirtyRects is not null)
            {
                NumDirtyRects = numDirtyRects.Value;
            }

            if (pDirtyRects is not null)
            {
                PDirtyRects = pDirtyRects;
            }

            if (sourceDPBFrameReference is not null)
            {
                SourceDPBFrameReference = sourceDPBFrameReference.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "FullFrameIdentical")]
        public Silk.NET.Core.Bool32 FullFrameIdentical;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_DIRTY_REGIONS_MAP_VALUES_MODE")]
        [NativeName("Name", "MapValuesType")]
        public VideoEncoderDirtyRegionsMapValuesMode MapValuesType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDirtyRects")]
        public uint NumDirtyRects;

        [NativeName("Type", "RECT *")]
        [NativeName("Type.Name", "RECT *")]
        [NativeName("Name", "pDirtyRects")]
        public Silk.NET.Maths.Box2D<int>* PDirtyRects;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SourceDPBFrameReference")]
        public uint SourceDPBFrameReference;
    }
}
