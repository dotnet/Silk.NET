// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "_D3DENCRYPTED_BLOCK_INFO")]
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
