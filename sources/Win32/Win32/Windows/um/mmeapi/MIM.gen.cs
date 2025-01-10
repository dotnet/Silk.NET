// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MIM
{
    [NativeTypeName("#define MIM_OPEN MM_MIM_OPEN")]
    public const int MIM_OPEN = 0x3C1;

    [NativeTypeName("#define MIM_CLOSE MM_MIM_CLOSE")]
    public const int MIM_CLOSE = 0x3C2;

    [NativeTypeName("#define MIM_DATA MM_MIM_DATA")]
    public const int MIM_DATA = 0x3C3;

    [NativeTypeName("#define MIM_LONGDATA MM_MIM_LONGDATA")]
    public const int MIM_LONGDATA = 0x3C4;

    [NativeTypeName("#define MIM_ERROR MM_MIM_ERROR")]
    public const int MIM_ERROR = 0x3C5;

    [NativeTypeName("#define MIM_LONGERROR MM_MIM_LONGERROR")]
    public const int MIM_LONGERROR = 0x3C6;

    [NativeTypeName("#define MIM_MOREDATA MM_MIM_MOREDATA")]
    public const int MIM_MOREDATA = 0x3CC;
}
