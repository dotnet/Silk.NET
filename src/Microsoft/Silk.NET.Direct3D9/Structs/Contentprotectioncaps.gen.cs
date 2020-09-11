// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            uint caps = default,
            Guid keyExchangeType = default,
            uint bufferAlignmentStart = default,
            uint blockAlignmentSize = default,
            ulong protectedMemorySize = default
        )
        {
            Caps = caps;
            KeyExchangeType = keyExchangeType;
            BufferAlignmentStart = bufferAlignmentStart;
            BlockAlignmentSize = blockAlignmentSize;
            ProtectedMemorySize = protectedMemorySize;
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
