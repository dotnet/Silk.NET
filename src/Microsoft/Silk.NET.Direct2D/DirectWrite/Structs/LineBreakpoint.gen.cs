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
    [NativeName("Name", "DWRITE_LINE_BREAKPOINT")]
    public unsafe partial struct LineBreakpoint
    {
        public LineBreakpoint
        (
            byte? breakConditionBefore = null,
            byte? breakConditionAfter = null,
            byte? isWhitespace = null,
            byte? isSoftHyphen = null,
            byte? padding = null
        ) : this()
        {
            if (breakConditionBefore is not null)
            {
                BreakConditionBefore = breakConditionBefore.Value;
            }

            if (breakConditionAfter is not null)
            {
                BreakConditionAfter = breakConditionAfter.Value;
            }

            if (isWhitespace is not null)
            {
                IsWhitespace = isWhitespace.Value;
            }

            if (isSoftHyphen is not null)
            {
                IsSoftHyphen = isSoftHyphen.Value;
            }

            if (padding is not null)
            {
                Padding = padding.Value;
            }
        }


        private byte _bitfield1;

        public byte BreakConditionBefore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (byte)(_bitfield1 & 0x3);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((byte)(_bitfield1 & ~0x3) | (byte)((byte)(value) & 0x3));
        }

        public byte BreakConditionAfter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (byte)((_bitfield1 >> 2) & 0x3);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((byte)(_bitfield1 & ~(0x3 << 2)) | (byte)(((byte)(value) & 0x3) << 2));
        }

        public byte IsWhitespace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (byte)((_bitfield1 >> 4) & 0x1);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((byte)(_bitfield1 & ~(0x1 << 4)) | (byte)(((byte)(value) & 0x1) << 4));
        }

        public byte IsSoftHyphen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (byte)((_bitfield1 >> 5) & 0x1);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((byte)(_bitfield1 & ~(0x1 << 5)) | (byte)(((byte)(value) & 0x1) << 5));
        }

        public byte Padding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (byte)((_bitfield1 >> 6) & 0x3);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (byte)((byte)(_bitfield1 & ~(0x3 << 6)) | (byte)(((byte)(value) & 0x3) << 6));
        }
    }
}
