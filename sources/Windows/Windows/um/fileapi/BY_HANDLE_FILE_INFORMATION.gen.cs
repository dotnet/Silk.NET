// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION"]/*'/>
public partial struct BY_HANDLE_FILE_INFORMATION
{
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.dwFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.ftCreationTime"]/*'/>
    public FILETIME ftCreationTime;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.ftLastAccessTime"]/*'/>
    public FILETIME ftLastAccessTime;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.ftLastWriteTime"]/*'/>
    public FILETIME ftLastWriteTime;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.dwVolumeSerialNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVolumeSerialNumber;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.nFileSizeHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.nFileSizeLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.nNumberOfLinks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nNumberOfLinks;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.nFileIndexHigh"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileIndexHigh;
    /// <include file='BY_HANDLE_FILE_INFORMATION.xml' path='doc/member[@name="BY_HANDLE_FILE_INFORMATION.nFileIndexLow"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFileIndexLow;
}