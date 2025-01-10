// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AudioDecoderDegradation
{
    AudioDecoderDegradation_None = 0,
    AudioDecoderDegradation_DownmixTo2Channels = 1,
    AudioDecoderDegradation_DownmixTo6Channels = 2,
    AudioDecoderDegradation_DownmixTo8Channels = 3,
}
