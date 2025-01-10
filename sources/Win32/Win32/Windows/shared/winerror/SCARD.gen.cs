// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class SCARD
{
    [NativeTypeName("#define SCARD_S_SUCCESS NO_ERROR")]
    public const int SCARD_S_SUCCESS = 0;

    [NativeTypeName("#define SCARD_F_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x80100001L)")]
    public const int SCARD_F_INTERNAL_ERROR = unchecked((int)(0x80100001));

    [NativeTypeName("#define SCARD_E_CANCELLED _HRESULT_TYPEDEF_(0x80100002L)")]
    public const int SCARD_E_CANCELLED = unchecked((int)(0x80100002));

    [NativeTypeName("#define SCARD_E_INVALID_HANDLE _HRESULT_TYPEDEF_(0x80100003L)")]
    public const int SCARD_E_INVALID_HANDLE = unchecked((int)(0x80100003));

    [NativeTypeName("#define SCARD_E_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x80100004L)")]
    public const int SCARD_E_INVALID_PARAMETER = unchecked((int)(0x80100004));

    [NativeTypeName("#define SCARD_E_INVALID_TARGET _HRESULT_TYPEDEF_(0x80100005L)")]
    public const int SCARD_E_INVALID_TARGET = unchecked((int)(0x80100005));

    [NativeTypeName("#define SCARD_E_NO_MEMORY _HRESULT_TYPEDEF_(0x80100006L)")]
    public const int SCARD_E_NO_MEMORY = unchecked((int)(0x80100006));

    [NativeTypeName("#define SCARD_F_WAITED_TOO_LONG _HRESULT_TYPEDEF_(0x80100007L)")]
    public const int SCARD_F_WAITED_TOO_LONG = unchecked((int)(0x80100007));

    [NativeTypeName("#define SCARD_E_INSUFFICIENT_BUFFER _HRESULT_TYPEDEF_(0x80100008L)")]
    public const int SCARD_E_INSUFFICIENT_BUFFER = unchecked((int)(0x80100008));

    [NativeTypeName("#define SCARD_E_UNKNOWN_READER _HRESULT_TYPEDEF_(0x80100009L)")]
    public const int SCARD_E_UNKNOWN_READER = unchecked((int)(0x80100009));

    [NativeTypeName("#define SCARD_E_TIMEOUT _HRESULT_TYPEDEF_(0x8010000AL)")]
    public const int SCARD_E_TIMEOUT = unchecked((int)(0x8010000A));

    [NativeTypeName("#define SCARD_E_SHARING_VIOLATION _HRESULT_TYPEDEF_(0x8010000BL)")]
    public const int SCARD_E_SHARING_VIOLATION = unchecked((int)(0x8010000B));

    [NativeTypeName("#define SCARD_E_NO_SMARTCARD _HRESULT_TYPEDEF_(0x8010000CL)")]
    public const int SCARD_E_NO_SMARTCARD = unchecked((int)(0x8010000C));

    [NativeTypeName("#define SCARD_E_UNKNOWN_CARD _HRESULT_TYPEDEF_(0x8010000DL)")]
    public const int SCARD_E_UNKNOWN_CARD = unchecked((int)(0x8010000D));

    [NativeTypeName("#define SCARD_E_CANT_DISPOSE _HRESULT_TYPEDEF_(0x8010000EL)")]
    public const int SCARD_E_CANT_DISPOSE = unchecked((int)(0x8010000E));

    [NativeTypeName("#define SCARD_E_PROTO_MISMATCH _HRESULT_TYPEDEF_(0x8010000FL)")]
    public const int SCARD_E_PROTO_MISMATCH = unchecked((int)(0x8010000F));

    [NativeTypeName("#define SCARD_E_NOT_READY _HRESULT_TYPEDEF_(0x80100010L)")]
    public const int SCARD_E_NOT_READY = unchecked((int)(0x80100010));

    [NativeTypeName("#define SCARD_E_INVALID_VALUE _HRESULT_TYPEDEF_(0x80100011L)")]
    public const int SCARD_E_INVALID_VALUE = unchecked((int)(0x80100011));

    [NativeTypeName("#define SCARD_E_SYSTEM_CANCELLED _HRESULT_TYPEDEF_(0x80100012L)")]
    public const int SCARD_E_SYSTEM_CANCELLED = unchecked((int)(0x80100012));

    [NativeTypeName("#define SCARD_F_COMM_ERROR _HRESULT_TYPEDEF_(0x80100013L)")]
    public const int SCARD_F_COMM_ERROR = unchecked((int)(0x80100013));

    [NativeTypeName("#define SCARD_F_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80100014L)")]
    public const int SCARD_F_UNKNOWN_ERROR = unchecked((int)(0x80100014));

    [NativeTypeName("#define SCARD_E_INVALID_ATR _HRESULT_TYPEDEF_(0x80100015L)")]
    public const int SCARD_E_INVALID_ATR = unchecked((int)(0x80100015));

    [NativeTypeName("#define SCARD_E_NOT_TRANSACTED _HRESULT_TYPEDEF_(0x80100016L)")]
    public const int SCARD_E_NOT_TRANSACTED = unchecked((int)(0x80100016));

    [NativeTypeName("#define SCARD_E_READER_UNAVAILABLE _HRESULT_TYPEDEF_(0x80100017L)")]
    public const int SCARD_E_READER_UNAVAILABLE = unchecked((int)(0x80100017));

    [NativeTypeName("#define SCARD_P_SHUTDOWN _HRESULT_TYPEDEF_(0x80100018L)")]
    public const int SCARD_P_SHUTDOWN = unchecked((int)(0x80100018));

    [NativeTypeName("#define SCARD_E_PCI_TOO_SMALL _HRESULT_TYPEDEF_(0x80100019L)")]
    public const int SCARD_E_PCI_TOO_SMALL = unchecked((int)(0x80100019));

    [NativeTypeName("#define SCARD_E_READER_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001AL)")]
    public const int SCARD_E_READER_UNSUPPORTED = unchecked((int)(0x8010001A));

    [NativeTypeName("#define SCARD_E_DUPLICATE_READER _HRESULT_TYPEDEF_(0x8010001BL)")]
    public const int SCARD_E_DUPLICATE_READER = unchecked((int)(0x8010001B));

    [NativeTypeName("#define SCARD_E_CARD_UNSUPPORTED _HRESULT_TYPEDEF_(0x8010001CL)")]
    public const int SCARD_E_CARD_UNSUPPORTED = unchecked((int)(0x8010001C));

    [NativeTypeName("#define SCARD_E_NO_SERVICE _HRESULT_TYPEDEF_(0x8010001DL)")]
    public const int SCARD_E_NO_SERVICE = unchecked((int)(0x8010001D));

    [NativeTypeName("#define SCARD_E_SERVICE_STOPPED _HRESULT_TYPEDEF_(0x8010001EL)")]
    public const int SCARD_E_SERVICE_STOPPED = unchecked((int)(0x8010001E));

    [NativeTypeName("#define SCARD_E_UNEXPECTED _HRESULT_TYPEDEF_(0x8010001FL)")]
    public const int SCARD_E_UNEXPECTED = unchecked((int)(0x8010001F));

    [NativeTypeName("#define SCARD_E_ICC_INSTALLATION _HRESULT_TYPEDEF_(0x80100020L)")]
    public const int SCARD_E_ICC_INSTALLATION = unchecked((int)(0x80100020));

    [NativeTypeName("#define SCARD_E_ICC_CREATEORDER _HRESULT_TYPEDEF_(0x80100021L)")]
    public const int SCARD_E_ICC_CREATEORDER = unchecked((int)(0x80100021));

    [NativeTypeName("#define SCARD_E_UNSUPPORTED_FEATURE _HRESULT_TYPEDEF_(0x80100022L)")]
    public const int SCARD_E_UNSUPPORTED_FEATURE = unchecked((int)(0x80100022));

    [NativeTypeName("#define SCARD_E_DIR_NOT_FOUND _HRESULT_TYPEDEF_(0x80100023L)")]
    public const int SCARD_E_DIR_NOT_FOUND = unchecked((int)(0x80100023));

    [NativeTypeName("#define SCARD_E_FILE_NOT_FOUND _HRESULT_TYPEDEF_(0x80100024L)")]
    public const int SCARD_E_FILE_NOT_FOUND = unchecked((int)(0x80100024));

    [NativeTypeName("#define SCARD_E_NO_DIR _HRESULT_TYPEDEF_(0x80100025L)")]
    public const int SCARD_E_NO_DIR = unchecked((int)(0x80100025));

    [NativeTypeName("#define SCARD_E_NO_FILE _HRESULT_TYPEDEF_(0x80100026L)")]
    public const int SCARD_E_NO_FILE = unchecked((int)(0x80100026));

    [NativeTypeName("#define SCARD_E_NO_ACCESS _HRESULT_TYPEDEF_(0x80100027L)")]
    public const int SCARD_E_NO_ACCESS = unchecked((int)(0x80100027));

    [NativeTypeName("#define SCARD_E_WRITE_TOO_MANY _HRESULT_TYPEDEF_(0x80100028L)")]
    public const int SCARD_E_WRITE_TOO_MANY = unchecked((int)(0x80100028));

    [NativeTypeName("#define SCARD_E_BAD_SEEK _HRESULT_TYPEDEF_(0x80100029L)")]
    public const int SCARD_E_BAD_SEEK = unchecked((int)(0x80100029));

    [NativeTypeName("#define SCARD_E_INVALID_CHV _HRESULT_TYPEDEF_(0x8010002AL)")]
    public const int SCARD_E_INVALID_CHV = unchecked((int)(0x8010002A));

    [NativeTypeName("#define SCARD_E_UNKNOWN_RES_MNG _HRESULT_TYPEDEF_(0x8010002BL)")]
    public const int SCARD_E_UNKNOWN_RES_MNG = unchecked((int)(0x8010002B));

    [NativeTypeName("#define SCARD_E_NO_SUCH_CERTIFICATE _HRESULT_TYPEDEF_(0x8010002CL)")]
    public const int SCARD_E_NO_SUCH_CERTIFICATE = unchecked((int)(0x8010002C));

    [NativeTypeName("#define SCARD_E_CERTIFICATE_UNAVAILABLE _HRESULT_TYPEDEF_(0x8010002DL)")]
    public const int SCARD_E_CERTIFICATE_UNAVAILABLE = unchecked((int)(0x8010002D));

    [NativeTypeName("#define SCARD_E_NO_READERS_AVAILABLE _HRESULT_TYPEDEF_(0x8010002EL)")]
    public const int SCARD_E_NO_READERS_AVAILABLE = unchecked((int)(0x8010002E));

    [NativeTypeName("#define SCARD_E_COMM_DATA_LOST _HRESULT_TYPEDEF_(0x8010002FL)")]
    public const int SCARD_E_COMM_DATA_LOST = unchecked((int)(0x8010002F));

    [NativeTypeName("#define SCARD_E_NO_KEY_CONTAINER _HRESULT_TYPEDEF_(0x80100030L)")]
    public const int SCARD_E_NO_KEY_CONTAINER = unchecked((int)(0x80100030));

    [NativeTypeName("#define SCARD_E_SERVER_TOO_BUSY _HRESULT_TYPEDEF_(0x80100031L)")]
    public const int SCARD_E_SERVER_TOO_BUSY = unchecked((int)(0x80100031));

    [NativeTypeName("#define SCARD_E_PIN_CACHE_EXPIRED _HRESULT_TYPEDEF_(0x80100032L)")]
    public const int SCARD_E_PIN_CACHE_EXPIRED = unchecked((int)(0x80100032));

    [NativeTypeName("#define SCARD_E_NO_PIN_CACHE _HRESULT_TYPEDEF_(0x80100033L)")]
    public const int SCARD_E_NO_PIN_CACHE = unchecked((int)(0x80100033));

    [NativeTypeName("#define SCARD_E_READ_ONLY_CARD _HRESULT_TYPEDEF_(0x80100034L)")]
    public const int SCARD_E_READ_ONLY_CARD = unchecked((int)(0x80100034));

    [NativeTypeName("#define SCARD_W_UNSUPPORTED_CARD _HRESULT_TYPEDEF_(0x80100065L)")]
    public const int SCARD_W_UNSUPPORTED_CARD = unchecked((int)(0x80100065));

    [NativeTypeName("#define SCARD_W_UNRESPONSIVE_CARD _HRESULT_TYPEDEF_(0x80100066L)")]
    public const int SCARD_W_UNRESPONSIVE_CARD = unchecked((int)(0x80100066));

    [NativeTypeName("#define SCARD_W_UNPOWERED_CARD _HRESULT_TYPEDEF_(0x80100067L)")]
    public const int SCARD_W_UNPOWERED_CARD = unchecked((int)(0x80100067));

    [NativeTypeName("#define SCARD_W_RESET_CARD _HRESULT_TYPEDEF_(0x80100068L)")]
    public const int SCARD_W_RESET_CARD = unchecked((int)(0x80100068));

    [NativeTypeName("#define SCARD_W_REMOVED_CARD _HRESULT_TYPEDEF_(0x80100069L)")]
    public const int SCARD_W_REMOVED_CARD = unchecked((int)(0x80100069));

    [NativeTypeName("#define SCARD_W_SECURITY_VIOLATION _HRESULT_TYPEDEF_(0x8010006AL)")]
    public const int SCARD_W_SECURITY_VIOLATION = unchecked((int)(0x8010006A));

    [NativeTypeName("#define SCARD_W_WRONG_CHV _HRESULT_TYPEDEF_(0x8010006BL)")]
    public const int SCARD_W_WRONG_CHV = unchecked((int)(0x8010006B));

    [NativeTypeName("#define SCARD_W_CHV_BLOCKED _HRESULT_TYPEDEF_(0x8010006CL)")]
    public const int SCARD_W_CHV_BLOCKED = unchecked((int)(0x8010006C));

    [NativeTypeName("#define SCARD_W_EOF _HRESULT_TYPEDEF_(0x8010006DL)")]
    public const int SCARD_W_EOF = unchecked((int)(0x8010006D));

    [NativeTypeName("#define SCARD_W_CANCELLED_BY_USER _HRESULT_TYPEDEF_(0x8010006EL)")]
    public const int SCARD_W_CANCELLED_BY_USER = unchecked((int)(0x8010006E));

    [NativeTypeName("#define SCARD_W_CARD_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x8010006FL)")]
    public const int SCARD_W_CARD_NOT_AUTHENTICATED = unchecked((int)(0x8010006F));

    [NativeTypeName("#define SCARD_W_CACHE_ITEM_NOT_FOUND _HRESULT_TYPEDEF_(0x80100070L)")]
    public const int SCARD_W_CACHE_ITEM_NOT_FOUND = unchecked((int)(0x80100070));

    [NativeTypeName("#define SCARD_W_CACHE_ITEM_STALE _HRESULT_TYPEDEF_(0x80100071L)")]
    public const int SCARD_W_CACHE_ITEM_STALE = unchecked((int)(0x80100071));

    [NativeTypeName("#define SCARD_W_CACHE_ITEM_TOO_BIG _HRESULT_TYPEDEF_(0x80100072L)")]
    public const int SCARD_W_CACHE_ITEM_TOO_BIG = unchecked((int)(0x80100072));
}
