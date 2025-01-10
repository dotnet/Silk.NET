// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MARK
{
    [NativeTypeName("#define MARK_HANDLE_PROTECT_CLUSTERS (0x00000001)")]
    public const int MARK_HANDLE_PROTECT_CLUSTERS = (0x00000001);

    [NativeTypeName("#define MARK_HANDLE_TXF_SYSTEM_LOG (0x00000004)")]
    public const int MARK_HANDLE_TXF_SYSTEM_LOG = (0x00000004);

    [NativeTypeName("#define MARK_HANDLE_NOT_TXF_SYSTEM_LOG (0x00000008)")]
    public const int MARK_HANDLE_NOT_TXF_SYSTEM_LOG = (0x00000008);

    [NativeTypeName("#define MARK_HANDLE_REALTIME (0x00000020)")]
    public const int MARK_HANDLE_REALTIME = (0x00000020);

    [NativeTypeName("#define MARK_HANDLE_NOT_REALTIME (0x00000040)")]
    public const int MARK_HANDLE_NOT_REALTIME = (0x00000040);

    [NativeTypeName("#define MARK_HANDLE_CLOUD_SYNC (0x00000800)")]
    public const int MARK_HANDLE_CLOUD_SYNC = (0x00000800);

    [NativeTypeName("#define MARK_HANDLE_READ_COPY (0x00000080)")]
    public const int MARK_HANDLE_READ_COPY = (0x00000080);

    [NativeTypeName("#define MARK_HANDLE_NOT_READ_COPY (0x00000100)")]
    public const int MARK_HANDLE_NOT_READ_COPY = (0x00000100);

    [NativeTypeName("#define MARK_HANDLE_FILTER_METADATA (0x00000200)")]
    public const int MARK_HANDLE_FILTER_METADATA = (0x00000200);

    [NativeTypeName("#define MARK_HANDLE_RETURN_PURGE_FAILURE (0x00000400)")]
    public const int MARK_HANDLE_RETURN_PURGE_FAILURE = (0x00000400);

    [NativeTypeName("#define MARK_HANDLE_DISABLE_FILE_METADATA_OPTIMIZATION (0x00001000)")]
    public const int MARK_HANDLE_DISABLE_FILE_METADATA_OPTIMIZATION = (0x00001000);

    [NativeTypeName("#define MARK_HANDLE_ENABLE_USN_SOURCE_ON_PAGING_IO (0x00002000)")]
    public const int MARK_HANDLE_ENABLE_USN_SOURCE_ON_PAGING_IO = (0x00002000);

    [NativeTypeName("#define MARK_HANDLE_SKIP_COHERENCY_SYNC_DISALLOW_WRITES (0x00004000)")]
    public const int MARK_HANDLE_SKIP_COHERENCY_SYNC_DISALLOW_WRITES = (0x00004000);

    [NativeTypeName("#define MARK_HANDLE_SUPPRESS_VOLUME_OPEN_FLUSH (0x00008000)")]
    public const int MARK_HANDLE_SUPPRESS_VOLUME_OPEN_FLUSH = (0x00008000);

    [NativeTypeName("#define MARK_HANDLE_ENABLE_CPU_CACHE (0x10000000)")]
    public const int MARK_HANDLE_ENABLE_CPU_CACHE = (0x10000000);
}
