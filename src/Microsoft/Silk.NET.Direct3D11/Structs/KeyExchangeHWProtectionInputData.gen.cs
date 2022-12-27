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
    [NativeName("Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA")]
    public unsafe partial struct KeyExchangeHWProtectionInputData
    {
        public KeyExchangeHWProtectionInputData
        (
            uint? privateDataSize = null,
            uint? hWProtectionDataSize = null
        ) : this()
        {
            if (privateDataSize is not null)
            {
                PrivateDataSize = privateDataSize.Value;
            }

            if (hWProtectionDataSize is not null)
            {
                HWProtectionDataSize = hWProtectionDataSize.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateDataSize")]
        public uint PrivateDataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "HWProtectionDataSize")]
        public uint HWProtectionDataSize;
        [NativeName("Type", "BYTE[4]")]
        [NativeName("Type.Name", "BYTE[4]")]
        [NativeName("Name", "pbInput")]
        public fixed byte PbInput[4];
    }
}
