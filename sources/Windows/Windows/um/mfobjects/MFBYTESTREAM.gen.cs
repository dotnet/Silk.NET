// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MFBYTESTREAM
{
    [NativeTypeName("#define MFBYTESTREAM_IS_READABLE 0x00000001")]
    public const int MFBYTESTREAM_IS_READABLE = 0x00000001;

    [NativeTypeName("#define MFBYTESTREAM_IS_WRITABLE 0x00000002")]
    public const int MFBYTESTREAM_IS_WRITABLE = 0x00000002;

    [NativeTypeName("#define MFBYTESTREAM_IS_SEEKABLE 0x00000004")]
    public const int MFBYTESTREAM_IS_SEEKABLE = 0x00000004;

    [NativeTypeName("#define MFBYTESTREAM_IS_REMOTE 0x00000008")]
    public const int MFBYTESTREAM_IS_REMOTE = 0x00000008;

    [NativeTypeName("#define MFBYTESTREAM_IS_DIRECTORY 0x00000080")]
    public const int MFBYTESTREAM_IS_DIRECTORY = 0x00000080;

    [NativeTypeName("#define MFBYTESTREAM_HAS_SLOW_SEEK 0x00000100")]
    public const int MFBYTESTREAM_HAS_SLOW_SEEK = 0x00000100;

    [NativeTypeName("#define MFBYTESTREAM_IS_PARTIALLY_DOWNLOADED 0x00000200")]
    public const int MFBYTESTREAM_IS_PARTIALLY_DOWNLOADED = 0x00000200;

    [NativeTypeName("#define MFBYTESTREAM_SHARE_WRITE 0x00000400")]
    public const int MFBYTESTREAM_SHARE_WRITE = 0x00000400;

    [NativeTypeName("#define MFBYTESTREAM_DOES_NOT_USE_NETWORK 0x00000800")]
    public const int MFBYTESTREAM_DOES_NOT_USE_NETWORK = 0x00000800;

    [NativeTypeName("#define MFBYTESTREAM_SEEK_FLAG_CANCEL_PENDING_IO 0x00000001")]
    public const int MFBYTESTREAM_SEEK_FLAG_CANCEL_PENDING_IO = 0x00000001;
}
