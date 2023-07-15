// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class DTM
{
    [NativeTypeName("#define DTM_FIRST 0x1000")]
    public const int DTM_FIRST = 0x1000;
    [NativeTypeName("#define DTM_GETSYSTEMTIME (DTM_FIRST + 1)")]
    public const int DTM_GETSYSTEMTIME = (0x1000 + 1);
    [NativeTypeName("#define DTM_SETSYSTEMTIME (DTM_FIRST + 2)")]
    public const int DTM_SETSYSTEMTIME = (0x1000 + 2);
    [NativeTypeName("#define DTM_GETRANGE (DTM_FIRST + 3)")]
    public const int DTM_GETRANGE = (0x1000 + 3);
    [NativeTypeName("#define DTM_SETRANGE (DTM_FIRST + 4)")]
    public const int DTM_SETRANGE = (0x1000 + 4);
    [NativeTypeName("#define DTM_SETFORMATA (DTM_FIRST + 5)")]
    public const int DTM_SETFORMATA = (0x1000 + 5);
    [NativeTypeName("#define DTM_SETFORMATW (DTM_FIRST + 50)")]
    public const int DTM_SETFORMATW = (0x1000 + 50);
    [NativeTypeName("#define DTM_SETFORMAT DTM_SETFORMATW")]
    public const int DTM_SETFORMAT = (0x1000 + 50);
    [NativeTypeName("#define DTM_SETMCCOLOR (DTM_FIRST + 6)")]
    public const int DTM_SETMCCOLOR = (0x1000 + 6);
    [NativeTypeName("#define DTM_GETMCCOLOR (DTM_FIRST + 7)")]
    public const int DTM_GETMCCOLOR = (0x1000 + 7);
    [NativeTypeName("#define DTM_GETMONTHCAL (DTM_FIRST + 8)")]
    public const int DTM_GETMONTHCAL = (0x1000 + 8);
    [NativeTypeName("#define DTM_SETMCFONT (DTM_FIRST + 9)")]
    public const int DTM_SETMCFONT = (0x1000 + 9);
    [NativeTypeName("#define DTM_GETMCFONT (DTM_FIRST + 10)")]
    public const int DTM_GETMCFONT = (0x1000 + 10);
    [NativeTypeName("#define DTM_SETMCSTYLE (DTM_FIRST + 11)")]
    public const int DTM_SETMCSTYLE = (0x1000 + 11);
    [NativeTypeName("#define DTM_GETMCSTYLE (DTM_FIRST + 12)")]
    public const int DTM_GETMCSTYLE = (0x1000 + 12);
    [NativeTypeName("#define DTM_CLOSEMONTHCAL (DTM_FIRST + 13)")]
    public const int DTM_CLOSEMONTHCAL = (0x1000 + 13);
    [NativeTypeName("#define DTM_GETDATETIMEPICKERINFO (DTM_FIRST + 14)")]
    public const int DTM_GETDATETIMEPICKERINFO = (0x1000 + 14);
    [NativeTypeName("#define DTM_GETIDEALSIZE (DTM_FIRST + 15)")]
    public const int DTM_GETIDEALSIZE = (0x1000 + 15);
}