// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO"]/*'/>
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_FILE_BASIC_INFO
{
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.IsDirectory"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte IsDirectory;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.FileSize"]/*'/>
    [NativeTypeName("INT64")]
    public long FileSize;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.CreationTime"]/*'/>
    public LARGE_INTEGER CreationTime;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.LastAccessTime"]/*'/>
    public LARGE_INTEGER LastAccessTime;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.LastWriteTime"]/*'/>
    public LARGE_INTEGER LastWriteTime;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.ChangeTime"]/*'/>
    public LARGE_INTEGER ChangeTime;
    /// <include file='PRJ_FILE_BASIC_INFO.xml' path='doc/member[@name="PRJ_FILE_BASIC_INFO.FileAttributes"]/*'/>
    [NativeTypeName("UINT32")]
    public uint FileAttributes;
}