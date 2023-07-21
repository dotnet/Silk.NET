// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_HEADER_NAME.xml' path='doc/member[@name="WINHTTP_HEADER_NAME"]/*' />
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct WINHTTP_HEADER_NAME
{
    /// <include file='WINHTTP_HEADER_NAME.xml' path='doc/member[@name="WINHTTP_HEADER_NAME.pwszName"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("PCWSTR")]
    public ushort* pwszName;

    /// <include file='WINHTTP_HEADER_NAME.xml' path='doc/member[@name="WINHTTP_HEADER_NAME.pszName"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("PCSTR")]
    public sbyte* pszName;
}
