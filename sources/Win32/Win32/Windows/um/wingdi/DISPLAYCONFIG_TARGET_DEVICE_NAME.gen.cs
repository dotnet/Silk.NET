// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;
    public DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS flags;
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;

    [NativeTypeName("UINT16")]
    public ushort edidManufactureId;

    [NativeTypeName("UINT16")]
    public ushort edidProductCodeId;

    [NativeTypeName("UINT32")]
    public uint connectorInstance;

    [NativeTypeName("WCHAR[64]")]
    public _monitorFriendlyDeviceName_e__FixedBuffer monitorFriendlyDeviceName;

    [NativeTypeName("WCHAR[128]")]
    public _monitorDevicePath_e__FixedBuffer monitorDevicePath;

    [InlineArray(64)]
    public partial struct _monitorFriendlyDeviceName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(128)]
    public partial struct _monitorDevicePath_e__FixedBuffer
    {
        public ushort e0;
    }
}
