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
    [NativeName("Name", "StdVideoEncodeAV1OperatingPointInfoFlags")]
    public unsafe partial struct StdVideoEncodeAV1OperatingPointInfoFlags
    {
        public StdVideoEncodeAV1OperatingPointInfoFlags
        (
            uint? decoderModelPresentForThisOp = null,
            uint? lowDelayModeFlag = null,
            uint? initialDisplayDelayPresentForThisOp = null,
            uint? reserved = null
        ) : this()
        {
            if (decoderModelPresentForThisOp is not null)
            {
                DecoderModelPresentForThisOp = decoderModelPresentForThisOp.Value;
            }

            if (lowDelayModeFlag is not null)
            {
                LowDelayModeFlag = lowDelayModeFlag.Value;
            }

            if (initialDisplayDelayPresentForThisOp is not null)
            {
                InitialDisplayDelayPresentForThisOp = initialDisplayDelayPresentForThisOp.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint DecoderModelPresentForThisOp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint LowDelayModeFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint InitialDisplayDelayPresentForThisOp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1FFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1FFFFFFFu << 3)) | (uint)(((uint)(value) & 0x1FFFFFFFu) << 3));
        }
    }
}
