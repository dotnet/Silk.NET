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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHDETW_VIDEOPROCESSBLTHD_STREAM")]
    public unsafe partial struct HdetwVideoprocessblthdStream
    {
        public HdetwVideoprocessblthdStream
        (
            ulong? pObject = null,
            ulong? pInputSurface = null,
            Silk.NET.Maths.Box2D<int>? sourceRect = null,
            Silk.NET.Maths.Box2D<int>? destinationRect = null,
            Silk.NET.Direct3D9.Format? inputFormat = null,
            HDFrameFormat? frameFormat = null,
            uint? colorSpace = null,
            uint? streamNumber = null,
            uint? outputIndex = null,
            uint? inputFrameOrField = null,
            uint? pastFrames = null,
            uint? futureFrames = null
        ) : this()
        {
            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (pInputSurface is not null)
            {
                PInputSurface = pInputSurface.Value;
            }

            if (sourceRect is not null)
            {
                SourceRect = sourceRect.Value;
            }

            if (destinationRect is not null)
            {
                DestinationRect = destinationRect.Value;
            }

            if (inputFormat is not null)
            {
                InputFormat = inputFormat.Value;
            }

            if (frameFormat is not null)
            {
                FrameFormat = frameFormat.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (streamNumber is not null)
            {
                StreamNumber = streamNumber.Value;
            }

            if (outputIndex is not null)
            {
                OutputIndex = outputIndex.Value;
            }

            if (inputFrameOrField is not null)
            {
                InputFrameOrField = inputFrameOrField.Value;
            }

            if (pastFrames is not null)
            {
                PastFrames = pastFrames.Value;
            }

            if (futureFrames is not null)
            {
                FutureFrames = futureFrames.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pInputSurface")]
        public ulong PInputSurface;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "SourceRect")]
        public Silk.NET.Maths.Box2D<int> SourceRect;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DestinationRect")]
        public Silk.NET.Maths.Box2D<int> DestinationRect;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "InputFormat")]
        public Silk.NET.Direct3D9.Format InputFormat;

        [NativeName("Type", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Type.Name", "DXVAHD_FRAME_FORMAT")]
        [NativeName("Name", "FrameFormat")]
        public HDFrameFormat FrameFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ColorSpace")]
        public uint ColorSpace;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StreamNumber")]
        public uint StreamNumber;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputIndex")]
        public uint OutputIndex;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFrameOrField")]
        public uint InputFrameOrField;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PastFrames")]
        public uint PastFrames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FutureFrames")]
        public uint FutureFrames;
    }
}
