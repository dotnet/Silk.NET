// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW"]/*'/>
public unsafe partial struct STARTUPINFOW
{
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpReserved"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpReserved;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpDesktop"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpDesktop;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpTitle"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpTitle;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwX"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwX;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwY"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwY;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwXSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwXSize;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwYSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwYSize;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwXCountChars"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwXCountChars;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwYCountChars"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwYCountChars;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwFillAttribute"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFillAttribute;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.wShowWindow"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wShowWindow;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.cbReserved2"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbReserved2;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.lpReserved2"]/*'/>
    [NativeTypeName("LPBYTE")]
    public byte* lpReserved2;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdInput"]/*'/>
    public HANDLE hStdInput;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdOutput"]/*'/>
    public HANDLE hStdOutput;
    /// <include file='STARTUPINFOW.xml' path='doc/member[@name="STARTUPINFOW.hStdError"]/*'/>
    public HANDLE hStdError;
}