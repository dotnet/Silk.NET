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
            uint? idrFlag = null,
            uint? isReferenceFlag = null,
            uint? usedForLongTermReference = null
        ) : this()
        {
            if (idrFlag is not null)
            {
                IdrFlag = idrFlag.Value;
            }

            if (isReferenceFlag is not null)
            {
                IsReferenceFlag = isReferenceFlag.Value;
            }

            if (usedForLongTermReference is not null)
            {
                UsedForLongTermReference = usedForLongTermReference.Value;
            }
        }


        private uint _bitfield1;

        public uint IdrFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint IsReferenceFlag
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
    }
}
