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
    [NativeName("Name", "StdVideoDecodeH264ReferenceInfoFlags")]
    public unsafe partial struct StdVideoDecodeH264ReferenceInfoFlags
    {
        public StdVideoDecodeH264ReferenceInfoFlags
        (
            uint? topFieldFlag = null,
            uint? bottomFieldFlag = null,
            uint? usedForLongTermReference = null,
            uint? isNonExisting = null
        ) : this()
        {
            if (topFieldFlag is not null)
            {
                TopFieldFlag = topFieldFlag.Value;
            }

            if (bottomFieldFlag is not null)
            {
                BottomFieldFlag = bottomFieldFlag.Value;
            }

            if (usedForLongTermReference is not null)
            {
                UsedForLongTermReference = usedForLongTermReference.Value;
            }

            if (isNonExisting is not null)
            {
                IsNonExisting = isNonExisting.Value;
            }
        }


        private uint _bitfield1;

        public uint TopFieldFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint BottomFieldFlag
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

        public uint IsNonExisting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }
    }
}
