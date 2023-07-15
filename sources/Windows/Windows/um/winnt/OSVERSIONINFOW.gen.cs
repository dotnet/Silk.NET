// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW"]/*'/>
public unsafe partial struct OSVERSIONINFOW
{
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.dwOSVersionInfoSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.dwMajorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.dwMinorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.dwBuildNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.dwPlatformId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPlatformId;
    /// <include file='OSVERSIONINFOW.xml' path='doc/member[@name="OSVERSIONINFOW.szCSDVersion"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort szCSDVersion[128];
}