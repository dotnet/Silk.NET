// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA"]/*'/>
public partial struct WIN32_FILE_ATTRIBUTE_DATA
{
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.dwFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.ftCreationTime"]/*'/>
    public FILETIME ftCreationTime;
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.ftLastAccessTime"]/*'/>
    public FILETIME ftLastAccessTime;
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.ftLastWriteTime"]/*'/>
    public FILETIME ftLastWriteTime;
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.nFileSizeHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;
    /// <include file='WIN32_FILE_ATTRIBUTE_DATA.xml' path='doc/member[@name="WIN32_FILE_ATTRIBUTE_DATA.nFileSizeLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;
}