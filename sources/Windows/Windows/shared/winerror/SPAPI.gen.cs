// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SPAPI
{
    [NativeTypeName("#define SPAPI_E_EXPECTED_SECTION_NAME _HRESULT_TYPEDEF_(0x800F0000L)")]
    public const int SPAPI_E_EXPECTED_SECTION_NAME = unchecked((int)(0x800F0000));

    [NativeTypeName("#define SPAPI_E_BAD_SECTION_NAME_LINE _HRESULT_TYPEDEF_(0x800F0001L)")]
    public const int SPAPI_E_BAD_SECTION_NAME_LINE = unchecked((int)(0x800F0001));

    [NativeTypeName("#define SPAPI_E_SECTION_NAME_TOO_LONG _HRESULT_TYPEDEF_(0x800F0002L)")]
    public const int SPAPI_E_SECTION_NAME_TOO_LONG = unchecked((int)(0x800F0002));

    [NativeTypeName("#define SPAPI_E_GENERAL_SYNTAX _HRESULT_TYPEDEF_(0x800F0003L)")]
    public const int SPAPI_E_GENERAL_SYNTAX = unchecked((int)(0x800F0003));

    [NativeTypeName("#define SPAPI_E_WRONG_INF_STYLE _HRESULT_TYPEDEF_(0x800F0100L)")]
    public const int SPAPI_E_WRONG_INF_STYLE = unchecked((int)(0x800F0100));

    [NativeTypeName("#define SPAPI_E_SECTION_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0101L)")]
    public const int SPAPI_E_SECTION_NOT_FOUND = unchecked((int)(0x800F0101));

    [NativeTypeName("#define SPAPI_E_LINE_NOT_FOUND _HRESULT_TYPEDEF_(0x800F0102L)")]
    public const int SPAPI_E_LINE_NOT_FOUND = unchecked((int)(0x800F0102));

    [NativeTypeName("#define SPAPI_E_NO_BACKUP _HRESULT_TYPEDEF_(0x800F0103L)")]
    public const int SPAPI_E_NO_BACKUP = unchecked((int)(0x800F0103));

    [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_CLASS _HRESULT_TYPEDEF_(0x800F0200L)")]
    public const int SPAPI_E_NO_ASSOCIATED_CLASS = unchecked((int)(0x800F0200));

    [NativeTypeName("#define SPAPI_E_CLASS_MISMATCH _HRESULT_TYPEDEF_(0x800F0201L)")]
    public const int SPAPI_E_CLASS_MISMATCH = unchecked((int)(0x800F0201));

    [NativeTypeName("#define SPAPI_E_DUPLICATE_FOUND _HRESULT_TYPEDEF_(0x800F0202L)")]
    public const int SPAPI_E_DUPLICATE_FOUND = unchecked((int)(0x800F0202));

    [NativeTypeName("#define SPAPI_E_NO_DRIVER_SELECTED _HRESULT_TYPEDEF_(0x800F0203L)")]
    public const int SPAPI_E_NO_DRIVER_SELECTED = unchecked((int)(0x800F0203));

    [NativeTypeName("#define SPAPI_E_KEY_DOES_NOT_EXIST _HRESULT_TYPEDEF_(0x800F0204L)")]
    public const int SPAPI_E_KEY_DOES_NOT_EXIST = unchecked((int)(0x800F0204));

    [NativeTypeName("#define SPAPI_E_INVALID_DEVINST_NAME _HRESULT_TYPEDEF_(0x800F0205L)")]
    public const int SPAPI_E_INVALID_DEVINST_NAME = unchecked((int)(0x800F0205));

    [NativeTypeName("#define SPAPI_E_INVALID_CLASS _HRESULT_TYPEDEF_(0x800F0206L)")]
    public const int SPAPI_E_INVALID_CLASS = unchecked((int)(0x800F0206));

    [NativeTypeName("#define SPAPI_E_DEVINST_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x800F0207L)")]
    public const int SPAPI_E_DEVINST_ALREADY_EXISTS = unchecked((int)(0x800F0207));

    [NativeTypeName("#define SPAPI_E_DEVINFO_NOT_REGISTERED _HRESULT_TYPEDEF_(0x800F0208L)")]
    public const int SPAPI_E_DEVINFO_NOT_REGISTERED = unchecked((int)(0x800F0208));

    [NativeTypeName("#define SPAPI_E_INVALID_REG_PROPERTY _HRESULT_TYPEDEF_(0x800F0209L)")]
    public const int SPAPI_E_INVALID_REG_PROPERTY = unchecked((int)(0x800F0209));

    [NativeTypeName("#define SPAPI_E_NO_INF _HRESULT_TYPEDEF_(0x800F020AL)")]
    public const int SPAPI_E_NO_INF = unchecked((int)(0x800F020A));

    [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVINST _HRESULT_TYPEDEF_(0x800F020BL)")]
    public const int SPAPI_E_NO_SUCH_DEVINST = unchecked((int)(0x800F020B));

    [NativeTypeName("#define SPAPI_E_CANT_LOAD_CLASS_ICON _HRESULT_TYPEDEF_(0x800F020CL)")]
    public const int SPAPI_E_CANT_LOAD_CLASS_ICON = unchecked((int)(0x800F020C));

    [NativeTypeName("#define SPAPI_E_INVALID_CLASS_INSTALLER _HRESULT_TYPEDEF_(0x800F020DL)")]
    public const int SPAPI_E_INVALID_CLASS_INSTALLER = unchecked((int)(0x800F020D));

    [NativeTypeName("#define SPAPI_E_DI_DO_DEFAULT _HRESULT_TYPEDEF_(0x800F020EL)")]
    public const int SPAPI_E_DI_DO_DEFAULT = unchecked((int)(0x800F020E));

    [NativeTypeName("#define SPAPI_E_DI_NOFILECOPY _HRESULT_TYPEDEF_(0x800F020FL)")]
    public const int SPAPI_E_DI_NOFILECOPY = unchecked((int)(0x800F020F));

    [NativeTypeName("#define SPAPI_E_INVALID_HWPROFILE _HRESULT_TYPEDEF_(0x800F0210L)")]
    public const int SPAPI_E_INVALID_HWPROFILE = unchecked((int)(0x800F0210));

    [NativeTypeName("#define SPAPI_E_NO_DEVICE_SELECTED _HRESULT_TYPEDEF_(0x800F0211L)")]
    public const int SPAPI_E_NO_DEVICE_SELECTED = unchecked((int)(0x800F0211));

    [NativeTypeName("#define SPAPI_E_DEVINFO_LIST_LOCKED _HRESULT_TYPEDEF_(0x800F0212L)")]
    public const int SPAPI_E_DEVINFO_LIST_LOCKED = unchecked((int)(0x800F0212));

    [NativeTypeName("#define SPAPI_E_DEVINFO_DATA_LOCKED _HRESULT_TYPEDEF_(0x800F0213L)")]
    public const int SPAPI_E_DEVINFO_DATA_LOCKED = unchecked((int)(0x800F0213));

    [NativeTypeName("#define SPAPI_E_DI_BAD_PATH _HRESULT_TYPEDEF_(0x800F0214L)")]
    public const int SPAPI_E_DI_BAD_PATH = unchecked((int)(0x800F0214));

    [NativeTypeName("#define SPAPI_E_NO_CLASSINSTALL_PARAMS _HRESULT_TYPEDEF_(0x800F0215L)")]
    public const int SPAPI_E_NO_CLASSINSTALL_PARAMS = unchecked((int)(0x800F0215));

    [NativeTypeName("#define SPAPI_E_FILEQUEUE_LOCKED _HRESULT_TYPEDEF_(0x800F0216L)")]
    public const int SPAPI_E_FILEQUEUE_LOCKED = unchecked((int)(0x800F0216));

    [NativeTypeName("#define SPAPI_E_BAD_SERVICE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F0217L)")]
    public const int SPAPI_E_BAD_SERVICE_INSTALLSECT = unchecked((int)(0x800F0217));

    [NativeTypeName("#define SPAPI_E_NO_CLASS_DRIVER_LIST _HRESULT_TYPEDEF_(0x800F0218L)")]
    public const int SPAPI_E_NO_CLASS_DRIVER_LIST = unchecked((int)(0x800F0218));

    [NativeTypeName("#define SPAPI_E_NO_ASSOCIATED_SERVICE _HRESULT_TYPEDEF_(0x800F0219L)")]
    public const int SPAPI_E_NO_ASSOCIATED_SERVICE = unchecked((int)(0x800F0219));

    [NativeTypeName("#define SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F021AL)")]
    public const int SPAPI_E_NO_DEFAULT_DEVICE_INTERFACE = unchecked((int)(0x800F021A));

    [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_ACTIVE _HRESULT_TYPEDEF_(0x800F021BL)")]
    public const int SPAPI_E_DEVICE_INTERFACE_ACTIVE = unchecked((int)(0x800F021B));

    [NativeTypeName("#define SPAPI_E_DEVICE_INTERFACE_REMOVED _HRESULT_TYPEDEF_(0x800F021CL)")]
    public const int SPAPI_E_DEVICE_INTERFACE_REMOVED = unchecked((int)(0x800F021C));

    [NativeTypeName("#define SPAPI_E_BAD_INTERFACE_INSTALLSECT _HRESULT_TYPEDEF_(0x800F021DL)")]
    public const int SPAPI_E_BAD_INTERFACE_INSTALLSECT = unchecked((int)(0x800F021D));

    [NativeTypeName("#define SPAPI_E_NO_SUCH_INTERFACE_CLASS _HRESULT_TYPEDEF_(0x800F021EL)")]
    public const int SPAPI_E_NO_SUCH_INTERFACE_CLASS = unchecked((int)(0x800F021E));

    [NativeTypeName("#define SPAPI_E_INVALID_REFERENCE_STRING _HRESULT_TYPEDEF_(0x800F021FL)")]
    public const int SPAPI_E_INVALID_REFERENCE_STRING = unchecked((int)(0x800F021F));

    [NativeTypeName("#define SPAPI_E_INVALID_MACHINENAME _HRESULT_TYPEDEF_(0x800F0220L)")]
    public const int SPAPI_E_INVALID_MACHINENAME = unchecked((int)(0x800F0220));

    [NativeTypeName("#define SPAPI_E_REMOTE_COMM_FAILURE _HRESULT_TYPEDEF_(0x800F0221L)")]
    public const int SPAPI_E_REMOTE_COMM_FAILURE = unchecked((int)(0x800F0221));

    [NativeTypeName("#define SPAPI_E_MACHINE_UNAVAILABLE _HRESULT_TYPEDEF_(0x800F0222L)")]
    public const int SPAPI_E_MACHINE_UNAVAILABLE = unchecked((int)(0x800F0222));

    [NativeTypeName("#define SPAPI_E_NO_CONFIGMGR_SERVICES _HRESULT_TYPEDEF_(0x800F0223L)")]
    public const int SPAPI_E_NO_CONFIGMGR_SERVICES = unchecked((int)(0x800F0223));

    [NativeTypeName("#define SPAPI_E_INVALID_PROPPAGE_PROVIDER _HRESULT_TYPEDEF_(0x800F0224L)")]
    public const int SPAPI_E_INVALID_PROPPAGE_PROVIDER = unchecked((int)(0x800F0224));

    [NativeTypeName("#define SPAPI_E_NO_SUCH_DEVICE_INTERFACE _HRESULT_TYPEDEF_(0x800F0225L)")]
    public const int SPAPI_E_NO_SUCH_DEVICE_INTERFACE = unchecked((int)(0x800F0225));

    [NativeTypeName("#define SPAPI_E_DI_POSTPROCESSING_REQUIRED _HRESULT_TYPEDEF_(0x800F0226L)")]
    public const int SPAPI_E_DI_POSTPROCESSING_REQUIRED = unchecked((int)(0x800F0226));

    [NativeTypeName("#define SPAPI_E_INVALID_COINSTALLER _HRESULT_TYPEDEF_(0x800F0227L)")]
    public const int SPAPI_E_INVALID_COINSTALLER = unchecked((int)(0x800F0227));

    [NativeTypeName("#define SPAPI_E_NO_COMPAT_DRIVERS _HRESULT_TYPEDEF_(0x800F0228L)")]
    public const int SPAPI_E_NO_COMPAT_DRIVERS = unchecked((int)(0x800F0228));

    [NativeTypeName("#define SPAPI_E_NO_DEVICE_ICON _HRESULT_TYPEDEF_(0x800F0229L)")]
    public const int SPAPI_E_NO_DEVICE_ICON = unchecked((int)(0x800F0229));

    [NativeTypeName("#define SPAPI_E_INVALID_INF_LOGCONFIG _HRESULT_TYPEDEF_(0x800F022AL)")]
    public const int SPAPI_E_INVALID_INF_LOGCONFIG = unchecked((int)(0x800F022A));

    [NativeTypeName("#define SPAPI_E_DI_DONT_INSTALL _HRESULT_TYPEDEF_(0x800F022BL)")]
    public const int SPAPI_E_DI_DONT_INSTALL = unchecked((int)(0x800F022B));

    [NativeTypeName("#define SPAPI_E_INVALID_FILTER_DRIVER _HRESULT_TYPEDEF_(0x800F022CL)")]
    public const int SPAPI_E_INVALID_FILTER_DRIVER = unchecked((int)(0x800F022C));

    [NativeTypeName("#define SPAPI_E_NON_WINDOWS_NT_DRIVER _HRESULT_TYPEDEF_(0x800F022DL)")]
    public const int SPAPI_E_NON_WINDOWS_NT_DRIVER = unchecked((int)(0x800F022D));

    [NativeTypeName("#define SPAPI_E_NON_WINDOWS_DRIVER _HRESULT_TYPEDEF_(0x800F022EL)")]
    public const int SPAPI_E_NON_WINDOWS_DRIVER = unchecked((int)(0x800F022E));

    [NativeTypeName("#define SPAPI_E_NO_CATALOG_FOR_OEM_INF _HRESULT_TYPEDEF_(0x800F022FL)")]
    public const int SPAPI_E_NO_CATALOG_FOR_OEM_INF = unchecked((int)(0x800F022F));

    [NativeTypeName("#define SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE _HRESULT_TYPEDEF_(0x800F0230L)")]
    public const int SPAPI_E_DEVINSTALL_QUEUE_NONNATIVE = unchecked((int)(0x800F0230));

    [NativeTypeName("#define SPAPI_E_NOT_DISABLEABLE _HRESULT_TYPEDEF_(0x800F0231L)")]
    public const int SPAPI_E_NOT_DISABLEABLE = unchecked((int)(0x800F0231));

    [NativeTypeName("#define SPAPI_E_CANT_REMOVE_DEVINST _HRESULT_TYPEDEF_(0x800F0232L)")]
    public const int SPAPI_E_CANT_REMOVE_DEVINST = unchecked((int)(0x800F0232));

    [NativeTypeName("#define SPAPI_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x800F0233L)")]
    public const int SPAPI_E_INVALID_TARGET = unchecked((int)(0x800F0233));

    [NativeTypeName("#define SPAPI_E_DRIVER_NONNATIVE _HRESULT_TYPEDEF_(0x800F0234L)")]
    public const int SPAPI_E_DRIVER_NONNATIVE = unchecked((int)(0x800F0234));

    [NativeTypeName("#define SPAPI_E_IN_WOW64 _HRESULT_TYPEDEF_(0x800F0235L)")]
    public const int SPAPI_E_IN_WOW64 = unchecked((int)(0x800F0235));

    [NativeTypeName("#define SPAPI_E_SET_SYSTEM_RESTORE_POINT _HRESULT_TYPEDEF_(0x800F0236L)")]
    public const int SPAPI_E_SET_SYSTEM_RESTORE_POINT = unchecked((int)(0x800F0236));

    [NativeTypeName("#define SPAPI_E_INCORRECTLY_COPIED_INF _HRESULT_TYPEDEF_(0x800F0237L)")]
    public const int SPAPI_E_INCORRECTLY_COPIED_INF = unchecked((int)(0x800F0237));

    [NativeTypeName("#define SPAPI_E_SCE_DISABLED _HRESULT_TYPEDEF_(0x800F0238L)")]
    public const int SPAPI_E_SCE_DISABLED = unchecked((int)(0x800F0238));

    [NativeTypeName("#define SPAPI_E_UNKNOWN_EXCEPTION _HRESULT_TYPEDEF_(0x800F0239L)")]
    public const int SPAPI_E_UNKNOWN_EXCEPTION = unchecked((int)(0x800F0239));

    [NativeTypeName("#define SPAPI_E_PNP_REGISTRY_ERROR _HRESULT_TYPEDEF_(0x800F023AL)")]
    public const int SPAPI_E_PNP_REGISTRY_ERROR = unchecked((int)(0x800F023A));

    [NativeTypeName("#define SPAPI_E_REMOTE_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x800F023BL)")]
    public const int SPAPI_E_REMOTE_REQUEST_UNSUPPORTED = unchecked((int)(0x800F023B));

    [NativeTypeName("#define SPAPI_E_NOT_AN_INSTALLED_OEM_INF _HRESULT_TYPEDEF_(0x800F023CL)")]
    public const int SPAPI_E_NOT_AN_INSTALLED_OEM_INF = unchecked((int)(0x800F023C));

    [NativeTypeName("#define SPAPI_E_INF_IN_USE_BY_DEVICES _HRESULT_TYPEDEF_(0x800F023DL)")]
    public const int SPAPI_E_INF_IN_USE_BY_DEVICES = unchecked((int)(0x800F023D));

    [NativeTypeName("#define SPAPI_E_DI_FUNCTION_OBSOLETE _HRESULT_TYPEDEF_(0x800F023EL)")]
    public const int SPAPI_E_DI_FUNCTION_OBSOLETE = unchecked((int)(0x800F023E));

    [NativeTypeName("#define SPAPI_E_NO_AUTHENTICODE_CATALOG _HRESULT_TYPEDEF_(0x800F023FL)")]
    public const int SPAPI_E_NO_AUTHENTICODE_CATALOG = unchecked((int)(0x800F023F));

    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_DISALLOWED _HRESULT_TYPEDEF_(0x800F0240L)")]
    public const int SPAPI_E_AUTHENTICODE_DISALLOWED = unchecked((int)(0x800F0240));

    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER _HRESULT_TYPEDEF_(0x800F0241L)")]
    public const int SPAPI_E_AUTHENTICODE_TRUSTED_PUBLISHER = unchecked((int)(0x800F0241));

    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED _HRESULT_TYPEDEF_(0x800F0242L)")]
    public const int SPAPI_E_AUTHENTICODE_TRUST_NOT_ESTABLISHED = unchecked((int)(0x800F0242));

    [NativeTypeName("#define SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED _HRESULT_TYPEDEF_(0x800F0243L)")]
    public const int SPAPI_E_AUTHENTICODE_PUBLISHER_NOT_TRUSTED = unchecked((int)(0x800F0243));

    [NativeTypeName("#define SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH _HRESULT_TYPEDEF_(0x800F0244L)")]
    public const int SPAPI_E_SIGNATURE_OSATTRIBUTE_MISMATCH = unchecked((int)(0x800F0244));

    [NativeTypeName("#define SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE _HRESULT_TYPEDEF_(0x800F0245L)")]
    public const int SPAPI_E_ONLY_VALIDATE_VIA_AUTHENTICODE = unchecked((int)(0x800F0245));

    [NativeTypeName("#define SPAPI_E_DEVICE_INSTALLER_NOT_READY _HRESULT_TYPEDEF_(0x800F0246L)")]
    public const int SPAPI_E_DEVICE_INSTALLER_NOT_READY = unchecked((int)(0x800F0246));

    [NativeTypeName("#define SPAPI_E_DRIVER_STORE_ADD_FAILED _HRESULT_TYPEDEF_(0x800F0247L)")]
    public const int SPAPI_E_DRIVER_STORE_ADD_FAILED = unchecked((int)(0x800F0247));

    [NativeTypeName("#define SPAPI_E_DEVICE_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0248L)")]
    public const int SPAPI_E_DEVICE_INSTALL_BLOCKED = unchecked((int)(0x800F0248));

    [NativeTypeName("#define SPAPI_E_DRIVER_INSTALL_BLOCKED _HRESULT_TYPEDEF_(0x800F0249L)")]
    public const int SPAPI_E_DRIVER_INSTALL_BLOCKED = unchecked((int)(0x800F0249));

    [NativeTypeName("#define SPAPI_E_WRONG_INF_TYPE _HRESULT_TYPEDEF_(0x800F024AL)")]
    public const int SPAPI_E_WRONG_INF_TYPE = unchecked((int)(0x800F024A));

    [NativeTypeName("#define SPAPI_E_FILE_HASH_NOT_IN_CATALOG _HRESULT_TYPEDEF_(0x800F024BL)")]
    public const int SPAPI_E_FILE_HASH_NOT_IN_CATALOG = unchecked((int)(0x800F024B));

    [NativeTypeName("#define SPAPI_E_DRIVER_STORE_DELETE_FAILED _HRESULT_TYPEDEF_(0x800F024CL)")]
    public const int SPAPI_E_DRIVER_STORE_DELETE_FAILED = unchecked((int)(0x800F024C));

    [NativeTypeName("#define SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW _HRESULT_TYPEDEF_(0x800F0300L)")]
    public const int SPAPI_E_UNRECOVERABLE_STACK_OVERFLOW = unchecked((int)(0x800F0300));

    [NativeTypeName("#define SPAPI_E_ERROR_NOT_INSTALLED _HRESULT_TYPEDEF_(0x800F1000L)")]
    public const int SPAPI_E_ERROR_NOT_INSTALLED = unchecked((int)(0x800F1000));
}
