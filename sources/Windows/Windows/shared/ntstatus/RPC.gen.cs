// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ntstatus.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class RPC
{
    [NativeTypeName("#define RPC_NT_INVALID_STRING_BINDING ((NTSTATUS)0xC0020001L)")]
    public const int RPC_NT_INVALID_STRING_BINDING = unchecked((int)(0xC0020001));

    [NativeTypeName("#define RPC_NT_WRONG_KIND_OF_BINDING ((NTSTATUS)0xC0020002L)")]
    public const int RPC_NT_WRONG_KIND_OF_BINDING = unchecked((int)(0xC0020002));

    [NativeTypeName("#define RPC_NT_INVALID_BINDING ((NTSTATUS)0xC0020003L)")]
    public const int RPC_NT_INVALID_BINDING = unchecked((int)(0xC0020003));

    [NativeTypeName("#define RPC_NT_PROTSEQ_NOT_SUPPORTED ((NTSTATUS)0xC0020004L)")]
    public const int RPC_NT_PROTSEQ_NOT_SUPPORTED = unchecked((int)(0xC0020004));

    [NativeTypeName("#define RPC_NT_INVALID_RPC_PROTSEQ ((NTSTATUS)0xC0020005L)")]
    public const int RPC_NT_INVALID_RPC_PROTSEQ = unchecked((int)(0xC0020005));

    [NativeTypeName("#define RPC_NT_INVALID_STRING_UUID ((NTSTATUS)0xC0020006L)")]
    public const int RPC_NT_INVALID_STRING_UUID = unchecked((int)(0xC0020006));

    [NativeTypeName("#define RPC_NT_INVALID_ENDPOINT_FORMAT ((NTSTATUS)0xC0020007L)")]
    public const int RPC_NT_INVALID_ENDPOINT_FORMAT = unchecked((int)(0xC0020007));

    [NativeTypeName("#define RPC_NT_INVALID_NET_ADDR ((NTSTATUS)0xC0020008L)")]
    public const int RPC_NT_INVALID_NET_ADDR = unchecked((int)(0xC0020008));

    [NativeTypeName("#define RPC_NT_NO_ENDPOINT_FOUND ((NTSTATUS)0xC0020009L)")]
    public const int RPC_NT_NO_ENDPOINT_FOUND = unchecked((int)(0xC0020009));

    [NativeTypeName("#define RPC_NT_INVALID_TIMEOUT ((NTSTATUS)0xC002000AL)")]
    public const int RPC_NT_INVALID_TIMEOUT = unchecked((int)(0xC002000A));

    [NativeTypeName("#define RPC_NT_OBJECT_NOT_FOUND ((NTSTATUS)0xC002000BL)")]
    public const int RPC_NT_OBJECT_NOT_FOUND = unchecked((int)(0xC002000B));

    [NativeTypeName("#define RPC_NT_ALREADY_REGISTERED ((NTSTATUS)0xC002000CL)")]
    public const int RPC_NT_ALREADY_REGISTERED = unchecked((int)(0xC002000C));

    [NativeTypeName("#define RPC_NT_TYPE_ALREADY_REGISTERED ((NTSTATUS)0xC002000DL)")]
    public const int RPC_NT_TYPE_ALREADY_REGISTERED = unchecked((int)(0xC002000D));

    [NativeTypeName("#define RPC_NT_ALREADY_LISTENING ((NTSTATUS)0xC002000EL)")]
    public const int RPC_NT_ALREADY_LISTENING = unchecked((int)(0xC002000E));

    [NativeTypeName("#define RPC_NT_NO_PROTSEQS_REGISTERED ((NTSTATUS)0xC002000FL)")]
    public const int RPC_NT_NO_PROTSEQS_REGISTERED = unchecked((int)(0xC002000F));

    [NativeTypeName("#define RPC_NT_NOT_LISTENING ((NTSTATUS)0xC0020010L)")]
    public const int RPC_NT_NOT_LISTENING = unchecked((int)(0xC0020010));

    [NativeTypeName("#define RPC_NT_UNKNOWN_MGR_TYPE ((NTSTATUS)0xC0020011L)")]
    public const int RPC_NT_UNKNOWN_MGR_TYPE = unchecked((int)(0xC0020011));

    [NativeTypeName("#define RPC_NT_UNKNOWN_IF ((NTSTATUS)0xC0020012L)")]
    public const int RPC_NT_UNKNOWN_IF = unchecked((int)(0xC0020012));

    [NativeTypeName("#define RPC_NT_NO_BINDINGS ((NTSTATUS)0xC0020013L)")]
    public const int RPC_NT_NO_BINDINGS = unchecked((int)(0xC0020013));

    [NativeTypeName("#define RPC_NT_NO_PROTSEQS ((NTSTATUS)0xC0020014L)")]
    public const int RPC_NT_NO_PROTSEQS = unchecked((int)(0xC0020014));

    [NativeTypeName("#define RPC_NT_CANT_CREATE_ENDPOINT ((NTSTATUS)0xC0020015L)")]
    public const int RPC_NT_CANT_CREATE_ENDPOINT = unchecked((int)(0xC0020015));

    [NativeTypeName("#define RPC_NT_OUT_OF_RESOURCES ((NTSTATUS)0xC0020016L)")]
    public const int RPC_NT_OUT_OF_RESOURCES = unchecked((int)(0xC0020016));

    [NativeTypeName("#define RPC_NT_SERVER_UNAVAILABLE ((NTSTATUS)0xC0020017L)")]
    public const int RPC_NT_SERVER_UNAVAILABLE = unchecked((int)(0xC0020017));

    [NativeTypeName("#define RPC_NT_SERVER_TOO_BUSY ((NTSTATUS)0xC0020018L)")]
    public const int RPC_NT_SERVER_TOO_BUSY = unchecked((int)(0xC0020018));

    [NativeTypeName("#define RPC_NT_INVALID_NETWORK_OPTIONS ((NTSTATUS)0xC0020019L)")]
    public const int RPC_NT_INVALID_NETWORK_OPTIONS = unchecked((int)(0xC0020019));

    [NativeTypeName("#define RPC_NT_NO_CALL_ACTIVE ((NTSTATUS)0xC002001AL)")]
    public const int RPC_NT_NO_CALL_ACTIVE = unchecked((int)(0xC002001A));

    [NativeTypeName("#define RPC_NT_CALL_FAILED ((NTSTATUS)0xC002001BL)")]
    public const int RPC_NT_CALL_FAILED = unchecked((int)(0xC002001B));

    [NativeTypeName("#define RPC_NT_CALL_FAILED_DNE ((NTSTATUS)0xC002001CL)")]
    public const int RPC_NT_CALL_FAILED_DNE = unchecked((int)(0xC002001C));

    [NativeTypeName("#define RPC_NT_PROTOCOL_ERROR ((NTSTATUS)0xC002001DL)")]
    public const int RPC_NT_PROTOCOL_ERROR = unchecked((int)(0xC002001D));

    [NativeTypeName("#define RPC_NT_UNSUPPORTED_TRANS_SYN ((NTSTATUS)0xC002001FL)")]
    public const int RPC_NT_UNSUPPORTED_TRANS_SYN = unchecked((int)(0xC002001F));

    [NativeTypeName("#define RPC_NT_UNSUPPORTED_TYPE ((NTSTATUS)0xC0020021L)")]
    public const int RPC_NT_UNSUPPORTED_TYPE = unchecked((int)(0xC0020021));

    [NativeTypeName("#define RPC_NT_INVALID_TAG ((NTSTATUS)0xC0020022L)")]
    public const int RPC_NT_INVALID_TAG = unchecked((int)(0xC0020022));

    [NativeTypeName("#define RPC_NT_INVALID_BOUND ((NTSTATUS)0xC0020023L)")]
    public const int RPC_NT_INVALID_BOUND = unchecked((int)(0xC0020023));

    [NativeTypeName("#define RPC_NT_NO_ENTRY_NAME ((NTSTATUS)0xC0020024L)")]
    public const int RPC_NT_NO_ENTRY_NAME = unchecked((int)(0xC0020024));

    [NativeTypeName("#define RPC_NT_INVALID_NAME_SYNTAX ((NTSTATUS)0xC0020025L)")]
    public const int RPC_NT_INVALID_NAME_SYNTAX = unchecked((int)(0xC0020025));

    [NativeTypeName("#define RPC_NT_UNSUPPORTED_NAME_SYNTAX ((NTSTATUS)0xC0020026L)")]
    public const int RPC_NT_UNSUPPORTED_NAME_SYNTAX = unchecked((int)(0xC0020026));

    [NativeTypeName("#define RPC_NT_UUID_NO_ADDRESS ((NTSTATUS)0xC0020028L)")]
    public const int RPC_NT_UUID_NO_ADDRESS = unchecked((int)(0xC0020028));

    [NativeTypeName("#define RPC_NT_DUPLICATE_ENDPOINT ((NTSTATUS)0xC0020029L)")]
    public const int RPC_NT_DUPLICATE_ENDPOINT = unchecked((int)(0xC0020029));

    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_TYPE ((NTSTATUS)0xC002002AL)")]
    public const int RPC_NT_UNKNOWN_AUTHN_TYPE = unchecked((int)(0xC002002A));

    [NativeTypeName("#define RPC_NT_MAX_CALLS_TOO_SMALL ((NTSTATUS)0xC002002BL)")]
    public const int RPC_NT_MAX_CALLS_TOO_SMALL = unchecked((int)(0xC002002B));

    [NativeTypeName("#define RPC_NT_STRING_TOO_LONG ((NTSTATUS)0xC002002CL)")]
    public const int RPC_NT_STRING_TOO_LONG = unchecked((int)(0xC002002C));

    [NativeTypeName("#define RPC_NT_PROTSEQ_NOT_FOUND ((NTSTATUS)0xC002002DL)")]
    public const int RPC_NT_PROTSEQ_NOT_FOUND = unchecked((int)(0xC002002D));

    [NativeTypeName("#define RPC_NT_PROCNUM_OUT_OF_RANGE ((NTSTATUS)0xC002002EL)")]
    public const int RPC_NT_PROCNUM_OUT_OF_RANGE = unchecked((int)(0xC002002E));

    [NativeTypeName("#define RPC_NT_BINDING_HAS_NO_AUTH ((NTSTATUS)0xC002002FL)")]
    public const int RPC_NT_BINDING_HAS_NO_AUTH = unchecked((int)(0xC002002F));

    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_SERVICE ((NTSTATUS)0xC0020030L)")]
    public const int RPC_NT_UNKNOWN_AUTHN_SERVICE = unchecked((int)(0xC0020030));

    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHN_LEVEL ((NTSTATUS)0xC0020031L)")]
    public const int RPC_NT_UNKNOWN_AUTHN_LEVEL = unchecked((int)(0xC0020031));

    [NativeTypeName("#define RPC_NT_INVALID_AUTH_IDENTITY ((NTSTATUS)0xC0020032L)")]
    public const int RPC_NT_INVALID_AUTH_IDENTITY = unchecked((int)(0xC0020032));

    [NativeTypeName("#define RPC_NT_UNKNOWN_AUTHZ_SERVICE ((NTSTATUS)0xC0020033L)")]
    public const int RPC_NT_UNKNOWN_AUTHZ_SERVICE = unchecked((int)(0xC0020033));

    [NativeTypeName("#define RPC_NT_NOTHING_TO_EXPORT ((NTSTATUS)0xC0020037L)")]
    public const int RPC_NT_NOTHING_TO_EXPORT = unchecked((int)(0xC0020037));

    [NativeTypeName("#define RPC_NT_INCOMPLETE_NAME ((NTSTATUS)0xC0020038L)")]
    public const int RPC_NT_INCOMPLETE_NAME = unchecked((int)(0xC0020038));

    [NativeTypeName("#define RPC_NT_INVALID_VERS_OPTION ((NTSTATUS)0xC0020039L)")]
    public const int RPC_NT_INVALID_VERS_OPTION = unchecked((int)(0xC0020039));

    [NativeTypeName("#define RPC_NT_NO_MORE_MEMBERS ((NTSTATUS)0xC002003AL)")]
    public const int RPC_NT_NO_MORE_MEMBERS = unchecked((int)(0xC002003A));

    [NativeTypeName("#define RPC_NT_NOT_ALL_OBJS_UNEXPORTED ((NTSTATUS)0xC002003BL)")]
    public const int RPC_NT_NOT_ALL_OBJS_UNEXPORTED = unchecked((int)(0xC002003B));

    [NativeTypeName("#define RPC_NT_INTERFACE_NOT_FOUND ((NTSTATUS)0xC002003CL)")]
    public const int RPC_NT_INTERFACE_NOT_FOUND = unchecked((int)(0xC002003C));

    [NativeTypeName("#define RPC_NT_ENTRY_ALREADY_EXISTS ((NTSTATUS)0xC002003DL)")]
    public const int RPC_NT_ENTRY_ALREADY_EXISTS = unchecked((int)(0xC002003D));

    [NativeTypeName("#define RPC_NT_ENTRY_NOT_FOUND ((NTSTATUS)0xC002003EL)")]
    public const int RPC_NT_ENTRY_NOT_FOUND = unchecked((int)(0xC002003E));

    [NativeTypeName("#define RPC_NT_NAME_SERVICE_UNAVAILABLE ((NTSTATUS)0xC002003FL)")]
    public const int RPC_NT_NAME_SERVICE_UNAVAILABLE = unchecked((int)(0xC002003F));

    [NativeTypeName("#define RPC_NT_INVALID_NAF_ID ((NTSTATUS)0xC0020040L)")]
    public const int RPC_NT_INVALID_NAF_ID = unchecked((int)(0xC0020040));

    [NativeTypeName("#define RPC_NT_CANNOT_SUPPORT ((NTSTATUS)0xC0020041L)")]
    public const int RPC_NT_CANNOT_SUPPORT = unchecked((int)(0xC0020041));

    [NativeTypeName("#define RPC_NT_NO_CONTEXT_AVAILABLE ((NTSTATUS)0xC0020042L)")]
    public const int RPC_NT_NO_CONTEXT_AVAILABLE = unchecked((int)(0xC0020042));

    [NativeTypeName("#define RPC_NT_INTERNAL_ERROR ((NTSTATUS)0xC0020043L)")]
    public const int RPC_NT_INTERNAL_ERROR = unchecked((int)(0xC0020043));

    [NativeTypeName("#define RPC_NT_ZERO_DIVIDE ((NTSTATUS)0xC0020044L)")]
    public const int RPC_NT_ZERO_DIVIDE = unchecked((int)(0xC0020044));

    [NativeTypeName("#define RPC_NT_ADDRESS_ERROR ((NTSTATUS)0xC0020045L)")]
    public const int RPC_NT_ADDRESS_ERROR = unchecked((int)(0xC0020045));

    [NativeTypeName("#define RPC_NT_FP_DIV_ZERO ((NTSTATUS)0xC0020046L)")]
    public const int RPC_NT_FP_DIV_ZERO = unchecked((int)(0xC0020046));

    [NativeTypeName("#define RPC_NT_FP_UNDERFLOW ((NTSTATUS)0xC0020047L)")]
    public const int RPC_NT_FP_UNDERFLOW = unchecked((int)(0xC0020047));

    [NativeTypeName("#define RPC_NT_FP_OVERFLOW ((NTSTATUS)0xC0020048L)")]
    public const int RPC_NT_FP_OVERFLOW = unchecked((int)(0xC0020048));

    [NativeTypeName("#define RPC_NT_NO_MORE_ENTRIES ((NTSTATUS)0xC0030001L)")]
    public const int RPC_NT_NO_MORE_ENTRIES = unchecked((int)(0xC0030001));

    [NativeTypeName("#define RPC_NT_SS_CHAR_TRANS_OPEN_FAIL ((NTSTATUS)0xC0030002L)")]
    public const int RPC_NT_SS_CHAR_TRANS_OPEN_FAIL = unchecked((int)(0xC0030002));

    [NativeTypeName("#define RPC_NT_SS_CHAR_TRANS_SHORT_FILE ((NTSTATUS)0xC0030003L)")]
    public const int RPC_NT_SS_CHAR_TRANS_SHORT_FILE = unchecked((int)(0xC0030003));

    [NativeTypeName("#define RPC_NT_SS_IN_NULL_CONTEXT ((NTSTATUS)0xC0030004L)")]
    public const int RPC_NT_SS_IN_NULL_CONTEXT = unchecked((int)(0xC0030004));

    [NativeTypeName("#define RPC_NT_SS_CONTEXT_MISMATCH ((NTSTATUS)0xC0030005L)")]
    public const int RPC_NT_SS_CONTEXT_MISMATCH = unchecked((int)(0xC0030005));

    [NativeTypeName("#define RPC_NT_SS_CONTEXT_DAMAGED ((NTSTATUS)0xC0030006L)")]
    public const int RPC_NT_SS_CONTEXT_DAMAGED = unchecked((int)(0xC0030006));

    [NativeTypeName("#define RPC_NT_SS_HANDLES_MISMATCH ((NTSTATUS)0xC0030007L)")]
    public const int RPC_NT_SS_HANDLES_MISMATCH = unchecked((int)(0xC0030007));

    [NativeTypeName("#define RPC_NT_SS_CANNOT_GET_CALL_HANDLE ((NTSTATUS)0xC0030008L)")]
    public const int RPC_NT_SS_CANNOT_GET_CALL_HANDLE = unchecked((int)(0xC0030008));

    [NativeTypeName("#define RPC_NT_NULL_REF_POINTER ((NTSTATUS)0xC0030009L)")]
    public const int RPC_NT_NULL_REF_POINTER = unchecked((int)(0xC0030009));

    [NativeTypeName("#define RPC_NT_ENUM_VALUE_OUT_OF_RANGE ((NTSTATUS)0xC003000AL)")]
    public const int RPC_NT_ENUM_VALUE_OUT_OF_RANGE = unchecked((int)(0xC003000A));

    [NativeTypeName("#define RPC_NT_BYTE_COUNT_TOO_SMALL ((NTSTATUS)0xC003000BL)")]
    public const int RPC_NT_BYTE_COUNT_TOO_SMALL = unchecked((int)(0xC003000B));

    [NativeTypeName("#define RPC_NT_BAD_STUB_DATA ((NTSTATUS)0xC003000CL)")]
    public const int RPC_NT_BAD_STUB_DATA = unchecked((int)(0xC003000C));

    [NativeTypeName("#define RPC_NT_CALL_IN_PROGRESS ((NTSTATUS)0xC0020049L)")]
    public const int RPC_NT_CALL_IN_PROGRESS = unchecked((int)(0xC0020049));

    [NativeTypeName("#define RPC_NT_NO_MORE_BINDINGS ((NTSTATUS)0xC002004AL)")]
    public const int RPC_NT_NO_MORE_BINDINGS = unchecked((int)(0xC002004A));

    [NativeTypeName("#define RPC_NT_GROUP_MEMBER_NOT_FOUND ((NTSTATUS)0xC002004BL)")]
    public const int RPC_NT_GROUP_MEMBER_NOT_FOUND = unchecked((int)(0xC002004B));

    [NativeTypeName("#define RPC_NT_INVALID_OBJECT ((NTSTATUS)0xC002004DL)")]
    public const int RPC_NT_INVALID_OBJECT = unchecked((int)(0xC002004D));

    [NativeTypeName("#define RPC_NT_NO_INTERFACES ((NTSTATUS)0xC002004FL)")]
    public const int RPC_NT_NO_INTERFACES = unchecked((int)(0xC002004F));

    [NativeTypeName("#define RPC_NT_CALL_CANCELLED ((NTSTATUS)0xC0020050L)")]
    public const int RPC_NT_CALL_CANCELLED = unchecked((int)(0xC0020050));

    [NativeTypeName("#define RPC_NT_BINDING_INCOMPLETE ((NTSTATUS)0xC0020051L)")]
    public const int RPC_NT_BINDING_INCOMPLETE = unchecked((int)(0xC0020051));

    [NativeTypeName("#define RPC_NT_COMM_FAILURE ((NTSTATUS)0xC0020052L)")]
    public const int RPC_NT_COMM_FAILURE = unchecked((int)(0xC0020052));

    [NativeTypeName("#define RPC_NT_UNSUPPORTED_AUTHN_LEVEL ((NTSTATUS)0xC0020053L)")]
    public const int RPC_NT_UNSUPPORTED_AUTHN_LEVEL = unchecked((int)(0xC0020053));

    [NativeTypeName("#define RPC_NT_NO_PRINC_NAME ((NTSTATUS)0xC0020054L)")]
    public const int RPC_NT_NO_PRINC_NAME = unchecked((int)(0xC0020054));

    [NativeTypeName("#define RPC_NT_NOT_RPC_ERROR ((NTSTATUS)0xC0020055L)")]
    public const int RPC_NT_NOT_RPC_ERROR = unchecked((int)(0xC0020055));

    [NativeTypeName("#define RPC_NT_UUID_LOCAL_ONLY ((NTSTATUS)0x40020056L)")]
    public const int RPC_NT_UUID_LOCAL_ONLY = ((int)(0x40020056));

    [NativeTypeName("#define RPC_NT_SEC_PKG_ERROR ((NTSTATUS)0xC0020057L)")]
    public const int RPC_NT_SEC_PKG_ERROR = unchecked((int)(0xC0020057));

    [NativeTypeName("#define RPC_NT_NOT_CANCELLED ((NTSTATUS)0xC0020058L)")]
    public const int RPC_NT_NOT_CANCELLED = unchecked((int)(0xC0020058));

    [NativeTypeName("#define RPC_NT_INVALID_ES_ACTION ((NTSTATUS)0xC0030059L)")]
    public const int RPC_NT_INVALID_ES_ACTION = unchecked((int)(0xC0030059));

    [NativeTypeName("#define RPC_NT_WRONG_ES_VERSION ((NTSTATUS)0xC003005AL)")]
    public const int RPC_NT_WRONG_ES_VERSION = unchecked((int)(0xC003005A));

    [NativeTypeName("#define RPC_NT_WRONG_STUB_VERSION ((NTSTATUS)0xC003005BL)")]
    public const int RPC_NT_WRONG_STUB_VERSION = unchecked((int)(0xC003005B));

    [NativeTypeName("#define RPC_NT_INVALID_PIPE_OBJECT ((NTSTATUS)0xC003005CL)")]
    public const int RPC_NT_INVALID_PIPE_OBJECT = unchecked((int)(0xC003005C));

    [NativeTypeName("#define RPC_NT_INVALID_PIPE_OPERATION ((NTSTATUS)0xC003005DL)")]
    public const int RPC_NT_INVALID_PIPE_OPERATION = unchecked((int)(0xC003005D));

    [NativeTypeName("#define RPC_NT_WRONG_PIPE_VERSION ((NTSTATUS)0xC003005EL)")]
    public const int RPC_NT_WRONG_PIPE_VERSION = unchecked((int)(0xC003005E));

    [NativeTypeName("#define RPC_NT_PIPE_CLOSED ((NTSTATUS)0xC003005FL)")]
    public const int RPC_NT_PIPE_CLOSED = unchecked((int)(0xC003005F));

    [NativeTypeName("#define RPC_NT_PIPE_DISCIPLINE_ERROR ((NTSTATUS)0xC0030060L)")]
    public const int RPC_NT_PIPE_DISCIPLINE_ERROR = unchecked((int)(0xC0030060));

    [NativeTypeName("#define RPC_NT_PIPE_EMPTY ((NTSTATUS)0xC0030061L)")]
    public const int RPC_NT_PIPE_EMPTY = unchecked((int)(0xC0030061));

    [NativeTypeName("#define RPC_NT_INVALID_ASYNC_HANDLE ((NTSTATUS)0xC0020062L)")]
    public const int RPC_NT_INVALID_ASYNC_HANDLE = unchecked((int)(0xC0020062));

    [NativeTypeName("#define RPC_NT_INVALID_ASYNC_CALL ((NTSTATUS)0xC0020063L)")]
    public const int RPC_NT_INVALID_ASYNC_CALL = unchecked((int)(0xC0020063));

    [NativeTypeName("#define RPC_NT_PROXY_ACCESS_DENIED ((NTSTATUS)0xC0020064L)")]
    public const int RPC_NT_PROXY_ACCESS_DENIED = unchecked((int)(0xC0020064));

    [NativeTypeName("#define RPC_NT_COOKIE_AUTH_FAILED ((NTSTATUS)0xC0020065L)")]
    public const int RPC_NT_COOKIE_AUTH_FAILED = unchecked((int)(0xC0020065));

    [NativeTypeName("#define RPC_NT_SEND_INCOMPLETE ((NTSTATUS)0x400200AFL)")]
    public const int RPC_NT_SEND_INCOMPLETE = ((int)(0x400200AF));
}
