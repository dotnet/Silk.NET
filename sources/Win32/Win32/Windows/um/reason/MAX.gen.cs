// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/reason.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_REASON_NAME_LEN 64")]
    public const int MAX_REASON_NAME_LEN = 64;

    [NativeTypeName("#define MAX_REASON_DESC_LEN 256")]
    public const int MAX_REASON_DESC_LEN = 256;

    [NativeTypeName("#define MAX_REASON_BUGID_LEN 32")]
    public const int MAX_REASON_BUGID_LEN = 32;

    [NativeTypeName("#define MAX_REASON_COMMENT_LEN 512")]
    public const int MAX_REASON_COMMENT_LEN = 512;

    [NativeTypeName("#define MAX_NUM_REASONS 256")]
    public const int MAX_NUM_REASONS = 256;
}
