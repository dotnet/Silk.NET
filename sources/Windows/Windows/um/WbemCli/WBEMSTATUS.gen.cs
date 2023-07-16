// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS"]/*'/>
public enum WBEMSTATUS
{
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_NO_ERROR"]/*'/>
    WBEM_NO_ERROR = 0,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_NO_ERROR"]/*'/>
    WBEM_S_NO_ERROR = 0,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_SAME"]/*'/>
    WBEM_S_SAME = 0,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_FALSE"]/*'/>
    WBEM_S_FALSE = 1,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_ALREADY_EXISTS"]/*'/>
    WBEM_S_ALREADY_EXISTS = 0x40001,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_RESET_TO_DEFAULT"]/*'/>
    WBEM_S_RESET_TO_DEFAULT = 0x40002,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_DIFFERENT"]/*'/>
    WBEM_S_DIFFERENT = 0x40003,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_TIMEDOUT"]/*'/>
    WBEM_S_TIMEDOUT = 0x40004,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_NO_MORE_DATA"]/*'/>
    WBEM_S_NO_MORE_DATA = 0x40005,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_OPERATION_CANCELLED"]/*'/>
    WBEM_S_OPERATION_CANCELLED = 0x40006,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_PENDING"]/*'/>
    WBEM_S_PENDING = 0x40007,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_DUPLICATE_OBJECTS"]/*'/>
    WBEM_S_DUPLICATE_OBJECTS = 0x40008,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_ACCESS_DENIED"]/*'/>
    WBEM_S_ACCESS_DENIED = 0x40009,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_PARTIAL_RESULTS"]/*'/>
    WBEM_S_PARTIAL_RESULTS = 0x40010,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_S_SOURCE_NOT_AVAILABLE"]/*'/>
    WBEM_S_SOURCE_NOT_AVAILABLE = 0x40017,
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_FAILED"]/*'/>
    WBEM_E_FAILED = unchecked((int)(0x80041001)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NOT_FOUND"]/*'/>
    WBEM_E_NOT_FOUND = unchecked((int)(0x80041002)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_ACCESS_DENIED"]/*'/>
    WBEM_E_ACCESS_DENIED = unchecked((int)(0x80041003)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_FAILURE"]/*'/>
    WBEM_E_PROVIDER_FAILURE = unchecked((int)(0x80041004)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_TYPE_MISMATCH"]/*'/>
    WBEM_E_TYPE_MISMATCH = unchecked((int)(0x80041005)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_OUT_OF_MEMORY"]/*'/>
    WBEM_E_OUT_OF_MEMORY = unchecked((int)(0x80041006)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_CONTEXT"]/*'/>
    WBEM_E_INVALID_CONTEXT = unchecked((int)(0x80041007)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_PARAMETER"]/*'/>
    WBEM_E_INVALID_PARAMETER = unchecked((int)(0x80041008)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NOT_AVAILABLE"]/*'/>
    WBEM_E_NOT_AVAILABLE = unchecked((int)(0x80041009)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CRITICAL_ERROR"]/*'/>
    WBEM_E_CRITICAL_ERROR = unchecked((int)(0x8004100a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_STREAM"]/*'/>
    WBEM_E_INVALID_STREAM = unchecked((int)(0x8004100b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NOT_SUPPORTED"]/*'/>
    WBEM_E_NOT_SUPPORTED = unchecked((int)(0x8004100c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_SUPERCLASS"]/*'/>
    WBEM_E_INVALID_SUPERCLASS = unchecked((int)(0x8004100d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_NAMESPACE"]/*'/>
    WBEM_E_INVALID_NAMESPACE = unchecked((int)(0x8004100e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_OBJECT"]/*'/>
    WBEM_E_INVALID_OBJECT = unchecked((int)(0x8004100f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_CLASS"]/*'/>
    WBEM_E_INVALID_CLASS = unchecked((int)(0x80041010)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_NOT_FOUND"]/*'/>
    WBEM_E_PROVIDER_NOT_FOUND = unchecked((int)(0x80041011)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_PROVIDER_REGISTRATION"]/*'/>
    WBEM_E_INVALID_PROVIDER_REGISTRATION = unchecked((int)(0x80041012)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_LOAD_FAILURE"]/*'/>
    WBEM_E_PROVIDER_LOAD_FAILURE = unchecked((int)(0x80041013)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INITIALIZATION_FAILURE"]/*'/>
    WBEM_E_INITIALIZATION_FAILURE = unchecked((int)(0x80041014)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_TRANSPORT_FAILURE"]/*'/>
    WBEM_E_TRANSPORT_FAILURE = unchecked((int)(0x80041015)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_OPERATION"]/*'/>
    WBEM_E_INVALID_OPERATION = unchecked((int)(0x80041016)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_QUERY"]/*'/>
    WBEM_E_INVALID_QUERY = unchecked((int)(0x80041017)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_QUERY_TYPE"]/*'/>
    WBEM_E_INVALID_QUERY_TYPE = unchecked((int)(0x80041018)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_ALREADY_EXISTS"]/*'/>
    WBEM_E_ALREADY_EXISTS = unchecked((int)(0x80041019)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_OVERRIDE_NOT_ALLOWED"]/*'/>
    WBEM_E_OVERRIDE_NOT_ALLOWED = unchecked((int)(0x8004101a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROPAGATED_QUALIFIER"]/*'/>
    WBEM_E_PROPAGATED_QUALIFIER = unchecked((int)(0x8004101b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROPAGATED_PROPERTY"]/*'/>
    WBEM_E_PROPAGATED_PROPERTY = unchecked((int)(0x8004101c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNEXPECTED"]/*'/>
    WBEM_E_UNEXPECTED = unchecked((int)(0x8004101d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_ILLEGAL_OPERATION"]/*'/>
    WBEM_E_ILLEGAL_OPERATION = unchecked((int)(0x8004101e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CANNOT_BE_KEY"]/*'/>
    WBEM_E_CANNOT_BE_KEY = unchecked((int)(0x8004101f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INCOMPLETE_CLASS"]/*'/>
    WBEM_E_INCOMPLETE_CLASS = unchecked((int)(0x80041020)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_SYNTAX"]/*'/>
    WBEM_E_INVALID_SYNTAX = unchecked((int)(0x80041021)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NONDECORATED_OBJECT"]/*'/>
    WBEM_E_NONDECORATED_OBJECT = unchecked((int)(0x80041022)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_READ_ONLY"]/*'/>
    WBEM_E_READ_ONLY = unchecked((int)(0x80041023)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_NOT_CAPABLE"]/*'/>
    WBEM_E_PROVIDER_NOT_CAPABLE = unchecked((int)(0x80041024)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CLASS_HAS_CHILDREN"]/*'/>
    WBEM_E_CLASS_HAS_CHILDREN = unchecked((int)(0x80041025)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CLASS_HAS_INSTANCES"]/*'/>
    WBEM_E_CLASS_HAS_INSTANCES = unchecked((int)(0x80041026)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_QUERY_NOT_IMPLEMENTED"]/*'/>
    WBEM_E_QUERY_NOT_IMPLEMENTED = unchecked((int)(0x80041027)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_ILLEGAL_NULL"]/*'/>
    WBEM_E_ILLEGAL_NULL = unchecked((int)(0x80041028)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_QUALIFIER_TYPE"]/*'/>
    WBEM_E_INVALID_QUALIFIER_TYPE = unchecked((int)(0x80041029)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_PROPERTY_TYPE"]/*'/>
    WBEM_E_INVALID_PROPERTY_TYPE = unchecked((int)(0x8004102a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_VALUE_OUT_OF_RANGE"]/*'/>
    WBEM_E_VALUE_OUT_OF_RANGE = unchecked((int)(0x8004102b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CANNOT_BE_SINGLETON"]/*'/>
    WBEM_E_CANNOT_BE_SINGLETON = unchecked((int)(0x8004102c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_CIM_TYPE"]/*'/>
    WBEM_E_INVALID_CIM_TYPE = unchecked((int)(0x8004102d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_METHOD"]/*'/>
    WBEM_E_INVALID_METHOD = unchecked((int)(0x8004102e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_METHOD_PARAMETERS"]/*'/>
    WBEM_E_INVALID_METHOD_PARAMETERS = unchecked((int)(0x8004102f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_SYSTEM_PROPERTY"]/*'/>
    WBEM_E_SYSTEM_PROPERTY = unchecked((int)(0x80041030)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_PROPERTY"]/*'/>
    WBEM_E_INVALID_PROPERTY = unchecked((int)(0x80041031)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CALL_CANCELLED"]/*'/>
    WBEM_E_CALL_CANCELLED = unchecked((int)(0x80041032)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_SHUTTING_DOWN"]/*'/>
    WBEM_E_SHUTTING_DOWN = unchecked((int)(0x80041033)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROPAGATED_METHOD"]/*'/>
    WBEM_E_PROPAGATED_METHOD = unchecked((int)(0x80041034)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNSUPPORTED_PARAMETER"]/*'/>
    WBEM_E_UNSUPPORTED_PARAMETER = unchecked((int)(0x80041035)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_MISSING_PARAMETER_ID"]/*'/>
    WBEM_E_MISSING_PARAMETER_ID = unchecked((int)(0x80041036)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_PARAMETER_ID"]/*'/>
    WBEM_E_INVALID_PARAMETER_ID = unchecked((int)(0x80041037)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NONCONSECUTIVE_PARAMETER_IDS"]/*'/>
    WBEM_E_NONCONSECUTIVE_PARAMETER_IDS = unchecked((int)(0x80041038)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PARAMETER_ID_ON_RETVAL"]/*'/>
    WBEM_E_PARAMETER_ID_ON_RETVAL = unchecked((int)(0x80041039)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_OBJECT_PATH"]/*'/>
    WBEM_E_INVALID_OBJECT_PATH = unchecked((int)(0x8004103a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_OUT_OF_DISK_SPACE"]/*'/>
    WBEM_E_OUT_OF_DISK_SPACE = unchecked((int)(0x8004103b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_BUFFER_TOO_SMALL"]/*'/>
    WBEM_E_BUFFER_TOO_SMALL = unchecked((int)(0x8004103c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNSUPPORTED_PUT_EXTENSION"]/*'/>
    WBEM_E_UNSUPPORTED_PUT_EXTENSION = unchecked((int)(0x8004103d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNKNOWN_OBJECT_TYPE"]/*'/>
    WBEM_E_UNKNOWN_OBJECT_TYPE = unchecked((int)(0x8004103e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNKNOWN_PACKET_TYPE"]/*'/>
    WBEM_E_UNKNOWN_PACKET_TYPE = unchecked((int)(0x8004103f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_MARSHAL_VERSION_MISMATCH"]/*'/>
    WBEM_E_MARSHAL_VERSION_MISMATCH = unchecked((int)(0x80041040)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_MARSHAL_INVALID_SIGNATURE"]/*'/>
    WBEM_E_MARSHAL_INVALID_SIGNATURE = unchecked((int)(0x80041041)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_QUALIFIER"]/*'/>
    WBEM_E_INVALID_QUALIFIER = unchecked((int)(0x80041042)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_DUPLICATE_PARAMETER"]/*'/>
    WBEM_E_INVALID_DUPLICATE_PARAMETER = unchecked((int)(0x80041043)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_TOO_MUCH_DATA"]/*'/>
    WBEM_E_TOO_MUCH_DATA = unchecked((int)(0x80041044)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_SERVER_TOO_BUSY"]/*'/>
    WBEM_E_SERVER_TOO_BUSY = unchecked((int)(0x80041045)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_FLAVOR"]/*'/>
    WBEM_E_INVALID_FLAVOR = unchecked((int)(0x80041046)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CIRCULAR_REFERENCE"]/*'/>
    WBEM_E_CIRCULAR_REFERENCE = unchecked((int)(0x80041047)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNSUPPORTED_CLASS_UPDATE"]/*'/>
    WBEM_E_UNSUPPORTED_CLASS_UPDATE = unchecked((int)(0x80041048)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CANNOT_CHANGE_KEY_INHERITANCE"]/*'/>
    WBEM_E_CANNOT_CHANGE_KEY_INHERITANCE = unchecked((int)(0x80041049)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CANNOT_CHANGE_INDEX_INHERITANCE"]/*'/>
    WBEM_E_CANNOT_CHANGE_INDEX_INHERITANCE = unchecked((int)(0x80041050)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_TOO_MANY_PROPERTIES"]/*'/>
    WBEM_E_TOO_MANY_PROPERTIES = unchecked((int)(0x80041051)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UPDATE_TYPE_MISMATCH"]/*'/>
    WBEM_E_UPDATE_TYPE_MISMATCH = unchecked((int)(0x80041052)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UPDATE_OVERRIDE_NOT_ALLOWED"]/*'/>
    WBEM_E_UPDATE_OVERRIDE_NOT_ALLOWED = unchecked((int)(0x80041053)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UPDATE_PROPAGATED_METHOD"]/*'/>
    WBEM_E_UPDATE_PROPAGATED_METHOD = unchecked((int)(0x80041054)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_METHOD_NOT_IMPLEMENTED"]/*'/>
    WBEM_E_METHOD_NOT_IMPLEMENTED = unchecked((int)(0x80041055)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_METHOD_DISABLED"]/*'/>
    WBEM_E_METHOD_DISABLED = unchecked((int)(0x80041056)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_REFRESHER_BUSY"]/*'/>
    WBEM_E_REFRESHER_BUSY = unchecked((int)(0x80041057)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNPARSABLE_QUERY"]/*'/>
    WBEM_E_UNPARSABLE_QUERY = unchecked((int)(0x80041058)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NOT_EVENT_CLASS"]/*'/>
    WBEM_E_NOT_EVENT_CLASS = unchecked((int)(0x80041059)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_MISSING_GROUP_WITHIN"]/*'/>
    WBEM_E_MISSING_GROUP_WITHIN = unchecked((int)(0x8004105a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_MISSING_AGGREGATION_LIST"]/*'/>
    WBEM_E_MISSING_AGGREGATION_LIST = unchecked((int)(0x8004105b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROPERTY_NOT_AN_OBJECT"]/*'/>
    WBEM_E_PROPERTY_NOT_AN_OBJECT = unchecked((int)(0x8004105c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_AGGREGATING_BY_OBJECT"]/*'/>
    WBEM_E_AGGREGATING_BY_OBJECT = unchecked((int)(0x8004105d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNINTERPRETABLE_PROVIDER_QUERY"]/*'/>
    WBEM_E_UNINTERPRETABLE_PROVIDER_QUERY = unchecked((int)(0x8004105f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_BACKUP_RESTORE_WINMGMT_RUNNING"]/*'/>
    WBEM_E_BACKUP_RESTORE_WINMGMT_RUNNING = unchecked((int)(0x80041060)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_QUEUE_OVERFLOW"]/*'/>
    WBEM_E_QUEUE_OVERFLOW = unchecked((int)(0x80041061)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PRIVILEGE_NOT_HELD"]/*'/>
    WBEM_E_PRIVILEGE_NOT_HELD = unchecked((int)(0x80041062)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_OPERATOR"]/*'/>
    WBEM_E_INVALID_OPERATOR = unchecked((int)(0x80041063)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_LOCAL_CREDENTIALS"]/*'/>
    WBEM_E_LOCAL_CREDENTIALS = unchecked((int)(0x80041064)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CANNOT_BE_ABSTRACT"]/*'/>
    WBEM_E_CANNOT_BE_ABSTRACT = unchecked((int)(0x80041065)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_AMENDED_OBJECT"]/*'/>
    WBEM_E_AMENDED_OBJECT = unchecked((int)(0x80041066)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CLIENT_TOO_SLOW"]/*'/>
    WBEM_E_CLIENT_TOO_SLOW = unchecked((int)(0x80041067)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NULL_SECURITY_DESCRIPTOR"]/*'/>
    WBEM_E_NULL_SECURITY_DESCRIPTOR = unchecked((int)(0x80041068)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_TIMED_OUT"]/*'/>
    WBEM_E_TIMED_OUT = unchecked((int)(0x80041069)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_ASSOCIATION"]/*'/>
    WBEM_E_INVALID_ASSOCIATION = unchecked((int)(0x8004106a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_AMBIGUOUS_OPERATION"]/*'/>
    WBEM_E_AMBIGUOUS_OPERATION = unchecked((int)(0x8004106b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_QUOTA_VIOLATION"]/*'/>
    WBEM_E_QUOTA_VIOLATION = unchecked((int)(0x8004106c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_RESERVED_001"]/*'/>
    WBEM_E_RESERVED_001 = unchecked((int)(0x8004106d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_RESERVED_002"]/*'/>
    WBEM_E_RESERVED_002 = unchecked((int)(0x8004106e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_UNSUPPORTED_LOCALE"]/*'/>
    WBEM_E_UNSUPPORTED_LOCALE = unchecked((int)(0x8004106f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_HANDLE_OUT_OF_DATE"]/*'/>
    WBEM_E_HANDLE_OUT_OF_DATE = unchecked((int)(0x80041070)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CONNECTION_FAILED"]/*'/>
    WBEM_E_CONNECTION_FAILED = unchecked((int)(0x80041071)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_HANDLE_REQUEST"]/*'/>
    WBEM_E_INVALID_HANDLE_REQUEST = unchecked((int)(0x80041072)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROPERTY_NAME_TOO_WIDE"]/*'/>
    WBEM_E_PROPERTY_NAME_TOO_WIDE = unchecked((int)(0x80041073)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_CLASS_NAME_TOO_WIDE"]/*'/>
    WBEM_E_CLASS_NAME_TOO_WIDE = unchecked((int)(0x80041074)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_METHOD_NAME_TOO_WIDE"]/*'/>
    WBEM_E_METHOD_NAME_TOO_WIDE = unchecked((int)(0x80041075)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_QUALIFIER_NAME_TOO_WIDE"]/*'/>
    WBEM_E_QUALIFIER_NAME_TOO_WIDE = unchecked((int)(0x80041076)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_RERUN_COMMAND"]/*'/>
    WBEM_E_RERUN_COMMAND = unchecked((int)(0x80041077)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_DATABASE_VER_MISMATCH"]/*'/>
    WBEM_E_DATABASE_VER_MISMATCH = unchecked((int)(0x80041078)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_VETO_DELETE"]/*'/>
    WBEM_E_VETO_DELETE = unchecked((int)(0x80041079)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_VETO_PUT"]/*'/>
    WBEM_E_VETO_PUT = unchecked((int)(0x8004107a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_INVALID_LOCALE"]/*'/>
    WBEM_E_INVALID_LOCALE = unchecked((int)(0x80041080)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_SUSPENDED"]/*'/>
    WBEM_E_PROVIDER_SUSPENDED = unchecked((int)(0x80041081)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_SYNCHRONIZATION_REQUIRED"]/*'/>
    WBEM_E_SYNCHRONIZATION_REQUIRED = unchecked((int)(0x80041082)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NO_SCHEMA"]/*'/>
    WBEM_E_NO_SCHEMA = unchecked((int)(0x80041083)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_ALREADY_REGISTERED"]/*'/>
    WBEM_E_PROVIDER_ALREADY_REGISTERED = unchecked((int)(0x80041084)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_NOT_REGISTERED"]/*'/>
    WBEM_E_PROVIDER_NOT_REGISTERED = unchecked((int)(0x80041085)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_FATAL_TRANSPORT_ERROR"]/*'/>
    WBEM_E_FATAL_TRANSPORT_ERROR = unchecked((int)(0x80041086)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_ENCRYPTED_CONNECTION_REQUIRED"]/*'/>
    WBEM_E_ENCRYPTED_CONNECTION_REQUIRED = unchecked((int)(0x80041087)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_TIMED_OUT"]/*'/>
    WBEM_E_PROVIDER_TIMED_OUT = unchecked((int)(0x80041088)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_NO_KEY"]/*'/>
    WBEM_E_NO_KEY = unchecked((int)(0x80041089)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEM_E_PROVIDER_DISABLED"]/*'/>
    WBEM_E_PROVIDER_DISABLED = unchecked((int)(0x8004108a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMESS_E_REGISTRATION_TOO_BROAD"]/*'/>
    WBEMESS_E_REGISTRATION_TOO_BROAD = unchecked((int)(0x80042001)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMESS_E_REGISTRATION_TOO_PRECISE"]/*'/>
    WBEMESS_E_REGISTRATION_TOO_PRECISE = unchecked((int)(0x80042002)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMESS_E_AUTHZ_NOT_PRIVILEGED"]/*'/>
    WBEMESS_E_AUTHZ_NOT_PRIVILEGED = unchecked((int)(0x80042003)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_QUALIFIER_NAME"]/*'/>
    WBEMMOF_E_EXPECTED_QUALIFIER_NAME = unchecked((int)(0x80044001)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_SEMI"]/*'/>
    WBEMMOF_E_EXPECTED_SEMI = unchecked((int)(0x80044002)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_OPEN_BRACE"]/*'/>
    WBEMMOF_E_EXPECTED_OPEN_BRACE = unchecked((int)(0x80044003)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_CLOSE_BRACE"]/*'/>
    WBEMMOF_E_EXPECTED_CLOSE_BRACE = unchecked((int)(0x80044004)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_CLOSE_BRACKET"]/*'/>
    WBEMMOF_E_EXPECTED_CLOSE_BRACKET = unchecked((int)(0x80044005)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_CLOSE_PAREN"]/*'/>
    WBEMMOF_E_EXPECTED_CLOSE_PAREN = unchecked((int)(0x80044006)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_ILLEGAL_CONSTANT_VALUE"]/*'/>
    WBEMMOF_E_ILLEGAL_CONSTANT_VALUE = unchecked((int)(0x80044007)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_TYPE_IDENTIFIER"]/*'/>
    WBEMMOF_E_EXPECTED_TYPE_IDENTIFIER = unchecked((int)(0x80044008)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_OPEN_PAREN"]/*'/>
    WBEMMOF_E_EXPECTED_OPEN_PAREN = unchecked((int)(0x80044009)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNRECOGNIZED_TOKEN"]/*'/>
    WBEMMOF_E_UNRECOGNIZED_TOKEN = unchecked((int)(0x8004400a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNRECOGNIZED_TYPE"]/*'/>
    WBEMMOF_E_UNRECOGNIZED_TYPE = unchecked((int)(0x8004400b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_PROPERTY_NAME"]/*'/>
    WBEMMOF_E_EXPECTED_PROPERTY_NAME = unchecked((int)(0x8004400c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_TYPEDEF_NOT_SUPPORTED"]/*'/>
    WBEMMOF_E_TYPEDEF_NOT_SUPPORTED = unchecked((int)(0x8004400d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNEXPECTED_ALIAS"]/*'/>
    WBEMMOF_E_UNEXPECTED_ALIAS = unchecked((int)(0x8004400e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNEXPECTED_ARRAY_INIT"]/*'/>
    WBEMMOF_E_UNEXPECTED_ARRAY_INIT = unchecked((int)(0x8004400f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_AMENDMENT_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_AMENDMENT_SYNTAX = unchecked((int)(0x80044010)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_DUPLICATE_AMENDMENT"]/*'/>
    WBEMMOF_E_INVALID_DUPLICATE_AMENDMENT = unchecked((int)(0x80044011)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_PRAGMA"]/*'/>
    WBEMMOF_E_INVALID_PRAGMA = unchecked((int)(0x80044012)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_NAMESPACE_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_NAMESPACE_SYNTAX = unchecked((int)(0x80044013)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_CLASS_NAME"]/*'/>
    WBEMMOF_E_EXPECTED_CLASS_NAME = unchecked((int)(0x80044014)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_TYPE_MISMATCH"]/*'/>
    WBEMMOF_E_TYPE_MISMATCH = unchecked((int)(0x80044015)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_ALIAS_NAME"]/*'/>
    WBEMMOF_E_EXPECTED_ALIAS_NAME = unchecked((int)(0x80044016)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_CLASS_DECLARATION"]/*'/>
    WBEMMOF_E_INVALID_CLASS_DECLARATION = unchecked((int)(0x80044017)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_INSTANCE_DECLARATION"]/*'/>
    WBEMMOF_E_INVALID_INSTANCE_DECLARATION = unchecked((int)(0x80044018)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_DOLLAR"]/*'/>
    WBEMMOF_E_EXPECTED_DOLLAR = unchecked((int)(0x80044019)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_CIMTYPE_QUALIFIER"]/*'/>
    WBEMMOF_E_CIMTYPE_QUALIFIER = unchecked((int)(0x8004401a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_DUPLICATE_PROPERTY"]/*'/>
    WBEMMOF_E_DUPLICATE_PROPERTY = unchecked((int)(0x8004401b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_NAMESPACE_SPECIFICATION"]/*'/>
    WBEMMOF_E_INVALID_NAMESPACE_SPECIFICATION = unchecked((int)(0x8004401c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_OUT_OF_RANGE"]/*'/>
    WBEMMOF_E_OUT_OF_RANGE = unchecked((int)(0x8004401d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_FILE"]/*'/>
    WBEMMOF_E_INVALID_FILE = unchecked((int)(0x8004401e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_ALIASES_IN_EMBEDDED"]/*'/>
    WBEMMOF_E_ALIASES_IN_EMBEDDED = unchecked((int)(0x8004401f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_NULL_ARRAY_ELEM"]/*'/>
    WBEMMOF_E_NULL_ARRAY_ELEM = unchecked((int)(0x80044020)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_DUPLICATE_QUALIFIER"]/*'/>
    WBEMMOF_E_DUPLICATE_QUALIFIER = unchecked((int)(0x80044021)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_FLAVOR_TYPE"]/*'/>
    WBEMMOF_E_EXPECTED_FLAVOR_TYPE = unchecked((int)(0x80044022)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES"]/*'/>
    WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES = unchecked((int)(0x80044023)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_MULTIPLE_ALIASES"]/*'/>
    WBEMMOF_E_MULTIPLE_ALIASES = unchecked((int)(0x80044024)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES2"]/*'/>
    WBEMMOF_E_INCOMPATIBLE_FLAVOR_TYPES2 = unchecked((int)(0x80044025)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_NO_ARRAYS_RETURNED"]/*'/>
    WBEMMOF_E_NO_ARRAYS_RETURNED = unchecked((int)(0x80044026)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_MUST_BE_IN_OR_OUT"]/*'/>
    WBEMMOF_E_MUST_BE_IN_OR_OUT = unchecked((int)(0x80044027)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_FLAGS_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_FLAGS_SYNTAX = unchecked((int)(0x80044028)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_EXPECTED_BRACE_OR_BAD_TYPE"]/*'/>
    WBEMMOF_E_EXPECTED_BRACE_OR_BAD_TYPE = unchecked((int)(0x80044029)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNSUPPORTED_CIMV22_QUAL_VALUE"]/*'/>
    WBEMMOF_E_UNSUPPORTED_CIMV22_QUAL_VALUE = unchecked((int)(0x8004402a)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_UNSUPPORTED_CIMV22_DATA_TYPE"]/*'/>
    WBEMMOF_E_UNSUPPORTED_CIMV22_DATA_TYPE = unchecked((int)(0x8004402b)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_DELETEINSTANCE_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_DELETEINSTANCE_SYNTAX = unchecked((int)(0x8004402c)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_QUALIFIER_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_QUALIFIER_SYNTAX = unchecked((int)(0x8004402d)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_QUALIFIER_USED_OUTSIDE_SCOPE"]/*'/>
    WBEMMOF_E_QUALIFIER_USED_OUTSIDE_SCOPE = unchecked((int)(0x8004402e)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_ERROR_CREATING_TEMP_FILE"]/*'/>
    WBEMMOF_E_ERROR_CREATING_TEMP_FILE = unchecked((int)(0x8004402f)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_ERROR_INVALID_INCLUDE_FILE"]/*'/>
    WBEMMOF_E_ERROR_INVALID_INCLUDE_FILE = unchecked((int)(0x80044030)),
    /// <include file='WBEMSTATUS.xml' path='doc/member[@name="WBEMSTATUS.WBEMMOF_E_INVALID_DELETECLASS_SYNTAX"]/*'/>
    WBEMMOF_E_INVALID_DELETECLASS_SYNTAX = unchecked((int)(0x80044031)),
}