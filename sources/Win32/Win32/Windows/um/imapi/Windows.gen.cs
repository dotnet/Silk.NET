// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define RECORDER_DOING_NOTHING ( 0 )")]
    public const int RECORDER_DOING_NOTHING = (0);

    [NativeTypeName("#define RECORDER_OPENED ( 0x1 )")]
    public const int RECORDER_OPENED = (0x1);

    [NativeTypeName("#define RECORDER_BURNING ( 0x2 )")]
    public const int RECORDER_BURNING = (0x2);
}
