// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT
{
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Action"]/*'/>
    [NativeTypeName("DEVICE_DSM_ACTION")]
    public uint Action;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OperationStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OperationStatus;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.ExtendedError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExtendedError;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.TargetDetailedError"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TargetDetailedError;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.ReservedStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ReservedStatus;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OutputBlockOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OutputBlockOffset;
    /// <include file='DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.xml' path='doc/member[@name="DEVICE_MANAGE_DATA_SET_ATTRIBUTES_OUTPUT.OutputBlockLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OutputBlockLength;
}