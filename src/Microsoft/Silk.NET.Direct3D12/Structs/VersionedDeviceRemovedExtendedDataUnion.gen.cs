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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L15803_C5")]
    public unsafe partial struct VersionedDeviceRemovedExtendedDataUnion
    {
        public VersionedDeviceRemovedExtendedDataUnion
        (
            DeviceRemovedExtendedData? dred10 = null,
            DeviceRemovedExtendedData1? dred11 = null,
            DeviceRemovedExtendedData2? dred12 = null,
            DeviceRemovedExtendedData3? dred13 = null
        ) : this()
        {
            if (dred10 is not null)
            {
                Dred10 = dred10.Value;
            }

            if (dred11 is not null)
            {
                Dred11 = dred11.Value;
            }

            if (dred12 is not null)
            {
                Dred12 = dred12.Value;
            }

            if (dred13 is not null)
            {
                Dred13 = dred13.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_DEVICE_REMOVED_EXTENDED_DATA")]
        [NativeName("Type.Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA")]
        [NativeName("Name", "Dred_1_0")]
        public DeviceRemovedExtendedData Dred10;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_DEVICE_REMOVED_EXTENDED_DATA1")]
        [NativeName("Type.Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA1")]
        [NativeName("Name", "Dred_1_1")]
        public DeviceRemovedExtendedData1 Dred11;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_DEVICE_REMOVED_EXTENDED_DATA2")]
        [NativeName("Type.Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA2")]
        [NativeName("Name", "Dred_1_2")]
        public DeviceRemovedExtendedData2 Dred12;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_DEVICE_REMOVED_EXTENDED_DATA3")]
        [NativeName("Type.Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA3")]
        [NativeName("Name", "Dred_1_3")]
        public DeviceRemovedExtendedData3 Dred13;
    }
}
