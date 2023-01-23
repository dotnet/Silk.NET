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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "__AnonymousRecord_dxvahd_L402_C9")]
    public unsafe partial struct HDStreamStateInputColorSpaceDataUnionUnion
    {
        public HDStreamStateInputColorSpaceDataUnionUnion
        (
            uint? type = null,
            uint? rGBRange = null,
            uint? yCbCrMatrix = null,
            uint? yCbCrXvYCC = null,
            uint? reserved = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (rGBRange is not null)
            {
                RGBRange = rGBRange.Value;
            }

            if (yCbCrMatrix is not null)
            {
                YCbCrMatrix = yCbCrMatrix.Value;
            }

            if (yCbCrXvYCC is not null)
            {
                YCbCrXvYCC = yCbCrXvYCC.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private uint _bitfield1;

        public uint Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint RGBRange
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint YCbCrMatrix
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint YCbCrXvYCC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0xFFFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFFFFFFu << 4)) | (uint)(((uint)(value) & 0xFFFFFFFu) << 4));
        }
    }
}
