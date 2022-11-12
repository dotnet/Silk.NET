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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCONTENTPROTECTIONCAPS")]
    public unsafe partial struct Contentprotectioncaps
    {
        public Contentprotectioncaps
        (
            uint? caps = null,
            Guid? keyExchangeType = null,
            uint? bufferAlignmentStart = null,
            uint? blockAlignmentSize = null,
            ulong? protectedMemorySize = null
        ) : this()
        {
            if (caps is not null)
            {
                Caps = caps.Value;
            }

            if (keyExchangeType is not null)
            {
                KeyExchangeType = keyExchangeType.Value;
            }

            if (bufferAlignmentStart is not null)
            {
                BufferAlignmentStart = bufferAlignmentStart.Value;
            }

            if (blockAlignmentSize is not null)
            {
                BlockAlignmentSize = blockAlignmentSize.Value;
            }

            if (protectedMemorySize is not null)
            {
                ProtectedMemorySize = protectedMemorySize.Value;
            }
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "KeyExchangeType")]
        public Guid KeyExchangeType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BufferAlignmentStart")]
        public uint BufferAlignmentStart;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlockAlignmentSize")]
        public uint BlockAlignmentSize;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "ProtectedMemorySize")]
        public ulong ProtectedMemorySize;
    }
}
