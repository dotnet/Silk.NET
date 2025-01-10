// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DI8DEVTYPESUPPLEMENTAL
{
    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_UNKNOWN 2")]
    public const int DI8DEVTYPESUPPLEMENTAL_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_2NDHANDCONTROLLER 3")]
    public const int DI8DEVTYPESUPPLEMENTAL_2NDHANDCONTROLLER = 3;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_HEADTRACKER 4")]
    public const int DI8DEVTYPESUPPLEMENTAL_HEADTRACKER = 4;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_HANDTRACKER 5")]
    public const int DI8DEVTYPESUPPLEMENTAL_HANDTRACKER = 5;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SHIFTSTICKGATE 6")]
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTSTICKGATE = 6;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SHIFTER 7")]
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTER = 7;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_THROTTLE 8")]
    public const int DI8DEVTYPESUPPLEMENTAL_THROTTLE = 8;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SPLITTHROTTLE 9")]
    public const int DI8DEVTYPESUPPLEMENTAL_SPLITTHROTTLE = 9;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_COMBINEDPEDALS 10")]
    public const int DI8DEVTYPESUPPLEMENTAL_COMBINEDPEDALS = 10;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_DUALPEDALS 11")]
    public const int DI8DEVTYPESUPPLEMENTAL_DUALPEDALS = 11;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_THREEPEDALS 12")]
    public const int DI8DEVTYPESUPPLEMENTAL_THREEPEDALS = 12;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_RUDDERPEDALS 13")]
    public const int DI8DEVTYPESUPPLEMENTAL_RUDDERPEDALS = 13;
}
