// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty"]/*'/>
public enum CameraControlProperty
{
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Pan"]/*'/>
    CameraControl_Pan = 0,
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Tilt"]/*'/>
    CameraControl_Tilt = (CameraControl_Pan + 1),
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Roll"]/*'/>
    CameraControl_Roll = (CameraControl_Tilt + 1),
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Zoom"]/*'/>
    CameraControl_Zoom = (CameraControl_Roll + 1),
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Exposure"]/*'/>
    CameraControl_Exposure = (CameraControl_Zoom + 1),
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Iris"]/*'/>
    CameraControl_Iris = (CameraControl_Exposure + 1),
    /// <include file='CameraControlProperty.xml' path='doc/member[@name="CameraControlProperty.CameraControl_Focus"]/*'/>
    CameraControl_Focus = (CameraControl_Iris + 1),
}