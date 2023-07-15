// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlGuid.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PIDVSI
{
    [NativeTypeName("#define PIDVSI_STREAM_NAME 0x00000002")]
    public const int PIDVSI_STREAM_NAME = 0x00000002;
    [NativeTypeName("#define PIDVSI_FRAME_WIDTH 0x00000003")]
    public const int PIDVSI_FRAME_WIDTH = 0x00000003;
    [NativeTypeName("#define PIDVSI_FRAME_HEIGHT 0x00000004")]
    public const int PIDVSI_FRAME_HEIGHT = 0x00000004;
    [NativeTypeName("#define PIDVSI_TIMELENGTH 0x00000007")]
    public const int PIDVSI_TIMELENGTH = 0x00000007;
    [NativeTypeName("#define PIDVSI_FRAME_COUNT 0x00000005")]
    public const int PIDVSI_FRAME_COUNT = 0x00000005;
    [NativeTypeName("#define PIDVSI_FRAME_RATE 0x00000006")]
    public const int PIDVSI_FRAME_RATE = 0x00000006;
    [NativeTypeName("#define PIDVSI_DATA_RATE 0x00000008")]
    public const int PIDVSI_DATA_RATE = 0x00000008;
    [NativeTypeName("#define PIDVSI_SAMPLE_SIZE 0x00000009")]
    public const int PIDVSI_SAMPLE_SIZE = 0x00000009;
    [NativeTypeName("#define PIDVSI_COMPRESSION 0x0000000A")]
    public const int PIDVSI_COMPRESSION = 0x0000000A;
    [NativeTypeName("#define PIDVSI_STREAM_NUMBER 0x0000000B")]
    public const int PIDVSI_STREAM_NUMBER = 0x0000000B;
}