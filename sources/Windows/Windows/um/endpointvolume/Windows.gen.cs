// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/endpointvolume.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_VOLUME 0x00000001")]
    public const int ENDPOINT_HARDWARE_SUPPORT_VOLUME = 0x00000001;

    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_MUTE 0x00000002")]
    public const int ENDPOINT_HARDWARE_SUPPORT_MUTE = 0x00000002;

    [NativeTypeName("#define ENDPOINT_HARDWARE_SUPPORT_METER 0x00000004")]
    public const int ENDPOINT_HARDWARE_SUPPORT_METER = 0x00000004;
}
