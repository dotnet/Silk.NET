// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFSensorDeviceMode.xml' path='doc/member[@name="MFSensorDeviceMode"]/*'/>
public enum MFSensorDeviceMode
{
    /// <include file='MFSensorDeviceMode.xml' path='doc/member[@name="MFSensorDeviceMode.MFSensorDeviceMode_Controller"]/*'/>
    MFSensorDeviceMode_Controller = 0,
    /// <include file='MFSensorDeviceMode.xml' path='doc/member[@name="MFSensorDeviceMode.MFSensorDeviceMode_Shared"]/*'/>
    MFSensorDeviceMode_Shared = (MFSensorDeviceMode_Controller + 1),
}