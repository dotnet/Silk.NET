// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO"]/*'/>
public partial struct FILE_BASIC_INFO
{
    /// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO.CreationTime"]/*'/>
    public LARGE_INTEGER CreationTime;
    /// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO.LastAccessTime"]/*'/>
    public LARGE_INTEGER LastAccessTime;
    /// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO.LastWriteTime"]/*'/>
    public LARGE_INTEGER LastWriteTime;
    /// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO.ChangeTime"]/*'/>
    public LARGE_INTEGER ChangeTime;
    /// <include file='FILE_BASIC_INFO.xml' path='doc/member[@name="FILE_BASIC_INFO.FileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileAttributes;
}