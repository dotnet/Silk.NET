// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GET_DISK_ATTRIBUTES.xml' path='doc/member[@name="GET_DISK_ATTRIBUTES"]/*'/>
public partial struct GET_DISK_ATTRIBUTES
{
    /// <include file='GET_DISK_ATTRIBUTES.xml' path='doc/member[@name="GET_DISK_ATTRIBUTES.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='GET_DISK_ATTRIBUTES.xml' path='doc/member[@name="GET_DISK_ATTRIBUTES.Reserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved1;
    /// <include file='GET_DISK_ATTRIBUTES.xml' path='doc/member[@name="GET_DISK_ATTRIBUTES.Attributes"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Attributes;
}