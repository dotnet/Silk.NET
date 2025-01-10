// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class WN
{
    [NativeTypeName("#define WN_SUCCESS NO_ERROR")]
    public const int WN_SUCCESS = 0;

    [NativeTypeName("#define WN_NO_ERROR NO_ERROR")]
    public const int WN_NO_ERROR = 0;

    [NativeTypeName("#define WN_NOT_SUPPORTED ERROR_NOT_SUPPORTED")]
    public const int WN_NOT_SUPPORTED = 50;

    [NativeTypeName("#define WN_CANCEL ERROR_CANCELLED")]
    public const int WN_CANCEL = 1223;

    [NativeTypeName("#define WN_RETRY ERROR_RETRY")]
    public const int WN_RETRY = 1237;

    [NativeTypeName("#define WN_NET_ERROR ERROR_UNEXP_NET_ERR")]
    public const int WN_NET_ERROR = 59;

    [NativeTypeName("#define WN_MORE_DATA ERROR_MORE_DATA")]
    public const int WN_MORE_DATA = 234;

    [NativeTypeName("#define WN_BAD_POINTER ERROR_INVALID_ADDRESS")]
    public const int WN_BAD_POINTER = 487;

    [NativeTypeName("#define WN_BAD_VALUE ERROR_INVALID_PARAMETER")]
    public const int WN_BAD_VALUE = 87;

    [NativeTypeName("#define WN_BAD_USER ERROR_BAD_USERNAME")]
    public const int WN_BAD_USER = 2202;

    [NativeTypeName("#define WN_BAD_PASSWORD ERROR_INVALID_PASSWORD")]
    public const int WN_BAD_PASSWORD = 86;

    [NativeTypeName("#define WN_ACCESS_DENIED ERROR_ACCESS_DENIED")]
    public const int WN_ACCESS_DENIED = 5;

    [NativeTypeName("#define WN_FUNCTION_BUSY ERROR_BUSY")]
    public const int WN_FUNCTION_BUSY = 170;

    [NativeTypeName("#define WN_WINDOWS_ERROR ERROR_UNEXP_NET_ERR")]
    public const int WN_WINDOWS_ERROR = 59;

    [NativeTypeName("#define WN_OUT_OF_MEMORY ERROR_NOT_ENOUGH_MEMORY")]
    public const int WN_OUT_OF_MEMORY = 8;

    [NativeTypeName("#define WN_NO_NETWORK ERROR_NO_NETWORK")]
    public const int WN_NO_NETWORK = 1222;

    [NativeTypeName("#define WN_EXTENDED_ERROR ERROR_EXTENDED_ERROR")]
    public const int WN_EXTENDED_ERROR = 1208;

    [NativeTypeName("#define WN_BAD_LEVEL ERROR_INVALID_LEVEL")]
    public const int WN_BAD_LEVEL = 124;

    [NativeTypeName("#define WN_BAD_HANDLE ERROR_INVALID_HANDLE")]
    public const int WN_BAD_HANDLE = 6;

    [NativeTypeName("#define WN_NOT_INITIALIZING ERROR_ALREADY_INITIALIZED")]
    public const int WN_NOT_INITIALIZING = 1247;

    [NativeTypeName("#define WN_NO_MORE_DEVICES ERROR_NO_MORE_DEVICES")]
    public const int WN_NO_MORE_DEVICES = 1248;

    [NativeTypeName("#define WN_NOT_CONNECTED ERROR_NOT_CONNECTED")]
    public const int WN_NOT_CONNECTED = 2250;

    [NativeTypeName("#define WN_OPEN_FILES ERROR_OPEN_FILES")]
    public const int WN_OPEN_FILES = 2401;

    [NativeTypeName("#define WN_DEVICE_IN_USE ERROR_DEVICE_IN_USE")]
    public const int WN_DEVICE_IN_USE = 2404;

    [NativeTypeName("#define WN_BAD_NETNAME ERROR_BAD_NET_NAME")]
    public const int WN_BAD_NETNAME = 67;

    [NativeTypeName("#define WN_BAD_LOCALNAME ERROR_BAD_DEVICE")]
    public const int WN_BAD_LOCALNAME = 1200;

    [NativeTypeName("#define WN_ALREADY_CONNECTED ERROR_ALREADY_ASSIGNED")]
    public const int WN_ALREADY_CONNECTED = 85;

    [NativeTypeName("#define WN_DEVICE_ERROR ERROR_GEN_FAILURE")]
    public const int WN_DEVICE_ERROR = 31;

    [NativeTypeName("#define WN_CONNECTION_CLOSED ERROR_CONNECTION_UNAVAIL")]
    public const int WN_CONNECTION_CLOSED = 1201;

    [NativeTypeName("#define WN_NO_NET_OR_BAD_PATH ERROR_NO_NET_OR_BAD_PATH")]
    public const int WN_NO_NET_OR_BAD_PATH = 1203;

    [NativeTypeName("#define WN_BAD_PROVIDER ERROR_BAD_PROVIDER")]
    public const int WN_BAD_PROVIDER = 1204;

    [NativeTypeName("#define WN_CANNOT_OPEN_PROFILE ERROR_CANNOT_OPEN_PROFILE")]
    public const int WN_CANNOT_OPEN_PROFILE = 1205;

    [NativeTypeName("#define WN_BAD_PROFILE ERROR_BAD_PROFILE")]
    public const int WN_BAD_PROFILE = 1206;

    [NativeTypeName("#define WN_BAD_DEV_TYPE ERROR_BAD_DEV_TYPE")]
    public const int WN_BAD_DEV_TYPE = 66;

    [NativeTypeName("#define WN_DEVICE_ALREADY_REMEMBERED ERROR_DEVICE_ALREADY_REMEMBERED")]
    public const int WN_DEVICE_ALREADY_REMEMBERED = 1202;

    [NativeTypeName("#define WN_CONNECTED_OTHER_PASSWORD ERROR_CONNECTED_OTHER_PASSWORD")]
    public const int WN_CONNECTED_OTHER_PASSWORD = 2108;

    [NativeTypeName(
        "#define WN_CONNECTED_OTHER_PASSWORD_DEFAULT ERROR_CONNECTED_OTHER_PASSWORD_DEFAULT"
    )]
    public const int WN_CONNECTED_OTHER_PASSWORD_DEFAULT = 2109;

    [NativeTypeName("#define WN_NO_MORE_ENTRIES ERROR_NO_MORE_ITEMS")]
    public const int WN_NO_MORE_ENTRIES = 259;

    [NativeTypeName("#define WN_NOT_CONTAINER ERROR_NOT_CONTAINER")]
    public const int WN_NOT_CONTAINER = 1207;

    [NativeTypeName("#define WN_NOT_AUTHENTICATED ERROR_NOT_AUTHENTICATED")]
    public const int WN_NOT_AUTHENTICATED = 1244;

    [NativeTypeName("#define WN_NOT_LOGGED_ON ERROR_NOT_LOGGED_ON")]
    public const int WN_NOT_LOGGED_ON = 1245;

    [NativeTypeName("#define WN_NOT_VALIDATED ERROR_NO_LOGON_SERVERS")]
    public const int WN_NOT_VALIDATED = 1311;
}
