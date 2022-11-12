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
    [NativeName("Name", "_DXVA2_VideoProcessBltParams")]
    public unsafe partial struct DXVA2VideoProcessBltParams
    {
        public DXVA2VideoProcessBltParams
        (
            long? targetFrame = null,
            Silk.NET.Maths.Box2D<int>? targetRect = null,
            Silk.NET.Maths.Vector2D<int>? constrictionSize = null,
            uint? streamingFlags = null,
            DXVA2AYUVSample16? backgroundColor = null,
            DXVA2ExtendedFormat? destFormat = null,
            DXVA2ProcAmpValues? procAmpValues = null,
            DXVA2Fixed32? alpha = null,
            DXVA2FilterValues? noiseFilterLuma = null,
            DXVA2FilterValues? noiseFilterChroma = null,
            DXVA2FilterValues? detailFilterLuma = null,
            DXVA2FilterValues? detailFilterChroma = null,
            uint? destData = null
        ) : this()
        {
            if (targetFrame is not null)
            {
                TargetFrame = targetFrame.Value;
            }

            if (targetRect is not null)
            {
                TargetRect = targetRect.Value;
            }

            if (constrictionSize is not null)
            {
                ConstrictionSize = constrictionSize.Value;
            }

            if (streamingFlags is not null)
            {
                StreamingFlags = streamingFlags.Value;
            }

            if (backgroundColor is not null)
            {
                BackgroundColor = backgroundColor.Value;
            }

            if (destFormat is not null)
            {
                DestFormat = destFormat.Value;
            }

            if (procAmpValues is not null)
            {
                ProcAmpValues = procAmpValues.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }

            if (noiseFilterLuma is not null)
            {
                NoiseFilterLuma = noiseFilterLuma.Value;
            }

            if (noiseFilterChroma is not null)
            {
                NoiseFilterChroma = noiseFilterChroma.Value;
            }

            if (detailFilterLuma is not null)
            {
                DetailFilterLuma = detailFilterLuma.Value;
            }

            if (detailFilterChroma is not null)
            {
                DetailFilterChroma = detailFilterChroma.Value;
            }

            if (destData is not null)
            {
                DestData = destData.Value;
            }
        }


        [NativeName("Type", "REFERENCE_TIME")]
        [NativeName("Type.Name", "REFERENCE_TIME")]
        [NativeName("Name", "TargetFrame")]
        public long TargetFrame;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "TargetRect")]
        public Silk.NET.Maths.Box2D<int> TargetRect;

        [NativeName("Type", "SIZE")]
        [NativeName("Type.Name", "SIZE")]
        [NativeName("Name", "ConstrictionSize")]
        public Silk.NET.Maths.Vector2D<int> ConstrictionSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StreamingFlags")]
        public uint StreamingFlags;

        [NativeName("Type", "DXVA2_AYUVSample16")]
        [NativeName("Type.Name", "DXVA2_AYUVSample16")]
        [NativeName("Name", "BackgroundColor")]
        public DXVA2AYUVSample16 BackgroundColor;

        [NativeName("Type", "DXVA2_ExtendedFormat")]
        [NativeName("Type.Name", "DXVA2_ExtendedFormat")]
        [NativeName("Name", "DestFormat")]
        public DXVA2ExtendedFormat DestFormat;

        [NativeName("Type", "DXVA2_ProcAmpValues")]
        [NativeName("Type.Name", "DXVA2_ProcAmpValues")]
        [NativeName("Name", "ProcAmpValues")]
        public DXVA2ProcAmpValues ProcAmpValues;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Alpha")]
        public DXVA2Fixed32 Alpha;

        [NativeName("Type", "DXVA2_FilterValues")]
        [NativeName("Type.Name", "DXVA2_FilterValues")]
        [NativeName("Name", "NoiseFilterLuma")]
        public DXVA2FilterValues NoiseFilterLuma;

        [NativeName("Type", "DXVA2_FilterValues")]
        [NativeName("Type.Name", "DXVA2_FilterValues")]
        [NativeName("Name", "NoiseFilterChroma")]
        public DXVA2FilterValues NoiseFilterChroma;

        [NativeName("Type", "DXVA2_FilterValues")]
        [NativeName("Type.Name", "DXVA2_FilterValues")]
        [NativeName("Name", "DetailFilterLuma")]
        public DXVA2FilterValues DetailFilterLuma;

        [NativeName("Type", "DXVA2_FilterValues")]
        [NativeName("Type.Name", "DXVA2_FilterValues")]
        [NativeName("Name", "DetailFilterChroma")]
        public DXVA2FilterValues DetailFilterChroma;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "DestData")]
        public uint DestData;
    }
}
