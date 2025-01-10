// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class S
{
    [NativeTypeName("#define S_QUEUEEMPTY 0")]
    public const int S_QUEUEEMPTY = 0;

    [NativeTypeName("#define S_THRESHOLD 1")]
    public const int S_THRESHOLD = 1;

    [NativeTypeName("#define S_ALLTHRESHOLD 2")]
    public const int S_ALLTHRESHOLD = 2;

    [NativeTypeName("#define S_NORMAL 0")]
    public const int S_NORMAL = 0;

    [NativeTypeName("#define S_LEGATO 1")]
    public const int S_LEGATO = 1;

    [NativeTypeName("#define S_STACCATO 2")]
    public const int S_STACCATO = 2;

    [NativeTypeName("#define S_PERIOD512 0")]
    public const int S_PERIOD512 = 0;

    [NativeTypeName("#define S_PERIOD1024 1")]
    public const int S_PERIOD1024 = 1;

    [NativeTypeName("#define S_PERIOD2048 2")]
    public const int S_PERIOD2048 = 2;

    [NativeTypeName("#define S_PERIODVOICE 3")]
    public const int S_PERIODVOICE = 3;

    [NativeTypeName("#define S_WHITE512 4")]
    public const int S_WHITE512 = 4;

    [NativeTypeName("#define S_WHITE1024 5")]
    public const int S_WHITE1024 = 5;

    [NativeTypeName("#define S_WHITE2048 6")]
    public const int S_WHITE2048 = 6;

    [NativeTypeName("#define S_WHITEVOICE 7")]
    public const int S_WHITEVOICE = 7;

    [NativeTypeName("#define S_SERDVNA (-1)")]
    public const int S_SERDVNA = (-1);

    [NativeTypeName("#define S_SEROFM (-2)")]
    public const int S_SEROFM = (-2);

    [NativeTypeName("#define S_SERMACT (-3)")]
    public const int S_SERMACT = (-3);

    [NativeTypeName("#define S_SERQFUL (-4)")]
    public const int S_SERQFUL = (-4);

    [NativeTypeName("#define S_SERBDNT (-5)")]
    public const int S_SERBDNT = (-5);

    [NativeTypeName("#define S_SERDLN (-6)")]
    public const int S_SERDLN = (-6);

    [NativeTypeName("#define S_SERDCC (-7)")]
    public const int S_SERDCC = (-7);

    [NativeTypeName("#define S_SERDTP (-8)")]
    public const int S_SERDTP = (-8);

    [NativeTypeName("#define S_SERDVL (-9)")]
    public const int S_SERDVL = (-9);

    [NativeTypeName("#define S_SERDMD (-10)")]
    public const int S_SERDMD = (-10);

    [NativeTypeName("#define S_SERDSH (-11)")]
    public const int S_SERDSH = (-11);

    [NativeTypeName("#define S_SERDPT (-12)")]
    public const int S_SERDPT = (-12);

    [NativeTypeName("#define S_SERDFQ (-13)")]
    public const int S_SERDFQ = (-13);

    [NativeTypeName("#define S_SERDDR (-14)")]
    public const int S_SERDDR = (-14);

    [NativeTypeName("#define S_SERDSR (-15)")]
    public const int S_SERDSR = (-15);

    [NativeTypeName("#define S_SERDST (-16)")]
    public const int S_SERDST = (-16);
}
