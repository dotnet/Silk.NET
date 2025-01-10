// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum CameraControlProperty
{
    CameraControl_Pan = 0,
    CameraControl_Tilt = (CameraControl_Pan + 1),
    CameraControl_Roll = (CameraControl_Tilt + 1),
    CameraControl_Zoom = (CameraControl_Roll + 1),
    CameraControl_Exposure = (CameraControl_Zoom + 1),
    CameraControl_Iris = (CameraControl_Exposure + 1),
    CameraControl_Focus = (CameraControl_Iris + 1),
}
