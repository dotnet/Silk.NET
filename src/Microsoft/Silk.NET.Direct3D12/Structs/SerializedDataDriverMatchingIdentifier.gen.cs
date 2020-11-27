// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER")]
    public unsafe partial struct SerializedDataDriverMatchingIdentifier
    {
        public SerializedDataDriverMatchingIdentifier
        (
            Guid? driverOpaqueGUID = null
        ) : this()
        {
            if (driverOpaqueGUID is not null)
            {
                DriverOpaqueGUID = driverOpaqueGUID.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "DriverOpaqueGUID")]
        public Guid DriverOpaqueGUID;
        [NativeName("Type", "BYTE [16]")]
        [NativeName("Type.Name", "BYTE [16]")]
        [NativeName("Name", "DriverOpaqueVersioningData")]
        public fixed byte DriverOpaqueVersioningData[16];
    }
}
