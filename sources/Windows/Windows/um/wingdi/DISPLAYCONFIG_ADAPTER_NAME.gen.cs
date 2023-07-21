// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_ADAPTER_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_ADAPTER_NAME"]/*' />
public unsafe partial struct DISPLAYCONFIG_ADAPTER_NAME
{
    /// <include file='DISPLAYCONFIG_ADAPTER_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_ADAPTER_NAME.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_ADAPTER_NAME.xml' path='doc/member[@name="DISPLAYCONFIG_ADAPTER_NAME.adapterDevicePath"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort adapterDevicePath[128];
}
