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
    [NativeName("Name", "DWRITE_CLUSTER_METRICS")]
    public unsafe partial struct ClusterMetrics
    {
        public ClusterMetrics
        (
            float? width = null,
            ushort? length = null,
            ushort? canWrapLineAfter = null,
            ushort? isWhitespace = null,
            ushort? isNewline = null,
            ushort? isSoftHyphen = null,
            ushort? isRightToLeft = null,
            ushort? padding = null
        ) : this()
        {
            if (width is not null)
            {
                Width = width.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

            if (canWrapLineAfter is not null)
            {
                CanWrapLineAfter = canWrapLineAfter.Value;
            }

            if (isWhitespace is not null)
            {
                IsWhitespace = isWhitespace.Value;
            }

            if (isNewline is not null)
            {
                IsNewline = isNewline.Value;
            }

            if (isSoftHyphen is not null)
            {
                IsSoftHyphen = isSoftHyphen.Value;
            }

            if (isRightToLeft is not null)
            {
                IsRightToLeft = isRightToLeft.Value;
            }

            if (padding is not null)
            {
                Padding = padding.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "width")]
        public float Width;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "length")]
        public ushort Length;

        private ushort _bitfield1;

        public ushort CanWrapLineAfter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~0x1u) | (ushort)((ushort)(value) & 0x1u));
        }

        public ushort IsWhitespace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 1)) | (ushort)(((ushort)(value) & 0x1u) << 1));
        }

        public ushort IsNewline
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 2)) | (ushort)(((ushort)(value) & 0x1u) << 2));
        }

        public ushort IsSoftHyphen
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 3)) | (ushort)(((ushort)(value) & 0x1u) << 3));
        }

        public ushort IsRightToLeft
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x1u << 4)) | (ushort)(((ushort)(value) & 0x1u) << 4));
        }

        public ushort Padding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (ushort)((_bitfield1 >> 5) & 0x7FFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (ushort)((ushort)(_bitfield1 & ~(0x7FFu << 5)) | (ushort)(((ushort)(value) & 0x7FFu) << 5));
        }
    }
}
