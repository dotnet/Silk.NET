// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DNS
{
    [NativeTypeName("#define DNS_ERROR_RESPONSE_CODES_BASE 9000")]
    public const int DNS_ERROR_RESPONSE_CODES_BASE = 9000;

    [NativeTypeName("#define DNS_ERROR_RCODE_NO_ERROR NO_ERROR")]
    public const int DNS_ERROR_RCODE_NO_ERROR = 0;

    [NativeTypeName("#define DNS_ERROR_MASK 0x00002328")]
    public const int DNS_ERROR_MASK = 0x00002328;

    [NativeTypeName("#define DNS_ERROR_RCODE_FORMAT_ERROR 9001L")]
    public const int DNS_ERROR_RCODE_FORMAT_ERROR = 9001;

    [NativeTypeName("#define DNS_ERROR_RCODE_SERVER_FAILURE 9002L")]
    public const int DNS_ERROR_RCODE_SERVER_FAILURE = 9002;

    [NativeTypeName("#define DNS_ERROR_RCODE_NAME_ERROR 9003L")]
    public const int DNS_ERROR_RCODE_NAME_ERROR = 9003;

    [NativeTypeName("#define DNS_ERROR_RCODE_NOT_IMPLEMENTED 9004L")]
    public const int DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004;

    [NativeTypeName("#define DNS_ERROR_RCODE_REFUSED 9005L")]
    public const int DNS_ERROR_RCODE_REFUSED = 9005;

    [NativeTypeName("#define DNS_ERROR_RCODE_YXDOMAIN 9006L")]
    public const int DNS_ERROR_RCODE_YXDOMAIN = 9006;

    [NativeTypeName("#define DNS_ERROR_RCODE_YXRRSET 9007L")]
    public const int DNS_ERROR_RCODE_YXRRSET = 9007;

    [NativeTypeName("#define DNS_ERROR_RCODE_NXRRSET 9008L")]
    public const int DNS_ERROR_RCODE_NXRRSET = 9008;

    [NativeTypeName("#define DNS_ERROR_RCODE_NOTAUTH 9009L")]
    public const int DNS_ERROR_RCODE_NOTAUTH = 9009;

    [NativeTypeName("#define DNS_ERROR_RCODE_NOTZONE 9010L")]
    public const int DNS_ERROR_RCODE_NOTZONE = 9010;

    [NativeTypeName("#define DNS_ERROR_RCODE_BADSIG 9016L")]
    public const int DNS_ERROR_RCODE_BADSIG = 9016;

    [NativeTypeName("#define DNS_ERROR_RCODE_BADKEY 9017L")]
    public const int DNS_ERROR_RCODE_BADKEY = 9017;

    [NativeTypeName("#define DNS_ERROR_RCODE_BADTIME 9018L")]
    public const int DNS_ERROR_RCODE_BADTIME = 9018;

    [NativeTypeName("#define DNS_ERROR_RCODE_LAST DNS_ERROR_RCODE_BADTIME")]
    public const int DNS_ERROR_RCODE_LAST = 9018;

    [NativeTypeName("#define DNS_ERROR_DNSSEC_BASE 9100")]
    public const int DNS_ERROR_DNSSEC_BASE = 9100;

    [NativeTypeName("#define DNS_ERROR_KEYMASTER_REQUIRED 9101L")]
    public const int DNS_ERROR_KEYMASTER_REQUIRED = 9101;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE 9102L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE = 9102;

    [NativeTypeName("#define DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 9103L")]
    public const int DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 = 9103;

    [NativeTypeName("#define DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS 9104L")]
    public const int DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS = 9104;

    [NativeTypeName("#define DNS_ERROR_UNSUPPORTED_ALGORITHM 9105L")]
    public const int DNS_ERROR_UNSUPPORTED_ALGORITHM = 9105;

    [NativeTypeName("#define DNS_ERROR_INVALID_KEY_SIZE 9106L")]
    public const int DNS_ERROR_INVALID_KEY_SIZE = 9106;

    [NativeTypeName("#define DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE 9107L")]
    public const int DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE = 9107;

    [NativeTypeName("#define DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION 9108L")]
    public const int DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION = 9108;

    [NativeTypeName("#define DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR 9109L")]
    public const int DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR = 9109;

    [NativeTypeName("#define DNS_ERROR_UNEXPECTED_CNG_ERROR 9110L")]
    public const int DNS_ERROR_UNEXPECTED_CNG_ERROR = 9110;

    [NativeTypeName("#define DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION 9111L")]
    public const int DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION = 9111;

    [NativeTypeName("#define DNS_ERROR_KSP_NOT_ACCESSIBLE 9112L")]
    public const int DNS_ERROR_KSP_NOT_ACCESSIBLE = 9112;

    [NativeTypeName("#define DNS_ERROR_TOO_MANY_SKDS 9113L")]
    public const int DNS_ERROR_TOO_MANY_SKDS = 9113;

    [NativeTypeName("#define DNS_ERROR_INVALID_ROLLOVER_PERIOD 9114L")]
    public const int DNS_ERROR_INVALID_ROLLOVER_PERIOD = 9114;

    [NativeTypeName("#define DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET 9115L")]
    public const int DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET = 9115;

    [NativeTypeName("#define DNS_ERROR_ROLLOVER_IN_PROGRESS 9116L")]
    public const int DNS_ERROR_ROLLOVER_IN_PROGRESS = 9116;

    [NativeTypeName("#define DNS_ERROR_STANDBY_KEY_NOT_PRESENT 9117L")]
    public const int DNS_ERROR_STANDBY_KEY_NOT_PRESENT = 9117;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ZSK 9118L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ZSK = 9118;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD 9119L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD = 9119;

    [NativeTypeName("#define DNS_ERROR_ROLLOVER_ALREADY_QUEUED 9120L")]
    public const int DNS_ERROR_ROLLOVER_ALREADY_QUEUED = 9120;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE 9121L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE = 9121;

    [NativeTypeName("#define DNS_ERROR_BAD_KEYMASTER 9122L")]
    public const int DNS_ERROR_BAD_KEYMASTER = 9122;

    [NativeTypeName("#define DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD 9123L")]
    public const int DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD = 9123;

    [NativeTypeName("#define DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT 9124L")]
    public const int DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT = 9124;

    [NativeTypeName("#define DNS_ERROR_DNSSEC_IS_DISABLED 9125L")]
    public const int DNS_ERROR_DNSSEC_IS_DISABLED = 9125;

    [NativeTypeName("#define DNS_ERROR_INVALID_XML 9126L")]
    public const int DNS_ERROR_INVALID_XML = 9126;

    [NativeTypeName("#define DNS_ERROR_NO_VALID_TRUST_ANCHORS 9127L")]
    public const int DNS_ERROR_NO_VALID_TRUST_ANCHORS = 9127;

    [NativeTypeName("#define DNS_ERROR_ROLLOVER_NOT_POKEABLE 9128L")]
    public const int DNS_ERROR_ROLLOVER_NOT_POKEABLE = 9128;

    [NativeTypeName("#define DNS_ERROR_NSEC3_NAME_COLLISION 9129L")]
    public const int DNS_ERROR_NSEC3_NAME_COLLISION = 9129;

    [NativeTypeName("#define DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 9130L")]
    public const int DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 = 9130;

    [NativeTypeName("#define DNS_ERROR_PACKET_FMT_BASE 9500")]
    public const int DNS_ERROR_PACKET_FMT_BASE = 9500;

    [NativeTypeName("#define DNS_INFO_NO_RECORDS 9501L")]
    public const int DNS_INFO_NO_RECORDS = 9501;

    [NativeTypeName("#define DNS_ERROR_BAD_PACKET 9502L")]
    public const int DNS_ERROR_BAD_PACKET = 9502;

    [NativeTypeName("#define DNS_ERROR_NO_PACKET 9503L")]
    public const int DNS_ERROR_NO_PACKET = 9503;

    [NativeTypeName("#define DNS_ERROR_RCODE 9504L")]
    public const int DNS_ERROR_RCODE = 9504;

    [NativeTypeName("#define DNS_ERROR_UNSECURE_PACKET 9505L")]
    public const int DNS_ERROR_UNSECURE_PACKET = 9505;

    [NativeTypeName("#define DNS_STATUS_PACKET_UNSECURE DNS_ERROR_UNSECURE_PACKET")]
    public const int DNS_STATUS_PACKET_UNSECURE = 9505;

    [NativeTypeName("#define DNS_REQUEST_PENDING 9506L")]
    public const int DNS_REQUEST_PENDING = 9506;

    [NativeTypeName("#define DNS_ERROR_NO_MEMORY ERROR_OUTOFMEMORY")]
    public const int DNS_ERROR_NO_MEMORY = 14;

    [NativeTypeName("#define DNS_ERROR_INVALID_NAME ERROR_INVALID_NAME")]
    public const int DNS_ERROR_INVALID_NAME = 123;

    [NativeTypeName("#define DNS_ERROR_INVALID_DATA ERROR_INVALID_DATA")]
    public const int DNS_ERROR_INVALID_DATA = 13;

    [NativeTypeName("#define DNS_ERROR_GENERAL_API_BASE 9550")]
    public const int DNS_ERROR_GENERAL_API_BASE = 9550;

    [NativeTypeName("#define DNS_ERROR_INVALID_TYPE 9551L")]
    public const int DNS_ERROR_INVALID_TYPE = 9551;

    [NativeTypeName("#define DNS_ERROR_INVALID_IP_ADDRESS 9552L")]
    public const int DNS_ERROR_INVALID_IP_ADDRESS = 9552;

    [NativeTypeName("#define DNS_ERROR_INVALID_PROPERTY 9553L")]
    public const int DNS_ERROR_INVALID_PROPERTY = 9553;

    [NativeTypeName("#define DNS_ERROR_TRY_AGAIN_LATER 9554L")]
    public const int DNS_ERROR_TRY_AGAIN_LATER = 9554;

    [NativeTypeName("#define DNS_ERROR_NOT_UNIQUE 9555L")]
    public const int DNS_ERROR_NOT_UNIQUE = 9555;

    [NativeTypeName("#define DNS_ERROR_NON_RFC_NAME 9556L")]
    public const int DNS_ERROR_NON_RFC_NAME = 9556;

    [NativeTypeName("#define DNS_STATUS_FQDN 9557L")]
    public const int DNS_STATUS_FQDN = 9557;

    [NativeTypeName("#define DNS_STATUS_DOTTED_NAME 9558L")]
    public const int DNS_STATUS_DOTTED_NAME = 9558;

    [NativeTypeName("#define DNS_STATUS_SINGLE_PART_NAME 9559L")]
    public const int DNS_STATUS_SINGLE_PART_NAME = 9559;

    [NativeTypeName("#define DNS_ERROR_INVALID_NAME_CHAR 9560L")]
    public const int DNS_ERROR_INVALID_NAME_CHAR = 9560;

    [NativeTypeName("#define DNS_ERROR_NUMERIC_NAME 9561L")]
    public const int DNS_ERROR_NUMERIC_NAME = 9561;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER 9562L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION 9563L")]
    public const int DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563;

    [NativeTypeName("#define DNS_ERROR_CANNOT_FIND_ROOT_HINTS 9564L")]
    public const int DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564;

    [NativeTypeName("#define DNS_ERROR_INCONSISTENT_ROOT_HINTS 9565L")]
    public const int DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565;

    [NativeTypeName("#define DNS_ERROR_DWORD_VALUE_TOO_SMALL 9566L")]
    public const int DNS_ERROR_DWORD_VALUE_TOO_SMALL = 9566;

    [NativeTypeName("#define DNS_ERROR_DWORD_VALUE_TOO_LARGE 9567L")]
    public const int DNS_ERROR_DWORD_VALUE_TOO_LARGE = 9567;

    [NativeTypeName("#define DNS_ERROR_BACKGROUND_LOADING 9568L")]
    public const int DNS_ERROR_BACKGROUND_LOADING = 9568;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_RODC 9569L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_RODC = 9569;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_UNDER_DNAME 9570L")]
    public const int DNS_ERROR_NOT_ALLOWED_UNDER_DNAME = 9570;

    [NativeTypeName("#define DNS_ERROR_DELEGATION_REQUIRED 9571L")]
    public const int DNS_ERROR_DELEGATION_REQUIRED = 9571;

    [NativeTypeName("#define DNS_ERROR_INVALID_POLICY_TABLE 9572L")]
    public const int DNS_ERROR_INVALID_POLICY_TABLE = 9572;

    [NativeTypeName("#define DNS_ERROR_ADDRESS_REQUIRED 9573L")]
    public const int DNS_ERROR_ADDRESS_REQUIRED = 9573;

    [NativeTypeName("#define DNS_ERROR_ZONE_BASE 9600")]
    public const int DNS_ERROR_ZONE_BASE = 9600;

    [NativeTypeName("#define DNS_ERROR_ZONE_DOES_NOT_EXIST 9601L")]
    public const int DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601;

    [NativeTypeName("#define DNS_ERROR_NO_ZONE_INFO 9602L")]
    public const int DNS_ERROR_NO_ZONE_INFO = 9602;

    [NativeTypeName("#define DNS_ERROR_INVALID_ZONE_OPERATION 9603L")]
    public const int DNS_ERROR_INVALID_ZONE_OPERATION = 9603;

    [NativeTypeName("#define DNS_ERROR_ZONE_CONFIGURATION_ERROR 9604L")]
    public const int DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604;

    [NativeTypeName("#define DNS_ERROR_ZONE_HAS_NO_SOA_RECORD 9605L")]
    public const int DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605;

    [NativeTypeName("#define DNS_ERROR_ZONE_HAS_NO_NS_RECORDS 9606L")]
    public const int DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606;

    [NativeTypeName("#define DNS_ERROR_ZONE_LOCKED 9607L")]
    public const int DNS_ERROR_ZONE_LOCKED = 9607;

    [NativeTypeName("#define DNS_ERROR_ZONE_CREATION_FAILED 9608L")]
    public const int DNS_ERROR_ZONE_CREATION_FAILED = 9608;

    [NativeTypeName("#define DNS_ERROR_ZONE_ALREADY_EXISTS 9609L")]
    public const int DNS_ERROR_ZONE_ALREADY_EXISTS = 9609;

    [NativeTypeName("#define DNS_ERROR_AUTOZONE_ALREADY_EXISTS 9610L")]
    public const int DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610;

    [NativeTypeName("#define DNS_ERROR_INVALID_ZONE_TYPE 9611L")]
    public const int DNS_ERROR_INVALID_ZONE_TYPE = 9611;

    [NativeTypeName("#define DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP 9612L")]
    public const int DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612;

    [NativeTypeName("#define DNS_ERROR_ZONE_NOT_SECONDARY 9613L")]
    public const int DNS_ERROR_ZONE_NOT_SECONDARY = 9613;

    [NativeTypeName("#define DNS_ERROR_NEED_SECONDARY_ADDRESSES 9614L")]
    public const int DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614;

    [NativeTypeName("#define DNS_ERROR_WINS_INIT_FAILED 9615L")]
    public const int DNS_ERROR_WINS_INIT_FAILED = 9615;

    [NativeTypeName("#define DNS_ERROR_NEED_WINS_SERVERS 9616L")]
    public const int DNS_ERROR_NEED_WINS_SERVERS = 9616;

    [NativeTypeName("#define DNS_ERROR_NBSTAT_INIT_FAILED 9617L")]
    public const int DNS_ERROR_NBSTAT_INIT_FAILED = 9617;

    [NativeTypeName("#define DNS_ERROR_SOA_DELETE_INVALID 9618L")]
    public const int DNS_ERROR_SOA_DELETE_INVALID = 9618;

    [NativeTypeName("#define DNS_ERROR_FORWARDER_ALREADY_EXISTS 9619L")]
    public const int DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619;

    [NativeTypeName("#define DNS_ERROR_ZONE_REQUIRES_MASTER_IP 9620L")]
    public const int DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620;

    [NativeTypeName("#define DNS_ERROR_ZONE_IS_SHUTDOWN 9621L")]
    public const int DNS_ERROR_ZONE_IS_SHUTDOWN = 9621;

    [NativeTypeName("#define DNS_ERROR_ZONE_LOCKED_FOR_SIGNING 9622L")]
    public const int DNS_ERROR_ZONE_LOCKED_FOR_SIGNING = 9622;

    [NativeTypeName("#define DNS_ERROR_DATAFILE_BASE 9650")]
    public const int DNS_ERROR_DATAFILE_BASE = 9650;

    [NativeTypeName("#define DNS_ERROR_PRIMARY_REQUIRES_DATAFILE 9651L")]
    public const int DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651;

    [NativeTypeName("#define DNS_ERROR_INVALID_DATAFILE_NAME 9652L")]
    public const int DNS_ERROR_INVALID_DATAFILE_NAME = 9652;

    [NativeTypeName("#define DNS_ERROR_DATAFILE_OPEN_FAILURE 9653L")]
    public const int DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653;

    [NativeTypeName("#define DNS_ERROR_FILE_WRITEBACK_FAILED 9654L")]
    public const int DNS_ERROR_FILE_WRITEBACK_FAILED = 9654;

    [NativeTypeName("#define DNS_ERROR_DATAFILE_PARSING 9655L")]
    public const int DNS_ERROR_DATAFILE_PARSING = 9655;

    [NativeTypeName("#define DNS_ERROR_DATABASE_BASE 9700")]
    public const int DNS_ERROR_DATABASE_BASE = 9700;

    [NativeTypeName("#define DNS_ERROR_RECORD_DOES_NOT_EXIST 9701L")]
    public const int DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701;

    [NativeTypeName("#define DNS_ERROR_RECORD_FORMAT 9702L")]
    public const int DNS_ERROR_RECORD_FORMAT = 9702;

    [NativeTypeName("#define DNS_ERROR_NODE_CREATION_FAILED 9703L")]
    public const int DNS_ERROR_NODE_CREATION_FAILED = 9703;

    [NativeTypeName("#define DNS_ERROR_UNKNOWN_RECORD_TYPE 9704L")]
    public const int DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704;

    [NativeTypeName("#define DNS_ERROR_RECORD_TIMED_OUT 9705L")]
    public const int DNS_ERROR_RECORD_TIMED_OUT = 9705;

    [NativeTypeName("#define DNS_ERROR_NAME_NOT_IN_ZONE 9706L")]
    public const int DNS_ERROR_NAME_NOT_IN_ZONE = 9706;

    [NativeTypeName("#define DNS_ERROR_CNAME_LOOP 9707L")]
    public const int DNS_ERROR_CNAME_LOOP = 9707;

    [NativeTypeName("#define DNS_ERROR_NODE_IS_CNAME 9708L")]
    public const int DNS_ERROR_NODE_IS_CNAME = 9708;

    [NativeTypeName("#define DNS_ERROR_CNAME_COLLISION 9709L")]
    public const int DNS_ERROR_CNAME_COLLISION = 9709;

    [NativeTypeName("#define DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT 9710L")]
    public const int DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710;

    [NativeTypeName("#define DNS_ERROR_RECORD_ALREADY_EXISTS 9711L")]
    public const int DNS_ERROR_RECORD_ALREADY_EXISTS = 9711;

    [NativeTypeName("#define DNS_ERROR_SECONDARY_DATA 9712L")]
    public const int DNS_ERROR_SECONDARY_DATA = 9712;

    [NativeTypeName("#define DNS_ERROR_NO_CREATE_CACHE_DATA 9713L")]
    public const int DNS_ERROR_NO_CREATE_CACHE_DATA = 9713;

    [NativeTypeName("#define DNS_ERROR_NAME_DOES_NOT_EXIST 9714L")]
    public const int DNS_ERROR_NAME_DOES_NOT_EXIST = 9714;

    [NativeTypeName("#define DNS_WARNING_PTR_CREATE_FAILED 9715L")]
    public const int DNS_WARNING_PTR_CREATE_FAILED = 9715;

    [NativeTypeName("#define DNS_WARNING_DOMAIN_UNDELETED 9716L")]
    public const int DNS_WARNING_DOMAIN_UNDELETED = 9716;

    [NativeTypeName("#define DNS_ERROR_DS_UNAVAILABLE 9717L")]
    public const int DNS_ERROR_DS_UNAVAILABLE = 9717;

    [NativeTypeName("#define DNS_ERROR_DS_ZONE_ALREADY_EXISTS 9718L")]
    public const int DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718;

    [NativeTypeName("#define DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE 9719L")]
    public const int DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719;

    [NativeTypeName("#define DNS_ERROR_NODE_IS_DNAME 9720L")]
    public const int DNS_ERROR_NODE_IS_DNAME = 9720;

    [NativeTypeName("#define DNS_ERROR_DNAME_COLLISION 9721L")]
    public const int DNS_ERROR_DNAME_COLLISION = 9721;

    [NativeTypeName("#define DNS_ERROR_ALIAS_LOOP 9722L")]
    public const int DNS_ERROR_ALIAS_LOOP = 9722;

    [NativeTypeName("#define DNS_ERROR_OPERATION_BASE 9750")]
    public const int DNS_ERROR_OPERATION_BASE = 9750;

    [NativeTypeName("#define DNS_INFO_AXFR_COMPLETE 9751L")]
    public const int DNS_INFO_AXFR_COMPLETE = 9751;

    [NativeTypeName("#define DNS_ERROR_AXFR 9752L")]
    public const int DNS_ERROR_AXFR = 9752;

    [NativeTypeName("#define DNS_INFO_ADDED_LOCAL_WINS 9753L")]
    public const int DNS_INFO_ADDED_LOCAL_WINS = 9753;

    [NativeTypeName("#define DNS_ERROR_SECURE_BASE 9800")]
    public const int DNS_ERROR_SECURE_BASE = 9800;

    [NativeTypeName("#define DNS_STATUS_CONTINUE_NEEDED 9801L")]
    public const int DNS_STATUS_CONTINUE_NEEDED = 9801;

    [NativeTypeName("#define DNS_ERROR_SETUP_BASE 9850")]
    public const int DNS_ERROR_SETUP_BASE = 9850;

    [NativeTypeName("#define DNS_ERROR_NO_TCPIP 9851L")]
    public const int DNS_ERROR_NO_TCPIP = 9851;

    [NativeTypeName("#define DNS_ERROR_NO_DNS_SERVERS 9852L")]
    public const int DNS_ERROR_NO_DNS_SERVERS = 9852;

    [NativeTypeName("#define DNS_ERROR_DP_BASE 9900")]
    public const int DNS_ERROR_DP_BASE = 9900;

    [NativeTypeName("#define DNS_ERROR_DP_DOES_NOT_EXIST 9901L")]
    public const int DNS_ERROR_DP_DOES_NOT_EXIST = 9901;

    [NativeTypeName("#define DNS_ERROR_DP_ALREADY_EXISTS 9902L")]
    public const int DNS_ERROR_DP_ALREADY_EXISTS = 9902;

    [NativeTypeName("#define DNS_ERROR_DP_NOT_ENLISTED 9903L")]
    public const int DNS_ERROR_DP_NOT_ENLISTED = 9903;

    [NativeTypeName("#define DNS_ERROR_DP_ALREADY_ENLISTED 9904L")]
    public const int DNS_ERROR_DP_ALREADY_ENLISTED = 9904;

    [NativeTypeName("#define DNS_ERROR_DP_NOT_AVAILABLE 9905L")]
    public const int DNS_ERROR_DP_NOT_AVAILABLE = 9905;

    [NativeTypeName("#define DNS_ERROR_DP_FSMO_ERROR 9906L")]
    public const int DNS_ERROR_DP_FSMO_ERROR = 9906;

    [NativeTypeName("#define DNS_ERROR_RRL_NOT_ENABLED 9911L")]
    public const int DNS_ERROR_RRL_NOT_ENABLED = 9911;

    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_WINDOW_SIZE 9912L")]
    public const int DNS_ERROR_RRL_INVALID_WINDOW_SIZE = 9912;

    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_IPV4_PREFIX 9913L")]
    public const int DNS_ERROR_RRL_INVALID_IPV4_PREFIX = 9913;

    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_IPV6_PREFIX 9914L")]
    public const int DNS_ERROR_RRL_INVALID_IPV6_PREFIX = 9914;

    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_TC_RATE 9915L")]
    public const int DNS_ERROR_RRL_INVALID_TC_RATE = 9915;

    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_LEAK_RATE 9916L")]
    public const int DNS_ERROR_RRL_INVALID_LEAK_RATE = 9916;

    [NativeTypeName("#define DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE 9917L")]
    public const int DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE = 9917;

    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS 9921L")]
    public const int DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS = 9921;

    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST 9922L")]
    public const int DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST = 9922;

    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_TREE_LOCKED 9923L")]
    public const int DNS_ERROR_VIRTUALIZATION_TREE_LOCKED = 9923;

    [NativeTypeName("#define DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME 9924L")]
    public const int DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME = 9924;

    [NativeTypeName("#define DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE 9925L")]
    public const int DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE = 9925;

    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_ALREADY_EXISTS 9951L")]
    public const int DNS_ERROR_ZONESCOPE_ALREADY_EXISTS = 9951;

    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST 9952L")]
    public const int DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST = 9952;

    [NativeTypeName("#define DNS_ERROR_DEFAULT_ZONESCOPE 9953L")]
    public const int DNS_ERROR_DEFAULT_ZONESCOPE = 9953;

    [NativeTypeName("#define DNS_ERROR_INVALID_ZONESCOPE_NAME 9954L")]
    public const int DNS_ERROR_INVALID_ZONESCOPE_NAME = 9954;

    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES 9955L")]
    public const int DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES = 9955;

    [NativeTypeName("#define DNS_ERROR_LOAD_ZONESCOPE_FAILED 9956L")]
    public const int DNS_ERROR_LOAD_ZONESCOPE_FAILED = 9956;

    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED 9957L")]
    public const int DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED = 9957;

    [NativeTypeName("#define DNS_ERROR_INVALID_SCOPE_NAME 9958L")]
    public const int DNS_ERROR_INVALID_SCOPE_NAME = 9958;

    [NativeTypeName("#define DNS_ERROR_SCOPE_DOES_NOT_EXIST 9959L")]
    public const int DNS_ERROR_SCOPE_DOES_NOT_EXIST = 9959;

    [NativeTypeName("#define DNS_ERROR_DEFAULT_SCOPE 9960L")]
    public const int DNS_ERROR_DEFAULT_SCOPE = 9960;

    [NativeTypeName("#define DNS_ERROR_INVALID_SCOPE_OPERATION 9961L")]
    public const int DNS_ERROR_INVALID_SCOPE_OPERATION = 9961;

    [NativeTypeName("#define DNS_ERROR_SCOPE_LOCKED 9962L")]
    public const int DNS_ERROR_SCOPE_LOCKED = 9962;

    [NativeTypeName("#define DNS_ERROR_SCOPE_ALREADY_EXISTS 9963L")]
    public const int DNS_ERROR_SCOPE_ALREADY_EXISTS = 9963;

    [NativeTypeName("#define DNS_ERROR_POLICY_ALREADY_EXISTS 9971L")]
    public const int DNS_ERROR_POLICY_ALREADY_EXISTS = 9971;

    [NativeTypeName("#define DNS_ERROR_POLICY_DOES_NOT_EXIST 9972L")]
    public const int DNS_ERROR_POLICY_DOES_NOT_EXIST = 9972;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA 9973L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA = 9973;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_SETTINGS 9974L")]
    public const int DNS_ERROR_POLICY_INVALID_SETTINGS = 9974;

    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED 9975L")]
    public const int DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED = 9975;

    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST 9976L")]
    public const int DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST = 9976;

    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS 9977L")]
    public const int DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS = 9977;

    [NativeTypeName("#define DNS_ERROR_SUBNET_DOES_NOT_EXIST 9978L")]
    public const int DNS_ERROR_SUBNET_DOES_NOT_EXIST = 9978;

    [NativeTypeName("#define DNS_ERROR_SUBNET_ALREADY_EXISTS 9979L")]
    public const int DNS_ERROR_SUBNET_ALREADY_EXISTS = 9979;

    [NativeTypeName("#define DNS_ERROR_POLICY_LOCKED 9980L")]
    public const int DNS_ERROR_POLICY_LOCKED = 9980;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_WEIGHT 9981L")]
    public const int DNS_ERROR_POLICY_INVALID_WEIGHT = 9981;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_NAME 9982L")]
    public const int DNS_ERROR_POLICY_INVALID_NAME = 9982;

    [NativeTypeName("#define DNS_ERROR_POLICY_MISSING_CRITERIA 9983L")]
    public const int DNS_ERROR_POLICY_MISSING_CRITERIA = 9983;

    [NativeTypeName("#define DNS_ERROR_INVALID_CLIENT_SUBNET_NAME 9984L")]
    public const int DNS_ERROR_INVALID_CLIENT_SUBNET_NAME = 9984;

    [NativeTypeName("#define DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID 9985L")]
    public const int DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID = 9985;

    [NativeTypeName("#define DNS_ERROR_POLICY_SCOPE_MISSING 9986L")]
    public const int DNS_ERROR_POLICY_SCOPE_MISSING = 9986;

    [NativeTypeName("#define DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED 9987L")]
    public const int DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED = 9987;

    [NativeTypeName("#define DNS_ERROR_SERVERSCOPE_IS_REFERENCED 9988L")]
    public const int DNS_ERROR_SERVERSCOPE_IS_REFERENCED = 9988;

    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_IS_REFERENCED 9989L")]
    public const int DNS_ERROR_ZONESCOPE_IS_REFERENCED = 9989;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET 9990L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET = 9990;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL 9991L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL = 9991;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL 9992L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL = 9992;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE 9993L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE = 9993;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN 9994L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN = 9994;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE 9995L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE = 9995;

    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY 9996L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY = 9996;
}
