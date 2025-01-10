// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CameraCaptureUIMaxPhotoResolution
{
    CameraCaptureUIMaxPhotoResolution_HighestAvailable = 0,
    CameraCaptureUIMaxPhotoResolution_VerySmallQvga = 1,
    CameraCaptureUIMaxPhotoResolution_SmallVga = 2,
    CameraCaptureUIMaxPhotoResolution_MediumXga = 3,
    CameraCaptureUIMaxPhotoResolution_Large3M = 4,
    CameraCaptureUIMaxPhotoResolution_VeryLarge5M = 5,
}
