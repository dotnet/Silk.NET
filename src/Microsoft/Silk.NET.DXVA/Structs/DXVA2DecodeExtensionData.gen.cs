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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_DecodeExtensionData")]
    public unsafe partial struct DXVA2DecodeExtensionData
    {
        public DXVA2DecodeExtensionData
        (
            uint? function = null,
            void* pPrivateInputData = null,
            uint? privateInputDataSize = null,
            void* pPrivateOutputData = null,
            uint? privateOutputDataSize = null
        ) : this()
        {
            if (function is not null)
            {
                Function = function.Value;
            }

            if (pPrivateInputData is not null)
            {
                PPrivateInputData = pPrivateInputData;
            }

            if (privateInputDataSize is not null)
            {
                PrivateInputDataSize = privateInputDataSize.Value;
            }

            if (pPrivateOutputData is not null)
            {
                PPrivateOutputData = pPrivateOutputData;
            }

            if (privateOutputDataSize is not null)
            {
                PrivateOutputDataSize = privateOutputDataSize.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Function")]
        public uint Function;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pPrivateInputData")]
        public void* PPrivateInputData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateInputDataSize")]
        public uint PrivateInputDataSize;

        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "pPrivateOutputData")]
        public void* PPrivateOutputData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateOutputDataSize")]
        public uint PrivateOutputDataSize;
    }
}
