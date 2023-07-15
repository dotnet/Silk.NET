// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_CAMERA_CONTROL_RANGE_INFO.xml' path='doc/member[@name="MF_CAMERA_CONTROL_RANGE_INFO"]/*'/>
public partial struct MF_CAMERA_CONTROL_RANGE_INFO
{
    /// <include file='MF_CAMERA_CONTROL_RANGE_INFO.xml' path='doc/member[@name="MF_CAMERA_CONTROL_RANGE_INFO.minValue"]/*'/>
    [NativeTypeName("LONG")]
    public int minValue;
    /// <include file='MF_CAMERA_CONTROL_RANGE_INFO.xml' path='doc/member[@name="MF_CAMERA_CONTROL_RANGE_INFO.maxValue"]/*'/>
    [NativeTypeName("LONG")]
    public int maxValue;
    /// <include file='MF_CAMERA_CONTROL_RANGE_INFO.xml' path='doc/member[@name="MF_CAMERA_CONTROL_RANGE_INFO.stepValue"]/*'/>
    [NativeTypeName("LONG")]
    public int stepValue;
    /// <include file='MF_CAMERA_CONTROL_RANGE_INFO.xml' path='doc/member[@name="MF_CAMERA_CONTROL_RANGE_INFO.defaultValue"]/*'/>
    [NativeTypeName("LONG")]
    public int defaultValue;
}