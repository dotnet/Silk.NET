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
    [NativeName("Name", "StdVideoAV1LoopFilterFlags")]
    public unsafe partial struct StdVideoAV1LoopFilterFlags
    {
        public StdVideoAV1LoopFilterFlags
        (
            uint? loopFilterDeltaEnabled = null,
            uint? loopFilterDeltaUpdate = null,
            uint? reserved = null
        ) : this()
        {
            if (loopFilterDeltaEnabled is not null)
            {
                LoopFilterDeltaEnabled = loopFilterDeltaEnabled.Value;
            }

            if (loopFilterDeltaUpdate is not null)
            {
                LoopFilterDeltaUpdate = loopFilterDeltaUpdate.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint LoopFilterDeltaEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint LoopFilterDeltaUpdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x3FFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x3FFFFFFFu << 2)) | (uint)(((uint)(value) & 0x3FFFFFFFu) << 2));
        }
    }
}
