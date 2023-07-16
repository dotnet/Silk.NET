// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO"]/*'/>
public partial struct IMAGE_HOT_PATCH_INFO
{
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.SequenceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SequenceNumber;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.BaseImageList"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseImageList;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.BaseImageCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseImageCount;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.BufferOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BufferOffset;
    /// <include file='IMAGE_HOT_PATCH_INFO.xml' path='doc/member[@name="IMAGE_HOT_PATCH_INFO.ExtraPatchSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExtraPatchSize;
}