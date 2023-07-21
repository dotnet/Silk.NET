// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_PATH_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_INFO"]/*' />
public partial struct DISPLAYCONFIG_PATH_INFO
{
    /// <include file='DISPLAYCONFIG_PATH_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_INFO.sourceInfo"]/*' />
    public DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;

    /// <include file='DISPLAYCONFIG_PATH_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_INFO.targetInfo"]/*' />
    public DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;

    /// <include file='DISPLAYCONFIG_PATH_INFO.xml' path='doc/member[@name="DISPLAYCONFIG_PATH_INFO.flags"]/*' />
    [NativeTypeName("UINT32")]
    public uint flags;
}
