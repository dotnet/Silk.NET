// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.i2c.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct ProviderI2cTransferResult
{
    [NativeTypeName("ABI::Windows::Devices::I2c::Provider::ProviderI2cTransferStatus")]
    public ProviderI2cTransferStatus Status;

    [NativeTypeName("UINT32")]
    public uint BytesTransferred;
}
