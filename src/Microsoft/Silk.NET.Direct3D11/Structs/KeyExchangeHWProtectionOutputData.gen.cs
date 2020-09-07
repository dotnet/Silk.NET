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
    [NativeName("Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA")]
    public unsafe partial struct KeyExchangeHWProtectionOutputData
    {
        public KeyExchangeHWProtectionOutputData
        (
            uint privateDataSize = default,
            uint maxHWProtectionDataSize = default,
            uint hWProtectionDataSize = default,
            ulong transportTime = default,
            ulong executionTime = default
        )
        {
            PrivateDataSize = privateDataSize;
            MaxHWProtectionDataSize = maxHWProtectionDataSize;
            HWProtectionDataSize = hWProtectionDataSize;
            TransportTime = transportTime;
            ExecutionTime = executionTime;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PrivateDataSize")]
        public uint PrivateDataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaxHWProtectionDataSize")]
        public uint MaxHWProtectionDataSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "HWProtectionDataSize")]
        public uint HWProtectionDataSize;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "TransportTime")]
        public ulong TransportTime;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ExecutionTime")]
        public ulong ExecutionTime;
        [NativeName("Type", "BYTE [4]")]
        [NativeName("Type.Name", "BYTE [4]")]
        [NativeName("Name", "pbOutput")]
        public fixed byte PbOutput[4];
    }
}
