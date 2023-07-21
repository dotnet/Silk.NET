// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_MODE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO_TYPE"]/*' />
public enum DISPLAYCONFIG_MODE_INFO_TYPE
{
    /// <include file='DISPLAYCONFIG_MODE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO_TYPE.DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE"]/*' />
    DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1,

    /// <include file='DISPLAYCONFIG_MODE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO_TYPE.DISPLAYCONFIG_MODE_INFO_TYPE_TARGET"]/*' />
    DISPLAYCONFIG_MODE_INFO_TYPE_TARGET = 2,

    /// <include file='DISPLAYCONFIG_MODE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO_TYPE.DISPLAYCONFIG_MODE_INFO_TYPE_DESKTOP_IMAGE"]/*' />
    DISPLAYCONFIG_MODE_INFO_TYPE_DESKTOP_IMAGE = 3,

    /// <include file='DISPLAYCONFIG_MODE_INFO_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_MODE_INFO_TYPE.DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32"]/*' />
    DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = unchecked((int)(0xFFFFFFFF)),
}
