// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SCRUB
{
    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_RESUME 0x00000001")]
    public const int SCRUB_DATA_INPUT_FLAG_RESUME = 0x00000001;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC 0x00000002")]
    public const int SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC = 0x00000002;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA 0x00000004")]
    public const int SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA = 0x00000004;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY 0x00000008")]
    public const int SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY = 0x00000008;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_DATA 0x00000010")]
    public const int SCRUB_DATA_INPUT_FLAG_SKIP_DATA = 0x00000010;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID 0x00000020")]
    public const int SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID = 0x00000020;

    [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED 0x00000040")]
    public const int SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED = 0x00000040;

    [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE 0x00000001")]
    public const int SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE = 0x00000001;

    [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE 0x00010000")]
    public const int SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE = 0x00010000;

    [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED 0x00020000")]
    public const int SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED = 0x00020000;

    [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED 0x00040000")]
    public const int SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED = 0x00040000;
}
