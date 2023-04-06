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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_SHAPING_TEXT_PROPERTIES")]
    public unsafe partial struct ShapingTextProperties
    {
        public ShapingTextProperties
        (
            ushort? isShapedAlone = null,
            ushort? reserved1 = null,
            ushort? canBreakShapingAfter = null,
            ushort? reserved = null
        ) : this()
        {
            if (isShapedAlone is not null)
            {
                IsShapedAlone = isShapedAlone.Value;
            }

            if (reserved1 is not null)
            {
                Reserved1 = reserved1.Value;
            }

            if (canBreakShapingAfter is not null)
            {
                CanBreakShapingAfter = canBreakShapingAfter.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private ushort _bitfield1;

        public ushort IsShapedAlone
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~0x1u) | (ushort)((ushort)(value) & 0x1u));
        }

        public ushort Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 1)) | (ushort)(((ushort)(value) & 0x1u) << 1));
        }

        public ushort CanBreakShapingAfter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 2)) | (ushort)(((ushort)(value) & 0x1u) << 2));
        }

        public ushort Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 3) & 0x1FFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1FFFu << 3)) | (ushort)(((ushort)(value) & 0x1FFFu) << 3));
        }
    }
}
