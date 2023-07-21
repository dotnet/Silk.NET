// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MFASYNC
{
    [NativeTypeName("#define MFASYNC_FAST_IO_PROCESSING_CALLBACK 0x00000001")]
    public const int MFASYNC_FAST_IO_PROCESSING_CALLBACK = 0x00000001;

    [NativeTypeName("#define MFASYNC_SIGNAL_CALLBACK 0x00000002")]
    public const int MFASYNC_SIGNAL_CALLBACK = 0x00000002;

    [NativeTypeName("#define MFASYNC_BLOCKING_CALLBACK 0x00000004")]
    public const int MFASYNC_BLOCKING_CALLBACK = 0x00000004;

    [NativeTypeName("#define MFASYNC_REPLY_CALLBACK 0x00000008")]
    public const int MFASYNC_REPLY_CALLBACK = 0x00000008;

    [NativeTypeName("#define MFASYNC_LOCALIZE_REMOTE_CALLBACK 0x00000010")]
    public const int MFASYNC_LOCALIZE_REMOTE_CALLBACK = 0x00000010;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_UNDEFINED 0x00000000")]
    public const int MFASYNC_CALLBACK_QUEUE_UNDEFINED = 0x00000000;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_STANDARD 0x00000001")]
    public const int MFASYNC_CALLBACK_QUEUE_STANDARD = 0x00000001;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_RT 0x00000002")]
    public const int MFASYNC_CALLBACK_QUEUE_RT = 0x00000002;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_IO 0x00000003")]
    public const int MFASYNC_CALLBACK_QUEUE_IO = 0x00000003;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_TIMER 0x00000004")]
    public const int MFASYNC_CALLBACK_QUEUE_TIMER = 0x00000004;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_MULTITHREADED 0x00000005")]
    public const int MFASYNC_CALLBACK_QUEUE_MULTITHREADED = 0x00000005;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_LONG_FUNCTION 0x00000007")]
    public const int MFASYNC_CALLBACK_QUEUE_LONG_FUNCTION = 0x00000007;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_PRIVATE_MASK 0xFFFF0000")]
    public const uint MFASYNC_CALLBACK_QUEUE_PRIVATE_MASK = 0xFFFF0000;

    [NativeTypeName("#define MFASYNC_CALLBACK_QUEUE_ALL 0xFFFFFFFF")]
    public const uint MFASYNC_CALLBACK_QUEUE_ALL = 0xFFFFFFFF;
}
