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
    [NativeName("Name", "DWRITE_JUSTIFICATION_OPPORTUNITY")]
    public unsafe partial struct JustificationOpportunity
    {
        public JustificationOpportunity
        (
            float? expansionMinimum = null,
            float? expansionMaximum = null,
            float? compressionMaximum = null,
            uint? expansionPriority = null,
            uint? compressionPriority = null,
            uint? allowResidualExpansion = null,
            uint? allowResidualCompression = null,
            uint? applyToLeadingEdge = null,
            uint? applyToTrailingEdge = null,
            uint? reserved = null
        ) : this()
        {
            if (expansionMinimum is not null)
            {
                ExpansionMinimum = expansionMinimum.Value;
            }

            if (expansionMaximum is not null)
            {
                ExpansionMaximum = expansionMaximum.Value;
            }

            if (compressionMaximum is not null)
            {
                CompressionMaximum = compressionMaximum.Value;
            }

            if (expansionPriority is not null)
            {
                ExpansionPriority = expansionPriority.Value;
            }

            if (compressionPriority is not null)
            {
                CompressionPriority = compressionPriority.Value;
            }

            if (allowResidualExpansion is not null)
            {
                AllowResidualExpansion = allowResidualExpansion.Value;
            }

            if (allowResidualCompression is not null)
            {
                AllowResidualCompression = allowResidualCompression.Value;
            }

            if (applyToLeadingEdge is not null)
            {
                ApplyToLeadingEdge = applyToLeadingEdge.Value;
            }

            if (applyToTrailingEdge is not null)
            {
                ApplyToTrailingEdge = applyToTrailingEdge.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "expansionMinimum")]
        public float ExpansionMinimum;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "expansionMaximum")]
        public float ExpansionMaximum;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "compressionMaximum")]
        public float CompressionMaximum;

        private uint _bitfield1;

        public uint ExpansionPriority
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0xFFu) | (uint)((uint)(value) & 0xFFu));
        }

        public uint CompressionPriority
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 8) & 0xFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFu << 8)) | (uint)(((uint)(value) & 0xFFu) << 8));
        }

        public uint AllowResidualExpansion
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 16) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 16)) | (uint)(((uint)(value) & 0x1u) << 16));
        }

        public uint AllowResidualCompression
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 17) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 17)) | (uint)(((uint)(value) & 0x1u) << 17));
        }

        public uint ApplyToLeadingEdge
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 18) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 18)) | (uint)(((uint)(value) & 0x1u) << 18));
        }

        public uint ApplyToTrailingEdge
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 19) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 19)) | (uint)(((uint)(value) & 0x1u) << 19));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 20) & 0xFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0xFFFu << 20)) | (uint)(((uint)(value) & 0xFFFu) << 20));
        }
    }
}
