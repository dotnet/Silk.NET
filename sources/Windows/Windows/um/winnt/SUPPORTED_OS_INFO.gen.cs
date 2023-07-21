// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SUPPORTED_OS_INFO.xml' path='doc/member[@name="SUPPORTED_OS_INFO"]/*' />
public partial struct SUPPORTED_OS_INFO
{
    /// <include file='SUPPORTED_OS_INFO.xml' path='doc/member[@name="SUPPORTED_OS_INFO.MajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    /// <include file='SUPPORTED_OS_INFO.xml' path='doc/member[@name="SUPPORTED_OS_INFO.MinorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorVersion;
}
