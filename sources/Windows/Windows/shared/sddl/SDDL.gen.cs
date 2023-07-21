// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/sddl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SDDL
{
    [NativeTypeName("#define SDDL_REVISION_1 1")]
    public const int SDDL_REVISION_1 = 1;

    [NativeTypeName("#define SDDL_REVISION SDDL_REVISION_1")]
    public const int SDDL_REVISION = 1;

    [NativeTypeName("#define SDDL_OWNER TEXT(\"O\")")]
    public const string SDDL_OWNER = "O";

    [NativeTypeName("#define SDDL_GROUP TEXT(\"G\")")]
    public const string SDDL_GROUP = "G";

    [NativeTypeName("#define SDDL_DACL TEXT(\"D\")")]
    public const string SDDL_DACL = "D";

    [NativeTypeName("#define SDDL_SACL TEXT(\"S\")")]
    public const string SDDL_SACL = "S";

    [NativeTypeName("#define SDDL_PROTECTED TEXT(\"P\")")]
    public const string SDDL_PROTECTED = "P";

    [NativeTypeName("#define SDDL_AUTO_INHERIT_REQ TEXT(\"AR\")")]
    public const string SDDL_AUTO_INHERIT_REQ = "AR";

    [NativeTypeName("#define SDDL_AUTO_INHERITED TEXT(\"AI\")")]
    public const string SDDL_AUTO_INHERITED = "AI";

    [NativeTypeName("#define SDDL_NULL_ACL TEXT(\"NO_ACCESS_CONTROL\")")]
    public const string SDDL_NULL_ACL = "NO_ACCESS_CONTROL";

    [NativeTypeName("#define SDDL_ACCESS_ALLOWED TEXT(\"A\")")]
    public const string SDDL_ACCESS_ALLOWED = "A";

    [NativeTypeName("#define SDDL_ACCESS_DENIED TEXT(\"D\")")]
    public const string SDDL_ACCESS_DENIED = "D";

    [NativeTypeName("#define SDDL_OBJECT_ACCESS_ALLOWED TEXT(\"OA\")")]
    public const string SDDL_OBJECT_ACCESS_ALLOWED = "OA";

    [NativeTypeName("#define SDDL_OBJECT_ACCESS_DENIED TEXT(\"OD\")")]
    public const string SDDL_OBJECT_ACCESS_DENIED = "OD";

    [NativeTypeName("#define SDDL_AUDIT TEXT(\"AU\")")]
    public const string SDDL_AUDIT = "AU";

    [NativeTypeName("#define SDDL_ALARM TEXT(\"AL\")")]
    public const string SDDL_ALARM = "AL";

    [NativeTypeName("#define SDDL_OBJECT_AUDIT TEXT(\"OU\")")]
    public const string SDDL_OBJECT_AUDIT = "OU";

    [NativeTypeName("#define SDDL_OBJECT_ALARM TEXT(\"OL\")")]
    public const string SDDL_OBJECT_ALARM = "OL";

    [NativeTypeName("#define SDDL_MANDATORY_LABEL TEXT(\"ML\")")]
    public const string SDDL_MANDATORY_LABEL = "ML";

    [NativeTypeName("#define SDDL_PROCESS_TRUST_LABEL TEXT(\"TL\")")]
    public const string SDDL_PROCESS_TRUST_LABEL = "TL";

    [NativeTypeName("#define SDDL_CALLBACK_ACCESS_ALLOWED TEXT(\"XA\")")]
    public const string SDDL_CALLBACK_ACCESS_ALLOWED = "XA";

    [NativeTypeName("#define SDDL_CALLBACK_ACCESS_DENIED TEXT(\"XD\")")]
    public const string SDDL_CALLBACK_ACCESS_DENIED = "XD";

    [NativeTypeName("#define SDDL_RESOURCE_ATTRIBUTE TEXT(\"RA\")")]
    public const string SDDL_RESOURCE_ATTRIBUTE = "RA";

    [NativeTypeName("#define SDDL_SCOPED_POLICY_ID TEXT(\"SP\")")]
    public const string SDDL_SCOPED_POLICY_ID = "SP";

    [NativeTypeName("#define SDDL_CALLBACK_AUDIT TEXT(\"XU\")")]
    public const string SDDL_CALLBACK_AUDIT = "XU";

    [NativeTypeName("#define SDDL_CALLBACK_OBJECT_ACCESS_ALLOWED TEXT(\"ZA\")")]
    public const string SDDL_CALLBACK_OBJECT_ACCESS_ALLOWED = "ZA";

    [NativeTypeName("#define SDDL_ACCESS_FILTER TEXT(\"FL\")")]
    public const string SDDL_ACCESS_FILTER = "FL";

    [NativeTypeName("#define SDDL_INT TEXT(\"TI\")")]
    public const string SDDL_INT = "TI";

    [NativeTypeName("#define SDDL_UINT TEXT(\"TU\")")]
    public const string SDDL_UINT = "TU";

    [NativeTypeName("#define SDDL_WSTRING TEXT(\"TS\")")]
    public const string SDDL_WSTRING = "TS";

    [NativeTypeName("#define SDDL_SID TEXT(\"TD\")")]
    public const string SDDL_SID = "TD";

    [NativeTypeName("#define SDDL_BLOB TEXT(\"TX\")")]
    public const string SDDL_BLOB = "TX";

    [NativeTypeName("#define SDDL_BOOLEAN TEXT(\"TB\")")]
    public const string SDDL_BOOLEAN = "TB";

    [NativeTypeName("#define SDDL_CONTAINER_INHERIT TEXT(\"CI\")")]
    public const string SDDL_CONTAINER_INHERIT = "CI";

    [NativeTypeName("#define SDDL_OBJECT_INHERIT TEXT(\"OI\")")]
    public const string SDDL_OBJECT_INHERIT = "OI";

    [NativeTypeName("#define SDDL_NO_PROPAGATE TEXT(\"NP\")")]
    public const string SDDL_NO_PROPAGATE = "NP";

    [NativeTypeName("#define SDDL_INHERIT_ONLY TEXT(\"IO\")")]
    public const string SDDL_INHERIT_ONLY = "IO";

    [NativeTypeName("#define SDDL_INHERITED TEXT(\"ID\")")]
    public const string SDDL_INHERITED = "ID";

    [NativeTypeName("#define SDDL_CRITICAL TEXT(\"CR\")")]
    public const string SDDL_CRITICAL = "CR";

    [NativeTypeName("#define SDDL_TRUST_PROTECTED_FILTER TEXT(\"TP\")")]
    public const string SDDL_TRUST_PROTECTED_FILTER = "TP";

    [NativeTypeName("#define SDDL_AUDIT_SUCCESS TEXT(\"SA\")")]
    public const string SDDL_AUDIT_SUCCESS = "SA";

    [NativeTypeName("#define SDDL_AUDIT_FAILURE TEXT(\"FA\")")]
    public const string SDDL_AUDIT_FAILURE = "FA";

    [NativeTypeName("#define SDDL_READ_PROPERTY TEXT(\"RP\")")]
    public const string SDDL_READ_PROPERTY = "RP";

    [NativeTypeName("#define SDDL_WRITE_PROPERTY TEXT(\"WP\")")]
    public const string SDDL_WRITE_PROPERTY = "WP";

    [NativeTypeName("#define SDDL_CREATE_CHILD TEXT(\"CC\")")]
    public const string SDDL_CREATE_CHILD = "CC";

    [NativeTypeName("#define SDDL_DELETE_CHILD TEXT(\"DC\")")]
    public const string SDDL_DELETE_CHILD = "DC";

    [NativeTypeName("#define SDDL_LIST_CHILDREN TEXT(\"LC\")")]
    public const string SDDL_LIST_CHILDREN = "LC";

    [NativeTypeName("#define SDDL_SELF_WRITE TEXT(\"SW\")")]
    public const string SDDL_SELF_WRITE = "SW";

    [NativeTypeName("#define SDDL_LIST_OBJECT TEXT(\"LO\")")]
    public const string SDDL_LIST_OBJECT = "LO";

    [NativeTypeName("#define SDDL_DELETE_TREE TEXT(\"DT\")")]
    public const string SDDL_DELETE_TREE = "DT";

    [NativeTypeName("#define SDDL_CONTROL_ACCESS TEXT(\"CR\")")]
    public const string SDDL_CONTROL_ACCESS = "CR";

    [NativeTypeName("#define SDDL_READ_CONTROL TEXT(\"RC\")")]
    public const string SDDL_READ_CONTROL = "RC";

    [NativeTypeName("#define SDDL_WRITE_DAC TEXT(\"WD\")")]
    public const string SDDL_WRITE_DAC = "WD";

    [NativeTypeName("#define SDDL_WRITE_OWNER TEXT(\"WO\")")]
    public const string SDDL_WRITE_OWNER = "WO";

    [NativeTypeName("#define SDDL_STANDARD_DELETE TEXT(\"SD\")")]
    public const string SDDL_STANDARD_DELETE = "SD";

    [NativeTypeName("#define SDDL_GENERIC_ALL TEXT(\"GA\")")]
    public const string SDDL_GENERIC_ALL = "GA";

    [NativeTypeName("#define SDDL_GENERIC_READ TEXT(\"GR\")")]
    public const string SDDL_GENERIC_READ = "GR";

    [NativeTypeName("#define SDDL_GENERIC_WRITE TEXT(\"GW\")")]
    public const string SDDL_GENERIC_WRITE = "GW";

    [NativeTypeName("#define SDDL_GENERIC_EXECUTE TEXT(\"GX\")")]
    public const string SDDL_GENERIC_EXECUTE = "GX";

    [NativeTypeName("#define SDDL_FILE_ALL TEXT(\"FA\")")]
    public const string SDDL_FILE_ALL = "FA";

    [NativeTypeName("#define SDDL_FILE_READ TEXT(\"FR\")")]
    public const string SDDL_FILE_READ = "FR";

    [NativeTypeName("#define SDDL_FILE_WRITE TEXT(\"FW\")")]
    public const string SDDL_FILE_WRITE = "FW";

    [NativeTypeName("#define SDDL_FILE_EXECUTE TEXT(\"FX\")")]
    public const string SDDL_FILE_EXECUTE = "FX";

    [NativeTypeName("#define SDDL_KEY_ALL TEXT(\"KA\")")]
    public const string SDDL_KEY_ALL = "KA";

    [NativeTypeName("#define SDDL_KEY_READ TEXT(\"KR\")")]
    public const string SDDL_KEY_READ = "KR";

    [NativeTypeName("#define SDDL_KEY_WRITE TEXT(\"KW\")")]
    public const string SDDL_KEY_WRITE = "KW";

    [NativeTypeName("#define SDDL_KEY_EXECUTE TEXT(\"KX\")")]
    public const string SDDL_KEY_EXECUTE = "KX";

    [NativeTypeName("#define SDDL_NO_WRITE_UP TEXT(\"NW\")")]
    public const string SDDL_NO_WRITE_UP = "NW";

    [NativeTypeName("#define SDDL_NO_READ_UP TEXT(\"NR\")")]
    public const string SDDL_NO_READ_UP = "NR";

    [NativeTypeName("#define SDDL_NO_EXECUTE_UP TEXT(\"NX\")")]
    public const string SDDL_NO_EXECUTE_UP = "NX";

    [NativeTypeName("#define SDDL_ALIAS_SIZE 2")]
    public const int SDDL_ALIAS_SIZE = 2;

    [NativeTypeName("#define SDDL_DOMAIN_ADMINISTRATORS TEXT(\"DA\")")]
    public const string SDDL_DOMAIN_ADMINISTRATORS = "DA";

    [NativeTypeName("#define SDDL_DOMAIN_GUESTS TEXT(\"DG\")")]
    public const string SDDL_DOMAIN_GUESTS = "DG";

    [NativeTypeName("#define SDDL_DOMAIN_USERS TEXT(\"DU\")")]
    public const string SDDL_DOMAIN_USERS = "DU";

    [NativeTypeName("#define SDDL_ENTERPRISE_DOMAIN_CONTROLLERS TEXT(\"ED\")")]
    public const string SDDL_ENTERPRISE_DOMAIN_CONTROLLERS = "ED";

    [NativeTypeName("#define SDDL_DOMAIN_DOMAIN_CONTROLLERS TEXT(\"DD\")")]
    public const string SDDL_DOMAIN_DOMAIN_CONTROLLERS = "DD";

    [NativeTypeName("#define SDDL_DOMAIN_COMPUTERS TEXT(\"DC\")")]
    public const string SDDL_DOMAIN_COMPUTERS = "DC";

    [NativeTypeName("#define SDDL_BUILTIN_ADMINISTRATORS TEXT(\"BA\")")]
    public const string SDDL_BUILTIN_ADMINISTRATORS = "BA";

    [NativeTypeName("#define SDDL_BUILTIN_GUESTS TEXT(\"BG\")")]
    public const string SDDL_BUILTIN_GUESTS = "BG";

    [NativeTypeName("#define SDDL_BUILTIN_USERS TEXT(\"BU\")")]
    public const string SDDL_BUILTIN_USERS = "BU";

    [NativeTypeName("#define SDDL_LOCAL_ADMIN TEXT(\"LA\")")]
    public const string SDDL_LOCAL_ADMIN = "LA";

    [NativeTypeName("#define SDDL_LOCAL_GUEST TEXT(\"LG\")")]
    public const string SDDL_LOCAL_GUEST = "LG";

    [NativeTypeName("#define SDDL_ACCOUNT_OPERATORS TEXT(\"AO\")")]
    public const string SDDL_ACCOUNT_OPERATORS = "AO";

    [NativeTypeName("#define SDDL_BACKUP_OPERATORS TEXT(\"BO\")")]
    public const string SDDL_BACKUP_OPERATORS = "BO";

    [NativeTypeName("#define SDDL_PRINTER_OPERATORS TEXT(\"PO\")")]
    public const string SDDL_PRINTER_OPERATORS = "PO";

    [NativeTypeName("#define SDDL_SERVER_OPERATORS TEXT(\"SO\")")]
    public const string SDDL_SERVER_OPERATORS = "SO";

    [NativeTypeName("#define SDDL_AUTHENTICATED_USERS TEXT(\"AU\")")]
    public const string SDDL_AUTHENTICATED_USERS = "AU";

    [NativeTypeName("#define SDDL_PERSONAL_SELF TEXT(\"PS\")")]
    public const string SDDL_PERSONAL_SELF = "PS";

    [NativeTypeName("#define SDDL_CREATOR_OWNER TEXT(\"CO\")")]
    public const string SDDL_CREATOR_OWNER = "CO";

    [NativeTypeName("#define SDDL_CREATOR_GROUP TEXT(\"CG\")")]
    public const string SDDL_CREATOR_GROUP = "CG";

    [NativeTypeName("#define SDDL_LOCAL_SYSTEM TEXT(\"SY\")")]
    public const string SDDL_LOCAL_SYSTEM = "SY";

    [NativeTypeName("#define SDDL_POWER_USERS TEXT(\"PU\")")]
    public const string SDDL_POWER_USERS = "PU";

    [NativeTypeName("#define SDDL_EVERYONE TEXT(\"WD\")")]
    public const string SDDL_EVERYONE = "WD";

    [NativeTypeName("#define SDDL_REPLICATOR TEXT(\"RE\")")]
    public const string SDDL_REPLICATOR = "RE";

    [NativeTypeName("#define SDDL_INTERACTIVE TEXT(\"IU\")")]
    public const string SDDL_INTERACTIVE = "IU";

    [NativeTypeName("#define SDDL_NETWORK TEXT(\"NU\")")]
    public const string SDDL_NETWORK = "NU";

    [NativeTypeName("#define SDDL_SERVICE TEXT(\"SU\")")]
    public const string SDDL_SERVICE = "SU";

    [NativeTypeName("#define SDDL_RESTRICTED_CODE TEXT(\"RC\")")]
    public const string SDDL_RESTRICTED_CODE = "RC";

    [NativeTypeName("#define SDDL_WRITE_RESTRICTED_CODE TEXT(\"WR\")")]
    public const string SDDL_WRITE_RESTRICTED_CODE = "WR";

    [NativeTypeName("#define SDDL_ANONYMOUS TEXT(\"AN\")")]
    public const string SDDL_ANONYMOUS = "AN";

    [NativeTypeName("#define SDDL_SCHEMA_ADMINISTRATORS TEXT(\"SA\")")]
    public const string SDDL_SCHEMA_ADMINISTRATORS = "SA";

    [NativeTypeName("#define SDDL_CERT_SERV_ADMINISTRATORS TEXT(\"CA\")")]
    public const string SDDL_CERT_SERV_ADMINISTRATORS = "CA";

    [NativeTypeName("#define SDDL_RAS_SERVERS TEXT(\"RS\")")]
    public const string SDDL_RAS_SERVERS = "RS";

    [NativeTypeName("#define SDDL_ENTERPRISE_ADMINS TEXT(\"EA\")")]
    public const string SDDL_ENTERPRISE_ADMINS = "EA";

    [NativeTypeName("#define SDDL_GROUP_POLICY_ADMINS TEXT(\"PA\")")]
    public const string SDDL_GROUP_POLICY_ADMINS = "PA";

    [NativeTypeName("#define SDDL_ALIAS_PREW2KCOMPACC TEXT(\"RU\")")]
    public const string SDDL_ALIAS_PREW2KCOMPACC = "RU";

    [NativeTypeName("#define SDDL_LOCAL_SERVICE TEXT(\"LS\")")]
    public const string SDDL_LOCAL_SERVICE = "LS";

    [NativeTypeName("#define SDDL_NETWORK_SERVICE TEXT(\"NS\")")]
    public const string SDDL_NETWORK_SERVICE = "NS";

    [NativeTypeName("#define SDDL_REMOTE_DESKTOP TEXT(\"RD\")")]
    public const string SDDL_REMOTE_DESKTOP = "RD";

    [NativeTypeName("#define SDDL_NETWORK_CONFIGURATION_OPS TEXT(\"NO\")")]
    public const string SDDL_NETWORK_CONFIGURATION_OPS = "NO";

    [NativeTypeName("#define SDDL_PERFMON_USERS TEXT(\"MU\")")]
    public const string SDDL_PERFMON_USERS = "MU";

    [NativeTypeName("#define SDDL_PERFLOG_USERS TEXT(\"LU\")")]
    public const string SDDL_PERFLOG_USERS = "LU";

    [NativeTypeName("#define SDDL_IIS_USERS TEXT(\"IS\")")]
    public const string SDDL_IIS_USERS = "IS";

    [NativeTypeName("#define SDDL_CRYPTO_OPERATORS TEXT(\"CY\")")]
    public const string SDDL_CRYPTO_OPERATORS = "CY";

    [NativeTypeName("#define SDDL_OWNER_RIGHTS TEXT(\"OW\")")]
    public const string SDDL_OWNER_RIGHTS = "OW";

    [NativeTypeName("#define SDDL_EVENT_LOG_READERS TEXT(\"ER\")")]
    public const string SDDL_EVENT_LOG_READERS = "ER";

    [NativeTypeName("#define SDDL_ENTERPRISE_RO_DCs TEXT(\"RO\")")]
    public const string SDDL_ENTERPRISE_RO_DCs = "RO";

    [NativeTypeName("#define SDDL_CERTSVC_DCOM_ACCESS TEXT(\"CD\")")]
    public const string SDDL_CERTSVC_DCOM_ACCESS = "CD";

    [NativeTypeName("#define SDDL_ALL_APP_PACKAGES TEXT(\"AC\")")]
    public const string SDDL_ALL_APP_PACKAGES = "AC";

    [NativeTypeName("#define SDDL_RDS_REMOTE_ACCESS_SERVERS TEXT(\"RA\")")]
    public const string SDDL_RDS_REMOTE_ACCESS_SERVERS = "RA";

    [NativeTypeName("#define SDDL_RDS_ENDPOINT_SERVERS TEXT(\"ES\")")]
    public const string SDDL_RDS_ENDPOINT_SERVERS = "ES";

    [NativeTypeName("#define SDDL_RDS_MANAGEMENT_SERVERS TEXT(\"MS\")")]
    public const string SDDL_RDS_MANAGEMENT_SERVERS = "MS";

    [NativeTypeName("#define SDDL_USER_MODE_DRIVERS TEXT(\"UD\")")]
    public const string SDDL_USER_MODE_DRIVERS = "UD";

    [NativeTypeName("#define SDDL_HYPER_V_ADMINS TEXT(\"HA\")")]
    public const string SDDL_HYPER_V_ADMINS = "HA";

    [NativeTypeName("#define SDDL_CLONEABLE_CONTROLLERS TEXT(\"CN\")")]
    public const string SDDL_CLONEABLE_CONTROLLERS = "CN";

    [NativeTypeName("#define SDDL_ACCESS_CONTROL_ASSISTANCE_OPS TEXT(\"AA\")")]
    public const string SDDL_ACCESS_CONTROL_ASSISTANCE_OPS = "AA";

    [NativeTypeName("#define SDDL_REMOTE_MANAGEMENT_USERS TEXT(\"RM\")")]
    public const string SDDL_REMOTE_MANAGEMENT_USERS = "RM";

    [NativeTypeName("#define SDDL_AUTHORITY_ASSERTED TEXT(\"AS\")")]
    public const string SDDL_AUTHORITY_ASSERTED = "AS";

    [NativeTypeName("#define SDDL_SERVICE_ASSERTED TEXT(\"SS\")")]
    public const string SDDL_SERVICE_ASSERTED = "SS";

    [NativeTypeName("#define SDDL_PROTECTED_USERS TEXT(\"AP\")")]
    public const string SDDL_PROTECTED_USERS = "AP";

    [NativeTypeName("#define SDDL_KEY_ADMINS TEXT(\"KA\")")]
    public const string SDDL_KEY_ADMINS = "KA";

    [NativeTypeName("#define SDDL_ENTERPRISE_KEY_ADMINS TEXT(\"EK\")")]
    public const string SDDL_ENTERPRISE_KEY_ADMINS = "EK";

    [NativeTypeName("#define SDDL_ML_LOW TEXT(\"LW\")")]
    public const string SDDL_ML_LOW = "LW";

    [NativeTypeName("#define SDDL_ML_MEDIUM TEXT(\"ME\")")]
    public const string SDDL_ML_MEDIUM = "ME";

    [NativeTypeName("#define SDDL_ML_MEDIUM_PLUS TEXT(\"MP\")")]
    public const string SDDL_ML_MEDIUM_PLUS = "MP";

    [NativeTypeName("#define SDDL_ML_HIGH TEXT(\"HI\")")]
    public const string SDDL_ML_HIGH = "HI";

    [NativeTypeName("#define SDDL_ML_SYSTEM TEXT(\"SI\")")]
    public const string SDDL_ML_SYSTEM = "SI";

    [NativeTypeName("#define SDDL_SEPERATORC TEXT(';')")]
    public const ushort SDDL_SEPERATORC = ';';

    [NativeTypeName("#define SDDL_DELIMINATORC TEXT(':')")]
    public const ushort SDDL_DELIMINATORC = ':';

    [NativeTypeName("#define SDDL_ACE_BEGINC TEXT('(')")]
    public const ushort SDDL_ACE_BEGINC = '(';

    [NativeTypeName("#define SDDL_ACE_ENDC TEXT(')')")]
    public const ushort SDDL_ACE_ENDC = ')';

    [NativeTypeName("#define SDDL_SPACEC TEXT(' ')")]
    public const ushort SDDL_SPACEC = ' ';

    [NativeTypeName("#define SDDL_ACE_COND_BEGINC TEXT('(')")]
    public const ushort SDDL_ACE_COND_BEGINC = '(';

    [NativeTypeName("#define SDDL_ACE_COND_ENDC TEXT(')')")]
    public const ushort SDDL_ACE_COND_ENDC = ')';

    [NativeTypeName("#define SDDL_ACE_COND_STRING_BEGINC TEXT('\"')")]
    public const ushort SDDL_ACE_COND_STRING_BEGINC = '"';

    [NativeTypeName("#define SDDL_ACE_COND_STRING_ENDC TEXT('\"')")]
    public const ushort SDDL_ACE_COND_STRING_ENDC = '"';

    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_BEGINC TEXT('{')")]
    public const ushort SDDL_ACE_COND_COMPOSITEVALUE_BEGINC = '{';

    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_ENDC TEXT('}')")]
    public const ushort SDDL_ACE_COND_COMPOSITEVALUE_ENDC = '}';

    [NativeTypeName("#define SDDL_ACE_COND_COMPOSITEVALUE_SEPERATORC TEXT(',')")]
    public const ushort SDDL_ACE_COND_COMPOSITEVALUE_SEPERATORC = ',';

    [NativeTypeName("#define SDDL_ACE_COND_BLOB_PREFIXC TEXT('#')")]
    public const ushort SDDL_ACE_COND_BLOB_PREFIXC = '#';

    [NativeTypeName("#define SDDL_ACE_COND_SID_BEGINC TEXT('(')")]
    public const ushort SDDL_ACE_COND_SID_BEGINC = '(';

    [NativeTypeName("#define SDDL_ACE_COND_SID_ENDC TEXT(')')")]
    public const ushort SDDL_ACE_COND_SID_ENDC = ')';

    [NativeTypeName("#define SDDL_SEPERATOR TEXT(\";\")")]
    public const string SDDL_SEPERATOR = ";";

    [NativeTypeName("#define SDDL_DELIMINATOR TEXT(\":\")")]
    public const string SDDL_DELIMINATOR = ":";

    [NativeTypeName("#define SDDL_ACE_BEGIN TEXT(\"(\")")]
    public const string SDDL_ACE_BEGIN = "(";

    [NativeTypeName("#define SDDL_ACE_END TEXT(\")\")")]
    public const string SDDL_ACE_END = ")";

    [NativeTypeName("#define SDDL_ACE_COND_BEGIN TEXT(\"(\")")]
    public const string SDDL_ACE_COND_BEGIN = "(";

    [NativeTypeName("#define SDDL_ACE_COND_END TEXT(\")\")")]
    public const string SDDL_ACE_COND_END = ")";

    [NativeTypeName("#define SDDL_SPACE TEXT(\" \")")]
    public const string SDDL_SPACE = " ";

    [NativeTypeName("#define SDDL_ACE_COND_BLOB_PREFIX TEXT(\"#\")")]
    public const string SDDL_ACE_COND_BLOB_PREFIX = "#";

    [NativeTypeName("#define SDDL_ACE_COND_SID_PREFIX TEXT(\"SID\")")]
    public const string SDDL_ACE_COND_SID_PREFIX = "SID";

    [NativeTypeName("#define SDDL_ACE_COND_ATTRIBUTE_PREFIX TEXT(\"@\")")]
    public const string SDDL_ACE_COND_ATTRIBUTE_PREFIX = "@";

    [NativeTypeName("#define SDDL_ACE_COND_USER_ATTRIBUTE_PREFIX TEXT(\"@USER.\")")]
    public const string SDDL_ACE_COND_USER_ATTRIBUTE_PREFIX = "@USER.";

    [NativeTypeName("#define SDDL_ACE_COND_RESOURCE_ATTRIBUTE_PREFIX TEXT(\"@RESOURCE.\")")]
    public const string SDDL_ACE_COND_RESOURCE_ATTRIBUTE_PREFIX = "@RESOURCE.";

    [NativeTypeName("#define SDDL_ACE_COND_DEVICE_ATTRIBUTE_PREFIX TEXT(\"@DEVICE.\")")]
    public const string SDDL_ACE_COND_DEVICE_ATTRIBUTE_PREFIX = "@DEVICE.";

    [NativeTypeName("#define SDDL_ACE_COND_TOKEN_ATTRIBUTE_PREFIX TEXT(\"@TOKEN.\")")]
    public const string SDDL_ACE_COND_TOKEN_ATTRIBUTE_PREFIX = "@TOKEN.";
}
