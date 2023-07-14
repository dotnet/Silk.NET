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
    [NativeName("Name", "StdVideoEncodeH264PictureInfoFlags")]
    public unsafe partial struct StdVideoEncodeH264PictureInfoFlags
    {
        public StdVideoEncodeH264PictureInfoFlags
        (
            uint? idrPicFlag = null,
            uint? isReference = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? longTermReferenceFlag = null,
            uint? adaptiveRefPicMarkingModeFlag = null,
            uint? reserved = null
        ) : this()
        {
            if (idrPicFlag is not null)
            {
                IdrPicFlag = idrPicFlag.Value;
            }

            if (isReference is not null)
            {
                IsReference = isReference.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (longTermReferenceFlag is not null)
            {
                LongTermReferenceFlag = longTermReferenceFlag.Value;
            }

            if (adaptiveRefPicMarkingModeFlag is not null)
            {
                AdaptiveRefPicMarkingModeFlag = adaptiveRefPicMarkingModeFlag.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint IdrPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint IsReference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint NoOutputOfPriorPicsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint LongTermReferenceFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint AdaptiveRefPicMarkingModeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x7FFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7FFFFFFu << 5)) | (uint)(((uint)(value) & 0x7FFFFFFu) << 5));
        }
    }
}
