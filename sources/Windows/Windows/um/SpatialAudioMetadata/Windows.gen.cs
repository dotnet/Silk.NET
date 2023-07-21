// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define SPATIAL_AUDIO_STANDARD_COMMANDS_START 200")]
    public const int SPATIAL_AUDIO_STANDARD_COMMANDS_START = 200;

    [NativeTypeName("#define SPATIAL_AUDIO_POSITION (SPATIAL_AUDIO_STANDARD_COMMANDS_START)")]
    public const int SPATIAL_AUDIO_POSITION = (200);

    [NativeTypeName("#define SPATIAL_AUDIO_POSITION_BYTE_COUNT (sizeof(float) * 3)")]
    public const uint SPATIAL_AUDIO_POSITION_BYTE_COUNT = (4 * 3);
}
