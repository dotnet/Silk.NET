// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

public static partial class IMAGE
{
    [NativeTypeName("#define IMAGE_DOS_SIGNATURE 0x5A4D")]
    public const int IMAGE_DOS_SIGNATURE = 0x5A4D;

    [NativeTypeName("#define IMAGE_OS2_SIGNATURE 0x454E")]
    public const int IMAGE_OS2_SIGNATURE = 0x454E;

    [NativeTypeName("#define IMAGE_OS2_SIGNATURE_LE 0x454C")]
    public const int IMAGE_OS2_SIGNATURE_LE = 0x454C;

    [NativeTypeName("#define IMAGE_VXD_SIGNATURE 0x454C")]
    public const int IMAGE_VXD_SIGNATURE = 0x454C;

    [NativeTypeName("#define IMAGE_NT_SIGNATURE 0x00004550")]
    public const int IMAGE_NT_SIGNATURE = 0x00004550;

    [NativeTypeName("#define IMAGE_SIZEOF_FILE_HEADER 20")]
    public const int IMAGE_SIZEOF_FILE_HEADER = 20;

    [NativeTypeName("#define IMAGE_FILE_RELOCS_STRIPPED 0x0001")]
    public const int IMAGE_FILE_RELOCS_STRIPPED = 0x0001;

    [NativeTypeName("#define IMAGE_FILE_EXECUTABLE_IMAGE 0x0002")]
    public const int IMAGE_FILE_EXECUTABLE_IMAGE = 0x0002;

    [NativeTypeName("#define IMAGE_FILE_LINE_NUMS_STRIPPED 0x0004")]
    public const int IMAGE_FILE_LINE_NUMS_STRIPPED = 0x0004;

    [NativeTypeName("#define IMAGE_FILE_LOCAL_SYMS_STRIPPED 0x0008")]
    public const int IMAGE_FILE_LOCAL_SYMS_STRIPPED = 0x0008;

    [NativeTypeName("#define IMAGE_FILE_AGGRESIVE_WS_TRIM 0x0010")]
    public const int IMAGE_FILE_AGGRESIVE_WS_TRIM = 0x0010;

    [NativeTypeName("#define IMAGE_FILE_LARGE_ADDRESS_AWARE 0x0020")]
    public const int IMAGE_FILE_LARGE_ADDRESS_AWARE = 0x0020;

    [NativeTypeName("#define IMAGE_FILE_BYTES_REVERSED_LO 0x0080")]
    public const int IMAGE_FILE_BYTES_REVERSED_LO = 0x0080;

    [NativeTypeName("#define IMAGE_FILE_32BIT_MACHINE 0x0100")]
    public const int IMAGE_FILE_32BIT_MACHINE = 0x0100;

    [NativeTypeName("#define IMAGE_FILE_DEBUG_STRIPPED 0x0200")]
    public const int IMAGE_FILE_DEBUG_STRIPPED = 0x0200;

    [NativeTypeName("#define IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP 0x0400")]
    public const int IMAGE_FILE_REMOVABLE_RUN_FROM_SWAP = 0x0400;

    [NativeTypeName("#define IMAGE_FILE_NET_RUN_FROM_SWAP 0x0800")]
    public const int IMAGE_FILE_NET_RUN_FROM_SWAP = 0x0800;

    [NativeTypeName("#define IMAGE_FILE_SYSTEM 0x1000")]
    public const int IMAGE_FILE_SYSTEM = 0x1000;

    [NativeTypeName("#define IMAGE_FILE_DLL 0x2000")]
    public const int IMAGE_FILE_DLL = 0x2000;

    [NativeTypeName("#define IMAGE_FILE_UP_SYSTEM_ONLY 0x4000")]
    public const int IMAGE_FILE_UP_SYSTEM_ONLY = 0x4000;

    [NativeTypeName("#define IMAGE_FILE_BYTES_REVERSED_HI 0x8000")]
    public const int IMAGE_FILE_BYTES_REVERSED_HI = 0x8000;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_UNKNOWN 0")]
    public const int IMAGE_FILE_MACHINE_UNKNOWN = 0;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_TARGET_HOST 0x0001")]
    public const int IMAGE_FILE_MACHINE_TARGET_HOST = 0x0001;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_I386 0x014c")]
    public const int IMAGE_FILE_MACHINE_I386 = 0x014c;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_R3000 0x0162")]
    public const int IMAGE_FILE_MACHINE_R3000 = 0x0162;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_R4000 0x0166")]
    public const int IMAGE_FILE_MACHINE_R4000 = 0x0166;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_R10000 0x0168")]
    public const int IMAGE_FILE_MACHINE_R10000 = 0x0168;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_WCEMIPSV2 0x0169")]
    public const int IMAGE_FILE_MACHINE_WCEMIPSV2 = 0x0169;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_ALPHA 0x0184")]
    public const int IMAGE_FILE_MACHINE_ALPHA = 0x0184;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3 0x01a2")]
    public const int IMAGE_FILE_MACHINE_SH3 = 0x01a2;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3DSP 0x01a3")]
    public const int IMAGE_FILE_MACHINE_SH3DSP = 0x01a3;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_SH3E 0x01a4")]
    public const int IMAGE_FILE_MACHINE_SH3E = 0x01a4;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_SH4 0x01a6")]
    public const int IMAGE_FILE_MACHINE_SH4 = 0x01a6;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_SH5 0x01a8")]
    public const int IMAGE_FILE_MACHINE_SH5 = 0x01a8;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_ARM 0x01c0")]
    public const int IMAGE_FILE_MACHINE_ARM = 0x01c0;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_THUMB 0x01c2")]
    public const int IMAGE_FILE_MACHINE_THUMB = 0x01c2;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_ARMNT 0x01c4")]
    public const int IMAGE_FILE_MACHINE_ARMNT = 0x01c4;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_AM33 0x01d3")]
    public const int IMAGE_FILE_MACHINE_AM33 = 0x01d3;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_POWERPC 0x01F0")]
    public const int IMAGE_FILE_MACHINE_POWERPC = 0x01F0;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_POWERPCFP 0x01f1")]
    public const int IMAGE_FILE_MACHINE_POWERPCFP = 0x01f1;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_IA64 0x0200")]
    public const int IMAGE_FILE_MACHINE_IA64 = 0x0200;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPS16 0x0266")]
    public const int IMAGE_FILE_MACHINE_MIPS16 = 0x0266;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_ALPHA64 0x0284")]
    public const int IMAGE_FILE_MACHINE_ALPHA64 = 0x0284;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPSFPU 0x0366")]
    public const int IMAGE_FILE_MACHINE_MIPSFPU = 0x0366;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_MIPSFPU16 0x0466")]
    public const int IMAGE_FILE_MACHINE_MIPSFPU16 = 0x0466;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_AXP64 IMAGE_FILE_MACHINE_ALPHA64")]
    public const int IMAGE_FILE_MACHINE_AXP64 = 0x0284;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_TRICORE 0x0520")]
    public const int IMAGE_FILE_MACHINE_TRICORE = 0x0520;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_CEF 0x0CEF")]
    public const int IMAGE_FILE_MACHINE_CEF = 0x0CEF;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_EBC 0x0EBC")]
    public const int IMAGE_FILE_MACHINE_EBC = 0x0EBC;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_AMD64 0x8664")]
    public const int IMAGE_FILE_MACHINE_AMD64 = 0x8664;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_M32R 0x9041")]
    public const int IMAGE_FILE_MACHINE_M32R = 0x9041;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_ARM64 0xAA64")]
    public const int IMAGE_FILE_MACHINE_ARM64 = 0xAA64;

    [NativeTypeName("#define IMAGE_FILE_MACHINE_CEE 0xC0EE")]
    public const int IMAGE_FILE_MACHINE_CEE = 0xC0EE;

    [NativeTypeName("#define IMAGE_NUMBEROF_DIRECTORY_ENTRIES 16")]
    public const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

    [NativeTypeName("#define IMAGE_NT_OPTIONAL_HDR32_MAGIC 0x10b")]
    public const int IMAGE_NT_OPTIONAL_HDR32_MAGIC = 0x10b;

    [NativeTypeName("#define IMAGE_NT_OPTIONAL_HDR64_MAGIC 0x20b")]
    public const int IMAGE_NT_OPTIONAL_HDR64_MAGIC = 0x20b;

    [NativeTypeName("#define IMAGE_ROM_OPTIONAL_HDR_MAGIC 0x107")]
    public const int IMAGE_ROM_OPTIONAL_HDR_MAGIC = 0x107;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_UNKNOWN 0")]
    public const int IMAGE_SUBSYSTEM_UNKNOWN = 0;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_NATIVE 1")]
    public const int IMAGE_SUBSYSTEM_NATIVE = 1;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_GUI 2")]
    public const int IMAGE_SUBSYSTEM_WINDOWS_GUI = 2;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_CUI 3")]
    public const int IMAGE_SUBSYSTEM_WINDOWS_CUI = 3;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_OS2_CUI 5")]
    public const int IMAGE_SUBSYSTEM_OS2_CUI = 5;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_POSIX_CUI 7")]
    public const int IMAGE_SUBSYSTEM_POSIX_CUI = 7;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_NATIVE_WINDOWS 8")]
    public const int IMAGE_SUBSYSTEM_NATIVE_WINDOWS = 8;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_CE_GUI 9")]
    public const int IMAGE_SUBSYSTEM_WINDOWS_CE_GUI = 9;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_APPLICATION 10")]
    public const int IMAGE_SUBSYSTEM_EFI_APPLICATION = 10;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER 11")]
    public const int IMAGE_SUBSYSTEM_EFI_BOOT_SERVICE_DRIVER = 11;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER 12")]
    public const int IMAGE_SUBSYSTEM_EFI_RUNTIME_DRIVER = 12;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_EFI_ROM 13")]
    public const int IMAGE_SUBSYSTEM_EFI_ROM = 13;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_XBOX 14")]
    public const int IMAGE_SUBSYSTEM_XBOX = 14;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION 16")]
    public const int IMAGE_SUBSYSTEM_WINDOWS_BOOT_APPLICATION = 16;

    [NativeTypeName("#define IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG 17")]
    public const int IMAGE_SUBSYSTEM_XBOX_CODE_CATALOG = 17;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA 0x0020")]
    public const int IMAGE_DLLCHARACTERISTICS_HIGH_ENTROPY_VA = 0x0020;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE 0x0040")]
    public const int IMAGE_DLLCHARACTERISTICS_DYNAMIC_BASE = 0x0040;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY 0x0080")]
    public const int IMAGE_DLLCHARACTERISTICS_FORCE_INTEGRITY = 0x0080;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NX_COMPAT 0x0100")]
    public const int IMAGE_DLLCHARACTERISTICS_NX_COMPAT = 0x0100;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_ISOLATION 0x0200")]
    public const int IMAGE_DLLCHARACTERISTICS_NO_ISOLATION = 0x0200;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_SEH 0x0400")]
    public const int IMAGE_DLLCHARACTERISTICS_NO_SEH = 0x0400;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_NO_BIND 0x0800")]
    public const int IMAGE_DLLCHARACTERISTICS_NO_BIND = 0x0800;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_APPCONTAINER 0x1000")]
    public const int IMAGE_DLLCHARACTERISTICS_APPCONTAINER = 0x1000;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_WDM_DRIVER 0x2000")]
    public const int IMAGE_DLLCHARACTERISTICS_WDM_DRIVER = 0x2000;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_GUARD_CF 0x4000")]
    public const int IMAGE_DLLCHARACTERISTICS_GUARD_CF = 0x4000;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE 0x8000")]
    public const int IMAGE_DLLCHARACTERISTICS_TERMINAL_SERVER_AWARE = 0x8000;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_EXPORT 0")]
    public const int IMAGE_DIRECTORY_ENTRY_EXPORT = 0;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_IMPORT 1")]
    public const int IMAGE_DIRECTORY_ENTRY_IMPORT = 1;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_RESOURCE 2")]
    public const int IMAGE_DIRECTORY_ENTRY_RESOURCE = 2;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_EXCEPTION 3")]
    public const int IMAGE_DIRECTORY_ENTRY_EXCEPTION = 3;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_SECURITY 4")]
    public const int IMAGE_DIRECTORY_ENTRY_SECURITY = 4;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_BASERELOC 5")]
    public const int IMAGE_DIRECTORY_ENTRY_BASERELOC = 5;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_DEBUG 6")]
    public const int IMAGE_DIRECTORY_ENTRY_DEBUG = 6;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_ARCHITECTURE 7")]
    public const int IMAGE_DIRECTORY_ENTRY_ARCHITECTURE = 7;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_GLOBALPTR 8")]
    public const int IMAGE_DIRECTORY_ENTRY_GLOBALPTR = 8;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_TLS 9")]
    public const int IMAGE_DIRECTORY_ENTRY_TLS = 9;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG 10")]
    public const int IMAGE_DIRECTORY_ENTRY_LOAD_CONFIG = 10;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT 11")]
    public const int IMAGE_DIRECTORY_ENTRY_BOUND_IMPORT = 11;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_IAT 12")]
    public const int IMAGE_DIRECTORY_ENTRY_IAT = 12;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT 13")]
    public const int IMAGE_DIRECTORY_ENTRY_DELAY_IMPORT = 13;

    [NativeTypeName("#define IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR 14")]
    public const int IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR = 14;

    [NativeTypeName("#define IMAGE_SIZEOF_SHORT_NAME 8")]
    public const int IMAGE_SIZEOF_SHORT_NAME = 8;

    [NativeTypeName("#define IMAGE_SIZEOF_SECTION_HEADER 40")]
    public const int IMAGE_SIZEOF_SECTION_HEADER = 40;

    [NativeTypeName("#define IMAGE_SCN_TYPE_NO_PAD 0x00000008")]
    public const int IMAGE_SCN_TYPE_NO_PAD = 0x00000008;

    [NativeTypeName("#define IMAGE_SCN_CNT_CODE 0x00000020")]
    public const int IMAGE_SCN_CNT_CODE = 0x00000020;

    [NativeTypeName("#define IMAGE_SCN_CNT_INITIALIZED_DATA 0x00000040")]
    public const int IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040;

    [NativeTypeName("#define IMAGE_SCN_CNT_UNINITIALIZED_DATA 0x00000080")]
    public const int IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080;

    [NativeTypeName("#define IMAGE_SCN_LNK_OTHER 0x00000100")]
    public const int IMAGE_SCN_LNK_OTHER = 0x00000100;

    [NativeTypeName("#define IMAGE_SCN_LNK_INFO 0x00000200")]
    public const int IMAGE_SCN_LNK_INFO = 0x00000200;

    [NativeTypeName("#define IMAGE_SCN_LNK_REMOVE 0x00000800")]
    public const int IMAGE_SCN_LNK_REMOVE = 0x00000800;

    [NativeTypeName("#define IMAGE_SCN_LNK_COMDAT 0x00001000")]
    public const int IMAGE_SCN_LNK_COMDAT = 0x00001000;

    [NativeTypeName("#define IMAGE_SCN_NO_DEFER_SPEC_EXC 0x00004000")]
    public const int IMAGE_SCN_NO_DEFER_SPEC_EXC = 0x00004000;

    [NativeTypeName("#define IMAGE_SCN_GPREL 0x00008000")]
    public const int IMAGE_SCN_GPREL = 0x00008000;

    [NativeTypeName("#define IMAGE_SCN_MEM_FARDATA 0x00008000")]
    public const int IMAGE_SCN_MEM_FARDATA = 0x00008000;

    [NativeTypeName("#define IMAGE_SCN_MEM_PURGEABLE 0x00020000")]
    public const int IMAGE_SCN_MEM_PURGEABLE = 0x00020000;

    [NativeTypeName("#define IMAGE_SCN_MEM_16BIT 0x00020000")]
    public const int IMAGE_SCN_MEM_16BIT = 0x00020000;

    [NativeTypeName("#define IMAGE_SCN_MEM_LOCKED 0x00040000")]
    public const int IMAGE_SCN_MEM_LOCKED = 0x00040000;

    [NativeTypeName("#define IMAGE_SCN_MEM_PRELOAD 0x00080000")]
    public const int IMAGE_SCN_MEM_PRELOAD = 0x00080000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_1BYTES 0x00100000")]
    public const int IMAGE_SCN_ALIGN_1BYTES = 0x00100000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_2BYTES 0x00200000")]
    public const int IMAGE_SCN_ALIGN_2BYTES = 0x00200000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_4BYTES 0x00300000")]
    public const int IMAGE_SCN_ALIGN_4BYTES = 0x00300000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_8BYTES 0x00400000")]
    public const int IMAGE_SCN_ALIGN_8BYTES = 0x00400000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_16BYTES 0x00500000")]
    public const int IMAGE_SCN_ALIGN_16BYTES = 0x00500000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_32BYTES 0x00600000")]
    public const int IMAGE_SCN_ALIGN_32BYTES = 0x00600000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_64BYTES 0x00700000")]
    public const int IMAGE_SCN_ALIGN_64BYTES = 0x00700000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_128BYTES 0x00800000")]
    public const int IMAGE_SCN_ALIGN_128BYTES = 0x00800000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_256BYTES 0x00900000")]
    public const int IMAGE_SCN_ALIGN_256BYTES = 0x00900000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_512BYTES 0x00A00000")]
    public const int IMAGE_SCN_ALIGN_512BYTES = 0x00A00000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_1024BYTES 0x00B00000")]
    public const int IMAGE_SCN_ALIGN_1024BYTES = 0x00B00000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_2048BYTES 0x00C00000")]
    public const int IMAGE_SCN_ALIGN_2048BYTES = 0x00C00000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_4096BYTES 0x00D00000")]
    public const int IMAGE_SCN_ALIGN_4096BYTES = 0x00D00000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_8192BYTES 0x00E00000")]
    public const int IMAGE_SCN_ALIGN_8192BYTES = 0x00E00000;

    [NativeTypeName("#define IMAGE_SCN_ALIGN_MASK 0x00F00000")]
    public const int IMAGE_SCN_ALIGN_MASK = 0x00F00000;

    [NativeTypeName("#define IMAGE_SCN_LNK_NRELOC_OVFL 0x01000000")]
    public const int IMAGE_SCN_LNK_NRELOC_OVFL = 0x01000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_DISCARDABLE 0x02000000")]
    public const int IMAGE_SCN_MEM_DISCARDABLE = 0x02000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_NOT_CACHED 0x04000000")]
    public const int IMAGE_SCN_MEM_NOT_CACHED = 0x04000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_NOT_PAGED 0x08000000")]
    public const int IMAGE_SCN_MEM_NOT_PAGED = 0x08000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_SHARED 0x10000000")]
    public const int IMAGE_SCN_MEM_SHARED = 0x10000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_EXECUTE 0x20000000")]
    public const int IMAGE_SCN_MEM_EXECUTE = 0x20000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_READ 0x40000000")]
    public const int IMAGE_SCN_MEM_READ = 0x40000000;

    [NativeTypeName("#define IMAGE_SCN_MEM_WRITE 0x80000000")]
    public const uint IMAGE_SCN_MEM_WRITE = 0x80000000;

    [NativeTypeName("#define IMAGE_SCN_SCALE_INDEX 0x00000001")]
    public const int IMAGE_SCN_SCALE_INDEX = 0x00000001;

    [NativeTypeName("#define IMAGE_SIZEOF_SYMBOL 18")]
    public const int IMAGE_SIZEOF_SYMBOL = 18;

    [NativeTypeName("#define IMAGE_SYM_UNDEFINED (SHORT)0")]
    public const short IMAGE_SYM_UNDEFINED = (short)(0);

    [NativeTypeName("#define IMAGE_SYM_ABSOLUTE (SHORT)-1")]
    public const short IMAGE_SYM_ABSOLUTE = (short)(-1);

    [NativeTypeName("#define IMAGE_SYM_DEBUG (SHORT)-2")]
    public const short IMAGE_SYM_DEBUG = (short)(-2);

    [NativeTypeName("#define IMAGE_SYM_SECTION_MAX 0xFEFF")]
    public const int IMAGE_SYM_SECTION_MAX = 0xFEFF;

    [NativeTypeName("#define IMAGE_SYM_SECTION_MAX_EX MAXLONG")]
    public const int IMAGE_SYM_SECTION_MAX_EX = 0x7fffffff;

    [NativeTypeName("#define IMAGE_SYM_TYPE_NULL 0x0000")]
    public const int IMAGE_SYM_TYPE_NULL = 0x0000;

    [NativeTypeName("#define IMAGE_SYM_TYPE_VOID 0x0001")]
    public const int IMAGE_SYM_TYPE_VOID = 0x0001;

    [NativeTypeName("#define IMAGE_SYM_TYPE_CHAR 0x0002")]
    public const int IMAGE_SYM_TYPE_CHAR = 0x0002;

    [NativeTypeName("#define IMAGE_SYM_TYPE_SHORT 0x0003")]
    public const int IMAGE_SYM_TYPE_SHORT = 0x0003;

    [NativeTypeName("#define IMAGE_SYM_TYPE_INT 0x0004")]
    public const int IMAGE_SYM_TYPE_INT = 0x0004;

    [NativeTypeName("#define IMAGE_SYM_TYPE_LONG 0x0005")]
    public const int IMAGE_SYM_TYPE_LONG = 0x0005;

    [NativeTypeName("#define IMAGE_SYM_TYPE_FLOAT 0x0006")]
    public const int IMAGE_SYM_TYPE_FLOAT = 0x0006;

    [NativeTypeName("#define IMAGE_SYM_TYPE_DOUBLE 0x0007")]
    public const int IMAGE_SYM_TYPE_DOUBLE = 0x0007;

    [NativeTypeName("#define IMAGE_SYM_TYPE_STRUCT 0x0008")]
    public const int IMAGE_SYM_TYPE_STRUCT = 0x0008;

    [NativeTypeName("#define IMAGE_SYM_TYPE_UNION 0x0009")]
    public const int IMAGE_SYM_TYPE_UNION = 0x0009;

    [NativeTypeName("#define IMAGE_SYM_TYPE_ENUM 0x000A")]
    public const int IMAGE_SYM_TYPE_ENUM = 0x000A;

    [NativeTypeName("#define IMAGE_SYM_TYPE_MOE 0x000B")]
    public const int IMAGE_SYM_TYPE_MOE = 0x000B;

    [NativeTypeName("#define IMAGE_SYM_TYPE_BYTE 0x000C")]
    public const int IMAGE_SYM_TYPE_BYTE = 0x000C;

    [NativeTypeName("#define IMAGE_SYM_TYPE_WORD 0x000D")]
    public const int IMAGE_SYM_TYPE_WORD = 0x000D;

    [NativeTypeName("#define IMAGE_SYM_TYPE_UINT 0x000E")]
    public const int IMAGE_SYM_TYPE_UINT = 0x000E;

    [NativeTypeName("#define IMAGE_SYM_TYPE_DWORD 0x000F")]
    public const int IMAGE_SYM_TYPE_DWORD = 0x000F;

    [NativeTypeName("#define IMAGE_SYM_TYPE_PCODE 0x8000")]
    public const int IMAGE_SYM_TYPE_PCODE = 0x8000;

    [NativeTypeName("#define IMAGE_SYM_DTYPE_NULL 0")]
    public const int IMAGE_SYM_DTYPE_NULL = 0;

    [NativeTypeName("#define IMAGE_SYM_DTYPE_POINTER 1")]
    public const int IMAGE_SYM_DTYPE_POINTER = 1;

    [NativeTypeName("#define IMAGE_SYM_DTYPE_FUNCTION 2")]
    public const int IMAGE_SYM_DTYPE_FUNCTION = 2;

    [NativeTypeName("#define IMAGE_SYM_DTYPE_ARRAY 3")]
    public const int IMAGE_SYM_DTYPE_ARRAY = 3;

    [NativeTypeName("#define IMAGE_SYM_CLASS_END_OF_FUNCTION (BYTE )-1")]
    public const byte IMAGE_SYM_CLASS_END_OF_FUNCTION = unchecked((byte)(-1));

    [NativeTypeName("#define IMAGE_SYM_CLASS_NULL 0x0000")]
    public const int IMAGE_SYM_CLASS_NULL = 0x0000;

    [NativeTypeName("#define IMAGE_SYM_CLASS_AUTOMATIC 0x0001")]
    public const int IMAGE_SYM_CLASS_AUTOMATIC = 0x0001;

    [NativeTypeName("#define IMAGE_SYM_CLASS_EXTERNAL 0x0002")]
    public const int IMAGE_SYM_CLASS_EXTERNAL = 0x0002;

    [NativeTypeName("#define IMAGE_SYM_CLASS_STATIC 0x0003")]
    public const int IMAGE_SYM_CLASS_STATIC = 0x0003;

    [NativeTypeName("#define IMAGE_SYM_CLASS_REGISTER 0x0004")]
    public const int IMAGE_SYM_CLASS_REGISTER = 0x0004;

    [NativeTypeName("#define IMAGE_SYM_CLASS_EXTERNAL_DEF 0x0005")]
    public const int IMAGE_SYM_CLASS_EXTERNAL_DEF = 0x0005;

    [NativeTypeName("#define IMAGE_SYM_CLASS_LABEL 0x0006")]
    public const int IMAGE_SYM_CLASS_LABEL = 0x0006;

    [NativeTypeName("#define IMAGE_SYM_CLASS_UNDEFINED_LABEL 0x0007")]
    public const int IMAGE_SYM_CLASS_UNDEFINED_LABEL = 0x0007;

    [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_STRUCT 0x0008")]
    public const int IMAGE_SYM_CLASS_MEMBER_OF_STRUCT = 0x0008;

    [NativeTypeName("#define IMAGE_SYM_CLASS_ARGUMENT 0x0009")]
    public const int IMAGE_SYM_CLASS_ARGUMENT = 0x0009;

    [NativeTypeName("#define IMAGE_SYM_CLASS_STRUCT_TAG 0x000A")]
    public const int IMAGE_SYM_CLASS_STRUCT_TAG = 0x000A;

    [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_UNION 0x000B")]
    public const int IMAGE_SYM_CLASS_MEMBER_OF_UNION = 0x000B;

    [NativeTypeName("#define IMAGE_SYM_CLASS_UNION_TAG 0x000C")]
    public const int IMAGE_SYM_CLASS_UNION_TAG = 0x000C;

    [NativeTypeName("#define IMAGE_SYM_CLASS_TYPE_DEFINITION 0x000D")]
    public const int IMAGE_SYM_CLASS_TYPE_DEFINITION = 0x000D;

    [NativeTypeName("#define IMAGE_SYM_CLASS_UNDEFINED_STATIC 0x000E")]
    public const int IMAGE_SYM_CLASS_UNDEFINED_STATIC = 0x000E;

    [NativeTypeName("#define IMAGE_SYM_CLASS_ENUM_TAG 0x000F")]
    public const int IMAGE_SYM_CLASS_ENUM_TAG = 0x000F;

    [NativeTypeName("#define IMAGE_SYM_CLASS_MEMBER_OF_ENUM 0x0010")]
    public const int IMAGE_SYM_CLASS_MEMBER_OF_ENUM = 0x0010;

    [NativeTypeName("#define IMAGE_SYM_CLASS_REGISTER_PARAM 0x0011")]
    public const int IMAGE_SYM_CLASS_REGISTER_PARAM = 0x0011;

    [NativeTypeName("#define IMAGE_SYM_CLASS_BIT_FIELD 0x0012")]
    public const int IMAGE_SYM_CLASS_BIT_FIELD = 0x0012;

    [NativeTypeName("#define IMAGE_SYM_CLASS_FAR_EXTERNAL 0x0044")]
    public const int IMAGE_SYM_CLASS_FAR_EXTERNAL = 0x0044;

    [NativeTypeName("#define IMAGE_SYM_CLASS_BLOCK 0x0064")]
    public const int IMAGE_SYM_CLASS_BLOCK = 0x0064;

    [NativeTypeName("#define IMAGE_SYM_CLASS_FUNCTION 0x0065")]
    public const int IMAGE_SYM_CLASS_FUNCTION = 0x0065;

    [NativeTypeName("#define IMAGE_SYM_CLASS_END_OF_STRUCT 0x0066")]
    public const int IMAGE_SYM_CLASS_END_OF_STRUCT = 0x0066;

    [NativeTypeName("#define IMAGE_SYM_CLASS_FILE 0x0067")]
    public const int IMAGE_SYM_CLASS_FILE = 0x0067;

    [NativeTypeName("#define IMAGE_SYM_CLASS_SECTION 0x0068")]
    public const int IMAGE_SYM_CLASS_SECTION = 0x0068;

    [NativeTypeName("#define IMAGE_SYM_CLASS_WEAK_EXTERNAL 0x0069")]
    public const int IMAGE_SYM_CLASS_WEAK_EXTERNAL = 0x0069;

    [NativeTypeName("#define IMAGE_SYM_CLASS_CLR_TOKEN 0x006B")]
    public const int IMAGE_SYM_CLASS_CLR_TOKEN = 0x006B;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_NODUPLICATES 1")]
    public const int IMAGE_COMDAT_SELECT_NODUPLICATES = 1;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_ANY 2")]
    public const int IMAGE_COMDAT_SELECT_ANY = 2;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_SAME_SIZE 3")]
    public const int IMAGE_COMDAT_SELECT_SAME_SIZE = 3;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_EXACT_MATCH 4")]
    public const int IMAGE_COMDAT_SELECT_EXACT_MATCH = 4;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_ASSOCIATIVE 5")]
    public const int IMAGE_COMDAT_SELECT_ASSOCIATIVE = 5;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_LARGEST 6")]
    public const int IMAGE_COMDAT_SELECT_LARGEST = 6;

    [NativeTypeName("#define IMAGE_COMDAT_SELECT_NEWEST 7")]
    public const int IMAGE_COMDAT_SELECT_NEWEST = 7;

    [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY 1")]
    public const int IMAGE_WEAK_EXTERN_SEARCH_NOLIBRARY = 1;

    [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_LIBRARY 2")]
    public const int IMAGE_WEAK_EXTERN_SEARCH_LIBRARY = 2;

    [NativeTypeName("#define IMAGE_WEAK_EXTERN_SEARCH_ALIAS 3")]
    public const int IMAGE_WEAK_EXTERN_SEARCH_ALIAS = 3;

    [NativeTypeName("#define IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY 4")]
    public const int IMAGE_WEAK_EXTERN_ANTI_DEPENDENCY = 4;

    [NativeTypeName("#define IMAGE_REL_I386_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_I386_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_I386_DIR16 0x0001")]
    public const int IMAGE_REL_I386_DIR16 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_I386_REL16 0x0002")]
    public const int IMAGE_REL_I386_REL16 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_I386_DIR32 0x0006")]
    public const int IMAGE_REL_I386_DIR32 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_I386_DIR32NB 0x0007")]
    public const int IMAGE_REL_I386_DIR32NB = 0x0007;

    [NativeTypeName("#define IMAGE_REL_I386_SEG12 0x0009")]
    public const int IMAGE_REL_I386_SEG12 = 0x0009;

    [NativeTypeName("#define IMAGE_REL_I386_SECTION 0x000A")]
    public const int IMAGE_REL_I386_SECTION = 0x000A;

    [NativeTypeName("#define IMAGE_REL_I386_SECREL 0x000B")]
    public const int IMAGE_REL_I386_SECREL = 0x000B;

    [NativeTypeName("#define IMAGE_REL_I386_TOKEN 0x000C")]
    public const int IMAGE_REL_I386_TOKEN = 0x000C;

    [NativeTypeName("#define IMAGE_REL_I386_SECREL7 0x000D")]
    public const int IMAGE_REL_I386_SECREL7 = 0x000D;

    [NativeTypeName("#define IMAGE_REL_I386_REL32 0x0014")]
    public const int IMAGE_REL_I386_REL32 = 0x0014;

    [NativeTypeName("#define IMAGE_REL_MIPS_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_MIPS_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_MIPS_REFHALF 0x0001")]
    public const int IMAGE_REL_MIPS_REFHALF = 0x0001;

    [NativeTypeName("#define IMAGE_REL_MIPS_REFWORD 0x0002")]
    public const int IMAGE_REL_MIPS_REFWORD = 0x0002;

    [NativeTypeName("#define IMAGE_REL_MIPS_JMPADDR 0x0003")]
    public const int IMAGE_REL_MIPS_JMPADDR = 0x0003;

    [NativeTypeName("#define IMAGE_REL_MIPS_REFHI 0x0004")]
    public const int IMAGE_REL_MIPS_REFHI = 0x0004;

    [NativeTypeName("#define IMAGE_REL_MIPS_REFLO 0x0005")]
    public const int IMAGE_REL_MIPS_REFLO = 0x0005;

    [NativeTypeName("#define IMAGE_REL_MIPS_GPREL 0x0006")]
    public const int IMAGE_REL_MIPS_GPREL = 0x0006;

    [NativeTypeName("#define IMAGE_REL_MIPS_LITERAL 0x0007")]
    public const int IMAGE_REL_MIPS_LITERAL = 0x0007;

    [NativeTypeName("#define IMAGE_REL_MIPS_SECTION 0x000A")]
    public const int IMAGE_REL_MIPS_SECTION = 0x000A;

    [NativeTypeName("#define IMAGE_REL_MIPS_SECREL 0x000B")]
    public const int IMAGE_REL_MIPS_SECREL = 0x000B;

    [NativeTypeName("#define IMAGE_REL_MIPS_SECRELLO 0x000C")]
    public const int IMAGE_REL_MIPS_SECRELLO = 0x000C;

    [NativeTypeName("#define IMAGE_REL_MIPS_SECRELHI 0x000D")]
    public const int IMAGE_REL_MIPS_SECRELHI = 0x000D;

    [NativeTypeName("#define IMAGE_REL_MIPS_TOKEN 0x000E")]
    public const int IMAGE_REL_MIPS_TOKEN = 0x000E;

    [NativeTypeName("#define IMAGE_REL_MIPS_JMPADDR16 0x0010")]
    public const int IMAGE_REL_MIPS_JMPADDR16 = 0x0010;

    [NativeTypeName("#define IMAGE_REL_MIPS_REFWORDNB 0x0022")]
    public const int IMAGE_REL_MIPS_REFWORDNB = 0x0022;

    [NativeTypeName("#define IMAGE_REL_MIPS_PAIR 0x0025")]
    public const int IMAGE_REL_MIPS_PAIR = 0x0025;

    [NativeTypeName("#define IMAGE_REL_ALPHA_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_ALPHA_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFLONG 0x0001")]
    public const int IMAGE_REL_ALPHA_REFLONG = 0x0001;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFQUAD 0x0002")]
    public const int IMAGE_REL_ALPHA_REFQUAD = 0x0002;

    [NativeTypeName("#define IMAGE_REL_ALPHA_GPREL32 0x0003")]
    public const int IMAGE_REL_ALPHA_GPREL32 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_ALPHA_LITERAL 0x0004")]
    public const int IMAGE_REL_ALPHA_LITERAL = 0x0004;

    [NativeTypeName("#define IMAGE_REL_ALPHA_LITUSE 0x0005")]
    public const int IMAGE_REL_ALPHA_LITUSE = 0x0005;

    [NativeTypeName("#define IMAGE_REL_ALPHA_GPDISP 0x0006")]
    public const int IMAGE_REL_ALPHA_GPDISP = 0x0006;

    [NativeTypeName("#define IMAGE_REL_ALPHA_BRADDR 0x0007")]
    public const int IMAGE_REL_ALPHA_BRADDR = 0x0007;

    [NativeTypeName("#define IMAGE_REL_ALPHA_HINT 0x0008")]
    public const int IMAGE_REL_ALPHA_HINT = 0x0008;

    [NativeTypeName("#define IMAGE_REL_ALPHA_INLINE_REFLONG 0x0009")]
    public const int IMAGE_REL_ALPHA_INLINE_REFLONG = 0x0009;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFHI 0x000A")]
    public const int IMAGE_REL_ALPHA_REFHI = 0x000A;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFLO 0x000B")]
    public const int IMAGE_REL_ALPHA_REFLO = 0x000B;

    [NativeTypeName("#define IMAGE_REL_ALPHA_PAIR 0x000C")]
    public const int IMAGE_REL_ALPHA_PAIR = 0x000C;

    [NativeTypeName("#define IMAGE_REL_ALPHA_MATCH 0x000D")]
    public const int IMAGE_REL_ALPHA_MATCH = 0x000D;

    [NativeTypeName("#define IMAGE_REL_ALPHA_SECTION 0x000E")]
    public const int IMAGE_REL_ALPHA_SECTION = 0x000E;

    [NativeTypeName("#define IMAGE_REL_ALPHA_SECREL 0x000F")]
    public const int IMAGE_REL_ALPHA_SECREL = 0x000F;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFLONGNB 0x0010")]
    public const int IMAGE_REL_ALPHA_REFLONGNB = 0x0010;

    [NativeTypeName("#define IMAGE_REL_ALPHA_SECRELLO 0x0011")]
    public const int IMAGE_REL_ALPHA_SECRELLO = 0x0011;

    [NativeTypeName("#define IMAGE_REL_ALPHA_SECRELHI 0x0012")]
    public const int IMAGE_REL_ALPHA_SECRELHI = 0x0012;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ3 0x0013")]
    public const int IMAGE_REL_ALPHA_REFQ3 = 0x0013;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ2 0x0014")]
    public const int IMAGE_REL_ALPHA_REFQ2 = 0x0014;

    [NativeTypeName("#define IMAGE_REL_ALPHA_REFQ1 0x0015")]
    public const int IMAGE_REL_ALPHA_REFQ1 = 0x0015;

    [NativeTypeName("#define IMAGE_REL_ALPHA_GPRELLO 0x0016")]
    public const int IMAGE_REL_ALPHA_GPRELLO = 0x0016;

    [NativeTypeName("#define IMAGE_REL_ALPHA_GPRELHI 0x0017")]
    public const int IMAGE_REL_ALPHA_GPRELHI = 0x0017;

    [NativeTypeName("#define IMAGE_REL_PPC_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_PPC_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR64 0x0001")]
    public const int IMAGE_REL_PPC_ADDR64 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR32 0x0002")]
    public const int IMAGE_REL_PPC_ADDR32 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR24 0x0003")]
    public const int IMAGE_REL_PPC_ADDR24 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR16 0x0004")]
    public const int IMAGE_REL_PPC_ADDR16 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR14 0x0005")]
    public const int IMAGE_REL_PPC_ADDR14 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_PPC_REL24 0x0006")]
    public const int IMAGE_REL_PPC_REL24 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_PPC_REL14 0x0007")]
    public const int IMAGE_REL_PPC_REL14 = 0x0007;

    [NativeTypeName("#define IMAGE_REL_PPC_TOCREL16 0x0008")]
    public const int IMAGE_REL_PPC_TOCREL16 = 0x0008;

    [NativeTypeName("#define IMAGE_REL_PPC_TOCREL14 0x0009")]
    public const int IMAGE_REL_PPC_TOCREL14 = 0x0009;

    [NativeTypeName("#define IMAGE_REL_PPC_ADDR32NB 0x000A")]
    public const int IMAGE_REL_PPC_ADDR32NB = 0x000A;

    [NativeTypeName("#define IMAGE_REL_PPC_SECREL 0x000B")]
    public const int IMAGE_REL_PPC_SECREL = 0x000B;

    [NativeTypeName("#define IMAGE_REL_PPC_SECTION 0x000C")]
    public const int IMAGE_REL_PPC_SECTION = 0x000C;

    [NativeTypeName("#define IMAGE_REL_PPC_IFGLUE 0x000D")]
    public const int IMAGE_REL_PPC_IFGLUE = 0x000D;

    [NativeTypeName("#define IMAGE_REL_PPC_IMGLUE 0x000E")]
    public const int IMAGE_REL_PPC_IMGLUE = 0x000E;

    [NativeTypeName("#define IMAGE_REL_PPC_SECREL16 0x000F")]
    public const int IMAGE_REL_PPC_SECREL16 = 0x000F;

    [NativeTypeName("#define IMAGE_REL_PPC_REFHI 0x0010")]
    public const int IMAGE_REL_PPC_REFHI = 0x0010;

    [NativeTypeName("#define IMAGE_REL_PPC_REFLO 0x0011")]
    public const int IMAGE_REL_PPC_REFLO = 0x0011;

    [NativeTypeName("#define IMAGE_REL_PPC_PAIR 0x0012")]
    public const int IMAGE_REL_PPC_PAIR = 0x0012;

    [NativeTypeName("#define IMAGE_REL_PPC_SECRELLO 0x0013")]
    public const int IMAGE_REL_PPC_SECRELLO = 0x0013;

    [NativeTypeName("#define IMAGE_REL_PPC_SECRELHI 0x0014")]
    public const int IMAGE_REL_PPC_SECRELHI = 0x0014;

    [NativeTypeName("#define IMAGE_REL_PPC_GPREL 0x0015")]
    public const int IMAGE_REL_PPC_GPREL = 0x0015;

    [NativeTypeName("#define IMAGE_REL_PPC_TOKEN 0x0016")]
    public const int IMAGE_REL_PPC_TOKEN = 0x0016;

    [NativeTypeName("#define IMAGE_REL_PPC_TYPEMASK 0x00FF")]
    public const int IMAGE_REL_PPC_TYPEMASK = 0x00FF;

    [NativeTypeName("#define IMAGE_REL_PPC_NEG 0x0100")]
    public const int IMAGE_REL_PPC_NEG = 0x0100;

    [NativeTypeName("#define IMAGE_REL_PPC_BRTAKEN 0x0200")]
    public const int IMAGE_REL_PPC_BRTAKEN = 0x0200;

    [NativeTypeName("#define IMAGE_REL_PPC_BRNTAKEN 0x0400")]
    public const int IMAGE_REL_PPC_BRNTAKEN = 0x0400;

    [NativeTypeName("#define IMAGE_REL_PPC_TOCDEFN 0x0800")]
    public const int IMAGE_REL_PPC_TOCDEFN = 0x0800;

    [NativeTypeName("#define IMAGE_REL_SH3_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_SH3_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT16 0x0001")]
    public const int IMAGE_REL_SH3_DIRECT16 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT32 0x0002")]
    public const int IMAGE_REL_SH3_DIRECT32 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8 0x0003")]
    public const int IMAGE_REL_SH3_DIRECT8 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8_WORD 0x0004")]
    public const int IMAGE_REL_SH3_DIRECT8_WORD = 0x0004;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT8_LONG 0x0005")]
    public const int IMAGE_REL_SH3_DIRECT8_LONG = 0x0005;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4 0x0006")]
    public const int IMAGE_REL_SH3_DIRECT4 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4_WORD 0x0007")]
    public const int IMAGE_REL_SH3_DIRECT4_WORD = 0x0007;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT4_LONG 0x0008")]
    public const int IMAGE_REL_SH3_DIRECT4_LONG = 0x0008;

    [NativeTypeName("#define IMAGE_REL_SH3_PCREL8_WORD 0x0009")]
    public const int IMAGE_REL_SH3_PCREL8_WORD = 0x0009;

    [NativeTypeName("#define IMAGE_REL_SH3_PCREL8_LONG 0x000A")]
    public const int IMAGE_REL_SH3_PCREL8_LONG = 0x000A;

    [NativeTypeName("#define IMAGE_REL_SH3_PCREL12_WORD 0x000B")]
    public const int IMAGE_REL_SH3_PCREL12_WORD = 0x000B;

    [NativeTypeName("#define IMAGE_REL_SH3_STARTOF_SECTION 0x000C")]
    public const int IMAGE_REL_SH3_STARTOF_SECTION = 0x000C;

    [NativeTypeName("#define IMAGE_REL_SH3_SIZEOF_SECTION 0x000D")]
    public const int IMAGE_REL_SH3_SIZEOF_SECTION = 0x000D;

    [NativeTypeName("#define IMAGE_REL_SH3_SECTION 0x000E")]
    public const int IMAGE_REL_SH3_SECTION = 0x000E;

    [NativeTypeName("#define IMAGE_REL_SH3_SECREL 0x000F")]
    public const int IMAGE_REL_SH3_SECREL = 0x000F;

    [NativeTypeName("#define IMAGE_REL_SH3_DIRECT32_NB 0x0010")]
    public const int IMAGE_REL_SH3_DIRECT32_NB = 0x0010;

    [NativeTypeName("#define IMAGE_REL_SH3_GPREL4_LONG 0x0011")]
    public const int IMAGE_REL_SH3_GPREL4_LONG = 0x0011;

    [NativeTypeName("#define IMAGE_REL_SH3_TOKEN 0x0012")]
    public const int IMAGE_REL_SH3_TOKEN = 0x0012;

    [NativeTypeName("#define IMAGE_REL_SHM_PCRELPT 0x0013")]
    public const int IMAGE_REL_SHM_PCRELPT = 0x0013;

    [NativeTypeName("#define IMAGE_REL_SHM_REFLO 0x0014")]
    public const int IMAGE_REL_SHM_REFLO = 0x0014;

    [NativeTypeName("#define IMAGE_REL_SHM_REFHALF 0x0015")]
    public const int IMAGE_REL_SHM_REFHALF = 0x0015;

    [NativeTypeName("#define IMAGE_REL_SHM_RELLO 0x0016")]
    public const int IMAGE_REL_SHM_RELLO = 0x0016;

    [NativeTypeName("#define IMAGE_REL_SHM_RELHALF 0x0017")]
    public const int IMAGE_REL_SHM_RELHALF = 0x0017;

    [NativeTypeName("#define IMAGE_REL_SHM_PAIR 0x0018")]
    public const int IMAGE_REL_SHM_PAIR = 0x0018;

    [NativeTypeName("#define IMAGE_REL_SH_NOMODE 0x8000")]
    public const int IMAGE_REL_SH_NOMODE = 0x8000;

    [NativeTypeName("#define IMAGE_REL_ARM_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_ARM_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_ARM_ADDR32 0x0001")]
    public const int IMAGE_REL_ARM_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_ARM_ADDR32NB 0x0002")]
    public const int IMAGE_REL_ARM_ADDR32NB = 0x0002;

    [NativeTypeName("#define IMAGE_REL_ARM_BRANCH24 0x0003")]
    public const int IMAGE_REL_ARM_BRANCH24 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_ARM_BRANCH11 0x0004")]
    public const int IMAGE_REL_ARM_BRANCH11 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_ARM_TOKEN 0x0005")]
    public const int IMAGE_REL_ARM_TOKEN = 0x0005;

    [NativeTypeName("#define IMAGE_REL_ARM_GPREL12 0x0006")]
    public const int IMAGE_REL_ARM_GPREL12 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_ARM_GPREL7 0x0007")]
    public const int IMAGE_REL_ARM_GPREL7 = 0x0007;

    [NativeTypeName("#define IMAGE_REL_ARM_BLX24 0x0008")]
    public const int IMAGE_REL_ARM_BLX24 = 0x0008;

    [NativeTypeName("#define IMAGE_REL_ARM_BLX11 0x0009")]
    public const int IMAGE_REL_ARM_BLX11 = 0x0009;

    [NativeTypeName("#define IMAGE_REL_ARM_SECTION 0x000E")]
    public const int IMAGE_REL_ARM_SECTION = 0x000E;

    [NativeTypeName("#define IMAGE_REL_ARM_SECREL 0x000F")]
    public const int IMAGE_REL_ARM_SECREL = 0x000F;

    [NativeTypeName("#define IMAGE_REL_ARM_MOV32A 0x0010")]
    public const int IMAGE_REL_ARM_MOV32A = 0x0010;

    [NativeTypeName("#define IMAGE_REL_ARM_MOV32 0x0010")]
    public const int IMAGE_REL_ARM_MOV32 = 0x0010;

    [NativeTypeName("#define IMAGE_REL_ARM_MOV32T 0x0011")]
    public const int IMAGE_REL_ARM_MOV32T = 0x0011;

    [NativeTypeName("#define IMAGE_REL_THUMB_MOV32 0x0011")]
    public const int IMAGE_REL_THUMB_MOV32 = 0x0011;

    [NativeTypeName("#define IMAGE_REL_ARM_BRANCH20T 0x0012")]
    public const int IMAGE_REL_ARM_BRANCH20T = 0x0012;

    [NativeTypeName("#define IMAGE_REL_THUMB_BRANCH20 0x0012")]
    public const int IMAGE_REL_THUMB_BRANCH20 = 0x0012;

    [NativeTypeName("#define IMAGE_REL_ARM_BRANCH24T 0x0014")]
    public const int IMAGE_REL_ARM_BRANCH24T = 0x0014;

    [NativeTypeName("#define IMAGE_REL_THUMB_BRANCH24 0x0014")]
    public const int IMAGE_REL_THUMB_BRANCH24 = 0x0014;

    [NativeTypeName("#define IMAGE_REL_ARM_BLX23T 0x0015")]
    public const int IMAGE_REL_ARM_BLX23T = 0x0015;

    [NativeTypeName("#define IMAGE_REL_THUMB_BLX23 0x0015")]
    public const int IMAGE_REL_THUMB_BLX23 = 0x0015;

    [NativeTypeName("#define IMAGE_REL_AM_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_AM_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_AM_ADDR32 0x0001")]
    public const int IMAGE_REL_AM_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_AM_ADDR32NB 0x0002")]
    public const int IMAGE_REL_AM_ADDR32NB = 0x0002;

    [NativeTypeName("#define IMAGE_REL_AM_CALL32 0x0003")]
    public const int IMAGE_REL_AM_CALL32 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_AM_FUNCINFO 0x0004")]
    public const int IMAGE_REL_AM_FUNCINFO = 0x0004;

    [NativeTypeName("#define IMAGE_REL_AM_REL32_1 0x0005")]
    public const int IMAGE_REL_AM_REL32_1 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_AM_REL32_2 0x0006")]
    public const int IMAGE_REL_AM_REL32_2 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_AM_SECREL 0x0007")]
    public const int IMAGE_REL_AM_SECREL = 0x0007;

    [NativeTypeName("#define IMAGE_REL_AM_SECTION 0x0008")]
    public const int IMAGE_REL_AM_SECTION = 0x0008;

    [NativeTypeName("#define IMAGE_REL_AM_TOKEN 0x0009")]
    public const int IMAGE_REL_AM_TOKEN = 0x0009;

    [NativeTypeName("#define IMAGE_REL_ARM64_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_ARM64_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_ARM64_ADDR32 0x0001")]
    public const int IMAGE_REL_ARM64_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_ARM64_ADDR32NB 0x0002")]
    public const int IMAGE_REL_ARM64_ADDR32NB = 0x0002;

    [NativeTypeName("#define IMAGE_REL_ARM64_BRANCH26 0x0003")]
    public const int IMAGE_REL_ARM64_BRANCH26 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_ARM64_PAGEBASE_REL21 0x0004")]
    public const int IMAGE_REL_ARM64_PAGEBASE_REL21 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_ARM64_REL21 0x0005")]
    public const int IMAGE_REL_ARM64_REL21 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_ARM64_PAGEOFFSET_12A 0x0006")]
    public const int IMAGE_REL_ARM64_PAGEOFFSET_12A = 0x0006;

    [NativeTypeName("#define IMAGE_REL_ARM64_PAGEOFFSET_12L 0x0007")]
    public const int IMAGE_REL_ARM64_PAGEOFFSET_12L = 0x0007;

    [NativeTypeName("#define IMAGE_REL_ARM64_SECREL 0x0008")]
    public const int IMAGE_REL_ARM64_SECREL = 0x0008;

    [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_LOW12A 0x0009")]
    public const int IMAGE_REL_ARM64_SECREL_LOW12A = 0x0009;

    [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_HIGH12A 0x000A")]
    public const int IMAGE_REL_ARM64_SECREL_HIGH12A = 0x000A;

    [NativeTypeName("#define IMAGE_REL_ARM64_SECREL_LOW12L 0x000B")]
    public const int IMAGE_REL_ARM64_SECREL_LOW12L = 0x000B;

    [NativeTypeName("#define IMAGE_REL_ARM64_TOKEN 0x000C")]
    public const int IMAGE_REL_ARM64_TOKEN = 0x000C;

    [NativeTypeName("#define IMAGE_REL_ARM64_SECTION 0x000D")]
    public const int IMAGE_REL_ARM64_SECTION = 0x000D;

    [NativeTypeName("#define IMAGE_REL_ARM64_ADDR64 0x000E")]
    public const int IMAGE_REL_ARM64_ADDR64 = 0x000E;

    [NativeTypeName("#define IMAGE_REL_ARM64_BRANCH19 0x000F")]
    public const int IMAGE_REL_ARM64_BRANCH19 = 0x000F;

    [NativeTypeName("#define IMAGE_REL_AMD64_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_AMD64_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_AMD64_ADDR64 0x0001")]
    public const int IMAGE_REL_AMD64_ADDR64 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_AMD64_ADDR32 0x0002")]
    public const int IMAGE_REL_AMD64_ADDR32 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_AMD64_ADDR32NB 0x0003")]
    public const int IMAGE_REL_AMD64_ADDR32NB = 0x0003;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32 0x0004")]
    public const int IMAGE_REL_AMD64_REL32 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32_1 0x0005")]
    public const int IMAGE_REL_AMD64_REL32_1 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32_2 0x0006")]
    public const int IMAGE_REL_AMD64_REL32_2 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32_3 0x0007")]
    public const int IMAGE_REL_AMD64_REL32_3 = 0x0007;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32_4 0x0008")]
    public const int IMAGE_REL_AMD64_REL32_4 = 0x0008;

    [NativeTypeName("#define IMAGE_REL_AMD64_REL32_5 0x0009")]
    public const int IMAGE_REL_AMD64_REL32_5 = 0x0009;

    [NativeTypeName("#define IMAGE_REL_AMD64_SECTION 0x000A")]
    public const int IMAGE_REL_AMD64_SECTION = 0x000A;

    [NativeTypeName("#define IMAGE_REL_AMD64_SECREL 0x000B")]
    public const int IMAGE_REL_AMD64_SECREL = 0x000B;

    [NativeTypeName("#define IMAGE_REL_AMD64_SECREL7 0x000C")]
    public const int IMAGE_REL_AMD64_SECREL7 = 0x000C;

    [NativeTypeName("#define IMAGE_REL_AMD64_TOKEN 0x000D")]
    public const int IMAGE_REL_AMD64_TOKEN = 0x000D;

    [NativeTypeName("#define IMAGE_REL_AMD64_SREL32 0x000E")]
    public const int IMAGE_REL_AMD64_SREL32 = 0x000E;

    [NativeTypeName("#define IMAGE_REL_AMD64_PAIR 0x000F")]
    public const int IMAGE_REL_AMD64_PAIR = 0x000F;

    [NativeTypeName("#define IMAGE_REL_AMD64_SSPAN32 0x0010")]
    public const int IMAGE_REL_AMD64_SSPAN32 = 0x0010;

    [NativeTypeName("#define IMAGE_REL_AMD64_EHANDLER 0x0011")]
    public const int IMAGE_REL_AMD64_EHANDLER = 0x0011;

    [NativeTypeName("#define IMAGE_REL_AMD64_IMPORT_BR 0x0012")]
    public const int IMAGE_REL_AMD64_IMPORT_BR = 0x0012;

    [NativeTypeName("#define IMAGE_REL_AMD64_IMPORT_CALL 0x0013")]
    public const int IMAGE_REL_AMD64_IMPORT_CALL = 0x0013;

    [NativeTypeName("#define IMAGE_REL_AMD64_CFG_BR 0x0014")]
    public const int IMAGE_REL_AMD64_CFG_BR = 0x0014;

    [NativeTypeName("#define IMAGE_REL_AMD64_CFG_BR_REX 0x0015")]
    public const int IMAGE_REL_AMD64_CFG_BR_REX = 0x0015;

    [NativeTypeName("#define IMAGE_REL_AMD64_CFG_CALL 0x0016")]
    public const int IMAGE_REL_AMD64_CFG_CALL = 0x0016;

    [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR 0x0017")]
    public const int IMAGE_REL_AMD64_INDIR_BR = 0x0017;

    [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_REX 0x0018")]
    public const int IMAGE_REL_AMD64_INDIR_BR_REX = 0x0018;

    [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_CALL 0x0019")]
    public const int IMAGE_REL_AMD64_INDIR_CALL = 0x0019;

    [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST 0x0020")]
    public const int IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_FIRST = 0x0020;

    [NativeTypeName("#define IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST 0x002F")]
    public const int IMAGE_REL_AMD64_INDIR_BR_SWITCHTABLE_LAST = 0x002F;

    [NativeTypeName("#define IMAGE_REL_IA64_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_IA64_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_IA64_IMM14 0x0001")]
    public const int IMAGE_REL_IA64_IMM14 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_IA64_IMM22 0x0002")]
    public const int IMAGE_REL_IA64_IMM22 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_IA64_IMM64 0x0003")]
    public const int IMAGE_REL_IA64_IMM64 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_IA64_DIR32 0x0004")]
    public const int IMAGE_REL_IA64_DIR32 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_IA64_DIR64 0x0005")]
    public const int IMAGE_REL_IA64_DIR64 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL21B 0x0006")]
    public const int IMAGE_REL_IA64_PCREL21B = 0x0006;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL21M 0x0007")]
    public const int IMAGE_REL_IA64_PCREL21M = 0x0007;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL21F 0x0008")]
    public const int IMAGE_REL_IA64_PCREL21F = 0x0008;

    [NativeTypeName("#define IMAGE_REL_IA64_GPREL22 0x0009")]
    public const int IMAGE_REL_IA64_GPREL22 = 0x0009;

    [NativeTypeName("#define IMAGE_REL_IA64_LTOFF22 0x000A")]
    public const int IMAGE_REL_IA64_LTOFF22 = 0x000A;

    [NativeTypeName("#define IMAGE_REL_IA64_SECTION 0x000B")]
    public const int IMAGE_REL_IA64_SECTION = 0x000B;

    [NativeTypeName("#define IMAGE_REL_IA64_SECREL22 0x000C")]
    public const int IMAGE_REL_IA64_SECREL22 = 0x000C;

    [NativeTypeName("#define IMAGE_REL_IA64_SECREL64I 0x000D")]
    public const int IMAGE_REL_IA64_SECREL64I = 0x000D;

    [NativeTypeName("#define IMAGE_REL_IA64_SECREL32 0x000E")]
    public const int IMAGE_REL_IA64_SECREL32 = 0x000E;

    [NativeTypeName("#define IMAGE_REL_IA64_DIR32NB 0x0010")]
    public const int IMAGE_REL_IA64_DIR32NB = 0x0010;

    [NativeTypeName("#define IMAGE_REL_IA64_SREL14 0x0011")]
    public const int IMAGE_REL_IA64_SREL14 = 0x0011;

    [NativeTypeName("#define IMAGE_REL_IA64_SREL22 0x0012")]
    public const int IMAGE_REL_IA64_SREL22 = 0x0012;

    [NativeTypeName("#define IMAGE_REL_IA64_SREL32 0x0013")]
    public const int IMAGE_REL_IA64_SREL32 = 0x0013;

    [NativeTypeName("#define IMAGE_REL_IA64_UREL32 0x0014")]
    public const int IMAGE_REL_IA64_UREL32 = 0x0014;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL60X 0x0015")]
    public const int IMAGE_REL_IA64_PCREL60X = 0x0015;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL60B 0x0016")]
    public const int IMAGE_REL_IA64_PCREL60B = 0x0016;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL60F 0x0017")]
    public const int IMAGE_REL_IA64_PCREL60F = 0x0017;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL60I 0x0018")]
    public const int IMAGE_REL_IA64_PCREL60I = 0x0018;

    [NativeTypeName("#define IMAGE_REL_IA64_PCREL60M 0x0019")]
    public const int IMAGE_REL_IA64_PCREL60M = 0x0019;

    [NativeTypeName("#define IMAGE_REL_IA64_IMMGPREL64 0x001A")]
    public const int IMAGE_REL_IA64_IMMGPREL64 = 0x001A;

    [NativeTypeName("#define IMAGE_REL_IA64_TOKEN 0x001B")]
    public const int IMAGE_REL_IA64_TOKEN = 0x001B;

    [NativeTypeName("#define IMAGE_REL_IA64_GPREL32 0x001C")]
    public const int IMAGE_REL_IA64_GPREL32 = 0x001C;

    [NativeTypeName("#define IMAGE_REL_IA64_ADDEND 0x001F")]
    public const int IMAGE_REL_IA64_ADDEND = 0x001F;

    [NativeTypeName("#define IMAGE_REL_CEF_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_CEF_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_CEF_ADDR32 0x0001")]
    public const int IMAGE_REL_CEF_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_CEF_ADDR64 0x0002")]
    public const int IMAGE_REL_CEF_ADDR64 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_CEF_ADDR32NB 0x0003")]
    public const int IMAGE_REL_CEF_ADDR32NB = 0x0003;

    [NativeTypeName("#define IMAGE_REL_CEF_SECTION 0x0004")]
    public const int IMAGE_REL_CEF_SECTION = 0x0004;

    [NativeTypeName("#define IMAGE_REL_CEF_SECREL 0x0005")]
    public const int IMAGE_REL_CEF_SECREL = 0x0005;

    [NativeTypeName("#define IMAGE_REL_CEF_TOKEN 0x0006")]
    public const int IMAGE_REL_CEF_TOKEN = 0x0006;

    [NativeTypeName("#define IMAGE_REL_CEE_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_CEE_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_CEE_ADDR32 0x0001")]
    public const int IMAGE_REL_CEE_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_CEE_ADDR64 0x0002")]
    public const int IMAGE_REL_CEE_ADDR64 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_CEE_ADDR32NB 0x0003")]
    public const int IMAGE_REL_CEE_ADDR32NB = 0x0003;

    [NativeTypeName("#define IMAGE_REL_CEE_SECTION 0x0004")]
    public const int IMAGE_REL_CEE_SECTION = 0x0004;

    [NativeTypeName("#define IMAGE_REL_CEE_SECREL 0x0005")]
    public const int IMAGE_REL_CEE_SECREL = 0x0005;

    [NativeTypeName("#define IMAGE_REL_CEE_TOKEN 0x0006")]
    public const int IMAGE_REL_CEE_TOKEN = 0x0006;

    [NativeTypeName("#define IMAGE_REL_M32R_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_M32R_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_M32R_ADDR32 0x0001")]
    public const int IMAGE_REL_M32R_ADDR32 = 0x0001;

    [NativeTypeName("#define IMAGE_REL_M32R_ADDR32NB 0x0002")]
    public const int IMAGE_REL_M32R_ADDR32NB = 0x0002;

    [NativeTypeName("#define IMAGE_REL_M32R_ADDR24 0x0003")]
    public const int IMAGE_REL_M32R_ADDR24 = 0x0003;

    [NativeTypeName("#define IMAGE_REL_M32R_GPREL16 0x0004")]
    public const int IMAGE_REL_M32R_GPREL16 = 0x0004;

    [NativeTypeName("#define IMAGE_REL_M32R_PCREL24 0x0005")]
    public const int IMAGE_REL_M32R_PCREL24 = 0x0005;

    [NativeTypeName("#define IMAGE_REL_M32R_PCREL16 0x0006")]
    public const int IMAGE_REL_M32R_PCREL16 = 0x0006;

    [NativeTypeName("#define IMAGE_REL_M32R_PCREL8 0x0007")]
    public const int IMAGE_REL_M32R_PCREL8 = 0x0007;

    [NativeTypeName("#define IMAGE_REL_M32R_REFHALF 0x0008")]
    public const int IMAGE_REL_M32R_REFHALF = 0x0008;

    [NativeTypeName("#define IMAGE_REL_M32R_REFHI 0x0009")]
    public const int IMAGE_REL_M32R_REFHI = 0x0009;

    [NativeTypeName("#define IMAGE_REL_M32R_REFLO 0x000A")]
    public const int IMAGE_REL_M32R_REFLO = 0x000A;

    [NativeTypeName("#define IMAGE_REL_M32R_PAIR 0x000B")]
    public const int IMAGE_REL_M32R_PAIR = 0x000B;

    [NativeTypeName("#define IMAGE_REL_M32R_SECTION 0x000C")]
    public const int IMAGE_REL_M32R_SECTION = 0x000C;

    [NativeTypeName("#define IMAGE_REL_M32R_SECREL32 0x000D")]
    public const int IMAGE_REL_M32R_SECREL32 = 0x000D;

    [NativeTypeName("#define IMAGE_REL_M32R_TOKEN 0x000E")]
    public const int IMAGE_REL_M32R_TOKEN = 0x000E;

    [NativeTypeName("#define IMAGE_REL_EBC_ABSOLUTE 0x0000")]
    public const int IMAGE_REL_EBC_ABSOLUTE = 0x0000;

    [NativeTypeName("#define IMAGE_REL_EBC_ADDR32NB 0x0001")]
    public const int IMAGE_REL_EBC_ADDR32NB = 0x0001;

    [NativeTypeName("#define IMAGE_REL_EBC_REL32 0x0002")]
    public const int IMAGE_REL_EBC_REL32 = 0x0002;

    [NativeTypeName("#define IMAGE_REL_EBC_SECTION 0x0003")]
    public const int IMAGE_REL_EBC_SECTION = 0x0003;

    [NativeTypeName("#define IMAGE_REL_EBC_SECREL 0x0004")]
    public const int IMAGE_REL_EBC_SECREL = 0x0004;

    [NativeTypeName("#define IMAGE_REL_BASED_ABSOLUTE 0")]
    public const int IMAGE_REL_BASED_ABSOLUTE = 0;

    [NativeTypeName("#define IMAGE_REL_BASED_HIGH 1")]
    public const int IMAGE_REL_BASED_HIGH = 1;

    [NativeTypeName("#define IMAGE_REL_BASED_LOW 2")]
    public const int IMAGE_REL_BASED_LOW = 2;

    [NativeTypeName("#define IMAGE_REL_BASED_HIGHLOW 3")]
    public const int IMAGE_REL_BASED_HIGHLOW = 3;

    [NativeTypeName("#define IMAGE_REL_BASED_HIGHADJ 4")]
    public const int IMAGE_REL_BASED_HIGHADJ = 4;

    [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_5 5")]
    public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_5 = 5;

    [NativeTypeName("#define IMAGE_REL_BASED_RESERVED 6")]
    public const int IMAGE_REL_BASED_RESERVED = 6;

    [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_7 7")]
    public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_7 = 7;

    [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_8 8")]
    public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_8 = 8;

    [NativeTypeName("#define IMAGE_REL_BASED_MACHINE_SPECIFIC_9 9")]
    public const int IMAGE_REL_BASED_MACHINE_SPECIFIC_9 = 9;

    [NativeTypeName("#define IMAGE_REL_BASED_DIR64 10")]
    public const int IMAGE_REL_BASED_DIR64 = 10;

    [NativeTypeName("#define IMAGE_REL_BASED_IA64_IMM64 9")]
    public const int IMAGE_REL_BASED_IA64_IMM64 = 9;

    [NativeTypeName("#define IMAGE_REL_BASED_MIPS_JMPADDR 5")]
    public const int IMAGE_REL_BASED_MIPS_JMPADDR = 5;

    [NativeTypeName("#define IMAGE_REL_BASED_MIPS_JMPADDR16 9")]
    public const int IMAGE_REL_BASED_MIPS_JMPADDR16 = 9;

    [NativeTypeName("#define IMAGE_REL_BASED_ARM_MOV32 5")]
    public const int IMAGE_REL_BASED_ARM_MOV32 = 5;

    [NativeTypeName("#define IMAGE_REL_BASED_THUMB_MOV32 7")]
    public const int IMAGE_REL_BASED_THUMB_MOV32 = 7;

    [NativeTypeName("#define IMAGE_ARCHIVE_START_SIZE 8")]
    public const int IMAGE_ARCHIVE_START_SIZE = 8;

    [NativeTypeName("#define IMAGE_ARCHIVE_START \"!<arch>\\n\"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_START => "!<arch>\n"u8;

    [NativeTypeName("#define IMAGE_ARCHIVE_END \"`\\n\"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_END => "`\n"u8;

    [NativeTypeName("#define IMAGE_ARCHIVE_PAD \"\\n\"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_PAD => "\n"u8;

    [NativeTypeName("#define IMAGE_ARCHIVE_LINKER_MEMBER \"/               \"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_LINKER_MEMBER => "/               "u8;

    [NativeTypeName("#define IMAGE_ARCHIVE_LONGNAMES_MEMBER \"//              \"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_LONGNAMES_MEMBER => "//              "u8;

    [NativeTypeName("#define IMAGE_ARCHIVE_HYBRIDMAP_MEMBER \"/<HYBRIDMAP>/   \"")]
    public static ReadOnlySpan<byte> IMAGE_ARCHIVE_HYBRIDMAP_MEMBER => "/<HYBRIDMAP>/   "u8;

    [NativeTypeName("#define IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR 60")]
    public const int IMAGE_SIZEOF_ARCHIVE_MEMBER_HDR = 60;

    [NativeTypeName("#define IMAGE_ORDINAL_FLAG64 0x8000000000000000")]
    public const ulong IMAGE_ORDINAL_FLAG64 = 0x8000000000000000;

    [NativeTypeName("#define IMAGE_ORDINAL_FLAG32 0x80000000")]
    public const uint IMAGE_ORDINAL_FLAG32 = 0x80000000;

    [NativeTypeName("#define IMAGE_RESOURCE_NAME_IS_STRING 0x80000000")]
    public const uint IMAGE_RESOURCE_NAME_IS_STRING = 0x80000000;

    [NativeTypeName("#define IMAGE_RESOURCE_DATA_IS_DIRECTORY 0x80000000")]
    public const uint IMAGE_RESOURCE_DATA_IS_DIRECTORY = 0x80000000;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE 0x00000001")]
    public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_PROLOGUE = 0x00000001;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE 0x00000002")]
    public const int IMAGE_DYNAMIC_RELOCATION_GUARD_RF_EPILOGUE = 0x00000002;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER 0x00000003")]
    public const int IMAGE_DYNAMIC_RELOCATION_GUARD_IMPORT_CONTROL_TRANSFER = 0x00000003;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER 0x00000004")]
    public const int IMAGE_DYNAMIC_RELOCATION_GUARD_INDIR_CONTROL_TRANSFER = 0x00000004;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH 0x00000005")]
    public const int IMAGE_DYNAMIC_RELOCATION_GUARD_SWITCHTABLE_BRANCH = 0x00000005;

    [NativeTypeName("#define IMAGE_DYNAMIC_RELOCATION_FUNCTION_OVERRIDE 0x00000007")]
    public const int IMAGE_DYNAMIC_RELOCATION_FUNCTION_OVERRIDE = 0x00000007;

    [NativeTypeName("#define IMAGE_FUNCTION_OVERRIDE_INVALID 0")]
    public const int IMAGE_FUNCTION_OVERRIDE_INVALID = 0;

    [NativeTypeName("#define IMAGE_FUNCTION_OVERRIDE_X64_REL32 1")]
    public const int IMAGE_FUNCTION_OVERRIDE_X64_REL32 = 1;

    [NativeTypeName("#define IMAGE_FUNCTION_OVERRIDE_ARM64_BRANCH26 2")]
    public const int IMAGE_FUNCTION_OVERRIDE_ARM64_BRANCH26 = 2;

    [NativeTypeName("#define IMAGE_FUNCTION_OVERRIDE_ARM64_THUNK 3")]
    public const int IMAGE_FUNCTION_OVERRIDE_ARM64_THUNK = 3;

    [NativeTypeName("#define IMAGE_HOT_PATCH_BASE_OBLIGATORY 0x00000001")]
    public const int IMAGE_HOT_PATCH_BASE_OBLIGATORY = 0x00000001;

    [NativeTypeName("#define IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK 0x00000002")]
    public const int IMAGE_HOT_PATCH_BASE_CAN_ROLL_BACK = 0x00000002;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_INVERSE 0x80000000")]
    public const uint IMAGE_HOT_PATCH_CHUNK_INVERSE = 0x80000000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_OBLIGATORY 0x40000000")]
    public const int IMAGE_HOT_PATCH_CHUNK_OBLIGATORY = 0x40000000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_RESERVED 0x3FF03000")]
    public const int IMAGE_HOT_PATCH_CHUNK_RESERVED = 0x3FF03000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_TYPE 0x000FC000")]
    public const int IMAGE_HOT_PATCH_CHUNK_TYPE = 0x000FC000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA 0x00008000")]
    public const int IMAGE_HOT_PATCH_CHUNK_SOURCE_RVA = 0x00008000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_TARGET_RVA 0x00004000")]
    public const int IMAGE_HOT_PATCH_CHUNK_TARGET_RVA = 0x00004000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CHUNK_SIZE 0x00000FFF")]
    public const int IMAGE_HOT_PATCH_CHUNK_SIZE = 0x00000FFF;

    [NativeTypeName("#define IMAGE_HOT_PATCH_NONE 0x00000000")]
    public const int IMAGE_HOT_PATCH_NONE = 0x00000000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_FUNCTION 0x0001C000")]
    public const int IMAGE_HOT_PATCH_FUNCTION = 0x0001C000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_ABSOLUTE 0x0002C000")]
    public const int IMAGE_HOT_PATCH_ABSOLUTE = 0x0002C000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_REL32 0x0003C000")]
    public const int IMAGE_HOT_PATCH_REL32 = 0x0003C000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_CALL_TARGET 0x00044000")]
    public const int IMAGE_HOT_PATCH_CALL_TARGET = 0x00044000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_INDIRECT 0x0005C000")]
    public const int IMAGE_HOT_PATCH_INDIRECT = 0x0005C000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_NO_CALL_TARGET 0x00064000")]
    public const int IMAGE_HOT_PATCH_NO_CALL_TARGET = 0x00064000;

    [NativeTypeName("#define IMAGE_HOT_PATCH_DYNAMIC_VALUE 0x00078000")]
    public const int IMAGE_HOT_PATCH_DYNAMIC_VALUE = 0x00078000;

    [NativeTypeName("#define IMAGE_GUARD_CF_INSTRUMENTED 0x00000100")]
    public const int IMAGE_GUARD_CF_INSTRUMENTED = 0x00000100;

    [NativeTypeName("#define IMAGE_GUARD_CFW_INSTRUMENTED 0x00000200")]
    public const int IMAGE_GUARD_CFW_INSTRUMENTED = 0x00000200;

    [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT 0x00000400")]
    public const int IMAGE_GUARD_CF_FUNCTION_TABLE_PRESENT = 0x00000400;

    [NativeTypeName("#define IMAGE_GUARD_SECURITY_COOKIE_UNUSED 0x00000800")]
    public const int IMAGE_GUARD_SECURITY_COOKIE_UNUSED = 0x00000800;

    [NativeTypeName("#define IMAGE_GUARD_PROTECT_DELAYLOAD_IAT 0x00001000")]
    public const int IMAGE_GUARD_PROTECT_DELAYLOAD_IAT = 0x00001000;

    [NativeTypeName("#define IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION 0x00002000")]
    public const int IMAGE_GUARD_DELAYLOAD_IAT_IN_ITS_OWN_SECTION = 0x00002000;

    [NativeTypeName("#define IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT 0x00004000")]
    public const int IMAGE_GUARD_CF_EXPORT_SUPPRESSION_INFO_PRESENT = 0x00004000;

    [NativeTypeName("#define IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION 0x00008000")]
    public const int IMAGE_GUARD_CF_ENABLE_EXPORT_SUPPRESSION = 0x00008000;

    [NativeTypeName("#define IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT 0x00010000")]
    public const int IMAGE_GUARD_CF_LONGJUMP_TABLE_PRESENT = 0x00010000;

    [NativeTypeName("#define IMAGE_GUARD_RF_INSTRUMENTED 0x00020000")]
    public const int IMAGE_GUARD_RF_INSTRUMENTED = 0x00020000;

    [NativeTypeName("#define IMAGE_GUARD_RF_ENABLE 0x00040000")]
    public const int IMAGE_GUARD_RF_ENABLE = 0x00040000;

    [NativeTypeName("#define IMAGE_GUARD_RF_STRICT 0x00080000")]
    public const int IMAGE_GUARD_RF_STRICT = 0x00080000;

    [NativeTypeName("#define IMAGE_GUARD_RETPOLINE_PRESENT 0x00100000")]
    public const int IMAGE_GUARD_RETPOLINE_PRESENT = 0x00100000;

    [NativeTypeName("#define IMAGE_GUARD_EH_CONTINUATION_TABLE_PRESENT 0x00400000")]
    public const int IMAGE_GUARD_EH_CONTINUATION_TABLE_PRESENT = 0x00400000;

    [NativeTypeName("#define IMAGE_GUARD_XFG_ENABLED 0x00800000")]
    public const int IMAGE_GUARD_XFG_ENABLED = 0x00800000;

    [NativeTypeName("#define IMAGE_GUARD_CASTGUARD_PRESENT 0x01000000")]
    public const int IMAGE_GUARD_CASTGUARD_PRESENT = 0x01000000;

    [NativeTypeName("#define IMAGE_GUARD_MEMCPY_PRESENT 0x02000000")]
    public const int IMAGE_GUARD_MEMCPY_PRESENT = 0x02000000;

    [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK 0xF0000000")]
    public const uint IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_MASK = 0xF0000000;

    [NativeTypeName("#define IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT 28")]
    public const int IMAGE_GUARD_CF_FUNCTION_TABLE_SIZE_SHIFT = 28;

    [NativeTypeName("#define IMAGE_GUARD_FLAG_FID_SUPPRESSED 0x01")]
    public const int IMAGE_GUARD_FLAG_FID_SUPPRESSED = 0x01;

    [NativeTypeName("#define IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED 0x02")]
    public const int IMAGE_GUARD_FLAG_EXPORT_SUPPRESSED = 0x02;

    [NativeTypeName("#define IMAGE_GUARD_FLAG_FID_LANGEXCPTHANDLER 0x04")]
    public const int IMAGE_GUARD_FLAG_FID_LANGEXCPTHANDLER = 0x04;

    [NativeTypeName("#define IMAGE_GUARD_FLAG_FID_XFG 0x08")]
    public const int IMAGE_GUARD_FLAG_FID_XFG = 0x08;

    [NativeTypeName("#define IMAGE_ENCLAVE_LONG_ID_LENGTH ENCLAVE_LONG_ID_LENGTH")]
    public const int IMAGE_ENCLAVE_LONG_ID_LENGTH = 32;

    [NativeTypeName("#define IMAGE_ENCLAVE_SHORT_ID_LENGTH ENCLAVE_SHORT_ID_LENGTH")]
    public const int IMAGE_ENCLAVE_SHORT_ID_LENGTH = 16;

    [NativeTypeName("#define IMAGE_ENCLAVE_POLICY_DEBUGGABLE 0x00000001")]
    public const int IMAGE_ENCLAVE_POLICY_DEBUGGABLE = 0x00000001;

    [NativeTypeName("#define IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE 0x00000001")]
    public const int IMAGE_ENCLAVE_FLAG_PRIMARY_IMAGE = 0x00000001;

    [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_NONE 0x00000000")]
    public const int IMAGE_ENCLAVE_IMPORT_MATCH_NONE = 0x00000000;

    [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID 0x00000001")]
    public const int IMAGE_ENCLAVE_IMPORT_MATCH_UNIQUE_ID = 0x00000001;

    [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID 0x00000002")]
    public const int IMAGE_ENCLAVE_IMPORT_MATCH_AUTHOR_ID = 0x00000002;

    [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID 0x00000003")]
    public const int IMAGE_ENCLAVE_IMPORT_MATCH_FAMILY_ID = 0x00000003;

    [NativeTypeName("#define IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID 0x00000004")]
    public const int IMAGE_ENCLAVE_IMPORT_MATCH_IMAGE_ID = 0x00000004;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_UNKNOWN 0")]
    public const int IMAGE_DEBUG_TYPE_UNKNOWN = 0;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_COFF 1")]
    public const int IMAGE_DEBUG_TYPE_COFF = 1;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_CODEVIEW 2")]
    public const int IMAGE_DEBUG_TYPE_CODEVIEW = 2;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_FPO 3")]
    public const int IMAGE_DEBUG_TYPE_FPO = 3;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_MISC 4")]
    public const int IMAGE_DEBUG_TYPE_MISC = 4;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_EXCEPTION 5")]
    public const int IMAGE_DEBUG_TYPE_EXCEPTION = 5;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_FIXUP 6")]
    public const int IMAGE_DEBUG_TYPE_FIXUP = 6;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_OMAP_TO_SRC 7")]
    public const int IMAGE_DEBUG_TYPE_OMAP_TO_SRC = 7;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_OMAP_FROM_SRC 8")]
    public const int IMAGE_DEBUG_TYPE_OMAP_FROM_SRC = 8;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_BORLAND 9")]
    public const int IMAGE_DEBUG_TYPE_BORLAND = 9;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_RESERVED10 10")]
    public const int IMAGE_DEBUG_TYPE_RESERVED10 = 10;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_BBT IMAGE_DEBUG_TYPE_RESERVED10")]
    public const int IMAGE_DEBUG_TYPE_BBT = 10;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_CLSID 11")]
    public const int IMAGE_DEBUG_TYPE_CLSID = 11;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_VC_FEATURE 12")]
    public const int IMAGE_DEBUG_TYPE_VC_FEATURE = 12;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_POGO 13")]
    public const int IMAGE_DEBUG_TYPE_POGO = 13;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_ILTCG 14")]
    public const int IMAGE_DEBUG_TYPE_ILTCG = 14;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_MPX 15")]
    public const int IMAGE_DEBUG_TYPE_MPX = 15;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_REPRO 16")]
    public const int IMAGE_DEBUG_TYPE_REPRO = 16;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_SPGO 18")]
    public const int IMAGE_DEBUG_TYPE_SPGO = 18;

    [NativeTypeName("#define IMAGE_DEBUG_TYPE_EX_DLLCHARACTERISTICS 20")]
    public const int IMAGE_DEBUG_TYPE_EX_DLLCHARACTERISTICS = 20;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT 0x01")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT = 0x01;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT_STRICT_MODE 0x02")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_COMPAT_STRICT_MODE = 0x02;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE 0x04")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_SET_CONTEXT_IP_VALIDATION_RELAXED_MODE = 0x04;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_DYNAMIC_APIS_ALLOW_IN_PROC 0x08")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_DYNAMIC_APIS_ALLOW_IN_PROC = 0x08;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_1 0x10")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_1 = 0x10;

    [NativeTypeName("#define IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_2 0x20")]
    public const int IMAGE_DLLCHARACTERISTICS_EX_CET_RESERVED_2 = 0x20;

    [NativeTypeName("#define IMAGE_DEBUG_MISC_EXENAME 1")]
    public const int IMAGE_DEBUG_MISC_EXENAME = 1;

    [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_SIGNATURE 0x4944")]
    public const int IMAGE_SEPARATE_DEBUG_SIGNATURE = 0x4944;

    [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_FLAGS_MASK 0x8000")]
    public const int IMAGE_SEPARATE_DEBUG_FLAGS_MASK = 0x8000;

    [NativeTypeName("#define IMAGE_SEPARATE_DEBUG_MISMATCH 0x8000")]
    public const int IMAGE_SEPARATE_DEBUG_MISMATCH = 0x8000;

    [NativeTypeName("#define IMAGE_POLICY_METADATA_VERSION 1")]
    public const int IMAGE_POLICY_METADATA_VERSION = 1;

    [NativeTypeName("#define IMAGE_POLICY_SECTION_NAME \".tPolicy\"")]
    public static ReadOnlySpan<byte> IMAGE_POLICY_SECTION_NAME => ".tPolicy"u8;
}
