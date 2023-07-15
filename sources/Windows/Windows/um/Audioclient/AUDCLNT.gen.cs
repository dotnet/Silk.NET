// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class AUDCLNT
{
    [NativeTypeName("#define AUDCLNT_E_NOT_INITIALIZED AUDCLNT_ERR(0x001)")]
    public const int AUDCLNT_E_NOT_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x001))));
    [NativeTypeName("#define AUDCLNT_E_ALREADY_INITIALIZED AUDCLNT_ERR(0x002)")]
    public const int AUDCLNT_E_ALREADY_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x002))));
    [NativeTypeName("#define AUDCLNT_E_WRONG_ENDPOINT_TYPE AUDCLNT_ERR(0x003)")]
    public const int AUDCLNT_E_WRONG_ENDPOINT_TYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x003))));
    [NativeTypeName("#define AUDCLNT_E_DEVICE_INVALIDATED AUDCLNT_ERR(0x004)")]
    public const int AUDCLNT_E_DEVICE_INVALIDATED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x004))));
    [NativeTypeName("#define AUDCLNT_E_NOT_STOPPED AUDCLNT_ERR(0x005)")]
    public const int AUDCLNT_E_NOT_STOPPED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x005))));
    [NativeTypeName("#define AUDCLNT_E_BUFFER_TOO_LARGE AUDCLNT_ERR(0x006)")]
    public const int AUDCLNT_E_BUFFER_TOO_LARGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x006))));
    [NativeTypeName("#define AUDCLNT_E_OUT_OF_ORDER AUDCLNT_ERR(0x007)")]
    public const int AUDCLNT_E_OUT_OF_ORDER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x007))));
    [NativeTypeName("#define AUDCLNT_E_UNSUPPORTED_FORMAT AUDCLNT_ERR(0x008)")]
    public const int AUDCLNT_E_UNSUPPORTED_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x008))));
    [NativeTypeName("#define AUDCLNT_E_INVALID_SIZE AUDCLNT_ERR(0x009)")]
    public const int AUDCLNT_E_INVALID_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x009))));
    [NativeTypeName("#define AUDCLNT_E_DEVICE_IN_USE AUDCLNT_ERR(0x00a)")]
    public const int AUDCLNT_E_DEVICE_IN_USE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00a))));
    [NativeTypeName("#define AUDCLNT_E_BUFFER_OPERATION_PENDING AUDCLNT_ERR(0x00b)")]
    public const int AUDCLNT_E_BUFFER_OPERATION_PENDING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00b))));
    [NativeTypeName("#define AUDCLNT_E_THREAD_NOT_REGISTERED AUDCLNT_ERR(0x00c)")]
    public const int AUDCLNT_E_THREAD_NOT_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00c))));
    [NativeTypeName("#define AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED AUDCLNT_ERR(0x00e)")]
    public const int AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00e))));
    [NativeTypeName("#define AUDCLNT_E_ENDPOINT_CREATE_FAILED AUDCLNT_ERR(0x00f)")]
    public const int AUDCLNT_E_ENDPOINT_CREATE_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00f))));
    [NativeTypeName("#define AUDCLNT_E_SERVICE_NOT_RUNNING AUDCLNT_ERR(0x010)")]
    public const int AUDCLNT_E_SERVICE_NOT_RUNNING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010))));
    [NativeTypeName("#define AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED AUDCLNT_ERR(0x011)")]
    public const int AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x011))));
    [NativeTypeName("#define AUDCLNT_E_EXCLUSIVE_MODE_ONLY AUDCLNT_ERR(0x012)")]
    public const int AUDCLNT_E_EXCLUSIVE_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x012))));
    [NativeTypeName("#define AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL AUDCLNT_ERR(0x013)")]
    public const int AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x013))));
    [NativeTypeName("#define AUDCLNT_E_EVENTHANDLE_NOT_SET AUDCLNT_ERR(0x014)")]
    public const int AUDCLNT_E_EVENTHANDLE_NOT_SET = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x014))));
    [NativeTypeName("#define AUDCLNT_E_INCORRECT_BUFFER_SIZE AUDCLNT_ERR(0x015)")]
    public const int AUDCLNT_E_INCORRECT_BUFFER_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x015))));
    [NativeTypeName("#define AUDCLNT_E_BUFFER_SIZE_ERROR AUDCLNT_ERR(0x016)")]
    public const int AUDCLNT_E_BUFFER_SIZE_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x016))));
    [NativeTypeName("#define AUDCLNT_E_CPUUSAGE_EXCEEDED AUDCLNT_ERR(0x017)")]
    public const int AUDCLNT_E_CPUUSAGE_EXCEEDED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x017))));
    [NativeTypeName("#define AUDCLNT_E_BUFFER_ERROR AUDCLNT_ERR(0x018)")]
    public const int AUDCLNT_E_BUFFER_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x018))));
    [NativeTypeName("#define AUDCLNT_E_BUFFER_SIZE_NOT_ALIGNED AUDCLNT_ERR(0x019)")]
    public const int AUDCLNT_E_BUFFER_SIZE_NOT_ALIGNED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x019))));
    [NativeTypeName("#define AUDCLNT_E_INVALID_DEVICE_PERIOD AUDCLNT_ERR(0x020)")]
    public const int AUDCLNT_E_INVALID_DEVICE_PERIOD = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x020))));
    [NativeTypeName("#define AUDCLNT_E_INVALID_STREAM_FLAG AUDCLNT_ERR(0x021)")]
    public const int AUDCLNT_E_INVALID_STREAM_FLAG = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x021))));
    [NativeTypeName("#define AUDCLNT_E_ENDPOINT_OFFLOAD_NOT_CAPABLE AUDCLNT_ERR(0x022)")]
    public const int AUDCLNT_E_ENDPOINT_OFFLOAD_NOT_CAPABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x022))));
    [NativeTypeName("#define AUDCLNT_E_OUT_OF_OFFLOAD_RESOURCES AUDCLNT_ERR(0x023)")]
    public const int AUDCLNT_E_OUT_OF_OFFLOAD_RESOURCES = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x023))));
    [NativeTypeName("#define AUDCLNT_E_OFFLOAD_MODE_ONLY AUDCLNT_ERR(0x024)")]
    public const int AUDCLNT_E_OFFLOAD_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x024))));
    [NativeTypeName("#define AUDCLNT_E_NONOFFLOAD_MODE_ONLY AUDCLNT_ERR(0x025)")]
    public const int AUDCLNT_E_NONOFFLOAD_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x025))));
    [NativeTypeName("#define AUDCLNT_E_RESOURCES_INVALIDATED AUDCLNT_ERR(0x026)")]
    public const int AUDCLNT_E_RESOURCES_INVALIDATED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x026))));
    [NativeTypeName("#define AUDCLNT_E_RAW_MODE_UNSUPPORTED AUDCLNT_ERR(0x027)")]
    public const int AUDCLNT_E_RAW_MODE_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x027))));
    [NativeTypeName("#define AUDCLNT_E_ENGINE_PERIODICITY_LOCKED AUDCLNT_ERR(0x028)")]
    public const int AUDCLNT_E_ENGINE_PERIODICITY_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x028))));
    [NativeTypeName("#define AUDCLNT_E_ENGINE_FORMAT_LOCKED AUDCLNT_ERR(0x029)")]
    public const int AUDCLNT_E_ENGINE_FORMAT_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x029))));
    [NativeTypeName("#define AUDCLNT_E_HEADTRACKING_ENABLED AUDCLNT_ERR(0x030)")]
    public const int AUDCLNT_E_HEADTRACKING_ENABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x030))));
    [NativeTypeName("#define AUDCLNT_E_HEADTRACKING_UNSUPPORTED AUDCLNT_ERR(0x040)")]
    public const int AUDCLNT_E_HEADTRACKING_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x040))));
    [NativeTypeName("#define AUDCLNT_E_EFFECT_NOT_AVAILABLE AUDCLNT_ERR(0x041)")]
    public const int AUDCLNT_E_EFFECT_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x041))));
    [NativeTypeName("#define AUDCLNT_E_EFFECT_STATE_READ_ONLY AUDCLNT_ERR(0x042)")]
    public const int AUDCLNT_E_EFFECT_STATE_READ_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x042))));
    [NativeTypeName("#define AUDCLNT_S_BUFFER_EMPTY AUDCLNT_SUCCESS(0x001)")]
    public const int AUDCLNT_S_BUFFER_EMPTY = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x001))));
    [NativeTypeName("#define AUDCLNT_S_THREAD_ALREADY_REGISTERED AUDCLNT_SUCCESS(0x002)")]
    public const int AUDCLNT_S_THREAD_ALREADY_REGISTERED = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x002))));
    [NativeTypeName("#define AUDCLNT_S_POSITION_STALLED AUDCLNT_SUCCESS(0x003)")]
    public const int AUDCLNT_S_POSITION_STALLED = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x003))));
}