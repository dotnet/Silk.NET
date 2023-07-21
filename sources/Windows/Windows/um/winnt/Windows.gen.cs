// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("const GUID")]
    public static ref readonly Guid NO_SUBGROUP_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x3E, 0x41, 0xA3, 0xFE,
                0x05, 0x7E,
                0x11, 0x49,
                0x9A,
                0x71,
                0x70,
                0x03,
                0x31,
                0xF1,
                0xC2,
                0x94
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const GUID")]
    public static ref readonly Guid ALL_POWERSCHEMES_GUID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x5E, 0xE9, 0xA1, 0x68,
                0xEA, 0x13,
                0xE1, 0x41,
                0x80,
                0x11,
                0x0C,
                0x49,
                0x6C,
                0xA4,
                0x90,
                0xB0
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("#define ANYSIZE_ARRAY 1")]
    public const int ANYSIZE_ARRAY = 1;

    [NativeTypeName("#define X86_CACHE_ALIGNMENT_SIZE 64")]
    public const int X86_CACHE_ALIGNMENT_SIZE = 64;

    [NativeTypeName("#define ARM_CACHE_ALIGNMENT_SIZE 128")]
    public const int ARM_CACHE_ALIGNMENT_SIZE = 128;

    [NativeTypeName("#define PRAGMA_DEPRECATED_DDK 0")]
    public const int PRAGMA_DEPRECATED_DDK = 0;

    [NativeTypeName("#define UCSCHAR_INVALID_CHARACTER (0xffffffff)")]
    public const uint UCSCHAR_INVALID_CHARACTER = (0xffffffff);

    [NativeTypeName("#define MIN_UCSCHAR (0)")]
    public const int MIN_UCSCHAR = (0);

    [NativeTypeName("#define ALL_PROCESSOR_GROUPS 0xffff")]
    public const int ALL_PROCESSOR_GROUPS = 0xffff;

    [NativeTypeName("#define APPLICATION_ERROR_MASK 0x20000000")]
    public const int APPLICATION_ERROR_MASK = 0x20000000;

    [NativeTypeName("#define MAXLONGLONG (0x7fffffffffffffff)")]
    public const long MAXLONGLONG = (0x7fffffffffffffff);

    [NativeTypeName("#define ANSI_NULL ((CHAR)0)")]
    public const sbyte ANSI_NULL = ((sbyte)(0));

    [NativeTypeName("#define UNICODE_NULL ((WCHAR)0)")]
    public const ushort UNICODE_NULL = ((ushort)(0));

    [NativeTypeName("#define UNICODE_STRING_MAX_BYTES ((WORD  ) 65534)")]
    public const ushort UNICODE_STRING_MAX_BYTES = ((ushort)(65534));

    [NativeTypeName("#define UNICODE_STRING_MAX_CHARS (32767)")]
    public const int UNICODE_STRING_MAX_CHARS = (32767);

    [NativeTypeName("#define MINCHAR 0x80")]
    public const int MINCHAR = 0x80;

    [NativeTypeName("#define MAXCHAR 0x7f")]
    public const int MAXCHAR = 0x7f;

    [NativeTypeName("#define MINSHORT 0x8000")]
    public const int MINSHORT = 0x8000;

    [NativeTypeName("#define MAXSHORT 0x7fff")]
    public const int MAXSHORT = 0x7fff;

    [NativeTypeName("#define MINLONG 0x80000000")]
    public const uint MINLONG = 0x80000000;

    [NativeTypeName("#define MAXLONG 0x7fffffff")]
    public const int MAXLONG = 0x7fffffff;

    [NativeTypeName("#define MAXBYTE 0xff")]
    public const int MAXBYTE = 0xff;

    [NativeTypeName("#define MAXWORD 0xffff")]
    public const int MAXWORD = 0xffff;

    [NativeTypeName("#define MAXDWORD 0xffffffff")]
    public const uint MAXDWORD = 0xffffffff;

    [NativeTypeName("#define ENCLAVE_SHORT_ID_LENGTH 16")]
    public const int ENCLAVE_SHORT_ID_LENGTH = 16;

    [NativeTypeName("#define ENCLAVE_LONG_ID_LENGTH 32")]
    public const int ENCLAVE_LONG_ID_LENGTH = 32;

    [NativeTypeName("#define NLS_VALID_LOCALE_MASK 0x000fffff")]
    public const int NLS_VALID_LOCALE_MASK = 0x000fffff;

    [NativeTypeName("#define _MM_HINT_T0 1")]
    public const int _MM_HINT_T0 = 1;

    [NativeTypeName("#define _MM_HINT_T1 2")]
    public const int _MM_HINT_T1 = 2;

    [NativeTypeName("#define _MM_HINT_T2 3")]
    public const int _MM_HINT_T2 = 3;

    [NativeTypeName("#define _MM_HINT_NTA 0")]
    public const int _MM_HINT_NTA = 0;

    [NativeTypeName("#define DELETE (0x00010000L)")]
    public const int DELETE = (0x00010000);

    [NativeTypeName("#define WRITE_DAC (0x00040000L)")]
    public const int WRITE_DAC = (0x00040000);

    [NativeTypeName("#define WRITE_OWNER (0x00080000L)")]
    public const int WRITE_OWNER = (0x00080000);

    [NativeTypeName("#define SYNCHRONIZE (0x00100000L)")]
    public const int SYNCHRONIZE = (0x00100000);

    [NativeTypeName("#define STANDARD_RIGHTS_REQUIRED (0x000F0000L)")]
    public const int STANDARD_RIGHTS_REQUIRED = (0x000F0000);

    [NativeTypeName("#define STANDARD_RIGHTS_READ (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_READ = ((0x00020000));

    [NativeTypeName("#define STANDARD_RIGHTS_WRITE (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_WRITE = ((0x00020000));

    [NativeTypeName("#define STANDARD_RIGHTS_EXECUTE (READ_CONTROL)")]
    public const int STANDARD_RIGHTS_EXECUTE = ((0x00020000));

    [NativeTypeName("#define STANDARD_RIGHTS_ALL (0x001F0000L)")]
    public const int STANDARD_RIGHTS_ALL = (0x001F0000);

    [NativeTypeName("#define SPECIFIC_RIGHTS_ALL (0x0000FFFFL)")]
    public const int SPECIFIC_RIGHTS_ALL = (0x0000FFFF);

    [NativeTypeName("#define GENERIC_READ (0x80000000L)")]
    public const uint GENERIC_READ = (0x80000000);

    [NativeTypeName("#define GENERIC_WRITE (0x40000000L)")]
    public const int GENERIC_WRITE = (0x40000000);

    [NativeTypeName("#define GENERIC_EXECUTE (0x20000000L)")]
    public const int GENERIC_EXECUTE = (0x20000000);

    [NativeTypeName("#define GENERIC_ALL (0x10000000L)")]
    public const int GENERIC_ALL = (0x10000000);

    [NativeTypeName("#define FOREST_USER_RID_MAX (0x000001F3L)")]
    public const int FOREST_USER_RID_MAX = (0x000001F3);

    [NativeTypeName("#define ACL_REVISION (2)")]
    public const int ACL_REVISION = (2);

    [NativeTypeName("#define ACL_REVISION_DS (4)")]
    public const int ACL_REVISION_DS = (4);

    [NativeTypeName("#define ACL_REVISION1 (1)")]
    public const int ACL_REVISION1 = (1);

    [NativeTypeName("#define MIN_ACL_REVISION ACL_REVISION2")]
    public const int MIN_ACL_REVISION = (2);

    [NativeTypeName("#define ACL_REVISION2 (2)")]
    public const int ACL_REVISION2 = (2);

    [NativeTypeName("#define ACL_REVISION3 (3)")]
    public const int ACL_REVISION3 = (3);

    [NativeTypeName("#define ACL_REVISION4 (4)")]
    public const int ACL_REVISION4 = (4);

    [NativeTypeName("#define OBJECT_INHERIT_ACE (0x1)")]
    public const int OBJECT_INHERIT_ACE = (0x1);

    [NativeTypeName("#define NO_PROPAGATE_INHERIT_ACE (0x4)")]
    public const int NO_PROPAGATE_INHERIT_ACE = (0x4);

    [NativeTypeName("#define INHERIT_ONLY_ACE (0x8)")]
    public const int INHERIT_ONLY_ACE = (0x8);

    [NativeTypeName("#define INHERITED_ACE (0x10)")]
    public const int INHERITED_ACE = (0x10);

    [NativeTypeName("#define VALID_INHERIT_FLAGS (0x1F)")]
    public const int VALID_INHERIT_FLAGS = (0x1F);

    [NativeTypeName("#define CRITICAL_ACE_FLAG (0x20)")]
    public const int CRITICAL_ACE_FLAG = (0x20);

    [NativeTypeName("#define SUCCESSFUL_ACCESS_ACE_FLAG (0x40)")]
    public const int SUCCESSFUL_ACCESS_ACE_FLAG = (0x40);

    [NativeTypeName("#define FAILED_ACCESS_ACE_FLAG (0x80)")]
    public const int FAILED_ACCESS_ACE_FLAG = (0x80);

    [NativeTypeName("#define ACE_OBJECT_TYPE_PRESENT 0x1")]
    public const int ACE_OBJECT_TYPE_PRESENT = 0x1;

    [NativeTypeName("#define ACE_INHERITED_OBJECT_TYPE_PRESENT 0x2")]
    public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;

    [NativeTypeName("#define AUDIT_ALLOW_NO_PRIVILEGE 0x1")]
    public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

    [NativeTypeName("#define PRIVILEGE_SET_ALL_NECESSARY (1)")]
    public const int PRIVILEGE_SET_ALL_NECESSARY = (1);

    [NativeTypeName("#define DISABLE_MAX_PRIVILEGE 0x1")]
    public const int DISABLE_MAX_PRIVILEGE = 0x1;

    [NativeTypeName("#define SANDBOX_INERT 0x2")]
    public const int SANDBOX_INERT = 0x2;

    [NativeTypeName("#define LUA_TOKEN 0x4")]
    public const int LUA_TOKEN = 0x4;

    [NativeTypeName("#define WRITE_RESTRICTED 0x8")]
    public const int WRITE_RESTRICTED = 0x8;

    [NativeTypeName("#define OWNER_SECURITY_INFORMATION (0x00000001L)")]
    public const int OWNER_SECURITY_INFORMATION = (0x00000001);

    [NativeTypeName("#define GROUP_SECURITY_INFORMATION (0x00000002L)")]
    public const int GROUP_SECURITY_INFORMATION = (0x00000002);

    [NativeTypeName("#define DACL_SECURITY_INFORMATION (0x00000004L)")]
    public const int DACL_SECURITY_INFORMATION = (0x00000004);

    [NativeTypeName("#define SACL_SECURITY_INFORMATION (0x00000008L)")]
    public const int SACL_SECURITY_INFORMATION = (0x00000008);

    [NativeTypeName("#define LABEL_SECURITY_INFORMATION (0x00000010L)")]
    public const int LABEL_SECURITY_INFORMATION = (0x00000010);

    [NativeTypeName("#define ATTRIBUTE_SECURITY_INFORMATION (0x00000020L)")]
    public const int ATTRIBUTE_SECURITY_INFORMATION = (0x00000020);

    [NativeTypeName("#define SCOPE_SECURITY_INFORMATION (0x00000040L)")]
    public const int SCOPE_SECURITY_INFORMATION = (0x00000040);

    [NativeTypeName("#define PROTECTED_DACL_SECURITY_INFORMATION (0x80000000L)")]
    public const uint PROTECTED_DACL_SECURITY_INFORMATION = (0x80000000);

    [NativeTypeName("#define PROTECTED_SACL_SECURITY_INFORMATION (0x40000000L)")]
    public const int PROTECTED_SACL_SECURITY_INFORMATION = (0x40000000);

    [NativeTypeName("#define UNPROTECTED_DACL_SECURITY_INFORMATION (0x20000000L)")]
    public const int UNPROTECTED_DACL_SECURITY_INFORMATION = (0x20000000);

    [NativeTypeName("#define UNPROTECTED_SACL_SECURITY_INFORMATION (0x10000000L)")]
    public const int UNPROTECTED_SACL_SECURITY_INFORMATION = (0x10000000);

    [NativeTypeName("#define FLS_MAXIMUM_AVAILABLE 4080")]
    public const int FLS_MAXIMUM_AVAILABLE = 4080;

    [NativeTypeName("#define TLS_MINIMUM_AVAILABLE 64")]
    public const int TLS_MINIMUM_AVAILABLE = 64;

    [NativeTypeName("#define COMPONENT_KTM 0x01")]
    public const int COMPONENT_KTM = 0x01;

    [NativeTypeName("#define COMPONENT_VALID_FLAGS (COMPONENT_KTM)")]
    public const int COMPONENT_VALID_FLAGS = (0x01);

    [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_ADD (0x00000001)")]
    public const int DYNAMIC_EH_CONTINUATION_TARGET_ADD = (0x00000001);

    [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED (0x00000002)")]
    public const int DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED = (0x00000002);

    [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD (0x00000001)")]
    public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD = (0x00000001);

    [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED (0x00000002)")]
    public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED = (0x00000002);

    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_ENABLE 0x00000001")]
    public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;

    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_DISABLE 0x00000002")]
    public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;

    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_ENABLE 0x00000004")]
    public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;

    [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_DISABLE 0x00000008")]
    public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;

    [NativeTypeName("#define QUOTA_LIMITS_USE_DEFAULT_LIMITS 0x00000010")]
    public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

    [NativeTypeName("#define MUTANT_QUERY_STATE 0x0001")]
    public const int MUTANT_QUERY_STATE = 0x0001;

    [NativeTypeName("#define MUTANT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          MUTANT_QUERY_STATE)")]
    public const int MUTANT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);

    [NativeTypeName("#define SEMAPHORE_MODIFY_STATE 0x0002")]
    public const int SEMAPHORE_MODIFY_STATE = 0x0002;

    [NativeTypeName("#define SEMAPHORE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
    public const int SEMAPHORE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

    [NativeTypeName("#define TIMER_QUERY_STATE 0x0001")]
    public const int TIMER_QUERY_STATE = 0x0001;

    [NativeTypeName("#define TIMER_MODIFY_STATE 0x0002")]
    public const int TIMER_MODIFY_STATE = 0x0002;

    [NativeTypeName("#define TIMER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          TIMER_QUERY_STATE|TIMER_MODIFY_STATE)")]
    public const int TIMER_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);

    [NativeTypeName("#define LTP_PC_SMT 0x1")]
    public const int LTP_PC_SMT = 0x1;

    [NativeTypeName("#define CACHE_FULLY_ASSOCIATIVE 0xFF")]
    public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

    [NativeTypeName("#define CFG_CALL_TARGET_VALID (0x00000001)")]
    public const int CFG_CALL_TARGET_VALID = (0x00000001);

    [NativeTypeName("#define CFG_CALL_TARGET_PROCESSED (0x00000002)")]
    public const int CFG_CALL_TARGET_PROCESSED = (0x00000002);

    [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID (0x00000004)")]
    public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = (0x00000004);

    [NativeTypeName("#define CFG_CALL_TARGET_VALID_XFG (0x00000008)")]
    public const int CFG_CALL_TARGET_VALID_XFG = (0x00000008);

    [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_XFG_TO_CFG (0x00000010)")]
    public const int CFG_CALL_TARGET_CONVERT_XFG_TO_CFG = (0x00000010);

    [NativeTypeName("#define SECTION_QUERY 0x0001")]
    public const int SECTION_QUERY = 0x0001;

    [NativeTypeName("#define SECTION_MAP_WRITE 0x0002")]
    public const int SECTION_MAP_WRITE = 0x0002;

    [NativeTypeName("#define SECTION_MAP_READ 0x0004")]
    public const int SECTION_MAP_READ = 0x0004;

    [NativeTypeName("#define SECTION_MAP_EXECUTE 0x0008")]
    public const int SECTION_MAP_EXECUTE = 0x0008;

    [NativeTypeName("#define SECTION_EXTEND_SIZE 0x0010")]
    public const int SECTION_EXTEND_SIZE = 0x0010;

    [NativeTypeName("#define SECTION_MAP_EXECUTE_EXPLICIT 0x0020")]
    public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

    [NativeTypeName("#define SECTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SECTION_QUERY|\\\r\n                            SECTION_MAP_WRITE |      \\\r\n                            SECTION_MAP_READ |       \\\r\n                            SECTION_MAP_EXECUTE |    \\\r\n                            SECTION_EXTEND_SIZE)")]
    public const int SECTION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

    [NativeTypeName("#define SESSION_QUERY_ACCESS 0x0001")]
    public const int SESSION_QUERY_ACCESS = 0x0001;

    [NativeTypeName("#define SESSION_MODIFY_ACCESS 0x0002")]
    public const int SESSION_MODIFY_ACCESS = 0x0002;

    [NativeTypeName("#define SESSION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |  \\\r\n                            SESSION_QUERY_ACCESS |             \\\r\n                            SESSION_MODIFY_ACCESS)")]
    public const int SESSION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002);

    [NativeTypeName("#define WRITE_WATCH_FLAG_RESET 0x01")]
    public const int WRITE_WATCH_FLAG_RESET = 0x01;

    [NativeTypeName("#define ENCLAVE_TYPE_SGX 0x00000001")]
    public const int ENCLAVE_TYPE_SGX = 0x00000001;

    [NativeTypeName("#define ENCLAVE_TYPE_SGX2 0x00000002")]
    public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

    [NativeTypeName("#define ENCLAVE_TYPE_VBS 0x00000010")]
    public const int ENCLAVE_TYPE_VBS = 0x00000010;

    [NativeTypeName("#define ENCLAVE_VBS_FLAG_DEBUG 0x00000001")]
    public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

    [NativeTypeName("#define ENCLAVE_TYPE_VBS_BASIC 0x00000011")]
    public const int ENCLAVE_TYPE_VBS_BASIC = 0x00000011;

    [NativeTypeName("#define VBS_BASIC_PAGE_MEASURED_DATA 0x00000001")]
    public const int VBS_BASIC_PAGE_MEASURED_DATA = 0x00000001;

    [NativeTypeName("#define VBS_BASIC_PAGE_UNMEASURED_DATA 0x00000002")]
    public const int VBS_BASIC_PAGE_UNMEASURED_DATA = 0x00000002;

    [NativeTypeName("#define VBS_BASIC_PAGE_ZERO_FILL 0x00000003")]
    public const int VBS_BASIC_PAGE_ZERO_FILL = 0x00000003;

    [NativeTypeName("#define VBS_BASIC_PAGE_THREAD_DESCRIPTOR 0x00000004")]
    public const int VBS_BASIC_PAGE_THREAD_DESCRIPTOR = 0x00000004;

    [NativeTypeName("#define VBS_BASIC_PAGE_SYSTEM_CALL 0x00000005")]
    public const int VBS_BASIC_PAGE_SYSTEM_CALL = 0x00000005;

    [NativeTypeName("#define DEDICATED_MEMORY_CACHE_ELIGIBLE 0x1")]
    public const int DEDICATED_MEMORY_CACHE_ELIGIBLE = 0x1;

    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PRIVACY 0x00004000")]
    public const int TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;

    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_INTEGRITY 0x00008000")]
    public const int TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;

    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_GLOBAL 0x00000004")]
    public const int TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;

    [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PINNED 0x00000002")]
    public const int TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;

    [NativeTypeName("#define MAILSLOT_NO_MESSAGE ((DWORD)-1)")]
    public const uint MAILSLOT_NO_MESSAGE = unchecked((uint)(-1));

    [NativeTypeName("#define MAILSLOT_WAIT_FOREVER ((DWORD)-1)")]
    public const uint MAILSLOT_WAIT_FOREVER = unchecked((uint)(-1));

    [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_ONLY 0x00000001")]
    public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

    [NativeTypeName("#define FLUSH_FLAGS_NO_SYNC 0x00000002")]
    public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

    [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_SYNC_ONLY 0x00000004")]
    public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

    [NativeTypeName("#define SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS (0x00000001)")]
    public const int SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS = (0x00000001);

    [NativeTypeName("#define SMB_CCF_APP_INSTANCE_EA_NAME \"ClusteredApplicationInstance\"")]
    public static ReadOnlySpan<byte> SMB_CCF_APP_INSTANCE_EA_NAME => "ClusteredApplicationInstance"u8;

    [NativeTypeName("#define NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR 0x00000001")]
    public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

    [NativeTypeName("#define DUPLICATE_CLOSE_SOURCE 0x00000001")]
    public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;

    [NativeTypeName("#define DUPLICATE_SAME_ACCESS 0x00000002")]
    public const int DUPLICATE_SAME_ACCESS = 0x00000002;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL 0")]
    public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_SINGLE 1")]
    public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_ROCKET 2")]
    public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE 3")]
    public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_DECREASE_MAX PERFSTATE_POLICY_CHANGE_ROCKET")]
    public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = 2;

    [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_INCREASE_MAX PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE")]
    public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = 3;

    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_IDEAL 0")]
    public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;

    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_SINGLE 1")]
    public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;

    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_ROCKET 2")]
    public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;

    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MULTISTEP 3")]
    public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;

    [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MAX CORE_PARKING_POLICY_CHANGE_MULTISTEP")]
    public const int CORE_PARKING_POLICY_CHANGE_MAX = 3;

    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_DISABLED 0")]
    public const int PARKING_TOPOLOGY_POLICY_DISABLED = 0;

    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_ROUNDROBIN 1")]
    public const int PARKING_TOPOLOGY_POLICY_ROUNDROBIN = 1;

    [NativeTypeName("#define PARKING_TOPOLOGY_POLICY_SEQUENTIAL 2")]
    public const int PARKING_TOPOLOGY_POLICY_SEQUENTIAL = 2;

    [NativeTypeName("#define SMT_UNPARKING_POLICY_CORE 0")]
    public const int SMT_UNPARKING_POLICY_CORE = 0;

    [NativeTypeName("#define SMT_UNPARKING_POLICY_CORE_PER_THREAD 1")]
    public const int SMT_UNPARKING_POLICY_CORE_PER_THREAD = 1;

    [NativeTypeName("#define SMT_UNPARKING_POLICY_LP_ROUNDROBIN 2")]
    public const int SMT_UNPARKING_POLICY_LP_ROUNDROBIN = 2;

    [NativeTypeName("#define SMT_UNPARKING_POLICY_LP_SEQUENTIAL 3")]
    public const int SMT_UNPARKING_POLICY_LP_SEQUENTIAL = 3;

    [NativeTypeName("#define DIAGNOSTIC_REASON_VERSION 0")]
    public const int DIAGNOSTIC_REASON_VERSION = 0;

    [NativeTypeName("#define DIAGNOSTIC_REASON_SIMPLE_STRING 0x00000001")]
    public const int DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;

    [NativeTypeName("#define DIAGNOSTIC_REASON_DETAILED_STRING 0x00000002")]
    public const int DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;

    [NativeTypeName("#define DIAGNOSTIC_REASON_NOT_SPECIFIED 0x80000000")]
    public const uint DIAGNOSTIC_REASON_NOT_SPECIFIED = 0x80000000;

    [NativeTypeName("#define DIAGNOSTIC_REASON_INVALID_FLAGS (~0x80000007)")]
    public const uint DIAGNOSTIC_REASON_INVALID_FLAGS = (~0x80000007);

    [NativeTypeName("#define PDCAP_D0_SUPPORTED 0x00000001")]
    public const int PDCAP_D0_SUPPORTED = 0x00000001;

    [NativeTypeName("#define PDCAP_D1_SUPPORTED 0x00000002")]
    public const int PDCAP_D1_SUPPORTED = 0x00000002;

    [NativeTypeName("#define PDCAP_D2_SUPPORTED 0x00000004")]
    public const int PDCAP_D2_SUPPORTED = 0x00000004;

    [NativeTypeName("#define PDCAP_D3_SUPPORTED 0x00000008")]
    public const int PDCAP_D3_SUPPORTED = 0x00000008;

    [NativeTypeName("#define PDCAP_WAKE_FROM_D0_SUPPORTED 0x00000010")]
    public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;

    [NativeTypeName("#define PDCAP_WAKE_FROM_D1_SUPPORTED 0x00000020")]
    public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;

    [NativeTypeName("#define PDCAP_WAKE_FROM_D2_SUPPORTED 0x00000040")]
    public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;

    [NativeTypeName("#define PDCAP_WAKE_FROM_D3_SUPPORTED 0x00000080")]
    public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;

    [NativeTypeName("#define PDCAP_WARM_EJECT_SUPPORTED 0x00000100")]
    public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

    [NativeTypeName("#define ACPI_PPM_SOFTWARE_ALL 0xFC")]
    public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;

    [NativeTypeName("#define ACPI_PPM_SOFTWARE_ANY 0xFD")]
    public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;

    [NativeTypeName("#define ACPI_PPM_HARDWARE_ALL 0xFE")]
    public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

    [NativeTypeName("#define NUM_DISCHARGE_POLICIES 4")]
    public const int NUM_DISCHARGE_POLICIES = 4;

    [NativeTypeName("#define DISCHARGE_POLICY_CRITICAL 0")]
    public const int DISCHARGE_POLICY_CRITICAL = 0;

    [NativeTypeName("#define DISCHARGE_POLICY_LOW 1")]
    public const int DISCHARGE_POLICY_LOW = 1;

    [NativeTypeName("#define PO_THROTTLE_NONE 0")]
    public const int PO_THROTTLE_NONE = 0;

    [NativeTypeName("#define PO_THROTTLE_CONSTANT 1")]
    public const int PO_THROTTLE_CONSTANT = 1;

    [NativeTypeName("#define PO_THROTTLE_DEGRADE 2")]
    public const int PO_THROTTLE_DEGRADE = 2;

    [NativeTypeName("#define PO_THROTTLE_ADAPTIVE 3")]
    public const int PO_THROTTLE_ADAPTIVE = 3;

    [NativeTypeName("#define PO_THROTTLE_MAXIMUM 4")]
    public const int PO_THROTTLE_MAXIMUM = 4;

    [NativeTypeName("#define HIBERFILE_TYPE_NONE 0x00")]
    public const int HIBERFILE_TYPE_NONE = 0x00;

    [NativeTypeName("#define HIBERFILE_TYPE_REDUCED 0x01")]
    public const int HIBERFILE_TYPE_REDUCED = 0x01;

    [NativeTypeName("#define HIBERFILE_TYPE_FULL 0x02")]
    public const int HIBERFILE_TYPE_FULL = 0x02;

    [NativeTypeName("#define HIBERFILE_TYPE_MAX 0x03")]
    public const int HIBERFILE_TYPE_MAX = 0x03;

    [NativeTypeName("#define N_BTMASK 0x000F")]
    public const int N_BTMASK = 0x000F;

    [NativeTypeName("#define N_TMASK 0x0030")]
    public const int N_TMASK = 0x0030;

    [NativeTypeName("#define N_TMASK1 0x00C0")]
    public const int N_TMASK1 = 0x00C0;

    [NativeTypeName("#define N_TMASK2 0x00F0")]
    public const int N_TMASK2 = 0x00F0;

    [NativeTypeName("#define N_BTSHFT 4")]
    public const int N_BTSHFT = 4;

    [NativeTypeName("#define N_TSHIFT 2")]
    public const int N_TSHIFT = 2;

    [NativeTypeName("#define FRAME_FPO 0")]
    public const int FRAME_FPO = 0;

    [NativeTypeName("#define FRAME_TRAP 1")]
    public const int FRAME_TRAP = 1;

    [NativeTypeName("#define FRAME_TSS 2")]
    public const int FRAME_TSS = 2;

    [NativeTypeName("#define FRAME_NONFPO 3")]
    public const int FRAME_NONFPO = 3;

    [NativeTypeName("#define SIZEOF_RFPO_DATA 16")]
    public const int SIZEOF_RFPO_DATA = 16;

    [NativeTypeName("#define NON_PAGED_DEBUG_SIGNATURE 0x494E")]
    public const int NON_PAGED_DEBUG_SIGNATURE = 0x494E;

    [NativeTypeName("#define IMPORT_OBJECT_HDR_SIG2 0xffff")]
    public const int IMPORT_OBJECT_HDR_SIG2 = 0xffff;

    [NativeTypeName("#define UNWIND_HISTORY_TABLE_SIZE 12")]
    public const int UNWIND_HISTORY_TABLE_SIZE = 12;

    [NativeTypeName("#define COMPRESSION_FORMAT_NONE (0x0000)")]
    public const int COMPRESSION_FORMAT_NONE = (0x0000);

    [NativeTypeName("#define COMPRESSION_FORMAT_DEFAULT (0x0001)")]
    public const int COMPRESSION_FORMAT_DEFAULT = (0x0001);

    [NativeTypeName("#define COMPRESSION_FORMAT_LZNT1 (0x0002)")]
    public const int COMPRESSION_FORMAT_LZNT1 = (0x0002);

    [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS (0x0003)")]
    public const int COMPRESSION_FORMAT_XPRESS = (0x0003);

    [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS_HUFF (0x0004)")]
    public const int COMPRESSION_FORMAT_XPRESS_HUFF = (0x0004);

    [NativeTypeName("#define COMPRESSION_FORMAT_XP10 (0x0005)")]
    public const int COMPRESSION_FORMAT_XP10 = (0x0005);

    [NativeTypeName("#define COMPRESSION_ENGINE_STANDARD (0x0000)")]
    public const int COMPRESSION_ENGINE_STANDARD = (0x0000);

    [NativeTypeName("#define COMPRESSION_ENGINE_MAXIMUM (0x0100)")]
    public const int COMPRESSION_ENGINE_MAXIMUM = (0x0100);

    [NativeTypeName("#define COMPRESSION_ENGINE_HIBER (0x0200)")]
    public const int COMPRESSION_ENGINE_HIBER = (0x0200);

    [NativeTypeName("#define MESSAGE_RESOURCE_UNICODE 0x0001")]
    public const int MESSAGE_RESOURCE_UNICODE = 0x0001;

    [NativeTypeName("#define MESSAGE_RESOURCE_UTF8 0x0002")]
    public const int MESSAGE_RESOURCE_UTF8 = 0x0002;

    [NativeTypeName("#define VRL_PREDEFINED_CLASS_BEGIN (1 << 0)")]
    public const int VRL_PREDEFINED_CLASS_BEGIN = (1 << 0);

    [NativeTypeName("#define VRL_CUSTOM_CLASS_BEGIN (1 << 8)")]
    public const int VRL_CUSTOM_CLASS_BEGIN = (1 << 8);

    [NativeTypeName("#define VRL_CLASS_CONSISTENCY (VRL_PREDEFINED_CLASS_BEGIN << 0)")]
    public const int VRL_CLASS_CONSISTENCY = ((1 << 0) << 0);

    [NativeTypeName("#define VRL_ENABLE_KERNEL_BREAKS (1 << 31)")]
    public const int VRL_ENABLE_KERNEL_BREAKS = (1 << 31);

    [NativeTypeName("#define CTMF_INCLUDE_APPCONTAINER 0x00000001UL")]
    public const uint CTMF_INCLUDE_APPCONTAINER = 0x00000001U;

    [NativeTypeName("#define CTMF_INCLUDE_LPAC 0x00000002UL")]
    public const uint CTMF_INCLUDE_LPAC = 0x00000002U;

    [NativeTypeName("#define CTMF_VALID_FLAGS (CTMF_INCLUDE_APPCONTAINER | CTMF_INCLUDE_LPAC)")]
    public const uint CTMF_VALID_FLAGS = (0x00000001U | 0x00000002U);

    [NativeTypeName("#define FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN (0x00000001)")]
    public const int FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN = (0x00000001);

    [NativeTypeName("#define FLUSH_NV_MEMORY_DEFAULT_TOKEN (ULONG_PTR)(-1)")]
    public static nuint FLUSH_NV_MEMORY_DEFAULT_TOKEN => unchecked((nuint)(-1));

    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
    public const int WRITE_NV_MEMORY_FLAG_FLUSH = (0x00000001);

    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
    public const int WRITE_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_PERSIST (WRITE_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | WRITE_NV_MEMORY_FLAG_NON_TEMPORAL)")]
    public const int WRITE_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

    [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
    public const int WRITE_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
    public const int FILL_NV_MEMORY_FLAG_FLUSH = (0x00000001);

    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
    public const int FILL_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_PERSIST (FILL_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | FILL_NV_MEMORY_FLAG_NON_TEMPORAL)")]
    public const int FILL_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

    [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
    public const int FILL_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

    [NativeTypeName("#define PERFORMANCE_DATA_VERSION 1")]
    public const int PERFORMANCE_DATA_VERSION = 1;

    [NativeTypeName("#define UNIFIEDBUILDREVISION_KEY L\"\\\\Registry\\\\Machine\\\\Software\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\"")]
    public const string UNIFIEDBUILDREVISION_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion";

    [NativeTypeName("#define UNIFIEDBUILDREVISION_VALUE L\"UBR\"")]
    public const string UNIFIEDBUILDREVISION_VALUE = "UBR";

    [NativeTypeName("#define UNIFIEDBUILDREVISION_MIN 0x00000000")]
    public const int UNIFIEDBUILDREVISION_MIN = 0x00000000;

    [NativeTypeName("#define DLL_PROCESS_ATTACH 1")]
    public const int DLL_PROCESS_ATTACH = 1;

    [NativeTypeName("#define DLL_THREAD_ATTACH 2")]
    public const int DLL_THREAD_ATTACH = 2;

    [NativeTypeName("#define DLL_THREAD_DETACH 3")]
    public const int DLL_THREAD_DETACH = 3;

    [NativeTypeName("#define DLL_PROCESS_DETACH 0")]
    public const int DLL_PROCESS_DETACH = 0;

    [NativeTypeName("#define MAXLOGICALLOGNAMESIZE 256")]
    public const int MAXLOGICALLOGNAMESIZE = 256;
}
