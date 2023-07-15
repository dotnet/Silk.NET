// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DRIVE_LAYOUT_INFORMATION_MBR.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_MBR"]/*'/>
public partial struct DRIVE_LAYOUT_INFORMATION_MBR
{
    /// <include file='DRIVE_LAYOUT_INFORMATION_MBR.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_MBR.Signature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Signature;
    /// <include file='DRIVE_LAYOUT_INFORMATION_MBR.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION_MBR.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
}