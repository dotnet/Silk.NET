// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MAX
{
    [NativeTypeName("#define MAX_COLUMN_NAME_LEN 80")]
    public const int MAX_COLUMN_NAME_LEN = 80;

    [NativeTypeName("#define MAX_COLUMN_DESC_LEN 128")]
    public const int MAX_COLUMN_DESC_LEN = 128;
}
