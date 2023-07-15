// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PAGE
{
    [NativeTypeName("#define PAGE_NOACCESS 0x01")]
    public const int PAGE_NOACCESS = 0x01;
    [NativeTypeName("#define PAGE_READONLY 0x02")]
    public const int PAGE_READONLY = 0x02;
    [NativeTypeName("#define PAGE_READWRITE 0x04")]
    public const int PAGE_READWRITE = 0x04;
    [NativeTypeName("#define PAGE_WRITECOPY 0x08")]
    public const int PAGE_WRITECOPY = 0x08;
    [NativeTypeName("#define PAGE_EXECUTE 0x10")]
    public const int PAGE_EXECUTE = 0x10;
    [NativeTypeName("#define PAGE_EXECUTE_READ 0x20")]
    public const int PAGE_EXECUTE_READ = 0x20;
    [NativeTypeName("#define PAGE_EXECUTE_READWRITE 0x40")]
    public const int PAGE_EXECUTE_READWRITE = 0x40;
    [NativeTypeName("#define PAGE_EXECUTE_WRITECOPY 0x80")]
    public const int PAGE_EXECUTE_WRITECOPY = 0x80;
    [NativeTypeName("#define PAGE_GUARD 0x100")]
    public const int PAGE_GUARD = 0x100;
    [NativeTypeName("#define PAGE_NOCACHE 0x200")]
    public const int PAGE_NOCACHE = 0x200;
    [NativeTypeName("#define PAGE_WRITECOMBINE 0x400")]
    public const int PAGE_WRITECOMBINE = 0x400;
    [NativeTypeName("#define PAGE_GRAPHICS_NOACCESS 0x0800")]
    public const int PAGE_GRAPHICS_NOACCESS = 0x0800;
    [NativeTypeName("#define PAGE_GRAPHICS_READONLY 0x1000")]
    public const int PAGE_GRAPHICS_READONLY = 0x1000;
    [NativeTypeName("#define PAGE_GRAPHICS_READWRITE 0x2000")]
    public const int PAGE_GRAPHICS_READWRITE = 0x2000;
    [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE 0x4000")]
    public const int PAGE_GRAPHICS_EXECUTE = 0x4000;
    [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READ 0x8000")]
    public const int PAGE_GRAPHICS_EXECUTE_READ = 0x8000;
    [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READWRITE 0x10000")]
    public const int PAGE_GRAPHICS_EXECUTE_READWRITE = 0x10000;
    [NativeTypeName("#define PAGE_GRAPHICS_COHERENT 0x20000")]
    public const int PAGE_GRAPHICS_COHERENT = 0x20000;
    [NativeTypeName("#define PAGE_GRAPHICS_NOCACHE 0x40000")]
    public const int PAGE_GRAPHICS_NOCACHE = 0x40000;
    [NativeTypeName("#define PAGE_ENCLAVE_THREAD_CONTROL 0x80000000")]
    public const uint PAGE_ENCLAVE_THREAD_CONTROL = 0x80000000;
    [NativeTypeName("#define PAGE_REVERT_TO_FILE_MAP 0x80000000")]
    public const uint PAGE_REVERT_TO_FILE_MAP = 0x80000000;
    [NativeTypeName("#define PAGE_TARGETS_NO_UPDATE 0x40000000")]
    public const int PAGE_TARGETS_NO_UPDATE = 0x40000000;
    [NativeTypeName("#define PAGE_TARGETS_INVALID 0x40000000")]
    public const int PAGE_TARGETS_INVALID = 0x40000000;
    [NativeTypeName("#define PAGE_ENCLAVE_UNVALIDATED 0x20000000")]
    public const int PAGE_ENCLAVE_UNVALIDATED = 0x20000000;
    [NativeTypeName("#define PAGE_ENCLAVE_MASK 0x10000000")]
    public const int PAGE_ENCLAVE_MASK = 0x10000000;
    [NativeTypeName("#define PAGE_ENCLAVE_DECOMMIT (PAGE_ENCLAVE_MASK | 0)")]
    public const int PAGE_ENCLAVE_DECOMMIT = (0x10000000 | 0);
    [NativeTypeName("#define PAGE_ENCLAVE_SS_FIRST (PAGE_ENCLAVE_MASK | 1)")]
    public const int PAGE_ENCLAVE_SS_FIRST = (0x10000000 | 1);
    [NativeTypeName("#define PAGE_ENCLAVE_SS_REST (PAGE_ENCLAVE_MASK | 2)")]
    public const int PAGE_ENCLAVE_SS_REST = (0x10000000 | 2);
}