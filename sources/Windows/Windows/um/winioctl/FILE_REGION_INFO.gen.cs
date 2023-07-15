// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_REGION_INFO.xml' path='doc/member[@name="FILE_REGION_INFO"]/*'/>
public partial struct FILE_REGION_INFO
{
    /// <include file='FILE_REGION_INFO.xml' path='doc/member[@name="FILE_REGION_INFO.FileOffset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long FileOffset;
    /// <include file='FILE_REGION_INFO.xml' path='doc/member[@name="FILE_REGION_INFO.Length"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Length;
    /// <include file='FILE_REGION_INFO.xml' path='doc/member[@name="FILE_REGION_INFO.Usage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Usage;
    /// <include file='FILE_REGION_INFO.xml' path='doc/member[@name="FILE_REGION_INFO.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
}