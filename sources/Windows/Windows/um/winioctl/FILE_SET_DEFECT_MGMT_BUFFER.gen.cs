// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_SET_DEFECT_MGMT_BUFFER.xml' path='doc/member[@name="FILE_SET_DEFECT_MGMT_BUFFER"]/*'/>
public partial struct FILE_SET_DEFECT_MGMT_BUFFER
{
    /// <include file='FILE_SET_DEFECT_MGMT_BUFFER.xml' path='doc/member[@name="FILE_SET_DEFECT_MGMT_BUFFER.Disable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Disable;
}