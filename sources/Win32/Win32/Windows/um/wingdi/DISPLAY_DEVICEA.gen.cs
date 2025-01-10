// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAY_DEVICEA
{
    [NativeTypeName("DWORD")]
    public uint cb;

    [NativeTypeName("CHAR[32]")]
    public _DeviceName_e__FixedBuffer DeviceName;

    [NativeTypeName("CHAR[128]")]
    public _DeviceString_e__FixedBuffer DeviceString;

    [NativeTypeName("DWORD")]
    public uint StateFlags;

    [NativeTypeName("CHAR[128]")]
    public _DeviceID_e__FixedBuffer DeviceID;

    [NativeTypeName("CHAR[128]")]
    public _DeviceKey_e__FixedBuffer DeviceKey;

    [InlineArray(32)]
    public partial struct _DeviceName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(128)]
    public partial struct _DeviceString_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(128)]
    public partial struct _DeviceID_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(128)]
    public partial struct _DeviceKey_e__FixedBuffer
    {
        public sbyte e0;
    }
}
