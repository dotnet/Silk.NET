// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX"]/*'/>
public partial struct VIRTUALIZATION_INSTANCE_INFO_INPUT_EX
{
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.HeaderSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort HeaderSize;
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.NotificationInfoSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NotificationInfoSize;
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.NotificationInfoOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort NotificationInfoOffset;
    /// <include file='VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.xml' path='doc/member[@name="VIRTUALIZATION_INSTANCE_INFO_INPUT_EX.ProviderMajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ProviderMajorVersion;
}