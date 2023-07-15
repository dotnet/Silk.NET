// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='VERIFY_INFORMATION.xml' path='doc/member[@name="VERIFY_INFORMATION"]/*'/>
public partial struct VERIFY_INFORMATION
{
    /// <include file='VERIFY_INFORMATION.xml' path='doc/member[@name="VERIFY_INFORMATION.StartingOffset"]/*'/>
    public LARGE_INTEGER StartingOffset;
    /// <include file='VERIFY_INFORMATION.xml' path='doc/member[@name="VERIFY_INFORMATION.Length"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Length;
}