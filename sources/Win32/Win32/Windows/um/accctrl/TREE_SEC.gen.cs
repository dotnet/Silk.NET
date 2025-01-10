// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class TREE_SEC
{
    [NativeTypeName("#define TREE_SEC_INFO_SET 0x00000001")]
    public const int TREE_SEC_INFO_SET = 0x00000001;

    [NativeTypeName("#define TREE_SEC_INFO_RESET 0x00000002")]
    public const int TREE_SEC_INFO_RESET = 0x00000002;

    [NativeTypeName("#define TREE_SEC_INFO_RESET_KEEP_EXPLICIT 0x00000003")]
    public const int TREE_SEC_INFO_RESET_KEEP_EXPLICIT = 0x00000003;
}
