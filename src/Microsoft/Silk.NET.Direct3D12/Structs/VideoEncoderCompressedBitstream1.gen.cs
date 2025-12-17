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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM1")]
    public unsafe partial struct VideoEncoderCompressedBitstream1
    {
        public VideoEncoderCompressedBitstream1
        (
            VideoEncoderCompressedBitstreamNotificationMode? notificationMode = null,
            VideoEncoderCompressedBitstream1Union? anonymous = null,
            VideoEncoderCompressedBitstream? frameOutputBuffer = null,
            VideoEncoderSubregionCompressedBitstream? subregionOutputBuffers = null
        ) : this()
        {
            if (notificationMode is not null)
            {
                NotificationMode = notificationMode.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (frameOutputBuffer is not null)
            {
                FrameOutputBuffer = frameOutputBuffer.Value;
            }

            if (subregionOutputBuffers is not null)
            {
                SubregionOutputBuffers = subregionOutputBuffers.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_COMPRESSED_BITSTREAM_NOTIFICATION_MODE")]
        [NativeName("Name", "NotificationMode")]
        public VideoEncoderCompressedBitstreamNotificationMode NotificationMode;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L10217_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderCompressedBitstream1Union Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderCompressedBitstream FrameOutputBuffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].FrameOutputBuffer;
        }
#else
        public VideoEncoderCompressedBitstream FrameOutputBuffer
        {
            get => Anonymous.FrameOutputBuffer;
            set => Anonymous.FrameOutputBuffer = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderSubregionCompressedBitstream SubregionOutputBuffers
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].SubregionOutputBuffers;
        }
#else
        public VideoEncoderSubregionCompressedBitstream SubregionOutputBuffers
        {
            get => Anonymous.SubregionOutputBuffers;
            set => Anonymous.SubregionOutputBuffers = value;
        }
#endif

    }
}
