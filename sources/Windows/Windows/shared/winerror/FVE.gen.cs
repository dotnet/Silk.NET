// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FVE
{
    [NativeTypeName("#define FVE_E_LOCKED_VOLUME _HRESULT_TYPEDEF_(0x80310000L)")]
    public const int FVE_E_LOCKED_VOLUME = unchecked((int)(0x80310000));
    [NativeTypeName("#define FVE_E_NOT_ENCRYPTED _HRESULT_TYPEDEF_(0x80310001L)")]
    public const int FVE_E_NOT_ENCRYPTED = unchecked((int)(0x80310001));
    [NativeTypeName("#define FVE_E_NO_TPM_BIOS _HRESULT_TYPEDEF_(0x80310002L)")]
    public const int FVE_E_NO_TPM_BIOS = unchecked((int)(0x80310002));
    [NativeTypeName("#define FVE_E_NO_MBR_METRIC _HRESULT_TYPEDEF_(0x80310003L)")]
    public const int FVE_E_NO_MBR_METRIC = unchecked((int)(0x80310003));
    [NativeTypeName("#define FVE_E_NO_BOOTSECTOR_METRIC _HRESULT_TYPEDEF_(0x80310004L)")]
    public const int FVE_E_NO_BOOTSECTOR_METRIC = unchecked((int)(0x80310004));
    [NativeTypeName("#define FVE_E_NO_BOOTMGR_METRIC _HRESULT_TYPEDEF_(0x80310005L)")]
    public const int FVE_E_NO_BOOTMGR_METRIC = unchecked((int)(0x80310005));
    [NativeTypeName("#define FVE_E_WRONG_BOOTMGR _HRESULT_TYPEDEF_(0x80310006L)")]
    public const int FVE_E_WRONG_BOOTMGR = unchecked((int)(0x80310006));
    [NativeTypeName("#define FVE_E_SECURE_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310007L)")]
    public const int FVE_E_SECURE_KEY_REQUIRED = unchecked((int)(0x80310007));
    [NativeTypeName("#define FVE_E_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80310008L)")]
    public const int FVE_E_NOT_ACTIVATED = unchecked((int)(0x80310008));
    [NativeTypeName("#define FVE_E_ACTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310009L)")]
    public const int FVE_E_ACTION_NOT_ALLOWED = unchecked((int)(0x80310009));
    [NativeTypeName("#define FVE_E_AD_SCHEMA_NOT_INSTALLED _HRESULT_TYPEDEF_(0x8031000AL)")]
    public const int FVE_E_AD_SCHEMA_NOT_INSTALLED = unchecked((int)(0x8031000A));
    [NativeTypeName("#define FVE_E_AD_INVALID_DATATYPE _HRESULT_TYPEDEF_(0x8031000BL)")]
    public const int FVE_E_AD_INVALID_DATATYPE = unchecked((int)(0x8031000B));
    [NativeTypeName("#define FVE_E_AD_INVALID_DATASIZE _HRESULT_TYPEDEF_(0x8031000CL)")]
    public const int FVE_E_AD_INVALID_DATASIZE = unchecked((int)(0x8031000C));
    [NativeTypeName("#define FVE_E_AD_NO_VALUES _HRESULT_TYPEDEF_(0x8031000DL)")]
    public const int FVE_E_AD_NO_VALUES = unchecked((int)(0x8031000D));
    [NativeTypeName("#define FVE_E_AD_ATTR_NOT_SET _HRESULT_TYPEDEF_(0x8031000EL)")]
    public const int FVE_E_AD_ATTR_NOT_SET = unchecked((int)(0x8031000E));
    [NativeTypeName("#define FVE_E_AD_GUID_NOT_FOUND _HRESULT_TYPEDEF_(0x8031000FL)")]
    public const int FVE_E_AD_GUID_NOT_FOUND = unchecked((int)(0x8031000F));
    [NativeTypeName("#define FVE_E_BAD_INFORMATION _HRESULT_TYPEDEF_(0x80310010L)")]
    public const int FVE_E_BAD_INFORMATION = unchecked((int)(0x80310010));
    [NativeTypeName("#define FVE_E_TOO_SMALL _HRESULT_TYPEDEF_(0x80310011L)")]
    public const int FVE_E_TOO_SMALL = unchecked((int)(0x80310011));
    [NativeTypeName("#define FVE_E_SYSTEM_VOLUME _HRESULT_TYPEDEF_(0x80310012L)")]
    public const int FVE_E_SYSTEM_VOLUME = unchecked((int)(0x80310012));
    [NativeTypeName("#define FVE_E_FAILED_WRONG_FS _HRESULT_TYPEDEF_(0x80310013L)")]
    public const int FVE_E_FAILED_WRONG_FS = unchecked((int)(0x80310013));
    [NativeTypeName("#define FVE_E_BAD_PARTITION_SIZE _HRESULT_TYPEDEF_(0x80310014L)")]
    public const int FVE_E_BAD_PARTITION_SIZE = unchecked((int)(0x80310014));
    [NativeTypeName("#define FVE_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310015L)")]
    public const int FVE_E_NOT_SUPPORTED = unchecked((int)(0x80310015));
    [NativeTypeName("#define FVE_E_BAD_DATA _HRESULT_TYPEDEF_(0x80310016L)")]
    public const int FVE_E_BAD_DATA = unchecked((int)(0x80310016));
    [NativeTypeName("#define FVE_E_VOLUME_NOT_BOUND _HRESULT_TYPEDEF_(0x80310017L)")]
    public const int FVE_E_VOLUME_NOT_BOUND = unchecked((int)(0x80310017));
    [NativeTypeName("#define FVE_E_TPM_NOT_OWNED _HRESULT_TYPEDEF_(0x80310018L)")]
    public const int FVE_E_TPM_NOT_OWNED = unchecked((int)(0x80310018));
    [NativeTypeName("#define FVE_E_NOT_DATA_VOLUME _HRESULT_TYPEDEF_(0x80310019L)")]
    public const int FVE_E_NOT_DATA_VOLUME = unchecked((int)(0x80310019));
    [NativeTypeName("#define FVE_E_AD_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x8031001AL)")]
    public const int FVE_E_AD_INSUFFICIENT_BUFFER = unchecked((int)(0x8031001A));
    [NativeTypeName("#define FVE_E_CONV_READ _HRESULT_TYPEDEF_(0x8031001BL)")]
    public const int FVE_E_CONV_READ = unchecked((int)(0x8031001B));
    [NativeTypeName("#define FVE_E_CONV_WRITE _HRESULT_TYPEDEF_(0x8031001CL)")]
    public const int FVE_E_CONV_WRITE = unchecked((int)(0x8031001C));
    [NativeTypeName("#define FVE_E_KEY_REQUIRED _HRESULT_TYPEDEF_(0x8031001DL)")]
    public const int FVE_E_KEY_REQUIRED = unchecked((int)(0x8031001D));
    [NativeTypeName("#define FVE_E_CLUSTERING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8031001EL)")]
    public const int FVE_E_CLUSTERING_NOT_SUPPORTED = unchecked((int)(0x8031001E));
    [NativeTypeName("#define FVE_E_VOLUME_BOUND_ALREADY _HRESULT_TYPEDEF_(0x8031001FL)")]
    public const int FVE_E_VOLUME_BOUND_ALREADY = unchecked((int)(0x8031001F));
    [NativeTypeName("#define FVE_E_OS_NOT_PROTECTED _HRESULT_TYPEDEF_(0x80310020L)")]
    public const int FVE_E_OS_NOT_PROTECTED = unchecked((int)(0x80310020));
    [NativeTypeName("#define FVE_E_PROTECTION_DISABLED _HRESULT_TYPEDEF_(0x80310021L)")]
    public const int FVE_E_PROTECTION_DISABLED = unchecked((int)(0x80310021));
    [NativeTypeName("#define FVE_E_RECOVERY_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310022L)")]
    public const int FVE_E_RECOVERY_KEY_REQUIRED = unchecked((int)(0x80310022));
    [NativeTypeName("#define FVE_E_FOREIGN_VOLUME _HRESULT_TYPEDEF_(0x80310023L)")]
    public const int FVE_E_FOREIGN_VOLUME = unchecked((int)(0x80310023));
    [NativeTypeName("#define FVE_E_OVERLAPPED_UPDATE _HRESULT_TYPEDEF_(0x80310024L)")]
    public const int FVE_E_OVERLAPPED_UPDATE = unchecked((int)(0x80310024));
    [NativeTypeName("#define FVE_E_TPM_SRK_AUTH_NOT_ZERO _HRESULT_TYPEDEF_(0x80310025L)")]
    public const int FVE_E_TPM_SRK_AUTH_NOT_ZERO = unchecked((int)(0x80310025));
    [NativeTypeName("#define FVE_E_FAILED_SECTOR_SIZE _HRESULT_TYPEDEF_(0x80310026L)")]
    public const int FVE_E_FAILED_SECTOR_SIZE = unchecked((int)(0x80310026));
    [NativeTypeName("#define FVE_E_FAILED_AUTHENTICATION _HRESULT_TYPEDEF_(0x80310027L)")]
    public const int FVE_E_FAILED_AUTHENTICATION = unchecked((int)(0x80310027));
    [NativeTypeName("#define FVE_E_NOT_OS_VOLUME _HRESULT_TYPEDEF_(0x80310028L)")]
    public const int FVE_E_NOT_OS_VOLUME = unchecked((int)(0x80310028));
    [NativeTypeName("#define FVE_E_AUTOUNLOCK_ENABLED _HRESULT_TYPEDEF_(0x80310029L)")]
    public const int FVE_E_AUTOUNLOCK_ENABLED = unchecked((int)(0x80310029));
    [NativeTypeName("#define FVE_E_WRONG_BOOTSECTOR _HRESULT_TYPEDEF_(0x8031002AL)")]
    public const int FVE_E_WRONG_BOOTSECTOR = unchecked((int)(0x8031002A));
    [NativeTypeName("#define FVE_E_WRONG_SYSTEM_FS _HRESULT_TYPEDEF_(0x8031002BL)")]
    public const int FVE_E_WRONG_SYSTEM_FS = unchecked((int)(0x8031002B));
    [NativeTypeName("#define FVE_E_POLICY_PASSWORD_REQUIRED _HRESULT_TYPEDEF_(0x8031002CL)")]
    public const int FVE_E_POLICY_PASSWORD_REQUIRED = unchecked((int)(0x8031002C));
    [NativeTypeName("#define FVE_E_CANNOT_SET_FVEK_ENCRYPTED _HRESULT_TYPEDEF_(0x8031002DL)")]
    public const int FVE_E_CANNOT_SET_FVEK_ENCRYPTED = unchecked((int)(0x8031002D));
    [NativeTypeName("#define FVE_E_CANNOT_ENCRYPT_NO_KEY _HRESULT_TYPEDEF_(0x8031002EL)")]
    public const int FVE_E_CANNOT_ENCRYPT_NO_KEY = unchecked((int)(0x8031002E));
    [NativeTypeName("#define FVE_E_BOOTABLE_CDDVD _HRESULT_TYPEDEF_(0x80310030L)")]
    public const int FVE_E_BOOTABLE_CDDVD = unchecked((int)(0x80310030));
    [NativeTypeName("#define FVE_E_PROTECTOR_EXISTS _HRESULT_TYPEDEF_(0x80310031L)")]
    public const int FVE_E_PROTECTOR_EXISTS = unchecked((int)(0x80310031));
    [NativeTypeName("#define FVE_E_RELATIVE_PATH _HRESULT_TYPEDEF_(0x80310032L)")]
    public const int FVE_E_RELATIVE_PATH = unchecked((int)(0x80310032));
    [NativeTypeName("#define FVE_E_PROTECTOR_NOT_FOUND _HRESULT_TYPEDEF_(0x80310033L)")]
    public const int FVE_E_PROTECTOR_NOT_FOUND = unchecked((int)(0x80310033));
    [NativeTypeName("#define FVE_E_INVALID_KEY_FORMAT _HRESULT_TYPEDEF_(0x80310034L)")]
    public const int FVE_E_INVALID_KEY_FORMAT = unchecked((int)(0x80310034));
    [NativeTypeName("#define FVE_E_INVALID_PASSWORD_FORMAT _HRESULT_TYPEDEF_(0x80310035L)")]
    public const int FVE_E_INVALID_PASSWORD_FORMAT = unchecked((int)(0x80310035));
    [NativeTypeName("#define FVE_E_FIPS_RNG_CHECK_FAILED _HRESULT_TYPEDEF_(0x80310036L)")]
    public const int FVE_E_FIPS_RNG_CHECK_FAILED = unchecked((int)(0x80310036));
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD _HRESULT_TYPEDEF_(0x80310037L)")]
    public const int FVE_E_FIPS_PREVENTS_RECOVERY_PASSWORD = unchecked((int)(0x80310037));
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT _HRESULT_TYPEDEF_(0x80310038L)")]
    public const int FVE_E_FIPS_PREVENTS_EXTERNAL_KEY_EXPORT = unchecked((int)(0x80310038));
    [NativeTypeName("#define FVE_E_NOT_DECRYPTED _HRESULT_TYPEDEF_(0x80310039L)")]
    public const int FVE_E_NOT_DECRYPTED = unchecked((int)(0x80310039));
    [NativeTypeName("#define FVE_E_INVALID_PROTECTOR_TYPE _HRESULT_TYPEDEF_(0x8031003AL)")]
    public const int FVE_E_INVALID_PROTECTOR_TYPE = unchecked((int)(0x8031003A));
    [NativeTypeName("#define FVE_E_NO_PROTECTORS_TO_TEST _HRESULT_TYPEDEF_(0x8031003BL)")]
    public const int FVE_E_NO_PROTECTORS_TO_TEST = unchecked((int)(0x8031003B));
    [NativeTypeName("#define FVE_E_KEYFILE_NOT_FOUND _HRESULT_TYPEDEF_(0x8031003CL)")]
    public const int FVE_E_KEYFILE_NOT_FOUND = unchecked((int)(0x8031003C));
    [NativeTypeName("#define FVE_E_KEYFILE_INVALID _HRESULT_TYPEDEF_(0x8031003DL)")]
    public const int FVE_E_KEYFILE_INVALID = unchecked((int)(0x8031003D));
    [NativeTypeName("#define FVE_E_KEYFILE_NO_VMK _HRESULT_TYPEDEF_(0x8031003EL)")]
    public const int FVE_E_KEYFILE_NO_VMK = unchecked((int)(0x8031003E));
    [NativeTypeName("#define FVE_E_TPM_DISABLED _HRESULT_TYPEDEF_(0x8031003FL)")]
    public const int FVE_E_TPM_DISABLED = unchecked((int)(0x8031003F));
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_IN_SAFE_MODE _HRESULT_TYPEDEF_(0x80310040L)")]
    public const int FVE_E_NOT_ALLOWED_IN_SAFE_MODE = unchecked((int)(0x80310040));
    [NativeTypeName("#define FVE_E_TPM_INVALID_PCR _HRESULT_TYPEDEF_(0x80310041L)")]
    public const int FVE_E_TPM_INVALID_PCR = unchecked((int)(0x80310041));
    [NativeTypeName("#define FVE_E_TPM_NO_VMK _HRESULT_TYPEDEF_(0x80310042L)")]
    public const int FVE_E_TPM_NO_VMK = unchecked((int)(0x80310042));
    [NativeTypeName("#define FVE_E_PIN_INVALID _HRESULT_TYPEDEF_(0x80310043L)")]
    public const int FVE_E_PIN_INVALID = unchecked((int)(0x80310043));
    [NativeTypeName("#define FVE_E_AUTH_INVALID_APPLICATION _HRESULT_TYPEDEF_(0x80310044L)")]
    public const int FVE_E_AUTH_INVALID_APPLICATION = unchecked((int)(0x80310044));
    [NativeTypeName("#define FVE_E_AUTH_INVALID_CONFIG _HRESULT_TYPEDEF_(0x80310045L)")]
    public const int FVE_E_AUTH_INVALID_CONFIG = unchecked((int)(0x80310045));
    [NativeTypeName("#define FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310046L)")]
    public const int FVE_E_FIPS_DISABLE_PROTECTION_NOT_ALLOWED = unchecked((int)(0x80310046));
    [NativeTypeName("#define FVE_E_FS_NOT_EXTENDED _HRESULT_TYPEDEF_(0x80310047L)")]
    public const int FVE_E_FS_NOT_EXTENDED = unchecked((int)(0x80310047));
    [NativeTypeName("#define FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310048L)")]
    public const int FVE_E_FIRMWARE_TYPE_NOT_SUPPORTED = unchecked((int)(0x80310048));
    [NativeTypeName("#define FVE_E_NO_LICENSE _HRESULT_TYPEDEF_(0x80310049L)")]
    public const int FVE_E_NO_LICENSE = unchecked((int)(0x80310049));
    [NativeTypeName("#define FVE_E_NOT_ON_STACK _HRESULT_TYPEDEF_(0x8031004AL)")]
    public const int FVE_E_NOT_ON_STACK = unchecked((int)(0x8031004A));
    [NativeTypeName("#define FVE_E_FS_MOUNTED _HRESULT_TYPEDEF_(0x8031004BL)")]
    public const int FVE_E_FS_MOUNTED = unchecked((int)(0x8031004B));
    [NativeTypeName("#define FVE_E_TOKEN_NOT_IMPERSONATED _HRESULT_TYPEDEF_(0x8031004CL)")]
    public const int FVE_E_TOKEN_NOT_IMPERSONATED = unchecked((int)(0x8031004C));
    [NativeTypeName("#define FVE_E_DRY_RUN_FAILED _HRESULT_TYPEDEF_(0x8031004DL)")]
    public const int FVE_E_DRY_RUN_FAILED = unchecked((int)(0x8031004D));
    [NativeTypeName("#define FVE_E_REBOOT_REQUIRED _HRESULT_TYPEDEF_(0x8031004EL)")]
    public const int FVE_E_REBOOT_REQUIRED = unchecked((int)(0x8031004E));
    [NativeTypeName("#define FVE_E_DEBUGGER_ENABLED _HRESULT_TYPEDEF_(0x8031004FL)")]
    public const int FVE_E_DEBUGGER_ENABLED = unchecked((int)(0x8031004F));
    [NativeTypeName("#define FVE_E_RAW_ACCESS _HRESULT_TYPEDEF_(0x80310050L)")]
    public const int FVE_E_RAW_ACCESS = unchecked((int)(0x80310050));
    [NativeTypeName("#define FVE_E_RAW_BLOCKED _HRESULT_TYPEDEF_(0x80310051L)")]
    public const int FVE_E_RAW_BLOCKED = unchecked((int)(0x80310051));
    [NativeTypeName("#define FVE_E_BCD_APPLICATIONS_PATH_INCORRECT _HRESULT_TYPEDEF_(0x80310052L)")]
    public const int FVE_E_BCD_APPLICATIONS_PATH_INCORRECT = unchecked((int)(0x80310052));
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_IN_VERSION _HRESULT_TYPEDEF_(0x80310053L)")]
    public const int FVE_E_NOT_ALLOWED_IN_VERSION = unchecked((int)(0x80310053));
    [NativeTypeName("#define FVE_E_NO_AUTOUNLOCK_MASTER_KEY _HRESULT_TYPEDEF_(0x80310054L)")]
    public const int FVE_E_NO_AUTOUNLOCK_MASTER_KEY = unchecked((int)(0x80310054));
    [NativeTypeName("#define FVE_E_MOR_FAILED _HRESULT_TYPEDEF_(0x80310055L)")]
    public const int FVE_E_MOR_FAILED = unchecked((int)(0x80310055));
    [NativeTypeName("#define FVE_E_HIDDEN_VOLUME _HRESULT_TYPEDEF_(0x80310056L)")]
    public const int FVE_E_HIDDEN_VOLUME = unchecked((int)(0x80310056));
    [NativeTypeName("#define FVE_E_TRANSIENT_STATE _HRESULT_TYPEDEF_(0x80310057L)")]
    public const int FVE_E_TRANSIENT_STATE = unchecked((int)(0x80310057));
    [NativeTypeName("#define FVE_E_PUBKEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310058L)")]
    public const int FVE_E_PUBKEY_NOT_ALLOWED = unchecked((int)(0x80310058));
    [NativeTypeName("#define FVE_E_VOLUME_HANDLE_OPEN _HRESULT_TYPEDEF_(0x80310059L)")]
    public const int FVE_E_VOLUME_HANDLE_OPEN = unchecked((int)(0x80310059));
    [NativeTypeName("#define FVE_E_NO_FEATURE_LICENSE _HRESULT_TYPEDEF_(0x8031005AL)")]
    public const int FVE_E_NO_FEATURE_LICENSE = unchecked((int)(0x8031005A));
    [NativeTypeName("#define FVE_E_INVALID_STARTUP_OPTIONS _HRESULT_TYPEDEF_(0x8031005BL)")]
    public const int FVE_E_INVALID_STARTUP_OPTIONS = unchecked((int)(0x8031005B));
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031005CL)")]
    public const int FVE_E_POLICY_RECOVERY_PASSWORD_NOT_ALLOWED = unchecked((int)(0x8031005C));
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED _HRESULT_TYPEDEF_(0x8031005DL)")]
    public const int FVE_E_POLICY_RECOVERY_PASSWORD_REQUIRED = unchecked((int)(0x8031005D));
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031005EL)")]
    public const int FVE_E_POLICY_RECOVERY_KEY_NOT_ALLOWED = unchecked((int)(0x8031005E));
    [NativeTypeName("#define FVE_E_POLICY_RECOVERY_KEY_REQUIRED _HRESULT_TYPEDEF_(0x8031005FL)")]
    public const int FVE_E_POLICY_RECOVERY_KEY_REQUIRED = unchecked((int)(0x8031005F));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310060L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_NOT_ALLOWED = unchecked((int)(0x80310060));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_REQUIRED _HRESULT_TYPEDEF_(0x80310061L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_REQUIRED = unchecked((int)(0x80310061));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310062L)")]
    public const int FVE_E_POLICY_STARTUP_KEY_NOT_ALLOWED = unchecked((int)(0x80310062));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310063L)")]
    public const int FVE_E_POLICY_STARTUP_KEY_REQUIRED = unchecked((int)(0x80310063));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310064L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_KEY_NOT_ALLOWED = unchecked((int)(0x80310064));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310065L)")]
    public const int FVE_E_POLICY_STARTUP_PIN_KEY_REQUIRED = unchecked((int)(0x80310065));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310066L)")]
    public const int FVE_E_POLICY_STARTUP_TPM_NOT_ALLOWED = unchecked((int)(0x80310066));
    [NativeTypeName("#define FVE_E_POLICY_STARTUP_TPM_REQUIRED _HRESULT_TYPEDEF_(0x80310067L)")]
    public const int FVE_E_POLICY_STARTUP_TPM_REQUIRED = unchecked((int)(0x80310067));
    [NativeTypeName("#define FVE_E_POLICY_INVALID_PIN_LENGTH _HRESULT_TYPEDEF_(0x80310068L)")]
    public const int FVE_E_POLICY_INVALID_PIN_LENGTH = unchecked((int)(0x80310068));
    [NativeTypeName("#define FVE_E_KEY_PROTECTOR_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80310069L)")]
    public const int FVE_E_KEY_PROTECTOR_NOT_SUPPORTED = unchecked((int)(0x80310069));
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031006AL)")]
    public const int FVE_E_POLICY_PASSPHRASE_NOT_ALLOWED = unchecked((int)(0x8031006A));
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_REQUIRED _HRESULT_TYPEDEF_(0x8031006BL)")]
    public const int FVE_E_POLICY_PASSPHRASE_REQUIRED = unchecked((int)(0x8031006B));
    [NativeTypeName("#define FVE_E_FIPS_PREVENTS_PASSPHRASE _HRESULT_TYPEDEF_(0x8031006CL)")]
    public const int FVE_E_FIPS_PREVENTS_PASSPHRASE = unchecked((int)(0x8031006C));
    [NativeTypeName("#define FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x8031006DL)")]
    public const int FVE_E_OS_VOLUME_PASSPHRASE_NOT_ALLOWED = unchecked((int)(0x8031006D));
    [NativeTypeName("#define FVE_E_INVALID_BITLOCKER_OID _HRESULT_TYPEDEF_(0x8031006EL)")]
    public const int FVE_E_INVALID_BITLOCKER_OID = unchecked((int)(0x8031006E));
    [NativeTypeName("#define FVE_E_VOLUME_TOO_SMALL _HRESULT_TYPEDEF_(0x8031006FL)")]
    public const int FVE_E_VOLUME_TOO_SMALL = unchecked((int)(0x8031006F));
    [NativeTypeName("#define FVE_E_DV_NOT_SUPPORTED_ON_FS _HRESULT_TYPEDEF_(0x80310070L)")]
    public const int FVE_E_DV_NOT_SUPPORTED_ON_FS = unchecked((int)(0x80310070));
    [NativeTypeName("#define FVE_E_DV_NOT_ALLOWED_BY_GP _HRESULT_TYPEDEF_(0x80310071L)")]
    public const int FVE_E_DV_NOT_ALLOWED_BY_GP = unchecked((int)(0x80310071));
    [NativeTypeName("#define FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310072L)")]
    public const int FVE_E_POLICY_USER_CERTIFICATE_NOT_ALLOWED = unchecked((int)(0x80310072));
    [NativeTypeName("#define FVE_E_POLICY_USER_CERTIFICATE_REQUIRED _HRESULT_TYPEDEF_(0x80310073L)")]
    public const int FVE_E_POLICY_USER_CERTIFICATE_REQUIRED = unchecked((int)(0x80310073));
    [NativeTypeName("#define FVE_E_POLICY_USER_CERT_MUST_BE_HW _HRESULT_TYPEDEF_(0x80310074L)")]
    public const int FVE_E_POLICY_USER_CERT_MUST_BE_HW = unchecked((int)(0x80310074));
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310075L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_FDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)(0x80310075));
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310076L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_RDV_AUTOUNLOCK_NOT_ALLOWED = unchecked((int)(0x80310076));
    [NativeTypeName("#define FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310077L)")]
    public const int FVE_E_POLICY_USER_CONFIGURE_RDV_NOT_ALLOWED = unchecked((int)(0x80310077));
    [NativeTypeName("#define FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310078L)")]
    public const int FVE_E_POLICY_USER_ENABLE_RDV_NOT_ALLOWED = unchecked((int)(0x80310078));
    [NativeTypeName("#define FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310079L)")]
    public const int FVE_E_POLICY_USER_DISABLE_RDV_NOT_ALLOWED = unchecked((int)(0x80310079));
    [NativeTypeName("#define FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH _HRESULT_TYPEDEF_(0x80310080L)")]
    public const int FVE_E_POLICY_INVALID_PASSPHRASE_LENGTH = unchecked((int)(0x80310080));
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE _HRESULT_TYPEDEF_(0x80310081L)")]
    public const int FVE_E_POLICY_PASSPHRASE_TOO_SIMPLE = unchecked((int)(0x80310081));
    [NativeTypeName("#define FVE_E_RECOVERY_PARTITION _HRESULT_TYPEDEF_(0x80310082L)")]
    public const int FVE_E_RECOVERY_PARTITION = unchecked((int)(0x80310082));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON _HRESULT_TYPEDEF_(0x80310083L)")]
    public const int FVE_E_POLICY_CONFLICT_FDV_RK_OFF_AUK_ON = unchecked((int)(0x80310083));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON _HRESULT_TYPEDEF_(0x80310084L)")]
    public const int FVE_E_POLICY_CONFLICT_RDV_RK_OFF_AUK_ON = unchecked((int)(0x80310084));
    [NativeTypeName("#define FVE_E_NON_BITLOCKER_OID _HRESULT_TYPEDEF_(0x80310085L)")]
    public const int FVE_E_NON_BITLOCKER_OID = unchecked((int)(0x80310085));
    [NativeTypeName("#define FVE_E_POLICY_PROHIBITS_SELFSIGNED _HRESULT_TYPEDEF_(0x80310086L)")]
    public const int FVE_E_POLICY_PROHIBITS_SELFSIGNED = unchecked((int)(0x80310086));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED _HRESULT_TYPEDEF_(0x80310087L)")]
    public const int FVE_E_POLICY_CONFLICT_RO_AND_STARTUP_KEY_REQUIRED = unchecked((int)(0x80310087));
    [NativeTypeName("#define FVE_E_CONV_RECOVERY_FAILED _HRESULT_TYPEDEF_(0x80310088L)")]
    public const int FVE_E_CONV_RECOVERY_FAILED = unchecked((int)(0x80310088));
    [NativeTypeName("#define FVE_E_VIRTUALIZED_SPACE_TOO_BIG _HRESULT_TYPEDEF_(0x80310089L)")]
    public const int FVE_E_VIRTUALIZED_SPACE_TOO_BIG = unchecked((int)(0x80310089));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310090L)")]
    public const int FVE_E_POLICY_CONFLICT_OSV_RP_OFF_ADB_ON = unchecked((int)(0x80310090));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310091L)")]
    public const int FVE_E_POLICY_CONFLICT_FDV_RP_OFF_ADB_ON = unchecked((int)(0x80310091));
    [NativeTypeName("#define FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON _HRESULT_TYPEDEF_(0x80310092L)")]
    public const int FVE_E_POLICY_CONFLICT_RDV_RP_OFF_ADB_ON = unchecked((int)(0x80310092));
    [NativeTypeName("#define FVE_E_NON_BITLOCKER_KU _HRESULT_TYPEDEF_(0x80310093L)")]
    public const int FVE_E_NON_BITLOCKER_KU = unchecked((int)(0x80310093));
    [NativeTypeName("#define FVE_E_PRIVATEKEY_AUTH_FAILED _HRESULT_TYPEDEF_(0x80310094L)")]
    public const int FVE_E_PRIVATEKEY_AUTH_FAILED = unchecked((int)(0x80310094));
    [NativeTypeName("#define FVE_E_REMOVAL_OF_DRA_FAILED _HRESULT_TYPEDEF_(0x80310095L)")]
    public const int FVE_E_REMOVAL_OF_DRA_FAILED = unchecked((int)(0x80310095));
    [NativeTypeName("#define FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME _HRESULT_TYPEDEF_(0x80310096L)")]
    public const int FVE_E_OPERATION_NOT_SUPPORTED_ON_VISTA_VOLUME = unchecked((int)(0x80310096));
    [NativeTypeName("#define FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME _HRESULT_TYPEDEF_(0x80310097L)")]
    public const int FVE_E_CANT_LOCK_AUTOUNLOCK_ENABLED_VOLUME = unchecked((int)(0x80310097));
    [NativeTypeName("#define FVE_E_FIPS_HASH_KDF_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80310098L)")]
    public const int FVE_E_FIPS_HASH_KDF_NOT_ALLOWED = unchecked((int)(0x80310098));
    [NativeTypeName("#define FVE_E_ENH_PIN_INVALID _HRESULT_TYPEDEF_(0x80310099L)")]
    public const int FVE_E_ENH_PIN_INVALID = unchecked((int)(0x80310099));
    [NativeTypeName("#define FVE_E_INVALID_PIN_CHARS _HRESULT_TYPEDEF_(0x8031009AL)")]
    public const int FVE_E_INVALID_PIN_CHARS = unchecked((int)(0x8031009A));
    [NativeTypeName("#define FVE_E_INVALID_DATUM_TYPE _HRESULT_TYPEDEF_(0x8031009BL)")]
    public const int FVE_E_INVALID_DATUM_TYPE = unchecked((int)(0x8031009B));
    [NativeTypeName("#define FVE_E_EFI_ONLY _HRESULT_TYPEDEF_(0x8031009CL)")]
    public const int FVE_E_EFI_ONLY = unchecked((int)(0x8031009C));
    [NativeTypeName("#define FVE_E_MULTIPLE_NKP_CERTS _HRESULT_TYPEDEF_(0x8031009DL)")]
    public const int FVE_E_MULTIPLE_NKP_CERTS = unchecked((int)(0x8031009D));
    [NativeTypeName("#define FVE_E_REMOVAL_OF_NKP_FAILED _HRESULT_TYPEDEF_(0x8031009EL)")]
    public const int FVE_E_REMOVAL_OF_NKP_FAILED = unchecked((int)(0x8031009E));
    [NativeTypeName("#define FVE_E_INVALID_NKP_CERT _HRESULT_TYPEDEF_(0x8031009FL)")]
    public const int FVE_E_INVALID_NKP_CERT = unchecked((int)(0x8031009F));
    [NativeTypeName("#define FVE_E_NO_EXISTING_PIN _HRESULT_TYPEDEF_(0x803100A0L)")]
    public const int FVE_E_NO_EXISTING_PIN = unchecked((int)(0x803100A0));
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH _HRESULT_TYPEDEF_(0x803100A1L)")]
    public const int FVE_E_PROTECTOR_CHANGE_PIN_MISMATCH = unchecked((int)(0x803100A1));
    [NativeTypeName("#define FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED _HRESULT_TYPEDEF_(0x803100A2L)")]
    public const int FVE_E_PIN_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)(0x803100A2));
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED _HRESULT_TYPEDEF_(0x803100A3L)")]
    public const int FVE_E_PROTECTOR_CHANGE_MAX_PIN_CHANGE_ATTEMPTS_REACHED = unchecked((int)(0x803100A3));
    [NativeTypeName("#define FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII _HRESULT_TYPEDEF_(0x803100A4L)")]
    public const int FVE_E_POLICY_PASSPHRASE_REQUIRES_ASCII = unchecked((int)(0x803100A4));
    [NativeTypeName("#define FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE _HRESULT_TYPEDEF_(0x803100A5L)")]
    public const int FVE_E_FULL_ENCRYPTION_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0x803100A5));
    [NativeTypeName("#define FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE _HRESULT_TYPEDEF_(0x803100A6L)")]
    public const int FVE_E_WIPE_NOT_ALLOWED_ON_TP_STORAGE = unchecked((int)(0x803100A6));
    [NativeTypeName("#define FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE _HRESULT_TYPEDEF_(0x803100A7L)")]
    public const int FVE_E_KEY_LENGTH_NOT_SUPPORTED_BY_EDRIVE = unchecked((int)(0x803100A7));
    [NativeTypeName("#define FVE_E_NO_EXISTING_PASSPHRASE _HRESULT_TYPEDEF_(0x803100A8L)")]
    public const int FVE_E_NO_EXISTING_PASSPHRASE = unchecked((int)(0x803100A8));
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH _HRESULT_TYPEDEF_(0x803100A9L)")]
    public const int FVE_E_PROTECTOR_CHANGE_PASSPHRASE_MISMATCH = unchecked((int)(0x803100A9));
    [NativeTypeName("#define FVE_E_PASSPHRASE_TOO_LONG _HRESULT_TYPEDEF_(0x803100AAL)")]
    public const int FVE_E_PASSPHRASE_TOO_LONG = unchecked((int)(0x803100AA));
    [NativeTypeName("#define FVE_E_NO_PASSPHRASE_WITH_TPM _HRESULT_TYPEDEF_(0x803100ABL)")]
    public const int FVE_E_NO_PASSPHRASE_WITH_TPM = unchecked((int)(0x803100AB));
    [NativeTypeName("#define FVE_E_NO_TPM_WITH_PASSPHRASE _HRESULT_TYPEDEF_(0x803100ACL)")]
    public const int FVE_E_NO_TPM_WITH_PASSPHRASE = unchecked((int)(0x803100AC));
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_ON_CSV_STACK _HRESULT_TYPEDEF_(0x803100ADL)")]
    public const int FVE_E_NOT_ALLOWED_ON_CSV_STACK = unchecked((int)(0x803100AD));
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_ON_CLUSTER _HRESULT_TYPEDEF_(0x803100AEL)")]
    public const int FVE_E_NOT_ALLOWED_ON_CLUSTER = unchecked((int)(0x803100AE));
    [NativeTypeName("#define FVE_E_EDRIVE_NO_FAILOVER_TO_SW _HRESULT_TYPEDEF_(0x803100AFL)")]
    public const int FVE_E_EDRIVE_NO_FAILOVER_TO_SW = unchecked((int)(0x803100AF));
    [NativeTypeName("#define FVE_E_EDRIVE_BAND_IN_USE _HRESULT_TYPEDEF_(0x803100B0L)")]
    public const int FVE_E_EDRIVE_BAND_IN_USE = unchecked((int)(0x803100B0));
    [NativeTypeName("#define FVE_E_EDRIVE_DISALLOWED_BY_GP _HRESULT_TYPEDEF_(0x803100B1L)")]
    public const int FVE_E_EDRIVE_DISALLOWED_BY_GP = unchecked((int)(0x803100B1));
    [NativeTypeName("#define FVE_E_EDRIVE_INCOMPATIBLE_VOLUME _HRESULT_TYPEDEF_(0x803100B2L)")]
    public const int FVE_E_EDRIVE_INCOMPATIBLE_VOLUME = unchecked((int)(0x803100B2));
    [NativeTypeName("#define FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING _HRESULT_TYPEDEF_(0x803100B3L)")]
    public const int FVE_E_NOT_ALLOWED_TO_UPGRADE_WHILE_CONVERTING = unchecked((int)(0x803100B3));
    [NativeTypeName("#define FVE_E_EDRIVE_DV_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100B4L)")]
    public const int FVE_E_EDRIVE_DV_NOT_SUPPORTED = unchecked((int)(0x803100B4));
    [NativeTypeName("#define FVE_E_NO_PREBOOT_KEYBOARD_DETECTED _HRESULT_TYPEDEF_(0x803100B5L)")]
    public const int FVE_E_NO_PREBOOT_KEYBOARD_DETECTED = unchecked((int)(0x803100B5));
    [NativeTypeName("#define FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED _HRESULT_TYPEDEF_(0x803100B6L)")]
    public const int FVE_E_NO_PREBOOT_KEYBOARD_OR_WINRE_DETECTED = unchecked((int)(0x803100B6));
    [NativeTypeName("#define FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE _HRESULT_TYPEDEF_(0x803100B7L)")]
    public const int FVE_E_POLICY_REQUIRES_STARTUP_PIN_ON_TOUCH_DEVICE = unchecked((int)(0x803100B7));
    [NativeTypeName("#define FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE _HRESULT_TYPEDEF_(0x803100B8L)")]
    public const int FVE_E_POLICY_REQUIRES_RECOVERY_PASSWORD_ON_TOUCH_DEVICE = unchecked((int)(0x803100B8));
    [NativeTypeName("#define FVE_E_WIPE_CANCEL_NOT_APPLICABLE _HRESULT_TYPEDEF_(0x803100B9L)")]
    public const int FVE_E_WIPE_CANCEL_NOT_APPLICABLE = unchecked((int)(0x803100B9));
    [NativeTypeName("#define FVE_E_SECUREBOOT_DISABLED _HRESULT_TYPEDEF_(0x803100BAL)")]
    public const int FVE_E_SECUREBOOT_DISABLED = unchecked((int)(0x803100BA));
    [NativeTypeName("#define FVE_E_SECUREBOOT_CONFIGURATION_INVALID _HRESULT_TYPEDEF_(0x803100BBL)")]
    public const int FVE_E_SECUREBOOT_CONFIGURATION_INVALID = unchecked((int)(0x803100BB));
    [NativeTypeName("#define FVE_E_EDRIVE_DRY_RUN_FAILED _HRESULT_TYPEDEF_(0x803100BCL)")]
    public const int FVE_E_EDRIVE_DRY_RUN_FAILED = unchecked((int)(0x803100BC));
    [NativeTypeName("#define FVE_E_SHADOW_COPY_PRESENT _HRESULT_TYPEDEF_(0x803100BDL)")]
    public const int FVE_E_SHADOW_COPY_PRESENT = unchecked((int)(0x803100BD));
    [NativeTypeName("#define FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS _HRESULT_TYPEDEF_(0x803100BEL)")]
    public const int FVE_E_POLICY_INVALID_ENHANCED_BCD_SETTINGS = unchecked((int)(0x803100BE));
    [NativeTypeName("#define FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE _HRESULT_TYPEDEF_(0x803100BFL)")]
    public const int FVE_E_EDRIVE_INCOMPATIBLE_FIRMWARE = unchecked((int)(0x803100BF));
    [NativeTypeName("#define FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED _HRESULT_TYPEDEF_(0x803100C0L)")]
    public const int FVE_E_PROTECTOR_CHANGE_MAX_PASSPHRASE_CHANGE_ATTEMPTS_REACHED = unchecked((int)(0x803100C0));
    [NativeTypeName("#define FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED _HRESULT_TYPEDEF_(0x803100C1L)")]
    public const int FVE_E_PASSPHRASE_PROTECTOR_CHANGE_BY_STD_USER_DISALLOWED = unchecked((int)(0x803100C1));
    [NativeTypeName("#define FVE_E_LIVEID_ACCOUNT_SUSPENDED _HRESULT_TYPEDEF_(0x803100C2L)")]
    public const int FVE_E_LIVEID_ACCOUNT_SUSPENDED = unchecked((int)(0x803100C2));
    [NativeTypeName("#define FVE_E_LIVEID_ACCOUNT_BLOCKED _HRESULT_TYPEDEF_(0x803100C3L)")]
    public const int FVE_E_LIVEID_ACCOUNT_BLOCKED = unchecked((int)(0x803100C3));
    [NativeTypeName("#define FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES _HRESULT_TYPEDEF_(0x803100C4L)")]
    public const int FVE_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)(0x803100C4));
    [NativeTypeName("#define FVE_E_DE_FIXED_DATA_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100C5L)")]
    public const int FVE_E_DE_FIXED_DATA_NOT_SUPPORTED = unchecked((int)(0x803100C5));
    [NativeTypeName("#define FVE_E_DE_HARDWARE_NOT_COMPLIANT _HRESULT_TYPEDEF_(0x803100C6L)")]
    public const int FVE_E_DE_HARDWARE_NOT_COMPLIANT = unchecked((int)(0x803100C6));
    [NativeTypeName("#define FVE_E_DE_WINRE_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x803100C7L)")]
    public const int FVE_E_DE_WINRE_NOT_CONFIGURED = unchecked((int)(0x803100C7));
    [NativeTypeName("#define FVE_E_DE_PROTECTION_SUSPENDED _HRESULT_TYPEDEF_(0x803100C8L)")]
    public const int FVE_E_DE_PROTECTION_SUSPENDED = unchecked((int)(0x803100C8));
    [NativeTypeName("#define FVE_E_DE_OS_VOLUME_NOT_PROTECTED _HRESULT_TYPEDEF_(0x803100C9L)")]
    public const int FVE_E_DE_OS_VOLUME_NOT_PROTECTED = unchecked((int)(0x803100C9));
    [NativeTypeName("#define FVE_E_DE_DEVICE_LOCKEDOUT _HRESULT_TYPEDEF_(0x803100CAL)")]
    public const int FVE_E_DE_DEVICE_LOCKEDOUT = unchecked((int)(0x803100CA));
    [NativeTypeName("#define FVE_E_DE_PROTECTION_NOT_YET_ENABLED _HRESULT_TYPEDEF_(0x803100CBL)")]
    public const int FVE_E_DE_PROTECTION_NOT_YET_ENABLED = unchecked((int)(0x803100CB));
    [NativeTypeName("#define FVE_E_INVALID_PIN_CHARS_DETAILED _HRESULT_TYPEDEF_(0x803100CCL)")]
    public const int FVE_E_INVALID_PIN_CHARS_DETAILED = unchecked((int)(0x803100CC));
    [NativeTypeName("#define FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE _HRESULT_TYPEDEF_(0x803100CDL)")]
    public const int FVE_E_DEVICE_LOCKOUT_COUNTER_UNAVAILABLE = unchecked((int)(0x803100CD));
    [NativeTypeName("#define FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH _HRESULT_TYPEDEF_(0x803100CEL)")]
    public const int FVE_E_DEVICELOCKOUT_COUNTER_MISMATCH = unchecked((int)(0x803100CE));
    [NativeTypeName("#define FVE_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x803100CFL)")]
    public const int FVE_E_BUFFER_TOO_LARGE = unchecked((int)(0x803100CF));
    [NativeTypeName("#define FVE_E_NO_SUCH_CAPABILITY_ON_TARGET _HRESULT_TYPEDEF_(0x803100D0L)")]
    public const int FVE_E_NO_SUCH_CAPABILITY_ON_TARGET = unchecked((int)(0x803100D0));
    [NativeTypeName("#define FVE_E_DE_PREVENTED_FOR_OS _HRESULT_TYPEDEF_(0x803100D1L)")]
    public const int FVE_E_DE_PREVENTED_FOR_OS = unchecked((int)(0x803100D1));
    [NativeTypeName("#define FVE_E_DE_VOLUME_OPTED_OUT _HRESULT_TYPEDEF_(0x803100D2L)")]
    public const int FVE_E_DE_VOLUME_OPTED_OUT = unchecked((int)(0x803100D2));
    [NativeTypeName("#define FVE_E_DE_VOLUME_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100D3L)")]
    public const int FVE_E_DE_VOLUME_NOT_SUPPORTED = unchecked((int)(0x803100D3));
    [NativeTypeName("#define FVE_E_EOW_NOT_SUPPORTED_IN_VERSION _HRESULT_TYPEDEF_(0x803100D4L)")]
    public const int FVE_E_EOW_NOT_SUPPORTED_IN_VERSION = unchecked((int)(0x803100D4));
    [NativeTypeName("#define FVE_E_ADBACKUP_NOT_ENABLED _HRESULT_TYPEDEF_(0x803100D5L)")]
    public const int FVE_E_ADBACKUP_NOT_ENABLED = unchecked((int)(0x803100D5));
    [NativeTypeName("#define FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT _HRESULT_TYPEDEF_(0x803100D6L)")]
    public const int FVE_E_VOLUME_EXTEND_PREVENTS_EOW_DECRYPT = unchecked((int)(0x803100D6));
    [NativeTypeName("#define FVE_E_NOT_DE_VOLUME _HRESULT_TYPEDEF_(0x803100D7L)")]
    public const int FVE_E_NOT_DE_VOLUME = unchecked((int)(0x803100D7));
    [NativeTypeName("#define FVE_E_PROTECTION_CANNOT_BE_DISABLED _HRESULT_TYPEDEF_(0x803100D8L)")]
    public const int FVE_E_PROTECTION_CANNOT_BE_DISABLED = unchecked((int)(0x803100D8));
    [NativeTypeName("#define FVE_E_OSV_KSR_NOT_ALLOWED _HRESULT_TYPEDEF_(0x803100D9L)")]
    public const int FVE_E_OSV_KSR_NOT_ALLOWED = unchecked((int)(0x803100D9));
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_OS_DRIVE _HRESULT_TYPEDEF_(0x803100DAL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_OS_DRIVE = unchecked((int)(0x803100DA));
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_FIXED_DRIVE _HRESULT_TYPEDEF_(0x803100DBL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_FIXED_DRIVE = unchecked((int)(0x803100DB));
    [NativeTypeName("#define FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_REMOVABLE_DRIVE _HRESULT_TYPEDEF_(0x803100DCL)")]
    public const int FVE_E_AD_BACKUP_REQUIRED_POLICY_NOT_SET_REMOVABLE_DRIVE = unchecked((int)(0x803100DC));
    [NativeTypeName("#define FVE_E_KEY_ROTATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100DDL)")]
    public const int FVE_E_KEY_ROTATION_NOT_SUPPORTED = unchecked((int)(0x803100DD));
    [NativeTypeName("#define FVE_E_EXECUTE_REQUEST_SENT_TOO_SOON _HRESULT_TYPEDEF_(0x803100DEL)")]
    public const int FVE_E_EXECUTE_REQUEST_SENT_TOO_SOON = unchecked((int)(0x803100DE));
    [NativeTypeName("#define FVE_E_KEY_ROTATION_NOT_ENABLED _HRESULT_TYPEDEF_(0x803100DFL)")]
    public const int FVE_E_KEY_ROTATION_NOT_ENABLED = unchecked((int)(0x803100DF));
    [NativeTypeName("#define FVE_E_DEVICE_NOT_JOINED _HRESULT_TYPEDEF_(0x803100E0L)")]
    public const int FVE_E_DEVICE_NOT_JOINED = unchecked((int)(0x803100E0));
    [NativeTypeName("#define FVE_E_AAD_ENDPOINT_BUSY _HRESULT_TYPEDEF_(0x803100E1L)")]
    public const int FVE_E_AAD_ENDPOINT_BUSY = unchecked((int)(0x803100E1));
    [NativeTypeName("#define FVE_E_INVALID_NBP_CERT _HRESULT_TYPEDEF_(0x803100E2L)")]
    public const int FVE_E_INVALID_NBP_CERT = unchecked((int)(0x803100E2));
    [NativeTypeName("#define FVE_E_EDRIVE_BAND_ENUMERATION_FAILED _HRESULT_TYPEDEF_(0x803100E3L)")]
    public const int FVE_E_EDRIVE_BAND_ENUMERATION_FAILED = unchecked((int)(0x803100E3));
    [NativeTypeName("#define FVE_E_POLICY_ON_RDV_EXCLUSION_LIST _HRESULT_TYPEDEF_(0x803100E4L)")]
    public const int FVE_E_POLICY_ON_RDV_EXCLUSION_LIST = unchecked((int)(0x803100E4));
    [NativeTypeName("#define FVE_E_PREDICTED_TPM_PROTECTOR_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E5L)")]
    public const int FVE_E_PREDICTED_TPM_PROTECTOR_NOT_SUPPORTED = unchecked((int)(0x803100E5));
    [NativeTypeName("#define FVE_E_SETUP_TPM_CALLBACK_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E6L)")]
    public const int FVE_E_SETUP_TPM_CALLBACK_NOT_SUPPORTED = unchecked((int)(0x803100E6));
    [NativeTypeName("#define FVE_E_TPM_CONTEXT_SETUP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x803100E7L)")]
    public const int FVE_E_TPM_CONTEXT_SETUP_NOT_SUPPORTED = unchecked((int)(0x803100E7));
    [NativeTypeName("#define FVE_E_UPDATE_INVALID_CONFIG _HRESULT_TYPEDEF_(0x803100E8L)")]
    public const int FVE_E_UPDATE_INVALID_CONFIG = unchecked((int)(0x803100E8));
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_RETRY_AFTER _HRESULT_TYPEDEF_(0x803100E9L)")]
    public const int FVE_E_AAD_SERVER_FAIL_RETRY_AFTER = unchecked((int)(0x803100E9));
    [NativeTypeName("#define FVE_E_AAD_SERVER_FAIL_BACKOFF _HRESULT_TYPEDEF_(0x803100EAL)")]
    public const int FVE_E_AAD_SERVER_FAIL_BACKOFF = unchecked((int)(0x803100EA));
    [NativeTypeName("#define FVE_E_DATASET_FULL _HRESULT_TYPEDEF_(0x803100EBL)")]
    public const int FVE_E_DATASET_FULL = unchecked((int)(0x803100EB));
    [NativeTypeName("#define FVE_E_METADATA_FULL _HRESULT_TYPEDEF_(0x803100ECL)")]
    public const int FVE_E_METADATA_FULL = unchecked((int)(0x803100EC));
}