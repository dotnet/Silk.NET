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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_COMMAND_SIGNATURE_DESC")]
    public unsafe partial struct CommandSignatureDesc
    {
        public CommandSignatureDesc
        (
            uint? byteStride = null,
            uint? numArgumentDescs = null,
            IndirectArgumentDesc* pArgumentDescs = null,
            uint? nodeMask = null
        ) : this()
        {
            if (byteStride is not null)
            {
                ByteStride = byteStride.Value;
            }

            if (numArgumentDescs is not null)
            {
                NumArgumentDescs = numArgumentDescs.Value;
            }

            if (pArgumentDescs is not null)
            {
                PArgumentDescs = pArgumentDescs;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ByteStride")]
        public uint ByteStride;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumArgumentDescs")]
        public uint NumArgumentDescs;

        [NativeName("Type", "const D3D12_INDIRECT_ARGUMENT_DESC *")]
        [NativeName("Type.Name", "const D3D12_INDIRECT_ARGUMENT_DESC *")]
        [NativeName("Name", "pArgumentDescs")]
        public IndirectArgumentDesc* PArgumentDescs;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;
    }
}
