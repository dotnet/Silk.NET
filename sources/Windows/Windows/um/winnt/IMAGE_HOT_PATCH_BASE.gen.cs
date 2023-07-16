// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE"]/*'/>
public partial struct IMAGE_HOT_PATCH_BASE
{
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.SequenceNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SequenceNumber;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.OriginalTimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OriginalTimeDateStamp;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.OriginalCheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OriginalCheckSum;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.CodeIntegrityInfo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CodeIntegrityInfo;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.CodeIntegritySize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CodeIntegritySize;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.PatchTable"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PatchTable;
    /// <include file='IMAGE_HOT_PATCH_BASE.xml' path='doc/member[@name="IMAGE_HOT_PATCH_BASE.BufferOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BufferOffset;
}