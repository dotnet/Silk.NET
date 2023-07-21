// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HTTP_VERSION_INFO.xml' path='doc/member[@name="HTTP_VERSION_INFO"]/*' />
public partial struct HTTP_VERSION_INFO
{
    /// <include file='HTTP_VERSION_INFO.xml' path='doc/member[@name="HTTP_VERSION_INFO.dwMajorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    /// <include file='HTTP_VERSION_INFO.xml' path='doc/member[@name="HTTP_VERSION_INFO.dwMinorVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;
}
