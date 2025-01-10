// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class ACTRL
{
    [NativeTypeName("#define ACTRL_RESERVED 0x00000000")]
    public const int ACTRL_RESERVED = 0x00000000;

    [NativeTypeName("#define ACTRL_PERM_1 0x00000001")]
    public const int ACTRL_PERM_1 = 0x00000001;

    [NativeTypeName("#define ACTRL_PERM_2 0x00000002")]
    public const int ACTRL_PERM_2 = 0x00000002;

    [NativeTypeName("#define ACTRL_PERM_3 0x00000004")]
    public const int ACTRL_PERM_3 = 0x00000004;

    [NativeTypeName("#define ACTRL_PERM_4 0x00000008")]
    public const int ACTRL_PERM_4 = 0x00000008;

    [NativeTypeName("#define ACTRL_PERM_5 0x00000010")]
    public const int ACTRL_PERM_5 = 0x00000010;

    [NativeTypeName("#define ACTRL_PERM_6 0x00000020")]
    public const int ACTRL_PERM_6 = 0x00000020;

    [NativeTypeName("#define ACTRL_PERM_7 0x00000040")]
    public const int ACTRL_PERM_7 = 0x00000040;

    [NativeTypeName("#define ACTRL_PERM_8 0x00000080")]
    public const int ACTRL_PERM_8 = 0x00000080;

    [NativeTypeName("#define ACTRL_PERM_9 0x00000100")]
    public const int ACTRL_PERM_9 = 0x00000100;

    [NativeTypeName("#define ACTRL_PERM_10 0x00000200")]
    public const int ACTRL_PERM_10 = 0x00000200;

    [NativeTypeName("#define ACTRL_PERM_11 0x00000400")]
    public const int ACTRL_PERM_11 = 0x00000400;

    [NativeTypeName("#define ACTRL_PERM_12 0x00000800")]
    public const int ACTRL_PERM_12 = 0x00000800;

    [NativeTypeName("#define ACTRL_PERM_13 0x00001000")]
    public const int ACTRL_PERM_13 = 0x00001000;

    [NativeTypeName("#define ACTRL_PERM_14 0x00002000")]
    public const int ACTRL_PERM_14 = 0x00002000;

    [NativeTypeName("#define ACTRL_PERM_15 0x00004000")]
    public const int ACTRL_PERM_15 = 0x00004000;

    [NativeTypeName("#define ACTRL_PERM_16 0x00008000")]
    public const int ACTRL_PERM_16 = 0x00008000;

    [NativeTypeName("#define ACTRL_PERM_17 0x00010000")]
    public const int ACTRL_PERM_17 = 0x00010000;

    [NativeTypeName("#define ACTRL_PERM_18 0x00020000")]
    public const int ACTRL_PERM_18 = 0x00020000;

    [NativeTypeName("#define ACTRL_PERM_19 0x00040000")]
    public const int ACTRL_PERM_19 = 0x00040000;

    [NativeTypeName("#define ACTRL_PERM_20 0x00080000")]
    public const int ACTRL_PERM_20 = 0x00080000;

    [NativeTypeName("#define ACTRL_ACCESS_ALLOWED 0x00000001")]
    public const int ACTRL_ACCESS_ALLOWED = 0x00000001;

    [NativeTypeName("#define ACTRL_ACCESS_DENIED 0x00000002")]
    public const int ACTRL_ACCESS_DENIED = 0x00000002;

    [NativeTypeName("#define ACTRL_AUDIT_SUCCESS 0x00000004")]
    public const int ACTRL_AUDIT_SUCCESS = 0x00000004;

    [NativeTypeName("#define ACTRL_AUDIT_FAILURE 0x00000008")]
    public const int ACTRL_AUDIT_FAILURE = 0x00000008;

    [NativeTypeName("#define ACTRL_ACCESS_PROTECTED 0x00000001")]
    public const int ACTRL_ACCESS_PROTECTED = 0x00000001;

    [NativeTypeName("#define ACTRL_SYSTEM_ACCESS 0x04000000")]
    public const int ACTRL_SYSTEM_ACCESS = 0x04000000;

    [NativeTypeName("#define ACTRL_DELETE 0x08000000")]
    public const int ACTRL_DELETE = 0x08000000;

    [NativeTypeName("#define ACTRL_READ_CONTROL 0x10000000")]
    public const int ACTRL_READ_CONTROL = 0x10000000;

    [NativeTypeName("#define ACTRL_CHANGE_ACCESS 0x20000000")]
    public const int ACTRL_CHANGE_ACCESS = 0x20000000;

    [NativeTypeName("#define ACTRL_CHANGE_OWNER 0x40000000")]
    public const int ACTRL_CHANGE_OWNER = 0x40000000;

    [NativeTypeName("#define ACTRL_SYNCHRONIZE 0x80000000")]
    public const uint ACTRL_SYNCHRONIZE = 0x80000000;

    [NativeTypeName("#define ACTRL_STD_RIGHTS_ALL 0xf8000000")]
    public const uint ACTRL_STD_RIGHTS_ALL = 0xf8000000;

    [NativeTypeName(
        "#define ACTRL_STD_RIGHT_REQUIRED ( ACTRL_STD_RIGHTS_ALL & ~ACTRL_SYNCHRONIZE )"
    )]
    public const uint ACTRL_STD_RIGHT_REQUIRED = (0xf8000000 & ~0x80000000);

    [NativeTypeName("#define ACTRL_DS_OPEN ACTRL_RESERVED")]
    public const int ACTRL_DS_OPEN = 0x00000000;

    [NativeTypeName("#define ACTRL_DS_CREATE_CHILD ACTRL_PERM_1")]
    public const int ACTRL_DS_CREATE_CHILD = 0x00000001;

    [NativeTypeName("#define ACTRL_DS_DELETE_CHILD ACTRL_PERM_2")]
    public const int ACTRL_DS_DELETE_CHILD = 0x00000002;

    [NativeTypeName("#define ACTRL_DS_LIST ACTRL_PERM_3")]
    public const int ACTRL_DS_LIST = 0x00000004;

    [NativeTypeName("#define ACTRL_DS_SELF ACTRL_PERM_4")]
    public const int ACTRL_DS_SELF = 0x00000008;

    [NativeTypeName("#define ACTRL_DS_READ_PROP ACTRL_PERM_5")]
    public const int ACTRL_DS_READ_PROP = 0x00000010;

    [NativeTypeName("#define ACTRL_DS_WRITE_PROP ACTRL_PERM_6")]
    public const int ACTRL_DS_WRITE_PROP = 0x00000020;

    [NativeTypeName("#define ACTRL_DS_DELETE_TREE ACTRL_PERM_7")]
    public const int ACTRL_DS_DELETE_TREE = 0x00000040;

    [NativeTypeName("#define ACTRL_DS_LIST_OBJECT ACTRL_PERM_8")]
    public const int ACTRL_DS_LIST_OBJECT = 0x00000080;

    [NativeTypeName("#define ACTRL_DS_CONTROL_ACCESS ACTRL_PERM_9")]
    public const int ACTRL_DS_CONTROL_ACCESS = 0x00000100;

    [NativeTypeName("#define ACTRL_FILE_READ ACTRL_PERM_1")]
    public const int ACTRL_FILE_READ = 0x00000001;

    [NativeTypeName("#define ACTRL_FILE_WRITE ACTRL_PERM_2")]
    public const int ACTRL_FILE_WRITE = 0x00000002;

    [NativeTypeName("#define ACTRL_FILE_APPEND ACTRL_PERM_3")]
    public const int ACTRL_FILE_APPEND = 0x00000004;

    [NativeTypeName("#define ACTRL_FILE_READ_PROP ACTRL_PERM_4")]
    public const int ACTRL_FILE_READ_PROP = 0x00000008;

    [NativeTypeName("#define ACTRL_FILE_WRITE_PROP ACTRL_PERM_5")]
    public const int ACTRL_FILE_WRITE_PROP = 0x00000010;

    [NativeTypeName("#define ACTRL_FILE_EXECUTE ACTRL_PERM_6")]
    public const int ACTRL_FILE_EXECUTE = 0x00000020;

    [NativeTypeName("#define ACTRL_FILE_READ_ATTRIB ACTRL_PERM_8")]
    public const int ACTRL_FILE_READ_ATTRIB = 0x00000080;

    [NativeTypeName("#define ACTRL_FILE_WRITE_ATTRIB ACTRL_PERM_9")]
    public const int ACTRL_FILE_WRITE_ATTRIB = 0x00000100;

    [NativeTypeName("#define ACTRL_FILE_CREATE_PIPE ACTRL_PERM_10")]
    public const int ACTRL_FILE_CREATE_PIPE = 0x00000200;

    [NativeTypeName("#define ACTRL_DIR_LIST ACTRL_PERM_1")]
    public const int ACTRL_DIR_LIST = 0x00000001;

    [NativeTypeName("#define ACTRL_DIR_CREATE_OBJECT ACTRL_PERM_2")]
    public const int ACTRL_DIR_CREATE_OBJECT = 0x00000002;

    [NativeTypeName("#define ACTRL_DIR_CREATE_CHILD ACTRL_PERM_3")]
    public const int ACTRL_DIR_CREATE_CHILD = 0x00000004;

    [NativeTypeName("#define ACTRL_DIR_DELETE_CHILD ACTRL_PERM_7")]
    public const int ACTRL_DIR_DELETE_CHILD = 0x00000040;

    [NativeTypeName("#define ACTRL_DIR_TRAVERSE ACTRL_PERM_6")]
    public const int ACTRL_DIR_TRAVERSE = 0x00000020;

    [NativeTypeName("#define ACTRL_KERNEL_TERMINATE ACTRL_PERM_1")]
    public const int ACTRL_KERNEL_TERMINATE = 0x00000001;

    [NativeTypeName("#define ACTRL_KERNEL_THREAD ACTRL_PERM_2")]
    public const int ACTRL_KERNEL_THREAD = 0x00000002;

    [NativeTypeName("#define ACTRL_KERNEL_VM ACTRL_PERM_3")]
    public const int ACTRL_KERNEL_VM = 0x00000004;

    [NativeTypeName("#define ACTRL_KERNEL_VM_READ ACTRL_PERM_4")]
    public const int ACTRL_KERNEL_VM_READ = 0x00000008;

    [NativeTypeName("#define ACTRL_KERNEL_VM_WRITE ACTRL_PERM_5")]
    public const int ACTRL_KERNEL_VM_WRITE = 0x00000010;

    [NativeTypeName("#define ACTRL_KERNEL_DUP_HANDLE ACTRL_PERM_6")]
    public const int ACTRL_KERNEL_DUP_HANDLE = 0x00000020;

    [NativeTypeName("#define ACTRL_KERNEL_PROCESS ACTRL_PERM_7")]
    public const int ACTRL_KERNEL_PROCESS = 0x00000040;

    [NativeTypeName("#define ACTRL_KERNEL_SET_INFO ACTRL_PERM_8")]
    public const int ACTRL_KERNEL_SET_INFO = 0x00000080;

    [NativeTypeName("#define ACTRL_KERNEL_GET_INFO ACTRL_PERM_9")]
    public const int ACTRL_KERNEL_GET_INFO = 0x00000100;

    [NativeTypeName("#define ACTRL_KERNEL_CONTROL ACTRL_PERM_10")]
    public const int ACTRL_KERNEL_CONTROL = 0x00000200;

    [NativeTypeName("#define ACTRL_KERNEL_ALERT ACTRL_PERM_11")]
    public const int ACTRL_KERNEL_ALERT = 0x00000400;

    [NativeTypeName("#define ACTRL_KERNEL_GET_CONTEXT ACTRL_PERM_12")]
    public const int ACTRL_KERNEL_GET_CONTEXT = 0x00000800;

    [NativeTypeName("#define ACTRL_KERNEL_SET_CONTEXT ACTRL_PERM_13")]
    public const int ACTRL_KERNEL_SET_CONTEXT = 0x00001000;

    [NativeTypeName("#define ACTRL_KERNEL_TOKEN ACTRL_PERM_14")]
    public const int ACTRL_KERNEL_TOKEN = 0x00002000;

    [NativeTypeName("#define ACTRL_KERNEL_IMPERSONATE ACTRL_PERM_15")]
    public const int ACTRL_KERNEL_IMPERSONATE = 0x00004000;

    [NativeTypeName("#define ACTRL_KERNEL_DIMPERSONATE ACTRL_PERM_16")]
    public const int ACTRL_KERNEL_DIMPERSONATE = 0x00008000;

    [NativeTypeName("#define ACTRL_PRINT_SADMIN ACTRL_PERM_1")]
    public const int ACTRL_PRINT_SADMIN = 0x00000001;

    [NativeTypeName("#define ACTRL_PRINT_SLIST ACTRL_PERM_2")]
    public const int ACTRL_PRINT_SLIST = 0x00000002;

    [NativeTypeName("#define ACTRL_PRINT_PADMIN ACTRL_PERM_3")]
    public const int ACTRL_PRINT_PADMIN = 0x00000004;

    [NativeTypeName("#define ACTRL_PRINT_PUSE ACTRL_PERM_4")]
    public const int ACTRL_PRINT_PUSE = 0x00000008;

    [NativeTypeName("#define ACTRL_PRINT_JADMIN ACTRL_PERM_5")]
    public const int ACTRL_PRINT_JADMIN = 0x00000010;

    [NativeTypeName("#define ACTRL_SVC_GET_INFO ACTRL_PERM_1")]
    public const int ACTRL_SVC_GET_INFO = 0x00000001;

    [NativeTypeName("#define ACTRL_SVC_SET_INFO ACTRL_PERM_2")]
    public const int ACTRL_SVC_SET_INFO = 0x00000002;

    [NativeTypeName("#define ACTRL_SVC_STATUS ACTRL_PERM_3")]
    public const int ACTRL_SVC_STATUS = 0x00000004;

    [NativeTypeName("#define ACTRL_SVC_LIST ACTRL_PERM_4")]
    public const int ACTRL_SVC_LIST = 0x00000008;

    [NativeTypeName("#define ACTRL_SVC_START ACTRL_PERM_5")]
    public const int ACTRL_SVC_START = 0x00000010;

    [NativeTypeName("#define ACTRL_SVC_STOP ACTRL_PERM_6")]
    public const int ACTRL_SVC_STOP = 0x00000020;

    [NativeTypeName("#define ACTRL_SVC_PAUSE ACTRL_PERM_7")]
    public const int ACTRL_SVC_PAUSE = 0x00000040;

    [NativeTypeName("#define ACTRL_SVC_INTERROGATE ACTRL_PERM_8")]
    public const int ACTRL_SVC_INTERROGATE = 0x00000080;

    [NativeTypeName("#define ACTRL_SVC_UCONTROL ACTRL_PERM_9")]
    public const int ACTRL_SVC_UCONTROL = 0x00000100;

    [NativeTypeName("#define ACTRL_REG_QUERY ACTRL_PERM_1")]
    public const int ACTRL_REG_QUERY = 0x00000001;

    [NativeTypeName("#define ACTRL_REG_SET ACTRL_PERM_2")]
    public const int ACTRL_REG_SET = 0x00000002;

    [NativeTypeName("#define ACTRL_REG_CREATE_CHILD ACTRL_PERM_3")]
    public const int ACTRL_REG_CREATE_CHILD = 0x00000004;

    [NativeTypeName("#define ACTRL_REG_LIST ACTRL_PERM_4")]
    public const int ACTRL_REG_LIST = 0x00000008;

    [NativeTypeName("#define ACTRL_REG_NOTIFY ACTRL_PERM_5")]
    public const int ACTRL_REG_NOTIFY = 0x00000010;

    [NativeTypeName("#define ACTRL_REG_LINK ACTRL_PERM_6")]
    public const int ACTRL_REG_LINK = 0x00000020;

    [NativeTypeName("#define ACTRL_WIN_CLIPBRD ACTRL_PERM_1")]
    public const int ACTRL_WIN_CLIPBRD = 0x00000001;

    [NativeTypeName("#define ACTRL_WIN_GLOBAL_ATOMS ACTRL_PERM_2")]
    public const int ACTRL_WIN_GLOBAL_ATOMS = 0x00000002;

    [NativeTypeName("#define ACTRL_WIN_CREATE ACTRL_PERM_3")]
    public const int ACTRL_WIN_CREATE = 0x00000004;

    [NativeTypeName("#define ACTRL_WIN_LIST_DESK ACTRL_PERM_4")]
    public const int ACTRL_WIN_LIST_DESK = 0x00000008;

    [NativeTypeName("#define ACTRL_WIN_LIST ACTRL_PERM_5")]
    public const int ACTRL_WIN_LIST = 0x00000010;

    [NativeTypeName("#define ACTRL_WIN_READ_ATTRIBS ACTRL_PERM_6")]
    public const int ACTRL_WIN_READ_ATTRIBS = 0x00000020;

    [NativeTypeName("#define ACTRL_WIN_WRITE_ATTRIBS ACTRL_PERM_7")]
    public const int ACTRL_WIN_WRITE_ATTRIBS = 0x00000040;

    [NativeTypeName("#define ACTRL_WIN_SCREEN ACTRL_PERM_8")]
    public const int ACTRL_WIN_SCREEN = 0x00000080;

    [NativeTypeName("#define ACTRL_WIN_EXIT ACTRL_PERM_9")]
    public const int ACTRL_WIN_EXIT = 0x00000100;

    [NativeTypeName("#define ACTRL_ACCESS_NO_OPTIONS 0x00000000")]
    public const int ACTRL_ACCESS_NO_OPTIONS = 0x00000000;

    [NativeTypeName("#define ACTRL_ACCESS_SUPPORTS_OBJECT_ENTRIES 0x00000001")]
    public const int ACTRL_ACCESS_SUPPORTS_OBJECT_ENTRIES = 0x00000001;
}
