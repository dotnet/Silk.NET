// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_PHYSICAL_ADAPTER_DATA
{
    [NativeTypeName("DWORD")]
    public uint AdapterId;
    public STORAGE_COMPONENT_HEALTH_STATUS HealthStatus;
    public STORAGE_PROTOCOL_TYPE CommandProtocol;
    public STORAGE_SPEC_VERSION SpecVersion;

    [NativeTypeName("BYTE[8]")]
    public _Vendor_e__FixedBuffer Vendor;

    [NativeTypeName("BYTE[40]")]
    public _Model_e__FixedBuffer Model;

    [NativeTypeName("BYTE[16]")]
    public _FirmwareRevision_e__FixedBuffer FirmwareRevision;

    [NativeTypeName("BYTE[32]")]
    public _PhysicalLocation_e__FixedBuffer PhysicalLocation;

    [NativeTypeName("BOOLEAN")]
    public byte ExpanderConnected;

    [NativeTypeName("BYTE[3]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    [NativeTypeName("DWORD[3]")]
    public _Reserved1_e__FixedBuffer Reserved1;

    [InlineArray(8)]
    public partial struct _Vendor_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(40)]
    public partial struct _Model_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _FirmwareRevision_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _PhysicalLocation_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(3)]
    public partial struct _Reserved1_e__FixedBuffer
    {
        public uint e0;
    }
}
