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
    [NativeName("Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_DATA")]
    public unsafe partial struct KeyExchangeHWProtectionData
    {
        public KeyExchangeHWProtectionData
        (
            uint hWProtectionFunctionID = default,
            KeyExchangeHWProtectionInputData* pInputData = default,
            KeyExchangeHWProtectionOutputData* pOutputData = default,
            int status = default
        )
        {
            HWProtectionFunctionID = hWProtectionFunctionID;
            PInputData = pInputData;
            POutputData = pOutputData;
            Status = status;
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
