// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class INSTALLPROPERTY
{
    [NativeTypeName("#define INSTALLPROPERTY_PACKAGENAME __TEXT(\"PackageName\")")]
    public const string INSTALLPROPERTY_PACKAGENAME = "PackageName";

    [NativeTypeName("#define INSTALLPROPERTY_TRANSFORMS __TEXT(\"Transforms\")")]
    public const string INSTALLPROPERTY_TRANSFORMS = "Transforms";

    [NativeTypeName("#define INSTALLPROPERTY_LANGUAGE __TEXT(\"Language\")")]
    public const string INSTALLPROPERTY_LANGUAGE = "Language";

    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTNAME __TEXT(\"ProductName\")")]
    public const string INSTALLPROPERTY_PRODUCTNAME = "ProductName";

    [NativeTypeName("#define INSTALLPROPERTY_ASSIGNMENTTYPE __TEXT(\"AssignmentType\")")]
    public const string INSTALLPROPERTY_ASSIGNMENTTYPE = "AssignmentType";

    [NativeTypeName("#define INSTALLPROPERTY_INSTANCETYPE __TEXT(\"InstanceType\")")]
    public const string INSTALLPROPERTY_INSTANCETYPE = "InstanceType";

    [NativeTypeName("#define INSTALLPROPERTY_AUTHORIZED_LUA_APP __TEXT(\"AuthorizedLUAApp\")")]
    public const string INSTALLPROPERTY_AUTHORIZED_LUA_APP = "AuthorizedLUAApp";

    [NativeTypeName("#define INSTALLPROPERTY_PACKAGECODE __TEXT(\"PackageCode\")")]
    public const string INSTALLPROPERTY_PACKAGECODE = "PackageCode";

    [NativeTypeName("#define INSTALLPROPERTY_VERSION __TEXT(\"Version\")")]
    public const string INSTALLPROPERTY_VERSION = "Version";

    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTICON __TEXT(\"ProductIcon\")")]
    public const string INSTALLPROPERTY_PRODUCTICON = "ProductIcon";

    [NativeTypeName("#define INSTALLPROPERTY_INSTALLEDPRODUCTNAME __TEXT(\"InstalledProductName\")")]
    public const string INSTALLPROPERTY_INSTALLEDPRODUCTNAME = "InstalledProductName";

    [NativeTypeName("#define INSTALLPROPERTY_VERSIONSTRING __TEXT(\"VersionString\")")]
    public const string INSTALLPROPERTY_VERSIONSTRING = "VersionString";

    [NativeTypeName("#define INSTALLPROPERTY_HELPLINK __TEXT(\"HelpLink\")")]
    public const string INSTALLPROPERTY_HELPLINK = "HelpLink";

    [NativeTypeName("#define INSTALLPROPERTY_HELPTELEPHONE __TEXT(\"HelpTelephone\")")]
    public const string INSTALLPROPERTY_HELPTELEPHONE = "HelpTelephone";

    [NativeTypeName("#define INSTALLPROPERTY_INSTALLLOCATION __TEXT(\"InstallLocation\")")]
    public const string INSTALLPROPERTY_INSTALLLOCATION = "InstallLocation";

    [NativeTypeName("#define INSTALLPROPERTY_INSTALLSOURCE __TEXT(\"InstallSource\")")]
    public const string INSTALLPROPERTY_INSTALLSOURCE = "InstallSource";

    [NativeTypeName("#define INSTALLPROPERTY_INSTALLDATE __TEXT(\"InstallDate\")")]
    public const string INSTALLPROPERTY_INSTALLDATE = "InstallDate";

    [NativeTypeName("#define INSTALLPROPERTY_PUBLISHER __TEXT(\"Publisher\")")]
    public const string INSTALLPROPERTY_PUBLISHER = "Publisher";

    [NativeTypeName("#define INSTALLPROPERTY_LOCALPACKAGE __TEXT(\"LocalPackage\")")]
    public const string INSTALLPROPERTY_LOCALPACKAGE = "LocalPackage";

    [NativeTypeName("#define INSTALLPROPERTY_URLINFOABOUT __TEXT(\"URLInfoAbout\")")]
    public const string INSTALLPROPERTY_URLINFOABOUT = "URLInfoAbout";

    [NativeTypeName("#define INSTALLPROPERTY_URLUPDATEINFO __TEXT(\"URLUpdateInfo\")")]
    public const string INSTALLPROPERTY_URLUPDATEINFO = "URLUpdateInfo";

    [NativeTypeName("#define INSTALLPROPERTY_VERSIONMINOR __TEXT(\"VersionMinor\")")]
    public const string INSTALLPROPERTY_VERSIONMINOR = "VersionMinor";

    [NativeTypeName("#define INSTALLPROPERTY_VERSIONMAJOR __TEXT(\"VersionMajor\")")]
    public const string INSTALLPROPERTY_VERSIONMAJOR = "VersionMajor";

    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTID __TEXT(\"ProductID\")")]
    public const string INSTALLPROPERTY_PRODUCTID = "ProductID";

    [NativeTypeName("#define INSTALLPROPERTY_REGCOMPANY __TEXT(\"RegCompany\")")]
    public const string INSTALLPROPERTY_REGCOMPANY = "RegCompany";

    [NativeTypeName("#define INSTALLPROPERTY_REGOWNER __TEXT(\"RegOwner\")")]
    public const string INSTALLPROPERTY_REGOWNER = "RegOwner";

    [NativeTypeName("#define INSTALLPROPERTY_INSTALLEDLANGUAGE __TEXT(\"InstalledLanguage\")")]
    public const string INSTALLPROPERTY_INSTALLEDLANGUAGE = "InstalledLanguage";

    [NativeTypeName("#define INSTALLPROPERTY_UNINSTALLABLE __TEXT(\"Uninstallable\")")]
    public const string INSTALLPROPERTY_UNINSTALLABLE = "Uninstallable";

    [NativeTypeName("#define INSTALLPROPERTY_PRODUCTSTATE __TEXT(\"State\")")]
    public const string INSTALLPROPERTY_PRODUCTSTATE = "State";

    [NativeTypeName("#define INSTALLPROPERTY_PATCHSTATE __TEXT(\"State\")")]
    public const string INSTALLPROPERTY_PATCHSTATE = "State";

    [NativeTypeName("#define INSTALLPROPERTY_PATCHTYPE __TEXT(\"PatchType\")")]
    public const string INSTALLPROPERTY_PATCHTYPE = "PatchType";

    [NativeTypeName("#define INSTALLPROPERTY_LUAENABLED __TEXT(\"LUAEnabled\")")]
    public const string INSTALLPROPERTY_LUAENABLED = "LUAEnabled";

    [NativeTypeName("#define INSTALLPROPERTY_DISPLAYNAME __TEXT(\"DisplayName\")")]
    public const string INSTALLPROPERTY_DISPLAYNAME = "DisplayName";

    [NativeTypeName("#define INSTALLPROPERTY_MOREINFOURL __TEXT(\"MoreInfoURL\")")]
    public const string INSTALLPROPERTY_MOREINFOURL = "MoreInfoURL";

    [NativeTypeName("#define INSTALLPROPERTY_LASTUSEDSOURCE __TEXT(\"LastUsedSource\")")]
    public const string INSTALLPROPERTY_LASTUSEDSOURCE = "LastUsedSource";

    [NativeTypeName("#define INSTALLPROPERTY_LASTUSEDTYPE __TEXT(\"LastUsedType\")")]
    public const string INSTALLPROPERTY_LASTUSEDTYPE = "LastUsedType";

    [NativeTypeName("#define INSTALLPROPERTY_MEDIAPACKAGEPATH __TEXT(\"MediaPackagePath\")")]
    public const string INSTALLPROPERTY_MEDIAPACKAGEPATH = "MediaPackagePath";

    [NativeTypeName("#define INSTALLPROPERTY_DISKPROMPT __TEXT(\"DiskPrompt\")")]
    public const string INSTALLPROPERTY_DISKPROMPT = "DiskPrompt";
}
