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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L13459_C5")]
    public unsafe partial struct AnonymousRecordD3d12L13459C5
    {
        public AnonymousRecordD3d12L13459C5
        (
            DeviceRemovedExtendedData? dred10 = null,
            DeviceRemovedExtendedData1? dred11 = null,
            DeviceRemovedExtendedData2? dred12 = null
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
    }
}
