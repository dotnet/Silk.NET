// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class VSCLASS
{
    [NativeTypeName("#define VSCLASS_LINK L\"LINK\"")]
    public const string VSCLASS_LINK = "LINK";

    [NativeTypeName("#define VSCLASS_EMPTYMARKUP L\"EMPTYMARKUP\"")]
    public const string VSCLASS_EMPTYMARKUP = "EMPTYMARKUP";

    [NativeTypeName("#define VSCLASS_STATIC L\"STATIC\"")]
    public const string VSCLASS_STATIC = "STATIC";

    [NativeTypeName("#define VSCLASS_PAGE L\"PAGE\"")]
    public const string VSCLASS_PAGE = "PAGE";

    [NativeTypeName("#define VSCLASS_MONTHCAL L\"MONTHCAL\"")]
    public const string VSCLASS_MONTHCAL = "MONTHCAL";

    [NativeTypeName("#define VSCLASS_CLOCK L\"CLOCK\"")]
    public const string VSCLASS_CLOCK = "CLOCK";

    [NativeTypeName("#define VSCLASS_TRAYNOTIFY L\"TRAYNOTIFY\"")]
    public const string VSCLASS_TRAYNOTIFY = "TRAYNOTIFY";

    [NativeTypeName("#define VSCLASS_TASKBAR L\"TASKBAR\"")]
    public const string VSCLASS_TASKBAR = "TASKBAR";

    [NativeTypeName("#define VSCLASS_TASKBAND L\"TASKBAND\"")]
    public const string VSCLASS_TASKBAND = "TASKBAND";

    [NativeTypeName("#define VSCLASS_STARTPANEL L\"STARTPANEL\"")]
    public const string VSCLASS_STARTPANEL = "STARTPANEL";

    [NativeTypeName("#define VSCLASS_MENUBAND L\"MENUBAND\"")]
    public const string VSCLASS_MENUBAND = "MENUBAND";
}
