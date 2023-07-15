// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class JOB
{
    [NativeTypeName("#define JOB_OBJECT_ASSIGN_PROCESS (0x0001)")]
    public const int JOB_OBJECT_ASSIGN_PROCESS = (0x0001);
    [NativeTypeName("#define JOB_OBJECT_SET_ATTRIBUTES (0x0002)")]
    public const int JOB_OBJECT_SET_ATTRIBUTES = (0x0002);
    [NativeTypeName("#define JOB_OBJECT_QUERY (0x0004)")]
    public const int JOB_OBJECT_QUERY = (0x0004);
    [NativeTypeName("#define JOB_OBJECT_TERMINATE (0x0008)")]
    public const int JOB_OBJECT_TERMINATE = (0x0008);
    [NativeTypeName("#define JOB_OBJECT_SET_SECURITY_ATTRIBUTES (0x0010)")]
    public const int JOB_OBJECT_SET_SECURITY_ATTRIBUTES = (0x0010);
    [NativeTypeName("#define JOB_OBJECT_IMPERSONATE (0x0020)")]
    public const int JOB_OBJECT_IMPERSONATE = (0x0020);
    [NativeTypeName("#define JOB_OBJECT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                        0x3F )")]
    public const int JOB_OBJECT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3F);
    [NativeTypeName("#define JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG 64")]
    public const int JOB_OBJECT_NET_RATE_CONTROL_MAX_DSCP_TAG = 64;
    [NativeTypeName("#define JOB_OBJECT_TERMINATE_AT_END_OF_JOB 0")]
    public const int JOB_OBJECT_TERMINATE_AT_END_OF_JOB = 0;
    [NativeTypeName("#define JOB_OBJECT_POST_AT_END_OF_JOB 1")]
    public const int JOB_OBJECT_POST_AT_END_OF_JOB = 1;
    [NativeTypeName("#define JOB_OBJECT_MSG_END_OF_JOB_TIME 1")]
    public const int JOB_OBJECT_MSG_END_OF_JOB_TIME = 1;
    [NativeTypeName("#define JOB_OBJECT_MSG_END_OF_PROCESS_TIME 2")]
    public const int JOB_OBJECT_MSG_END_OF_PROCESS_TIME = 2;
    [NativeTypeName("#define JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT 3")]
    public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_LIMIT = 3;
    [NativeTypeName("#define JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO 4")]
    public const int JOB_OBJECT_MSG_ACTIVE_PROCESS_ZERO = 4;
    [NativeTypeName("#define JOB_OBJECT_MSG_NEW_PROCESS 6")]
    public const int JOB_OBJECT_MSG_NEW_PROCESS = 6;
    [NativeTypeName("#define JOB_OBJECT_MSG_EXIT_PROCESS 7")]
    public const int JOB_OBJECT_MSG_EXIT_PROCESS = 7;
    [NativeTypeName("#define JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS 8")]
    public const int JOB_OBJECT_MSG_ABNORMAL_EXIT_PROCESS = 8;
    [NativeTypeName("#define JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT 9")]
    public const int JOB_OBJECT_MSG_PROCESS_MEMORY_LIMIT = 9;
    [NativeTypeName("#define JOB_OBJECT_MSG_JOB_MEMORY_LIMIT 10")]
    public const int JOB_OBJECT_MSG_JOB_MEMORY_LIMIT = 10;
    [NativeTypeName("#define JOB_OBJECT_MSG_NOTIFICATION_LIMIT 11")]
    public const int JOB_OBJECT_MSG_NOTIFICATION_LIMIT = 11;
    [NativeTypeName("#define JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT 12")]
    public const int JOB_OBJECT_MSG_JOB_CYCLE_TIME_LIMIT = 12;
    [NativeTypeName("#define JOB_OBJECT_MSG_SILO_TERMINATED 13")]
    public const int JOB_OBJECT_MSG_SILO_TERMINATED = 13;
    [NativeTypeName("#define JOB_OBJECT_MSG_MINIMUM 1")]
    public const int JOB_OBJECT_MSG_MINIMUM = 1;
    [NativeTypeName("#define JOB_OBJECT_MSG_MAXIMUM 13")]
    public const int JOB_OBJECT_MSG_MAXIMUM = 13;
    [NativeTypeName("#define JOB_OBJECT_VALID_COMPLETION_FILTER (((1UL << (JOB_OBJECT_MSG_MAXIMUM + 1)) - 1) - \\\r\n     ((1UL << JOB_OBJECT_MSG_MINIMUM) - 1))")]
    public const uint JOB_OBJECT_VALID_COMPLETION_FILTER = (((1U << (13 + 1)) - 1) - ((1U << 1) - 1));
    [NativeTypeName("#define JOB_OBJECT_LIMIT_WORKINGSET 0x00000001")]
    public const int JOB_OBJECT_LIMIT_WORKINGSET = 0x00000001;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_PROCESS_TIME 0x00000002")]
    public const int JOB_OBJECT_LIMIT_PROCESS_TIME = 0x00000002;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_TIME 0x00000004")]
    public const int JOB_OBJECT_LIMIT_JOB_TIME = 0x00000004;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_ACTIVE_PROCESS 0x00000008")]
    public const int JOB_OBJECT_LIMIT_ACTIVE_PROCESS = 0x00000008;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_AFFINITY 0x00000010")]
    public const int JOB_OBJECT_LIMIT_AFFINITY = 0x00000010;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_PRIORITY_CLASS 0x00000020")]
    public const int JOB_OBJECT_LIMIT_PRIORITY_CLASS = 0x00000020;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME 0x00000040")]
    public const int JOB_OBJECT_LIMIT_PRESERVE_JOB_TIME = 0x00000040;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_SCHEDULING_CLASS 0x00000080")]
    public const int JOB_OBJECT_LIMIT_SCHEDULING_CLASS = 0x00000080;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_PROCESS_MEMORY 0x00000100")]
    public const int JOB_OBJECT_LIMIT_PROCESS_MEMORY = 0x00000100;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY 0x00000200")]
    public const int JOB_OBJECT_LIMIT_JOB_MEMORY = 0x00000200;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH JOB_OBJECT_LIMIT_JOB_MEMORY")]
    public const int JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH = 0x00000200;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION 0x00000400")]
    public const int JOB_OBJECT_LIMIT_DIE_ON_UNHANDLED_EXCEPTION = 0x00000400;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_BREAKAWAY_OK 0x00000800")]
    public const int JOB_OBJECT_LIMIT_BREAKAWAY_OK = 0x00000800;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK 0x00001000")]
    public const int JOB_OBJECT_LIMIT_SILENT_BREAKAWAY_OK = 0x00001000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE 0x00002000")]
    public const int JOB_OBJECT_LIMIT_KILL_ON_JOB_CLOSE = 0x00002000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_SUBSET_AFFINITY 0x00004000")]
    public const int JOB_OBJECT_LIMIT_SUBSET_AFFINITY = 0x00004000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_MEMORY_LOW 0x00008000")]
    public const int JOB_OBJECT_LIMIT_JOB_MEMORY_LOW = 0x00008000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_READ_BYTES 0x00010000")]
    public const int JOB_OBJECT_LIMIT_JOB_READ_BYTES = 0x00010000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_JOB_WRITE_BYTES 0x00020000")]
    public const int JOB_OBJECT_LIMIT_JOB_WRITE_BYTES = 0x00020000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_RATE_CONTROL 0x00040000")]
    public const int JOB_OBJECT_LIMIT_RATE_CONTROL = 0x00040000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_CPU_RATE_CONTROL JOB_OBJECT_LIMIT_RATE_CONTROL")]
    public const int JOB_OBJECT_LIMIT_CPU_RATE_CONTROL = 0x00040000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_IO_RATE_CONTROL 0x00080000")]
    public const int JOB_OBJECT_LIMIT_IO_RATE_CONTROL = 0x00080000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_NET_RATE_CONTROL 0x00100000")]
    public const int JOB_OBJECT_LIMIT_NET_RATE_CONTROL = 0x00100000;
    [NativeTypeName("#define JOB_OBJECT_LIMIT_VALID_FLAGS 0x0007ffff")]
    public const int JOB_OBJECT_LIMIT_VALID_FLAGS = 0x0007ffff;
    [NativeTypeName("#define JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS 0x000000ff")]
    public const int JOB_OBJECT_BASIC_LIMIT_VALID_FLAGS = 0x000000ff;
    [NativeTypeName("#define JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS 0x00007fff")]
    public const int JOB_OBJECT_EXTENDED_LIMIT_VALID_FLAGS = 0x00007fff;
    [NativeTypeName("#define JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS (JOB_OBJECT_LIMIT_JOB_READ_BYTES | \\\r\n     JOB_OBJECT_LIMIT_JOB_WRITE_BYTES | \\\r\n     JOB_OBJECT_LIMIT_JOB_TIME | \\\r\n     JOB_OBJECT_LIMIT_JOB_MEMORY_LOW | \\\r\n     JOB_OBJECT_LIMIT_JOB_MEMORY_HIGH | \\\r\n     JOB_OBJECT_LIMIT_CPU_RATE_CONTROL | \\\r\n     JOB_OBJECT_LIMIT_IO_RATE_CONTROL | \\\r\n     JOB_OBJECT_LIMIT_NET_RATE_CONTROL)")]
    public const int JOB_OBJECT_NOTIFICATION_LIMIT_VALID_FLAGS = (0x00010000 | 0x00020000 | 0x00000004 | 0x00008000 | 0x00000200 | 0x00040000 | 0x00080000 | 0x00100000);
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_NONE 0x00000000")]
    public const int JOB_OBJECT_UILIMIT_NONE = 0x00000000;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_HANDLES 0x00000001")]
    public const int JOB_OBJECT_UILIMIT_HANDLES = 0x00000001;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_READCLIPBOARD 0x00000002")]
    public const int JOB_OBJECT_UILIMIT_READCLIPBOARD = 0x00000002;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_WRITECLIPBOARD 0x00000004")]
    public const int JOB_OBJECT_UILIMIT_WRITECLIPBOARD = 0x00000004;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS 0x00000008")]
    public const int JOB_OBJECT_UILIMIT_SYSTEMPARAMETERS = 0x00000008;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_DISPLAYSETTINGS 0x00000010")]
    public const int JOB_OBJECT_UILIMIT_DISPLAYSETTINGS = 0x00000010;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_GLOBALATOMS 0x00000020")]
    public const int JOB_OBJECT_UILIMIT_GLOBALATOMS = 0x00000020;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_DESKTOP 0x00000040")]
    public const int JOB_OBJECT_UILIMIT_DESKTOP = 0x00000040;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_EXITWINDOWS 0x00000080")]
    public const int JOB_OBJECT_UILIMIT_EXITWINDOWS = 0x00000080;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_IME 0x00000100")]
    public const int JOB_OBJECT_UILIMIT_IME = 0x00000100;
    [NativeTypeName("#define JOB_OBJECT_UILIMIT_ALL 0x000001FF")]
    public const int JOB_OBJECT_UILIMIT_ALL = 0x000001FF;
    [NativeTypeName("#define JOB_OBJECT_UI_VALID_FLAGS 0x000001FF")]
    public const int JOB_OBJECT_UI_VALID_FLAGS = 0x000001FF;
    [NativeTypeName("#define JOB_OBJECT_SECURITY_NO_ADMIN 0x00000001")]
    public const int JOB_OBJECT_SECURITY_NO_ADMIN = 0x00000001;
    [NativeTypeName("#define JOB_OBJECT_SECURITY_RESTRICTED_TOKEN 0x00000002")]
    public const int JOB_OBJECT_SECURITY_RESTRICTED_TOKEN = 0x00000002;
    [NativeTypeName("#define JOB_OBJECT_SECURITY_ONLY_TOKEN 0x00000004")]
    public const int JOB_OBJECT_SECURITY_ONLY_TOKEN = 0x00000004;
    [NativeTypeName("#define JOB_OBJECT_SECURITY_FILTER_TOKENS 0x00000008")]
    public const int JOB_OBJECT_SECURITY_FILTER_TOKENS = 0x00000008;
    [NativeTypeName("#define JOB_OBJECT_SECURITY_VALID_FLAGS 0x0000000f")]
    public const int JOB_OBJECT_SECURITY_VALID_FLAGS = 0x0000000f;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_ENABLE 0x1")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_ENABLE = 0x1;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED 0x2")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_WEIGHT_BASED = 0x2;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP 0x4")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_HARD_CAP = 0x4;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY 0x8")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_NOTIFY = 0x8;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE 0x10")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_MIN_MAX_RATE = 0x10;
    [NativeTypeName("#define JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS 0x1f")]
    public const int JOB_OBJECT_CPU_RATE_CONTROL_VALID_FLAGS = 0x1f;
}