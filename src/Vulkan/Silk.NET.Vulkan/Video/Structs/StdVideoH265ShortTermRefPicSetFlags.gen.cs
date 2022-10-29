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
    [NativeName("Name", "StdVideoH265ShortTermRefPicSetFlags")]
    public unsafe partial struct StdVideoH265ShortTermRefPicSetFlags
    {
        public StdVideoH265ShortTermRefPicSetFlags
        (
            uint? interRefPicSetPredictionFlag = null,
            uint? deltaRpsSign = null
        ) : this()
        {
            if (interRefPicSetPredictionFlag is not null)
            {
                InterRefPicSetPredictionFlag = interRefPicSetPredictionFlag.Value;
            }

            if (deltaRpsSign is not null)
            {
                DeltaRpsSign = deltaRpsSign.Value;
            }
        }


        private uint _bitfield1;

        public uint InterRefPicSetPredictionFlag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint DeltaRpsSign
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }
    }
}
