// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA"]/*' />
public unsafe partial struct STARTUPINFOA
{
    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpReserved"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpReserved;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpDesktop"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpDesktop;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpTitle"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* lpTitle;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwX"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwX;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwY"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwY;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwXSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwXSize;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwYSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwYSize;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwXCountChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwXCountChars;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwYCountChars"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwYCountChars;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwFillAttribute"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFillAttribute;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.wShowWindow"]/*' />
    [NativeTypeName("WORD")]
    public ushort wShowWindow;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.cbReserved2"]/*' />
    [NativeTypeName("WORD")]
    public ushort cbReserved2;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.lpReserved2"]/*' />
    [NativeTypeName("LPBYTE")]
    public byte* lpReserved2;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdInput"]/*' />
    public HANDLE hStdInput;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdOutput"]/*' />
    public HANDLE hStdOutput;

    /// <include file='STARTUPINFOA.xml' path='doc/member[@name="STARTUPINFOA.hStdError"]/*' />
    public HANDLE hStdError;
}
