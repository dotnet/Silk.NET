// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW"]/*'/>
public unsafe partial struct WIN32_FIND_DATAW
{
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftCreationTime"]/*'/>
    public FILETIME ftCreationTime;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastAccessTime"]/*'/>
    public FILETIME ftLastAccessTime;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastWriteTime"]/*'/>
    public FILETIME ftLastWriteTime;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved0"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved0;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cFileName"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort cFileName[260];
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cAlternateFileName"]/*'/>
    [NativeTypeName("WCHAR[14]")]
    public fixed ushort cAlternateFileName[14];
}