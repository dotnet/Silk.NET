// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAGS")]
    public enum DeviceFactoryFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_NONE")]
        DeviceFactoryFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowReturningExistingDevice\"")]
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_EXISTING_DEVICE")]
        DeviceFactoryFlagAllowReturningExistingDevice = 0x1,
        [Obsolete("Deprecated in favour of \"AllowReturningIncompatibleExistingDevice\"")]
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_INCOMPATIBLE_EXISTING_DEVICE")]
        DeviceFactoryFlagAllowReturningIncompatibleExistingDevice = 0x2,
        [Obsolete("Deprecated in favour of \"DisallowStoringNewDeviceAsSingleton\"")]
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_DISALLOW_STORING_NEW_DEVICE_AS_SINGLETON")]
        DeviceFactoryFlagDisallowStoringNewDeviceAsSingleton = 0x4,
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_EXISTING_DEVICE")]
        AllowReturningExistingDevice = 0x1,
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_ALLOW_RETURNING_INCOMPATIBLE_EXISTING_DEVICE")]
        AllowReturningIncompatibleExistingDevice = 0x2,
        [NativeName("Name", "D3D12_DEVICE_FACTORY_FLAG_DISALLOW_STORING_NEW_DEVICE_AS_SINGLETON")]
        DisallowStoringNewDeviceAsSingleton = 0x4,
    }
}
