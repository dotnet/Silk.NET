// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class RPC
{
    [NativeTypeName("#define RPC_S_INVALID_STRING_BINDING 1700L")]
    public const int RPC_S_INVALID_STRING_BINDING = 1700;
    [NativeTypeName("#define RPC_S_WRONG_KIND_OF_BINDING 1701L")]
    public const int RPC_S_WRONG_KIND_OF_BINDING = 1701;
    [NativeTypeName("#define RPC_S_INVALID_BINDING 1702L")]
    public const int RPC_S_INVALID_BINDING = 1702;
    [NativeTypeName("#define RPC_S_PROTSEQ_NOT_SUPPORTED 1703L")]
    public const int RPC_S_PROTSEQ_NOT_SUPPORTED = 1703;
    [NativeTypeName("#define RPC_S_INVALID_RPC_PROTSEQ 1704L")]
    public const int RPC_S_INVALID_RPC_PROTSEQ = 1704;
    [NativeTypeName("#define RPC_S_INVALID_STRING_UUID 1705L")]
    public const int RPC_S_INVALID_STRING_UUID = 1705;
    [NativeTypeName("#define RPC_S_INVALID_ENDPOINT_FORMAT 1706L")]
    public const int RPC_S_INVALID_ENDPOINT_FORMAT = 1706;
    [NativeTypeName("#define RPC_S_INVALID_NET_ADDR 1707L")]
    public const int RPC_S_INVALID_NET_ADDR = 1707;
    [NativeTypeName("#define RPC_S_NO_ENDPOINT_FOUND 1708L")]
    public const int RPC_S_NO_ENDPOINT_FOUND = 1708;
    [NativeTypeName("#define RPC_S_INVALID_TIMEOUT 1709L")]
    public const int RPC_S_INVALID_TIMEOUT = 1709;
    [NativeTypeName("#define RPC_S_OBJECT_NOT_FOUND 1710L")]
    public const int RPC_S_OBJECT_NOT_FOUND = 1710;
    [NativeTypeName("#define RPC_S_ALREADY_REGISTERED 1711L")]
    public const int RPC_S_ALREADY_REGISTERED = 1711;
    [NativeTypeName("#define RPC_S_TYPE_ALREADY_REGISTERED 1712L")]
    public const int RPC_S_TYPE_ALREADY_REGISTERED = 1712;
    [NativeTypeName("#define RPC_S_ALREADY_LISTENING 1713L")]
    public const int RPC_S_ALREADY_LISTENING = 1713;
    [NativeTypeName("#define RPC_S_NO_PROTSEQS_REGISTERED 1714L")]
    public const int RPC_S_NO_PROTSEQS_REGISTERED = 1714;
    [NativeTypeName("#define RPC_S_NOT_LISTENING 1715L")]
    public const int RPC_S_NOT_LISTENING = 1715;
    [NativeTypeName("#define RPC_S_UNKNOWN_MGR_TYPE 1716L")]
    public const int RPC_S_UNKNOWN_MGR_TYPE = 1716;
    [NativeTypeName("#define RPC_S_UNKNOWN_IF 1717L")]
    public const int RPC_S_UNKNOWN_IF = 1717;
    [NativeTypeName("#define RPC_S_NO_BINDINGS 1718L")]
    public const int RPC_S_NO_BINDINGS = 1718;
    [NativeTypeName("#define RPC_S_NO_PROTSEQS 1719L")]
    public const int RPC_S_NO_PROTSEQS = 1719;
    [NativeTypeName("#define RPC_S_CANT_CREATE_ENDPOINT 1720L")]
    public const int RPC_S_CANT_CREATE_ENDPOINT = 1720;
    [NativeTypeName("#define RPC_S_OUT_OF_RESOURCES 1721L")]
    public const int RPC_S_OUT_OF_RESOURCES = 1721;
    [NativeTypeName("#define RPC_S_SERVER_UNAVAILABLE 1722L")]
    public const int RPC_S_SERVER_UNAVAILABLE = 1722;
    [NativeTypeName("#define RPC_S_SERVER_TOO_BUSY 1723L")]
    public const int RPC_S_SERVER_TOO_BUSY = 1723;
    [NativeTypeName("#define RPC_S_INVALID_NETWORK_OPTIONS 1724L")]
    public const int RPC_S_INVALID_NETWORK_OPTIONS = 1724;
    [NativeTypeName("#define RPC_S_NO_CALL_ACTIVE 1725L")]
    public const int RPC_S_NO_CALL_ACTIVE = 1725;
    [NativeTypeName("#define RPC_S_CALL_FAILED 1726L")]
    public const int RPC_S_CALL_FAILED = 1726;
    [NativeTypeName("#define RPC_S_CALL_FAILED_DNE 1727L")]
    public const int RPC_S_CALL_FAILED_DNE = 1727;
    [NativeTypeName("#define RPC_S_PROTOCOL_ERROR 1728L")]
    public const int RPC_S_PROTOCOL_ERROR = 1728;
    [NativeTypeName("#define RPC_S_PROXY_ACCESS_DENIED 1729L")]
    public const int RPC_S_PROXY_ACCESS_DENIED = 1729;
    [NativeTypeName("#define RPC_S_UNSUPPORTED_TRANS_SYN 1730L")]
    public const int RPC_S_UNSUPPORTED_TRANS_SYN = 1730;
    [NativeTypeName("#define RPC_S_UNSUPPORTED_TYPE 1732L")]
    public const int RPC_S_UNSUPPORTED_TYPE = 1732;
    [NativeTypeName("#define RPC_S_INVALID_TAG 1733L")]
    public const int RPC_S_INVALID_TAG = 1733;
    [NativeTypeName("#define RPC_S_INVALID_BOUND 1734L")]
    public const int RPC_S_INVALID_BOUND = 1734;
    [NativeTypeName("#define RPC_S_NO_ENTRY_NAME 1735L")]
    public const int RPC_S_NO_ENTRY_NAME = 1735;
    [NativeTypeName("#define RPC_S_INVALID_NAME_SYNTAX 1736L")]
    public const int RPC_S_INVALID_NAME_SYNTAX = 1736;
    [NativeTypeName("#define RPC_S_UNSUPPORTED_NAME_SYNTAX 1737L")]
    public const int RPC_S_UNSUPPORTED_NAME_SYNTAX = 1737;
    [NativeTypeName("#define RPC_S_UUID_NO_ADDRESS 1739L")]
    public const int RPC_S_UUID_NO_ADDRESS = 1739;
    [NativeTypeName("#define RPC_S_DUPLICATE_ENDPOINT 1740L")]
    public const int RPC_S_DUPLICATE_ENDPOINT = 1740;
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_TYPE 1741L")]
    public const int RPC_S_UNKNOWN_AUTHN_TYPE = 1741;
    [NativeTypeName("#define RPC_S_MAX_CALLS_TOO_SMALL 1742L")]
    public const int RPC_S_MAX_CALLS_TOO_SMALL = 1742;
    [NativeTypeName("#define RPC_S_STRING_TOO_LONG 1743L")]
    public const int RPC_S_STRING_TOO_LONG = 1743;
    [NativeTypeName("#define RPC_S_PROTSEQ_NOT_FOUND 1744L")]
    public const int RPC_S_PROTSEQ_NOT_FOUND = 1744;
    [NativeTypeName("#define RPC_S_PROCNUM_OUT_OF_RANGE 1745L")]
    public const int RPC_S_PROCNUM_OUT_OF_RANGE = 1745;
    [NativeTypeName("#define RPC_S_BINDING_HAS_NO_AUTH 1746L")]
    public const int RPC_S_BINDING_HAS_NO_AUTH = 1746;
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_SERVICE 1747L")]
    public const int RPC_S_UNKNOWN_AUTHN_SERVICE = 1747;
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHN_LEVEL 1748L")]
    public const int RPC_S_UNKNOWN_AUTHN_LEVEL = 1748;
    [NativeTypeName("#define RPC_S_INVALID_AUTH_IDENTITY 1749L")]
    public const int RPC_S_INVALID_AUTH_IDENTITY = 1749;
    [NativeTypeName("#define RPC_S_UNKNOWN_AUTHZ_SERVICE 1750L")]
    public const int RPC_S_UNKNOWN_AUTHZ_SERVICE = 1750;
    [NativeTypeName("#define RPC_S_NOTHING_TO_EXPORT 1754L")]
    public const int RPC_S_NOTHING_TO_EXPORT = 1754;
    [NativeTypeName("#define RPC_S_INCOMPLETE_NAME 1755L")]
    public const int RPC_S_INCOMPLETE_NAME = 1755;
    [NativeTypeName("#define RPC_S_INVALID_VERS_OPTION 1756L")]
    public const int RPC_S_INVALID_VERS_OPTION = 1756;
    [NativeTypeName("#define RPC_S_NO_MORE_MEMBERS 1757L")]
    public const int RPC_S_NO_MORE_MEMBERS = 1757;
    [NativeTypeName("#define RPC_S_NOT_ALL_OBJS_UNEXPORTED 1758L")]
    public const int RPC_S_NOT_ALL_OBJS_UNEXPORTED = 1758;
    [NativeTypeName("#define RPC_S_INTERFACE_NOT_FOUND 1759L")]
    public const int RPC_S_INTERFACE_NOT_FOUND = 1759;
    [NativeTypeName("#define RPC_S_ENTRY_ALREADY_EXISTS 1760L")]
    public const int RPC_S_ENTRY_ALREADY_EXISTS = 1760;
    [NativeTypeName("#define RPC_S_ENTRY_NOT_FOUND 1761L")]
    public const int RPC_S_ENTRY_NOT_FOUND = 1761;
    [NativeTypeName("#define RPC_S_NAME_SERVICE_UNAVAILABLE 1762L")]
    public const int RPC_S_NAME_SERVICE_UNAVAILABLE = 1762;
    [NativeTypeName("#define RPC_S_INVALID_NAF_ID 1763L")]
    public const int RPC_S_INVALID_NAF_ID = 1763;
    [NativeTypeName("#define RPC_S_CANNOT_SUPPORT 1764L")]
    public const int RPC_S_CANNOT_SUPPORT = 1764;
    [NativeTypeName("#define RPC_S_NO_CONTEXT_AVAILABLE 1765L")]
    public const int RPC_S_NO_CONTEXT_AVAILABLE = 1765;
    [NativeTypeName("#define RPC_S_INTERNAL_ERROR 1766L")]
    public const int RPC_S_INTERNAL_ERROR = 1766;
    [NativeTypeName("#define RPC_S_ZERO_DIVIDE 1767L")]
    public const int RPC_S_ZERO_DIVIDE = 1767;
    [NativeTypeName("#define RPC_S_ADDRESS_ERROR 1768L")]
    public const int RPC_S_ADDRESS_ERROR = 1768;
    [NativeTypeName("#define RPC_S_FP_DIV_ZERO 1769L")]
    public const int RPC_S_FP_DIV_ZERO = 1769;
    [NativeTypeName("#define RPC_S_FP_UNDERFLOW 1770L")]
    public const int RPC_S_FP_UNDERFLOW = 1770;
    [NativeTypeName("#define RPC_S_FP_OVERFLOW 1771L")]
    public const int RPC_S_FP_OVERFLOW = 1771;
    [NativeTypeName("#define RPC_X_NO_MORE_ENTRIES 1772L")]
    public const int RPC_X_NO_MORE_ENTRIES = 1772;
    [NativeTypeName("#define RPC_X_SS_CHAR_TRANS_OPEN_FAIL 1773L")]
    public const int RPC_X_SS_CHAR_TRANS_OPEN_FAIL = 1773;
    [NativeTypeName("#define RPC_X_SS_CHAR_TRANS_SHORT_FILE 1774L")]
    public const int RPC_X_SS_CHAR_TRANS_SHORT_FILE = 1774;
    [NativeTypeName("#define RPC_X_SS_IN_NULL_CONTEXT 1775L")]
    public const int RPC_X_SS_IN_NULL_CONTEXT = 1775;
    [NativeTypeName("#define RPC_X_SS_CONTEXT_DAMAGED 1777L")]
    public const int RPC_X_SS_CONTEXT_DAMAGED = 1777;
    [NativeTypeName("#define RPC_X_SS_HANDLES_MISMATCH 1778L")]
    public const int RPC_X_SS_HANDLES_MISMATCH = 1778;
    [NativeTypeName("#define RPC_X_SS_CANNOT_GET_CALL_HANDLE 1779L")]
    public const int RPC_X_SS_CANNOT_GET_CALL_HANDLE = 1779;
    [NativeTypeName("#define RPC_X_NULL_REF_POINTER 1780L")]
    public const int RPC_X_NULL_REF_POINTER = 1780;
    [NativeTypeName("#define RPC_X_ENUM_VALUE_OUT_OF_RANGE 1781L")]
    public const int RPC_X_ENUM_VALUE_OUT_OF_RANGE = 1781;
    [NativeTypeName("#define RPC_X_BYTE_COUNT_TOO_SMALL 1782L")]
    public const int RPC_X_BYTE_COUNT_TOO_SMALL = 1782;
    [NativeTypeName("#define RPC_X_BAD_STUB_DATA 1783L")]
    public const int RPC_X_BAD_STUB_DATA = 1783;
    [NativeTypeName("#define RPC_S_CALL_IN_PROGRESS 1791L")]
    public const int RPC_S_CALL_IN_PROGRESS = 1791;
    [NativeTypeName("#define RPC_S_NO_MORE_BINDINGS 1806L")]
    public const int RPC_S_NO_MORE_BINDINGS = 1806;
    [NativeTypeName("#define RPC_S_NO_INTERFACES 1817L")]
    public const int RPC_S_NO_INTERFACES = 1817;
    [NativeTypeName("#define RPC_S_CALL_CANCELLED 1818L")]
    public const int RPC_S_CALL_CANCELLED = 1818;
    [NativeTypeName("#define RPC_S_BINDING_INCOMPLETE 1819L")]
    public const int RPC_S_BINDING_INCOMPLETE = 1819;
    [NativeTypeName("#define RPC_S_COMM_FAILURE 1820L")]
    public const int RPC_S_COMM_FAILURE = 1820;
    [NativeTypeName("#define RPC_S_UNSUPPORTED_AUTHN_LEVEL 1821L")]
    public const int RPC_S_UNSUPPORTED_AUTHN_LEVEL = 1821;
    [NativeTypeName("#define RPC_S_NO_PRINC_NAME 1822L")]
    public const int RPC_S_NO_PRINC_NAME = 1822;
    [NativeTypeName("#define RPC_S_NOT_RPC_ERROR 1823L")]
    public const int RPC_S_NOT_RPC_ERROR = 1823;
    [NativeTypeName("#define RPC_S_UUID_LOCAL_ONLY 1824L")]
    public const int RPC_S_UUID_LOCAL_ONLY = 1824;
    [NativeTypeName("#define RPC_S_SEC_PKG_ERROR 1825L")]
    public const int RPC_S_SEC_PKG_ERROR = 1825;
    [NativeTypeName("#define RPC_S_NOT_CANCELLED 1826L")]
    public const int RPC_S_NOT_CANCELLED = 1826;
    [NativeTypeName("#define RPC_X_INVALID_ES_ACTION 1827L")]
    public const int RPC_X_INVALID_ES_ACTION = 1827;
    [NativeTypeName("#define RPC_X_WRONG_ES_VERSION 1828L")]
    public const int RPC_X_WRONG_ES_VERSION = 1828;
    [NativeTypeName("#define RPC_X_WRONG_STUB_VERSION 1829L")]
    public const int RPC_X_WRONG_STUB_VERSION = 1829;
    [NativeTypeName("#define RPC_X_INVALID_PIPE_OBJECT 1830L")]
    public const int RPC_X_INVALID_PIPE_OBJECT = 1830;
    [NativeTypeName("#define RPC_X_WRONG_PIPE_ORDER 1831L")]
    public const int RPC_X_WRONG_PIPE_ORDER = 1831;
    [NativeTypeName("#define RPC_X_WRONG_PIPE_VERSION 1832L")]
    public const int RPC_X_WRONG_PIPE_VERSION = 1832;
    [NativeTypeName("#define RPC_S_COOKIE_AUTH_FAILED 1833L")]
    public const int RPC_S_COOKIE_AUTH_FAILED = 1833;
    [NativeTypeName("#define RPC_S_DO_NOT_DISTURB 1834L")]
    public const int RPC_S_DO_NOT_DISTURB = 1834;
    [NativeTypeName("#define RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED 1835L")]
    public const int RPC_S_SYSTEM_HANDLE_COUNT_EXCEEDED = 1835;
    [NativeTypeName("#define RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH 1836L")]
    public const int RPC_S_SYSTEM_HANDLE_TYPE_MISMATCH = 1836;
    [NativeTypeName("#define RPC_S_GROUP_MEMBER_NOT_FOUND 1898L")]
    public const int RPC_S_GROUP_MEMBER_NOT_FOUND = 1898;
    [NativeTypeName("#define RPC_S_INVALID_OBJECT 1900L")]
    public const int RPC_S_INVALID_OBJECT = 1900;
    [NativeTypeName("#define RPC_S_SEND_INCOMPLETE 1913L")]
    public const int RPC_S_SEND_INCOMPLETE = 1913;
    [NativeTypeName("#define RPC_S_INVALID_ASYNC_HANDLE 1914L")]
    public const int RPC_S_INVALID_ASYNC_HANDLE = 1914;
    [NativeTypeName("#define RPC_S_INVALID_ASYNC_CALL 1915L")]
    public const int RPC_S_INVALID_ASYNC_CALL = 1915;
    [NativeTypeName("#define RPC_X_PIPE_CLOSED 1916L")]
    public const int RPC_X_PIPE_CLOSED = 1916;
    [NativeTypeName("#define RPC_X_PIPE_DISCIPLINE_ERROR 1917L")]
    public const int RPC_X_PIPE_DISCIPLINE_ERROR = 1917;
    [NativeTypeName("#define RPC_X_PIPE_EMPTY 1918L")]
    public const int RPC_X_PIPE_EMPTY = 1918;
    [NativeTypeName("#define RPC_S_ENTRY_TYPE_MISMATCH 1922L")]
    public const int RPC_S_ENTRY_TYPE_MISMATCH = 1922;
    [NativeTypeName("#define RPC_S_NOT_ALL_OBJS_EXPORTED 1923L")]
    public const int RPC_S_NOT_ALL_OBJS_EXPORTED = 1923;
    [NativeTypeName("#define RPC_S_INTERFACE_NOT_EXPORTED 1924L")]
    public const int RPC_S_INTERFACE_NOT_EXPORTED = 1924;
    [NativeTypeName("#define RPC_S_PROFILE_NOT_ADDED 1925L")]
    public const int RPC_S_PROFILE_NOT_ADDED = 1925;
    [NativeTypeName("#define RPC_S_PRF_ELT_NOT_ADDED 1926L")]
    public const int RPC_S_PRF_ELT_NOT_ADDED = 1926;
    [NativeTypeName("#define RPC_S_PRF_ELT_NOT_REMOVED 1927L")]
    public const int RPC_S_PRF_ELT_NOT_REMOVED = 1927;
    [NativeTypeName("#define RPC_S_GRP_ELT_NOT_ADDED 1928L")]
    public const int RPC_S_GRP_ELT_NOT_ADDED = 1928;
    [NativeTypeName("#define RPC_S_GRP_ELT_NOT_REMOVED 1929L")]
    public const int RPC_S_GRP_ELT_NOT_REMOVED = 1929;
    [NativeTypeName("#define RPC_E_CALL_REJECTED _HRESULT_TYPEDEF_(0x80010001L)")]
    public const int RPC_E_CALL_REJECTED = unchecked((int)(0x80010001));
    [NativeTypeName("#define RPC_E_CALL_CANCELED _HRESULT_TYPEDEF_(0x80010002L)")]
    public const int RPC_E_CALL_CANCELED = unchecked((int)(0x80010002));
    [NativeTypeName("#define RPC_E_CANTPOST_INSENDCALL _HRESULT_TYPEDEF_(0x80010003L)")]
    public const int RPC_E_CANTPOST_INSENDCALL = unchecked((int)(0x80010003));
    [NativeTypeName("#define RPC_E_CANTCALLOUT_INASYNCCALL _HRESULT_TYPEDEF_(0x80010004L)")]
    public const int RPC_E_CANTCALLOUT_INASYNCCALL = unchecked((int)(0x80010004));
    [NativeTypeName("#define RPC_E_CANTCALLOUT_INEXTERNALCALL _HRESULT_TYPEDEF_(0x80010005L)")]
    public const int RPC_E_CANTCALLOUT_INEXTERNALCALL = unchecked((int)(0x80010005));
    [NativeTypeName("#define RPC_E_CONNECTION_TERMINATED _HRESULT_TYPEDEF_(0x80010006L)")]
    public const int RPC_E_CONNECTION_TERMINATED = unchecked((int)(0x80010006));
    [NativeTypeName("#define RPC_E_SERVER_DIED _HRESULT_TYPEDEF_(0x80010007L)")]
    public const int RPC_E_SERVER_DIED = unchecked((int)(0x80010007));
    [NativeTypeName("#define RPC_E_CLIENT_DIED _HRESULT_TYPEDEF_(0x80010008L)")]
    public const int RPC_E_CLIENT_DIED = unchecked((int)(0x80010008));
    [NativeTypeName("#define RPC_E_INVALID_DATAPACKET _HRESULT_TYPEDEF_(0x80010009L)")]
    public const int RPC_E_INVALID_DATAPACKET = unchecked((int)(0x80010009));
    [NativeTypeName("#define RPC_E_CANTTRANSMIT_CALL _HRESULT_TYPEDEF_(0x8001000AL)")]
    public const int RPC_E_CANTTRANSMIT_CALL = unchecked((int)(0x8001000A));
    [NativeTypeName("#define RPC_E_CLIENT_CANTMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000BL)")]
    public const int RPC_E_CLIENT_CANTMARSHAL_DATA = unchecked((int)(0x8001000B));
    [NativeTypeName("#define RPC_E_CLIENT_CANTUNMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000CL)")]
    public const int RPC_E_CLIENT_CANTUNMARSHAL_DATA = unchecked((int)(0x8001000C));
    [NativeTypeName("#define RPC_E_SERVER_CANTMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000DL)")]
    public const int RPC_E_SERVER_CANTMARSHAL_DATA = unchecked((int)(0x8001000D));
    [NativeTypeName("#define RPC_E_SERVER_CANTUNMARSHAL_DATA _HRESULT_TYPEDEF_(0x8001000EL)")]
    public const int RPC_E_SERVER_CANTUNMARSHAL_DATA = unchecked((int)(0x8001000E));
    [NativeTypeName("#define RPC_E_INVALID_DATA _HRESULT_TYPEDEF_(0x8001000FL)")]
    public const int RPC_E_INVALID_DATA = unchecked((int)(0x8001000F));
    [NativeTypeName("#define RPC_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80010010L)")]
    public const int RPC_E_INVALID_PARAMETER = unchecked((int)(0x80010010));
    [NativeTypeName("#define RPC_E_CANTCALLOUT_AGAIN _HRESULT_TYPEDEF_(0x80010011L)")]
    public const int RPC_E_CANTCALLOUT_AGAIN = unchecked((int)(0x80010011));
    [NativeTypeName("#define RPC_E_SERVER_DIED_DNE _HRESULT_TYPEDEF_(0x80010012L)")]
    public const int RPC_E_SERVER_DIED_DNE = unchecked((int)(0x80010012));
    [NativeTypeName("#define RPC_E_SYS_CALL_FAILED _HRESULT_TYPEDEF_(0x80010100L)")]
    public const int RPC_E_SYS_CALL_FAILED = unchecked((int)(0x80010100));
    [NativeTypeName("#define RPC_E_OUT_OF_RESOURCES _HRESULT_TYPEDEF_(0x80010101L)")]
    public const int RPC_E_OUT_OF_RESOURCES = unchecked((int)(0x80010101));
    [NativeTypeName("#define RPC_E_ATTEMPTED_MULTITHREAD _HRESULT_TYPEDEF_(0x80010102L)")]
    public const int RPC_E_ATTEMPTED_MULTITHREAD = unchecked((int)(0x80010102));
    [NativeTypeName("#define RPC_E_NOT_REGISTERED _HRESULT_TYPEDEF_(0x80010103L)")]
    public const int RPC_E_NOT_REGISTERED = unchecked((int)(0x80010103));
    [NativeTypeName("#define RPC_E_FAULT _HRESULT_TYPEDEF_(0x80010104L)")]
    public const int RPC_E_FAULT = unchecked((int)(0x80010104));
    [NativeTypeName("#define RPC_E_SERVERFAULT _HRESULT_TYPEDEF_(0x80010105L)")]
    public const int RPC_E_SERVERFAULT = unchecked((int)(0x80010105));
    [NativeTypeName("#define RPC_E_CHANGED_MODE _HRESULT_TYPEDEF_(0x80010106L)")]
    public const int RPC_E_CHANGED_MODE = unchecked((int)(0x80010106));
    [NativeTypeName("#define RPC_E_INVALIDMETHOD _HRESULT_TYPEDEF_(0x80010107L)")]
    public const int RPC_E_INVALIDMETHOD = unchecked((int)(0x80010107));
    [NativeTypeName("#define RPC_E_DISCONNECTED _HRESULT_TYPEDEF_(0x80010108L)")]
    public const int RPC_E_DISCONNECTED = unchecked((int)(0x80010108));
    [NativeTypeName("#define RPC_E_RETRY _HRESULT_TYPEDEF_(0x80010109L)")]
    public const int RPC_E_RETRY = unchecked((int)(0x80010109));
    [NativeTypeName("#define RPC_E_SERVERCALL_RETRYLATER _HRESULT_TYPEDEF_(0x8001010AL)")]
    public const int RPC_E_SERVERCALL_RETRYLATER = unchecked((int)(0x8001010A));
    [NativeTypeName("#define RPC_E_SERVERCALL_REJECTED _HRESULT_TYPEDEF_(0x8001010BL)")]
    public const int RPC_E_SERVERCALL_REJECTED = unchecked((int)(0x8001010B));
    [NativeTypeName("#define RPC_E_INVALID_CALLDATA _HRESULT_TYPEDEF_(0x8001010CL)")]
    public const int RPC_E_INVALID_CALLDATA = unchecked((int)(0x8001010C));
    [NativeTypeName("#define RPC_E_CANTCALLOUT_ININPUTSYNCCALL _HRESULT_TYPEDEF_(0x8001010DL)")]
    public const int RPC_E_CANTCALLOUT_ININPUTSYNCCALL = unchecked((int)(0x8001010D));
    [NativeTypeName("#define RPC_E_WRONG_THREAD _HRESULT_TYPEDEF_(0x8001010EL)")]
    public const int RPC_E_WRONG_THREAD = unchecked((int)(0x8001010E));
    [NativeTypeName("#define RPC_E_THREAD_NOT_INIT _HRESULT_TYPEDEF_(0x8001010FL)")]
    public const int RPC_E_THREAD_NOT_INIT = unchecked((int)(0x8001010F));
    [NativeTypeName("#define RPC_E_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x80010110L)")]
    public const int RPC_E_VERSION_MISMATCH = unchecked((int)(0x80010110));
    [NativeTypeName("#define RPC_E_INVALID_HEADER _HRESULT_TYPEDEF_(0x80010111L)")]
    public const int RPC_E_INVALID_HEADER = unchecked((int)(0x80010111));
    [NativeTypeName("#define RPC_E_INVALID_EXTENSION _HRESULT_TYPEDEF_(0x80010112L)")]
    public const int RPC_E_INVALID_EXTENSION = unchecked((int)(0x80010112));
    [NativeTypeName("#define RPC_E_INVALID_IPID _HRESULT_TYPEDEF_(0x80010113L)")]
    public const int RPC_E_INVALID_IPID = unchecked((int)(0x80010113));
    [NativeTypeName("#define RPC_E_INVALID_OBJECT _HRESULT_TYPEDEF_(0x80010114L)")]
    public const int RPC_E_INVALID_OBJECT = unchecked((int)(0x80010114));
    [NativeTypeName("#define RPC_S_CALLPENDING _HRESULT_TYPEDEF_(0x80010115L)")]
    public const int RPC_S_CALLPENDING = unchecked((int)(0x80010115));
    [NativeTypeName("#define RPC_S_WAITONTIMER _HRESULT_TYPEDEF_(0x80010116L)")]
    public const int RPC_S_WAITONTIMER = unchecked((int)(0x80010116));
    [NativeTypeName("#define RPC_E_CALL_COMPLETE _HRESULT_TYPEDEF_(0x80010117L)")]
    public const int RPC_E_CALL_COMPLETE = unchecked((int)(0x80010117));
    [NativeTypeName("#define RPC_E_UNSECURE_CALL _HRESULT_TYPEDEF_(0x80010118L)")]
    public const int RPC_E_UNSECURE_CALL = unchecked((int)(0x80010118));
    [NativeTypeName("#define RPC_E_TOO_LATE _HRESULT_TYPEDEF_(0x80010119L)")]
    public const int RPC_E_TOO_LATE = unchecked((int)(0x80010119));
    [NativeTypeName("#define RPC_E_NO_GOOD_SECURITY_PACKAGES _HRESULT_TYPEDEF_(0x8001011AL)")]
    public const int RPC_E_NO_GOOD_SECURITY_PACKAGES = unchecked((int)(0x8001011A));
    [NativeTypeName("#define RPC_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x8001011BL)")]
    public const int RPC_E_ACCESS_DENIED = unchecked((int)(0x8001011B));
    [NativeTypeName("#define RPC_E_REMOTE_DISABLED _HRESULT_TYPEDEF_(0x8001011CL)")]
    public const int RPC_E_REMOTE_DISABLED = unchecked((int)(0x8001011C));
    [NativeTypeName("#define RPC_E_INVALID_OBJREF _HRESULT_TYPEDEF_(0x8001011DL)")]
    public const int RPC_E_INVALID_OBJREF = unchecked((int)(0x8001011D));
    [NativeTypeName("#define RPC_E_NO_CONTEXT _HRESULT_TYPEDEF_(0x8001011EL)")]
    public const int RPC_E_NO_CONTEXT = unchecked((int)(0x8001011E));
    [NativeTypeName("#define RPC_E_TIMEOUT _HRESULT_TYPEDEF_(0x8001011FL)")]
    public const int RPC_E_TIMEOUT = unchecked((int)(0x8001011F));
    [NativeTypeName("#define RPC_E_NO_SYNC _HRESULT_TYPEDEF_(0x80010120L)")]
    public const int RPC_E_NO_SYNC = unchecked((int)(0x80010120));
    [NativeTypeName("#define RPC_E_FULLSIC_REQUIRED _HRESULT_TYPEDEF_(0x80010121L)")]
    public const int RPC_E_FULLSIC_REQUIRED = unchecked((int)(0x80010121));
    [NativeTypeName("#define RPC_E_INVALID_STD_NAME _HRESULT_TYPEDEF_(0x80010122L)")]
    public const int RPC_E_INVALID_STD_NAME = unchecked((int)(0x80010122));
    [NativeTypeName("#define RPC_E_UNEXPECTED _HRESULT_TYPEDEF_(0x8001FFFFL)")]
    public const int RPC_E_UNEXPECTED = unchecked((int)(0x8001FFFF));
}