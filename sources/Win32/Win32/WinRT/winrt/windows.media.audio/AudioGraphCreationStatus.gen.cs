// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AudioGraphCreationStatus
{
    AudioGraphCreationStatus_Success = 0,
    AudioGraphCreationStatus_DeviceNotAvailable = 1,
    AudioGraphCreationStatus_FormatNotSupported = 2,
    AudioGraphCreationStatus_UnknownFailure = 3,
}
