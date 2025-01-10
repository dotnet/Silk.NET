// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WM
{
    [NativeTypeName("#define WM_NULL 0x0000")]
    public const int WM_NULL = 0x0000;

    [NativeTypeName("#define WM_CREATE 0x0001")]
    public const int WM_CREATE = 0x0001;

    [NativeTypeName("#define WM_DESTROY 0x0002")]
    public const int WM_DESTROY = 0x0002;

    [NativeTypeName("#define WM_MOVE 0x0003")]
    public const int WM_MOVE = 0x0003;

    [NativeTypeName("#define WM_SIZE 0x0005")]
    public const int WM_SIZE = 0x0005;

    [NativeTypeName("#define WM_ACTIVATE 0x0006")]
    public const int WM_ACTIVATE = 0x0006;

    [NativeTypeName("#define WM_SETFOCUS 0x0007")]
    public const int WM_SETFOCUS = 0x0007;

    [NativeTypeName("#define WM_KILLFOCUS 0x0008")]
    public const int WM_KILLFOCUS = 0x0008;

    [NativeTypeName("#define WM_ENABLE 0x000A")]
    public const int WM_ENABLE = 0x000A;

    [NativeTypeName("#define WM_SETREDRAW 0x000B")]
    public const int WM_SETREDRAW = 0x000B;

    [NativeTypeName("#define WM_SETTEXT 0x000C")]
    public const int WM_SETTEXT = 0x000C;

    [NativeTypeName("#define WM_GETTEXT 0x000D")]
    public const int WM_GETTEXT = 0x000D;

    [NativeTypeName("#define WM_GETTEXTLENGTH 0x000E")]
    public const int WM_GETTEXTLENGTH = 0x000E;

    [NativeTypeName("#define WM_PAINT 0x000F")]
    public const int WM_PAINT = 0x000F;

    [NativeTypeName("#define WM_CLOSE 0x0010")]
    public const int WM_CLOSE = 0x0010;

    [NativeTypeName("#define WM_QUERYENDSESSION 0x0011")]
    public const int WM_QUERYENDSESSION = 0x0011;

    [NativeTypeName("#define WM_QUERYOPEN 0x0013")]
    public const int WM_QUERYOPEN = 0x0013;

    [NativeTypeName("#define WM_ENDSESSION 0x0016")]
    public const int WM_ENDSESSION = 0x0016;

    [NativeTypeName("#define WM_QUIT 0x0012")]
    public const int WM_QUIT = 0x0012;

    [NativeTypeName("#define WM_ERASEBKGND 0x0014")]
    public const int WM_ERASEBKGND = 0x0014;

    [NativeTypeName("#define WM_SYSCOLORCHANGE 0x0015")]
    public const int WM_SYSCOLORCHANGE = 0x0015;

    [NativeTypeName("#define WM_SHOWWINDOW 0x0018")]
    public const int WM_SHOWWINDOW = 0x0018;

    [NativeTypeName("#define WM_WININICHANGE 0x001A")]
    public const int WM_WININICHANGE = 0x001A;

    [NativeTypeName("#define WM_SETTINGCHANGE WM_WININICHANGE")]
    public const int WM_SETTINGCHANGE = 0x001A;

    [NativeTypeName("#define WM_DEVMODECHANGE 0x001B")]
    public const int WM_DEVMODECHANGE = 0x001B;

    [NativeTypeName("#define WM_ACTIVATEAPP 0x001C")]
    public const int WM_ACTIVATEAPP = 0x001C;

    [NativeTypeName("#define WM_FONTCHANGE 0x001D")]
    public const int WM_FONTCHANGE = 0x001D;

    [NativeTypeName("#define WM_TIMECHANGE 0x001E")]
    public const int WM_TIMECHANGE = 0x001E;

    [NativeTypeName("#define WM_CANCELMODE 0x001F")]
    public const int WM_CANCELMODE = 0x001F;

    [NativeTypeName("#define WM_SETCURSOR 0x0020")]
    public const int WM_SETCURSOR = 0x0020;

    [NativeTypeName("#define WM_MOUSEACTIVATE 0x0021")]
    public const int WM_MOUSEACTIVATE = 0x0021;

    [NativeTypeName("#define WM_CHILDACTIVATE 0x0022")]
    public const int WM_CHILDACTIVATE = 0x0022;

    [NativeTypeName("#define WM_QUEUESYNC 0x0023")]
    public const int WM_QUEUESYNC = 0x0023;

    [NativeTypeName("#define WM_GETMINMAXINFO 0x0024")]
    public const int WM_GETMINMAXINFO = 0x0024;

    [NativeTypeName("#define WM_PAINTICON 0x0026")]
    public const int WM_PAINTICON = 0x0026;

    [NativeTypeName("#define WM_ICONERASEBKGND 0x0027")]
    public const int WM_ICONERASEBKGND = 0x0027;

    [NativeTypeName("#define WM_NEXTDLGCTL 0x0028")]
    public const int WM_NEXTDLGCTL = 0x0028;

    [NativeTypeName("#define WM_SPOOLERSTATUS 0x002A")]
    public const int WM_SPOOLERSTATUS = 0x002A;

    [NativeTypeName("#define WM_DRAWITEM 0x002B")]
    public const int WM_DRAWITEM = 0x002B;

    [NativeTypeName("#define WM_MEASUREITEM 0x002C")]
    public const int WM_MEASUREITEM = 0x002C;

    [NativeTypeName("#define WM_DELETEITEM 0x002D")]
    public const int WM_DELETEITEM = 0x002D;

    [NativeTypeName("#define WM_VKEYTOITEM 0x002E")]
    public const int WM_VKEYTOITEM = 0x002E;

    [NativeTypeName("#define WM_CHARTOITEM 0x002F")]
    public const int WM_CHARTOITEM = 0x002F;

    [NativeTypeName("#define WM_SETFONT 0x0030")]
    public const int WM_SETFONT = 0x0030;

    [NativeTypeName("#define WM_GETFONT 0x0031")]
    public const int WM_GETFONT = 0x0031;

    [NativeTypeName("#define WM_SETHOTKEY 0x0032")]
    public const int WM_SETHOTKEY = 0x0032;

    [NativeTypeName("#define WM_GETHOTKEY 0x0033")]
    public const int WM_GETHOTKEY = 0x0033;

    [NativeTypeName("#define WM_QUERYDRAGICON 0x0037")]
    public const int WM_QUERYDRAGICON = 0x0037;

    [NativeTypeName("#define WM_COMPAREITEM 0x0039")]
    public const int WM_COMPAREITEM = 0x0039;

    [NativeTypeName("#define WM_GETOBJECT 0x003D")]
    public const int WM_GETOBJECT = 0x003D;

    [NativeTypeName("#define WM_COMPACTING 0x0041")]
    public const int WM_COMPACTING = 0x0041;

    [NativeTypeName("#define WM_COMMNOTIFY 0x0044")]
    public const int WM_COMMNOTIFY = 0x0044;

    [NativeTypeName("#define WM_WINDOWPOSCHANGING 0x0046")]
    public const int WM_WINDOWPOSCHANGING = 0x0046;

    [NativeTypeName("#define WM_WINDOWPOSCHANGED 0x0047")]
    public const int WM_WINDOWPOSCHANGED = 0x0047;

    [NativeTypeName("#define WM_POWER 0x0048")]
    public const int WM_POWER = 0x0048;

    [NativeTypeName("#define WM_COPYDATA 0x004A")]
    public const int WM_COPYDATA = 0x004A;

    [NativeTypeName("#define WM_CANCELJOURNAL 0x004B")]
    public const int WM_CANCELJOURNAL = 0x004B;

    [NativeTypeName("#define WM_NOTIFY 0x004E")]
    public const int WM_NOTIFY = 0x004E;

    [NativeTypeName("#define WM_INPUTLANGCHANGEREQUEST 0x0050")]
    public const int WM_INPUTLANGCHANGEREQUEST = 0x0050;

    [NativeTypeName("#define WM_INPUTLANGCHANGE 0x0051")]
    public const int WM_INPUTLANGCHANGE = 0x0051;

    [NativeTypeName("#define WM_TCARD 0x0052")]
    public const int WM_TCARD = 0x0052;

    [NativeTypeName("#define WM_HELP 0x0053")]
    public const int WM_HELP = 0x0053;

    [NativeTypeName("#define WM_USERCHANGED 0x0054")]
    public const int WM_USERCHANGED = 0x0054;

    [NativeTypeName("#define WM_NOTIFYFORMAT 0x0055")]
    public const int WM_NOTIFYFORMAT = 0x0055;

    [NativeTypeName("#define WM_CONTEXTMENU 0x007B")]
    public const int WM_CONTEXTMENU = 0x007B;

    [NativeTypeName("#define WM_STYLECHANGING 0x007C")]
    public const int WM_STYLECHANGING = 0x007C;

    [NativeTypeName("#define WM_STYLECHANGED 0x007D")]
    public const int WM_STYLECHANGED = 0x007D;

    [NativeTypeName("#define WM_DISPLAYCHANGE 0x007E")]
    public const int WM_DISPLAYCHANGE = 0x007E;

    [NativeTypeName("#define WM_GETICON 0x007F")]
    public const int WM_GETICON = 0x007F;

    [NativeTypeName("#define WM_SETICON 0x0080")]
    public const int WM_SETICON = 0x0080;

    [NativeTypeName("#define WM_NCCREATE 0x0081")]
    public const int WM_NCCREATE = 0x0081;

    [NativeTypeName("#define WM_NCDESTROY 0x0082")]
    public const int WM_NCDESTROY = 0x0082;

    [NativeTypeName("#define WM_NCCALCSIZE 0x0083")]
    public const int WM_NCCALCSIZE = 0x0083;

    [NativeTypeName("#define WM_NCHITTEST 0x0084")]
    public const int WM_NCHITTEST = 0x0084;

    [NativeTypeName("#define WM_NCPAINT 0x0085")]
    public const int WM_NCPAINT = 0x0085;

    [NativeTypeName("#define WM_NCACTIVATE 0x0086")]
    public const int WM_NCACTIVATE = 0x0086;

    [NativeTypeName("#define WM_GETDLGCODE 0x0087")]
    public const int WM_GETDLGCODE = 0x0087;

    [NativeTypeName("#define WM_SYNCPAINT 0x0088")]
    public const int WM_SYNCPAINT = 0x0088;

    [NativeTypeName("#define WM_NCMOUSEMOVE 0x00A0")]
    public const int WM_NCMOUSEMOVE = 0x00A0;

    [NativeTypeName("#define WM_NCLBUTTONDOWN 0x00A1")]
    public const int WM_NCLBUTTONDOWN = 0x00A1;

    [NativeTypeName("#define WM_NCLBUTTONUP 0x00A2")]
    public const int WM_NCLBUTTONUP = 0x00A2;

    [NativeTypeName("#define WM_NCLBUTTONDBLCLK 0x00A3")]
    public const int WM_NCLBUTTONDBLCLK = 0x00A3;

    [NativeTypeName("#define WM_NCRBUTTONDOWN 0x00A4")]
    public const int WM_NCRBUTTONDOWN = 0x00A4;

    [NativeTypeName("#define WM_NCRBUTTONUP 0x00A5")]
    public const int WM_NCRBUTTONUP = 0x00A5;

    [NativeTypeName("#define WM_NCRBUTTONDBLCLK 0x00A6")]
    public const int WM_NCRBUTTONDBLCLK = 0x00A6;

    [NativeTypeName("#define WM_NCMBUTTONDOWN 0x00A7")]
    public const int WM_NCMBUTTONDOWN = 0x00A7;

    [NativeTypeName("#define WM_NCMBUTTONUP 0x00A8")]
    public const int WM_NCMBUTTONUP = 0x00A8;

    [NativeTypeName("#define WM_NCMBUTTONDBLCLK 0x00A9")]
    public const int WM_NCMBUTTONDBLCLK = 0x00A9;

    [NativeTypeName("#define WM_NCXBUTTONDOWN 0x00AB")]
    public const int WM_NCXBUTTONDOWN = 0x00AB;

    [NativeTypeName("#define WM_NCXBUTTONUP 0x00AC")]
    public const int WM_NCXBUTTONUP = 0x00AC;

    [NativeTypeName("#define WM_NCXBUTTONDBLCLK 0x00AD")]
    public const int WM_NCXBUTTONDBLCLK = 0x00AD;

    [NativeTypeName("#define WM_INPUT_DEVICE_CHANGE 0x00FE")]
    public const int WM_INPUT_DEVICE_CHANGE = 0x00FE;

    [NativeTypeName("#define WM_INPUT 0x00FF")]
    public const int WM_INPUT = 0x00FF;

    [NativeTypeName("#define WM_KEYFIRST 0x0100")]
    public const int WM_KEYFIRST = 0x0100;

    [NativeTypeName("#define WM_KEYDOWN 0x0100")]
    public const int WM_KEYDOWN = 0x0100;

    [NativeTypeName("#define WM_KEYUP 0x0101")]
    public const int WM_KEYUP = 0x0101;

    [NativeTypeName("#define WM_CHAR 0x0102")]
    public const int WM_CHAR = 0x0102;

    [NativeTypeName("#define WM_DEADCHAR 0x0103")]
    public const int WM_DEADCHAR = 0x0103;

    [NativeTypeName("#define WM_SYSKEYDOWN 0x0104")]
    public const int WM_SYSKEYDOWN = 0x0104;

    [NativeTypeName("#define WM_SYSKEYUP 0x0105")]
    public const int WM_SYSKEYUP = 0x0105;

    [NativeTypeName("#define WM_SYSCHAR 0x0106")]
    public const int WM_SYSCHAR = 0x0106;

    [NativeTypeName("#define WM_SYSDEADCHAR 0x0107")]
    public const int WM_SYSDEADCHAR = 0x0107;

    [NativeTypeName("#define WM_UNICHAR 0x0109")]
    public const int WM_UNICHAR = 0x0109;

    [NativeTypeName("#define WM_KEYLAST 0x0109")]
    public const int WM_KEYLAST = 0x0109;

    [NativeTypeName("#define WM_IME_STARTCOMPOSITION 0x010D")]
    public const int WM_IME_STARTCOMPOSITION = 0x010D;

    [NativeTypeName("#define WM_IME_ENDCOMPOSITION 0x010E")]
    public const int WM_IME_ENDCOMPOSITION = 0x010E;

    [NativeTypeName("#define WM_IME_COMPOSITION 0x010F")]
    public const int WM_IME_COMPOSITION = 0x010F;

    [NativeTypeName("#define WM_IME_KEYLAST 0x010F")]
    public const int WM_IME_KEYLAST = 0x010F;

    [NativeTypeName("#define WM_INITDIALOG 0x0110")]
    public const int WM_INITDIALOG = 0x0110;

    [NativeTypeName("#define WM_COMMAND 0x0111")]
    public const int WM_COMMAND = 0x0111;

    [NativeTypeName("#define WM_SYSCOMMAND 0x0112")]
    public const int WM_SYSCOMMAND = 0x0112;

    [NativeTypeName("#define WM_TIMER 0x0113")]
    public const int WM_TIMER = 0x0113;

    [NativeTypeName("#define WM_HSCROLL 0x0114")]
    public const int WM_HSCROLL = 0x0114;

    [NativeTypeName("#define WM_VSCROLL 0x0115")]
    public const int WM_VSCROLL = 0x0115;

    [NativeTypeName("#define WM_INITMENU 0x0116")]
    public const int WM_INITMENU = 0x0116;

    [NativeTypeName("#define WM_INITMENUPOPUP 0x0117")]
    public const int WM_INITMENUPOPUP = 0x0117;

    [NativeTypeName("#define WM_GESTURE 0x0119")]
    public const int WM_GESTURE = 0x0119;

    [NativeTypeName("#define WM_GESTURENOTIFY 0x011A")]
    public const int WM_GESTURENOTIFY = 0x011A;

    [NativeTypeName("#define WM_MENUSELECT 0x011F")]
    public const int WM_MENUSELECT = 0x011F;

    [NativeTypeName("#define WM_MENUCHAR 0x0120")]
    public const int WM_MENUCHAR = 0x0120;

    [NativeTypeName("#define WM_ENTERIDLE 0x0121")]
    public const int WM_ENTERIDLE = 0x0121;

    [NativeTypeName("#define WM_MENURBUTTONUP 0x0122")]
    public const int WM_MENURBUTTONUP = 0x0122;

    [NativeTypeName("#define WM_MENUDRAG 0x0123")]
    public const int WM_MENUDRAG = 0x0123;

    [NativeTypeName("#define WM_MENUGETOBJECT 0x0124")]
    public const int WM_MENUGETOBJECT = 0x0124;

    [NativeTypeName("#define WM_UNINITMENUPOPUP 0x0125")]
    public const int WM_UNINITMENUPOPUP = 0x0125;

    [NativeTypeName("#define WM_MENUCOMMAND 0x0126")]
    public const int WM_MENUCOMMAND = 0x0126;

    [NativeTypeName("#define WM_CHANGEUISTATE 0x0127")]
    public const int WM_CHANGEUISTATE = 0x0127;

    [NativeTypeName("#define WM_UPDATEUISTATE 0x0128")]
    public const int WM_UPDATEUISTATE = 0x0128;

    [NativeTypeName("#define WM_QUERYUISTATE 0x0129")]
    public const int WM_QUERYUISTATE = 0x0129;

    [NativeTypeName("#define WM_CTLCOLORMSGBOX 0x0132")]
    public const int WM_CTLCOLORMSGBOX = 0x0132;

    [NativeTypeName("#define WM_CTLCOLOREDIT 0x0133")]
    public const int WM_CTLCOLOREDIT = 0x0133;

    [NativeTypeName("#define WM_CTLCOLORLISTBOX 0x0134")]
    public const int WM_CTLCOLORLISTBOX = 0x0134;

    [NativeTypeName("#define WM_CTLCOLORBTN 0x0135")]
    public const int WM_CTLCOLORBTN = 0x0135;

    [NativeTypeName("#define WM_CTLCOLORDLG 0x0136")]
    public const int WM_CTLCOLORDLG = 0x0136;

    [NativeTypeName("#define WM_CTLCOLORSCROLLBAR 0x0137")]
    public const int WM_CTLCOLORSCROLLBAR = 0x0137;

    [NativeTypeName("#define WM_CTLCOLORSTATIC 0x0138")]
    public const int WM_CTLCOLORSTATIC = 0x0138;

    [NativeTypeName("#define WM_MOUSEFIRST 0x0200")]
    public const int WM_MOUSEFIRST = 0x0200;

    [NativeTypeName("#define WM_MOUSEMOVE 0x0200")]
    public const int WM_MOUSEMOVE = 0x0200;

    [NativeTypeName("#define WM_LBUTTONDOWN 0x0201")]
    public const int WM_LBUTTONDOWN = 0x0201;

    [NativeTypeName("#define WM_LBUTTONUP 0x0202")]
    public const int WM_LBUTTONUP = 0x0202;

    [NativeTypeName("#define WM_LBUTTONDBLCLK 0x0203")]
    public const int WM_LBUTTONDBLCLK = 0x0203;

    [NativeTypeName("#define WM_RBUTTONDOWN 0x0204")]
    public const int WM_RBUTTONDOWN = 0x0204;

    [NativeTypeName("#define WM_RBUTTONUP 0x0205")]
    public const int WM_RBUTTONUP = 0x0205;

    [NativeTypeName("#define WM_RBUTTONDBLCLK 0x0206")]
    public const int WM_RBUTTONDBLCLK = 0x0206;

    [NativeTypeName("#define WM_MBUTTONDOWN 0x0207")]
    public const int WM_MBUTTONDOWN = 0x0207;

    [NativeTypeName("#define WM_MBUTTONUP 0x0208")]
    public const int WM_MBUTTONUP = 0x0208;

    [NativeTypeName("#define WM_MBUTTONDBLCLK 0x0209")]
    public const int WM_MBUTTONDBLCLK = 0x0209;

    [NativeTypeName("#define WM_MOUSEWHEEL 0x020A")]
    public const int WM_MOUSEWHEEL = 0x020A;

    [NativeTypeName("#define WM_XBUTTONDOWN 0x020B")]
    public const int WM_XBUTTONDOWN = 0x020B;

    [NativeTypeName("#define WM_XBUTTONUP 0x020C")]
    public const int WM_XBUTTONUP = 0x020C;

    [NativeTypeName("#define WM_XBUTTONDBLCLK 0x020D")]
    public const int WM_XBUTTONDBLCLK = 0x020D;

    [NativeTypeName("#define WM_MOUSEHWHEEL 0x020E")]
    public const int WM_MOUSEHWHEEL = 0x020E;

    [NativeTypeName("#define WM_MOUSELAST 0x020E")]
    public const int WM_MOUSELAST = 0x020E;

    [NativeTypeName("#define WM_PARENTNOTIFY 0x0210")]
    public const int WM_PARENTNOTIFY = 0x0210;

    [NativeTypeName("#define WM_ENTERMENULOOP 0x0211")]
    public const int WM_ENTERMENULOOP = 0x0211;

    [NativeTypeName("#define WM_EXITMENULOOP 0x0212")]
    public const int WM_EXITMENULOOP = 0x0212;

    [NativeTypeName("#define WM_NEXTMENU 0x0213")]
    public const int WM_NEXTMENU = 0x0213;

    [NativeTypeName("#define WM_SIZING 0x0214")]
    public const int WM_SIZING = 0x0214;

    [NativeTypeName("#define WM_CAPTURECHANGED 0x0215")]
    public const int WM_CAPTURECHANGED = 0x0215;

    [NativeTypeName("#define WM_MOVING 0x0216")]
    public const int WM_MOVING = 0x0216;

    [NativeTypeName("#define WM_POWERBROADCAST 0x0218")]
    public const int WM_POWERBROADCAST = 0x0218;

    [NativeTypeName("#define WM_DEVICECHANGE 0x0219")]
    public const int WM_DEVICECHANGE = 0x0219;

    [NativeTypeName("#define WM_MDICREATE 0x0220")]
    public const int WM_MDICREATE = 0x0220;

    [NativeTypeName("#define WM_MDIDESTROY 0x0221")]
    public const int WM_MDIDESTROY = 0x0221;

    [NativeTypeName("#define WM_MDIACTIVATE 0x0222")]
    public const int WM_MDIACTIVATE = 0x0222;

    [NativeTypeName("#define WM_MDIRESTORE 0x0223")]
    public const int WM_MDIRESTORE = 0x0223;

    [NativeTypeName("#define WM_MDINEXT 0x0224")]
    public const int WM_MDINEXT = 0x0224;

    [NativeTypeName("#define WM_MDIMAXIMIZE 0x0225")]
    public const int WM_MDIMAXIMIZE = 0x0225;

    [NativeTypeName("#define WM_MDITILE 0x0226")]
    public const int WM_MDITILE = 0x0226;

    [NativeTypeName("#define WM_MDICASCADE 0x0227")]
    public const int WM_MDICASCADE = 0x0227;

    [NativeTypeName("#define WM_MDIICONARRANGE 0x0228")]
    public const int WM_MDIICONARRANGE = 0x0228;

    [NativeTypeName("#define WM_MDIGETACTIVE 0x0229")]
    public const int WM_MDIGETACTIVE = 0x0229;

    [NativeTypeName("#define WM_MDISETMENU 0x0230")]
    public const int WM_MDISETMENU = 0x0230;

    [NativeTypeName("#define WM_ENTERSIZEMOVE 0x0231")]
    public const int WM_ENTERSIZEMOVE = 0x0231;

    [NativeTypeName("#define WM_EXITSIZEMOVE 0x0232")]
    public const int WM_EXITSIZEMOVE = 0x0232;

    [NativeTypeName("#define WM_DROPFILES 0x0233")]
    public const int WM_DROPFILES = 0x0233;

    [NativeTypeName("#define WM_MDIREFRESHMENU 0x0234")]
    public const int WM_MDIREFRESHMENU = 0x0234;

    [NativeTypeName("#define WM_POINTERDEVICECHANGE 0x238")]
    public const int WM_POINTERDEVICECHANGE = 0x238;

    [NativeTypeName("#define WM_POINTERDEVICEINRANGE 0x239")]
    public const int WM_POINTERDEVICEINRANGE = 0x239;

    [NativeTypeName("#define WM_POINTERDEVICEOUTOFRANGE 0x23A")]
    public const int WM_POINTERDEVICEOUTOFRANGE = 0x23A;

    [NativeTypeName("#define WM_TOUCH 0x0240")]
    public const int WM_TOUCH = 0x0240;

    [NativeTypeName("#define WM_NCPOINTERUPDATE 0x0241")]
    public const int WM_NCPOINTERUPDATE = 0x0241;

    [NativeTypeName("#define WM_NCPOINTERDOWN 0x0242")]
    public const int WM_NCPOINTERDOWN = 0x0242;

    [NativeTypeName("#define WM_NCPOINTERUP 0x0243")]
    public const int WM_NCPOINTERUP = 0x0243;

    [NativeTypeName("#define WM_POINTERUPDATE 0x0245")]
    public const int WM_POINTERUPDATE = 0x0245;

    [NativeTypeName("#define WM_POINTERDOWN 0x0246")]
    public const int WM_POINTERDOWN = 0x0246;

    [NativeTypeName("#define WM_POINTERUP 0x0247")]
    public const int WM_POINTERUP = 0x0247;

    [NativeTypeName("#define WM_POINTERENTER 0x0249")]
    public const int WM_POINTERENTER = 0x0249;

    [NativeTypeName("#define WM_POINTERLEAVE 0x024A")]
    public const int WM_POINTERLEAVE = 0x024A;

    [NativeTypeName("#define WM_POINTERACTIVATE 0x024B")]
    public const int WM_POINTERACTIVATE = 0x024B;

    [NativeTypeName("#define WM_POINTERCAPTURECHANGED 0x024C")]
    public const int WM_POINTERCAPTURECHANGED = 0x024C;

    [NativeTypeName("#define WM_TOUCHHITTESTING 0x024D")]
    public const int WM_TOUCHHITTESTING = 0x024D;

    [NativeTypeName("#define WM_POINTERWHEEL 0x024E")]
    public const int WM_POINTERWHEEL = 0x024E;

    [NativeTypeName("#define WM_POINTERHWHEEL 0x024F")]
    public const int WM_POINTERHWHEEL = 0x024F;

    [NativeTypeName("#define WM_POINTERROUTEDTO 0x0251")]
    public const int WM_POINTERROUTEDTO = 0x0251;

    [NativeTypeName("#define WM_POINTERROUTEDAWAY 0x0252")]
    public const int WM_POINTERROUTEDAWAY = 0x0252;

    [NativeTypeName("#define WM_POINTERROUTEDRELEASED 0x0253")]
    public const int WM_POINTERROUTEDRELEASED = 0x0253;

    [NativeTypeName("#define WM_IME_SETCONTEXT 0x0281")]
    public const int WM_IME_SETCONTEXT = 0x0281;

    [NativeTypeName("#define WM_IME_NOTIFY 0x0282")]
    public const int WM_IME_NOTIFY = 0x0282;

    [NativeTypeName("#define WM_IME_CONTROL 0x0283")]
    public const int WM_IME_CONTROL = 0x0283;

    [NativeTypeName("#define WM_IME_COMPOSITIONFULL 0x0284")]
    public const int WM_IME_COMPOSITIONFULL = 0x0284;

    [NativeTypeName("#define WM_IME_SELECT 0x0285")]
    public const int WM_IME_SELECT = 0x0285;

    [NativeTypeName("#define WM_IME_CHAR 0x0286")]
    public const int WM_IME_CHAR = 0x0286;

    [NativeTypeName("#define WM_IME_REQUEST 0x0288")]
    public const int WM_IME_REQUEST = 0x0288;

    [NativeTypeName("#define WM_IME_KEYDOWN 0x0290")]
    public const int WM_IME_KEYDOWN = 0x0290;

    [NativeTypeName("#define WM_IME_KEYUP 0x0291")]
    public const int WM_IME_KEYUP = 0x0291;

    [NativeTypeName("#define WM_MOUSEHOVER 0x02A1")]
    public const int WM_MOUSEHOVER = 0x02A1;

    [NativeTypeName("#define WM_MOUSELEAVE 0x02A3")]
    public const int WM_MOUSELEAVE = 0x02A3;

    [NativeTypeName("#define WM_NCMOUSEHOVER 0x02A0")]
    public const int WM_NCMOUSEHOVER = 0x02A0;

    [NativeTypeName("#define WM_NCMOUSELEAVE 0x02A2")]
    public const int WM_NCMOUSELEAVE = 0x02A2;

    [NativeTypeName("#define WM_WTSSESSION_CHANGE 0x02B1")]
    public const int WM_WTSSESSION_CHANGE = 0x02B1;

    [NativeTypeName("#define WM_TABLET_FIRST 0x02c0")]
    public const int WM_TABLET_FIRST = 0x02c0;

    [NativeTypeName("#define WM_TABLET_LAST 0x02df")]
    public const int WM_TABLET_LAST = 0x02df;

    [NativeTypeName("#define WM_DPICHANGED 0x02E0")]
    public const int WM_DPICHANGED = 0x02E0;

    [NativeTypeName("#define WM_DPICHANGED_BEFOREPARENT 0x02E2")]
    public const int WM_DPICHANGED_BEFOREPARENT = 0x02E2;

    [NativeTypeName("#define WM_DPICHANGED_AFTERPARENT 0x02E3")]
    public const int WM_DPICHANGED_AFTERPARENT = 0x02E3;

    [NativeTypeName("#define WM_GETDPISCALEDSIZE 0x02E4")]
    public const int WM_GETDPISCALEDSIZE = 0x02E4;

    [NativeTypeName("#define WM_CUT 0x0300")]
    public const int WM_CUT = 0x0300;

    [NativeTypeName("#define WM_COPY 0x0301")]
    public const int WM_COPY = 0x0301;

    [NativeTypeName("#define WM_PASTE 0x0302")]
    public const int WM_PASTE = 0x0302;

    [NativeTypeName("#define WM_CLEAR 0x0303")]
    public const int WM_CLEAR = 0x0303;

    [NativeTypeName("#define WM_UNDO 0x0304")]
    public const int WM_UNDO = 0x0304;

    [NativeTypeName("#define WM_RENDERFORMAT 0x0305")]
    public const int WM_RENDERFORMAT = 0x0305;

    [NativeTypeName("#define WM_RENDERALLFORMATS 0x0306")]
    public const int WM_RENDERALLFORMATS = 0x0306;

    [NativeTypeName("#define WM_DESTROYCLIPBOARD 0x0307")]
    public const int WM_DESTROYCLIPBOARD = 0x0307;

    [NativeTypeName("#define WM_DRAWCLIPBOARD 0x0308")]
    public const int WM_DRAWCLIPBOARD = 0x0308;

    [NativeTypeName("#define WM_PAINTCLIPBOARD 0x0309")]
    public const int WM_PAINTCLIPBOARD = 0x0309;

    [NativeTypeName("#define WM_VSCROLLCLIPBOARD 0x030A")]
    public const int WM_VSCROLLCLIPBOARD = 0x030A;

    [NativeTypeName("#define WM_SIZECLIPBOARD 0x030B")]
    public const int WM_SIZECLIPBOARD = 0x030B;

    [NativeTypeName("#define WM_ASKCBFORMATNAME 0x030C")]
    public const int WM_ASKCBFORMATNAME = 0x030C;

    [NativeTypeName("#define WM_CHANGECBCHAIN 0x030D")]
    public const int WM_CHANGECBCHAIN = 0x030D;

    [NativeTypeName("#define WM_HSCROLLCLIPBOARD 0x030E")]
    public const int WM_HSCROLLCLIPBOARD = 0x030E;

    [NativeTypeName("#define WM_QUERYNEWPALETTE 0x030F")]
    public const int WM_QUERYNEWPALETTE = 0x030F;

    [NativeTypeName("#define WM_PALETTEISCHANGING 0x0310")]
    public const int WM_PALETTEISCHANGING = 0x0310;

    [NativeTypeName("#define WM_PALETTECHANGED 0x0311")]
    public const int WM_PALETTECHANGED = 0x0311;

    [NativeTypeName("#define WM_HOTKEY 0x0312")]
    public const int WM_HOTKEY = 0x0312;

    [NativeTypeName("#define WM_PRINT 0x0317")]
    public const int WM_PRINT = 0x0317;

    [NativeTypeName("#define WM_PRINTCLIENT 0x0318")]
    public const int WM_PRINTCLIENT = 0x0318;

    [NativeTypeName("#define WM_APPCOMMAND 0x0319")]
    public const int WM_APPCOMMAND = 0x0319;

    [NativeTypeName("#define WM_THEMECHANGED 0x031A")]
    public const int WM_THEMECHANGED = 0x031A;

    [NativeTypeName("#define WM_CLIPBOARDUPDATE 0x031D")]
    public const int WM_CLIPBOARDUPDATE = 0x031D;

    [NativeTypeName("#define WM_DWMCOMPOSITIONCHANGED 0x031E")]
    public const int WM_DWMCOMPOSITIONCHANGED = 0x031E;

    [NativeTypeName("#define WM_DWMNCRENDERINGCHANGED 0x031F")]
    public const int WM_DWMNCRENDERINGCHANGED = 0x031F;

    [NativeTypeName("#define WM_DWMCOLORIZATIONCOLORCHANGED 0x0320")]
    public const int WM_DWMCOLORIZATIONCOLORCHANGED = 0x0320;

    [NativeTypeName("#define WM_DWMWINDOWMAXIMIZEDCHANGE 0x0321")]
    public const int WM_DWMWINDOWMAXIMIZEDCHANGE = 0x0321;

    [NativeTypeName("#define WM_DWMSENDICONICTHUMBNAIL 0x0323")]
    public const int WM_DWMSENDICONICTHUMBNAIL = 0x0323;

    [NativeTypeName("#define WM_DWMSENDICONICLIVEPREVIEWBITMAP 0x0326")]
    public const int WM_DWMSENDICONICLIVEPREVIEWBITMAP = 0x0326;

    [NativeTypeName("#define WM_GETTITLEBARINFOEX 0x033F")]
    public const int WM_GETTITLEBARINFOEX = 0x033F;

    [NativeTypeName("#define WM_HANDHELDFIRST 0x0358")]
    public const int WM_HANDHELDFIRST = 0x0358;

    [NativeTypeName("#define WM_HANDHELDLAST 0x035F")]
    public const int WM_HANDHELDLAST = 0x035F;

    [NativeTypeName("#define WM_AFXFIRST 0x0360")]
    public const int WM_AFXFIRST = 0x0360;

    [NativeTypeName("#define WM_AFXLAST 0x037F")]
    public const int WM_AFXLAST = 0x037F;

    [NativeTypeName("#define WM_PENWINFIRST 0x0380")]
    public const int WM_PENWINFIRST = 0x0380;

    [NativeTypeName("#define WM_PENWINLAST 0x038F")]
    public const int WM_PENWINLAST = 0x038F;

    [NativeTypeName("#define WM_APP 0x8000")]
    public const int WM_APP = 0x8000;

    [NativeTypeName("#define WM_USER 0x0400")]
    public const int WM_USER = 0x0400;

    [NativeTypeName("#define WM_TOOLTIPDISMISS 0x0345")]
    public const int WM_TOOLTIPDISMISS = 0x0345;
}
