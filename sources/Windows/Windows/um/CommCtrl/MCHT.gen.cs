// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MCHT
{
    [NativeTypeName("#define MCHT_TITLE 0x00010000")]
    public const int MCHT_TITLE = 0x00010000;
    [NativeTypeName("#define MCHT_CALENDAR 0x00020000")]
    public const int MCHT_CALENDAR = 0x00020000;
    [NativeTypeName("#define MCHT_TODAYLINK 0x00030000")]
    public const int MCHT_TODAYLINK = 0x00030000;
    [NativeTypeName("#define MCHT_CALENDARCONTROL 0x00100000")]
    public const int MCHT_CALENDARCONTROL = 0x00100000;
    [NativeTypeName("#define MCHT_NEXT 0x01000000")]
    public const int MCHT_NEXT = 0x01000000;
    [NativeTypeName("#define MCHT_PREV 0x02000000")]
    public const int MCHT_PREV = 0x02000000;
    [NativeTypeName("#define MCHT_NOWHERE 0x00000000")]
    public const int MCHT_NOWHERE = 0x00000000;
    [NativeTypeName("#define MCHT_TITLEBK (MCHT_TITLE)")]
    public const int MCHT_TITLEBK = (0x00010000);
    [NativeTypeName("#define MCHT_TITLEMONTH (MCHT_TITLE | 0x0001)")]
    public const int MCHT_TITLEMONTH = (0x00010000 | 0x0001);
    [NativeTypeName("#define MCHT_TITLEYEAR (MCHT_TITLE | 0x0002)")]
    public const int MCHT_TITLEYEAR = (0x00010000 | 0x0002);
    [NativeTypeName("#define MCHT_TITLEBTNNEXT (MCHT_TITLE | MCHT_NEXT | 0x0003)")]
    public const int MCHT_TITLEBTNNEXT = (0x00010000 | 0x01000000 | 0x0003);
    [NativeTypeName("#define MCHT_TITLEBTNPREV (MCHT_TITLE | MCHT_PREV | 0x0003)")]
    public const int MCHT_TITLEBTNPREV = (0x00010000 | 0x02000000 | 0x0003);
    [NativeTypeName("#define MCHT_CALENDARBK (MCHT_CALENDAR)")]
    public const int MCHT_CALENDARBK = (0x00020000);
    [NativeTypeName("#define MCHT_CALENDARDATE (MCHT_CALENDAR | 0x0001)")]
    public const int MCHT_CALENDARDATE = (0x00020000 | 0x0001);
    [NativeTypeName("#define MCHT_CALENDARDATENEXT (MCHT_CALENDARDATE | MCHT_NEXT)")]
    public const int MCHT_CALENDARDATENEXT = ((0x00020000 | 0x0001) | 0x01000000);
    [NativeTypeName("#define MCHT_CALENDARDATEPREV (MCHT_CALENDARDATE | MCHT_PREV)")]
    public const int MCHT_CALENDARDATEPREV = ((0x00020000 | 0x0001) | 0x02000000);
    [NativeTypeName("#define MCHT_CALENDARDAY (MCHT_CALENDAR | 0x0002)")]
    public const int MCHT_CALENDARDAY = (0x00020000 | 0x0002);
    [NativeTypeName("#define MCHT_CALENDARWEEKNUM (MCHT_CALENDAR | 0x0003)")]
    public const int MCHT_CALENDARWEEKNUM = (0x00020000 | 0x0003);
    [NativeTypeName("#define MCHT_CALENDARDATEMIN (MCHT_CALENDAR | 0x0004)")]
    public const int MCHT_CALENDARDATEMIN = (0x00020000 | 0x0004);
    [NativeTypeName("#define MCHT_CALENDARDATEMAX (MCHT_CALENDAR | 0x0005)")]
    public const int MCHT_CALENDARDATEMAX = (0x00020000 | 0x0005);
}