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
    [NativeName("Name", "DWRITE_SHAPING_GLYPH_PROPERTIES")]
    public unsafe partial struct ShapingGlyphProperties
    {
        public ShapingGlyphProperties
        (
            ushort? justification = null,
            ushort? isClusterStart = null,
            ushort? isDiacritic = null,
            ushort? isZeroWidthSpace = null,
            ushort? reserved = null
        ) : this()
        {
            if (justification is not null)
            {
                Justification = justification.Value;
            }

            if (isClusterStart is not null)
            {
                IsClusterStart = isClusterStart.Value;
            }

            if (isDiacritic is not null)
            {
                IsDiacritic = isDiacritic.Value;
            }

            if (isZeroWidthSpace is not null)
            {
                IsZeroWidthSpace = isZeroWidthSpace.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        private ushort _bitfield1;

        public ushort Justification
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)(_bitfield1 & 0xFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~0xFu) | (ushort)((ushort)(value) & 0xFu));
        }

        public ushort IsClusterStart
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 4)) | (ushort)(((ushort)(value) & 0x1u) << 4));
        }

        public ushort IsDiacritic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 5)) | (ushort)(((ushort)(value) & 0x1u) << 5));
        }

        public ushort IsZeroWidthSpace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 6)) | (ushort)(((ushort)(value) & 0x1u) << 6));
        }

        public ushort Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 7) & 0x1FFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1FFu << 7)) | (ushort)(((ushort)(value) & 0x1FFu) << 7));
        }
    }
}
