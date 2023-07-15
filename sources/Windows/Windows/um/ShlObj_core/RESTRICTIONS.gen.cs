// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS"]/*'/>
public enum RESTRICTIONS
{
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONE"]/*'/>
    REST_NONE = 0x00000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORUN"]/*'/>
    REST_NORUN = 0x00000001,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCLOSE"]/*'/>
    REST_NOCLOSE = 0x00000002,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSAVESET"]/*'/>
    REST_NOSAVESET = 0x00000004,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFILEMENU"]/*'/>
    REST_NOFILEMENU = 0x00000008,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSETFOLDERS"]/*'/>
    REST_NOSETFOLDERS = 0x00000010,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSETTASKBAR"]/*'/>
    REST_NOSETTASKBAR = 0x00000020,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODESKTOP"]/*'/>
    REST_NODESKTOP = 0x00000040,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFIND"]/*'/>
    REST_NOFIND = 0x00000080,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODRIVES"]/*'/>
    REST_NODRIVES = 0x00000100,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODRIVEAUTORUN"]/*'/>
    REST_NODRIVEAUTORUN = 0x00000200,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODRIVETYPEAUTORUN"]/*'/>
    REST_NODRIVETYPEAUTORUN = 0x00000400,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONETHOOD"]/*'/>
    REST_NONETHOOD = 0x00000800,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_STARTBANNER"]/*'/>
    REST_STARTBANNER = 0x00001000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_RESTRICTRUN"]/*'/>
    REST_RESTRICTRUN = 0x00002000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOPRINTERTABS"]/*'/>
    REST_NOPRINTERTABS = 0x00004000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOPRINTERDELETE"]/*'/>
    REST_NOPRINTERDELETE = 0x00008000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOPRINTERADD"]/*'/>
    REST_NOPRINTERADD = 0x00010000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSTARTMENUSUBFOLDERS"]/*'/>
    REST_NOSTARTMENUSUBFOLDERS = 0x00020000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_MYDOCSONNET"]/*'/>
    REST_MYDOCSONNET = 0x00040000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOEXITTODOS"]/*'/>
    REST_NOEXITTODOS = 0x00080000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ENFORCESHELLEXTSECURITY"]/*'/>
    REST_ENFORCESHELLEXTSECURITY = 0x00100000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_LINKRESOLVEIGNORELINKINFO"]/*'/>
    REST_LINKRESOLVEIGNORELINKINFO = 0x00200000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCOMMONGROUPS"]/*'/>
    REST_NOCOMMONGROUPS = 0x00400000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_SEPARATEDESKTOPPROCESS"]/*'/>
    REST_SEPARATEDESKTOPPROCESS = 0x00800000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOWEB"]/*'/>
    REST_NOWEB = 0x01000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTRAYCONTEXTMENU"]/*'/>
    REST_NOTRAYCONTEXTMENU = 0x02000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOVIEWCONTEXTMENU"]/*'/>
    REST_NOVIEWCONTEXTMENU = 0x04000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONETCONNECTDISCONNECT"]/*'/>
    REST_NONETCONNECTDISCONNECT = 0x08000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_STARTMENULOGOFF"]/*'/>
    REST_STARTMENULOGOFF = 0x10000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSETTINGSASSIST"]/*'/>
    REST_NOSETTINGSASSIST = 0x20000000,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOINTERNETICON"]/*'/>
    REST_NOINTERNETICON = 0x40000001,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORECENTDOCSHISTORY"]/*'/>
    REST_NORECENTDOCSHISTORY = 0x40000002,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORECENTDOCSMENU"]/*'/>
    REST_NORECENTDOCSMENU = 0x40000003,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOACTIVEDESKTOP"]/*'/>
    REST_NOACTIVEDESKTOP = 0x40000004,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOACTIVEDESKTOPCHANGES"]/*'/>
    REST_NOACTIVEDESKTOPCHANGES = 0x40000005,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFAVORITESMENU"]/*'/>
    REST_NOFAVORITESMENU = 0x40000006,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_CLEARRECENTDOCSONEXIT"]/*'/>
    REST_CLEARRECENTDOCSONEXIT = 0x40000007,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_CLASSICSHELL"]/*'/>
    REST_CLASSICSHELL = 0x40000008,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCUSTOMIZEWEBVIEW"]/*'/>
    REST_NOCUSTOMIZEWEBVIEW = 0x40000009,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOHTMLWALLPAPER"]/*'/>
    REST_NOHTMLWALLPAPER = 0x40000010,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCHANGINGWALLPAPER"]/*'/>
    REST_NOCHANGINGWALLPAPER = 0x40000011,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODESKCOMP"]/*'/>
    REST_NODESKCOMP = 0x40000012,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOADDDESKCOMP"]/*'/>
    REST_NOADDDESKCOMP = 0x40000013,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODELDESKCOMP"]/*'/>
    REST_NODELDESKCOMP = 0x40000014,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCLOSEDESKCOMP"]/*'/>
    REST_NOCLOSEDESKCOMP = 0x40000015,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCLOSE_DRAGDROPBAND"]/*'/>
    REST_NOCLOSE_DRAGDROPBAND = 0x40000016,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOMOVINGBAND"]/*'/>
    REST_NOMOVINGBAND = 0x40000017,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOEDITDESKCOMP"]/*'/>
    REST_NOEDITDESKCOMP = 0x40000018,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORESOLVESEARCH"]/*'/>
    REST_NORESOLVESEARCH = 0x40000019,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORESOLVETRACK"]/*'/>
    REST_NORESOLVETRACK = 0x4000001A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_FORCECOPYACLWITHFILE"]/*'/>
    REST_FORCECOPYACLWITHFILE = 0x4000001B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFORGETSOFTWAREUPDATE"]/*'/>
    REST_NOFORGETSOFTWAREUPDATE = 0x4000001D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSETACTIVEDESKTOP"]/*'/>
    REST_NOSETACTIVEDESKTOP = 0x4000001E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOUPDATEWINDOWS"]/*'/>
    REST_NOUPDATEWINDOWS = 0x4000001F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCHANGESTARMENU"]/*'/>
    REST_NOCHANGESTARMENU = 0x40000020,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFOLDEROPTIONS"]/*'/>
    REST_NOFOLDEROPTIONS = 0x40000021,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_HASFINDCOMPUTERS"]/*'/>
    REST_HASFINDCOMPUTERS = 0x40000022,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_INTELLIMENUS"]/*'/>
    REST_INTELLIMENUS = 0x40000023,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_RUNDLGMEMCHECKBOX"]/*'/>
    REST_RUNDLGMEMCHECKBOX = 0x40000024,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_ShowPostSetup"]/*'/>
    REST_ARP_ShowPostSetup = 0x40000025,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCSC"]/*'/>
    REST_NOCSC = 0x40000026,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCONTROLPANEL"]/*'/>
    REST_NOCONTROLPANEL = 0x40000027,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ENUMWORKGROUP"]/*'/>
    REST_ENUMWORKGROUP = 0x40000028,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_NOARP"]/*'/>
    REST_ARP_NOARP = 0x40000029,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_NOREMOVEPAGE"]/*'/>
    REST_ARP_NOREMOVEPAGE = 0x4000002A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_NOADDPAGE"]/*'/>
    REST_ARP_NOADDPAGE = 0x4000002B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_NOWINSETUPPAGE"]/*'/>
    REST_ARP_NOWINSETUPPAGE = 0x4000002C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_GREYMSIADS"]/*'/>
    REST_GREYMSIADS = 0x4000002D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCHANGEMAPPEDDRIVELABEL"]/*'/>
    REST_NOCHANGEMAPPEDDRIVELABEL = 0x4000002E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCHANGEMAPPEDDRIVECOMMENT"]/*'/>
    REST_NOCHANGEMAPPEDDRIVECOMMENT = 0x4000002F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_MaxRecentDocs"]/*'/>
    REST_MaxRecentDocs = 0x40000030,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONETWORKCONNECTIONS"]/*'/>
    REST_NONETWORKCONNECTIONS = 0x40000031,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_FORCESTARTMENULOGOFF"]/*'/>
    REST_FORCESTARTMENULOGOFF = 0x40000032,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOWEBVIEW"]/*'/>
    REST_NOWEBVIEW = 0x40000033,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCUSTOMIZETHISFOLDER"]/*'/>
    REST_NOCUSTOMIZETHISFOLDER = 0x40000034,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOENCRYPTION"]/*'/>
    REST_NOENCRYPTION = 0x40000035,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_DONTSHOWSUPERHIDDEN"]/*'/>
    REST_DONTSHOWSUPERHIDDEN = 0x40000037,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSHELLSEARCHBUTTON"]/*'/>
    REST_NOSHELLSEARCHBUTTON = 0x40000038,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOHARDWARETAB"]/*'/>
    REST_NOHARDWARETAB = 0x40000039,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NORUNASINSTALLPROMPT"]/*'/>
    REST_NORUNASINSTALLPROMPT = 0x4000003A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_PROMPTRUNASINSTALLNETPATH"]/*'/>
    REST_PROMPTRUNASINSTALLNETPATH = 0x4000003B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOMANAGEMYCOMPUTERVERB"]/*'/>
    REST_NOMANAGEMYCOMPUTERVERB = 0x4000003C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_DISALLOWRUN"]/*'/>
    REST_DISALLOWRUN = 0x4000003E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOWELCOMESCREEN"]/*'/>
    REST_NOWELCOMESCREEN = 0x4000003F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_RESTRICTCPL"]/*'/>
    REST_RESTRICTCPL = 0x40000040,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_DISALLOWCPL"]/*'/>
    REST_DISALLOWCPL = 0x40000041,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMBALLOONTIP"]/*'/>
    REST_NOSMBALLOONTIP = 0x40000042,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMHELP"]/*'/>
    REST_NOSMHELP = 0x40000043,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOWINKEYS"]/*'/>
    REST_NOWINKEYS = 0x40000044,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOENCRYPTONMOVE"]/*'/>
    REST_NOENCRYPTONMOVE = 0x40000045,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOLOCALMACHINERUN"]/*'/>
    REST_NOLOCALMACHINERUN = 0x40000046,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCURRENTUSERRUN"]/*'/>
    REST_NOCURRENTUSERRUN = 0x40000047,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOLOCALMACHINERUNONCE"]/*'/>
    REST_NOLOCALMACHINERUNONCE = 0x40000048,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCURRENTUSERRUNONCE"]/*'/>
    REST_NOCURRENTUSERRUNONCE = 0x40000049,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_FORCEACTIVEDESKTOPON"]/*'/>
    REST_FORCEACTIVEDESKTOPON = 0x4000004A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOVIEWONDRIVE"]/*'/>
    REST_NOVIEWONDRIVE = 0x4000004C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONETCRAWL"]/*'/>
    REST_NONETCRAWL = 0x4000004D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSHAREDDOCUMENTS"]/*'/>
    REST_NOSHAREDDOCUMENTS = 0x4000004E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMMYDOCS"]/*'/>
    REST_NOSMMYDOCS = 0x4000004F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMMYPICS"]/*'/>
    REST_NOSMMYPICS = 0x40000050,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ALLOWBITBUCKDRIVES"]/*'/>
    REST_ALLOWBITBUCKDRIVES = 0x40000051,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NONLEGACYSHELLMODE"]/*'/>
    REST_NONLEGACYSHELLMODE = 0x40000052,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCONTROLPANELBARRICADE"]/*'/>
    REST_NOCONTROLPANELBARRICADE = 0x40000053,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSTARTPAGE"]/*'/>
    REST_NOSTARTPAGE = 0x40000054,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOAUTOTRAYNOTIFY"]/*'/>
    REST_NOAUTOTRAYNOTIFY = 0x40000055,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTASKGROUPING"]/*'/>
    REST_NOTASKGROUPING = 0x40000056,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCDBURNING"]/*'/>
    REST_NOCDBURNING = 0x40000057,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_MYCOMPNOPROP"]/*'/>
    REST_MYCOMPNOPROP = 0x40000058,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_MYDOCSNOPROP"]/*'/>
    REST_MYDOCSNOPROP = 0x40000059,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSTARTPANEL"]/*'/>
    REST_NOSTARTPANEL = 0x4000005A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPLAYAPPEARANCEPAGE"]/*'/>
    REST_NODISPLAYAPPEARANCEPAGE = 0x4000005B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTHEMESTAB"]/*'/>
    REST_NOTHEMESTAB = 0x4000005C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOVISUALSTYLECHOICE"]/*'/>
    REST_NOVISUALSTYLECHOICE = 0x4000005D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSIZECHOICE"]/*'/>
    REST_NOSIZECHOICE = 0x4000005E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOCOLORCHOICE"]/*'/>
    REST_NOCOLORCHOICE = 0x4000005F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_SETVISUALSTYLE"]/*'/>
    REST_SETVISUALSTYLE = 0x40000060,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_STARTRUNNOHOMEPATH"]/*'/>
    REST_STARTRUNNOHOMEPATH = 0x40000061,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOUSERNAMEINSTARTPANEL"]/*'/>
    REST_NOUSERNAMEINSTARTPANEL = 0x40000062,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOMYCOMPUTERICON"]/*'/>
    REST_NOMYCOMPUTERICON = 0x40000063,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMNETWORKPLACES"]/*'/>
    REST_NOSMNETWORKPLACES = 0x40000064,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMPINNEDLIST"]/*'/>
    REST_NOSMPINNEDLIST = 0x40000065,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMMYMUSIC"]/*'/>
    REST_NOSMMYMUSIC = 0x40000066,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMEJECTPC"]/*'/>
    REST_NOSMEJECTPC = 0x40000067,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMMOREPROGRAMS"]/*'/>
    REST_NOSMMOREPROGRAMS = 0x40000068,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMMFUPROGRAMS"]/*'/>
    REST_NOSMMFUPROGRAMS = 0x40000069,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTRAYITEMSDISPLAY"]/*'/>
    REST_NOTRAYITEMSDISPLAY = 0x4000006A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTOOLBARSONTASKBAR"]/*'/>
    REST_NOTOOLBARSONTASKBAR = 0x4000006B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSMCONFIGUREPROGRAMS"]/*'/>
    REST_NOSMCONFIGUREPROGRAMS = 0x4000006F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_HIDECLOCK"]/*'/>
    REST_HIDECLOCK = 0x40000070,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOLOWDISKSPACECHECKS"]/*'/>
    REST_NOLOWDISKSPACECHECKS = 0x40000071,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOENTIRENETWORK"]/*'/>
    REST_NOENTIRENETWORK = 0x40000072,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODESKTOPCLEANUP"]/*'/>
    REST_NODESKTOPCLEANUP = 0x40000073,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_BITBUCKNUKEONDELETE"]/*'/>
    REST_BITBUCKNUKEONDELETE = 0x40000074,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_BITBUCKCONFIRMDELETE"]/*'/>
    REST_BITBUCKCONFIRMDELETE = 0x40000075,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_BITBUCKNOPROP"]/*'/>
    REST_BITBUCKNOPROP = 0x40000076,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPBACKGROUND"]/*'/>
    REST_NODISPBACKGROUND = 0x40000077,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPSCREENSAVEPG"]/*'/>
    REST_NODISPSCREENSAVEPG = 0x40000078,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPSETTINGSPG"]/*'/>
    REST_NODISPSETTINGSPG = 0x40000079,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPSCREENSAVEPREVIEW"]/*'/>
    REST_NODISPSCREENSAVEPREVIEW = 0x4000007A,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISPLAYCPL"]/*'/>
    REST_NODISPLAYCPL = 0x4000007B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_HIDERUNASVERB"]/*'/>
    REST_HIDERUNASVERB = 0x4000007C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOTHUMBNAILCACHE"]/*'/>
    REST_NOTHUMBNAILCACHE = 0x4000007D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSTRCMPLOGICAL"]/*'/>
    REST_NOSTRCMPLOGICAL = 0x4000007E,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOPUBLISHWIZARD"]/*'/>
    REST_NOPUBLISHWIZARD = 0x4000007F,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOONLINEPRINTSWIZARD"]/*'/>
    REST_NOONLINEPRINTSWIZARD = 0x40000080,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOWEBSERVICES"]/*'/>
    REST_NOWEBSERVICES = 0x40000081,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ALLOWUNHASHEDWEBVIEW"]/*'/>
    REST_ALLOWUNHASHEDWEBVIEW = 0x40000082,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ALLOWLEGACYWEBVIEW"]/*'/>
    REST_ALLOWLEGACYWEBVIEW = 0x40000083,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_REVERTWEBVIEWSECURITY"]/*'/>
    REST_REVERTWEBVIEWSECURITY = 0x40000084,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_INHERITCONSOLEHANDLES"]/*'/>
    REST_INHERITCONSOLEHANDLES = 0x40000086,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOREMOTERECURSIVEEVENTS"]/*'/>
    REST_NOREMOTERECURSIVEEVENTS = 0x40000089,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOREMOTECHANGENOTIFY"]/*'/>
    REST_NOREMOTECHANGENOTIFY = 0x40000091,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOENUMENTIRENETWORK"]/*'/>
    REST_NOENUMENTIRENETWORK = 0x40000093,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOINTERNETOPENWITH"]/*'/>
    REST_NOINTERNETOPENWITH = 0x40000095,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_DONTRETRYBADNETNAME"]/*'/>
    REST_DONTRETRYBADNETNAME = 0x4000009B,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ALLOWFILECLSIDJUNCTIONS"]/*'/>
    REST_ALLOWFILECLSIDJUNCTIONS = 0x4000009C,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOUPNPINSTALL"]/*'/>
    REST_NOUPNPINSTALL = 0x4000009D,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_DONTGROUPPATCHES"]/*'/>
    REST_ARP_DONTGROUPPATCHES = 0x400000AC,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ARP_NOCHOOSEPROGRAMSPAGE"]/*'/>
    REST_ARP_NOCHOOSEPROGRAMSPAGE = 0x400000AD,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NODISCONNECT"]/*'/>
    REST_NODISCONNECT = 0x41000001,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOSECURITY"]/*'/>
    REST_NOSECURITY = 0x41000002,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_NOFILEASSOCIATE"]/*'/>
    REST_NOFILEASSOCIATE = 0x41000003,
    /// <include file='RESTRICTIONS.xml' path='doc/member[@name="RESTRICTIONS.REST_ALLOWCOMMENTTOGGLE"]/*'/>
    REST_ALLOWCOMMENTTOGGLE = 0x41000004,
}