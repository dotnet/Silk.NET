// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CREATE_DISK_MBR.xml' path='doc/member[@name="CREATE_DISK_MBR"]/*'/>
public partial struct CREATE_DISK_MBR
{
    /// <include file='CREATE_DISK_MBR.xml' path='doc/member[@name="CREATE_DISK_MBR.Signature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Signature;
}