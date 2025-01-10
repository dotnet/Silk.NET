// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SPI
{
    [NativeTypeName("#define SPI_GETBEEP 0x0001")]
    public const int SPI_GETBEEP = 0x0001;

    [NativeTypeName("#define SPI_SETBEEP 0x0002")]
    public const int SPI_SETBEEP = 0x0002;

    [NativeTypeName("#define SPI_GETMOUSE 0x0003")]
    public const int SPI_GETMOUSE = 0x0003;

    [NativeTypeName("#define SPI_SETMOUSE 0x0004")]
    public const int SPI_SETMOUSE = 0x0004;

    [NativeTypeName("#define SPI_GETBORDER 0x0005")]
    public const int SPI_GETBORDER = 0x0005;

    [NativeTypeName("#define SPI_SETBORDER 0x0006")]
    public const int SPI_SETBORDER = 0x0006;

    [NativeTypeName("#define SPI_GETKEYBOARDSPEED 0x000A")]
    public const int SPI_GETKEYBOARDSPEED = 0x000A;

    [NativeTypeName("#define SPI_SETKEYBOARDSPEED 0x000B")]
    public const int SPI_SETKEYBOARDSPEED = 0x000B;

    [NativeTypeName("#define SPI_LANGDRIVER 0x000C")]
    public const int SPI_LANGDRIVER = 0x000C;

    [NativeTypeName("#define SPI_ICONHORIZONTALSPACING 0x000D")]
    public const int SPI_ICONHORIZONTALSPACING = 0x000D;

    [NativeTypeName("#define SPI_GETSCREENSAVETIMEOUT 0x000E")]
    public const int SPI_GETSCREENSAVETIMEOUT = 0x000E;

    [NativeTypeName("#define SPI_SETSCREENSAVETIMEOUT 0x000F")]
    public const int SPI_SETSCREENSAVETIMEOUT = 0x000F;

    [NativeTypeName("#define SPI_GETSCREENSAVEACTIVE 0x0010")]
    public const int SPI_GETSCREENSAVEACTIVE = 0x0010;

    [NativeTypeName("#define SPI_SETSCREENSAVEACTIVE 0x0011")]
    public const int SPI_SETSCREENSAVEACTIVE = 0x0011;

    [NativeTypeName("#define SPI_GETGRIDGRANULARITY 0x0012")]
    public const int SPI_GETGRIDGRANULARITY = 0x0012;

    [NativeTypeName("#define SPI_SETGRIDGRANULARITY 0x0013")]
    public const int SPI_SETGRIDGRANULARITY = 0x0013;

    [NativeTypeName("#define SPI_SETDESKWALLPAPER 0x0014")]
    public const int SPI_SETDESKWALLPAPER = 0x0014;

    [NativeTypeName("#define SPI_SETDESKPATTERN 0x0015")]
    public const int SPI_SETDESKPATTERN = 0x0015;

    [NativeTypeName("#define SPI_GETKEYBOARDDELAY 0x0016")]
    public const int SPI_GETKEYBOARDDELAY = 0x0016;

    [NativeTypeName("#define SPI_SETKEYBOARDDELAY 0x0017")]
    public const int SPI_SETKEYBOARDDELAY = 0x0017;

    [NativeTypeName("#define SPI_ICONVERTICALSPACING 0x0018")]
    public const int SPI_ICONVERTICALSPACING = 0x0018;

    [NativeTypeName("#define SPI_GETICONTITLEWRAP 0x0019")]
    public const int SPI_GETICONTITLEWRAP = 0x0019;

    [NativeTypeName("#define SPI_SETICONTITLEWRAP 0x001A")]
    public const int SPI_SETICONTITLEWRAP = 0x001A;

    [NativeTypeName("#define SPI_GETMENUDROPALIGNMENT 0x001B")]
    public const int SPI_GETMENUDROPALIGNMENT = 0x001B;

    [NativeTypeName("#define SPI_SETMENUDROPALIGNMENT 0x001C")]
    public const int SPI_SETMENUDROPALIGNMENT = 0x001C;

    [NativeTypeName("#define SPI_SETDOUBLECLKWIDTH 0x001D")]
    public const int SPI_SETDOUBLECLKWIDTH = 0x001D;

    [NativeTypeName("#define SPI_SETDOUBLECLKHEIGHT 0x001E")]
    public const int SPI_SETDOUBLECLKHEIGHT = 0x001E;

    [NativeTypeName("#define SPI_GETICONTITLELOGFONT 0x001F")]
    public const int SPI_GETICONTITLELOGFONT = 0x001F;

    [NativeTypeName("#define SPI_SETDOUBLECLICKTIME 0x0020")]
    public const int SPI_SETDOUBLECLICKTIME = 0x0020;

    [NativeTypeName("#define SPI_SETMOUSEBUTTONSWAP 0x0021")]
    public const int SPI_SETMOUSEBUTTONSWAP = 0x0021;

    [NativeTypeName("#define SPI_SETICONTITLELOGFONT 0x0022")]
    public const int SPI_SETICONTITLELOGFONT = 0x0022;

    [NativeTypeName("#define SPI_GETFASTTASKSWITCH 0x0023")]
    public const int SPI_GETFASTTASKSWITCH = 0x0023;

    [NativeTypeName("#define SPI_SETFASTTASKSWITCH 0x0024")]
    public const int SPI_SETFASTTASKSWITCH = 0x0024;

    [NativeTypeName("#define SPI_SETDRAGFULLWINDOWS 0x0025")]
    public const int SPI_SETDRAGFULLWINDOWS = 0x0025;

    [NativeTypeName("#define SPI_GETDRAGFULLWINDOWS 0x0026")]
    public const int SPI_GETDRAGFULLWINDOWS = 0x0026;

    [NativeTypeName("#define SPI_GETNONCLIENTMETRICS 0x0029")]
    public const int SPI_GETNONCLIENTMETRICS = 0x0029;

    [NativeTypeName("#define SPI_SETNONCLIENTMETRICS 0x002A")]
    public const int SPI_SETNONCLIENTMETRICS = 0x002A;

    [NativeTypeName("#define SPI_GETMINIMIZEDMETRICS 0x002B")]
    public const int SPI_GETMINIMIZEDMETRICS = 0x002B;

    [NativeTypeName("#define SPI_SETMINIMIZEDMETRICS 0x002C")]
    public const int SPI_SETMINIMIZEDMETRICS = 0x002C;

    [NativeTypeName("#define SPI_GETICONMETRICS 0x002D")]
    public const int SPI_GETICONMETRICS = 0x002D;

    [NativeTypeName("#define SPI_SETICONMETRICS 0x002E")]
    public const int SPI_SETICONMETRICS = 0x002E;

    [NativeTypeName("#define SPI_SETWORKAREA 0x002F")]
    public const int SPI_SETWORKAREA = 0x002F;

    [NativeTypeName("#define SPI_GETWORKAREA 0x0030")]
    public const int SPI_GETWORKAREA = 0x0030;

    [NativeTypeName("#define SPI_SETPENWINDOWS 0x0031")]
    public const int SPI_SETPENWINDOWS = 0x0031;

    [NativeTypeName("#define SPI_GETHIGHCONTRAST 0x0042")]
    public const int SPI_GETHIGHCONTRAST = 0x0042;

    [NativeTypeName("#define SPI_SETHIGHCONTRAST 0x0043")]
    public const int SPI_SETHIGHCONTRAST = 0x0043;

    [NativeTypeName("#define SPI_GETKEYBOARDPREF 0x0044")]
    public const int SPI_GETKEYBOARDPREF = 0x0044;

    [NativeTypeName("#define SPI_SETKEYBOARDPREF 0x0045")]
    public const int SPI_SETKEYBOARDPREF = 0x0045;

    [NativeTypeName("#define SPI_GETSCREENREADER 0x0046")]
    public const int SPI_GETSCREENREADER = 0x0046;

    [NativeTypeName("#define SPI_SETSCREENREADER 0x0047")]
    public const int SPI_SETSCREENREADER = 0x0047;

    [NativeTypeName("#define SPI_GETANIMATION 0x0048")]
    public const int SPI_GETANIMATION = 0x0048;

    [NativeTypeName("#define SPI_SETANIMATION 0x0049")]
    public const int SPI_SETANIMATION = 0x0049;

    [NativeTypeName("#define SPI_GETFONTSMOOTHING 0x004A")]
    public const int SPI_GETFONTSMOOTHING = 0x004A;

    [NativeTypeName("#define SPI_SETFONTSMOOTHING 0x004B")]
    public const int SPI_SETFONTSMOOTHING = 0x004B;

    [NativeTypeName("#define SPI_SETDRAGWIDTH 0x004C")]
    public const int SPI_SETDRAGWIDTH = 0x004C;

    [NativeTypeName("#define SPI_SETDRAGHEIGHT 0x004D")]
    public const int SPI_SETDRAGHEIGHT = 0x004D;

    [NativeTypeName("#define SPI_SETHANDHELD 0x004E")]
    public const int SPI_SETHANDHELD = 0x004E;

    [NativeTypeName("#define SPI_GETLOWPOWERTIMEOUT 0x004F")]
    public const int SPI_GETLOWPOWERTIMEOUT = 0x004F;

    [NativeTypeName("#define SPI_GETPOWEROFFTIMEOUT 0x0050")]
    public const int SPI_GETPOWEROFFTIMEOUT = 0x0050;

    [NativeTypeName("#define SPI_SETLOWPOWERTIMEOUT 0x0051")]
    public const int SPI_SETLOWPOWERTIMEOUT = 0x0051;

    [NativeTypeName("#define SPI_SETPOWEROFFTIMEOUT 0x0052")]
    public const int SPI_SETPOWEROFFTIMEOUT = 0x0052;

    [NativeTypeName("#define SPI_GETLOWPOWERACTIVE 0x0053")]
    public const int SPI_GETLOWPOWERACTIVE = 0x0053;

    [NativeTypeName("#define SPI_GETPOWEROFFACTIVE 0x0054")]
    public const int SPI_GETPOWEROFFACTIVE = 0x0054;

    [NativeTypeName("#define SPI_SETLOWPOWERACTIVE 0x0055")]
    public const int SPI_SETLOWPOWERACTIVE = 0x0055;

    [NativeTypeName("#define SPI_SETPOWEROFFACTIVE 0x0056")]
    public const int SPI_SETPOWEROFFACTIVE = 0x0056;

    [NativeTypeName("#define SPI_SETCURSORS 0x0057")]
    public const int SPI_SETCURSORS = 0x0057;

    [NativeTypeName("#define SPI_SETICONS 0x0058")]
    public const int SPI_SETICONS = 0x0058;

    [NativeTypeName("#define SPI_GETDEFAULTINPUTLANG 0x0059")]
    public const int SPI_GETDEFAULTINPUTLANG = 0x0059;

    [NativeTypeName("#define SPI_SETDEFAULTINPUTLANG 0x005A")]
    public const int SPI_SETDEFAULTINPUTLANG = 0x005A;

    [NativeTypeName("#define SPI_SETLANGTOGGLE 0x005B")]
    public const int SPI_SETLANGTOGGLE = 0x005B;

    [NativeTypeName("#define SPI_GETWINDOWSEXTENSION 0x005C")]
    public const int SPI_GETWINDOWSEXTENSION = 0x005C;

    [NativeTypeName("#define SPI_SETMOUSETRAILS 0x005D")]
    public const int SPI_SETMOUSETRAILS = 0x005D;

    [NativeTypeName("#define SPI_GETMOUSETRAILS 0x005E")]
    public const int SPI_GETMOUSETRAILS = 0x005E;

    [NativeTypeName("#define SPI_SETSCREENSAVERRUNNING 0x0061")]
    public const int SPI_SETSCREENSAVERRUNNING = 0x0061;

    [NativeTypeName("#define SPI_SCREENSAVERRUNNING SPI_SETSCREENSAVERRUNNING")]
    public const int SPI_SCREENSAVERRUNNING = 0x0061;

    [NativeTypeName("#define SPI_GETFILTERKEYS 0x0032")]
    public const int SPI_GETFILTERKEYS = 0x0032;

    [NativeTypeName("#define SPI_SETFILTERKEYS 0x0033")]
    public const int SPI_SETFILTERKEYS = 0x0033;

    [NativeTypeName("#define SPI_GETTOGGLEKEYS 0x0034")]
    public const int SPI_GETTOGGLEKEYS = 0x0034;

    [NativeTypeName("#define SPI_SETTOGGLEKEYS 0x0035")]
    public const int SPI_SETTOGGLEKEYS = 0x0035;

    [NativeTypeName("#define SPI_GETMOUSEKEYS 0x0036")]
    public const int SPI_GETMOUSEKEYS = 0x0036;

    [NativeTypeName("#define SPI_SETMOUSEKEYS 0x0037")]
    public const int SPI_SETMOUSEKEYS = 0x0037;

    [NativeTypeName("#define SPI_GETSHOWSOUNDS 0x0038")]
    public const int SPI_GETSHOWSOUNDS = 0x0038;

    [NativeTypeName("#define SPI_SETSHOWSOUNDS 0x0039")]
    public const int SPI_SETSHOWSOUNDS = 0x0039;

    [NativeTypeName("#define SPI_GETSTICKYKEYS 0x003A")]
    public const int SPI_GETSTICKYKEYS = 0x003A;

    [NativeTypeName("#define SPI_SETSTICKYKEYS 0x003B")]
    public const int SPI_SETSTICKYKEYS = 0x003B;

    [NativeTypeName("#define SPI_GETACCESSTIMEOUT 0x003C")]
    public const int SPI_GETACCESSTIMEOUT = 0x003C;

    [NativeTypeName("#define SPI_SETACCESSTIMEOUT 0x003D")]
    public const int SPI_SETACCESSTIMEOUT = 0x003D;

    [NativeTypeName("#define SPI_GETSERIALKEYS 0x003E")]
    public const int SPI_GETSERIALKEYS = 0x003E;

    [NativeTypeName("#define SPI_SETSERIALKEYS 0x003F")]
    public const int SPI_SETSERIALKEYS = 0x003F;

    [NativeTypeName("#define SPI_GETSOUNDSENTRY 0x0040")]
    public const int SPI_GETSOUNDSENTRY = 0x0040;

    [NativeTypeName("#define SPI_SETSOUNDSENTRY 0x0041")]
    public const int SPI_SETSOUNDSENTRY = 0x0041;

    [NativeTypeName("#define SPI_GETSNAPTODEFBUTTON 0x005F")]
    public const int SPI_GETSNAPTODEFBUTTON = 0x005F;

    [NativeTypeName("#define SPI_SETSNAPTODEFBUTTON 0x0060")]
    public const int SPI_SETSNAPTODEFBUTTON = 0x0060;

    [NativeTypeName("#define SPI_GETMOUSEHOVERWIDTH 0x0062")]
    public const int SPI_GETMOUSEHOVERWIDTH = 0x0062;

    [NativeTypeName("#define SPI_SETMOUSEHOVERWIDTH 0x0063")]
    public const int SPI_SETMOUSEHOVERWIDTH = 0x0063;

    [NativeTypeName("#define SPI_GETMOUSEHOVERHEIGHT 0x0064")]
    public const int SPI_GETMOUSEHOVERHEIGHT = 0x0064;

    [NativeTypeName("#define SPI_SETMOUSEHOVERHEIGHT 0x0065")]
    public const int SPI_SETMOUSEHOVERHEIGHT = 0x0065;

    [NativeTypeName("#define SPI_GETMOUSEHOVERTIME 0x0066")]
    public const int SPI_GETMOUSEHOVERTIME = 0x0066;

    [NativeTypeName("#define SPI_SETMOUSEHOVERTIME 0x0067")]
    public const int SPI_SETMOUSEHOVERTIME = 0x0067;

    [NativeTypeName("#define SPI_GETWHEELSCROLLLINES 0x0068")]
    public const int SPI_GETWHEELSCROLLLINES = 0x0068;

    [NativeTypeName("#define SPI_SETWHEELSCROLLLINES 0x0069")]
    public const int SPI_SETWHEELSCROLLLINES = 0x0069;

    [NativeTypeName("#define SPI_GETMENUSHOWDELAY 0x006A")]
    public const int SPI_GETMENUSHOWDELAY = 0x006A;

    [NativeTypeName("#define SPI_SETMENUSHOWDELAY 0x006B")]
    public const int SPI_SETMENUSHOWDELAY = 0x006B;

    [NativeTypeName("#define SPI_GETWHEELSCROLLCHARS 0x006C")]
    public const int SPI_GETWHEELSCROLLCHARS = 0x006C;

    [NativeTypeName("#define SPI_SETWHEELSCROLLCHARS 0x006D")]
    public const int SPI_SETWHEELSCROLLCHARS = 0x006D;

    [NativeTypeName("#define SPI_GETSHOWIMEUI 0x006E")]
    public const int SPI_GETSHOWIMEUI = 0x006E;

    [NativeTypeName("#define SPI_SETSHOWIMEUI 0x006F")]
    public const int SPI_SETSHOWIMEUI = 0x006F;

    [NativeTypeName("#define SPI_GETMOUSESPEED 0x0070")]
    public const int SPI_GETMOUSESPEED = 0x0070;

    [NativeTypeName("#define SPI_SETMOUSESPEED 0x0071")]
    public const int SPI_SETMOUSESPEED = 0x0071;

    [NativeTypeName("#define SPI_GETSCREENSAVERRUNNING 0x0072")]
    public const int SPI_GETSCREENSAVERRUNNING = 0x0072;

    [NativeTypeName("#define SPI_GETDESKWALLPAPER 0x0073")]
    public const int SPI_GETDESKWALLPAPER = 0x0073;

    [NativeTypeName("#define SPI_GETAUDIODESCRIPTION 0x0074")]
    public const int SPI_GETAUDIODESCRIPTION = 0x0074;

    [NativeTypeName("#define SPI_SETAUDIODESCRIPTION 0x0075")]
    public const int SPI_SETAUDIODESCRIPTION = 0x0075;

    [NativeTypeName("#define SPI_GETSCREENSAVESECURE 0x0076")]
    public const int SPI_GETSCREENSAVESECURE = 0x0076;

    [NativeTypeName("#define SPI_SETSCREENSAVESECURE 0x0077")]
    public const int SPI_SETSCREENSAVESECURE = 0x0077;

    [NativeTypeName("#define SPI_GETHUNGAPPTIMEOUT 0x0078")]
    public const int SPI_GETHUNGAPPTIMEOUT = 0x0078;

    [NativeTypeName("#define SPI_SETHUNGAPPTIMEOUT 0x0079")]
    public const int SPI_SETHUNGAPPTIMEOUT = 0x0079;

    [NativeTypeName("#define SPI_GETWAITTOKILLTIMEOUT 0x007A")]
    public const int SPI_GETWAITTOKILLTIMEOUT = 0x007A;

    [NativeTypeName("#define SPI_SETWAITTOKILLTIMEOUT 0x007B")]
    public const int SPI_SETWAITTOKILLTIMEOUT = 0x007B;

    [NativeTypeName("#define SPI_GETWAITTOKILLSERVICETIMEOUT 0x007C")]
    public const int SPI_GETWAITTOKILLSERVICETIMEOUT = 0x007C;

    [NativeTypeName("#define SPI_SETWAITTOKILLSERVICETIMEOUT 0x007D")]
    public const int SPI_SETWAITTOKILLSERVICETIMEOUT = 0x007D;

    [NativeTypeName("#define SPI_GETMOUSEDOCKTHRESHOLD 0x007E")]
    public const int SPI_GETMOUSEDOCKTHRESHOLD = 0x007E;

    [NativeTypeName("#define SPI_SETMOUSEDOCKTHRESHOLD 0x007F")]
    public const int SPI_SETMOUSEDOCKTHRESHOLD = 0x007F;

    [NativeTypeName("#define SPI_GETPENDOCKTHRESHOLD 0x0080")]
    public const int SPI_GETPENDOCKTHRESHOLD = 0x0080;

    [NativeTypeName("#define SPI_SETPENDOCKTHRESHOLD 0x0081")]
    public const int SPI_SETPENDOCKTHRESHOLD = 0x0081;

    [NativeTypeName("#define SPI_GETWINARRANGING 0x0082")]
    public const int SPI_GETWINARRANGING = 0x0082;

    [NativeTypeName("#define SPI_SETWINARRANGING 0x0083")]
    public const int SPI_SETWINARRANGING = 0x0083;

    [NativeTypeName("#define SPI_GETMOUSEDRAGOUTTHRESHOLD 0x0084")]
    public const int SPI_GETMOUSEDRAGOUTTHRESHOLD = 0x0084;

    [NativeTypeName("#define SPI_SETMOUSEDRAGOUTTHRESHOLD 0x0085")]
    public const int SPI_SETMOUSEDRAGOUTTHRESHOLD = 0x0085;

    [NativeTypeName("#define SPI_GETPENDRAGOUTTHRESHOLD 0x0086")]
    public const int SPI_GETPENDRAGOUTTHRESHOLD = 0x0086;

    [NativeTypeName("#define SPI_SETPENDRAGOUTTHRESHOLD 0x0087")]
    public const int SPI_SETPENDRAGOUTTHRESHOLD = 0x0087;

    [NativeTypeName("#define SPI_GETMOUSESIDEMOVETHRESHOLD 0x0088")]
    public const int SPI_GETMOUSESIDEMOVETHRESHOLD = 0x0088;

    [NativeTypeName("#define SPI_SETMOUSESIDEMOVETHRESHOLD 0x0089")]
    public const int SPI_SETMOUSESIDEMOVETHRESHOLD = 0x0089;

    [NativeTypeName("#define SPI_GETPENSIDEMOVETHRESHOLD 0x008A")]
    public const int SPI_GETPENSIDEMOVETHRESHOLD = 0x008A;

    [NativeTypeName("#define SPI_SETPENSIDEMOVETHRESHOLD 0x008B")]
    public const int SPI_SETPENSIDEMOVETHRESHOLD = 0x008B;

    [NativeTypeName("#define SPI_GETDRAGFROMMAXIMIZE 0x008C")]
    public const int SPI_GETDRAGFROMMAXIMIZE = 0x008C;

    [NativeTypeName("#define SPI_SETDRAGFROMMAXIMIZE 0x008D")]
    public const int SPI_SETDRAGFROMMAXIMIZE = 0x008D;

    [NativeTypeName("#define SPI_GETSNAPSIZING 0x008E")]
    public const int SPI_GETSNAPSIZING = 0x008E;

    [NativeTypeName("#define SPI_SETSNAPSIZING 0x008F")]
    public const int SPI_SETSNAPSIZING = 0x008F;

    [NativeTypeName("#define SPI_GETDOCKMOVING 0x0090")]
    public const int SPI_GETDOCKMOVING = 0x0090;

    [NativeTypeName("#define SPI_SETDOCKMOVING 0x0091")]
    public const int SPI_SETDOCKMOVING = 0x0091;

    [NativeTypeName("#define SPI_GETTOUCHPREDICTIONPARAMETERS 0x009C")]
    public const int SPI_GETTOUCHPREDICTIONPARAMETERS = 0x009C;

    [NativeTypeName("#define SPI_SETTOUCHPREDICTIONPARAMETERS 0x009D")]
    public const int SPI_SETTOUCHPREDICTIONPARAMETERS = 0x009D;

    [NativeTypeName("#define SPI_GETLOGICALDPIOVERRIDE 0x009E")]
    public const int SPI_GETLOGICALDPIOVERRIDE = 0x009E;

    [NativeTypeName("#define SPI_SETLOGICALDPIOVERRIDE 0x009F")]
    public const int SPI_SETLOGICALDPIOVERRIDE = 0x009F;

    [NativeTypeName("#define SPI_GETMENURECT 0x00A2")]
    public const int SPI_GETMENURECT = 0x00A2;

    [NativeTypeName("#define SPI_SETMENURECT 0x00A3")]
    public const int SPI_SETMENURECT = 0x00A3;

    [NativeTypeName("#define SPI_GETTOUCHPADPARAMETERS 0x00AE")]
    public const int SPI_GETTOUCHPADPARAMETERS = 0x00AE;

    [NativeTypeName("#define SPI_SETTOUCHPADPARAMETERS 0x00AF")]
    public const int SPI_SETTOUCHPADPARAMETERS = 0x00AF;

    [NativeTypeName("#define SPI_GETACTIVEWINDOWTRACKING 0x1000")]
    public const int SPI_GETACTIVEWINDOWTRACKING = 0x1000;

    [NativeTypeName("#define SPI_SETACTIVEWINDOWTRACKING 0x1001")]
    public const int SPI_SETACTIVEWINDOWTRACKING = 0x1001;

    [NativeTypeName("#define SPI_GETMENUANIMATION 0x1002")]
    public const int SPI_GETMENUANIMATION = 0x1002;

    [NativeTypeName("#define SPI_SETMENUANIMATION 0x1003")]
    public const int SPI_SETMENUANIMATION = 0x1003;

    [NativeTypeName("#define SPI_GETCOMBOBOXANIMATION 0x1004")]
    public const int SPI_GETCOMBOBOXANIMATION = 0x1004;

    [NativeTypeName("#define SPI_SETCOMBOBOXANIMATION 0x1005")]
    public const int SPI_SETCOMBOBOXANIMATION = 0x1005;

    [NativeTypeName("#define SPI_GETLISTBOXSMOOTHSCROLLING 0x1006")]
    public const int SPI_GETLISTBOXSMOOTHSCROLLING = 0x1006;

    [NativeTypeName("#define SPI_SETLISTBOXSMOOTHSCROLLING 0x1007")]
    public const int SPI_SETLISTBOXSMOOTHSCROLLING = 0x1007;

    [NativeTypeName("#define SPI_GETGRADIENTCAPTIONS 0x1008")]
    public const int SPI_GETGRADIENTCAPTIONS = 0x1008;

    [NativeTypeName("#define SPI_SETGRADIENTCAPTIONS 0x1009")]
    public const int SPI_SETGRADIENTCAPTIONS = 0x1009;

    [NativeTypeName("#define SPI_GETKEYBOARDCUES 0x100A")]
    public const int SPI_GETKEYBOARDCUES = 0x100A;

    [NativeTypeName("#define SPI_SETKEYBOARDCUES 0x100B")]
    public const int SPI_SETKEYBOARDCUES = 0x100B;

    [NativeTypeName("#define SPI_GETMENUUNDERLINES SPI_GETKEYBOARDCUES")]
    public const int SPI_GETMENUUNDERLINES = 0x100A;

    [NativeTypeName("#define SPI_SETMENUUNDERLINES SPI_SETKEYBOARDCUES")]
    public const int SPI_SETMENUUNDERLINES = 0x100B;

    [NativeTypeName("#define SPI_GETACTIVEWNDTRKZORDER 0x100C")]
    public const int SPI_GETACTIVEWNDTRKZORDER = 0x100C;

    [NativeTypeName("#define SPI_SETACTIVEWNDTRKZORDER 0x100D")]
    public const int SPI_SETACTIVEWNDTRKZORDER = 0x100D;

    [NativeTypeName("#define SPI_GETHOTTRACKING 0x100E")]
    public const int SPI_GETHOTTRACKING = 0x100E;

    [NativeTypeName("#define SPI_SETHOTTRACKING 0x100F")]
    public const int SPI_SETHOTTRACKING = 0x100F;

    [NativeTypeName("#define SPI_GETMENUFADE 0x1012")]
    public const int SPI_GETMENUFADE = 0x1012;

    [NativeTypeName("#define SPI_SETMENUFADE 0x1013")]
    public const int SPI_SETMENUFADE = 0x1013;

    [NativeTypeName("#define SPI_GETSELECTIONFADE 0x1014")]
    public const int SPI_GETSELECTIONFADE = 0x1014;

    [NativeTypeName("#define SPI_SETSELECTIONFADE 0x1015")]
    public const int SPI_SETSELECTIONFADE = 0x1015;

    [NativeTypeName("#define SPI_GETTOOLTIPANIMATION 0x1016")]
    public const int SPI_GETTOOLTIPANIMATION = 0x1016;

    [NativeTypeName("#define SPI_SETTOOLTIPANIMATION 0x1017")]
    public const int SPI_SETTOOLTIPANIMATION = 0x1017;

    [NativeTypeName("#define SPI_GETTOOLTIPFADE 0x1018")]
    public const int SPI_GETTOOLTIPFADE = 0x1018;

    [NativeTypeName("#define SPI_SETTOOLTIPFADE 0x1019")]
    public const int SPI_SETTOOLTIPFADE = 0x1019;

    [NativeTypeName("#define SPI_GETCURSORSHADOW 0x101A")]
    public const int SPI_GETCURSORSHADOW = 0x101A;

    [NativeTypeName("#define SPI_SETCURSORSHADOW 0x101B")]
    public const int SPI_SETCURSORSHADOW = 0x101B;

    [NativeTypeName("#define SPI_GETMOUSESONAR 0x101C")]
    public const int SPI_GETMOUSESONAR = 0x101C;

    [NativeTypeName("#define SPI_SETMOUSESONAR 0x101D")]
    public const int SPI_SETMOUSESONAR = 0x101D;

    [NativeTypeName("#define SPI_GETMOUSECLICKLOCK 0x101E")]
    public const int SPI_GETMOUSECLICKLOCK = 0x101E;

    [NativeTypeName("#define SPI_SETMOUSECLICKLOCK 0x101F")]
    public const int SPI_SETMOUSECLICKLOCK = 0x101F;

    [NativeTypeName("#define SPI_GETMOUSEVANISH 0x1020")]
    public const int SPI_GETMOUSEVANISH = 0x1020;

    [NativeTypeName("#define SPI_SETMOUSEVANISH 0x1021")]
    public const int SPI_SETMOUSEVANISH = 0x1021;

    [NativeTypeName("#define SPI_GETFLATMENU 0x1022")]
    public const int SPI_GETFLATMENU = 0x1022;

    [NativeTypeName("#define SPI_SETFLATMENU 0x1023")]
    public const int SPI_SETFLATMENU = 0x1023;

    [NativeTypeName("#define SPI_GETDROPSHADOW 0x1024")]
    public const int SPI_GETDROPSHADOW = 0x1024;

    [NativeTypeName("#define SPI_SETDROPSHADOW 0x1025")]
    public const int SPI_SETDROPSHADOW = 0x1025;

    [NativeTypeName("#define SPI_GETBLOCKSENDINPUTRESETS 0x1026")]
    public const int SPI_GETBLOCKSENDINPUTRESETS = 0x1026;

    [NativeTypeName("#define SPI_SETBLOCKSENDINPUTRESETS 0x1027")]
    public const int SPI_SETBLOCKSENDINPUTRESETS = 0x1027;

    [NativeTypeName("#define SPI_GETUIEFFECTS 0x103E")]
    public const int SPI_GETUIEFFECTS = 0x103E;

    [NativeTypeName("#define SPI_SETUIEFFECTS 0x103F")]
    public const int SPI_SETUIEFFECTS = 0x103F;

    [NativeTypeName("#define SPI_GETDISABLEOVERLAPPEDCONTENT 0x1040")]
    public const int SPI_GETDISABLEOVERLAPPEDCONTENT = 0x1040;

    [NativeTypeName("#define SPI_SETDISABLEOVERLAPPEDCONTENT 0x1041")]
    public const int SPI_SETDISABLEOVERLAPPEDCONTENT = 0x1041;

    [NativeTypeName("#define SPI_GETCLIENTAREAANIMATION 0x1042")]
    public const int SPI_GETCLIENTAREAANIMATION = 0x1042;

    [NativeTypeName("#define SPI_SETCLIENTAREAANIMATION 0x1043")]
    public const int SPI_SETCLIENTAREAANIMATION = 0x1043;

    [NativeTypeName("#define SPI_GETCLEARTYPE 0x1048")]
    public const int SPI_GETCLEARTYPE = 0x1048;

    [NativeTypeName("#define SPI_SETCLEARTYPE 0x1049")]
    public const int SPI_SETCLEARTYPE = 0x1049;

    [NativeTypeName("#define SPI_GETSPEECHRECOGNITION 0x104A")]
    public const int SPI_GETSPEECHRECOGNITION = 0x104A;

    [NativeTypeName("#define SPI_SETSPEECHRECOGNITION 0x104B")]
    public const int SPI_SETSPEECHRECOGNITION = 0x104B;

    [NativeTypeName("#define SPI_GETCARETBROWSING 0x104C")]
    public const int SPI_GETCARETBROWSING = 0x104C;

    [NativeTypeName("#define SPI_SETCARETBROWSING 0x104D")]
    public const int SPI_SETCARETBROWSING = 0x104D;

    [NativeTypeName("#define SPI_GETTHREADLOCALINPUTSETTINGS 0x104E")]
    public const int SPI_GETTHREADLOCALINPUTSETTINGS = 0x104E;

    [NativeTypeName("#define SPI_SETTHREADLOCALINPUTSETTINGS 0x104F")]
    public const int SPI_SETTHREADLOCALINPUTSETTINGS = 0x104F;

    [NativeTypeName("#define SPI_GETSYSTEMLANGUAGEBAR 0x1050")]
    public const int SPI_GETSYSTEMLANGUAGEBAR = 0x1050;

    [NativeTypeName("#define SPI_SETSYSTEMLANGUAGEBAR 0x1051")]
    public const int SPI_SETSYSTEMLANGUAGEBAR = 0x1051;

    [NativeTypeName("#define SPI_GETFOREGROUNDLOCKTIMEOUT 0x2000")]
    public const int SPI_GETFOREGROUNDLOCKTIMEOUT = 0x2000;

    [NativeTypeName("#define SPI_SETFOREGROUNDLOCKTIMEOUT 0x2001")]
    public const int SPI_SETFOREGROUNDLOCKTIMEOUT = 0x2001;

    [NativeTypeName("#define SPI_GETACTIVEWNDTRKTIMEOUT 0x2002")]
    public const int SPI_GETACTIVEWNDTRKTIMEOUT = 0x2002;

    [NativeTypeName("#define SPI_SETACTIVEWNDTRKTIMEOUT 0x2003")]
    public const int SPI_SETACTIVEWNDTRKTIMEOUT = 0x2003;

    [NativeTypeName("#define SPI_GETFOREGROUNDFLASHCOUNT 0x2004")]
    public const int SPI_GETFOREGROUNDFLASHCOUNT = 0x2004;

    [NativeTypeName("#define SPI_SETFOREGROUNDFLASHCOUNT 0x2005")]
    public const int SPI_SETFOREGROUNDFLASHCOUNT = 0x2005;

    [NativeTypeName("#define SPI_GETCARETWIDTH 0x2006")]
    public const int SPI_GETCARETWIDTH = 0x2006;

    [NativeTypeName("#define SPI_SETCARETWIDTH 0x2007")]
    public const int SPI_SETCARETWIDTH = 0x2007;

    [NativeTypeName("#define SPI_GETMOUSECLICKLOCKTIME 0x2008")]
    public const int SPI_GETMOUSECLICKLOCKTIME = 0x2008;

    [NativeTypeName("#define SPI_SETMOUSECLICKLOCKTIME 0x2009")]
    public const int SPI_SETMOUSECLICKLOCKTIME = 0x2009;

    [NativeTypeName("#define SPI_GETFONTSMOOTHINGTYPE 0x200A")]
    public const int SPI_GETFONTSMOOTHINGTYPE = 0x200A;

    [NativeTypeName("#define SPI_SETFONTSMOOTHINGTYPE 0x200B")]
    public const int SPI_SETFONTSMOOTHINGTYPE = 0x200B;

    [NativeTypeName("#define SPI_GETFONTSMOOTHINGCONTRAST 0x200C")]
    public const int SPI_GETFONTSMOOTHINGCONTRAST = 0x200C;

    [NativeTypeName("#define SPI_SETFONTSMOOTHINGCONTRAST 0x200D")]
    public const int SPI_SETFONTSMOOTHINGCONTRAST = 0x200D;

    [NativeTypeName("#define SPI_GETFOCUSBORDERWIDTH 0x200E")]
    public const int SPI_GETFOCUSBORDERWIDTH = 0x200E;

    [NativeTypeName("#define SPI_SETFOCUSBORDERWIDTH 0x200F")]
    public const int SPI_SETFOCUSBORDERWIDTH = 0x200F;

    [NativeTypeName("#define SPI_GETFOCUSBORDERHEIGHT 0x2010")]
    public const int SPI_GETFOCUSBORDERHEIGHT = 0x2010;

    [NativeTypeName("#define SPI_SETFOCUSBORDERHEIGHT 0x2011")]
    public const int SPI_SETFOCUSBORDERHEIGHT = 0x2011;

    [NativeTypeName("#define SPI_GETFONTSMOOTHINGORIENTATION 0x2012")]
    public const int SPI_GETFONTSMOOTHINGORIENTATION = 0x2012;

    [NativeTypeName("#define SPI_SETFONTSMOOTHINGORIENTATION 0x2013")]
    public const int SPI_SETFONTSMOOTHINGORIENTATION = 0x2013;

    [NativeTypeName("#define SPI_GETMINIMUMHITRADIUS 0x2014")]
    public const int SPI_GETMINIMUMHITRADIUS = 0x2014;

    [NativeTypeName("#define SPI_SETMINIMUMHITRADIUS 0x2015")]
    public const int SPI_SETMINIMUMHITRADIUS = 0x2015;

    [NativeTypeName("#define SPI_GETMESSAGEDURATION 0x2016")]
    public const int SPI_GETMESSAGEDURATION = 0x2016;

    [NativeTypeName("#define SPI_SETMESSAGEDURATION 0x2017")]
    public const int SPI_SETMESSAGEDURATION = 0x2017;

    [NativeTypeName("#define SPI_GETCONTACTVISUALIZATION 0x2018")]
    public const int SPI_GETCONTACTVISUALIZATION = 0x2018;

    [NativeTypeName("#define SPI_SETCONTACTVISUALIZATION 0x2019")]
    public const int SPI_SETCONTACTVISUALIZATION = 0x2019;

    [NativeTypeName("#define SPI_GETGESTUREVISUALIZATION 0x201A")]
    public const int SPI_GETGESTUREVISUALIZATION = 0x201A;

    [NativeTypeName("#define SPI_SETGESTUREVISUALIZATION 0x201B")]
    public const int SPI_SETGESTUREVISUALIZATION = 0x201B;

    [NativeTypeName("#define SPI_GETMOUSEWHEELROUTING 0x201C")]
    public const int SPI_GETMOUSEWHEELROUTING = 0x201C;

    [NativeTypeName("#define SPI_SETMOUSEWHEELROUTING 0x201D")]
    public const int SPI_SETMOUSEWHEELROUTING = 0x201D;

    [NativeTypeName("#define SPI_GETPENVISUALIZATION 0x201E")]
    public const int SPI_GETPENVISUALIZATION = 0x201E;

    [NativeTypeName("#define SPI_SETPENVISUALIZATION 0x201F")]
    public const int SPI_SETPENVISUALIZATION = 0x201F;

    [NativeTypeName("#define SPI_GETPENARBITRATIONTYPE 0x2020")]
    public const int SPI_GETPENARBITRATIONTYPE = 0x2020;

    [NativeTypeName("#define SPI_SETPENARBITRATIONTYPE 0x2021")]
    public const int SPI_SETPENARBITRATIONTYPE = 0x2021;

    [NativeTypeName("#define SPI_GETCARETTIMEOUT 0x2022")]
    public const int SPI_GETCARETTIMEOUT = 0x2022;

    [NativeTypeName("#define SPI_SETCARETTIMEOUT 0x2023")]
    public const int SPI_SETCARETTIMEOUT = 0x2023;

    [NativeTypeName("#define SPI_GETHANDEDNESS 0x2024")]
    public const int SPI_GETHANDEDNESS = 0x2024;

    [NativeTypeName("#define SPI_SETHANDEDNESS 0x2025")]
    public const int SPI_SETHANDEDNESS = 0x2025;
}
