// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define AUDIOCLOCK_CHARACTERISTIC_FIXED_FREQ 0x00000001")]
    public const int AUDIOCLOCK_CHARACTERISTIC_FIXED_FREQ = 0x00000001;

    [NativeTypeName("#define AMBISONICS_PARAM_VERSION_1 1")]
    public const int AMBISONICS_PARAM_VERSION_1 = 1;
}
