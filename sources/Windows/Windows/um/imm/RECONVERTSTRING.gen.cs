// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING"]/*' />
public partial struct RECONVERTSTRING
{
    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwStrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStrLen;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwStrOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStrOffset;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwCompStrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCompStrLen;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwCompStrOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCompStrOffset;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwTargetStrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTargetStrLen;

    /// <include file='RECONVERTSTRING.xml' path='doc/member[@name="RECONVERTSTRING.dwTargetStrOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTargetStrOffset;
}
