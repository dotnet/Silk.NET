// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_TARGET_PREFERRED_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_PREFERRED_MODE"]/*' />
public partial struct DISPLAYCONFIG_TARGET_PREFERRED_MODE
{
    /// <include file='DISPLAYCONFIG_TARGET_PREFERRED_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_PREFERRED_MODE.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_TARGET_PREFERRED_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_PREFERRED_MODE.width"]/*' />
    [NativeTypeName("UINT32")]
    public uint width;

    /// <include file='DISPLAYCONFIG_TARGET_PREFERRED_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_PREFERRED_MODE.height"]/*' />
    [NativeTypeName("UINT32")]
    public uint height;

    /// <include file='DISPLAYCONFIG_TARGET_PREFERRED_MODE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_PREFERRED_MODE.targetMode"]/*' />
    public DISPLAYCONFIG_TARGET_MODE targetMode;
}
