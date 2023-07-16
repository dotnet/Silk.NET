// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class PEER
{
    [NativeTypeName("#define PEER_E_IPV6_NOT_INSTALLED _HRESULT_TYPEDEF_(0x80630001L)")]
    public const int PEER_E_IPV6_NOT_INSTALLED = unchecked((int)(0x80630001));
    [NativeTypeName("#define PEER_E_NOT_INITIALIZED _HRESULT_TYPEDEF_(0x80630002L)")]
    public const int PEER_E_NOT_INITIALIZED = unchecked((int)(0x80630002));
    [NativeTypeName("#define PEER_E_CANNOT_START_SERVICE _HRESULT_TYPEDEF_(0x80630003L)")]
    public const int PEER_E_CANNOT_START_SERVICE = unchecked((int)(0x80630003));
    [NativeTypeName("#define PEER_E_NOT_LICENSED _HRESULT_TYPEDEF_(0x80630004L)")]
    public const int PEER_E_NOT_LICENSED = unchecked((int)(0x80630004));
    [NativeTypeName("#define PEER_E_INVALID_GRAPH _HRESULT_TYPEDEF_(0x80630010L)")]
    public const int PEER_E_INVALID_GRAPH = unchecked((int)(0x80630010));
    [NativeTypeName("#define PEER_E_DBNAME_CHANGED _HRESULT_TYPEDEF_(0x80630011L)")]
    public const int PEER_E_DBNAME_CHANGED = unchecked((int)(0x80630011));
    [NativeTypeName("#define PEER_E_DUPLICATE_GRAPH _HRESULT_TYPEDEF_(0x80630012L)")]
    public const int PEER_E_DUPLICATE_GRAPH = unchecked((int)(0x80630012));
    [NativeTypeName("#define PEER_E_GRAPH_NOT_READY _HRESULT_TYPEDEF_(0x80630013L)")]
    public const int PEER_E_GRAPH_NOT_READY = unchecked((int)(0x80630013));
    [NativeTypeName("#define PEER_E_GRAPH_SHUTTING_DOWN _HRESULT_TYPEDEF_(0x80630014L)")]
    public const int PEER_E_GRAPH_SHUTTING_DOWN = unchecked((int)(0x80630014));
    [NativeTypeName("#define PEER_E_GRAPH_IN_USE _HRESULT_TYPEDEF_(0x80630015L)")]
    public const int PEER_E_GRAPH_IN_USE = unchecked((int)(0x80630015));
    [NativeTypeName("#define PEER_E_INVALID_DATABASE _HRESULT_TYPEDEF_(0x80630016L)")]
    public const int PEER_E_INVALID_DATABASE = unchecked((int)(0x80630016));
    [NativeTypeName("#define PEER_E_TOO_MANY_ATTRIBUTES _HRESULT_TYPEDEF_(0x80630017L)")]
    public const int PEER_E_TOO_MANY_ATTRIBUTES = unchecked((int)(0x80630017));
    [NativeTypeName("#define PEER_E_CONNECTION_NOT_FOUND _HRESULT_TYPEDEF_(0x80630103L)")]
    public const int PEER_E_CONNECTION_NOT_FOUND = unchecked((int)(0x80630103));
    [NativeTypeName("#define PEER_E_CONNECT_SELF _HRESULT_TYPEDEF_(0x80630106L)")]
    public const int PEER_E_CONNECT_SELF = unchecked((int)(0x80630106));
    [NativeTypeName("#define PEER_E_ALREADY_LISTENING _HRESULT_TYPEDEF_(0x80630107L)")]
    public const int PEER_E_ALREADY_LISTENING = unchecked((int)(0x80630107));
    [NativeTypeName("#define PEER_E_NODE_NOT_FOUND _HRESULT_TYPEDEF_(0x80630108L)")]
    public const int PEER_E_NODE_NOT_FOUND = unchecked((int)(0x80630108));
    [NativeTypeName("#define PEER_E_CONNECTION_FAILED _HRESULT_TYPEDEF_(0x80630109L)")]
    public const int PEER_E_CONNECTION_FAILED = unchecked((int)(0x80630109));
    [NativeTypeName("#define PEER_E_CONNECTION_NOT_AUTHENTICATED _HRESULT_TYPEDEF_(0x8063010AL)")]
    public const int PEER_E_CONNECTION_NOT_AUTHENTICATED = unchecked((int)(0x8063010A));
    [NativeTypeName("#define PEER_E_CONNECTION_REFUSED _HRESULT_TYPEDEF_(0x8063010BL)")]
    public const int PEER_E_CONNECTION_REFUSED = unchecked((int)(0x8063010B));
    [NativeTypeName("#define PEER_E_CLASSIFIER_TOO_LONG _HRESULT_TYPEDEF_(0x80630201L)")]
    public const int PEER_E_CLASSIFIER_TOO_LONG = unchecked((int)(0x80630201));
    [NativeTypeName("#define PEER_E_TOO_MANY_IDENTITIES _HRESULT_TYPEDEF_(0x80630202L)")]
    public const int PEER_E_TOO_MANY_IDENTITIES = unchecked((int)(0x80630202));
    [NativeTypeName("#define PEER_E_NO_KEY_ACCESS _HRESULT_TYPEDEF_(0x80630203L)")]
    public const int PEER_E_NO_KEY_ACCESS = unchecked((int)(0x80630203));
    [NativeTypeName("#define PEER_E_GROUPS_EXIST _HRESULT_TYPEDEF_(0x80630204L)")]
    public const int PEER_E_GROUPS_EXIST = unchecked((int)(0x80630204));
    [NativeTypeName("#define PEER_E_RECORD_NOT_FOUND _HRESULT_TYPEDEF_(0x80630301L)")]
    public const int PEER_E_RECORD_NOT_FOUND = unchecked((int)(0x80630301));
    [NativeTypeName("#define PEER_E_DATABASE_ACCESSDENIED _HRESULT_TYPEDEF_(0x80630302L)")]
    public const int PEER_E_DATABASE_ACCESSDENIED = unchecked((int)(0x80630302));
    [NativeTypeName("#define PEER_E_DBINITIALIZATION_FAILED _HRESULT_TYPEDEF_(0x80630303L)")]
    public const int PEER_E_DBINITIALIZATION_FAILED = unchecked((int)(0x80630303));
    [NativeTypeName("#define PEER_E_MAX_RECORD_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x80630304L)")]
    public const int PEER_E_MAX_RECORD_SIZE_EXCEEDED = unchecked((int)(0x80630304));
    [NativeTypeName("#define PEER_E_DATABASE_ALREADY_PRESENT _HRESULT_TYPEDEF_(0x80630305L)")]
    public const int PEER_E_DATABASE_ALREADY_PRESENT = unchecked((int)(0x80630305));
    [NativeTypeName("#define PEER_E_DATABASE_NOT_PRESENT _HRESULT_TYPEDEF_(0x80630306L)")]
    public const int PEER_E_DATABASE_NOT_PRESENT = unchecked((int)(0x80630306));
    [NativeTypeName("#define PEER_E_IDENTITY_NOT_FOUND _HRESULT_TYPEDEF_(0x80630401L)")]
    public const int PEER_E_IDENTITY_NOT_FOUND = unchecked((int)(0x80630401));
    [NativeTypeName("#define PEER_E_EVENT_HANDLE_NOT_FOUND _HRESULT_TYPEDEF_(0x80630501L)")]
    public const int PEER_E_EVENT_HANDLE_NOT_FOUND = unchecked((int)(0x80630501));
    [NativeTypeName("#define PEER_E_INVALID_SEARCH _HRESULT_TYPEDEF_(0x80630601L)")]
    public const int PEER_E_INVALID_SEARCH = unchecked((int)(0x80630601));
    [NativeTypeName("#define PEER_E_INVALID_ATTRIBUTES _HRESULT_TYPEDEF_(0x80630602L)")]
    public const int PEER_E_INVALID_ATTRIBUTES = unchecked((int)(0x80630602));
    [NativeTypeName("#define PEER_E_INVITATION_NOT_TRUSTED _HRESULT_TYPEDEF_(0x80630701L)")]
    public const int PEER_E_INVITATION_NOT_TRUSTED = unchecked((int)(0x80630701));
    [NativeTypeName("#define PEER_E_CHAIN_TOO_LONG _HRESULT_TYPEDEF_(0x80630703L)")]
    public const int PEER_E_CHAIN_TOO_LONG = unchecked((int)(0x80630703));
    [NativeTypeName("#define PEER_E_INVALID_TIME_PERIOD _HRESULT_TYPEDEF_(0x80630705L)")]
    public const int PEER_E_INVALID_TIME_PERIOD = unchecked((int)(0x80630705));
    [NativeTypeName("#define PEER_E_CIRCULAR_CHAIN_DETECTED _HRESULT_TYPEDEF_(0x80630706L)")]
    public const int PEER_E_CIRCULAR_CHAIN_DETECTED = unchecked((int)(0x80630706));
    [NativeTypeName("#define PEER_E_CERT_STORE_CORRUPTED _HRESULT_TYPEDEF_(0x80630801L)")]
    public const int PEER_E_CERT_STORE_CORRUPTED = unchecked((int)(0x80630801));
    [NativeTypeName("#define PEER_E_NO_CLOUD _HRESULT_TYPEDEF_(0x80631001L)")]
    public const int PEER_E_NO_CLOUD = unchecked((int)(0x80631001));
    [NativeTypeName("#define PEER_E_CLOUD_NAME_AMBIGUOUS _HRESULT_TYPEDEF_(0x80631005L)")]
    public const int PEER_E_CLOUD_NAME_AMBIGUOUS = unchecked((int)(0x80631005));
    [NativeTypeName("#define PEER_E_INVALID_RECORD _HRESULT_TYPEDEF_(0x80632010L)")]
    public const int PEER_E_INVALID_RECORD = unchecked((int)(0x80632010));
    [NativeTypeName("#define PEER_E_NOT_AUTHORIZED _HRESULT_TYPEDEF_(0x80632020L)")]
    public const int PEER_E_NOT_AUTHORIZED = unchecked((int)(0x80632020));
    [NativeTypeName("#define PEER_E_PASSWORD_DOES_NOT_MEET_POLICY _HRESULT_TYPEDEF_(0x80632021L)")]
    public const int PEER_E_PASSWORD_DOES_NOT_MEET_POLICY = unchecked((int)(0x80632021));
    [NativeTypeName("#define PEER_E_DEFERRED_VALIDATION _HRESULT_TYPEDEF_(0x80632030L)")]
    public const int PEER_E_DEFERRED_VALIDATION = unchecked((int)(0x80632030));
    [NativeTypeName("#define PEER_E_INVALID_GROUP_PROPERTIES _HRESULT_TYPEDEF_(0x80632040L)")]
    public const int PEER_E_INVALID_GROUP_PROPERTIES = unchecked((int)(0x80632040));
    [NativeTypeName("#define PEER_E_INVALID_PEER_NAME _HRESULT_TYPEDEF_(0x80632050L)")]
    public const int PEER_E_INVALID_PEER_NAME = unchecked((int)(0x80632050));
    [NativeTypeName("#define PEER_E_INVALID_CLASSIFIER _HRESULT_TYPEDEF_(0x80632060L)")]
    public const int PEER_E_INVALID_CLASSIFIER = unchecked((int)(0x80632060));
    [NativeTypeName("#define PEER_E_INVALID_FRIENDLY_NAME _HRESULT_TYPEDEF_(0x80632070L)")]
    public const int PEER_E_INVALID_FRIENDLY_NAME = unchecked((int)(0x80632070));
    [NativeTypeName("#define PEER_E_INVALID_ROLE_PROPERTY _HRESULT_TYPEDEF_(0x80632071L)")]
    public const int PEER_E_INVALID_ROLE_PROPERTY = unchecked((int)(0x80632071));
    [NativeTypeName("#define PEER_E_INVALID_CLASSIFIER_PROPERTY _HRESULT_TYPEDEF_(0x80632072L)")]
    public const int PEER_E_INVALID_CLASSIFIER_PROPERTY = unchecked((int)(0x80632072));
    [NativeTypeName("#define PEER_E_INVALID_RECORD_EXPIRATION _HRESULT_TYPEDEF_(0x80632080L)")]
    public const int PEER_E_INVALID_RECORD_EXPIRATION = unchecked((int)(0x80632080));
    [NativeTypeName("#define PEER_E_INVALID_CREDENTIAL_INFO _HRESULT_TYPEDEF_(0x80632081L)")]
    public const int PEER_E_INVALID_CREDENTIAL_INFO = unchecked((int)(0x80632081));
    [NativeTypeName("#define PEER_E_INVALID_CREDENTIAL _HRESULT_TYPEDEF_(0x80632082L)")]
    public const int PEER_E_INVALID_CREDENTIAL = unchecked((int)(0x80632082));
    [NativeTypeName("#define PEER_E_INVALID_RECORD_SIZE _HRESULT_TYPEDEF_(0x80632083L)")]
    public const int PEER_E_INVALID_RECORD_SIZE = unchecked((int)(0x80632083));
    [NativeTypeName("#define PEER_E_UNSUPPORTED_VERSION _HRESULT_TYPEDEF_(0x80632090L)")]
    public const int PEER_E_UNSUPPORTED_VERSION = unchecked((int)(0x80632090));
    [NativeTypeName("#define PEER_E_GROUP_NOT_READY _HRESULT_TYPEDEF_(0x80632091L)")]
    public const int PEER_E_GROUP_NOT_READY = unchecked((int)(0x80632091));
    [NativeTypeName("#define PEER_E_GROUP_IN_USE _HRESULT_TYPEDEF_(0x80632092L)")]
    public const int PEER_E_GROUP_IN_USE = unchecked((int)(0x80632092));
    [NativeTypeName("#define PEER_E_INVALID_GROUP _HRESULT_TYPEDEF_(0x80632093L)")]
    public const int PEER_E_INVALID_GROUP = unchecked((int)(0x80632093));
    [NativeTypeName("#define PEER_E_NO_MEMBERS_FOUND _HRESULT_TYPEDEF_(0x80632094L)")]
    public const int PEER_E_NO_MEMBERS_FOUND = unchecked((int)(0x80632094));
    [NativeTypeName("#define PEER_E_NO_MEMBER_CONNECTIONS _HRESULT_TYPEDEF_(0x80632095L)")]
    public const int PEER_E_NO_MEMBER_CONNECTIONS = unchecked((int)(0x80632095));
    [NativeTypeName("#define PEER_E_UNABLE_TO_LISTEN _HRESULT_TYPEDEF_(0x80632096L)")]
    public const int PEER_E_UNABLE_TO_LISTEN = unchecked((int)(0x80632096));
    [NativeTypeName("#define PEER_E_IDENTITY_DELETED _HRESULT_TYPEDEF_(0x806320A0L)")]
    public const int PEER_E_IDENTITY_DELETED = unchecked((int)(0x806320A0));
    [NativeTypeName("#define PEER_E_SERVICE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x806320A1L)")]
    public const int PEER_E_SERVICE_NOT_AVAILABLE = unchecked((int)(0x806320A1));
    [NativeTypeName("#define PEER_E_CONTACT_NOT_FOUND _HRESULT_TYPEDEF_(0x80636001L)")]
    public const int PEER_E_CONTACT_NOT_FOUND = unchecked((int)(0x80636001));
    [NativeTypeName("#define PEER_S_GRAPH_DATA_CREATED _HRESULT_TYPEDEF_(0x00630001L)")]
    public const int PEER_S_GRAPH_DATA_CREATED = ((int)(0x00630001));
    [NativeTypeName("#define PEER_S_NO_EVENT_DATA _HRESULT_TYPEDEF_(0x00630002L)")]
    public const int PEER_S_NO_EVENT_DATA = ((int)(0x00630002));
    [NativeTypeName("#define PEER_S_ALREADY_CONNECTED _HRESULT_TYPEDEF_(0x00632000L)")]
    public const int PEER_S_ALREADY_CONNECTED = ((int)(0x00632000));
    [NativeTypeName("#define PEER_S_SUBSCRIPTION_EXISTS _HRESULT_TYPEDEF_(0x00636000L)")]
    public const int PEER_S_SUBSCRIPTION_EXISTS = ((int)(0x00636000));
    [NativeTypeName("#define PEER_S_NO_CONNECTIVITY _HRESULT_TYPEDEF_(0x00630005L)")]
    public const int PEER_S_NO_CONNECTIVITY = ((int)(0x00630005));
    [NativeTypeName("#define PEER_S_ALREADY_A_MEMBER _HRESULT_TYPEDEF_(0x00630006L)")]
    public const int PEER_S_ALREADY_A_MEMBER = ((int)(0x00630006));
    [NativeTypeName("#define PEER_E_CANNOT_CONVERT_PEER_NAME _HRESULT_TYPEDEF_(0x80634001L)")]
    public const int PEER_E_CANNOT_CONVERT_PEER_NAME = unchecked((int)(0x80634001));
    [NativeTypeName("#define PEER_E_INVALID_PEER_HOST_NAME _HRESULT_TYPEDEF_(0x80634002L)")]
    public const int PEER_E_INVALID_PEER_HOST_NAME = unchecked((int)(0x80634002));
    [NativeTypeName("#define PEER_E_NO_MORE _HRESULT_TYPEDEF_(0x80634003L)")]
    public const int PEER_E_NO_MORE = unchecked((int)(0x80634003));
    [NativeTypeName("#define PEER_E_PNRP_DUPLICATE_PEER_NAME _HRESULT_TYPEDEF_(0x80634005L)")]
    public const int PEER_E_PNRP_DUPLICATE_PEER_NAME = unchecked((int)(0x80634005));
    [NativeTypeName("#define PEER_E_INVITE_CANCELLED _HRESULT_TYPEDEF_(0x80637000L)")]
    public const int PEER_E_INVITE_CANCELLED = unchecked((int)(0x80637000));
    [NativeTypeName("#define PEER_E_INVITE_RESPONSE_NOT_AVAILABLE _HRESULT_TYPEDEF_(0x80637001L)")]
    public const int PEER_E_INVITE_RESPONSE_NOT_AVAILABLE = unchecked((int)(0x80637001));
    [NativeTypeName("#define PEER_E_NOT_SIGNED_IN _HRESULT_TYPEDEF_(0x80637003L)")]
    public const int PEER_E_NOT_SIGNED_IN = unchecked((int)(0x80637003));
    [NativeTypeName("#define PEER_E_PRIVACY_DECLINED _HRESULT_TYPEDEF_(0x80637004L)")]
    public const int PEER_E_PRIVACY_DECLINED = unchecked((int)(0x80637004));
    [NativeTypeName("#define PEER_E_TIMEOUT _HRESULT_TYPEDEF_(0x80637005L)")]
    public const int PEER_E_TIMEOUT = unchecked((int)(0x80637005));
    [NativeTypeName("#define PEER_E_INVALID_ADDRESS _HRESULT_TYPEDEF_(0x80637007L)")]
    public const int PEER_E_INVALID_ADDRESS = unchecked((int)(0x80637007));
    [NativeTypeName("#define PEER_E_FW_EXCEPTION_DISABLED _HRESULT_TYPEDEF_(0x80637008L)")]
    public const int PEER_E_FW_EXCEPTION_DISABLED = unchecked((int)(0x80637008));
    [NativeTypeName("#define PEER_E_FW_BLOCKED_BY_POLICY _HRESULT_TYPEDEF_(0x80637009L)")]
    public const int PEER_E_FW_BLOCKED_BY_POLICY = unchecked((int)(0x80637009));
    [NativeTypeName("#define PEER_E_FW_BLOCKED_BY_SHIELDS_UP _HRESULT_TYPEDEF_(0x8063700AL)")]
    public const int PEER_E_FW_BLOCKED_BY_SHIELDS_UP = unchecked((int)(0x8063700A));
    [NativeTypeName("#define PEER_E_FW_DECLINED _HRESULT_TYPEDEF_(0x8063700BL)")]
    public const int PEER_E_FW_DECLINED = unchecked((int)(0x8063700B));
}