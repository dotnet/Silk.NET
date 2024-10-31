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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_CONFIG")]
    public unsafe partial struct VideoEncoderAV1RestorationConfig
    {
        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE[3]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TYPE[3]")]
        [NativeName("Name", "FrameRestorationType")]
        public FrameRestorationTypeBuffer FrameRestorationType;

        public struct FrameRestorationTypeBuffer
        {
            public VideoEncoderAV1RestorationType Element0;
            public VideoEncoderAV1RestorationType Element1;
            public VideoEncoderAV1RestorationType Element2;
            public ref VideoEncoderAV1RestorationType this[int index]
            {
                get
                {
                    if (index > 2 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1RestorationType* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoEncoderAV1RestorationType> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 3);
#endif
        }

        
        [NativeName("Type", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE[3]")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_AV1_RESTORATION_TILESIZE[3]")]
        [NativeName("Name", "LoopRestorationPixelSize")]
        public LoopRestorationPixelSizeBuffer LoopRestorationPixelSize;

        public struct LoopRestorationPixelSizeBuffer
        {
            public VideoEncoderAV1RestorationTilesize Element0;
            public VideoEncoderAV1RestorationTilesize Element1;
            public VideoEncoderAV1RestorationTilesize Element2;
            public ref VideoEncoderAV1RestorationTilesize this[int index]
            {
                get
                {
                    if (index > 2 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoEncoderAV1RestorationTilesize* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoEncoderAV1RestorationTilesize> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 3);
#endif
        }

    }
}
