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
        [NativeName("Type", "BYTE[16]")]
        [NativeName("Type.Name", "BYTE[16]")]
        [NativeName("Name", "DriverOpaqueVersioningData")]
        public fixed byte DriverOpaqueVersioningData[16];
    }
}
