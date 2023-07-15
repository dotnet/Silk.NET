// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR"]/*'/>
public partial struct STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR
{
    /// <include file='STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_HW_ENDURANCE_DATA_DESCRIPTOR.EnduranceInfo"]/*'/>
    public STORAGE_HW_ENDURANCE_INFO EnduranceInfo;
}