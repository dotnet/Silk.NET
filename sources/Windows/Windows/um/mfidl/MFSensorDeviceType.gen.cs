// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType"]/*'/>
public enum MFSensorDeviceType
{
    /// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType.MFSensorDeviceType_Unknown"]/*'/>
    MFSensorDeviceType_Unknown = 0,
    /// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType.MFSensorDeviceType_Device"]/*'/>
    MFSensorDeviceType_Device = (MFSensorDeviceType_Unknown + 1),
    /// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType.MFSensorDeviceType_MediaSource"]/*'/>
    MFSensorDeviceType_MediaSource = (MFSensorDeviceType_Device + 1),
    /// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType.MFSensorDeviceType_FrameProvider"]/*'/>
    MFSensorDeviceType_FrameProvider = (MFSensorDeviceType_MediaSource + 1),
    /// <include file='MFSensorDeviceType.xml' path='doc/member[@name="MFSensorDeviceType.MFSensorDeviceType_SensorTransform"]/*'/>
    MFSensorDeviceType_SensorTransform = (MFSensorDeviceType_FrameProvider + 1),
}