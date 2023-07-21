// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILETIME.xml' path='doc/member[@name="FILETIME"]/*' />
public partial struct FILETIME
{
    /// <include file='FILETIME.xml' path='doc/member[@name="FILETIME.dwLowDateTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLowDateTime;

    /// <include file='FILETIME.xml' path='doc/member[@name="FILETIME.dwHighDateTime"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHighDateTime;
}
