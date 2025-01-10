// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DI
{
    [NativeTypeName("#define DI_SHOWOEM 0x00000001L")]
    public const int DI_SHOWOEM = 0x00000001;

    [NativeTypeName("#define DI_SHOWCOMPAT 0x00000002L")]
    public const int DI_SHOWCOMPAT = 0x00000002;

    [NativeTypeName("#define DI_SHOWCLASS 0x00000004L")]
    public const int DI_SHOWCLASS = 0x00000004;

    [NativeTypeName("#define DI_SHOWALL 0x00000007L")]
    public const int DI_SHOWALL = 0x00000007;

    [NativeTypeName("#define DI_NOVCP 0x00000008L")]
    public const int DI_NOVCP = 0x00000008;

    [NativeTypeName("#define DI_DIDCOMPAT 0x00000010L")]
    public const int DI_DIDCOMPAT = 0x00000010;

    [NativeTypeName("#define DI_DIDCLASS 0x00000020L")]
    public const int DI_DIDCLASS = 0x00000020;

    [NativeTypeName("#define DI_AUTOASSIGNRES 0x00000040L")]
    public const int DI_AUTOASSIGNRES = 0x00000040;

    [NativeTypeName("#define DI_NEEDRESTART 0x00000080L")]
    public const int DI_NEEDRESTART = 0x00000080;

    [NativeTypeName("#define DI_NEEDREBOOT 0x00000100L")]
    public const int DI_NEEDREBOOT = 0x00000100;

    [NativeTypeName("#define DI_NOBROWSE 0x00000200L")]
    public const int DI_NOBROWSE = 0x00000200;

    [NativeTypeName("#define DI_MULTMFGS 0x00000400L")]
    public const int DI_MULTMFGS = 0x00000400;

    [NativeTypeName("#define DI_DISABLED 0x00000800L")]
    public const int DI_DISABLED = 0x00000800;

    [NativeTypeName("#define DI_GENERALPAGE_ADDED 0x00001000L")]
    public const int DI_GENERALPAGE_ADDED = 0x00001000;

    [NativeTypeName("#define DI_RESOURCEPAGE_ADDED 0x00002000L")]
    public const int DI_RESOURCEPAGE_ADDED = 0x00002000;

    [NativeTypeName("#define DI_PROPERTIES_CHANGE 0x00004000L")]
    public const int DI_PROPERTIES_CHANGE = 0x00004000;

    [NativeTypeName("#define DI_INF_IS_SORTED 0x00008000L")]
    public const int DI_INF_IS_SORTED = 0x00008000;

    [NativeTypeName("#define DI_ENUMSINGLEINF 0x00010000L")]
    public const int DI_ENUMSINGLEINF = 0x00010000;

    [NativeTypeName("#define DI_DONOTCALLCONFIGMG 0x00020000L")]
    public const int DI_DONOTCALLCONFIGMG = 0x00020000;

    [NativeTypeName("#define DI_INSTALLDISABLED 0x00040000L")]
    public const int DI_INSTALLDISABLED = 0x00040000;

    [NativeTypeName("#define DI_COMPAT_FROM_CLASS 0x00080000L")]
    public const int DI_COMPAT_FROM_CLASS = 0x00080000;

    [NativeTypeName("#define DI_CLASSINSTALLPARAMS 0x00100000L")]
    public const int DI_CLASSINSTALLPARAMS = 0x00100000;

    [NativeTypeName("#define DI_NODI_DEFAULTACTION 0x00200000L")]
    public const int DI_NODI_DEFAULTACTION = 0x00200000;

    [NativeTypeName("#define DI_QUIETINSTALL 0x00800000L")]
    public const int DI_QUIETINSTALL = 0x00800000;

    [NativeTypeName("#define DI_NOFILECOPY 0x01000000L")]
    public const int DI_NOFILECOPY = 0x01000000;

    [NativeTypeName("#define DI_FORCECOPY 0x02000000L")]
    public const int DI_FORCECOPY = 0x02000000;

    [NativeTypeName("#define DI_DRIVERPAGE_ADDED 0x04000000L")]
    public const int DI_DRIVERPAGE_ADDED = 0x04000000;

    [NativeTypeName("#define DI_USECI_SELECTSTRINGS 0x08000000L")]
    public const int DI_USECI_SELECTSTRINGS = 0x08000000;

    [NativeTypeName("#define DI_OVERRIDE_INFFLAGS 0x10000000L")]
    public const int DI_OVERRIDE_INFFLAGS = 0x10000000;

    [NativeTypeName("#define DI_PROPS_NOCHANGEUSAGE 0x20000000L")]
    public const int DI_PROPS_NOCHANGEUSAGE = 0x20000000;

    [NativeTypeName("#define DI_NOSELECTICONS 0x40000000L")]
    public const int DI_NOSELECTICONS = 0x40000000;

    [NativeTypeName("#define DI_NOWRITE_IDS 0x80000000L")]
    public const uint DI_NOWRITE_IDS = 0x80000000;

    [NativeTypeName("#define DI_FLAGSEX_RESERVED2 0x00000001L")]
    public const int DI_FLAGSEX_RESERVED2 = 0x00000001;

    [NativeTypeName("#define DI_FLAGSEX_RESERVED3 0x00000002L")]
    public const int DI_FLAGSEX_RESERVED3 = 0x00000002;

    [NativeTypeName("#define DI_FLAGSEX_CI_FAILED 0x00000004L")]
    public const int DI_FLAGSEX_CI_FAILED = 0x00000004;

    [NativeTypeName("#define DI_FLAGSEX_FINISHINSTALL_ACTION 0x00000008L")]
    public const int DI_FLAGSEX_FINISHINSTALL_ACTION = 0x00000008;

    [NativeTypeName("#define DI_FLAGSEX_DIDINFOLIST 0x00000010L")]
    public const int DI_FLAGSEX_DIDINFOLIST = 0x00000010;

    [NativeTypeName("#define DI_FLAGSEX_DIDCOMPATINFO 0x00000020L")]
    public const int DI_FLAGSEX_DIDCOMPATINFO = 0x00000020;

    [NativeTypeName("#define DI_FLAGSEX_FILTERCLASSES 0x00000040L")]
    public const int DI_FLAGSEX_FILTERCLASSES = 0x00000040;

    [NativeTypeName("#define DI_FLAGSEX_SETFAILEDINSTALL 0x00000080L")]
    public const int DI_FLAGSEX_SETFAILEDINSTALL = 0x00000080;

    [NativeTypeName("#define DI_FLAGSEX_DEVICECHANGE 0x00000100L")]
    public const int DI_FLAGSEX_DEVICECHANGE = 0x00000100;

    [NativeTypeName("#define DI_FLAGSEX_ALWAYSWRITEIDS 0x00000200L")]
    public const int DI_FLAGSEX_ALWAYSWRITEIDS = 0x00000200;

    [NativeTypeName("#define DI_FLAGSEX_PROPCHANGE_PENDING 0x00000400L")]
    public const int DI_FLAGSEX_PROPCHANGE_PENDING = 0x00000400;

    [NativeTypeName("#define DI_FLAGSEX_ALLOWEXCLUDEDDRVS 0x00000800L")]
    public const int DI_FLAGSEX_ALLOWEXCLUDEDDRVS = 0x00000800;

    [NativeTypeName("#define DI_FLAGSEX_NOUIONQUERYREMOVE 0x00001000L")]
    public const int DI_FLAGSEX_NOUIONQUERYREMOVE = 0x00001000;

    [NativeTypeName("#define DI_FLAGSEX_USECLASSFORCOMPAT 0x00002000L")]
    public const int DI_FLAGSEX_USECLASSFORCOMPAT = 0x00002000;

    [NativeTypeName("#define DI_FLAGSEX_RESERVED4 0x00004000L")]
    public const int DI_FLAGSEX_RESERVED4 = 0x00004000;

    [NativeTypeName("#define DI_FLAGSEX_NO_DRVREG_MODIFY 0x00008000L")]
    public const int DI_FLAGSEX_NO_DRVREG_MODIFY = 0x00008000;

    [NativeTypeName("#define DI_FLAGSEX_IN_SYSTEM_SETUP 0x00010000L")]
    public const int DI_FLAGSEX_IN_SYSTEM_SETUP = 0x00010000;

    [NativeTypeName("#define DI_FLAGSEX_INET_DRIVER 0x00020000L")]
    public const int DI_FLAGSEX_INET_DRIVER = 0x00020000;

    [NativeTypeName("#define DI_FLAGSEX_APPENDDRIVERLIST 0x00040000L")]
    public const int DI_FLAGSEX_APPENDDRIVERLIST = 0x00040000;

    [NativeTypeName("#define DI_FLAGSEX_PREINSTALLBACKUP 0x00080000L")]
    public const int DI_FLAGSEX_PREINSTALLBACKUP = 0x00080000;

    [NativeTypeName("#define DI_FLAGSEX_BACKUPONREPLACE 0x00100000L")]
    public const int DI_FLAGSEX_BACKUPONREPLACE = 0x00100000;

    [NativeTypeName("#define DI_FLAGSEX_DRIVERLIST_FROM_URL 0x00200000L")]
    public const int DI_FLAGSEX_DRIVERLIST_FROM_URL = 0x00200000;

    [NativeTypeName("#define DI_FLAGSEX_RESERVED1 0x00400000L")]
    public const int DI_FLAGSEX_RESERVED1 = 0x00400000;

    [NativeTypeName("#define DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS 0x00800000L")]
    public const int DI_FLAGSEX_EXCLUDE_OLD_INET_DRIVERS = 0x00800000;

    [NativeTypeName("#define DI_FLAGSEX_POWERPAGE_ADDED 0x01000000L")]
    public const int DI_FLAGSEX_POWERPAGE_ADDED = 0x01000000;

    [NativeTypeName("#define DI_FLAGSEX_FILTERSIMILARDRIVERS 0x02000000L")]
    public const int DI_FLAGSEX_FILTERSIMILARDRIVERS = 0x02000000;

    [NativeTypeName("#define DI_FLAGSEX_INSTALLEDDRIVER 0x04000000L")]
    public const int DI_FLAGSEX_INSTALLEDDRIVER = 0x04000000;

    [NativeTypeName("#define DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE 0x08000000L")]
    public const int DI_FLAGSEX_NO_CLASSLIST_NODE_MERGE = 0x08000000;

    [NativeTypeName("#define DI_FLAGSEX_ALTPLATFORM_DRVSEARCH 0x10000000L")]
    public const int DI_FLAGSEX_ALTPLATFORM_DRVSEARCH = 0x10000000;

    [NativeTypeName("#define DI_FLAGSEX_RESTART_DEVICE_ONLY 0x20000000L")]
    public const int DI_FLAGSEX_RESTART_DEVICE_ONLY = 0x20000000;

    [NativeTypeName("#define DI_FLAGSEX_RECURSIVESEARCH 0x40000000L")]
    public const int DI_FLAGSEX_RECURSIVESEARCH = 0x40000000;

    [NativeTypeName("#define DI_FLAGSEX_SEARCH_PUBLISHED_INFS 0x80000000L")]
    public const uint DI_FLAGSEX_SEARCH_PUBLISHED_INFS = 0x80000000;

    [NativeTypeName("#define DI_REMOVEDEVICE_GLOBAL 0x00000001")]
    public const int DI_REMOVEDEVICE_GLOBAL = 0x00000001;

    [NativeTypeName("#define DI_REMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
    public const int DI_REMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;

    [NativeTypeName("#define DI_UNREMOVEDEVICE_CONFIGSPECIFIC 0x00000002")]
    public const int DI_UNREMOVEDEVICE_CONFIGSPECIFIC = 0x00000002;
}
