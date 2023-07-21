// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class PBT
{
    [NativeTypeName("#define PBT_APMQUERYSUSPEND 0x0000")]
    public const int PBT_APMQUERYSUSPEND = 0x0000;

    [NativeTypeName("#define PBT_APMQUERYSTANDBY 0x0001")]
    public const int PBT_APMQUERYSTANDBY = 0x0001;

    [NativeTypeName("#define PBT_APMQUERYSUSPENDFAILED 0x0002")]
    public const int PBT_APMQUERYSUSPENDFAILED = 0x0002;

    [NativeTypeName("#define PBT_APMQUERYSTANDBYFAILED 0x0003")]
    public const int PBT_APMQUERYSTANDBYFAILED = 0x0003;

    [NativeTypeName("#define PBT_APMSUSPEND 0x0004")]
    public const int PBT_APMSUSPEND = 0x0004;

    [NativeTypeName("#define PBT_APMSTANDBY 0x0005")]
    public const int PBT_APMSTANDBY = 0x0005;

    [NativeTypeName("#define PBT_APMRESUMECRITICAL 0x0006")]
    public const int PBT_APMRESUMECRITICAL = 0x0006;

    [NativeTypeName("#define PBT_APMRESUMESUSPEND 0x0007")]
    public const int PBT_APMRESUMESUSPEND = 0x0007;

    [NativeTypeName("#define PBT_APMRESUMESTANDBY 0x0008")]
    public const int PBT_APMRESUMESTANDBY = 0x0008;

    [NativeTypeName("#define PBT_APMBATTERYLOW 0x0009")]
    public const int PBT_APMBATTERYLOW = 0x0009;

    [NativeTypeName("#define PBT_APMPOWERSTATUSCHANGE 0x000A")]
    public const int PBT_APMPOWERSTATUSCHANGE = 0x000A;

    [NativeTypeName("#define PBT_APMOEMEVENT 0x000B")]
    public const int PBT_APMOEMEVENT = 0x000B;

    [NativeTypeName("#define PBT_APMRESUMEAUTOMATIC 0x0012")]
    public const int PBT_APMRESUMEAUTOMATIC = 0x0012;

    [NativeTypeName("#define PBT_POWERSETTINGCHANGE 0x8013")]
    public const int PBT_POWERSETTINGCHANGE = 0x8013;
}
