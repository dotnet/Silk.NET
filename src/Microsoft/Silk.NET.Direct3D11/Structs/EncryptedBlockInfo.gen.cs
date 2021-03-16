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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_ENCRYPTED_BLOCK_INFO")]
    public unsafe partial struct EncryptedBlockInfo
    {
        public EncryptedBlockInfo
        (
            uint? numEncryptedBytesAtBeginning = null,
            uint? numBytesInSkipPattern = null,
            uint? numBytesInEncryptPattern = null
        ) : this()
        {
            if (numEncryptedBytesAtBeginning is not null)
            {
                NumEncryptedBytesAtBeginning = numEncryptedBytesAtBeginning.Value;
            }

            if (numBytesInSkipPattern is not null)
            {
                NumBytesInSkipPattern = numBytesInSkipPattern.Value;
            }

            if (numBytesInEncryptPattern is not null)
            {
                NumBytesInEncryptPattern = numBytesInEncryptPattern.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumEncryptedBytesAtBeginning")]
        public uint NumEncryptedBytesAtBeginning;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumBytesInSkipPattern")]
        public uint NumBytesInSkipPattern;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumBytesInEncryptPattern")]
        public uint NumBytesInEncryptPattern;
    }
}
