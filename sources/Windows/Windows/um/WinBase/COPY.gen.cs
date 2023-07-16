// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class COPY
{
    [NativeTypeName("#define COPY_FILE_FAIL_IF_EXISTS 0x00000001")]
    public const int COPY_FILE_FAIL_IF_EXISTS = 0x00000001;
    [NativeTypeName("#define COPY_FILE_RESTARTABLE 0x00000002")]
    public const int COPY_FILE_RESTARTABLE = 0x00000002;
    [NativeTypeName("#define COPY_FILE_OPEN_SOURCE_FOR_WRITE 0x00000004")]
    public const int COPY_FILE_OPEN_SOURCE_FOR_WRITE = 0x00000004;
    [NativeTypeName("#define COPY_FILE_ALLOW_DECRYPTED_DESTINATION 0x00000008")]
    public const int COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 0x00000008;
    [NativeTypeName("#define COPY_FILE_COPY_SYMLINK 0x00000800")]
    public const int COPY_FILE_COPY_SYMLINK = 0x00000800;
    [NativeTypeName("#define COPY_FILE_NO_BUFFERING 0x00001000")]
    public const int COPY_FILE_NO_BUFFERING = 0x00001000;
    [NativeTypeName("#define COPY_FILE_REQUEST_SECURITY_PRIVILEGES 0x00002000")]
    public const int COPY_FILE_REQUEST_SECURITY_PRIVILEGES = 0x00002000;
    [NativeTypeName("#define COPY_FILE_RESUME_FROM_PAUSE 0x00004000")]
    public const int COPY_FILE_RESUME_FROM_PAUSE = 0x00004000;
    [NativeTypeName("#define COPY_FILE_NO_OFFLOAD 0x00040000")]
    public const int COPY_FILE_NO_OFFLOAD = 0x00040000;
    [NativeTypeName("#define COPY_FILE_IGNORE_EDP_BLOCK 0x00400000")]
    public const int COPY_FILE_IGNORE_EDP_BLOCK = 0x00400000;
    [NativeTypeName("#define COPY_FILE_IGNORE_SOURCE_ENCRYPTION 0x00800000")]
    public const int COPY_FILE_IGNORE_SOURCE_ENCRYPTION = 0x00800000;
    [NativeTypeName("#define COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC 0x02000000")]
    public const int COPY_FILE_DONT_REQUEST_DEST_WRITE_DAC = 0x02000000;
    [NativeTypeName("#define COPY_FILE_REQUEST_COMPRESSED_TRAFFIC 0x10000000")]
    public const int COPY_FILE_REQUEST_COMPRESSED_TRAFFIC = 0x10000000;
    [NativeTypeName("#define COPY_FILE_OPEN_AND_COPY_REPARSE_POINT 0x00200000")]
    public const int COPY_FILE_OPEN_AND_COPY_REPARSE_POINT = 0x00200000;
    [NativeTypeName("#define COPY_FILE_DIRECTORY 0x00000080")]
    public const int COPY_FILE_DIRECTORY = 0x00000080;
    [NativeTypeName("#define COPY_FILE_SKIP_ALTERNATE_STREAMS 0x00008000")]
    public const int COPY_FILE_SKIP_ALTERNATE_STREAMS = 0x00008000;
    [NativeTypeName("#define COPY_FILE_DISABLE_PRE_ALLOCATION 0x04000000")]
    public const int COPY_FILE_DISABLE_PRE_ALLOCATION = 0x04000000;
    [NativeTypeName("#define COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE 0x08000000")]
    public const int COPY_FILE_ENABLE_LOW_FREE_SPACE_MODE = 0x08000000;
    [NativeTypeName("#define COPY_FILE_ENABLE_SPARSE_COPY 0x20000000")]
    public const int COPY_FILE_ENABLE_SPARSE_COPY = 0x20000000;
    [NativeTypeName("#define COPY_FILE2_V2_DONT_COPY_JUNCTIONS 0x00000001")]
    public const int COPY_FILE2_V2_DONT_COPY_JUNCTIONS = 0x00000001;
    [NativeTypeName("#define COPY_FILE2_V2_VALID_FLAGS (COPY_FILE2_V2_DONT_COPY_JUNCTIONS)")]
    public const int COPY_FILE2_V2_VALID_FLAGS = (0x00000001);
}