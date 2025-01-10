// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ExDispid.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DISPID
{
    [NativeTypeName("#define DISPID_BEFORENAVIGATE 100")]
    public const int DISPID_BEFORENAVIGATE = 100;

    [NativeTypeName("#define DISPID_NAVIGATECOMPLETE 101")]
    public const int DISPID_NAVIGATECOMPLETE = 101;

    [NativeTypeName("#define DISPID_STATUSTEXTCHANGE 102")]
    public const int DISPID_STATUSTEXTCHANGE = 102;

    [NativeTypeName("#define DISPID_QUIT 103")]
    public const int DISPID_QUIT = 103;

    [NativeTypeName("#define DISPID_DOWNLOADCOMPLETE 104")]
    public const int DISPID_DOWNLOADCOMPLETE = 104;

    [NativeTypeName("#define DISPID_COMMANDSTATECHANGE 105")]
    public const int DISPID_COMMANDSTATECHANGE = 105;

    [NativeTypeName("#define DISPID_DOWNLOADBEGIN 106")]
    public const int DISPID_DOWNLOADBEGIN = 106;

    [NativeTypeName("#define DISPID_NEWWINDOW 107")]
    public const int DISPID_NEWWINDOW = 107;

    [NativeTypeName("#define DISPID_PROGRESSCHANGE 108")]
    public const int DISPID_PROGRESSCHANGE = 108;

    [NativeTypeName("#define DISPID_WINDOWMOVE 109")]
    public const int DISPID_WINDOWMOVE = 109;

    [NativeTypeName("#define DISPID_WINDOWRESIZE 110")]
    public const int DISPID_WINDOWRESIZE = 110;

    [NativeTypeName("#define DISPID_WINDOWACTIVATE 111")]
    public const int DISPID_WINDOWACTIVATE = 111;

    [NativeTypeName("#define DISPID_PROPERTYCHANGE 112")]
    public const int DISPID_PROPERTYCHANGE = 112;

    [NativeTypeName("#define DISPID_TITLECHANGE 113")]
    public const int DISPID_TITLECHANGE = 113;

    [NativeTypeName("#define DISPID_TITLEICONCHANGE 114")]
    public const int DISPID_TITLEICONCHANGE = 114;

    [NativeTypeName("#define DISPID_FRAMEBEFORENAVIGATE 200")]
    public const int DISPID_FRAMEBEFORENAVIGATE = 200;

    [NativeTypeName("#define DISPID_FRAMENAVIGATECOMPLETE 201")]
    public const int DISPID_FRAMENAVIGATECOMPLETE = 201;

    [NativeTypeName("#define DISPID_FRAMENEWWINDOW 204")]
    public const int DISPID_FRAMENEWWINDOW = 204;

    [NativeTypeName("#define DISPID_BEFORENAVIGATE2 250")]
    public const int DISPID_BEFORENAVIGATE2 = 250;

    [NativeTypeName("#define DISPID_NEWWINDOW2 251")]
    public const int DISPID_NEWWINDOW2 = 251;

    [NativeTypeName("#define DISPID_NAVIGATECOMPLETE2 252")]
    public const int DISPID_NAVIGATECOMPLETE2 = 252;

    [NativeTypeName("#define DISPID_ONQUIT 253")]
    public const int DISPID_ONQUIT = 253;

    [NativeTypeName("#define DISPID_ONVISIBLE 254")]
    public const int DISPID_ONVISIBLE = 254;

    [NativeTypeName("#define DISPID_ONTOOLBAR 255")]
    public const int DISPID_ONTOOLBAR = 255;

    [NativeTypeName("#define DISPID_ONMENUBAR 256")]
    public const int DISPID_ONMENUBAR = 256;

    [NativeTypeName("#define DISPID_ONSTATUSBAR 257")]
    public const int DISPID_ONSTATUSBAR = 257;

    [NativeTypeName("#define DISPID_ONFULLSCREEN 258")]
    public const int DISPID_ONFULLSCREEN = 258;

    [NativeTypeName("#define DISPID_DOCUMENTCOMPLETE 259")]
    public const int DISPID_DOCUMENTCOMPLETE = 259;

    [NativeTypeName("#define DISPID_ONTHEATERMODE 260")]
    public const int DISPID_ONTHEATERMODE = 260;

    [NativeTypeName("#define DISPID_ONADDRESSBAR 261")]
    public const int DISPID_ONADDRESSBAR = 261;

    [NativeTypeName("#define DISPID_WINDOWSETRESIZABLE 262")]
    public const int DISPID_WINDOWSETRESIZABLE = 262;

    [NativeTypeName("#define DISPID_WINDOWCLOSING 263")]
    public const int DISPID_WINDOWCLOSING = 263;

    [NativeTypeName("#define DISPID_WINDOWSETLEFT 264")]
    public const int DISPID_WINDOWSETLEFT = 264;

    [NativeTypeName("#define DISPID_WINDOWSETTOP 265")]
    public const int DISPID_WINDOWSETTOP = 265;

    [NativeTypeName("#define DISPID_WINDOWSETWIDTH 266")]
    public const int DISPID_WINDOWSETWIDTH = 266;

    [NativeTypeName("#define DISPID_WINDOWSETHEIGHT 267")]
    public const int DISPID_WINDOWSETHEIGHT = 267;

    [NativeTypeName("#define DISPID_CLIENTTOHOSTWINDOW 268")]
    public const int DISPID_CLIENTTOHOSTWINDOW = 268;

    [NativeTypeName("#define DISPID_SETSECURELOCKICON 269")]
    public const int DISPID_SETSECURELOCKICON = 269;

    [NativeTypeName("#define DISPID_FILEDOWNLOAD 270")]
    public const int DISPID_FILEDOWNLOAD = 270;

    [NativeTypeName("#define DISPID_NAVIGATEERROR 271")]
    public const int DISPID_NAVIGATEERROR = 271;

    [NativeTypeName("#define DISPID_PRIVACYIMPACTEDSTATECHANGE 272")]
    public const int DISPID_PRIVACYIMPACTEDSTATECHANGE = 272;

    [NativeTypeName("#define DISPID_NEWWINDOW3 273")]
    public const int DISPID_NEWWINDOW3 = 273;

    [NativeTypeName("#define DISPID_VIEWUPDATE 281")]
    public const int DISPID_VIEWUPDATE = 281;

    [NativeTypeName("#define DISPID_SETPHISHINGFILTERSTATUS 282")]
    public const int DISPID_SETPHISHINGFILTERSTATUS = 282;

    [NativeTypeName("#define DISPID_WINDOWSTATECHANGED 283")]
    public const int DISPID_WINDOWSTATECHANGED = 283;

    [NativeTypeName("#define DISPID_NEWPROCESS 284")]
    public const int DISPID_NEWPROCESS = 284;

    [NativeTypeName("#define DISPID_THIRDPARTYURLBLOCKED 285")]
    public const int DISPID_THIRDPARTYURLBLOCKED = 285;

    [NativeTypeName("#define DISPID_REDIRECTXDOMAINBLOCKED 286")]
    public const int DISPID_REDIRECTXDOMAINBLOCKED = 286;

    [NativeTypeName("#define DISPID_WEBWORKERSTARTED 288")]
    public const int DISPID_WEBWORKERSTARTED = 288;

    [NativeTypeName("#define DISPID_WEBWORKERFINISHED 289")]
    public const int DISPID_WEBWORKERFINISHED = 289;

    [NativeTypeName("#define DISPID_BEFORESCRIPTEXECUTE 290")]
    public const int DISPID_BEFORESCRIPTEXECUTE = 290;

    [NativeTypeName("#define DISPID_PRINTTEMPLATEINSTANTIATION 225")]
    public const int DISPID_PRINTTEMPLATEINSTANTIATION = 225;

    [NativeTypeName("#define DISPID_PRINTTEMPLATETEARDOWN 226")]
    public const int DISPID_PRINTTEMPLATETEARDOWN = 226;

    [NativeTypeName("#define DISPID_UPDATEPAGESTATUS 227")]
    public const int DISPID_UPDATEPAGESTATUS = 227;

    [NativeTypeName("#define DISPID_WINDOWREGISTERED 200")]
    public const int DISPID_WINDOWREGISTERED = 200;

    [NativeTypeName("#define DISPID_WINDOWREVOKED 201")]
    public const int DISPID_WINDOWREVOKED = 201;

    [NativeTypeName("#define DISPID_RESETFIRSTBOOTMODE 1")]
    public const int DISPID_RESETFIRSTBOOTMODE = 1;

    [NativeTypeName("#define DISPID_RESETSAFEMODE 2")]
    public const int DISPID_RESETSAFEMODE = 2;

    [NativeTypeName("#define DISPID_REFRESHOFFLINEDESKTOP 3")]
    public const int DISPID_REFRESHOFFLINEDESKTOP = 3;

    [NativeTypeName("#define DISPID_ADDFAVORITE 4")]
    public const int DISPID_ADDFAVORITE = 4;

    [NativeTypeName("#define DISPID_ADDCHANNEL 5")]
    public const int DISPID_ADDCHANNEL = 5;

    [NativeTypeName("#define DISPID_ADDDESKTOPCOMPONENT 6")]
    public const int DISPID_ADDDESKTOPCOMPONENT = 6;

    [NativeTypeName("#define DISPID_ISSUBSCRIBED 7")]
    public const int DISPID_ISSUBSCRIBED = 7;

    [NativeTypeName("#define DISPID_NAVIGATEANDFIND 8")]
    public const int DISPID_NAVIGATEANDFIND = 8;

    [NativeTypeName("#define DISPID_IMPORTEXPORTFAVORITES 9")]
    public const int DISPID_IMPORTEXPORTFAVORITES = 9;

    [NativeTypeName("#define DISPID_AUTOCOMPLETESAVEFORM 10")]
    public const int DISPID_AUTOCOMPLETESAVEFORM = 10;

    [NativeTypeName("#define DISPID_AUTOSCAN 11")]
    public const int DISPID_AUTOSCAN = 11;

    [NativeTypeName("#define DISPID_AUTOCOMPLETEATTACH 12")]
    public const int DISPID_AUTOCOMPLETEATTACH = 12;

    [NativeTypeName("#define DISPID_SHOWBROWSERUI 13")]
    public const int DISPID_SHOWBROWSERUI = 13;

    [NativeTypeName("#define DISPID_ADDSEARCHPROVIDER 14")]
    public const int DISPID_ADDSEARCHPROVIDER = 14;

    [NativeTypeName("#define DISPID_RUNONCESHOWN 15")]
    public const int DISPID_RUNONCESHOWN = 15;

    [NativeTypeName("#define DISPID_SKIPRUNONCE 16")]
    public const int DISPID_SKIPRUNONCE = 16;

    [NativeTypeName("#define DISPID_CUSTOMIZESETTINGS 17")]
    public const int DISPID_CUSTOMIZESETTINGS = 17;

    [NativeTypeName("#define DISPID_SQMENABLED 18")]
    public const int DISPID_SQMENABLED = 18;

    [NativeTypeName("#define DISPID_PHISHINGENABLED 19")]
    public const int DISPID_PHISHINGENABLED = 19;

    [NativeTypeName("#define DISPID_BRANDIMAGEURI 20")]
    public const int DISPID_BRANDIMAGEURI = 20;

    [NativeTypeName("#define DISPID_SKIPTABSWELCOME 21")]
    public const int DISPID_SKIPTABSWELCOME = 21;

    [NativeTypeName("#define DISPID_DIAGNOSECONNECTION 22")]
    public const int DISPID_DIAGNOSECONNECTION = 22;

    [NativeTypeName("#define DISPID_CUSTOMIZECLEARTYPE 23")]
    public const int DISPID_CUSTOMIZECLEARTYPE = 23;

    [NativeTypeName("#define DISPID_ISSEARCHPROVIDERINSTALLED 24")]
    public const int DISPID_ISSEARCHPROVIDERINSTALLED = 24;

    [NativeTypeName("#define DISPID_ISSEARCHMIGRATED 25")]
    public const int DISPID_ISSEARCHMIGRATED = 25;

    [NativeTypeName("#define DISPID_DEFAULTSEARCHPROVIDER 26")]
    public const int DISPID_DEFAULTSEARCHPROVIDER = 26;

    [NativeTypeName("#define DISPID_RUNONCEREQUIREDSETTINGSCOMPLETE 27")]
    public const int DISPID_RUNONCEREQUIREDSETTINGSCOMPLETE = 27;

    [NativeTypeName("#define DISPID_RUNONCEHASSHOWN 28")]
    public const int DISPID_RUNONCEHASSHOWN = 28;

    [NativeTypeName("#define DISPID_SEARCHGUIDEURL 29")]
    public const int DISPID_SEARCHGUIDEURL = 29;

    [NativeTypeName("#define DISPID_ADDSERVICE 30")]
    public const int DISPID_ADDSERVICE = 30;

    [NativeTypeName("#define DISPID_ISSERVICEINSTALLED 31")]
    public const int DISPID_ISSERVICEINSTALLED = 31;

    [NativeTypeName("#define DISPID_ADDTOFAVORITESBAR 32")]
    public const int DISPID_ADDTOFAVORITESBAR = 32;

    [NativeTypeName("#define DISPID_BUILDNEWTABPAGE 33")]
    public const int DISPID_BUILDNEWTABPAGE = 33;

    [NativeTypeName("#define DISPID_SETRECENTLYCLOSEDVISIBLE 34")]
    public const int DISPID_SETRECENTLYCLOSEDVISIBLE = 34;

    [NativeTypeName("#define DISPID_SETACTIVITIESVISIBLE 35")]
    public const int DISPID_SETACTIVITIESVISIBLE = 35;

    [NativeTypeName("#define DISPID_CONTENTDISCOVERYRESET 36")]
    public const int DISPID_CONTENTDISCOVERYRESET = 36;

    [NativeTypeName("#define DISPID_INPRIVATEFILTERINGENABLED 37")]
    public const int DISPID_INPRIVATEFILTERINGENABLED = 37;

    [NativeTypeName("#define DISPID_SUGGESTEDSITESENABLED 38")]
    public const int DISPID_SUGGESTEDSITESENABLED = 38;

    [NativeTypeName("#define DISPID_ENABLESUGGESTEDSITES 39")]
    public const int DISPID_ENABLESUGGESTEDSITES = 39;

    [NativeTypeName("#define DISPID_NAVIGATETOSUGGESTEDSITES 40")]
    public const int DISPID_NAVIGATETOSUGGESTEDSITES = 40;

    [NativeTypeName("#define DISPID_SHOWTABSHELP 41")]
    public const int DISPID_SHOWTABSHELP = 41;

    [NativeTypeName("#define DISPID_SHOWINPRIVATEHELP 42")]
    public const int DISPID_SHOWINPRIVATEHELP = 42;

    [NativeTypeName("#define DISPID_ISSITEMODE 43")]
    public const int DISPID_ISSITEMODE = 43;

    [NativeTypeName("#define DISPID_SETSITEMODEICONOVERLAY 44")]
    public const int DISPID_SETSITEMODEICONOVERLAY = 44;

    [NativeTypeName("#define DISPID_CLEARSITEMODEICONOVERLAY 45")]
    public const int DISPID_CLEARSITEMODEICONOVERLAY = 45;

    [NativeTypeName("#define DISPID_UPDATETHUMBNAILBUTTON 46")]
    public const int DISPID_UPDATETHUMBNAILBUTTON = 46;

    [NativeTypeName("#define DISPID_SETTHUMBNAILBUTTONS 47")]
    public const int DISPID_SETTHUMBNAILBUTTONS = 47;

    [NativeTypeName("#define DISPID_ADDTHUMBNAILBUTTONS 48")]
    public const int DISPID_ADDTHUMBNAILBUTTONS = 48;

    [NativeTypeName("#define DISPID_ADDSITEMODE 49")]
    public const int DISPID_ADDSITEMODE = 49;

    [NativeTypeName("#define DISPID_SETSITEMODEPROPERTIES 50")]
    public const int DISPID_SETSITEMODEPROPERTIES = 50;

    [NativeTypeName("#define DISPID_SITEMODECREATEJUMPLIST 51")]
    public const int DISPID_SITEMODECREATEJUMPLIST = 51;

    [NativeTypeName("#define DISPID_SITEMODEADDJUMPLISTITEM 52")]
    public const int DISPID_SITEMODEADDJUMPLISTITEM = 52;

    [NativeTypeName("#define DISPID_SITEMODECLEARJUMPLIST 53")]
    public const int DISPID_SITEMODECLEARJUMPLIST = 53;

    [NativeTypeName("#define DISPID_SITEMODEADDBUTTONSTYLE 54")]
    public const int DISPID_SITEMODEADDBUTTONSTYLE = 54;

    [NativeTypeName("#define DISPID_SITEMODESHOWBUTTONSTYLE 55")]
    public const int DISPID_SITEMODESHOWBUTTONSTYLE = 55;

    [NativeTypeName("#define DISPID_SITEMODESHOWJUMPLIST 56")]
    public const int DISPID_SITEMODESHOWJUMPLIST = 56;

    [NativeTypeName("#define DISPID_ADDTRACKINGPROTECTIONLIST 57")]
    public const int DISPID_ADDTRACKINGPROTECTIONLIST = 57;

    [NativeTypeName("#define DISPID_SITEMODEACTIVATE 58")]
    public const int DISPID_SITEMODEACTIVATE = 58;

    [NativeTypeName("#define DISPID_ISSITEMODEFIRSTRUN 59")]
    public const int DISPID_ISSITEMODEFIRSTRUN = 59;

    [NativeTypeName("#define DISPID_TRACKINGPROTECTIONENABLED 60")]
    public const int DISPID_TRACKINGPROTECTIONENABLED = 60;

    [NativeTypeName("#define DISPID_ACTIVEXFILTERINGENABLED 61")]
    public const int DISPID_ACTIVEXFILTERINGENABLED = 61;

    [NativeTypeName("#define DISPID_PROVISIONNETWORKS 62")]
    public const int DISPID_PROVISIONNETWORKS = 62;

    [NativeTypeName("#define DISPID_REPORTSAFEURL 63")]
    public const int DISPID_REPORTSAFEURL = 63;

    [NativeTypeName("#define DISPID_SITEMODEREFRESHBADGE 64")]
    public const int DISPID_SITEMODEREFRESHBADGE = 64;

    [NativeTypeName("#define DISPID_SITEMODECLEARBADGE 65")]
    public const int DISPID_SITEMODECLEARBADGE = 65;

    [NativeTypeName("#define DISPID_DIAGNOSECONNECTIONUILESS 66")]
    public const int DISPID_DIAGNOSECONNECTIONUILESS = 66;

    [NativeTypeName("#define DISPID_LAUNCHNETWORKCLIENTHELP 67")]
    public const int DISPID_LAUNCHNETWORKCLIENTHELP = 67;

    [NativeTypeName("#define DISPID_CHANGEDEFAULTBROWSER 68")]
    public const int DISPID_CHANGEDEFAULTBROWSER = 68;

    [NativeTypeName("#define DISPID_STOPPERIODICUPDATE 69")]
    public const int DISPID_STOPPERIODICUPDATE = 69;

    [NativeTypeName("#define DISPID_STARTPERIODICUPDATE 70")]
    public const int DISPID_STARTPERIODICUPDATE = 70;

    [NativeTypeName("#define DISPID_CLEARNOTIFICATION 71")]
    public const int DISPID_CLEARNOTIFICATION = 71;

    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUE 72")]
    public const int DISPID_ENABLENOTIFICATIONQUEUE = 72;

    [NativeTypeName("#define DISPID_PINNEDSITESTATE 73")]
    public const int DISPID_PINNEDSITESTATE = 73;

    [NativeTypeName("#define DISPID_LAUNCHINTERNETOPTIONS 74")]
    public const int DISPID_LAUNCHINTERNETOPTIONS = 74;

    [NativeTypeName("#define DISPID_STARTPERIODICUPDATEBATCH 75")]
    public const int DISPID_STARTPERIODICUPDATEBATCH = 75;

    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUESQUARE 76")]
    public const int DISPID_ENABLENOTIFICATIONQUEUESQUARE = 76;

    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUEWIDE 77")]
    public const int DISPID_ENABLENOTIFICATIONQUEUEWIDE = 77;

    [NativeTypeName("#define DISPID_ENABLENOTIFICATIONQUEUELARGE 78")]
    public const int DISPID_ENABLENOTIFICATIONQUEUELARGE = 78;

    [NativeTypeName("#define DISPID_SCHEDULEDTILENOTIFICATION 79")]
    public const int DISPID_SCHEDULEDTILENOTIFICATION = 79;

    [NativeTypeName("#define DISPID_REMOVESCHEDULEDTILENOTIFICATION 80")]
    public const int DISPID_REMOVESCHEDULEDTILENOTIFICATION = 80;

    [NativeTypeName("#define DISPID_STARTBADGEUPDATE 81")]
    public const int DISPID_STARTBADGEUPDATE = 81;

    [NativeTypeName("#define DISPID_STOPBADGEUPDATE 82")]
    public const int DISPID_STOPBADGEUPDATE = 82;

    [NativeTypeName("#define DISPID_ISMETAREFERRERAVAILABLE 83")]
    public const int DISPID_ISMETAREFERRERAVAILABLE = 83;

    [NativeTypeName("#define DISPID_SETEXPERIMENTALFLAG 84")]
    public const int DISPID_SETEXPERIMENTALFLAG = 84;

    [NativeTypeName("#define DISPID_GETEXPERIMENTALFLAG 85")]
    public const int DISPID_GETEXPERIMENTALFLAG = 85;

    [NativeTypeName("#define DISPID_SETEXPERIMENTALVALUE 86")]
    public const int DISPID_SETEXPERIMENTALVALUE = 86;

    [NativeTypeName("#define DISPID_GETEXPERIMENTALVALUE 87")]
    public const int DISPID_GETEXPERIMENTALVALUE = 87;

    [NativeTypeName("#define DISPID_HASNEEDIEAUTOLAUNCHFLAG 88")]
    public const int DISPID_HASNEEDIEAUTOLAUNCHFLAG = 88;

    [NativeTypeName("#define DISPID_GETNEEDIEAUTOLAUNCHFLAG 89")]
    public const int DISPID_GETNEEDIEAUTOLAUNCHFLAG = 89;

    [NativeTypeName("#define DISPID_SETNEEDIEAUTOLAUNCHFLAG 90")]
    public const int DISPID_SETNEEDIEAUTOLAUNCHFLAG = 90;

    [NativeTypeName("#define DISPID_LAUNCHIE 91")]
    public const int DISPID_LAUNCHIE = 91;

    [NativeTypeName("#define DISPID_RESETEXPERIMENTALFLAGS 92")]
    public const int DISPID_RESETEXPERIMENTALFLAGS = 92;

    [NativeTypeName("#define DISPID_GETCVLISTDATA 93")]
    public const int DISPID_GETCVLISTDATA = 93;

    [NativeTypeName("#define DISPID_GETCVLISTLOCALDATA 94")]
    public const int DISPID_GETCVLISTLOCALDATA = 94;

    [NativeTypeName("#define DISPID_GETEMIELISTDATA 95")]
    public const int DISPID_GETEMIELISTDATA = 95;

    [NativeTypeName("#define DISPID_GETEMIELISTLOCALDATA 96")]
    public const int DISPID_GETEMIELISTLOCALDATA = 96;

    [NativeTypeName("#define DISPID_OPENFAVORITESPANE 97")]
    public const int DISPID_OPENFAVORITESPANE = 97;

    [NativeTypeName("#define DISPID_OPENFAVORITESSETTINGS 98")]
    public const int DISPID_OPENFAVORITESSETTINGS = 98;

    [NativeTypeName("#define DISPID_LAUNCHINHVSI 99")]
    public const int DISPID_LAUNCHINHVSI = 99;

    [NativeTypeName("#define DISPID_GETNEEDHVSIAUTOLAUNCHFLAG 100")]
    public const int DISPID_GETNEEDHVSIAUTOLAUNCHFLAG = 100;

    [NativeTypeName("#define DISPID_SETNEEDHVSIAUTOLAUNCHFLAG 101")]
    public const int DISPID_SETNEEDHVSIAUTOLAUNCHFLAG = 101;

    [NativeTypeName("#define DISPID_HASNEEDHVSIAUTOLAUNCHFLAG 102")]
    public const int DISPID_HASNEEDHVSIAUTOLAUNCHFLAG = 102;

    [NativeTypeName("#define DISPID_GETOSSKU 103")]
    public const int DISPID_GETOSSKU = 103;

    [NativeTypeName("#define DISPID_SETMSDEFAULTS 104")]
    public const int DISPID_SETMSDEFAULTS = 104;

    [NativeTypeName("#define DISPID_SHELLUIHELPERLAST 105")]
    public const int DISPID_SHELLUIHELPERLAST = 105;

    [NativeTypeName("#define DISPID_ADVANCEERROR 10")]
    public const int DISPID_ADVANCEERROR = 10;

    [NativeTypeName("#define DISPID_RETREATERROR 11")]
    public const int DISPID_RETREATERROR = 11;

    [NativeTypeName("#define DISPID_CANADVANCEERROR 12")]
    public const int DISPID_CANADVANCEERROR = 12;

    [NativeTypeName("#define DISPID_CANRETREATERROR 13")]
    public const int DISPID_CANRETREATERROR = 13;

    [NativeTypeName("#define DISPID_GETERRORLINE 14")]
    public const int DISPID_GETERRORLINE = 14;

    [NativeTypeName("#define DISPID_GETERRORCHAR 15")]
    public const int DISPID_GETERRORCHAR = 15;

    [NativeTypeName("#define DISPID_GETERRORCODE 16")]
    public const int DISPID_GETERRORCODE = 16;

    [NativeTypeName("#define DISPID_GETERRORMSG 17")]
    public const int DISPID_GETERRORMSG = 17;

    [NativeTypeName("#define DISPID_GETERRORURL 18")]
    public const int DISPID_GETERRORURL = 18;

    [NativeTypeName("#define DISPID_GETDETAILSSTATE 19")]
    public const int DISPID_GETDETAILSSTATE = 19;

    [NativeTypeName("#define DISPID_SETDETAILSSTATE 20")]
    public const int DISPID_SETDETAILSSTATE = 20;

    [NativeTypeName("#define DISPID_GETPERERRSTATE 21")]
    public const int DISPID_GETPERERRSTATE = 21;

    [NativeTypeName("#define DISPID_SETPERERRSTATE 22")]
    public const int DISPID_SETPERERRSTATE = 22;

    [NativeTypeName("#define DISPID_GETALWAYSSHOWLOCKSTATE 23")]
    public const int DISPID_GETALWAYSSHOWLOCKSTATE = 23;

    [NativeTypeName("#define DISPID_FAVSELECTIONCHANGE 1")]
    public const int DISPID_FAVSELECTIONCHANGE = 1;

    [NativeTypeName("#define DISPID_SELECTIONCHANGE 2")]
    public const int DISPID_SELECTIONCHANGE = 2;

    [NativeTypeName("#define DISPID_DOUBLECLICK 3")]
    public const int DISPID_DOUBLECLICK = 3;

    [NativeTypeName("#define DISPID_INITIALIZED 4")]
    public const int DISPID_INITIALIZED = 4;

    [NativeTypeName("#define DISPID_MOVESELECTIONUP 1")]
    public const int DISPID_MOVESELECTIONUP = 1;

    [NativeTypeName("#define DISPID_MOVESELECTIONDOWN 2")]
    public const int DISPID_MOVESELECTIONDOWN = 2;

    [NativeTypeName("#define DISPID_RESETSORT 3")]
    public const int DISPID_RESETSORT = 3;

    [NativeTypeName("#define DISPID_NEWFOLDER 4")]
    public const int DISPID_NEWFOLDER = 4;

    [NativeTypeName("#define DISPID_SYNCHRONIZE 5")]
    public const int DISPID_SYNCHRONIZE = 5;

    [NativeTypeName("#define DISPID_IMPORT 6")]
    public const int DISPID_IMPORT = 6;

    [NativeTypeName("#define DISPID_EXPORT 7")]
    public const int DISPID_EXPORT = 7;

    [NativeTypeName("#define DISPID_INVOKECONTEXTMENU 8")]
    public const int DISPID_INVOKECONTEXTMENU = 8;

    [NativeTypeName("#define DISPID_MOVESELECTIONTO 9")]
    public const int DISPID_MOVESELECTIONTO = 9;

    [NativeTypeName("#define DISPID_SUBSCRIPTIONSENABLED 10")]
    public const int DISPID_SUBSCRIPTIONSENABLED = 10;

    [NativeTypeName("#define DISPID_CREATESUBSCRIPTION 11")]
    public const int DISPID_CREATESUBSCRIPTION = 11;

    [NativeTypeName("#define DISPID_DELETESUBSCRIPTION 12")]
    public const int DISPID_DELETESUBSCRIPTION = 12;

    [NativeTypeName("#define DISPID_SETROOT 13")]
    public const int DISPID_SETROOT = 13;

    [NativeTypeName("#define DISPID_ENUMOPTIONS 14")]
    public const int DISPID_ENUMOPTIONS = 14;

    [NativeTypeName("#define DISPID_SELECTEDITEM 15")]
    public const int DISPID_SELECTEDITEM = 15;

    [NativeTypeName("#define DISPID_ROOT 16")]
    public const int DISPID_ROOT = 16;

    [NativeTypeName("#define DISPID_DEPTH 17")]
    public const int DISPID_DEPTH = 17;

    [NativeTypeName("#define DISPID_MODE 18")]
    public const int DISPID_MODE = 18;

    [NativeTypeName("#define DISPID_FLAGS 19")]
    public const int DISPID_FLAGS = 19;

    [NativeTypeName("#define DISPID_TVFLAGS 20")]
    public const int DISPID_TVFLAGS = 20;

    [NativeTypeName("#define DISPID_NSCOLUMNS 21")]
    public const int DISPID_NSCOLUMNS = 21;

    [NativeTypeName("#define DISPID_COUNTVIEWTYPES 22")]
    public const int DISPID_COUNTVIEWTYPES = 22;

    [NativeTypeName("#define DISPID_SETVIEWTYPE 23")]
    public const int DISPID_SETVIEWTYPE = 23;

    [NativeTypeName("#define DISPID_SELECTEDITEMS 24")]
    public const int DISPID_SELECTEDITEMS = 24;

    [NativeTypeName("#define DISPID_EXPAND 25")]
    public const int DISPID_EXPAND = 25;

    [NativeTypeName("#define DISPID_UNSELECTALL 26")]
    public const int DISPID_UNSELECTALL = 26;
}
