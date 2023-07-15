// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES"]/*'/>
public partial struct DEVICE_MANAGE_DATA_SET_ATTRIBUTES
{
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Action"]/*'/>
    [NativeTypeName("DEVICE_DSM_ACTION")]
    public uint Action;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.ParameterBlockOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ParameterBlockOffset;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.ParameterBlockLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ParameterBlockLength;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.DataSetRangesOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSetRangesOffset;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES.DataSetRangesLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DataSetRangesLength;
}