// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class IPROPNAME
{
    [NativeTypeName("#define IPROPNAME_PRODUCTNAME TEXT(\"ProductName\")")]
    public const string IPROPNAME_PRODUCTNAME = "ProductName";
    [NativeTypeName("#define IPROPNAME_PRODUCTCODE TEXT(\"ProductCode\")")]
    public const string IPROPNAME_PRODUCTCODE = "ProductCode";
    [NativeTypeName("#define IPROPNAME_PRODUCTVERSION TEXT(\"ProductVersion\")")]
    public const string IPROPNAME_PRODUCTVERSION = "ProductVersion";
    [NativeTypeName("#define IPROPNAME_INSTALLLANGUAGE TEXT(\"ProductLanguage\")")]
    public const string IPROPNAME_INSTALLLANGUAGE = "ProductLanguage";
    [NativeTypeName("#define IPROPNAME_MANUFACTURER TEXT(\"Manufacturer\")")]
    public const string IPROPNAME_MANUFACTURER = "Manufacturer";
    [NativeTypeName("#define IPROPNAME_UPGRADECODE TEXT(\"UpgradeCode\")")]
    public const string IPROPNAME_UPGRADECODE = "UpgradeCode";
    [NativeTypeName("#define IPROPNAME_PIDTEMPLATE TEXT(\"PIDTemplate\")")]
    public const string IPROPNAME_PIDTEMPLATE = "PIDTemplate";
    [NativeTypeName("#define IPROPNAME_DISKPROMPT TEXT(\"DiskPrompt\")")]
    public const string IPROPNAME_DISKPROMPT = "DiskPrompt";
    [NativeTypeName("#define IPROPNAME_LEFTUNIT TEXT(\"LeftUnit\")")]
    public const string IPROPNAME_LEFTUNIT = "LeftUnit";
    [NativeTypeName("#define IPROPNAME_ADMIN_PROPERTIES TEXT(\"AdminProperties\")")]
    public const string IPROPNAME_ADMIN_PROPERTIES = "AdminProperties";
    [NativeTypeName("#define IPROPNAME_DEFAULTUIFONT TEXT(\"DefaultUIFont\")")]
    public const string IPROPNAME_DEFAULTUIFONT = "DefaultUIFont";
    [NativeTypeName("#define IPROPNAME_ALLOWEDPROPERTIES TEXT(\"SecureCustomProperties\")")]
    public const string IPROPNAME_ALLOWEDPROPERTIES = "SecureCustomProperties";
    [NativeTypeName("#define IPROPNAME_ENABLEUSERCONTROL TEXT(\"EnableUserControl\")")]
    public const string IPROPNAME_ENABLEUSERCONTROL = "EnableUserControl";
    [NativeTypeName("#define IPROPNAME_HIDDEN_PROPERTIES TEXT(\"MsiHiddenProperties\")")]
    public const string IPROPNAME_HIDDEN_PROPERTIES = "MsiHiddenProperties";
    [NativeTypeName("#define IPROPNAME_USERNAME TEXT(\"USERNAME\")")]
    public const string IPROPNAME_USERNAME = "USERNAME";
    [NativeTypeName("#define IPROPNAME_COMPANYNAME TEXT(\"COMPANYNAME\")")]
    public const string IPROPNAME_COMPANYNAME = "COMPANYNAME";
    [NativeTypeName("#define IPROPNAME_PIDKEY TEXT(\"PIDKEY\")")]
    public const string IPROPNAME_PIDKEY = "PIDKEY";
    [NativeTypeName("#define IPROPNAME_PATCH TEXT(\"PATCH\")")]
    public const string IPROPNAME_PATCH = "PATCH";
    [NativeTypeName("#define IPROPNAME_MSIPATCHREMOVE TEXT(\"MSIPATCHREMOVE\")")]
    public const string IPROPNAME_MSIPATCHREMOVE = "MSIPATCHREMOVE";
    [NativeTypeName("#define IPROPNAME_TARGETDIR TEXT(\"TARGETDIR\")")]
    public const string IPROPNAME_TARGETDIR = "TARGETDIR";
    [NativeTypeName("#define IPROPNAME_ACTION TEXT(\"ACTION\")")]
    public const string IPROPNAME_ACTION = "ACTION";
    [NativeTypeName("#define IPROPNAME_LIMITUI TEXT(\"LIMITUI\")")]
    public const string IPROPNAME_LIMITUI = "LIMITUI";
    [NativeTypeName("#define IPROPNAME_LOGACTION TEXT(\"LOGACTION\")")]
    public const string IPROPNAME_LOGACTION = "LOGACTION";
    [NativeTypeName("#define IPROPNAME_ALLUSERS TEXT(\"ALLUSERS\")")]
    public const string IPROPNAME_ALLUSERS = "ALLUSERS";
    [NativeTypeName("#define IPROPNAME_INSTALLLEVEL TEXT(\"INSTALLLEVEL\")")]
    public const string IPROPNAME_INSTALLLEVEL = "INSTALLLEVEL";
    [NativeTypeName("#define IPROPNAME_REBOOT TEXT(\"REBOOT\")")]
    public const string IPROPNAME_REBOOT = "REBOOT";
    [NativeTypeName("#define IPROPNAME_REBOOTPROMPT TEXT(\"REBOOTPROMPT\")")]
    public const string IPROPNAME_REBOOTPROMPT = "REBOOTPROMPT";
    [NativeTypeName("#define IPROPNAME_EXECUTEMODE TEXT(\"EXECUTEMODE\")")]
    public const string IPROPNAME_EXECUTEMODE = "EXECUTEMODE";
    [NativeTypeName("#define IPROPNAME_EXECUTEACTION TEXT(\"EXECUTEACTION\")")]
    public const string IPROPNAME_EXECUTEACTION = "EXECUTEACTION";
    [NativeTypeName("#define IPROPNAME_SOURCELIST TEXT(\"SOURCELIST\")")]
    public const string IPROPNAME_SOURCELIST = "SOURCELIST";
    [NativeTypeName("#define IPROPNAME_ROOTDRIVE TEXT(\"ROOTDRIVE\")")]
    public const string IPROPNAME_ROOTDRIVE = "ROOTDRIVE";
    [NativeTypeName("#define IPROPNAME_TRANSFORMS TEXT(\"TRANSFORMS\")")]
    public const string IPROPNAME_TRANSFORMS = "TRANSFORMS";
    [NativeTypeName("#define IPROPNAME_TRANSFORMSATSOURCE TEXT(\"TRANSFORMSATSOURCE\")")]
    public const string IPROPNAME_TRANSFORMSATSOURCE = "TRANSFORMSATSOURCE";
    [NativeTypeName("#define IPROPNAME_TRANSFORMSSECURE TEXT(\"TRANSFORMSSECURE\")")]
    public const string IPROPNAME_TRANSFORMSSECURE = "TRANSFORMSSECURE";
    [NativeTypeName("#define IPROPNAME_SEQUENCE TEXT(\"SEQUENCE\")")]
    public const string IPROPNAME_SEQUENCE = "SEQUENCE";
    [NativeTypeName("#define IPROPNAME_SHORTFILENAMES TEXT(\"SHORTFILENAMES\")")]
    public const string IPROPNAME_SHORTFILENAMES = "SHORTFILENAMES";
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER TEXT(\"PRIMARYFOLDER\")")]
    public const string IPROPNAME_PRIMARYFOLDER = "PRIMARYFOLDER";
    [NativeTypeName("#define IPROPNAME_AFTERREBOOT TEXT(\"AFTERREBOOT\")")]
    public const string IPROPNAME_AFTERREBOOT = "AFTERREBOOT";
    [NativeTypeName("#define IPROPNAME_NOCOMPANYNAME TEXT(\"NOCOMPANYNAME\")")]
    public const string IPROPNAME_NOCOMPANYNAME = "NOCOMPANYNAME";
    [NativeTypeName("#define IPROPNAME_NOUSERNAME TEXT(\"NOUSERNAME\")")]
    public const string IPROPNAME_NOUSERNAME = "NOUSERNAME";
    [NativeTypeName("#define IPROPNAME_DISABLEROLLBACK TEXT(\"DISABLEROLLBACK\")")]
    public const string IPROPNAME_DISABLEROLLBACK = "DISABLEROLLBACK";
    [NativeTypeName("#define IPROPNAME_AVAILABLEFREEREG TEXT(\"AVAILABLEFREEREG\")")]
    public const string IPROPNAME_AVAILABLEFREEREG = "AVAILABLEFREEREG";
    [NativeTypeName("#define IPROPNAME_DISABLEADVTSHORTCUTS TEXT(\"DISABLEADVTSHORTCUTS\")")]
    public const string IPROPNAME_DISABLEADVTSHORTCUTS = "DISABLEADVTSHORTCUTS";
    [NativeTypeName("#define IPROPNAME_PATCHNEWPACKAGECODE TEXT(\"PATCHNEWPACKAGECODE\")")]
    public const string IPROPNAME_PATCHNEWPACKAGECODE = "PATCHNEWPACKAGECODE";
    [NativeTypeName("#define IPROPNAME_PATCHNEWSUMMARYSUBJECT TEXT(\"PATCHNEWSUMMARYSUBJECT\")")]
    public const string IPROPNAME_PATCHNEWSUMMARYSUBJECT = "PATCHNEWSUMMARYSUBJECT";
    [NativeTypeName("#define IPROPNAME_PATCHNEWSUMMARYCOMMENTS TEXT(\"PATCHNEWSUMMARYCOMMENTS\")")]
    public const string IPROPNAME_PATCHNEWSUMMARYCOMMENTS = "PATCHNEWSUMMARYCOMMENTS";
    [NativeTypeName("#define IPROPNAME_PRODUCTLANGUAGE TEXT(\"PRODUCTLANGUAGE\")")]
    public const string IPROPNAME_PRODUCTLANGUAGE = "PRODUCTLANGUAGE";
    [NativeTypeName("#define IPROPNAME_CHECKCRCS TEXT(\"MSICHECKCRCS\")")]
    public const string IPROPNAME_CHECKCRCS = "MSICHECKCRCS";
    [NativeTypeName("#define IPROPNAME_MSINODISABLEMEDIA TEXT(\"MSINODISABLEMEDIA\")")]
    public const string IPROPNAME_MSINODISABLEMEDIA = "MSINODISABLEMEDIA";
    [NativeTypeName("#define IPROPNAME_CARRYINGNDP TEXT(\"CARRYINGNDP\")")]
    public const string IPROPNAME_CARRYINGNDP = "CARRYINGNDP";
    [NativeTypeName("#define IPROPNAME_ENFORCE_UPGRADE_COMPONENT_RULES TEXT(\"MSIENFORCEUPGRADECOMPONENTRULES\")")]
    public const string IPROPNAME_ENFORCE_UPGRADE_COMPONENT_RULES = "MSIENFORCEUPGRADECOMPONENTRULES";
    [NativeTypeName("#define IPROPNAME_MSINEWINSTANCE TEXT(\"MSINEWINSTANCE\")")]
    public const string IPROPNAME_MSINEWINSTANCE = "MSINEWINSTANCE";
    [NativeTypeName("#define IPROPNAME_MSIINSTANCEGUID TEXT(\"MSIINSTANCEGUID\")")]
    public const string IPROPNAME_MSIINSTANCEGUID = "MSIINSTANCEGUID";
    [NativeTypeName("#define IPROPNAME_MSIPACKAGEDOWNLOADLOCALCOPY TEXT(\"MSIPACKAGEDOWNLOADLOCALCOPY\")")]
    public const string IPROPNAME_MSIPACKAGEDOWNLOADLOCALCOPY = "MSIPACKAGEDOWNLOADLOCALCOPY";
    [NativeTypeName("#define IPROPNAME_MSIPATCHDOWNLOADLOCALCOPY TEXT(\"MSIPATCHDOWNLOADLOCALCOPY\")")]
    public const string IPROPNAME_MSIPATCHDOWNLOADLOCALCOPY = "MSIPATCHDOWNLOADLOCALCOPY";
    [NativeTypeName("#define IPROPNAME_MSIDISABLELUAPATCHING TEXT(\"MSIDISABLELUAPATCHING\")")]
    public const string IPROPNAME_MSIDISABLELUAPATCHING = "MSIDISABLELUAPATCHING";
    [NativeTypeName("#define IPROPNAME_MSILOGGINGMODE TEXT(\"MsiLogging\")")]
    public const string IPROPNAME_MSILOGGINGMODE = "MsiLogging";
    [NativeTypeName("#define IPROPNAME_MSILOGFILELOCATION TEXT(\"MsiLogFileLocation\")")]
    public const string IPROPNAME_MSILOGFILELOCATION = "MsiLogFileLocation";
    [NativeTypeName("#define IPROPNAME_MSI_RM_CONTROL TEXT(\"MSIRESTARTMANAGERCONTROL\")")]
    public const string IPROPNAME_MSI_RM_CONTROL = "MSIRESTARTMANAGERCONTROL";
    [NativeTypeName("#define IPROPNAME_MSI_RM_SESSION_KEY TEXT(\"MsiRestartManagerSessionKey\")")]
    public const string IPROPNAME_MSI_RM_SESSION_KEY = "MsiRestartManagerSessionKey";
    [NativeTypeName("#define IPROPNAME_MSI_REBOOT_PENDING TEXT(\"MsiSystemRebootPending\")")]
    public const string IPROPNAME_MSI_REBOOT_PENDING = "MsiSystemRebootPending";
    [NativeTypeName("#define IPROPNAME_MSI_RM_SHUTDOWN TEXT(\"MSIRMSHUTDOWN\")")]
    public const string IPROPNAME_MSI_RM_SHUTDOWN = "MSIRMSHUTDOWN";
    [NativeTypeName("#define IPROPNAME_MSI_RM_DISABLE_RESTART TEXT(\"MSIDISABLERMRESTART\")")]
    public const string IPROPNAME_MSI_RM_DISABLE_RESTART = "MSIDISABLERMRESTART";
    [NativeTypeName("#define IPROPNAME_MSI_UAC_DEPLOYMENT_COMPLIANT TEXT(\"MSIDEPLOYMENTCOMPLIANT\")")]
    public const string IPROPNAME_MSI_UAC_DEPLOYMENT_COMPLIANT = "MSIDEPLOYMENTCOMPLIANT";
    [NativeTypeName("#define IPROPNAME_MSI_USE_REAL_ADMIN_DETECTION TEXT(\"MSIUSEREALADMINDETECTION\")")]
    public const string IPROPNAME_MSI_USE_REAL_ADMIN_DETECTION = "MSIUSEREALADMINDETECTION";
    [NativeTypeName("#define IPROPNAME_MSI_UNINSTALL_SUPERSEDED_COMPONENTS TEXT(\"MSIUNINSTALLSUPERSEDEDCOMPONENTS\")")]
    public const string IPROPNAME_MSI_UNINSTALL_SUPERSEDED_COMPONENTS = "MSIUNINSTALLSUPERSEDEDCOMPONENTS";
    [NativeTypeName("#define IPROPNAME_MSIDISABLEEEUI TEXT(\"MSIDISABLEEEUI\")")]
    public const string IPROPNAME_MSIDISABLEEEUI = "MSIDISABLEEEUI";
    [NativeTypeName("#define IPROPNAME_MSI_FASTINSTALL TEXT(\"MSIFASTINSTALL\")")]
    public const string IPROPNAME_MSI_FASTINSTALL = "MSIFASTINSTALL";
    [NativeTypeName("#define IPROPNAME_INSTALLPERUSER TEXT(\"MSIINSTALLPERUSER\")")]
    public const string IPROPNAME_INSTALLPERUSER = "MSIINSTALLPERUSER";
    [NativeTypeName("#define IPROPNAME_INTERNALINSTALLEDPERUSER TEXT(\"MSIINTERNALINSTALLEDPERUSER\")")]
    public const string IPROPNAME_INTERNALINSTALLEDPERUSER = "MSIINTERNALINSTALLEDPERUSER";
    [NativeTypeName("#define IPROPNAME_ARPAUTHORIZEDCDFPREFIX TEXT(\"ARPAUTHORIZEDCDFPREFIX\")")]
    public const string IPROPNAME_ARPAUTHORIZEDCDFPREFIX = "ARPAUTHORIZEDCDFPREFIX";
    [NativeTypeName("#define IPROPNAME_ARPCOMMENTS TEXT(\"ARPCOMMENTS\")")]
    public const string IPROPNAME_ARPCOMMENTS = "ARPCOMMENTS";
    [NativeTypeName("#define IPROPNAME_ARPCONTACT TEXT(\"ARPCONTACT\")")]
    public const string IPROPNAME_ARPCONTACT = "ARPCONTACT";
    [NativeTypeName("#define IPROPNAME_ARPHELPLINK TEXT(\"ARPHELPLINK\")")]
    public const string IPROPNAME_ARPHELPLINK = "ARPHELPLINK";
    [NativeTypeName("#define IPROPNAME_ARPHELPTELEPHONE TEXT(\"ARPHELPTELEPHONE\")")]
    public const string IPROPNAME_ARPHELPTELEPHONE = "ARPHELPTELEPHONE";
    [NativeTypeName("#define IPROPNAME_ARPINSTALLLOCATION TEXT(\"ARPINSTALLLOCATION\")")]
    public const string IPROPNAME_ARPINSTALLLOCATION = "ARPINSTALLLOCATION";
    [NativeTypeName("#define IPROPNAME_ARPNOMODIFY TEXT(\"ARPNOMODIFY\")")]
    public const string IPROPNAME_ARPNOMODIFY = "ARPNOMODIFY";
    [NativeTypeName("#define IPROPNAME_ARPNOREMOVE TEXT(\"ARPNOREMOVE\")")]
    public const string IPROPNAME_ARPNOREMOVE = "ARPNOREMOVE";
    [NativeTypeName("#define IPROPNAME_ARPNOREPAIR TEXT(\"ARPNOREPAIR\")")]
    public const string IPROPNAME_ARPNOREPAIR = "ARPNOREPAIR";
    [NativeTypeName("#define IPROPNAME_ARPREADME TEXT(\"ARPREADME\")")]
    public const string IPROPNAME_ARPREADME = "ARPREADME";
    [NativeTypeName("#define IPROPNAME_ARPSIZE TEXT(\"ARPSIZE\")")]
    public const string IPROPNAME_ARPSIZE = "ARPSIZE";
    [NativeTypeName("#define IPROPNAME_ARPSYSTEMCOMPONENT TEXT(\"ARPSYSTEMCOMPONENT\")")]
    public const string IPROPNAME_ARPSYSTEMCOMPONENT = "ARPSYSTEMCOMPONENT";
    [NativeTypeName("#define IPROPNAME_ARPURLINFOABOUT TEXT(\"ARPURLINFOABOUT\")")]
    public const string IPROPNAME_ARPURLINFOABOUT = "ARPURLINFOABOUT";
    [NativeTypeName("#define IPROPNAME_ARPURLUPDATEINFO TEXT(\"ARPURLUPDATEINFO\")")]
    public const string IPROPNAME_ARPURLUPDATEINFO = "ARPURLUPDATEINFO";
    [NativeTypeName("#define IPROPNAME_ARPPRODUCTICON TEXT(\"ARPPRODUCTICON\")")]
    public const string IPROPNAME_ARPPRODUCTICON = "ARPPRODUCTICON";
    [NativeTypeName("#define IPROPNAME_ARPSETTINGSIDENTIFIER TEXT(\"MSIARPSETTINGSIDENTIFIER\")")]
    public const string IPROPNAME_ARPSETTINGSIDENTIFIER = "MSIARPSETTINGSIDENTIFIER";
    [NativeTypeName("#define IPROPNAME_ARPSHIMFLAGS TEXT(\"SHIMFLAGS\")")]
    public const string IPROPNAME_ARPSHIMFLAGS = "SHIMFLAGS";
    [NativeTypeName("#define IPROPNAME_ARPSHIMVERSIONNT TEXT(\"SHIMVERSIONNT\")")]
    public const string IPROPNAME_ARPSHIMVERSIONNT = "SHIMVERSIONNT";
    [NativeTypeName("#define IPROPNAME_ARPSHIMSERVICEPACKLEVEL TEXT(\"SHIMSERVICEPACKLEVEL\")")]
    public const string IPROPNAME_ARPSHIMSERVICEPACKLEVEL = "SHIMSERVICEPACKLEVEL";
    [NativeTypeName("#define IPROPNAME_INSTALLED TEXT(\"Installed\")")]
    public const string IPROPNAME_INSTALLED = "Installed";
    [NativeTypeName("#define IPROPNAME_PRODUCTSTATE TEXT(\"ProductState\")")]
    public const string IPROPNAME_PRODUCTSTATE = "ProductState";
    [NativeTypeName("#define IPROPNAME_PRESELECTED TEXT(\"Preselected\")")]
    public const string IPROPNAME_PRESELECTED = "Preselected";
    [NativeTypeName("#define IPROPNAME_RESUME TEXT(\"RESUME\")")]
    public const string IPROPNAME_RESUME = "RESUME";
    [NativeTypeName("#define IPROPNAME_UPDATESTARTED TEXT(\"UpdateStarted\")")]
    public const string IPROPNAME_UPDATESTARTED = "UpdateStarted";
    [NativeTypeName("#define IPROPNAME_PRODUCTID TEXT(\"ProductID\")")]
    public const string IPROPNAME_PRODUCTID = "ProductID";
    [NativeTypeName("#define IPROPNAME_OUTOFDISKSPACE TEXT(\"OutOfDiskSpace\")")]
    public const string IPROPNAME_OUTOFDISKSPACE = "OutOfDiskSpace";
    [NativeTypeName("#define IPROPNAME_OUTOFNORBDISKSPACE TEXT(\"OutOfNoRbDiskSpace\")")]
    public const string IPROPNAME_OUTOFNORBDISKSPACE = "OutOfNoRbDiskSpace";
    [NativeTypeName("#define IPROPNAME_COSTINGCOMPLETE TEXT(\"CostingComplete\")")]
    public const string IPROPNAME_COSTINGCOMPLETE = "CostingComplete";
    [NativeTypeName("#define IPROPNAME_SOURCEDIR TEXT(\"SourceDir\")")]
    public const string IPROPNAME_SOURCEDIR = "SourceDir";
    [NativeTypeName("#define IPROPNAME_REPLACEDINUSEFILES TEXT(\"ReplacedInUseFiles\")")]
    public const string IPROPNAME_REPLACEDINUSEFILES = "ReplacedInUseFiles";
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_PATH TEXT(\"PrimaryVolumePath\")")]
    public const string IPROPNAME_PRIMARYFOLDER_PATH = "PrimaryVolumePath";
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEAVAILABLE TEXT(\"PrimaryVolumeSpaceAvailable\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEAVAILABLE = "PrimaryVolumeSpaceAvailable";
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEREQUIRED TEXT(\"PrimaryVolumeSpaceRequired\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEREQUIRED = "PrimaryVolumeSpaceRequired";
    [NativeTypeName("#define IPROPNAME_PRIMARYFOLDER_SPACEREMAINING TEXT(\"PrimaryVolumeSpaceRemaining\")")]
    public const string IPROPNAME_PRIMARYFOLDER_SPACEREMAINING = "PrimaryVolumeSpaceRemaining";
    [NativeTypeName("#define IPROPNAME_ISADMINPACKAGE TEXT(\"IsAdminPackage\")")]
    public const string IPROPNAME_ISADMINPACKAGE = "IsAdminPackage";
    [NativeTypeName("#define IPROPNAME_ROLLBACKDISABLED TEXT(\"RollbackDisabled\")")]
    public const string IPROPNAME_ROLLBACKDISABLED = "RollbackDisabled";
    [NativeTypeName("#define IPROPNAME_RESTRICTEDUSERCONTROL TEXT(\"RestrictedUserControl\")")]
    public const string IPROPNAME_RESTRICTEDUSERCONTROL = "RestrictedUserControl";
    [NativeTypeName("#define IPROPNAME_SOURCERESONLY TEXT(\"MsiUISourceResOnly\")")]
    public const string IPROPNAME_SOURCERESONLY = "MsiUISourceResOnly";
    [NativeTypeName("#define IPROPNAME_HIDECANCEL TEXT(\"MsiUIHideCancel\")")]
    public const string IPROPNAME_HIDECANCEL = "MsiUIHideCancel";
    [NativeTypeName("#define IPROPNAME_PROGRESSONLY TEXT(\"MsiUIProgressOnly\")")]
    public const string IPROPNAME_PROGRESSONLY = "MsiUIProgressOnly";
    [NativeTypeName("#define IPROPNAME_UACONLY TEXT(\"MsiUIUACOnly\")")]
    public const string IPROPNAME_UACONLY = "MsiUIUACOnly";
    [NativeTypeName("#define IPROPNAME_TIME TEXT(\"Time\")")]
    public const string IPROPNAME_TIME = "Time";
    [NativeTypeName("#define IPROPNAME_DATE TEXT(\"Date\")")]
    public const string IPROPNAME_DATE = "Date";
    [NativeTypeName("#define IPROPNAME_DATETIME TEXT(\"DateTime\")")]
    public const string IPROPNAME_DATETIME = "DateTime";
    [NativeTypeName("#define IPROPNAME_ARM TEXT(\"Arm\")")]
    public const string IPROPNAME_ARM = "Arm";
    [NativeTypeName("#define IPROPNAME_ARM64 TEXT(\"Arm64\")")]
    public const string IPROPNAME_ARM64 = "Arm64";
    [NativeTypeName("#define IPROPNAME_INTEL TEXT(\"Intel\")")]
    public const string IPROPNAME_INTEL = "Intel";
    [NativeTypeName("#define IPROPNAME_TEMPLATE_AMD64 TEXT(\"AMD64\")")]
    public const string IPROPNAME_TEMPLATE_AMD64 = "AMD64";
    [NativeTypeName("#define IPROPNAME_TEMPLATE_X64 TEXT(\"x64\")")]
    public const string IPROPNAME_TEMPLATE_X64 = "x64";
    [NativeTypeName("#define IPROPNAME_MSIAMD64 TEXT(\"MsiAMD64\")")]
    public const string IPROPNAME_MSIAMD64 = "MsiAMD64";
    [NativeTypeName("#define IPROPNAME_MSIX64 TEXT(\"Msix64\")")]
    public const string IPROPNAME_MSIX64 = "Msix64";
    [NativeTypeName("#define IPROPNAME_INTEL64 TEXT(\"Intel64\")")]
    public const string IPROPNAME_INTEL64 = "Intel64";
    [NativeTypeName("#define IPROPNAME_TEXTHEIGHT TEXT(\"TextHeight\")")]
    public const string IPROPNAME_TEXTHEIGHT = "TextHeight";
    [NativeTypeName("#define IPROPNAME_TEXTINTERNALLEADING TEXT(\"TextInternalLeading\")")]
    public const string IPROPNAME_TEXTINTERNALLEADING = "TextInternalLeading";
    [NativeTypeName("#define IPROPNAME_SCREENX TEXT(\"ScreenX\")")]
    public const string IPROPNAME_SCREENX = "ScreenX";
    [NativeTypeName("#define IPROPNAME_SCREENY TEXT(\"ScreenY\")")]
    public const string IPROPNAME_SCREENY = "ScreenY";
    [NativeTypeName("#define IPROPNAME_CAPTIONHEIGHT TEXT(\"CaptionHeight\")")]
    public const string IPROPNAME_CAPTIONHEIGHT = "CaptionHeight";
    [NativeTypeName("#define IPROPNAME_BORDERTOP TEXT(\"BorderTop\")")]
    public const string IPROPNAME_BORDERTOP = "BorderTop";
    [NativeTypeName("#define IPROPNAME_BORDERSIDE TEXT(\"BorderSide\")")]
    public const string IPROPNAME_BORDERSIDE = "BorderSide";
    [NativeTypeName("#define IPROPNAME_COLORBITS TEXT(\"ColorBits\")")]
    public const string IPROPNAME_COLORBITS = "ColorBits";
    [NativeTypeName("#define IPROPNAME_PHYSICALMEMORY TEXT(\"PhysicalMemory\")")]
    public const string IPROPNAME_PHYSICALMEMORY = "PhysicalMemory";
    [NativeTypeName("#define IPROPNAME_VIRTUALMEMORY TEXT(\"VirtualMemory\")")]
    public const string IPROPNAME_VIRTUALMEMORY = "VirtualMemory";
    [NativeTypeName("#define IPROPNAME_TEXTHEIGHT_CORRECTION TEXT(\"TextHeightCorrection\")")]
    public const string IPROPNAME_TEXTHEIGHT_CORRECTION = "TextHeightCorrection";
    [NativeTypeName("#define IPROPNAME_MSITABLETPC TEXT(\"MsiTabletPC\")")]
    public const string IPROPNAME_MSITABLETPC = "MsiTabletPC";
    [NativeTypeName("#define IPROPNAME_VERSIONNT TEXT(\"VersionNT\")")]
    public const string IPROPNAME_VERSIONNT = "VersionNT";
    [NativeTypeName("#define IPROPNAME_VERSION9X TEXT(\"Version9X\")")]
    public const string IPROPNAME_VERSION9X = "Version9X";
    [NativeTypeName("#define IPROPNAME_VERSIONNT64 TEXT(\"VersionNT64\")")]
    public const string IPROPNAME_VERSIONNT64 = "VersionNT64";
    [NativeTypeName("#define IPROPNAME_WINDOWSBUILD TEXT(\"WindowsBuild\")")]
    public const string IPROPNAME_WINDOWSBUILD = "WindowsBuild";
    [NativeTypeName("#define IPROPNAME_SERVICEPACKLEVEL TEXT(\"ServicePackLevel\")")]
    public const string IPROPNAME_SERVICEPACKLEVEL = "ServicePackLevel";
    [NativeTypeName("#define IPROPNAME_SERVICEPACKLEVELMINOR TEXT(\"ServicePackLevelMinor\")")]
    public const string IPROPNAME_SERVICEPACKLEVELMINOR = "ServicePackLevelMinor";
    [NativeTypeName("#define IPROPNAME_SHAREDWINDOWS TEXT(\"SharedWindows\")")]
    public const string IPROPNAME_SHAREDWINDOWS = "SharedWindows";
    [NativeTypeName("#define IPROPNAME_COMPUTERNAME TEXT(\"ComputerName\")")]
    public const string IPROPNAME_COMPUTERNAME = "ComputerName";
    [NativeTypeName("#define IPROPNAME_SHELLADVTSUPPORT TEXT(\"ShellAdvtSupport\")")]
    public const string IPROPNAME_SHELLADVTSUPPORT = "ShellAdvtSupport";
    [NativeTypeName("#define IPROPNAME_OLEADVTSUPPORT TEXT(\"OLEAdvtSupport\")")]
    public const string IPROPNAME_OLEADVTSUPPORT = "OLEAdvtSupport";
    [NativeTypeName("#define IPROPNAME_SYSTEMLANGUAGEID TEXT(\"SystemLanguageID\")")]
    public const string IPROPNAME_SYSTEMLANGUAGEID = "SystemLanguageID";
    [NativeTypeName("#define IPROPNAME_TTCSUPPORT TEXT(\"TTCSupport\")")]
    public const string IPROPNAME_TTCSUPPORT = "TTCSupport";
    [NativeTypeName("#define IPROPNAME_TERMSERVER TEXT(\"TerminalServer\")")]
    public const string IPROPNAME_TERMSERVER = "TerminalServer";
    [NativeTypeName("#define IPROPNAME_REMOTEADMINTS TEXT(\"RemoteAdminTS\")")]
    public const string IPROPNAME_REMOTEADMINTS = "RemoteAdminTS";
    [NativeTypeName("#define IPROPNAME_REDIRECTEDDLLSUPPORT TEXT(\"RedirectedDllSupport\")")]
    public const string IPROPNAME_REDIRECTEDDLLSUPPORT = "RedirectedDllSupport";
    [NativeTypeName("#define IPROPNAME_NTPRODUCTTYPE TEXT(\"MsiNTProductType\")")]
    public const string IPROPNAME_NTPRODUCTTYPE = "MsiNTProductType";
    [NativeTypeName("#define IPROPNAME_NTSUITEBACKOFFICE TEXT(\"MsiNTSuiteBackOffice\")")]
    public const string IPROPNAME_NTSUITEBACKOFFICE = "MsiNTSuiteBackOffice";
    [NativeTypeName("#define IPROPNAME_NTSUITEDATACENTER TEXT(\"MsiNTSuiteDataCenter\")")]
    public const string IPROPNAME_NTSUITEDATACENTER = "MsiNTSuiteDataCenter";
    [NativeTypeName("#define IPROPNAME_NTSUITEENTERPRISE TEXT(\"MsiNTSuiteEnterprise\")")]
    public const string IPROPNAME_NTSUITEENTERPRISE = "MsiNTSuiteEnterprise";
    [NativeTypeName("#define IPROPNAME_NTSUITESMALLBUSINESS TEXT(\"MsiNTSuiteSmallBusiness\")")]
    public const string IPROPNAME_NTSUITESMALLBUSINESS = "MsiNTSuiteSmallBusiness";
    [NativeTypeName("#define IPROPNAME_NTSUITESMALLBUSINESSRESTRICTED TEXT(\"MsiNTSuiteSmallBusinessRestricted\")")]
    public const string IPROPNAME_NTSUITESMALLBUSINESSRESTRICTED = "MsiNTSuiteSmallBusinessRestricted";
    [NativeTypeName("#define IPROPNAME_NTSUITEPERSONAL TEXT(\"MsiNTSuitePersonal\")")]
    public const string IPROPNAME_NTSUITEPERSONAL = "MsiNTSuitePersonal";
    [NativeTypeName("#define IPROPNAME_NTSUITEWEBSERVER TEXT(\"MsiNTSuiteWebServer\")")]
    public const string IPROPNAME_NTSUITEWEBSERVER = "MsiNTSuiteWebServer";
    [NativeTypeName("#define IPROPNAME_NETASSEMBLYSUPPORT TEXT(\"MsiNetAssemblySupport\")")]
    public const string IPROPNAME_NETASSEMBLYSUPPORT = "MsiNetAssemblySupport";
    [NativeTypeName("#define IPROPNAME_WIN32ASSEMBLYSUPPORT TEXT(\"MsiWin32AssemblySupport\")")]
    public const string IPROPNAME_WIN32ASSEMBLYSUPPORT = "MsiWin32AssemblySupport";
    [NativeTypeName("#define IPROPNAME_LOGONUSER TEXT(\"LogonUser\")")]
    public const string IPROPNAME_LOGONUSER = "LogonUser";
    [NativeTypeName("#define IPROPNAME_USERSID TEXT(\"UserSID\")")]
    public const string IPROPNAME_USERSID = "UserSID";
    [NativeTypeName("#define IPROPNAME_ADMINUSER TEXT(\"AdminUser\")")]
    public const string IPROPNAME_ADMINUSER = "AdminUser";
    [NativeTypeName("#define IPROPNAME_USERLANGUAGEID TEXT(\"UserLanguageID\")")]
    public const string IPROPNAME_USERLANGUAGEID = "UserLanguageID";
    [NativeTypeName("#define IPROPNAME_PRIVILEGED TEXT(\"Privileged\")")]
    public const string IPROPNAME_PRIVILEGED = "Privileged";
    [NativeTypeName("#define IPROPNAME_RUNNINGELEVATED TEXT(\"MsiRunningElevated\")")]
    public const string IPROPNAME_RUNNINGELEVATED = "MsiRunningElevated";
    [NativeTypeName("#define IPROPNAME_TRUEADMINUSER TEXT(\"MsiTrueAdminUser\")")]
    public const string IPROPNAME_TRUEADMINUSER = "MsiTrueAdminUser";
    [NativeTypeName("#define IPROPNAME_WINDOWS_FOLDER TEXT(\"WindowsFolder\")")]
    public const string IPROPNAME_WINDOWS_FOLDER = "WindowsFolder";
    [NativeTypeName("#define IPROPNAME_SYSTEM_FOLDER TEXT(\"SystemFolder\")")]
    public const string IPROPNAME_SYSTEM_FOLDER = "SystemFolder";
    [NativeTypeName("#define IPROPNAME_SYSTEM16_FOLDER TEXT(\"System16Folder\")")]
    public const string IPROPNAME_SYSTEM16_FOLDER = "System16Folder";
    [NativeTypeName("#define IPROPNAME_WINDOWS_VOLUME TEXT(\"WindowsVolume\")")]
    public const string IPROPNAME_WINDOWS_VOLUME = "WindowsVolume";
    [NativeTypeName("#define IPROPNAME_TEMP_FOLDER TEXT(\"TempFolder\")")]
    public const string IPROPNAME_TEMP_FOLDER = "TempFolder";
    [NativeTypeName("#define IPROPNAME_PROGRAMFILES_FOLDER TEXT(\"ProgramFilesFolder\")")]
    public const string IPROPNAME_PROGRAMFILES_FOLDER = "ProgramFilesFolder";
    [NativeTypeName("#define IPROPNAME_COMMONFILES_FOLDER TEXT(\"CommonFilesFolder\")")]
    public const string IPROPNAME_COMMONFILES_FOLDER = "CommonFilesFolder";
    [NativeTypeName("#define IPROPNAME_SYSTEM64_FOLDER TEXT(\"System64Folder\")")]
    public const string IPROPNAME_SYSTEM64_FOLDER = "System64Folder";
    [NativeTypeName("#define IPROPNAME_PROGRAMFILES64_FOLDER TEXT(\"ProgramFiles64Folder\")")]
    public const string IPROPNAME_PROGRAMFILES64_FOLDER = "ProgramFiles64Folder";
    [NativeTypeName("#define IPROPNAME_COMMONFILES64_FOLDER TEXT(\"CommonFiles64Folder\")")]
    public const string IPROPNAME_COMMONFILES64_FOLDER = "CommonFiles64Folder";
    [NativeTypeName("#define IPROPNAME_STARTMENU_FOLDER TEXT(\"StartMenuFolder\")")]
    public const string IPROPNAME_STARTMENU_FOLDER = "StartMenuFolder";
    [NativeTypeName("#define IPROPNAME_PROGRAMMENU_FOLDER TEXT(\"ProgramMenuFolder\")")]
    public const string IPROPNAME_PROGRAMMENU_FOLDER = "ProgramMenuFolder";
    [NativeTypeName("#define IPROPNAME_STARTUP_FOLDER TEXT(\"StartupFolder\")")]
    public const string IPROPNAME_STARTUP_FOLDER = "StartupFolder";
    [NativeTypeName("#define IPROPNAME_NETHOOD_FOLDER TEXT(\"NetHoodFolder\")")]
    public const string IPROPNAME_NETHOOD_FOLDER = "NetHoodFolder";
    [NativeTypeName("#define IPROPNAME_PERSONAL_FOLDER TEXT(\"PersonalFolder\")")]
    public const string IPROPNAME_PERSONAL_FOLDER = "PersonalFolder";
    [NativeTypeName("#define IPROPNAME_SENDTO_FOLDER TEXT(\"SendToFolder\")")]
    public const string IPROPNAME_SENDTO_FOLDER = "SendToFolder";
    [NativeTypeName("#define IPROPNAME_DESKTOP_FOLDER TEXT(\"DesktopFolder\")")]
    public const string IPROPNAME_DESKTOP_FOLDER = "DesktopFolder";
    [NativeTypeName("#define IPROPNAME_TEMPLATE_FOLDER TEXT(\"TemplateFolder\")")]
    public const string IPROPNAME_TEMPLATE_FOLDER = "TemplateFolder";
    [NativeTypeName("#define IPROPNAME_FONTS_FOLDER TEXT(\"FontsFolder\")")]
    public const string IPROPNAME_FONTS_FOLDER = "FontsFolder";
    [NativeTypeName("#define IPROPNAME_FAVORITES_FOLDER TEXT(\"FavoritesFolder\")")]
    public const string IPROPNAME_FAVORITES_FOLDER = "FavoritesFolder";
    [NativeTypeName("#define IPROPNAME_RECENT_FOLDER TEXT(\"RecentFolder\")")]
    public const string IPROPNAME_RECENT_FOLDER = "RecentFolder";
    [NativeTypeName("#define IPROPNAME_APPDATA_FOLDER TEXT(\"AppDataFolder\")")]
    public const string IPROPNAME_APPDATA_FOLDER = "AppDataFolder";
    [NativeTypeName("#define IPROPNAME_PRINTHOOD_FOLDER TEXT(\"PrintHoodFolder\")")]
    public const string IPROPNAME_PRINTHOOD_FOLDER = "PrintHoodFolder";
    [NativeTypeName("#define IPROPNAME_ADMINTOOLS_FOLDER TEXT(\"AdminToolsFolder\")")]
    public const string IPROPNAME_ADMINTOOLS_FOLDER = "AdminToolsFolder";
    [NativeTypeName("#define IPROPNAME_COMMONAPPDATA_FOLDER TEXT(\"CommonAppDataFolder\")")]
    public const string IPROPNAME_COMMONAPPDATA_FOLDER = "CommonAppDataFolder";
    [NativeTypeName("#define IPROPNAME_LOCALAPPDATA_FOLDER TEXT(\"LocalAppDataFolder\")")]
    public const string IPROPNAME_LOCALAPPDATA_FOLDER = "LocalAppDataFolder";
    [NativeTypeName("#define IPROPNAME_MYPICTURES_FOLDER TEXT(\"MyPicturesFolder\")")]
    public const string IPROPNAME_MYPICTURES_FOLDER = "MyPicturesFolder";
    [NativeTypeName("#define IPROPNAME_FEATUREADDLOCAL TEXT(\"ADDLOCAL\")")]
    public const string IPROPNAME_FEATUREADDLOCAL = "ADDLOCAL";
    [NativeTypeName("#define IPROPNAME_FEATUREADDSOURCE TEXT(\"ADDSOURCE\")")]
    public const string IPROPNAME_FEATUREADDSOURCE = "ADDSOURCE";
    [NativeTypeName("#define IPROPNAME_FEATUREADDDEFAULT TEXT(\"ADDDEFAULT\")")]
    public const string IPROPNAME_FEATUREADDDEFAULT = "ADDDEFAULT";
    [NativeTypeName("#define IPROPNAME_FEATUREREMOVE TEXT(\"REMOVE\")")]
    public const string IPROPNAME_FEATUREREMOVE = "REMOVE";
    [NativeTypeName("#define IPROPNAME_FEATUREADVERTISE TEXT(\"ADVERTISE\")")]
    public const string IPROPNAME_FEATUREADVERTISE = "ADVERTISE";
    [NativeTypeName("#define IPROPNAME_COMPONENTADDLOCAL TEXT(\"COMPADDLOCAL\")")]
    public const string IPROPNAME_COMPONENTADDLOCAL = "COMPADDLOCAL";
    [NativeTypeName("#define IPROPNAME_COMPONENTADDSOURCE TEXT(\"COMPADDSOURCE\")")]
    public const string IPROPNAME_COMPONENTADDSOURCE = "COMPADDSOURCE";
    [NativeTypeName("#define IPROPNAME_COMPONENTADDDEFAULT TEXT(\"COMPADDDEFAULT\")")]
    public const string IPROPNAME_COMPONENTADDDEFAULT = "COMPADDDEFAULT";
    [NativeTypeName("#define IPROPNAME_FILEADDLOCAL TEXT(\"FILEADDLOCAL\")")]
    public const string IPROPNAME_FILEADDLOCAL = "FILEADDLOCAL";
    [NativeTypeName("#define IPROPNAME_FILEADDSOURCE TEXT(\"FILEADDSOURCE\")")]
    public const string IPROPNAME_FILEADDSOURCE = "FILEADDSOURCE";
    [NativeTypeName("#define IPROPNAME_FILEADDDEFAULT TEXT(\"FILEADDDEFAULT\")")]
    public const string IPROPNAME_FILEADDDEFAULT = "FILEADDDEFAULT";
    [NativeTypeName("#define IPROPNAME_REINSTALL TEXT(\"REINSTALL\")")]
    public const string IPROPNAME_REINSTALL = "REINSTALL";
    [NativeTypeName("#define IPROPNAME_REINSTALLMODE TEXT(\"REINSTALLMODE\")")]
    public const string IPROPNAME_REINSTALLMODE = "REINSTALLMODE";
    [NativeTypeName("#define IPROPNAME_PROMPTROLLBACKCOST TEXT(\"PROMPTROLLBACKCOST\")")]
    public const string IPROPNAME_PROMPTROLLBACKCOST = "PROMPTROLLBACKCOST";
    [NativeTypeName("#define IPROPNAME_CUSTOMACTIONDATA TEXT(\"CustomActionData\")")]
    public const string IPROPNAME_CUSTOMACTIONDATA = "CustomActionData";
}