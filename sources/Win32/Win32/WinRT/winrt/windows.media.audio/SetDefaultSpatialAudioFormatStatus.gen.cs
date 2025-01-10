// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SetDefaultSpatialAudioFormatStatus
{
    SetDefaultSpatialAudioFormatStatus_Succeeded = 0,
    SetDefaultSpatialAudioFormatStatus_AccessDenied = 1,
    SetDefaultSpatialAudioFormatStatus_LicenseExpired = 2,
    SetDefaultSpatialAudioFormatStatus_LicenseNotValidForAudioEndpoint = 3,
    SetDefaultSpatialAudioFormatStatus_NotSupportedOnAudioEndpoint = 4,
    SetDefaultSpatialAudioFormatStatus_UnknownError = 5,
}
