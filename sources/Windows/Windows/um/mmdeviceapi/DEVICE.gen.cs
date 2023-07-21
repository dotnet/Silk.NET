// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DEVICE
{
    [NativeTypeName("#define DEVICE_STATE_ACTIVE 0x00000001")]
    public const int DEVICE_STATE_ACTIVE = 0x00000001;

    [NativeTypeName("#define DEVICE_STATE_DISABLED 0x00000002")]
    public const int DEVICE_STATE_DISABLED = 0x00000002;

    [NativeTypeName("#define DEVICE_STATE_NOTPRESENT 0x00000004")]
    public const int DEVICE_STATE_NOTPRESENT = 0x00000004;

    [NativeTypeName("#define DEVICE_STATE_UNPLUGGED 0x00000008")]
    public const int DEVICE_STATE_UNPLUGGED = 0x00000008;

    [NativeTypeName("#define DEVICE_STATEMASK_ALL 0x0000000f")]
    public const int DEVICE_STATEMASK_ALL = 0x0000000f;
}
