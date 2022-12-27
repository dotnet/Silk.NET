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
    [NativeName("Name", "D3D11_KEY_EXCHANGE_HW_PROTECTION_OUTPUT_DATA")]
    public unsafe partial struct KeyExchangeHWProtectionOutputData
    {
        public KeyExchangeHWProtectionOutputData
        (
            uint? privateDataSize = null,
            uint? maxHWProtectionDataSize = null,
            uint? hWProtectionDataSize = null,
            ulong? transportTime = null,
            ulong? executionTime = null
        ) : this()
        {
            if (privateDataSize is not null)
            {
                PrivateDataSize = privateDataSize.Value;
            }

            if (maxHWProtectionDataSize is not null)
            {
                MaxHWProtectionDataSize = maxHWProtectionDataSize.Value;
            }

            if (hWProtectionDataSize is not null)
            {
                HWProtectionDataSize = hWProtectionDataSize.Value;
            }

            if (transportTime is not null)
            {
                TransportTime = transportTime.Value;
            }

            if (executionTime is not null)
            {
                ExecutionTime = executionTime.Value;
            }
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
        [NativeName("Type", "BYTE[4]")]
        [NativeName("Type.Name", "BYTE[4]")]
        [NativeName("Name", "pbOutput")]
        public fixed byte PbOutput[4];
    }
}
