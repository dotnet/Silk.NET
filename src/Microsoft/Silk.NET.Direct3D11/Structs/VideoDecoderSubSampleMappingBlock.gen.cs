// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK")]
    public unsafe partial struct VideoDecoderSubSampleMappingBlock
    {
        public VideoDecoderSubSampleMappingBlock
        (
            uint? clearSize = null,
            uint? encryptedSize = null
        ) : this()
        {
            if (clearSize is not null)
            {
                ClearSize = clearSize.Value;
            }

            if (encryptedSize is not null)
            {
                EncryptedSize = encryptedSize.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ClearSize")]
        public uint ClearSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncryptedSize")]
        public uint EncryptedSize;
    }
}
