// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class TMT
{
    [NativeTypeName("#define TMT_RESERVEDLOW 0")]
    public const int TMT_RESERVEDLOW = 0;
    [NativeTypeName("#define TMT_RESERVEDHIGH 7999")]
    public const int TMT_RESERVEDHIGH = 7999;
    [NativeTypeName("#define TMT_DIBDATA 2")]
    public const int TMT_DIBDATA = 2;
    [NativeTypeName("#define TMT_GLYPHDIBDATA 8")]
    public const int TMT_GLYPHDIBDATA = 8;
    [NativeTypeName("#define TMT_ENUM 200")]
    public const int TMT_ENUM = 200;
    [NativeTypeName("#define TMT_STRING 201")]
    public const int TMT_STRING = 201;
    [NativeTypeName("#define TMT_INT 202")]
    public const int TMT_INT = 202;
    [NativeTypeName("#define TMT_BOOL 203")]
    public const int TMT_BOOL = 203;
    [NativeTypeName("#define TMT_COLOR 204")]
    public const int TMT_COLOR = 204;
    [NativeTypeName("#define TMT_MARGINS 205")]
    public const int TMT_MARGINS = 205;
    [NativeTypeName("#define TMT_FILENAME 206")]
    public const int TMT_FILENAME = 206;
    [NativeTypeName("#define TMT_SIZE 207")]
    public const int TMT_SIZE = 207;
    [NativeTypeName("#define TMT_POSITION 208")]
    public const int TMT_POSITION = 208;
    [NativeTypeName("#define TMT_RECT 209")]
    public const int TMT_RECT = 209;
    [NativeTypeName("#define TMT_FONT 210")]
    public const int TMT_FONT = 210;
    [NativeTypeName("#define TMT_INTLIST 211")]
    public const int TMT_INTLIST = 211;
    [NativeTypeName("#define TMT_HBITMAP 212")]
    public const int TMT_HBITMAP = 212;
    [NativeTypeName("#define TMT_DISKSTREAM 213")]
    public const int TMT_DISKSTREAM = 213;
    [NativeTypeName("#define TMT_STREAM 214")]
    public const int TMT_STREAM = 214;
    [NativeTypeName("#define TMT_BITMAPREF 215")]
    public const int TMT_BITMAPREF = 215;
    [NativeTypeName("#define TMT_FLOAT 216")]
    public const int TMT_FLOAT = 216;
    [NativeTypeName("#define TMT_FLOATLIST 217")]
    public const int TMT_FLOATLIST = 217;
    [NativeTypeName("#define TMT_COLORSCHEMES 401")]
    public const int TMT_COLORSCHEMES = 401;
    [NativeTypeName("#define TMT_SIZES 402")]
    public const int TMT_SIZES = 402;
    [NativeTypeName("#define TMT_CHARSET 403")]
    public const int TMT_CHARSET = 403;
    [NativeTypeName("#define TMT_NAME 600")]
    public const int TMT_NAME = 600;
    [NativeTypeName("#define TMT_DISPLAYNAME 601")]
    public const int TMT_DISPLAYNAME = 601;
    [NativeTypeName("#define TMT_TOOLTIP 602")]
    public const int TMT_TOOLTIP = 602;
    [NativeTypeName("#define TMT_COMPANY 603")]
    public const int TMT_COMPANY = 603;
    [NativeTypeName("#define TMT_AUTHOR 604")]
    public const int TMT_AUTHOR = 604;
    [NativeTypeName("#define TMT_COPYRIGHT 605")]
    public const int TMT_COPYRIGHT = 605;
    [NativeTypeName("#define TMT_URL 606")]
    public const int TMT_URL = 606;
    [NativeTypeName("#define TMT_VERSION 607")]
    public const int TMT_VERSION = 607;
    [NativeTypeName("#define TMT_DESCRIPTION 608")]
    public const int TMT_DESCRIPTION = 608;
    [NativeTypeName("#define TMT_FIRST_RCSTRING_NAME TMT_DISPLAYNAME")]
    public const int TMT_FIRST_RCSTRING_NAME = 601;
    [NativeTypeName("#define TMT_LAST_RCSTRING_NAME TMT_DESCRIPTION")]
    public const int TMT_LAST_RCSTRING_NAME = 608;
    [NativeTypeName("#define TMT_CAPTIONFONT 801")]
    public const int TMT_CAPTIONFONT = 801;
    [NativeTypeName("#define TMT_SMALLCAPTIONFONT 802")]
    public const int TMT_SMALLCAPTIONFONT = 802;
    [NativeTypeName("#define TMT_MENUFONT 803")]
    public const int TMT_MENUFONT = 803;
    [NativeTypeName("#define TMT_STATUSFONT 804")]
    public const int TMT_STATUSFONT = 804;
    [NativeTypeName("#define TMT_MSGBOXFONT 805")]
    public const int TMT_MSGBOXFONT = 805;
    [NativeTypeName("#define TMT_ICONTITLEFONT 806")]
    public const int TMT_ICONTITLEFONT = 806;
    [NativeTypeName("#define TMT_HEADING1FONT 807")]
    public const int TMT_HEADING1FONT = 807;
    [NativeTypeName("#define TMT_HEADING2FONT 808")]
    public const int TMT_HEADING2FONT = 808;
    [NativeTypeName("#define TMT_BODYFONT 809")]
    public const int TMT_BODYFONT = 809;
    [NativeTypeName("#define TMT_FIRSTFONT TMT_CAPTIONFONT")]
    public const int TMT_FIRSTFONT = 801;
    [NativeTypeName("#define TMT_LASTFONT TMT_BODYFONT")]
    public const int TMT_LASTFONT = 809;
    [NativeTypeName("#define TMT_FLATMENUS 1001")]
    public const int TMT_FLATMENUS = 1001;
    [NativeTypeName("#define TMT_FIRSTBOOL TMT_FLATMENUS")]
    public const int TMT_FIRSTBOOL = 1001;
    [NativeTypeName("#define TMT_LASTBOOL TMT_FLATMENUS")]
    public const int TMT_LASTBOOL = 1001;
    [NativeTypeName("#define TMT_SIZINGBORDERWIDTH 1201")]
    public const int TMT_SIZINGBORDERWIDTH = 1201;
    [NativeTypeName("#define TMT_SCROLLBARWIDTH 1202")]
    public const int TMT_SCROLLBARWIDTH = 1202;
    [NativeTypeName("#define TMT_SCROLLBARHEIGHT 1203")]
    public const int TMT_SCROLLBARHEIGHT = 1203;
    [NativeTypeName("#define TMT_CAPTIONBARWIDTH 1204")]
    public const int TMT_CAPTIONBARWIDTH = 1204;
    [NativeTypeName("#define TMT_CAPTIONBARHEIGHT 1205")]
    public const int TMT_CAPTIONBARHEIGHT = 1205;
    [NativeTypeName("#define TMT_SMCAPTIONBARWIDTH 1206")]
    public const int TMT_SMCAPTIONBARWIDTH = 1206;
    [NativeTypeName("#define TMT_SMCAPTIONBARHEIGHT 1207")]
    public const int TMT_SMCAPTIONBARHEIGHT = 1207;
    [NativeTypeName("#define TMT_MENUBARWIDTH 1208")]
    public const int TMT_MENUBARWIDTH = 1208;
    [NativeTypeName("#define TMT_MENUBARHEIGHT 1209")]
    public const int TMT_MENUBARHEIGHT = 1209;
    [NativeTypeName("#define TMT_PADDEDBORDERWIDTH 1210")]
    public const int TMT_PADDEDBORDERWIDTH = 1210;
    [NativeTypeName("#define TMT_FIRSTSIZE TMT_SIZINGBORDERWIDTH")]
    public const int TMT_FIRSTSIZE = 1201;
    [NativeTypeName("#define TMT_LASTSIZE TMT_PADDEDBORDERWIDTH")]
    public const int TMT_LASTSIZE = 1210;
    [NativeTypeName("#define TMT_MINCOLORDEPTH 1301")]
    public const int TMT_MINCOLORDEPTH = 1301;
    [NativeTypeName("#define TMT_FIRSTINT TMT_MINCOLORDEPTH")]
    public const int TMT_FIRSTINT = 1301;
    [NativeTypeName("#define TMT_LASTINT TMT_MINCOLORDEPTH")]
    public const int TMT_LASTINT = 1301;
    [NativeTypeName("#define TMT_CSSNAME 1401")]
    public const int TMT_CSSNAME = 1401;
    [NativeTypeName("#define TMT_XMLNAME 1402")]
    public const int TMT_XMLNAME = 1402;
    [NativeTypeName("#define TMT_LASTUPDATED 1403")]
    public const int TMT_LASTUPDATED = 1403;
    [NativeTypeName("#define TMT_ALIAS 1404")]
    public const int TMT_ALIAS = 1404;
    [NativeTypeName("#define TMT_FIRSTSTRING TMT_CSSNAME")]
    public const int TMT_FIRSTSTRING = 1401;
    [NativeTypeName("#define TMT_LASTSTRING TMT_ALIAS")]
    public const int TMT_LASTSTRING = 1404;
    [NativeTypeName("#define TMT_SCROLLBAR 1601")]
    public const int TMT_SCROLLBAR = 1601;
    [NativeTypeName("#define TMT_BACKGROUND 1602")]
    public const int TMT_BACKGROUND = 1602;
    [NativeTypeName("#define TMT_ACTIVECAPTION 1603")]
    public const int TMT_ACTIVECAPTION = 1603;
    [NativeTypeName("#define TMT_INACTIVECAPTION 1604")]
    public const int TMT_INACTIVECAPTION = 1604;
    [NativeTypeName("#define TMT_MENU 1605")]
    public const int TMT_MENU = 1605;
    [NativeTypeName("#define TMT_WINDOW 1606")]
    public const int TMT_WINDOW = 1606;
    [NativeTypeName("#define TMT_WINDOWFRAME 1607")]
    public const int TMT_WINDOWFRAME = 1607;
    [NativeTypeName("#define TMT_MENUTEXT 1608")]
    public const int TMT_MENUTEXT = 1608;
    [NativeTypeName("#define TMT_WINDOWTEXT 1609")]
    public const int TMT_WINDOWTEXT = 1609;
    [NativeTypeName("#define TMT_CAPTIONTEXT 1610")]
    public const int TMT_CAPTIONTEXT = 1610;
    [NativeTypeName("#define TMT_ACTIVEBORDER 1611")]
    public const int TMT_ACTIVEBORDER = 1611;
    [NativeTypeName("#define TMT_INACTIVEBORDER 1612")]
    public const int TMT_INACTIVEBORDER = 1612;
    [NativeTypeName("#define TMT_APPWORKSPACE 1613")]
    public const int TMT_APPWORKSPACE = 1613;
    [NativeTypeName("#define TMT_HIGHLIGHT 1614")]
    public const int TMT_HIGHLIGHT = 1614;
    [NativeTypeName("#define TMT_HIGHLIGHTTEXT 1615")]
    public const int TMT_HIGHLIGHTTEXT = 1615;
    [NativeTypeName("#define TMT_BTNFACE 1616")]
    public const int TMT_BTNFACE = 1616;
    [NativeTypeName("#define TMT_BTNSHADOW 1617")]
    public const int TMT_BTNSHADOW = 1617;
    [NativeTypeName("#define TMT_GRAYTEXT 1618")]
    public const int TMT_GRAYTEXT = 1618;
    [NativeTypeName("#define TMT_BTNTEXT 1619")]
    public const int TMT_BTNTEXT = 1619;
    [NativeTypeName("#define TMT_INACTIVECAPTIONTEXT 1620")]
    public const int TMT_INACTIVECAPTIONTEXT = 1620;
    [NativeTypeName("#define TMT_BTNHIGHLIGHT 1621")]
    public const int TMT_BTNHIGHLIGHT = 1621;
    [NativeTypeName("#define TMT_DKSHADOW3D 1622")]
    public const int TMT_DKSHADOW3D = 1622;
    [NativeTypeName("#define TMT_LIGHT3D 1623")]
    public const int TMT_LIGHT3D = 1623;
    [NativeTypeName("#define TMT_INFOTEXT 1624")]
    public const int TMT_INFOTEXT = 1624;
    [NativeTypeName("#define TMT_INFOBK 1625")]
    public const int TMT_INFOBK = 1625;
    [NativeTypeName("#define TMT_BUTTONALTERNATEFACE 1626")]
    public const int TMT_BUTTONALTERNATEFACE = 1626;
    [NativeTypeName("#define TMT_HOTTRACKING 1627")]
    public const int TMT_HOTTRACKING = 1627;
    [NativeTypeName("#define TMT_GRADIENTACTIVECAPTION 1628")]
    public const int TMT_GRADIENTACTIVECAPTION = 1628;
    [NativeTypeName("#define TMT_GRADIENTINACTIVECAPTION 1629")]
    public const int TMT_GRADIENTINACTIVECAPTION = 1629;
    [NativeTypeName("#define TMT_MENUHILIGHT 1630")]
    public const int TMT_MENUHILIGHT = 1630;
    [NativeTypeName("#define TMT_MENUBAR 1631")]
    public const int TMT_MENUBAR = 1631;
    [NativeTypeName("#define TMT_FIRSTCOLOR TMT_SCROLLBAR")]
    public const int TMT_FIRSTCOLOR = 1601;
    [NativeTypeName("#define TMT_LASTCOLOR TMT_MENUBAR")]
    public const int TMT_LASTCOLOR = 1631;
    [NativeTypeName("#define TMT_FROMHUE1 1801")]
    public const int TMT_FROMHUE1 = 1801;
    [NativeTypeName("#define TMT_FROMHUE2 1802")]
    public const int TMT_FROMHUE2 = 1802;
    [NativeTypeName("#define TMT_FROMHUE3 1803")]
    public const int TMT_FROMHUE3 = 1803;
    [NativeTypeName("#define TMT_FROMHUE4 1804")]
    public const int TMT_FROMHUE4 = 1804;
    [NativeTypeName("#define TMT_FROMHUE5 1805")]
    public const int TMT_FROMHUE5 = 1805;
    [NativeTypeName("#define TMT_TOHUE1 1806")]
    public const int TMT_TOHUE1 = 1806;
    [NativeTypeName("#define TMT_TOHUE2 1807")]
    public const int TMT_TOHUE2 = 1807;
    [NativeTypeName("#define TMT_TOHUE3 1808")]
    public const int TMT_TOHUE3 = 1808;
    [NativeTypeName("#define TMT_TOHUE4 1809")]
    public const int TMT_TOHUE4 = 1809;
    [NativeTypeName("#define TMT_TOHUE5 1810")]
    public const int TMT_TOHUE5 = 1810;
    [NativeTypeName("#define TMT_FROMCOLOR1 2001")]
    public const int TMT_FROMCOLOR1 = 2001;
    [NativeTypeName("#define TMT_FROMCOLOR2 2002")]
    public const int TMT_FROMCOLOR2 = 2002;
    [NativeTypeName("#define TMT_FROMCOLOR3 2003")]
    public const int TMT_FROMCOLOR3 = 2003;
    [NativeTypeName("#define TMT_FROMCOLOR4 2004")]
    public const int TMT_FROMCOLOR4 = 2004;
    [NativeTypeName("#define TMT_FROMCOLOR5 2005")]
    public const int TMT_FROMCOLOR5 = 2005;
    [NativeTypeName("#define TMT_TOCOLOR1 2006")]
    public const int TMT_TOCOLOR1 = 2006;
    [NativeTypeName("#define TMT_TOCOLOR2 2007")]
    public const int TMT_TOCOLOR2 = 2007;
    [NativeTypeName("#define TMT_TOCOLOR3 2008")]
    public const int TMT_TOCOLOR3 = 2008;
    [NativeTypeName("#define TMT_TOCOLOR4 2009")]
    public const int TMT_TOCOLOR4 = 2009;
    [NativeTypeName("#define TMT_TOCOLOR5 2010")]
    public const int TMT_TOCOLOR5 = 2010;
    [NativeTypeName("#define TMT_TRANSPARENT 2201")]
    public const int TMT_TRANSPARENT = 2201;
    [NativeTypeName("#define TMT_AUTOSIZE 2202")]
    public const int TMT_AUTOSIZE = 2202;
    [NativeTypeName("#define TMT_BORDERONLY 2203")]
    public const int TMT_BORDERONLY = 2203;
    [NativeTypeName("#define TMT_COMPOSITED 2204")]
    public const int TMT_COMPOSITED = 2204;
    [NativeTypeName("#define TMT_BGFILL 2205")]
    public const int TMT_BGFILL = 2205;
    [NativeTypeName("#define TMT_GLYPHTRANSPARENT 2206")]
    public const int TMT_GLYPHTRANSPARENT = 2206;
    [NativeTypeName("#define TMT_GLYPHONLY 2207")]
    public const int TMT_GLYPHONLY = 2207;
    [NativeTypeName("#define TMT_ALWAYSSHOWSIZINGBAR 2208")]
    public const int TMT_ALWAYSSHOWSIZINGBAR = 2208;
    [NativeTypeName("#define TMT_MIRRORIMAGE 2209")]
    public const int TMT_MIRRORIMAGE = 2209;
    [NativeTypeName("#define TMT_UNIFORMSIZING 2210")]
    public const int TMT_UNIFORMSIZING = 2210;
    [NativeTypeName("#define TMT_INTEGRALSIZING 2211")]
    public const int TMT_INTEGRALSIZING = 2211;
    [NativeTypeName("#define TMT_SOURCEGROW 2212")]
    public const int TMT_SOURCEGROW = 2212;
    [NativeTypeName("#define TMT_SOURCESHRINK 2213")]
    public const int TMT_SOURCESHRINK = 2213;
    [NativeTypeName("#define TMT_DRAWBORDERS 2214")]
    public const int TMT_DRAWBORDERS = 2214;
    [NativeTypeName("#define TMT_NOETCHEDEFFECT 2215")]
    public const int TMT_NOETCHEDEFFECT = 2215;
    [NativeTypeName("#define TMT_TEXTAPPLYOVERLAY 2216")]
    public const int TMT_TEXTAPPLYOVERLAY = 2216;
    [NativeTypeName("#define TMT_TEXTGLOW 2217")]
    public const int TMT_TEXTGLOW = 2217;
    [NativeTypeName("#define TMT_TEXTITALIC 2218")]
    public const int TMT_TEXTITALIC = 2218;
    [NativeTypeName("#define TMT_COMPOSITEDOPAQUE 2219")]
    public const int TMT_COMPOSITEDOPAQUE = 2219;
    [NativeTypeName("#define TMT_LOCALIZEDMIRRORIMAGE 2220")]
    public const int TMT_LOCALIZEDMIRRORIMAGE = 2220;
    [NativeTypeName("#define TMT_IMAGECOUNT 2401")]
    public const int TMT_IMAGECOUNT = 2401;
    [NativeTypeName("#define TMT_ALPHALEVEL 2402")]
    public const int TMT_ALPHALEVEL = 2402;
    [NativeTypeName("#define TMT_BORDERSIZE 2403")]
    public const int TMT_BORDERSIZE = 2403;
    [NativeTypeName("#define TMT_ROUNDCORNERWIDTH 2404")]
    public const int TMT_ROUNDCORNERWIDTH = 2404;
    [NativeTypeName("#define TMT_ROUNDCORNERHEIGHT 2405")]
    public const int TMT_ROUNDCORNERHEIGHT = 2405;
    [NativeTypeName("#define TMT_GRADIENTRATIO1 2406")]
    public const int TMT_GRADIENTRATIO1 = 2406;
    [NativeTypeName("#define TMT_GRADIENTRATIO2 2407")]
    public const int TMT_GRADIENTRATIO2 = 2407;
    [NativeTypeName("#define TMT_GRADIENTRATIO3 2408")]
    public const int TMT_GRADIENTRATIO3 = 2408;
    [NativeTypeName("#define TMT_GRADIENTRATIO4 2409")]
    public const int TMT_GRADIENTRATIO4 = 2409;
    [NativeTypeName("#define TMT_GRADIENTRATIO5 2410")]
    public const int TMT_GRADIENTRATIO5 = 2410;
    [NativeTypeName("#define TMT_PROGRESSCHUNKSIZE 2411")]
    public const int TMT_PROGRESSCHUNKSIZE = 2411;
    [NativeTypeName("#define TMT_PROGRESSSPACESIZE 2412")]
    public const int TMT_PROGRESSSPACESIZE = 2412;
    [NativeTypeName("#define TMT_SATURATION 2413")]
    public const int TMT_SATURATION = 2413;
    [NativeTypeName("#define TMT_TEXTBORDERSIZE 2414")]
    public const int TMT_TEXTBORDERSIZE = 2414;
    [NativeTypeName("#define TMT_ALPHATHRESHOLD 2415")]
    public const int TMT_ALPHATHRESHOLD = 2415;
    [NativeTypeName("#define TMT_WIDTH 2416")]
    public const int TMT_WIDTH = 2416;
    [NativeTypeName("#define TMT_HEIGHT 2417")]
    public const int TMT_HEIGHT = 2417;
    [NativeTypeName("#define TMT_GLYPHINDEX 2418")]
    public const int TMT_GLYPHINDEX = 2418;
    [NativeTypeName("#define TMT_TRUESIZESTRETCHMARK 2419")]
    public const int TMT_TRUESIZESTRETCHMARK = 2419;
    [NativeTypeName("#define TMT_MINDPI1 2420")]
    public const int TMT_MINDPI1 = 2420;
    [NativeTypeName("#define TMT_MINDPI2 2421")]
    public const int TMT_MINDPI2 = 2421;
    [NativeTypeName("#define TMT_MINDPI3 2422")]
    public const int TMT_MINDPI3 = 2422;
    [NativeTypeName("#define TMT_MINDPI4 2423")]
    public const int TMT_MINDPI4 = 2423;
    [NativeTypeName("#define TMT_MINDPI5 2424")]
    public const int TMT_MINDPI5 = 2424;
    [NativeTypeName("#define TMT_TEXTGLOWSIZE 2425")]
    public const int TMT_TEXTGLOWSIZE = 2425;
    [NativeTypeName("#define TMT_FRAMESPERSECOND 2426")]
    public const int TMT_FRAMESPERSECOND = 2426;
    [NativeTypeName("#define TMT_PIXELSPERFRAME 2427")]
    public const int TMT_PIXELSPERFRAME = 2427;
    [NativeTypeName("#define TMT_ANIMATIONDELAY 2428")]
    public const int TMT_ANIMATIONDELAY = 2428;
    [NativeTypeName("#define TMT_GLOWINTENSITY 2429")]
    public const int TMT_GLOWINTENSITY = 2429;
    [NativeTypeName("#define TMT_OPACITY 2430")]
    public const int TMT_OPACITY = 2430;
    [NativeTypeName("#define TMT_COLORIZATIONCOLOR 2431")]
    public const int TMT_COLORIZATIONCOLOR = 2431;
    [NativeTypeName("#define TMT_COLORIZATIONOPACITY 2432")]
    public const int TMT_COLORIZATIONOPACITY = 2432;
    [NativeTypeName("#define TMT_MINDPI6 2433")]
    public const int TMT_MINDPI6 = 2433;
    [NativeTypeName("#define TMT_MINDPI7 2434")]
    public const int TMT_MINDPI7 = 2434;
    [NativeTypeName("#define TMT_GLYPHFONT 2601")]
    public const int TMT_GLYPHFONT = 2601;
    [NativeTypeName("#define TMT_IMAGEFILE 3001")]
    public const int TMT_IMAGEFILE = 3001;
    [NativeTypeName("#define TMT_IMAGEFILE1 3002")]
    public const int TMT_IMAGEFILE1 = 3002;
    [NativeTypeName("#define TMT_IMAGEFILE2 3003")]
    public const int TMT_IMAGEFILE2 = 3003;
    [NativeTypeName("#define TMT_IMAGEFILE3 3004")]
    public const int TMT_IMAGEFILE3 = 3004;
    [NativeTypeName("#define TMT_IMAGEFILE4 3005")]
    public const int TMT_IMAGEFILE4 = 3005;
    [NativeTypeName("#define TMT_IMAGEFILE5 3006")]
    public const int TMT_IMAGEFILE5 = 3006;
    [NativeTypeName("#define TMT_GLYPHIMAGEFILE 3008")]
    public const int TMT_GLYPHIMAGEFILE = 3008;
    [NativeTypeName("#define TMT_IMAGEFILE6 3009")]
    public const int TMT_IMAGEFILE6 = 3009;
    [NativeTypeName("#define TMT_IMAGEFILE7 3010")]
    public const int TMT_IMAGEFILE7 = 3010;
    [NativeTypeName("#define TMT_TEXT 3201")]
    public const int TMT_TEXT = 3201;
    [NativeTypeName("#define TMT_CLASSICVALUE 3202")]
    public const int TMT_CLASSICVALUE = 3202;
    [NativeTypeName("#define TMT_OFFSET 3401")]
    public const int TMT_OFFSET = 3401;
    [NativeTypeName("#define TMT_TEXTSHADOWOFFSET 3402")]
    public const int TMT_TEXTSHADOWOFFSET = 3402;
    [NativeTypeName("#define TMT_MINSIZE 3403")]
    public const int TMT_MINSIZE = 3403;
    [NativeTypeName("#define TMT_MINSIZE1 3404")]
    public const int TMT_MINSIZE1 = 3404;
    [NativeTypeName("#define TMT_MINSIZE2 3405")]
    public const int TMT_MINSIZE2 = 3405;
    [NativeTypeName("#define TMT_MINSIZE3 3406")]
    public const int TMT_MINSIZE3 = 3406;
    [NativeTypeName("#define TMT_MINSIZE4 3407")]
    public const int TMT_MINSIZE4 = 3407;
    [NativeTypeName("#define TMT_MINSIZE5 3408")]
    public const int TMT_MINSIZE5 = 3408;
    [NativeTypeName("#define TMT_NORMALSIZE 3409")]
    public const int TMT_NORMALSIZE = 3409;
    [NativeTypeName("#define TMT_MINSIZE6 3410")]
    public const int TMT_MINSIZE6 = 3410;
    [NativeTypeName("#define TMT_MINSIZE7 3411")]
    public const int TMT_MINSIZE7 = 3411;
    [NativeTypeName("#define TMT_SIZINGMARGINS 3601")]
    public const int TMT_SIZINGMARGINS = 3601;
    [NativeTypeName("#define TMT_CONTENTMARGINS 3602")]
    public const int TMT_CONTENTMARGINS = 3602;
    [NativeTypeName("#define TMT_CAPTIONMARGINS 3603")]
    public const int TMT_CAPTIONMARGINS = 3603;
    [NativeTypeName("#define TMT_BORDERCOLOR 3801")]
    public const int TMT_BORDERCOLOR = 3801;
    [NativeTypeName("#define TMT_FILLCOLOR 3802")]
    public const int TMT_FILLCOLOR = 3802;
    [NativeTypeName("#define TMT_TEXTCOLOR 3803")]
    public const int TMT_TEXTCOLOR = 3803;
    [NativeTypeName("#define TMT_EDGELIGHTCOLOR 3804")]
    public const int TMT_EDGELIGHTCOLOR = 3804;
    [NativeTypeName("#define TMT_EDGEHIGHLIGHTCOLOR 3805")]
    public const int TMT_EDGEHIGHLIGHTCOLOR = 3805;
    [NativeTypeName("#define TMT_EDGESHADOWCOLOR 3806")]
    public const int TMT_EDGESHADOWCOLOR = 3806;
    [NativeTypeName("#define TMT_EDGEDKSHADOWCOLOR 3807")]
    public const int TMT_EDGEDKSHADOWCOLOR = 3807;
    [NativeTypeName("#define TMT_EDGEFILLCOLOR 3808")]
    public const int TMT_EDGEFILLCOLOR = 3808;
    [NativeTypeName("#define TMT_TRANSPARENTCOLOR 3809")]
    public const int TMT_TRANSPARENTCOLOR = 3809;
    [NativeTypeName("#define TMT_GRADIENTCOLOR1 3810")]
    public const int TMT_GRADIENTCOLOR1 = 3810;
    [NativeTypeName("#define TMT_GRADIENTCOLOR2 3811")]
    public const int TMT_GRADIENTCOLOR2 = 3811;
    [NativeTypeName("#define TMT_GRADIENTCOLOR3 3812")]
    public const int TMT_GRADIENTCOLOR3 = 3812;
    [NativeTypeName("#define TMT_GRADIENTCOLOR4 3813")]
    public const int TMT_GRADIENTCOLOR4 = 3813;
    [NativeTypeName("#define TMT_GRADIENTCOLOR5 3814")]
    public const int TMT_GRADIENTCOLOR5 = 3814;
    [NativeTypeName("#define TMT_SHADOWCOLOR 3815")]
    public const int TMT_SHADOWCOLOR = 3815;
    [NativeTypeName("#define TMT_GLOWCOLOR 3816")]
    public const int TMT_GLOWCOLOR = 3816;
    [NativeTypeName("#define TMT_TEXTBORDERCOLOR 3817")]
    public const int TMT_TEXTBORDERCOLOR = 3817;
    [NativeTypeName("#define TMT_TEXTSHADOWCOLOR 3818")]
    public const int TMT_TEXTSHADOWCOLOR = 3818;
    [NativeTypeName("#define TMT_GLYPHTEXTCOLOR 3819")]
    public const int TMT_GLYPHTEXTCOLOR = 3819;
    [NativeTypeName("#define TMT_GLYPHTRANSPARENTCOLOR 3820")]
    public const int TMT_GLYPHTRANSPARENTCOLOR = 3820;
    [NativeTypeName("#define TMT_FILLCOLORHINT 3821")]
    public const int TMT_FILLCOLORHINT = 3821;
    [NativeTypeName("#define TMT_BORDERCOLORHINT 3822")]
    public const int TMT_BORDERCOLORHINT = 3822;
    [NativeTypeName("#define TMT_ACCENTCOLORHINT 3823")]
    public const int TMT_ACCENTCOLORHINT = 3823;
    [NativeTypeName("#define TMT_TEXTCOLORHINT 3824")]
    public const int TMT_TEXTCOLORHINT = 3824;
    [NativeTypeName("#define TMT_HEADING1TEXTCOLOR 3825")]
    public const int TMT_HEADING1TEXTCOLOR = 3825;
    [NativeTypeName("#define TMT_HEADING2TEXTCOLOR 3826")]
    public const int TMT_HEADING2TEXTCOLOR = 3826;
    [NativeTypeName("#define TMT_BODYTEXTCOLOR 3827")]
    public const int TMT_BODYTEXTCOLOR = 3827;
    [NativeTypeName("#define TMT_BGTYPE 4001")]
    public const int TMT_BGTYPE = 4001;
    [NativeTypeName("#define TMT_BORDERTYPE 4002")]
    public const int TMT_BORDERTYPE = 4002;
    [NativeTypeName("#define TMT_FILLTYPE 4003")]
    public const int TMT_FILLTYPE = 4003;
    [NativeTypeName("#define TMT_SIZINGTYPE 4004")]
    public const int TMT_SIZINGTYPE = 4004;
    [NativeTypeName("#define TMT_HALIGN 4005")]
    public const int TMT_HALIGN = 4005;
    [NativeTypeName("#define TMT_CONTENTALIGNMENT 4006")]
    public const int TMT_CONTENTALIGNMENT = 4006;
    [NativeTypeName("#define TMT_VALIGN 4007")]
    public const int TMT_VALIGN = 4007;
    [NativeTypeName("#define TMT_OFFSETTYPE 4008")]
    public const int TMT_OFFSETTYPE = 4008;
    [NativeTypeName("#define TMT_ICONEFFECT 4009")]
    public const int TMT_ICONEFFECT = 4009;
    [NativeTypeName("#define TMT_TEXTSHADOWTYPE 4010")]
    public const int TMT_TEXTSHADOWTYPE = 4010;
    [NativeTypeName("#define TMT_IMAGELAYOUT 4011")]
    public const int TMT_IMAGELAYOUT = 4011;
    [NativeTypeName("#define TMT_GLYPHTYPE 4012")]
    public const int TMT_GLYPHTYPE = 4012;
    [NativeTypeName("#define TMT_IMAGESELECTTYPE 4013")]
    public const int TMT_IMAGESELECTTYPE = 4013;
    [NativeTypeName("#define TMT_GLYPHFONTSIZINGTYPE 4014")]
    public const int TMT_GLYPHFONTSIZINGTYPE = 4014;
    [NativeTypeName("#define TMT_TRUESIZESCALINGTYPE 4015")]
    public const int TMT_TRUESIZESCALINGTYPE = 4015;
    [NativeTypeName("#define TMT_USERPICTURE 5001")]
    public const int TMT_USERPICTURE = 5001;
    [NativeTypeName("#define TMT_DEFAULTPANESIZE 5002")]
    public const int TMT_DEFAULTPANESIZE = 5002;
    [NativeTypeName("#define TMT_BLENDCOLOR 5003")]
    public const int TMT_BLENDCOLOR = 5003;
    [NativeTypeName("#define TMT_CUSTOMSPLITRECT 5004")]
    public const int TMT_CUSTOMSPLITRECT = 5004;
    [NativeTypeName("#define TMT_ANIMATIONBUTTONRECT 5005")]
    public const int TMT_ANIMATIONBUTTONRECT = 5005;
    [NativeTypeName("#define TMT_ANIMATIONDURATION 5006")]
    public const int TMT_ANIMATIONDURATION = 5006;
    [NativeTypeName("#define TMT_TRANSITIONDURATIONS 6000")]
    public const int TMT_TRANSITIONDURATIONS = 6000;
    [NativeTypeName("#define TMT_SCALEDBACKGROUND 7001")]
    public const int TMT_SCALEDBACKGROUND = 7001;
    [NativeTypeName("#define TMT_ATLASIMAGE 8000")]
    public const int TMT_ATLASIMAGE = 8000;
    [NativeTypeName("#define TMT_ATLASINPUTIMAGE 8001")]
    public const int TMT_ATLASINPUTIMAGE = 8001;
    [NativeTypeName("#define TMT_ATLASRECT 8002")]
    public const int TMT_ATLASRECT = 8002;
}