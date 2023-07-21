// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.HRESULT_FROM_WIN32"]/*' />
    public static HRESULT HRESULT_FROM_WIN32([NativeTypeName("unsigned long")] uint x)
    {
        return (HRESULT)(x) <= 0 ? (HRESULT)(x) : (HRESULT)(((x) & 0x0000FFFF) | (7 << 16) | 0x80000000);
    }

    [NativeTypeName("#define NO_ERROR 0L")]
    public const int NO_ERROR = 0;

    [NativeTypeName("#define EPT_S_INVALID_ENTRY 1751L")]
    public const int EPT_S_INVALID_ENTRY = 1751;

    [NativeTypeName("#define EPT_S_CANT_PERFORM_OP 1752L")]
    public const int EPT_S_CANT_PERFORM_OP = 1752;

    [NativeTypeName("#define EPT_S_NOT_REGISTERED 1753L")]
    public const int EPT_S_NOT_REGISTERED = 1753;

    [NativeTypeName("#define EPT_S_CANT_CREATE 1899L")]
    public const int EPT_S_CANT_CREATE = 1899;

    [NativeTypeName("#define OR_INVALID_OXID 1910L")]
    public const int OR_INVALID_OXID = 1910;

    [NativeTypeName("#define OR_INVALID_OID 1911L")]
    public const int OR_INVALID_OID = 1911;

    [NativeTypeName("#define OR_INVALID_SET 1912L")]
    public const int OR_INVALID_SET = 1912;

    [NativeTypeName("#define WSABASEERR 10000")]
    public const int WSABASEERR = 10000;

    [NativeTypeName("#define WSAEINTR 10004L")]
    public const int WSAEINTR = 10004;

    [NativeTypeName("#define WSAEBADF 10009L")]
    public const int WSAEBADF = 10009;

    [NativeTypeName("#define WSAEACCES 10013L")]
    public const int WSAEACCES = 10013;

    [NativeTypeName("#define WSAEFAULT 10014L")]
    public const int WSAEFAULT = 10014;

    [NativeTypeName("#define WSAEINVAL 10022L")]
    public const int WSAEINVAL = 10022;

    [NativeTypeName("#define WSAEMFILE 10024L")]
    public const int WSAEMFILE = 10024;

    [NativeTypeName("#define WSAEWOULDBLOCK 10035L")]
    public const int WSAEWOULDBLOCK = 10035;

    [NativeTypeName("#define WSAEINPROGRESS 10036L")]
    public const int WSAEINPROGRESS = 10036;

    [NativeTypeName("#define WSAEALREADY 10037L")]
    public const int WSAEALREADY = 10037;

    [NativeTypeName("#define WSAENOTSOCK 10038L")]
    public const int WSAENOTSOCK = 10038;

    [NativeTypeName("#define WSAEDESTADDRREQ 10039L")]
    public const int WSAEDESTADDRREQ = 10039;

    [NativeTypeName("#define WSAEMSGSIZE 10040L")]
    public const int WSAEMSGSIZE = 10040;

    [NativeTypeName("#define WSAEPROTOTYPE 10041L")]
    public const int WSAEPROTOTYPE = 10041;

    [NativeTypeName("#define WSAENOPROTOOPT 10042L")]
    public const int WSAENOPROTOOPT = 10042;

    [NativeTypeName("#define WSAEPROTONOSUPPORT 10043L")]
    public const int WSAEPROTONOSUPPORT = 10043;

    [NativeTypeName("#define WSAESOCKTNOSUPPORT 10044L")]
    public const int WSAESOCKTNOSUPPORT = 10044;

    [NativeTypeName("#define WSAEOPNOTSUPP 10045L")]
    public const int WSAEOPNOTSUPP = 10045;

    [NativeTypeName("#define WSAEPFNOSUPPORT 10046L")]
    public const int WSAEPFNOSUPPORT = 10046;

    [NativeTypeName("#define WSAEAFNOSUPPORT 10047L")]
    public const int WSAEAFNOSUPPORT = 10047;

    [NativeTypeName("#define WSAEADDRINUSE 10048L")]
    public const int WSAEADDRINUSE = 10048;

    [NativeTypeName("#define WSAEADDRNOTAVAIL 10049L")]
    public const int WSAEADDRNOTAVAIL = 10049;

    [NativeTypeName("#define WSAENETDOWN 10050L")]
    public const int WSAENETDOWN = 10050;

    [NativeTypeName("#define WSAENETUNREACH 10051L")]
    public const int WSAENETUNREACH = 10051;

    [NativeTypeName("#define WSAENETRESET 10052L")]
    public const int WSAENETRESET = 10052;

    [NativeTypeName("#define WSAECONNABORTED 10053L")]
    public const int WSAECONNABORTED = 10053;

    [NativeTypeName("#define WSAECONNRESET 10054L")]
    public const int WSAECONNRESET = 10054;

    [NativeTypeName("#define WSAENOBUFS 10055L")]
    public const int WSAENOBUFS = 10055;

    [NativeTypeName("#define WSAEISCONN 10056L")]
    public const int WSAEISCONN = 10056;

    [NativeTypeName("#define WSAENOTCONN 10057L")]
    public const int WSAENOTCONN = 10057;

    [NativeTypeName("#define WSAESHUTDOWN 10058L")]
    public const int WSAESHUTDOWN = 10058;

    [NativeTypeName("#define WSAETOOMANYREFS 10059L")]
    public const int WSAETOOMANYREFS = 10059;

    [NativeTypeName("#define WSAETIMEDOUT 10060L")]
    public const int WSAETIMEDOUT = 10060;

    [NativeTypeName("#define WSAECONNREFUSED 10061L")]
    public const int WSAECONNREFUSED = 10061;

    [NativeTypeName("#define WSAELOOP 10062L")]
    public const int WSAELOOP = 10062;

    [NativeTypeName("#define WSAENAMETOOLONG 10063L")]
    public const int WSAENAMETOOLONG = 10063;

    [NativeTypeName("#define WSAEHOSTDOWN 10064L")]
    public const int WSAEHOSTDOWN = 10064;

    [NativeTypeName("#define WSAEHOSTUNREACH 10065L")]
    public const int WSAEHOSTUNREACH = 10065;

    [NativeTypeName("#define WSAENOTEMPTY 10066L")]
    public const int WSAENOTEMPTY = 10066;

    [NativeTypeName("#define WSAEPROCLIM 10067L")]
    public const int WSAEPROCLIM = 10067;

    [NativeTypeName("#define WSAEUSERS 10068L")]
    public const int WSAEUSERS = 10068;

    [NativeTypeName("#define WSAEDQUOT 10069L")]
    public const int WSAEDQUOT = 10069;

    [NativeTypeName("#define WSAESTALE 10070L")]
    public const int WSAESTALE = 10070;

    [NativeTypeName("#define WSAEREMOTE 10071L")]
    public const int WSAEREMOTE = 10071;

    [NativeTypeName("#define WSASYSNOTREADY 10091L")]
    public const int WSASYSNOTREADY = 10091;

    [NativeTypeName("#define WSAVERNOTSUPPORTED 10092L")]
    public const int WSAVERNOTSUPPORTED = 10092;

    [NativeTypeName("#define WSANOTINITIALISED 10093L")]
    public const int WSANOTINITIALISED = 10093;

    [NativeTypeName("#define WSAEDISCON 10101L")]
    public const int WSAEDISCON = 10101;

    [NativeTypeName("#define WSAENOMORE 10102L")]
    public const int WSAENOMORE = 10102;

    [NativeTypeName("#define WSAECANCELLED 10103L")]
    public const int WSAECANCELLED = 10103;

    [NativeTypeName("#define WSAEINVALIDPROCTABLE 10104L")]
    public const int WSAEINVALIDPROCTABLE = 10104;

    [NativeTypeName("#define WSAEINVALIDPROVIDER 10105L")]
    public const int WSAEINVALIDPROVIDER = 10105;

    [NativeTypeName("#define WSAEPROVIDERFAILEDINIT 10106L")]
    public const int WSAEPROVIDERFAILEDINIT = 10106;

    [NativeTypeName("#define WSASYSCALLFAILURE 10107L")]
    public const int WSASYSCALLFAILURE = 10107;

    [NativeTypeName("#define WSASERVICE_NOT_FOUND 10108L")]
    public const int WSASERVICE_NOT_FOUND = 10108;

    [NativeTypeName("#define WSATYPE_NOT_FOUND 10109L")]
    public const int WSATYPE_NOT_FOUND = 10109;

    [NativeTypeName("#define WSAEREFUSED 10112L")]
    public const int WSAEREFUSED = 10112;

    [NativeTypeName("#define WSAHOST_NOT_FOUND 11001L")]
    public const int WSAHOST_NOT_FOUND = 11001;

    [NativeTypeName("#define WSATRY_AGAIN 11002L")]
    public const int WSATRY_AGAIN = 11002;

    [NativeTypeName("#define WSANO_RECOVERY 11003L")]
    public const int WSANO_RECOVERY = 11003;

    [NativeTypeName("#define WSANO_DATA 11004L")]
    public const int WSANO_DATA = 11004;

    [NativeTypeName("#define WARNING_IPSEC_MM_POLICY_PRUNED 13024L")]
    public const int WARNING_IPSEC_MM_POLICY_PRUNED = 13024;

    [NativeTypeName("#define WARNING_IPSEC_QM_POLICY_PRUNED 13025L")]
    public const int WARNING_IPSEC_QM_POLICY_PRUNED = 13025;

    [NativeTypeName("#define APPMODEL_ERROR_NO_PACKAGE 15700L")]
    public const int APPMODEL_ERROR_NO_PACKAGE = 15700;

    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT 15701L")]
    public const int APPMODEL_ERROR_PACKAGE_RUNTIME_CORRUPT = 15701;

    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT 15702L")]
    public const int APPMODEL_ERROR_PACKAGE_IDENTITY_CORRUPT = 15702;

    [NativeTypeName("#define APPMODEL_ERROR_NO_APPLICATION 15703L")]
    public const int APPMODEL_ERROR_NO_APPLICATION = 15703;

    [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED 15704L")]
    public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_READ_FAILED = 15704;

    [NativeTypeName("#define APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID 15705L")]
    public const int APPMODEL_ERROR_DYNAMIC_PROPERTY_INVALID = 15705;

    [NativeTypeName("#define APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE 15706L")]
    public const int APPMODEL_ERROR_PACKAGE_NOT_AVAILABLE = 15706;

    [NativeTypeName("#define APPMODEL_ERROR_NO_MUTABLE_DIRECTORY 15707L")]
    public const int APPMODEL_ERROR_NO_MUTABLE_DIRECTORY = 15707;

    [NativeTypeName("#define STORE_ERROR_UNLICENSED 15861L")]
    public const int STORE_ERROR_UNLICENSED = 15861;

    [NativeTypeName("#define STORE_ERROR_UNLICENSED_USER 15862L")]
    public const int STORE_ERROR_UNLICENSED_USER = 15862;

    [NativeTypeName("#define STORE_ERROR_PENDING_COM_TRANSACTION 15863L")]
    public const int STORE_ERROR_PENDING_COM_TRANSACTION = 15863;

    [NativeTypeName("#define STORE_ERROR_LICENSE_REVOKED 15864L")]
    public const int STORE_ERROR_LICENSE_REVOKED = 15864;

    [NativeTypeName("#define SEVERITY_SUCCESS 0")]
    public const int SEVERITY_SUCCESS = 0;

    [NativeTypeName("#define SEVERITY_ERROR 1")]
    public const int SEVERITY_ERROR = 1;

    [NativeTypeName("#define NOERROR 0")]
    public const int NOERROR = 0;

    [NativeTypeName("#define CLASSFACTORY_E_FIRST 0x80040110L")]
    public const uint CLASSFACTORY_E_FIRST = 0x80040110;

    [NativeTypeName("#define CLASSFACTORY_E_LAST 0x8004011FL")]
    public const uint CLASSFACTORY_E_LAST = 0x8004011F;

    [NativeTypeName("#define CLASSFACTORY_S_FIRST 0x00040110L")]
    public const int CLASSFACTORY_S_FIRST = 0x00040110;

    [NativeTypeName("#define CLASSFACTORY_S_LAST 0x0004011FL")]
    public const int CLASSFACTORY_S_LAST = 0x0004011F;

    [NativeTypeName("#define CLASS_E_NOAGGREGATION _HRESULT_TYPEDEF_(0x80040110L)")]
    public const int CLASS_E_NOAGGREGATION = unchecked((int)(0x80040110));

    [NativeTypeName("#define CLASS_E_CLASSNOTAVAILABLE _HRESULT_TYPEDEF_(0x80040111L)")]
    public const int CLASS_E_CLASSNOTAVAILABLE = unchecked((int)(0x80040111));

    [NativeTypeName("#define CLASS_E_NOTLICENSED _HRESULT_TYPEDEF_(0x80040112L)")]
    public const int CLASS_E_NOTLICENSED = unchecked((int)(0x80040112));

    [NativeTypeName("#define MARSHAL_E_FIRST 0x80040120L")]
    public const uint MARSHAL_E_FIRST = 0x80040120;

    [NativeTypeName("#define MARSHAL_E_LAST 0x8004012FL")]
    public const uint MARSHAL_E_LAST = 0x8004012F;

    [NativeTypeName("#define MARSHAL_S_FIRST 0x00040120L")]
    public const int MARSHAL_S_FIRST = 0x00040120;

    [NativeTypeName("#define MARSHAL_S_LAST 0x0004012FL")]
    public const int MARSHAL_S_LAST = 0x0004012F;

    [NativeTypeName("#define DATA_E_FIRST 0x80040130L")]
    public const uint DATA_E_FIRST = 0x80040130;

    [NativeTypeName("#define DATA_E_LAST 0x8004013FL")]
    public const uint DATA_E_LAST = 0x8004013F;

    [NativeTypeName("#define DATA_S_FIRST 0x00040130L")]
    public const int DATA_S_FIRST = 0x00040130;

    [NativeTypeName("#define DATA_S_LAST 0x0004013FL")]
    public const int DATA_S_LAST = 0x0004013F;

    [NativeTypeName("#define CACHE_E_FIRST 0x80040170L")]
    public const uint CACHE_E_FIRST = 0x80040170;

    [NativeTypeName("#define CACHE_E_LAST 0x8004017FL")]
    public const uint CACHE_E_LAST = 0x8004017F;

    [NativeTypeName("#define CACHE_S_FIRST 0x00040170L")]
    public const int CACHE_S_FIRST = 0x00040170;

    [NativeTypeName("#define CACHE_S_LAST 0x0004017FL")]
    public const int CACHE_S_LAST = 0x0004017F;

    [NativeTypeName("#define CACHE_E_NOCACHE_UPDATED _HRESULT_TYPEDEF_(0x80040170L)")]
    public const int CACHE_E_NOCACHE_UPDATED = unchecked((int)(0x80040170));

    [NativeTypeName("#define OLEOBJ_E_FIRST 0x80040180L")]
    public const uint OLEOBJ_E_FIRST = 0x80040180;

    [NativeTypeName("#define OLEOBJ_E_LAST 0x8004018FL")]
    public const uint OLEOBJ_E_LAST = 0x8004018F;

    [NativeTypeName("#define OLEOBJ_S_FIRST 0x00040180L")]
    public const int OLEOBJ_S_FIRST = 0x00040180;

    [NativeTypeName("#define OLEOBJ_S_LAST 0x0004018FL")]
    public const int OLEOBJ_S_LAST = 0x0004018F;

    [NativeTypeName("#define OLEOBJ_E_NOVERBS _HRESULT_TYPEDEF_(0x80040180L)")]
    public const int OLEOBJ_E_NOVERBS = unchecked((int)(0x80040180));

    [NativeTypeName("#define OLEOBJ_E_INVALIDVERB _HRESULT_TYPEDEF_(0x80040181L)")]
    public const int OLEOBJ_E_INVALIDVERB = unchecked((int)(0x80040181));

    [NativeTypeName("#define CLIENTSITE_E_FIRST 0x80040190L")]
    public const uint CLIENTSITE_E_FIRST = 0x80040190;

    [NativeTypeName("#define CLIENTSITE_E_LAST 0x8004019FL")]
    public const uint CLIENTSITE_E_LAST = 0x8004019F;

    [NativeTypeName("#define CLIENTSITE_S_FIRST 0x00040190L")]
    public const int CLIENTSITE_S_FIRST = 0x00040190;

    [NativeTypeName("#define CLIENTSITE_S_LAST 0x0004019FL")]
    public const int CLIENTSITE_S_LAST = 0x0004019F;

    [NativeTypeName("#define INPLACE_E_NOTUNDOABLE _HRESULT_TYPEDEF_(0x800401A0L)")]
    public const int INPLACE_E_NOTUNDOABLE = unchecked((int)(0x800401A0));

    [NativeTypeName("#define INPLACE_E_NOTOOLSPACE _HRESULT_TYPEDEF_(0x800401A1L)")]
    public const int INPLACE_E_NOTOOLSPACE = unchecked((int)(0x800401A1));

    [NativeTypeName("#define INPLACE_E_FIRST 0x800401A0L")]
    public const uint INPLACE_E_FIRST = 0x800401A0;

    [NativeTypeName("#define INPLACE_E_LAST 0x800401AFL")]
    public const uint INPLACE_E_LAST = 0x800401AF;

    [NativeTypeName("#define INPLACE_S_FIRST 0x000401A0L")]
    public const int INPLACE_S_FIRST = 0x000401A0;

    [NativeTypeName("#define INPLACE_S_LAST 0x000401AFL")]
    public const int INPLACE_S_LAST = 0x000401AF;

    [NativeTypeName("#define CLIPBRD_E_FIRST 0x800401D0L")]
    public const uint CLIPBRD_E_FIRST = 0x800401D0;

    [NativeTypeName("#define CLIPBRD_E_LAST 0x800401DFL")]
    public const uint CLIPBRD_E_LAST = 0x800401DF;

    [NativeTypeName("#define CLIPBRD_S_FIRST 0x000401D0L")]
    public const int CLIPBRD_S_FIRST = 0x000401D0;

    [NativeTypeName("#define CLIPBRD_S_LAST 0x000401DFL")]
    public const int CLIPBRD_S_LAST = 0x000401DF;

    [NativeTypeName("#define CLIPBRD_E_CANT_OPEN _HRESULT_TYPEDEF_(0x800401D0L)")]
    public const int CLIPBRD_E_CANT_OPEN = unchecked((int)(0x800401D0));

    [NativeTypeName("#define CLIPBRD_E_CANT_EMPTY _HRESULT_TYPEDEF_(0x800401D1L)")]
    public const int CLIPBRD_E_CANT_EMPTY = unchecked((int)(0x800401D1));

    [NativeTypeName("#define CLIPBRD_E_CANT_SET _HRESULT_TYPEDEF_(0x800401D2L)")]
    public const int CLIPBRD_E_CANT_SET = unchecked((int)(0x800401D2));

    [NativeTypeName("#define CLIPBRD_E_BAD_DATA _HRESULT_TYPEDEF_(0x800401D3L)")]
    public const int CLIPBRD_E_BAD_DATA = unchecked((int)(0x800401D3));

    [NativeTypeName("#define CLIPBRD_E_CANT_CLOSE _HRESULT_TYPEDEF_(0x800401D4L)")]
    public const int CLIPBRD_E_CANT_CLOSE = unchecked((int)(0x800401D4));

    [NativeTypeName("#define DATA_S_SAMEFORMATETC _HRESULT_TYPEDEF_(0x00040130L)")]
    public const int DATA_S_SAMEFORMATETC = ((int)(0x00040130));

    [NativeTypeName("#define CACHE_S_FORMATETC_NOTSUPPORTED _HRESULT_TYPEDEF_(0x00040170L)")]
    public const int CACHE_S_FORMATETC_NOTSUPPORTED = ((int)(0x00040170));

    [NativeTypeName("#define CACHE_S_SAMECACHE _HRESULT_TYPEDEF_(0x00040171L)")]
    public const int CACHE_S_SAMECACHE = ((int)(0x00040171));

    [NativeTypeName("#define CACHE_S_SOMECACHES_NOTUPDATED _HRESULT_TYPEDEF_(0x00040172L)")]
    public const int CACHE_S_SOMECACHES_NOTUPDATED = ((int)(0x00040172));

    [NativeTypeName("#define OLEOBJ_S_INVALIDVERB _HRESULT_TYPEDEF_(0x00040180L)")]
    public const int OLEOBJ_S_INVALIDVERB = ((int)(0x00040180));

    [NativeTypeName("#define OLEOBJ_S_CANNOT_DOVERB_NOW _HRESULT_TYPEDEF_(0x00040181L)")]
    public const int OLEOBJ_S_CANNOT_DOVERB_NOW = ((int)(0x00040181));

    [NativeTypeName("#define OLEOBJ_S_INVALIDHWND _HRESULT_TYPEDEF_(0x00040182L)")]
    public const int OLEOBJ_S_INVALIDHWND = ((int)(0x00040182));

    [NativeTypeName("#define INPLACE_S_TRUNCATED _HRESULT_TYPEDEF_(0x000401A0L)")]
    public const int INPLACE_S_TRUNCATED = ((int)(0x000401A0));

    [NativeTypeName("#define BT_E_SPURIOUS_ACTIVATION _HRESULT_TYPEDEF_(0x80080300L)")]
    public const int BT_E_SPURIOUS_ACTIVATION = unchecked((int)(0x80080300));

    [NativeTypeName("#define XENROLL_E_KEY_NOT_EXPORTABLE _HRESULT_TYPEDEF_(0x80095000L)")]
    public const int XENROLL_E_KEY_NOT_EXPORTABLE = unchecked((int)(0x80095000));

    [NativeTypeName("#define XENROLL_E_CANNOT_ADD_ROOT_CERT _HRESULT_TYPEDEF_(0x80095001L)")]
    public const int XENROLL_E_CANNOT_ADD_ROOT_CERT = unchecked((int)(0x80095001));

    [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND _HRESULT_TYPEDEF_(0x80095002L)")]
    public const int XENROLL_E_RESPONSE_KA_HASH_NOT_FOUND = unchecked((int)(0x80095002));

    [NativeTypeName("#define XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH _HRESULT_TYPEDEF_(0x80095003L)")]
    public const int XENROLL_E_RESPONSE_UNEXPECTED_KA_HASH = unchecked((int)(0x80095003));

    [NativeTypeName("#define XENROLL_E_RESPONSE_KA_HASH_MISMATCH _HRESULT_TYPEDEF_(0x80095004L)")]
    public const int XENROLL_E_RESPONSE_KA_HASH_MISMATCH = unchecked((int)(0x80095004));

    [NativeTypeName("#define XENROLL_E_KEYSPEC_SMIME_MISMATCH _HRESULT_TYPEDEF_(0x80095005L)")]
    public const int XENROLL_E_KEYSPEC_SMIME_MISMATCH = unchecked((int)(0x80095005));

    [NativeTypeName("#define DIGSIG_E_ENCODE _HRESULT_TYPEDEF_(0x800B0005L)")]
    public const int DIGSIG_E_ENCODE = unchecked((int)(0x800B0005));

    [NativeTypeName("#define DIGSIG_E_DECODE _HRESULT_TYPEDEF_(0x800B0006L)")]
    public const int DIGSIG_E_DECODE = unchecked((int)(0x800B0006));

    [NativeTypeName("#define DIGSIG_E_EXTENSIBILITY _HRESULT_TYPEDEF_(0x800B0007L)")]
    public const int DIGSIG_E_EXTENSIBILITY = unchecked((int)(0x800B0007));

    [NativeTypeName("#define DIGSIG_E_CRYPTO _HRESULT_TYPEDEF_(0x800B0008L)")]
    public const int DIGSIG_E_CRYPTO = unchecked((int)(0x800B0008));

    [NativeTypeName("#define PERSIST_E_SIZEDEFINITE _HRESULT_TYPEDEF_(0x800B0009L)")]
    public const int PERSIST_E_SIZEDEFINITE = unchecked((int)(0x800B0009));

    [NativeTypeName("#define PERSIST_E_SIZEINDEFINITE _HRESULT_TYPEDEF_(0x800B000AL)")]
    public const int PERSIST_E_SIZEINDEFINITE = unchecked((int)(0x800B000A));

    [NativeTypeName("#define PERSIST_E_NOTSELFSIZING _HRESULT_TYPEDEF_(0x800B000BL)")]
    public const int PERSIST_E_NOTSELFSIZING = unchecked((int)(0x800B000B));

    [NativeTypeName("#define COMQC_E_APPLICATION_NOT_QUEUED _HRESULT_TYPEDEF_(0x80110600L)")]
    public const int COMQC_E_APPLICATION_NOT_QUEUED = unchecked((int)(0x80110600));

    [NativeTypeName("#define COMQC_E_NO_QUEUEABLE_INTERFACES _HRESULT_TYPEDEF_(0x80110601L)")]
    public const int COMQC_E_NO_QUEUEABLE_INTERFACES = unchecked((int)(0x80110601));

    [NativeTypeName("#define COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80110602L)")]
    public const int COMQC_E_QUEUING_SERVICE_NOT_AVAILABLE = unchecked((int)(0x80110602));

    [NativeTypeName("#define COMQC_E_NO_IPERSISTSTREAM _HRESULT_TYPEDEF_(0x80110603L)")]
    public const int COMQC_E_NO_IPERSISTSTREAM = unchecked((int)(0x80110603));

    [NativeTypeName("#define COMQC_E_BAD_MESSAGE _HRESULT_TYPEDEF_(0x80110604L)")]
    public const int COMQC_E_BAD_MESSAGE = unchecked((int)(0x80110604));

    [NativeTypeName("#define COMQC_E_UNAUTHENTICATED _HRESULT_TYPEDEF_(0x80110605L)")]
    public const int COMQC_E_UNAUTHENTICATED = unchecked((int)(0x80110605));

    [NativeTypeName("#define COMQC_E_UNTRUSTED_ENQUEUER _HRESULT_TYPEDEF_(0x80110606L)")]
    public const int COMQC_E_UNTRUSTED_ENQUEUER = unchecked((int)(0x80110606));

    [NativeTypeName("#define MSDTC_E_DUPLICATE_RESOURCE _HRESULT_TYPEDEF_(0x80110701L)")]
    public const int MSDTC_E_DUPLICATE_RESOURCE = unchecked((int)(0x80110701));

    [NativeTypeName("#define GCN_E_MODULE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0021L)")]
    public const int GCN_E_MODULE_NOT_FOUND = unchecked((int)(0x803B0021));

    [NativeTypeName("#define GCN_E_NO_REQUEST_HANDLERS _HRESULT_TYPEDEF_(0x803B0022L)")]
    public const int GCN_E_NO_REQUEST_HANDLERS = unchecked((int)(0x803B0022));

    [NativeTypeName("#define GCN_E_REQUEST_UNSUPPORTED _HRESULT_TYPEDEF_(0x803B0023L)")]
    public const int GCN_E_REQUEST_UNSUPPORTED = unchecked((int)(0x803B0023));

    [NativeTypeName("#define GCN_E_RUNTIMEKEYS_FAILED _HRESULT_TYPEDEF_(0x803B0024L)")]
    public const int GCN_E_RUNTIMEKEYS_FAILED = unchecked((int)(0x803B0024));

    [NativeTypeName("#define GCN_E_NETADAPTER_TIMEOUT _HRESULT_TYPEDEF_(0x803B0025L)")]
    public const int GCN_E_NETADAPTER_TIMEOUT = unchecked((int)(0x803B0025));

    [NativeTypeName("#define GCN_E_NETADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0026L)")]
    public const int GCN_E_NETADAPTER_NOT_FOUND = unchecked((int)(0x803B0026));

    [NativeTypeName("#define GCN_E_NETCOMPARTMENT_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0027L)")]
    public const int GCN_E_NETCOMPARTMENT_NOT_FOUND = unchecked((int)(0x803B0027));

    [NativeTypeName("#define GCN_E_NETINTERFACE_NOT_FOUND _HRESULT_TYPEDEF_(0x803B0028L)")]
    public const int GCN_E_NETINTERFACE_NOT_FOUND = unchecked((int)(0x803B0028));

    [NativeTypeName("#define GCN_E_DEFAULTNAMESPACE_EXISTS _HRESULT_TYPEDEF_(0x803B0029L)")]
    public const int GCN_E_DEFAULTNAMESPACE_EXISTS = unchecked((int)(0x803B0029));

    [NativeTypeName("#define STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80670011L)")]
    public const int STATEREPOSTORY_E_NESTED_TRANSACTION_NOT_SUPPORTED = unchecked((int)(0x80670011));

    [NativeTypeName("#define DXCORE_ERROR_EVENT_NOT_UNREGISTERED _HRESULT_TYPEDEF_(0x88800001L)")]
    public const int DXCORE_ERROR_EVENT_NOT_UNREGISTERED = unchecked((int)(0x88800001));

    [NativeTypeName("#define PRESENTATION_ERROR_LOST _HRESULT_TYPEDEF_(0x88810001L)")]
    public const int PRESENTATION_ERROR_LOST = unchecked((int)(0x88810001));

    [NativeTypeName("#define DWMERR_STATE_TRANSITION_FAILED _HRESULT_TYPEDEF_(0x88980700L)")]
    public const int DWMERR_STATE_TRANSITION_FAILED = unchecked((int)(0x88980700));

    [NativeTypeName("#define DWMERR_THEME_FAILED _HRESULT_TYPEDEF_(0x88980701L)")]
    public const int DWMERR_THEME_FAILED = unchecked((int)(0x88980701));

    [NativeTypeName("#define DWMERR_CATASTROPHIC_FAILURE _HRESULT_TYPEDEF_(0x88980702L)")]
    public const int DWMERR_CATASTROPHIC_FAILURE = unchecked((int)(0x88980702));

    [NativeTypeName("#define FA_E_MAX_PERSISTED_ITEMS_REACHED _HRESULT_TYPEDEF_(0x80270220L)")]
    public const int FA_E_MAX_PERSISTED_ITEMS_REACHED = unchecked((int)(0x80270220));

    [NativeTypeName("#define FA_E_HOMEGROUP_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80270222L)")]
    public const int FA_E_HOMEGROUP_NOT_AVAILABLE = unchecked((int)(0x80270222));

    [NativeTypeName("#define WEB_E_UNSUPPORTED_FORMAT _HRESULT_TYPEDEF_(0x83750001L)")]
    public const int WEB_E_UNSUPPORTED_FORMAT = unchecked((int)(0x83750001));

    [NativeTypeName("#define WEB_E_INVALID_XML _HRESULT_TYPEDEF_(0x83750002L)")]
    public const int WEB_E_INVALID_XML = unchecked((int)(0x83750002));

    [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ELEMENT _HRESULT_TYPEDEF_(0x83750003L)")]
    public const int WEB_E_MISSING_REQUIRED_ELEMENT = unchecked((int)(0x83750003));

    [NativeTypeName("#define WEB_E_MISSING_REQUIRED_ATTRIBUTE _HRESULT_TYPEDEF_(0x83750004L)")]
    public const int WEB_E_MISSING_REQUIRED_ATTRIBUTE = unchecked((int)(0x83750004));

    [NativeTypeName("#define WEB_E_UNEXPECTED_CONTENT _HRESULT_TYPEDEF_(0x83750005L)")]
    public const int WEB_E_UNEXPECTED_CONTENT = unchecked((int)(0x83750005));

    [NativeTypeName("#define WEB_E_RESOURCE_TOO_LARGE _HRESULT_TYPEDEF_(0x83750006L)")]
    public const int WEB_E_RESOURCE_TOO_LARGE = unchecked((int)(0x83750006));

    [NativeTypeName("#define WEB_E_INVALID_JSON_STRING _HRESULT_TYPEDEF_(0x83750007L)")]
    public const int WEB_E_INVALID_JSON_STRING = unchecked((int)(0x83750007));

    [NativeTypeName("#define WEB_E_INVALID_JSON_NUMBER _HRESULT_TYPEDEF_(0x83750008L)")]
    public const int WEB_E_INVALID_JSON_NUMBER = unchecked((int)(0x83750008));

    [NativeTypeName("#define WEB_E_JSON_VALUE_NOT_FOUND _HRESULT_TYPEDEF_(0x83750009L)")]
    public const int WEB_E_JSON_VALUE_NOT_FOUND = unchecked((int)(0x83750009));

    [NativeTypeName("#define HSP_E_ERROR_MASK _HRESULT_TYPEDEF_(0x81280000L)")]
    public const int HSP_E_ERROR_MASK = unchecked((int)(0x81280000));

    [NativeTypeName("#define HSP_E_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x81280FFFL)")]
    public const int HSP_E_INTERNAL_ERROR = unchecked((int)(0x81280FFF));

    [NativeTypeName("#define HSP_BS_ERROR_MASK _HRESULT_TYPEDEF_(0x81281000L)")]
    public const int HSP_BS_ERROR_MASK = unchecked((int)(0x81281000));

    [NativeTypeName("#define HSP_BS_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812810FFL)")]
    public const int HSP_BS_INTERNAL_ERROR = unchecked((int)(0x812810FF));

    [NativeTypeName("#define HSP_DRV_ERROR_MASK _HRESULT_TYPEDEF_(0x81290000L)")]
    public const int HSP_DRV_ERROR_MASK = unchecked((int)(0x81290000));

    [NativeTypeName("#define HSP_DRV_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812900FFL)")]
    public const int HSP_DRV_INTERNAL_ERROR = unchecked((int)(0x812900FF));

    [NativeTypeName("#define HSP_BASE_ERROR_MASK _HRESULT_TYPEDEF_(0x81290100L)")]
    public const int HSP_BASE_ERROR_MASK = unchecked((int)(0x81290100));

    [NativeTypeName("#define HSP_BASE_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812901FFL)")]
    public const int HSP_BASE_INTERNAL_ERROR = unchecked((int)(0x812901FF));

    [NativeTypeName("#define HSP_KSP_ERROR_MASK _HRESULT_TYPEDEF_(0x81290200L)")]
    public const int HSP_KSP_ERROR_MASK = unchecked((int)(0x81290200));

    [NativeTypeName("#define HSP_KSP_DEVICE_NOT_READY _HRESULT_TYPEDEF_(0x81290201L)")]
    public const int HSP_KSP_DEVICE_NOT_READY = unchecked((int)(0x81290201));

    [NativeTypeName("#define HSP_KSP_INVALID_PROVIDER_HANDLE _HRESULT_TYPEDEF_(0x81290202L)")]
    public const int HSP_KSP_INVALID_PROVIDER_HANDLE = unchecked((int)(0x81290202));

    [NativeTypeName("#define HSP_KSP_INVALID_KEY_HANDLE _HRESULT_TYPEDEF_(0x81290203L)")]
    public const int HSP_KSP_INVALID_KEY_HANDLE = unchecked((int)(0x81290203));

    [NativeTypeName("#define HSP_KSP_INVALID_PARAMETER _HRESULT_TYPEDEF_(0x81290204L)")]
    public const int HSP_KSP_INVALID_PARAMETER = unchecked((int)(0x81290204));

    [NativeTypeName("#define HSP_KSP_BUFFER_TOO_SMALL _HRESULT_TYPEDEF_(0x81290205L)")]
    public const int HSP_KSP_BUFFER_TOO_SMALL = unchecked((int)(0x81290205));

    [NativeTypeName("#define HSP_KSP_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x81290206L)")]
    public const int HSP_KSP_NOT_SUPPORTED = unchecked((int)(0x81290206));

    [NativeTypeName("#define HSP_KSP_INVALID_DATA _HRESULT_TYPEDEF_(0x81290207L)")]
    public const int HSP_KSP_INVALID_DATA = unchecked((int)(0x81290207));

    [NativeTypeName("#define HSP_KSP_INVALID_FLAGS _HRESULT_TYPEDEF_(0x81290208L)")]
    public const int HSP_KSP_INVALID_FLAGS = unchecked((int)(0x81290208));

    [NativeTypeName("#define HSP_KSP_ALGORITHM_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x81290209L)")]
    public const int HSP_KSP_ALGORITHM_NOT_SUPPORTED = unchecked((int)(0x81290209));

    [NativeTypeName("#define HSP_KSP_KEY_ALREADY_FINALIZED _HRESULT_TYPEDEF_(0x8129020AL)")]
    public const int HSP_KSP_KEY_ALREADY_FINALIZED = unchecked((int)(0x8129020A));

    [NativeTypeName("#define HSP_KSP_KEY_NOT_FINALIZED _HRESULT_TYPEDEF_(0x8129020BL)")]
    public const int HSP_KSP_KEY_NOT_FINALIZED = unchecked((int)(0x8129020B));

    [NativeTypeName("#define HSP_KSP_INVALID_KEY_TYPE _HRESULT_TYPEDEF_(0x8129020CL)")]
    public const int HSP_KSP_INVALID_KEY_TYPE = unchecked((int)(0x8129020C));

    [NativeTypeName("#define HSP_KSP_NO_MEMORY _HRESULT_TYPEDEF_(0x81290210L)")]
    public const int HSP_KSP_NO_MEMORY = unchecked((int)(0x81290210));

    [NativeTypeName("#define HSP_KSP_PARAMETER_NOT_SET _HRESULT_TYPEDEF_(0x81290211L)")]
    public const int HSP_KSP_PARAMETER_NOT_SET = unchecked((int)(0x81290211));

    [NativeTypeName("#define HSP_KSP_KEY_EXISTS _HRESULT_TYPEDEF_(0x81290215L)")]
    public const int HSP_KSP_KEY_EXISTS = unchecked((int)(0x81290215));

    [NativeTypeName("#define HSP_KSP_KEY_MISSING _HRESULT_TYPEDEF_(0x81290216L)")]
    public const int HSP_KSP_KEY_MISSING = unchecked((int)(0x81290216));

    [NativeTypeName("#define HSP_KSP_KEY_LOAD_FAIL _HRESULT_TYPEDEF_(0x81290217L)")]
    public const int HSP_KSP_KEY_LOAD_FAIL = unchecked((int)(0x81290217));

    [NativeTypeName("#define HSP_KSP_NO_MORE_ITEMS _HRESULT_TYPEDEF_(0x81290218L)")]
    public const int HSP_KSP_NO_MORE_ITEMS = unchecked((int)(0x81290218));

    [NativeTypeName("#define HSP_KSP_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x812902FFL)")]
    public const int HSP_KSP_INTERNAL_ERROR = unchecked((int)(0x812902FF));

    [NativeTypeName("#define JSCRIPT_E_CANTEXECUTE _HRESULT_TYPEDEF_(0x89020001L)")]
    public const int JSCRIPT_E_CANTEXECUTE = unchecked((int)(0x89020001));

    [NativeTypeName("#define WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES _HRESULT_TYPEDEF_(0x88010001L)")]
    public const int WEP_E_NOT_PROVISIONED_ON_ALL_VOLUMES = unchecked((int)(0x88010001));

    [NativeTypeName("#define WEP_E_FIXED_DATA_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88010002L)")]
    public const int WEP_E_FIXED_DATA_NOT_SUPPORTED = unchecked((int)(0x88010002));

    [NativeTypeName("#define WEP_E_HARDWARE_NOT_COMPLIANT _HRESULT_TYPEDEF_(0x88010003L)")]
    public const int WEP_E_HARDWARE_NOT_COMPLIANT = unchecked((int)(0x88010003));

    [NativeTypeName("#define WEP_E_LOCK_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x88010004L)")]
    public const int WEP_E_LOCK_NOT_CONFIGURED = unchecked((int)(0x88010004));

    [NativeTypeName("#define WEP_E_PROTECTION_SUSPENDED _HRESULT_TYPEDEF_(0x88010005L)")]
    public const int WEP_E_PROTECTION_SUSPENDED = unchecked((int)(0x88010005));

    [NativeTypeName("#define WEP_E_NO_LICENSE _HRESULT_TYPEDEF_(0x88010006L)")]
    public const int WEP_E_NO_LICENSE = unchecked((int)(0x88010006));

    [NativeTypeName("#define WEP_E_OS_NOT_PROTECTED _HRESULT_TYPEDEF_(0x88010007L)")]
    public const int WEP_E_OS_NOT_PROTECTED = unchecked((int)(0x88010007));

    [NativeTypeName("#define WEP_E_UNEXPECTED_FAIL _HRESULT_TYPEDEF_(0x88010008L)")]
    public const int WEP_E_UNEXPECTED_FAIL = unchecked((int)(0x88010008));

    [NativeTypeName("#define WEP_E_BUFFER_TOO_LARGE _HRESULT_TYPEDEF_(0x88010009L)")]
    public const int WEP_E_BUFFER_TOO_LARGE = unchecked((int)(0x88010009));

    [NativeTypeName("#define WINML_ERR_INVALID_DEVICE _HRESULT_TYPEDEF_(0x88900001L)")]
    public const int WINML_ERR_INVALID_DEVICE = unchecked((int)(0x88900001));

    [NativeTypeName("#define WINML_ERR_INVALID_BINDING _HRESULT_TYPEDEF_(0x88900002L)")]
    public const int WINML_ERR_INVALID_BINDING = unchecked((int)(0x88900002));

    [NativeTypeName("#define WINML_ERR_VALUE_NOTFOUND _HRESULT_TYPEDEF_(0x88900003L)")]
    public const int WINML_ERR_VALUE_NOTFOUND = unchecked((int)(0x88900003));

    [NativeTypeName("#define WINML_ERR_SIZE_MISMATCH _HRESULT_TYPEDEF_(0x88900004L)")]
    public const int WINML_ERR_SIZE_MISMATCH = unchecked((int)(0x88900004));

    [NativeTypeName("#define IORING_E_REQUIRED_FLAG_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80460001L)")]
    public const int IORING_E_REQUIRED_FLAG_NOT_SUPPORTED = unchecked((int)(0x80460001));

    [NativeTypeName("#define IORING_E_SUBMISSION_QUEUE_FULL _HRESULT_TYPEDEF_(0x80460002L)")]
    public const int IORING_E_SUBMISSION_QUEUE_FULL = unchecked((int)(0x80460002));

    [NativeTypeName("#define IORING_E_VERSION_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80460003L)")]
    public const int IORING_E_VERSION_NOT_SUPPORTED = unchecked((int)(0x80460003));

    [NativeTypeName("#define IORING_E_SUBMISSION_QUEUE_TOO_BIG _HRESULT_TYPEDEF_(0x80460004L)")]
    public const int IORING_E_SUBMISSION_QUEUE_TOO_BIG = unchecked((int)(0x80460004));

    [NativeTypeName("#define IORING_E_COMPLETION_QUEUE_TOO_BIG _HRESULT_TYPEDEF_(0x80460005L)")]
    public const int IORING_E_COMPLETION_QUEUE_TOO_BIG = unchecked((int)(0x80460005));

    [NativeTypeName("#define IORING_E_SUBMIT_IN_PROGRESS _HRESULT_TYPEDEF_(0x80460006L)")]
    public const int IORING_E_SUBMIT_IN_PROGRESS = unchecked((int)(0x80460006));

    [NativeTypeName("#define IORING_E_CORRUPT _HRESULT_TYPEDEF_(0x80460007L)")]
    public const int IORING_E_CORRUPT = unchecked((int)(0x80460007));

    [NativeTypeName("#define IORING_E_COMPLETION_QUEUE_TOO_FULL _HRESULT_TYPEDEF_(0x80460008L)")]
    public const int IORING_E_COMPLETION_QUEUE_TOO_FULL = unchecked((int)(0x80460008));
}
