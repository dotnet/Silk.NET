// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFSensorStreamType.xml' path='doc/member[@name="MFSensorStreamType"]/*'/>
public enum MFSensorStreamType
{
    /// <include file='MFSensorStreamType.xml' path='doc/member[@name="MFSensorStreamType.MFSensorStreamType_Unknown"]/*'/>
    MFSensorStreamType_Unknown = 0,
    /// <include file='MFSensorStreamType.xml' path='doc/member[@name="MFSensorStreamType.MFSensorStreamType_Input"]/*'/>
    MFSensorStreamType_Input = (MFSensorStreamType_Unknown + 1),
    /// <include file='MFSensorStreamType.xml' path='doc/member[@name="MFSensorStreamType.MFSensorStreamType_Output"]/*'/>
    MFSensorStreamType_Output = (MFSensorStreamType_Input + 1),
}