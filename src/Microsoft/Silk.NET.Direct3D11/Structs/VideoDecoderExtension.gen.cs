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
    [NativeName("Name", "D3D11_VIDEO_DECODER_EXTENSION")]
    public unsafe partial struct VideoDecoderExtension
    {
        public VideoDecoderExtension
        (
            uint function = default,
            void* pPrivateInputData = default,
            uint privateInputDataSize = default,
            void* pPrivateOutputData = default,
            uint privateOutputDataSize = default,
            uint resourceCount = default,
            ID3D11Resource** ppResourceList = default
        )
        {
            Function = function;
            PPrivateInputData = pPrivateInputData;
            PrivateInputDataSize = privateInputDataSize;
            PPrivateOutputData = pPrivateOutputData;
            PrivateOutputDataSize = privateOutputDataSize;
            ResourceCount = resourceCount;
            PpResourceList = ppResourceList;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Function")]
        public uint Function;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPrivateInputData")]
        public void* PPrivateInputData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateInputDataSize")]
        public uint PrivateInputDataSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pPrivateOutputData")]
        public void* PPrivateOutputData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateOutputDataSize")]
        public uint PrivateOutputDataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ResourceCount")]
        public uint ResourceCount;

        [NativeName("Type", "ID3D11Resource **")]
        [NativeName("Type.Name", "ID3D11Resource **")]
        [NativeName("Name", "ppResourceList")]
        public ID3D11Resource** PpResourceList;
    }
}
