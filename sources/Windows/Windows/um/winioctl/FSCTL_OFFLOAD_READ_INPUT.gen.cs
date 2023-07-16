// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT"]/*'/>
public partial struct FSCTL_OFFLOAD_READ_INPUT
{
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.TokenTimeToLive"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TokenTimeToLive;
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.FileOffset"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong FileOffset;
    /// <include file='FSCTL_OFFLOAD_READ_INPUT.xml' path='doc/member[@name="FSCTL_OFFLOAD_READ_INPUT.CopyLength"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong CopyLength;
}