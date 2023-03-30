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
    [NativeName("Name", "DWRITE_SCRIPT_PROPERTIES")]
    public unsafe partial struct ScriptProperties
    {
        public ScriptProperties
        (
            uint? isoScriptCode = null,
            uint? isoScriptNumber = null,
            uint? clusterLookahead = null,
            uint? justificationCharacter = null,
            uint? restrictCaretToClusters = null,
            uint? usesWordDividers = null,
            uint? isDiscreteWriting = null,
            uint? isBlockWriting = null,
            uint? isDistributedWithinCluster = null,
            uint? isConnectedWriting = null,
            uint? isCursiveWriting = null,
            uint? reserved = null
        ) : this()
        {
            if (isoScriptCode is not null)
            {
                IsoScriptCode = isoScriptCode.Value;
            }

            if (isoScriptNumber is not null)
            {
                IsoScriptNumber = isoScriptNumber.Value;
            }

            if (clusterLookahead is not null)
            {
                ClusterLookahead = clusterLookahead.Value;
            }

            if (justificationCharacter is not null)
            {
                JustificationCharacter = justificationCharacter.Value;
            }

            if (restrictCaretToClusters is not null)
            {
                RestrictCaretToClusters = restrictCaretToClusters.Value;
            }

            if (usesWordDividers is not null)
            {
                UsesWordDividers = usesWordDividers.Value;
            }

            if (isDiscreteWriting is not null)
            {
                IsDiscreteWriting = isDiscreteWriting.Value;
            }

            if (isBlockWriting is not null)
            {
                IsBlockWriting = isBlockWriting.Value;
            }

            if (isDistributedWithinCluster is not null)
            {
                IsDistributedWithinCluster = isDistributedWithinCluster.Value;
            }

            if (isConnectedWriting is not null)
            {
                IsConnectedWriting = isConnectedWriting.Value;
            }

            if (isCursiveWriting is not null)
            {
                IsCursiveWriting = isCursiveWriting.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "isoScriptCode")]
        public uint IsoScriptCode;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "isoScriptNumber")]
        public uint IsoScriptNumber;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "clusterLookahead")]
        public uint ClusterLookahead;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "justificationCharacter")]
        public uint JustificationCharacter;

        private uint _bitfield1;

        public uint RestrictCaretToClusters
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)(_bitfield1 & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~0x1u) | (uint)((uint)(value) & 0x1u));
        }

        public uint UsesWordDividers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 1) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 1)) | (uint)(((uint)(value) & 0x1u) << 1));
        }

        public uint IsDiscreteWriting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 2) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 2)) | (uint)(((uint)(value) & 0x1u) << 2));
        }

        public uint IsBlockWriting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 3) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 3)) | (uint)(((uint)(value) & 0x1u) << 3));
        }

        public uint IsDistributedWithinCluster
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 4) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 4)) | (uint)(((uint)(value) & 0x1u) << 4));
        }

        public uint IsConnectedWriting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 5) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 5)) | (uint)(((uint)(value) & 0x1u) << 5));
        }

        public uint IsCursiveWriting
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 6) & 0x1u);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1u << 6)) | (uint)(((uint)(value) & 0x1u) << 6));
        }

        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (uint)((_bitfield1 >> 7) & 0x1FFFFFFu);
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => _bitfield1 = (uint)((uint)(_bitfield1 & ~(0x1FFFFFFu << 7)) | (uint)(((uint)(value) & 0x1FFFFFFu) << 7));
        }
    }
}
