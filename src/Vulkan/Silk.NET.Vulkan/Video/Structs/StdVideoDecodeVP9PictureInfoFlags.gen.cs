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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoDecodeVP9PictureInfoFlags")]
    public unsafe partial struct StdVideoDecodeVP9PictureInfoFlags
    {
        public StdVideoDecodeVP9PictureInfoFlags
        (
            uint? errorResilientMode = null,
            uint? intraOnly = null,
            uint? allowHighPrecisionMv = null,
            uint? refreshFrameContext = null,
            uint? frameParallelDecodingMode = null,
            uint? segmentationEnabled = null,
            uint? showFrame = null,
            uint? usePrevFrameMvs = null,
            uint? reserved = null
        ) : this()
        {
            if (errorResilientMode is not null)
            {
                ErrorResilientMode = errorResilientMode.Value;
            }

            if (intraOnly is not null)
            {
                IntraOnly = intraOnly.Value;
            }

            if (allowHighPrecisionMv is not null)
            {
                AllowHighPrecisionMv = allowHighPrecisionMv.Value;
            }

            if (refreshFrameContext is not null)
            {
                RefreshFrameContext = refreshFrameContext.Value;
            }

            if (frameParallelDecodingMode is not null)
            {
                FrameParallelDecodingMode = frameParallelDecodingMode.Value;
            }

            if (segmentationEnabled is not null)
            {
                SegmentationEnabled = segmentationEnabled.Value;
            }

            if (showFrame is not null)
            {
                ShowFrame = showFrame.Value;
            }

            if (usePrevFrameMvs is not null)
            {
                UsePrevFrameMvs = usePrevFrameMvs.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint ErrorResilientMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint IntraOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint AllowHighPrecisionMv
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint RefreshFrameContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint FrameParallelDecodingMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint SegmentationEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint ShowFrame
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint UsePrevFrameMvs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0xFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFFFFFu << 8)) | (uint)(((uint)(value) & 0xFFFFFFu) << 8));
        }
    }
}
