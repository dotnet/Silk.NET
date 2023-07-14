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
    [NativeName("Name", "StdVideoEncodeH265PictureInfoFlags")]
    public unsafe partial struct StdVideoEncodeH265PictureInfoFlags
    {
        public StdVideoEncodeH265PictureInfoFlags
        (
            uint? isReference = null,
            uint? irapPicFlag = null,
            uint? usedForLongTermReference = null,
            uint? discardableFlag = null,
            uint? crossLayerBlaFlag = null,
            uint? picOutputFlag = null,
            uint? noOutputOfPriorPicsFlag = null,
            uint? shortTermRefPicSetSpsFlag = null,
            uint? sliceTemporalMvpEnabledFlag = null,
            uint? reserved = null
        ) : this()
        {
            if (isReference is not null)
            {
                IsReference = isReference.Value;
            }

            if (irapPicFlag is not null)
            {
                IrapPicFlag = irapPicFlag.Value;
            }

            if (usedForLongTermReference is not null)
            {
                UsedForLongTermReference = usedForLongTermReference.Value;
            }

            if (discardableFlag is not null)
            {
                DiscardableFlag = discardableFlag.Value;
            }

            if (crossLayerBlaFlag is not null)
            {
                CrossLayerBlaFlag = crossLayerBlaFlag.Value;
            }

            if (picOutputFlag is not null)
            {
                PicOutputFlag = picOutputFlag.Value;
            }

            if (noOutputOfPriorPicsFlag is not null)
            {
                NoOutputOfPriorPicsFlag = noOutputOfPriorPicsFlag.Value;
            }

            if (shortTermRefPicSetSpsFlag is not null)
            {
                ShortTermRefPicSetSpsFlag = shortTermRefPicSetSpsFlag.Value;
            }

            if (sliceTemporalMvpEnabledFlag is not null)
            {
                SliceTemporalMvpEnabledFlag = sliceTemporalMvpEnabledFlag.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint IsReference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint IrapPicFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint UsedForLongTermReference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint DiscardableFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint CrossLayerBlaFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint PicOutputFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint NoOutputOfPriorPicsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint ShortTermRefPicSetSpsFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 7)) | (uint)(((uint)(value) & 0x1u) << 7));
        }

        public uint SliceTemporalMvpEnabledFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 8)) | (uint)(((uint)(value) & 0x1u) << 8));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 9) & 0x7FFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x7FFFFFu << 9)) | (uint)(((uint)(value) & 0x7FFFFFu) << 9));
        }
    }
}
