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
    [NativeName("Name", "StdVideoEncodeH264RefMgmtFlags")]
    public unsafe partial struct StdVideoEncodeH264RefMgmtFlags
    {
        public StdVideoEncodeH264RefMgmtFlags
        (
            uint? refPicListModificationL0Flag = null,
            uint? refPicListModificationL1Flag = null
        ) : this()
        {
            if (refPicListModificationL0Flag is not null)
            {
                RefPicListModificationL0Flag = refPicListModificationL0Flag.Value;
            }

            if (refPicListModificationL1Flag is not null)
            {
                RefPicListModificationL1Flag = refPicListModificationL1Flag.Value;
            }
        }


        private uint _bitfield1;

        public uint RefPicListModificationL0Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint RefPicListModificationL1Flag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }
    }
}
