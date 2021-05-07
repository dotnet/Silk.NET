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
    [NativeName("Name", "StdVideoDecodeH265PictureInfoFlags")]
    public unsafe partial struct StdVideoDecodeH265PictureInfoFlags
    {
        public StdVideoDecodeH265PictureInfoFlags
        (
            uint? irapPicFlag = null,
            uint? idrPicFlag = null,
            uint? isReference = null,
            uint? shortTermRefPicSetSpsFlag = null
        ) : this()
        {
            if (irapPicFlag is not null)
            {
                IrapPicFlag = irapPicFlag.Value;
            }

            if (idrPicFlag is not null)
            {
                IdrPicFlag = idrPicFlag.Value;
            }

            if (isReference is not null)
            {
                IsReference = isReference.Value;
            }

            if (shortTermRefPicSetSpsFlag is not null)
            {
                ShortTermRefPicSetSpsFlag = shortTermRefPicSetSpsFlag.Value;
            }
        }


        private uint _bitfield1;

        public uint IrapPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint IdrPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint IsReference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint ShortTermRefPicSetSpsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }
    }
}
