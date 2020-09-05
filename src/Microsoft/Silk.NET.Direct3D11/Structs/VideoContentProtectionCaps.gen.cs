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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_CONTENT_PROTECTION_CAPS")]
    public unsafe partial struct VideoContentProtectionCaps
    {
        public VideoContentProtectionCaps
        (
            uint caps = default,
            uint keyExchangeTypeCount = default,
            uint blockAlignmentSize = default,
            ulong protectedMemorySize = default
        )
        {
            Caps = caps;
            KeyExchangeTypeCount = keyExchangeTypeCount;
            BlockAlignmentSize = blockAlignmentSize;
            ProtectedMemorySize = protectedMemorySize;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "KeyExchangeTypeCount")]
        public uint KeyExchangeTypeCount;

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
