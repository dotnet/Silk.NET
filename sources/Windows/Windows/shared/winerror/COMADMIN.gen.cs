// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class COMADMIN
{
    [NativeTypeName("#define COMADMIN_E_OBJECTERRORS _HRESULT_TYPEDEF_(0x80110401L)")]
    public const int COMADMIN_E_OBJECTERRORS = unchecked((int)(0x80110401));
    [NativeTypeName("#define COMADMIN_E_OBJECTINVALID _HRESULT_TYPEDEF_(0x80110402L)")]
    public const int COMADMIN_E_OBJECTINVALID = unchecked((int)(0x80110402));
    [NativeTypeName("#define COMADMIN_E_KEYMISSING _HRESULT_TYPEDEF_(0x80110403L)")]
    public const int COMADMIN_E_KEYMISSING = unchecked((int)(0x80110403));
    [NativeTypeName("#define COMADMIN_E_ALREADYINSTALLED _HRESULT_TYPEDEF_(0x80110404L)")]
    public const int COMADMIN_E_ALREADYINSTALLED = unchecked((int)(0x80110404));
    [NativeTypeName("#define COMADMIN_E_APP_FILE_WRITEFAIL _HRESULT_TYPEDEF_(0x80110407L)")]
    public const int COMADMIN_E_APP_FILE_WRITEFAIL = unchecked((int)(0x80110407));
    [NativeTypeName("#define COMADMIN_E_APP_FILE_READFAIL _HRESULT_TYPEDEF_(0x80110408L)")]
    public const int COMADMIN_E_APP_FILE_READFAIL = unchecked((int)(0x80110408));
    [NativeTypeName("#define COMADMIN_E_APP_FILE_VERSION _HRESULT_TYPEDEF_(0x80110409L)")]
    public const int COMADMIN_E_APP_FILE_VERSION = unchecked((int)(0x80110409));
    [NativeTypeName("#define COMADMIN_E_BADPATH _HRESULT_TYPEDEF_(0x8011040AL)")]
    public const int COMADMIN_E_BADPATH = unchecked((int)(0x8011040A));
    [NativeTypeName("#define COMADMIN_E_APPLICATIONEXISTS _HRESULT_TYPEDEF_(0x8011040BL)")]
    public const int COMADMIN_E_APPLICATIONEXISTS = unchecked((int)(0x8011040B));
    [NativeTypeName("#define COMADMIN_E_ROLEEXISTS _HRESULT_TYPEDEF_(0x8011040CL)")]
    public const int COMADMIN_E_ROLEEXISTS = unchecked((int)(0x8011040C));
    [NativeTypeName("#define COMADMIN_E_CANTCOPYFILE _HRESULT_TYPEDEF_(0x8011040DL)")]
    public const int COMADMIN_E_CANTCOPYFILE = unchecked((int)(0x8011040D));
    [NativeTypeName("#define COMADMIN_E_NOUSER _HRESULT_TYPEDEF_(0x8011040FL)")]
    public const int COMADMIN_E_NOUSER = unchecked((int)(0x8011040F));
    [NativeTypeName("#define COMADMIN_E_INVALIDUSERIDS _HRESULT_TYPEDEF_(0x80110410L)")]
    public const int COMADMIN_E_INVALIDUSERIDS = unchecked((int)(0x80110410));
    [NativeTypeName("#define COMADMIN_E_NOREGISTRYCLSID _HRESULT_TYPEDEF_(0x80110411L)")]
    public const int COMADMIN_E_NOREGISTRYCLSID = unchecked((int)(0x80110411));
    [NativeTypeName("#define COMADMIN_E_BADREGISTRYPROGID _HRESULT_TYPEDEF_(0x80110412L)")]
    public const int COMADMIN_E_BADREGISTRYPROGID = unchecked((int)(0x80110412));
    [NativeTypeName("#define COMADMIN_E_AUTHENTICATIONLEVEL _HRESULT_TYPEDEF_(0x80110413L)")]
    public const int COMADMIN_E_AUTHENTICATIONLEVEL = unchecked((int)(0x80110413));
    [NativeTypeName("#define COMADMIN_E_USERPASSWDNOTVALID _HRESULT_TYPEDEF_(0x80110414L)")]
    public const int COMADMIN_E_USERPASSWDNOTVALID = unchecked((int)(0x80110414));
    [NativeTypeName("#define COMADMIN_E_CLSIDORIIDMISMATCH _HRESULT_TYPEDEF_(0x80110418L)")]
    public const int COMADMIN_E_CLSIDORIIDMISMATCH = unchecked((int)(0x80110418));
    [NativeTypeName("#define COMADMIN_E_REMOTEINTERFACE _HRESULT_TYPEDEF_(0x80110419L)")]
    public const int COMADMIN_E_REMOTEINTERFACE = unchecked((int)(0x80110419));
    [NativeTypeName("#define COMADMIN_E_DLLREGISTERSERVER _HRESULT_TYPEDEF_(0x8011041AL)")]
    public const int COMADMIN_E_DLLREGISTERSERVER = unchecked((int)(0x8011041A));
    [NativeTypeName("#define COMADMIN_E_NOSERVERSHARE _HRESULT_TYPEDEF_(0x8011041BL)")]
    public const int COMADMIN_E_NOSERVERSHARE = unchecked((int)(0x8011041B));
    [NativeTypeName("#define COMADMIN_E_DLLLOADFAILED _HRESULT_TYPEDEF_(0x8011041DL)")]
    public const int COMADMIN_E_DLLLOADFAILED = unchecked((int)(0x8011041D));
    [NativeTypeName("#define COMADMIN_E_BADREGISTRYLIBID _HRESULT_TYPEDEF_(0x8011041EL)")]
    public const int COMADMIN_E_BADREGISTRYLIBID = unchecked((int)(0x8011041E));
    [NativeTypeName("#define COMADMIN_E_APPDIRNOTFOUND _HRESULT_TYPEDEF_(0x8011041FL)")]
    public const int COMADMIN_E_APPDIRNOTFOUND = unchecked((int)(0x8011041F));
    [NativeTypeName("#define COMADMIN_E_REGISTRARFAILED _HRESULT_TYPEDEF_(0x80110423L)")]
    public const int COMADMIN_E_REGISTRARFAILED = unchecked((int)(0x80110423));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_DOESNOTEXIST _HRESULT_TYPEDEF_(0x80110424L)")]
    public const int COMADMIN_E_COMPFILE_DOESNOTEXIST = unchecked((int)(0x80110424));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_LOADDLLFAIL _HRESULT_TYPEDEF_(0x80110425L)")]
    public const int COMADMIN_E_COMPFILE_LOADDLLFAIL = unchecked((int)(0x80110425));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_GETCLASSOBJ _HRESULT_TYPEDEF_(0x80110426L)")]
    public const int COMADMIN_E_COMPFILE_GETCLASSOBJ = unchecked((int)(0x80110426));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_CLASSNOTAVAIL _HRESULT_TYPEDEF_(0x80110427L)")]
    public const int COMADMIN_E_COMPFILE_CLASSNOTAVAIL = unchecked((int)(0x80110427));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_BADTLB _HRESULT_TYPEDEF_(0x80110428L)")]
    public const int COMADMIN_E_COMPFILE_BADTLB = unchecked((int)(0x80110428));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_NOTINSTALLABLE _HRESULT_TYPEDEF_(0x80110429L)")]
    public const int COMADMIN_E_COMPFILE_NOTINSTALLABLE = unchecked((int)(0x80110429));
    [NativeTypeName("#define COMADMIN_E_NOTCHANGEABLE _HRESULT_TYPEDEF_(0x8011042AL)")]
    public const int COMADMIN_E_NOTCHANGEABLE = unchecked((int)(0x8011042A));
    [NativeTypeName("#define COMADMIN_E_NOTDELETEABLE _HRESULT_TYPEDEF_(0x8011042BL)")]
    public const int COMADMIN_E_NOTDELETEABLE = unchecked((int)(0x8011042B));
    [NativeTypeName("#define COMADMIN_E_SESSION _HRESULT_TYPEDEF_(0x8011042CL)")]
    public const int COMADMIN_E_SESSION = unchecked((int)(0x8011042C));
    [NativeTypeName("#define COMADMIN_E_COMP_MOVE_LOCKED _HRESULT_TYPEDEF_(0x8011042DL)")]
    public const int COMADMIN_E_COMP_MOVE_LOCKED = unchecked((int)(0x8011042D));
    [NativeTypeName("#define COMADMIN_E_COMP_MOVE_BAD_DEST _HRESULT_TYPEDEF_(0x8011042EL)")]
    public const int COMADMIN_E_COMP_MOVE_BAD_DEST = unchecked((int)(0x8011042E));
    [NativeTypeName("#define COMADMIN_E_REGISTERTLB _HRESULT_TYPEDEF_(0x80110430L)")]
    public const int COMADMIN_E_REGISTERTLB = unchecked((int)(0x80110430));
    [NativeTypeName("#define COMADMIN_E_SYSTEMAPP _HRESULT_TYPEDEF_(0x80110433L)")]
    public const int COMADMIN_E_SYSTEMAPP = unchecked((int)(0x80110433));
    [NativeTypeName("#define COMADMIN_E_COMPFILE_NOREGISTRAR _HRESULT_TYPEDEF_(0x80110434L)")]
    public const int COMADMIN_E_COMPFILE_NOREGISTRAR = unchecked((int)(0x80110434));
    [NativeTypeName("#define COMADMIN_E_COREQCOMPINSTALLED _HRESULT_TYPEDEF_(0x80110435L)")]
    public const int COMADMIN_E_COREQCOMPINSTALLED = unchecked((int)(0x80110435));
    [NativeTypeName("#define COMADMIN_E_SERVICENOTINSTALLED _HRESULT_TYPEDEF_(0x80110436L)")]
    public const int COMADMIN_E_SERVICENOTINSTALLED = unchecked((int)(0x80110436));
    [NativeTypeName("#define COMADMIN_E_PROPERTYSAVEFAILED _HRESULT_TYPEDEF_(0x80110437L)")]
    public const int COMADMIN_E_PROPERTYSAVEFAILED = unchecked((int)(0x80110437));
    [NativeTypeName("#define COMADMIN_E_OBJECTEXISTS _HRESULT_TYPEDEF_(0x80110438L)")]
    public const int COMADMIN_E_OBJECTEXISTS = unchecked((int)(0x80110438));
    [NativeTypeName("#define COMADMIN_E_COMPONENTEXISTS _HRESULT_TYPEDEF_(0x80110439L)")]
    public const int COMADMIN_E_COMPONENTEXISTS = unchecked((int)(0x80110439));
    [NativeTypeName("#define COMADMIN_E_REGFILE_CORRUPT _HRESULT_TYPEDEF_(0x8011043BL)")]
    public const int COMADMIN_E_REGFILE_CORRUPT = unchecked((int)(0x8011043B));
    [NativeTypeName("#define COMADMIN_E_PROPERTY_OVERFLOW _HRESULT_TYPEDEF_(0x8011043CL)")]
    public const int COMADMIN_E_PROPERTY_OVERFLOW = unchecked((int)(0x8011043C));
    [NativeTypeName("#define COMADMIN_E_NOTINREGISTRY _HRESULT_TYPEDEF_(0x8011043EL)")]
    public const int COMADMIN_E_NOTINREGISTRY = unchecked((int)(0x8011043E));
    [NativeTypeName("#define COMADMIN_E_OBJECTNOTPOOLABLE _HRESULT_TYPEDEF_(0x8011043FL)")]
    public const int COMADMIN_E_OBJECTNOTPOOLABLE = unchecked((int)(0x8011043F));
    [NativeTypeName("#define COMADMIN_E_APPLID_MATCHES_CLSID _HRESULT_TYPEDEF_(0x80110446L)")]
    public const int COMADMIN_E_APPLID_MATCHES_CLSID = unchecked((int)(0x80110446));
    [NativeTypeName("#define COMADMIN_E_ROLE_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x80110447L)")]
    public const int COMADMIN_E_ROLE_DOES_NOT_EXIST = unchecked((int)(0x80110447));
    [NativeTypeName("#define COMADMIN_E_START_APP_NEEDS_COMPONENTS _HRESULT_TYPEDEF_(0x80110448L)")]
    public const int COMADMIN_E_START_APP_NEEDS_COMPONENTS = unchecked((int)(0x80110448));
    [NativeTypeName("#define COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM _HRESULT_TYPEDEF_(0x80110449L)")]
    public const int COMADMIN_E_REQUIRES_DIFFERENT_PLATFORM = unchecked((int)(0x80110449));
    [NativeTypeName("#define COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY _HRESULT_TYPEDEF_(0x8011044AL)")]
    public const int COMADMIN_E_CAN_NOT_EXPORT_APP_PROXY = unchecked((int)(0x8011044A));
    [NativeTypeName("#define COMADMIN_E_CAN_NOT_START_APP _HRESULT_TYPEDEF_(0x8011044BL)")]
    public const int COMADMIN_E_CAN_NOT_START_APP = unchecked((int)(0x8011044B));
    [NativeTypeName("#define COMADMIN_E_CAN_NOT_EXPORT_SYS_APP _HRESULT_TYPEDEF_(0x8011044CL)")]
    public const int COMADMIN_E_CAN_NOT_EXPORT_SYS_APP = unchecked((int)(0x8011044C));
    [NativeTypeName("#define COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT _HRESULT_TYPEDEF_(0x8011044DL)")]
    public const int COMADMIN_E_CANT_SUBSCRIBE_TO_COMPONENT = unchecked((int)(0x8011044D));
    [NativeTypeName("#define COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER _HRESULT_TYPEDEF_(0x8011044EL)")]
    public const int COMADMIN_E_EVENTCLASS_CANT_BE_SUBSCRIBER = unchecked((int)(0x8011044E));
    [NativeTypeName("#define COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE _HRESULT_TYPEDEF_(0x8011044FL)")]
    public const int COMADMIN_E_LIB_APP_PROXY_INCOMPATIBLE = unchecked((int)(0x8011044F));
    [NativeTypeName("#define COMADMIN_E_BASE_PARTITION_ONLY _HRESULT_TYPEDEF_(0x80110450L)")]
    public const int COMADMIN_E_BASE_PARTITION_ONLY = unchecked((int)(0x80110450));
    [NativeTypeName("#define COMADMIN_E_START_APP_DISABLED _HRESULT_TYPEDEF_(0x80110451L)")]
    public const int COMADMIN_E_START_APP_DISABLED = unchecked((int)(0x80110451));
    [NativeTypeName("#define COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME _HRESULT_TYPEDEF_(0x80110457L)")]
    public const int COMADMIN_E_CAT_DUPLICATE_PARTITION_NAME = unchecked((int)(0x80110457));
    [NativeTypeName("#define COMADMIN_E_CAT_INVALID_PARTITION_NAME _HRESULT_TYPEDEF_(0x80110458L)")]
    public const int COMADMIN_E_CAT_INVALID_PARTITION_NAME = unchecked((int)(0x80110458));
    [NativeTypeName("#define COMADMIN_E_CAT_PARTITION_IN_USE _HRESULT_TYPEDEF_(0x80110459L)")]
    public const int COMADMIN_E_CAT_PARTITION_IN_USE = unchecked((int)(0x80110459));
    [NativeTypeName("#define COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES _HRESULT_TYPEDEF_(0x8011045AL)")]
    public const int COMADMIN_E_FILE_PARTITION_DUPLICATE_FILES = unchecked((int)(0x8011045A));
    [NativeTypeName("#define COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8011045BL)")]
    public const int COMADMIN_E_CAT_IMPORTED_COMPONENTS_NOT_ALLOWED = unchecked((int)(0x8011045B));
    [NativeTypeName("#define COMADMIN_E_AMBIGUOUS_APPLICATION_NAME _HRESULT_TYPEDEF_(0x8011045CL)")]
    public const int COMADMIN_E_AMBIGUOUS_APPLICATION_NAME = unchecked((int)(0x8011045C));
    [NativeTypeName("#define COMADMIN_E_AMBIGUOUS_PARTITION_NAME _HRESULT_TYPEDEF_(0x8011045DL)")]
    public const int COMADMIN_E_AMBIGUOUS_PARTITION_NAME = unchecked((int)(0x8011045D));
    [NativeTypeName("#define COMADMIN_E_REGDB_NOTINITIALIZED _HRESULT_TYPEDEF_(0x80110472L)")]
    public const int COMADMIN_E_REGDB_NOTINITIALIZED = unchecked((int)(0x80110472));
    [NativeTypeName("#define COMADMIN_E_REGDB_NOTOPEN _HRESULT_TYPEDEF_(0x80110473L)")]
    public const int COMADMIN_E_REGDB_NOTOPEN = unchecked((int)(0x80110473));
    [NativeTypeName("#define COMADMIN_E_REGDB_SYSTEMERR _HRESULT_TYPEDEF_(0x80110474L)")]
    public const int COMADMIN_E_REGDB_SYSTEMERR = unchecked((int)(0x80110474));
    [NativeTypeName("#define COMADMIN_E_REGDB_ALREADYRUNNING _HRESULT_TYPEDEF_(0x80110475L)")]
    public const int COMADMIN_E_REGDB_ALREADYRUNNING = unchecked((int)(0x80110475));
    [NativeTypeName("#define COMADMIN_E_MIG_VERSIONNOTSUPPORTED _HRESULT_TYPEDEF_(0x80110480L)")]
    public const int COMADMIN_E_MIG_VERSIONNOTSUPPORTED = unchecked((int)(0x80110480));
    [NativeTypeName("#define COMADMIN_E_MIG_SCHEMANOTFOUND _HRESULT_TYPEDEF_(0x80110481L)")]
    public const int COMADMIN_E_MIG_SCHEMANOTFOUND = unchecked((int)(0x80110481));
    [NativeTypeName("#define COMADMIN_E_CAT_BITNESSMISMATCH _HRESULT_TYPEDEF_(0x80110482L)")]
    public const int COMADMIN_E_CAT_BITNESSMISMATCH = unchecked((int)(0x80110482));
    [NativeTypeName("#define COMADMIN_E_CAT_UNACCEPTABLEBITNESS _HRESULT_TYPEDEF_(0x80110483L)")]
    public const int COMADMIN_E_CAT_UNACCEPTABLEBITNESS = unchecked((int)(0x80110483));
    [NativeTypeName("#define COMADMIN_E_CAT_WRONGAPPBITNESS _HRESULT_TYPEDEF_(0x80110484L)")]
    public const int COMADMIN_E_CAT_WRONGAPPBITNESS = unchecked((int)(0x80110484));
    [NativeTypeName("#define COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80110485L)")]
    public const int COMADMIN_E_CAT_PAUSE_RESUME_NOT_SUPPORTED = unchecked((int)(0x80110485));
    [NativeTypeName("#define COMADMIN_E_CAT_SERVERFAULT _HRESULT_TYPEDEF_(0x80110486L)")]
    public const int COMADMIN_E_CAT_SERVERFAULT = unchecked((int)(0x80110486));
    [NativeTypeName("#define COMADMIN_E_OBJECT_PARENT_MISSING _HRESULT_TYPEDEF_(0x80110808L)")]
    public const int COMADMIN_E_OBJECT_PARENT_MISSING = unchecked((int)(0x80110808));
    [NativeTypeName("#define COMADMIN_E_OBJECT_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x80110809L)")]
    public const int COMADMIN_E_OBJECT_DOES_NOT_EXIST = unchecked((int)(0x80110809));
    [NativeTypeName("#define COMADMIN_E_APP_NOT_RUNNING _HRESULT_TYPEDEF_(0x8011080AL)")]
    public const int COMADMIN_E_APP_NOT_RUNNING = unchecked((int)(0x8011080A));
    [NativeTypeName("#define COMADMIN_E_INVALID_PARTITION _HRESULT_TYPEDEF_(0x8011080BL)")]
    public const int COMADMIN_E_INVALID_PARTITION = unchecked((int)(0x8011080B));
    [NativeTypeName("#define COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE _HRESULT_TYPEDEF_(0x8011080DL)")]
    public const int COMADMIN_E_SVCAPP_NOT_POOLABLE_OR_RECYCLABLE = unchecked((int)(0x8011080D));
    [NativeTypeName("#define COMADMIN_E_USER_IN_SET _HRESULT_TYPEDEF_(0x8011080EL)")]
    public const int COMADMIN_E_USER_IN_SET = unchecked((int)(0x8011080E));
    [NativeTypeName("#define COMADMIN_E_CANTRECYCLELIBRARYAPPS _HRESULT_TYPEDEF_(0x8011080FL)")]
    public const int COMADMIN_E_CANTRECYCLELIBRARYAPPS = unchecked((int)(0x8011080F));
    [NativeTypeName("#define COMADMIN_E_CANTRECYCLESERVICEAPPS _HRESULT_TYPEDEF_(0x80110811L)")]
    public const int COMADMIN_E_CANTRECYCLESERVICEAPPS = unchecked((int)(0x80110811));
    [NativeTypeName("#define COMADMIN_E_PROCESSALREADYRECYCLED _HRESULT_TYPEDEF_(0x80110812L)")]
    public const int COMADMIN_E_PROCESSALREADYRECYCLED = unchecked((int)(0x80110812));
    [NativeTypeName("#define COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED _HRESULT_TYPEDEF_(0x80110813L)")]
    public const int COMADMIN_E_PAUSEDPROCESSMAYNOTBERECYCLED = unchecked((int)(0x80110813));
    [NativeTypeName("#define COMADMIN_E_CANTMAKEINPROCSERVICE _HRESULT_TYPEDEF_(0x80110814L)")]
    public const int COMADMIN_E_CANTMAKEINPROCSERVICE = unchecked((int)(0x80110814));
    [NativeTypeName("#define COMADMIN_E_PROGIDINUSEBYCLSID _HRESULT_TYPEDEF_(0x80110815L)")]
    public const int COMADMIN_E_PROGIDINUSEBYCLSID = unchecked((int)(0x80110815));
    [NativeTypeName("#define COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET _HRESULT_TYPEDEF_(0x80110816L)")]
    public const int COMADMIN_E_DEFAULT_PARTITION_NOT_IN_SET = unchecked((int)(0x80110816));
    [NativeTypeName("#define COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED _HRESULT_TYPEDEF_(0x80110817L)")]
    public const int COMADMIN_E_RECYCLEDPROCESSMAYNOTBEPAUSED = unchecked((int)(0x80110817));
    [NativeTypeName("#define COMADMIN_E_PARTITION_ACCESSDENIED _HRESULT_TYPEDEF_(0x80110818L)")]
    public const int COMADMIN_E_PARTITION_ACCESSDENIED = unchecked((int)(0x80110818));
    [NativeTypeName("#define COMADMIN_E_PARTITION_MSI_ONLY _HRESULT_TYPEDEF_(0x80110819L)")]
    public const int COMADMIN_E_PARTITION_MSI_ONLY = unchecked((int)(0x80110819));
    [NativeTypeName("#define COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT _HRESULT_TYPEDEF_(0x8011081AL)")]
    public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_1_0_FORMAT = unchecked((int)(0x8011081A));
    [NativeTypeName("#define COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS _HRESULT_TYPEDEF_(0x8011081BL)")]
    public const int COMADMIN_E_LEGACYCOMPS_NOT_ALLOWED_IN_NONBASE_PARTITIONS = unchecked((int)(0x8011081B));
    [NativeTypeName("#define COMADMIN_E_COMP_MOVE_SOURCE _HRESULT_TYPEDEF_(0x8011081CL)")]
    public const int COMADMIN_E_COMP_MOVE_SOURCE = unchecked((int)(0x8011081C));
    [NativeTypeName("#define COMADMIN_E_COMP_MOVE_DEST _HRESULT_TYPEDEF_(0x8011081DL)")]
    public const int COMADMIN_E_COMP_MOVE_DEST = unchecked((int)(0x8011081D));
    [NativeTypeName("#define COMADMIN_E_COMP_MOVE_PRIVATE _HRESULT_TYPEDEF_(0x8011081EL)")]
    public const int COMADMIN_E_COMP_MOVE_PRIVATE = unchecked((int)(0x8011081E));
    [NativeTypeName("#define COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET _HRESULT_TYPEDEF_(0x8011081FL)")]
    public const int COMADMIN_E_BASEPARTITION_REQUIRED_IN_SET = unchecked((int)(0x8011081F));
    [NativeTypeName("#define COMADMIN_E_CANNOT_ALIAS_EVENTCLASS _HRESULT_TYPEDEF_(0x80110820L)")]
    public const int COMADMIN_E_CANNOT_ALIAS_EVENTCLASS = unchecked((int)(0x80110820));
    [NativeTypeName("#define COMADMIN_E_PRIVATE_ACCESSDENIED _HRESULT_TYPEDEF_(0x80110821L)")]
    public const int COMADMIN_E_PRIVATE_ACCESSDENIED = unchecked((int)(0x80110821));
    [NativeTypeName("#define COMADMIN_E_SAFERINVALID _HRESULT_TYPEDEF_(0x80110822L)")]
    public const int COMADMIN_E_SAFERINVALID = unchecked((int)(0x80110822));
    [NativeTypeName("#define COMADMIN_E_REGISTRY_ACCESSDENIED _HRESULT_TYPEDEF_(0x80110823L)")]
    public const int COMADMIN_E_REGISTRY_ACCESSDENIED = unchecked((int)(0x80110823));
    [NativeTypeName("#define COMADMIN_E_PARTITIONS_DISABLED _HRESULT_TYPEDEF_(0x80110824L)")]
    public const int COMADMIN_E_PARTITIONS_DISABLED = unchecked((int)(0x80110824));
}