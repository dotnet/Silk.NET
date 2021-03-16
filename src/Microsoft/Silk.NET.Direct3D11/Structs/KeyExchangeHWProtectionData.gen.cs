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
    [NativeName("Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA")]
    public unsafe partial struct KeyExchangeHWProtectionData
    {
        public KeyExchangeHWProtectionData
        (
            uint? hWProtectionFunctionID = null,
            KeyExchangeHWProtectionInputData* pInputData = null,
            KeyExchangeHWProtectionOutputData* pOutputData = null,
            int? status = null
        ) : this()
        {
            if (hWProtectionFunctionID is not null)
            {
                HWProtectionFunctionID = hWProtectionFunctionID.Value;
            }

            if (pInputData is not null)
            {
                PInputData = pInputData;
            }

            if (pOutputData is not null)
            {
                POutputData = pOutputData;
            }

            if (status is not null)
            {
                Status = status.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "HWProtectionFunctionID")]
        public uint HWProtectionFunctionID;

        [NativeName("Type", "D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA *")]
        [NativeName("Type.Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA *")]
        [NativeName("Name", "pInputData")]
        public KeyExchangeHWProtectionInputData* PInputData;

        [NativeName("Type", "D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA *")]
        [NativeName("Type.Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA *")]
        [NativeName("Name", "pOutputData")]
        public KeyExchangeHWProtectionOutputData* POutputData;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "Status")]
        public int Status;
    }
}
