// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class E
{
    [NativeTypeName("#define E_NOT_SET HRESULT_FROM_WIN32(ERROR_NOT_FOUND)")]
    public const int E_NOT_SET = -2147023728;

    [NativeTypeName("#define E_NOT_VALID_STATE HRESULT_FROM_WIN32(ERROR_INVALID_STATE)")]
    public const int E_NOT_VALID_STATE = -2147019873;

    [NativeTypeName("#define E_NOT_SUFFICIENT_BUFFER HRESULT_FROM_WIN32(ERROR_INSUFFICIENT_BUFFER)")]
    public const int E_NOT_SUFFICIENT_BUFFER = -2147024774;

    [NativeTypeName("#define E_TIME_SENSITIVE_THREAD HRESULT_FROM_WIN32(ERROR_TIME_SENSITIVE_THREAD)")]
    public const int E_TIME_SENSITIVE_THREAD = -2147024474;

    [NativeTypeName("#define E_NO_TASK_QUEUE HRESULT_FROM_WIN32(ERROR_NO_TASK_QUEUE)")]
    public const int E_NO_TASK_QUEUE = -2147024469;

    [NativeTypeName("#define E_UNEXPECTED _HRESULT_TYPEDEF_(0x8000FFFFL)")]
    public const int E_UNEXPECTED = unchecked((int)(0x8000FFFF));

    [NativeTypeName("#define E_NOTIMPL _HRESULT_TYPEDEF_(0x80004001L)")]
    public const int E_NOTIMPL = unchecked((int)(0x80004001));

    [NativeTypeName("#define E_OUTOFMEMORY _HRESULT_TYPEDEF_(0x8007000EL)")]
    public const int E_OUTOFMEMORY = unchecked((int)(0x8007000E));

    [NativeTypeName("#define E_INVALIDARG _HRESULT_TYPEDEF_(0x80070057L)")]
    public const int E_INVALIDARG = unchecked((int)(0x80070057));

    [NativeTypeName("#define E_NOINTERFACE _HRESULT_TYPEDEF_(0x80004002L)")]
    public const int E_NOINTERFACE = unchecked((int)(0x80004002));

    [NativeTypeName("#define E_POINTER _HRESULT_TYPEDEF_(0x80004003L)")]
    public const int E_POINTER = unchecked((int)(0x80004003));

    [NativeTypeName("#define E_HANDLE _HRESULT_TYPEDEF_(0x80070006L)")]
    public const int E_HANDLE = unchecked((int)(0x80070006));

    [NativeTypeName("#define E_ABORT _HRESULT_TYPEDEF_(0x80004004L)")]
    public const int E_ABORT = unchecked((int)(0x80004004));

    [NativeTypeName("#define E_FAIL _HRESULT_TYPEDEF_(0x80004005L)")]
    public const int E_FAIL = unchecked((int)(0x80004005));

    [NativeTypeName("#define E_ACCESSDENIED _HRESULT_TYPEDEF_(0x80070005L)")]
    public const int E_ACCESSDENIED = unchecked((int)(0x80070005));

    [NativeTypeName("#define E_PENDING _HRESULT_TYPEDEF_(0x8000000AL)")]
    public const int E_PENDING = unchecked((int)(0x8000000A));

    [NativeTypeName("#define E_BOUNDS _HRESULT_TYPEDEF_(0x8000000BL)")]
    public const int E_BOUNDS = unchecked((int)(0x8000000B));

    [NativeTypeName("#define E_CHANGED_STATE _HRESULT_TYPEDEF_(0x8000000CL)")]
    public const int E_CHANGED_STATE = unchecked((int)(0x8000000C));

    [NativeTypeName("#define E_ILLEGAL_STATE_CHANGE _HRESULT_TYPEDEF_(0x8000000DL)")]
    public const int E_ILLEGAL_STATE_CHANGE = unchecked((int)(0x8000000D));

    [NativeTypeName("#define E_ILLEGAL_METHOD_CALL _HRESULT_TYPEDEF_(0x8000000EL)")]
    public const int E_ILLEGAL_METHOD_CALL = unchecked((int)(0x8000000E));

    [NativeTypeName("#define E_STRING_NOT_NULL_TERMINATED _HRESULT_TYPEDEF_(0x80000017L)")]
    public const int E_STRING_NOT_NULL_TERMINATED = unchecked((int)(0x80000017));

    [NativeTypeName("#define E_ILLEGAL_DELEGATE_ASSIGNMENT _HRESULT_TYPEDEF_(0x80000018L)")]
    public const int E_ILLEGAL_DELEGATE_ASSIGNMENT = unchecked((int)(0x80000018));

    [NativeTypeName("#define E_ASYNC_OPERATION_NOT_STARTED _HRESULT_TYPEDEF_(0x80000019L)")]
    public const int E_ASYNC_OPERATION_NOT_STARTED = unchecked((int)(0x80000019));

    [NativeTypeName("#define E_APPLICATION_EXITING _HRESULT_TYPEDEF_(0x8000001AL)")]
    public const int E_APPLICATION_EXITING = unchecked((int)(0x8000001A));

    [NativeTypeName("#define E_APPLICATION_VIEW_EXITING _HRESULT_TYPEDEF_(0x8000001BL)")]
    public const int E_APPLICATION_VIEW_EXITING = unchecked((int)(0x8000001B));

    [NativeTypeName("#define E_MBN_CONTEXT_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80548201L)")]
    public const int E_MBN_CONTEXT_NOT_ACTIVATED = unchecked((int)(0x80548201));

    [NativeTypeName("#define E_MBN_BAD_SIM _HRESULT_TYPEDEF_(0x80548202L)")]
    public const int E_MBN_BAD_SIM = unchecked((int)(0x80548202));

    [NativeTypeName("#define E_MBN_DATA_CLASS_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80548203L)")]
    public const int E_MBN_DATA_CLASS_NOT_AVAILABLE = unchecked((int)(0x80548203));

    [NativeTypeName("#define E_MBN_INVALID_ACCESS_STRING _HRESULT_TYPEDEF_(0x80548204L)")]
    public const int E_MBN_INVALID_ACCESS_STRING = unchecked((int)(0x80548204));

    [NativeTypeName("#define E_MBN_MAX_ACTIVATED_CONTEXTS _HRESULT_TYPEDEF_(0x80548205L)")]
    public const int E_MBN_MAX_ACTIVATED_CONTEXTS = unchecked((int)(0x80548205));

    [NativeTypeName("#define E_MBN_PACKET_SVC_DETACHED _HRESULT_TYPEDEF_(0x80548206L)")]
    public const int E_MBN_PACKET_SVC_DETACHED = unchecked((int)(0x80548206));

    [NativeTypeName("#define E_MBN_PROVIDER_NOT_VISIBLE _HRESULT_TYPEDEF_(0x80548207L)")]
    public const int E_MBN_PROVIDER_NOT_VISIBLE = unchecked((int)(0x80548207));

    [NativeTypeName("#define E_MBN_RADIO_POWER_OFF _HRESULT_TYPEDEF_(0x80548208L)")]
    public const int E_MBN_RADIO_POWER_OFF = unchecked((int)(0x80548208));

    [NativeTypeName("#define E_MBN_SERVICE_NOT_ACTIVATED _HRESULT_TYPEDEF_(0x80548209L)")]
    public const int E_MBN_SERVICE_NOT_ACTIVATED = unchecked((int)(0x80548209));

    [NativeTypeName("#define E_MBN_SIM_NOT_INSERTED _HRESULT_TYPEDEF_(0x8054820AL)")]
    public const int E_MBN_SIM_NOT_INSERTED = unchecked((int)(0x8054820A));

    [NativeTypeName("#define E_MBN_VOICE_CALL_IN_PROGRESS _HRESULT_TYPEDEF_(0x8054820BL)")]
    public const int E_MBN_VOICE_CALL_IN_PROGRESS = unchecked((int)(0x8054820B));

    [NativeTypeName("#define E_MBN_INVALID_CACHE _HRESULT_TYPEDEF_(0x8054820CL)")]
    public const int E_MBN_INVALID_CACHE = unchecked((int)(0x8054820C));

    [NativeTypeName("#define E_MBN_NOT_REGISTERED _HRESULT_TYPEDEF_(0x8054820DL)")]
    public const int E_MBN_NOT_REGISTERED = unchecked((int)(0x8054820D));

    [NativeTypeName("#define E_MBN_PROVIDERS_NOT_FOUND _HRESULT_TYPEDEF_(0x8054820EL)")]
    public const int E_MBN_PROVIDERS_NOT_FOUND = unchecked((int)(0x8054820E));

    [NativeTypeName("#define E_MBN_PIN_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8054820FL)")]
    public const int E_MBN_PIN_NOT_SUPPORTED = unchecked((int)(0x8054820F));

    [NativeTypeName("#define E_MBN_PIN_REQUIRED _HRESULT_TYPEDEF_(0x80548210L)")]
    public const int E_MBN_PIN_REQUIRED = unchecked((int)(0x80548210));

    [NativeTypeName("#define E_MBN_PIN_DISABLED _HRESULT_TYPEDEF_(0x80548211L)")]
    public const int E_MBN_PIN_DISABLED = unchecked((int)(0x80548211));

    [NativeTypeName("#define E_MBN_FAILURE _HRESULT_TYPEDEF_(0x80548212L)")]
    public const int E_MBN_FAILURE = unchecked((int)(0x80548212));

    [NativeTypeName("#define E_MBN_INVALID_PROFILE _HRESULT_TYPEDEF_(0x80548218L)")]
    public const int E_MBN_INVALID_PROFILE = unchecked((int)(0x80548218));

    [NativeTypeName("#define E_MBN_DEFAULT_PROFILE_EXIST _HRESULT_TYPEDEF_(0x80548219L)")]
    public const int E_MBN_DEFAULT_PROFILE_EXIST = unchecked((int)(0x80548219));

    [NativeTypeName("#define E_MBN_SMS_ENCODING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548220L)")]
    public const int E_MBN_SMS_ENCODING_NOT_SUPPORTED = unchecked((int)(0x80548220));

    [NativeTypeName("#define E_MBN_SMS_FILTER_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548221L)")]
    public const int E_MBN_SMS_FILTER_NOT_SUPPORTED = unchecked((int)(0x80548221));

    [NativeTypeName("#define E_MBN_SMS_INVALID_MEMORY_INDEX _HRESULT_TYPEDEF_(0x80548222L)")]
    public const int E_MBN_SMS_INVALID_MEMORY_INDEX = unchecked((int)(0x80548222));

    [NativeTypeName("#define E_MBN_SMS_LANG_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548223L)")]
    public const int E_MBN_SMS_LANG_NOT_SUPPORTED = unchecked((int)(0x80548223));

    [NativeTypeName("#define E_MBN_SMS_MEMORY_FAILURE _HRESULT_TYPEDEF_(0x80548224L)")]
    public const int E_MBN_SMS_MEMORY_FAILURE = unchecked((int)(0x80548224));

    [NativeTypeName("#define E_MBN_SMS_NETWORK_TIMEOUT _HRESULT_TYPEDEF_(0x80548225L)")]
    public const int E_MBN_SMS_NETWORK_TIMEOUT = unchecked((int)(0x80548225));

    [NativeTypeName("#define E_MBN_SMS_UNKNOWN_SMSC_ADDRESS _HRESULT_TYPEDEF_(0x80548226L)")]
    public const int E_MBN_SMS_UNKNOWN_SMSC_ADDRESS = unchecked((int)(0x80548226));

    [NativeTypeName("#define E_MBN_SMS_FORMAT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80548227L)")]
    public const int E_MBN_SMS_FORMAT_NOT_SUPPORTED = unchecked((int)(0x80548227));

    [NativeTypeName("#define E_MBN_SMS_OPERATION_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80548228L)")]
    public const int E_MBN_SMS_OPERATION_NOT_ALLOWED = unchecked((int)(0x80548228));

    [NativeTypeName("#define E_MBN_SMS_MEMORY_FULL _HRESULT_TYPEDEF_(0x80548229L)")]
    public const int E_MBN_SMS_MEMORY_FULL = unchecked((int)(0x80548229));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80650001L)")]
    public const int E_BLUETOOTH_ATT_INVALID_HANDLE = unchecked((int)(0x80650001));

    [NativeTypeName("#define E_BLUETOOTH_ATT_READ_NOT_PERMITTED _HRESULT_TYPEDEF_(0x80650002L)")]
    public const int E_BLUETOOTH_ATT_READ_NOT_PERMITTED = unchecked((int)(0x80650002));

    [NativeTypeName("#define E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED _HRESULT_TYPEDEF_(0x80650003L)")]
    public const int E_BLUETOOTH_ATT_WRITE_NOT_PERMITTED = unchecked((int)(0x80650003));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_PDU _HRESULT_TYPEDEF_(0x80650004L)")]
    public const int E_BLUETOOTH_ATT_INVALID_PDU = unchecked((int)(0x80650004));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION _HRESULT_TYPEDEF_(0x80650005L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHENTICATION = unchecked((int)(0x80650005));

    [NativeTypeName("#define E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80650006L)")]
    public const int E_BLUETOOTH_ATT_REQUEST_NOT_SUPPORTED = unchecked((int)(0x80650006));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_OFFSET _HRESULT_TYPEDEF_(0x80650007L)")]
    public const int E_BLUETOOTH_ATT_INVALID_OFFSET = unchecked((int)(0x80650007));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION _HRESULT_TYPEDEF_(0x80650008L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_AUTHORIZATION = unchecked((int)(0x80650008));

    [NativeTypeName("#define E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL _HRESULT_TYPEDEF_(0x80650009L)")]
    public const int E_BLUETOOTH_ATT_PREPARE_QUEUE_FULL = unchecked((int)(0x80650009));

    [NativeTypeName("#define E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND _HRESULT_TYPEDEF_(0x8065000AL)")]
    public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_FOUND = unchecked((int)(0x8065000A));

    [NativeTypeName("#define E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG _HRESULT_TYPEDEF_(0x8065000BL)")]
    public const int E_BLUETOOTH_ATT_ATTRIBUTE_NOT_LONG = unchecked((int)(0x8065000B));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE _HRESULT_TYPEDEF_(0x8065000CL)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION_KEY_SIZE = unchecked((int)(0x8065000C));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH _HRESULT_TYPEDEF_(0x8065000DL)")]
    public const int E_BLUETOOTH_ATT_INVALID_ATTRIBUTE_VALUE_LENGTH = unchecked((int)(0x8065000D));

    [NativeTypeName("#define E_BLUETOOTH_ATT_UNLIKELY _HRESULT_TYPEDEF_(0x8065000EL)")]
    public const int E_BLUETOOTH_ATT_UNLIKELY = unchecked((int)(0x8065000E));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION _HRESULT_TYPEDEF_(0x8065000FL)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_ENCRYPTION = unchecked((int)(0x8065000F));

    [NativeTypeName("#define E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE _HRESULT_TYPEDEF_(0x80650010L)")]
    public const int E_BLUETOOTH_ATT_UNSUPPORTED_GROUP_TYPE = unchecked((int)(0x80650010));

    [NativeTypeName("#define E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES _HRESULT_TYPEDEF_(0x80650011L)")]
    public const int E_BLUETOOTH_ATT_INSUFFICIENT_RESOURCES = unchecked((int)(0x80650011));

    [NativeTypeName("#define E_BLUETOOTH_ATT_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80651000L)")]
    public const int E_BLUETOOTH_ATT_UNKNOWN_ERROR = unchecked((int)(0x80651000));

    [NativeTypeName("#define E_AUDIO_ENGINE_NODE_NOT_FOUND _HRESULT_TYPEDEF_(0x80660001L)")]
    public const int E_AUDIO_ENGINE_NODE_NOT_FOUND = unchecked((int)(0x80660001));

    [NativeTypeName("#define E_HDAUDIO_EMPTY_CONNECTION_LIST _HRESULT_TYPEDEF_(0x80660002L)")]
    public const int E_HDAUDIO_EMPTY_CONNECTION_LIST = unchecked((int)(0x80660002));

    [NativeTypeName("#define E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80660003L)")]
    public const int E_HDAUDIO_CONNECTION_LIST_NOT_SUPPORTED = unchecked((int)(0x80660003));

    [NativeTypeName("#define E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED _HRESULT_TYPEDEF_(0x80660004L)")]
    public const int E_HDAUDIO_NO_LOGICAL_DEVICES_CREATED = unchecked((int)(0x80660004));

    [NativeTypeName("#define E_HDAUDIO_NULL_LINKED_LIST_ENTRY _HRESULT_TYPEDEF_(0x80660005L)")]
    public const int E_HDAUDIO_NULL_LINKED_LIST_ENTRY = unchecked((int)(0x80660005));

    [NativeTypeName("#define E_MONITOR_RESOLUTION_TOO_LOW _HRESULT_TYPEDEF_(0x80270250L)")]
    public const int E_MONITOR_RESOLUTION_TOO_LOW = unchecked((int)(0x80270250));

    [NativeTypeName("#define E_ELEVATED_ACTIVATION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270251L)")]
    public const int E_ELEVATED_ACTIVATION_NOT_SUPPORTED = unchecked((int)(0x80270251));

    [NativeTypeName("#define E_UAC_DISABLED _HRESULT_TYPEDEF_(0x80270252L)")]
    public const int E_UAC_DISABLED = unchecked((int)(0x80270252));

    [NativeTypeName("#define E_FULL_ADMIN_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270253L)")]
    public const int E_FULL_ADMIN_NOT_SUPPORTED = unchecked((int)(0x80270253));

    [NativeTypeName("#define E_APPLICATION_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80270254L)")]
    public const int E_APPLICATION_NOT_REGISTERED = unchecked((int)(0x80270254));

    [NativeTypeName("#define E_MULTIPLE_EXTENSIONS_FOR_APPLICATION _HRESULT_TYPEDEF_(0x80270255L)")]
    public const int E_MULTIPLE_EXTENSIONS_FOR_APPLICATION = unchecked((int)(0x80270255));

    [NativeTypeName("#define E_MULTIPLE_PACKAGES_FOR_FAMILY _HRESULT_TYPEDEF_(0x80270256L)")]
    public const int E_MULTIPLE_PACKAGES_FOR_FAMILY = unchecked((int)(0x80270256));

    [NativeTypeName("#define E_APPLICATION_MANAGER_NOT_RUNNING _HRESULT_TYPEDEF_(0x80270257L)")]
    public const int E_APPLICATION_MANAGER_NOT_RUNNING = unchecked((int)(0x80270257));

    [NativeTypeName("#define E_APPLICATION_ACTIVATION_TIMED_OUT _HRESULT_TYPEDEF_(0x8027025AL)")]
    public const int E_APPLICATION_ACTIVATION_TIMED_OUT = unchecked((int)(0x8027025A));

    [NativeTypeName("#define E_APPLICATION_ACTIVATION_EXEC_FAILURE _HRESULT_TYPEDEF_(0x8027025BL)")]
    public const int E_APPLICATION_ACTIVATION_EXEC_FAILURE = unchecked((int)(0x8027025B));

    [NativeTypeName("#define E_APPLICATION_TEMPORARY_LICENSE_ERROR _HRESULT_TYPEDEF_(0x8027025CL)")]
    public const int E_APPLICATION_TEMPORARY_LICENSE_ERROR = unchecked((int)(0x8027025C));

    [NativeTypeName("#define E_APPLICATION_TRIAL_LICENSE_EXPIRED _HRESULT_TYPEDEF_(0x8027025DL)")]
    public const int E_APPLICATION_TRIAL_LICENSE_EXPIRED = unchecked((int)(0x8027025D));

    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270260L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_FILE_SYSTEM_NOT_SUPPORTED = unchecked((int)(0x80270260));

    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_OVERLAP _HRESULT_TYPEDEF_(0x80270261L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_OVERLAP = unchecked((int)(0x80270261));

    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX _HRESULT_TYPEDEF_(0x80270262L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_CANNOT_INDEX = unchecked((int)(0x80270262));

    [NativeTypeName("#define E_SKYDRIVE_FILE_NOT_UPLOADED _HRESULT_TYPEDEF_(0x80270263L)")]
    public const int E_SKYDRIVE_FILE_NOT_UPLOADED = unchecked((int)(0x80270263));

    [NativeTypeName("#define E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL _HRESULT_TYPEDEF_(0x80270264L)")]
    public const int E_SKYDRIVE_UPDATE_AVAILABILITY_FAIL = unchecked((int)(0x80270264));

    [NativeTypeName("#define E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80270265L)")]
    public const int E_SKYDRIVE_ROOT_TARGET_VOLUME_ROOT_NOT_SUPPORTED = unchecked((int)(0x80270265));

    [NativeTypeName("#define E_SYNCENGINE_FILE_SIZE_OVER_LIMIT _HRESULT_TYPEDEF_(0x8802B001L)")]
    public const int E_SYNCENGINE_FILE_SIZE_OVER_LIMIT = unchecked((int)(0x8802B001));

    [NativeTypeName("#define E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA _HRESULT_TYPEDEF_(0x8802B002L)")]
    public const int E_SYNCENGINE_FILE_SIZE_EXCEEDS_REMAINING_QUOTA = unchecked((int)(0x8802B002));

    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_FILE_NAME _HRESULT_TYPEDEF_(0x8802B003L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_FILE_NAME = unchecked((int)(0x8802B003));

    [NativeTypeName("#define E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802B004L)")]
    public const int E_SYNCENGINE_FOLDER_ITEM_COUNT_LIMIT_EXCEEDED = unchecked((int)(0x8802B004));

    [NativeTypeName("#define E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR _HRESULT_TYPEDEF_(0x8802B005L)")]
    public const int E_SYNCENGINE_FILE_SYNC_PARTNER_ERROR = unchecked((int)(0x8802B005));

    [NativeTypeName("#define E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE _HRESULT_TYPEDEF_(0x8802B006L)")]
    public const int E_SYNCENGINE_SYNC_PAUSED_BY_SERVICE = unchecked((int)(0x8802B006));

    [NativeTypeName("#define E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN _HRESULT_TYPEDEF_(0x8802C002L)")]
    public const int E_SYNCENGINE_FILE_IDENTIFIER_UNKNOWN = unchecked((int)(0x8802C002));

    [NativeTypeName("#define E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED _HRESULT_TYPEDEF_(0x8802C003L)")]
    public const int E_SYNCENGINE_SERVICE_AUTHENTICATION_FAILED = unchecked((int)(0x8802C003));

    [NativeTypeName("#define E_SYNCENGINE_UNKNOWN_SERVICE_ERROR _HRESULT_TYPEDEF_(0x8802C004L)")]
    public const int E_SYNCENGINE_UNKNOWN_SERVICE_ERROR = unchecked((int)(0x8802C004));

    [NativeTypeName("#define E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE _HRESULT_TYPEDEF_(0x8802C005L)")]
    public const int E_SYNCENGINE_SERVICE_RETURNED_UNEXPECTED_SIZE = unchecked((int)(0x8802C005));

    [NativeTypeName("#define E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE _HRESULT_TYPEDEF_(0x8802C006L)")]
    public const int E_SYNCENGINE_REQUEST_BLOCKED_BY_SERVICE = unchecked((int)(0x8802C006));

    [NativeTypeName("#define E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR _HRESULT_TYPEDEF_(0x8802C007L)")]
    public const int E_SYNCENGINE_REQUEST_BLOCKED_DUE_TO_CLIENT_ERROR = unchecked((int)(0x8802C007));

    [NativeTypeName("#define E_SYNCENGINE_FOLDER_INACCESSIBLE _HRESULT_TYPEDEF_(0x8802D001L)")]
    public const int E_SYNCENGINE_FOLDER_INACCESSIBLE = unchecked((int)(0x8802D001));

    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME _HRESULT_TYPEDEF_(0x8802D002L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_FOLDER_NAME = unchecked((int)(0x8802D002));

    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_MARKET _HRESULT_TYPEDEF_(0x8802D003L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_MARKET = unchecked((int)(0x8802D003));

    [NativeTypeName("#define E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802D004L)")]
    public const int E_SYNCENGINE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)(0x8802D004));

    [NativeTypeName("#define E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED _HRESULT_TYPEDEF_(0x8802D005L)")]
    public const int E_SYNCENGINE_REMOTE_PATH_LENGTH_LIMIT_EXCEEDED = unchecked((int)(0x8802D005));

    [NativeTypeName("#define E_SYNCENGINE_CLIENT_UPDATE_NEEDED _HRESULT_TYPEDEF_(0x8802D006L)")]
    public const int E_SYNCENGINE_CLIENT_UPDATE_NEEDED = unchecked((int)(0x8802D006));

    [NativeTypeName("#define E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED _HRESULT_TYPEDEF_(0x8802D007L)")]
    public const int E_SYNCENGINE_PROXY_AUTHENTICATION_REQUIRED = unchecked((int)(0x8802D007));

    [NativeTypeName("#define E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED _HRESULT_TYPEDEF_(0x8802D008L)")]
    public const int E_SYNCENGINE_STORAGE_SERVICE_PROVISIONING_FAILED = unchecked((int)(0x8802D008));

    [NativeTypeName("#define E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT _HRESULT_TYPEDEF_(0x8802D009L)")]
    public const int E_SYNCENGINE_UNSUPPORTED_REPARSE_POINT = unchecked((int)(0x8802D009));

    [NativeTypeName("#define E_SYNCENGINE_STORAGE_SERVICE_BLOCKED _HRESULT_TYPEDEF_(0x8802D00AL)")]
    public const int E_SYNCENGINE_STORAGE_SERVICE_BLOCKED = unchecked((int)(0x8802D00A));

    [NativeTypeName("#define E_SYNCENGINE_FOLDER_IN_REDIRECTION _HRESULT_TYPEDEF_(0x8802D00BL)")]
    public const int E_SYNCENGINE_FOLDER_IN_REDIRECTION = unchecked((int)(0x8802D00B));

    [NativeTypeName("#define E_INVALID_PROTOCOL_OPERATION _HRESULT_TYPEDEF_(0x83760001L)")]
    public const int E_INVALID_PROTOCOL_OPERATION = unchecked((int)(0x83760001));

    [NativeTypeName("#define E_INVALID_PROTOCOL_FORMAT _HRESULT_TYPEDEF_(0x83760002L)")]
    public const int E_INVALID_PROTOCOL_FORMAT = unchecked((int)(0x83760002));

    [NativeTypeName("#define E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760003L)")]
    public const int E_PROTOCOL_EXTENSIONS_NOT_SUPPORTED = unchecked((int)(0x83760003));

    [NativeTypeName("#define E_SUBPROTOCOL_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760004L)")]
    public const int E_SUBPROTOCOL_NOT_SUPPORTED = unchecked((int)(0x83760004));

    [NativeTypeName("#define E_PROTOCOL_VERSION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x83760005L)")]
    public const int E_PROTOCOL_VERSION_NOT_SUPPORTED = unchecked((int)(0x83760005));
}
