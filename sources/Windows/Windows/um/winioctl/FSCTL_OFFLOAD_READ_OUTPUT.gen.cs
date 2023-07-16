// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FSCTL_OFFLOAD_READ_OUTPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_OUTPUT"]/*'/>
public unsafe partial struct FSCTL_OFFLOAD_READ_OUTPUT
{
    /// <include file='FSCTL_OFFLOAD_READ_OUTPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='FSCTL_OFFLOAD_READ_OUTPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FSCTL_OFFLOAD_READ_OUTPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_OUTPUT.TransferLength"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong TransferLength;
    /// <include file='FSCTL_OFFLOAD_READ_OUTPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_OUTPUT.Token"]/*'/>
    [NativeTypeName("BYTE[512]")]
    public fixed byte Token[512];
}