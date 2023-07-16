// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR"]/*'/>
public partial struct STORAGE_RPMB_DESCRIPTOR
{
    /// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR.SizeInBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeInBytes;
    /// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR.MaxReliableWriteSizeInBytes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxReliableWriteSizeInBytes;
    /// <include file='STORAGE_RPMB_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_RPMB_DESCRIPTOR.FrameFormat"]/*'/>
    public STORAGE_RPMB_FRAME_TYPE FrameFormat;
}