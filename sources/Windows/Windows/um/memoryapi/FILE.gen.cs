// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/memoryapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FILE
{
    [NativeTypeName("#define FILE_MAP_WRITE SECTION_MAP_WRITE")]
    public const int FILE_MAP_WRITE = 0x0002;
    [NativeTypeName("#define FILE_MAP_READ SECTION_MAP_READ")]
    public const int FILE_MAP_READ = 0x0004;
    [NativeTypeName("#define FILE_MAP_ALL_ACCESS SECTION_ALL_ACCESS")]
    public const int FILE_MAP_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);
    [NativeTypeName("#define FILE_MAP_EXECUTE SECTION_MAP_EXECUTE_EXPLICIT")]
    public const int FILE_MAP_EXECUTE = 0x0020;
    [NativeTypeName("#define FILE_MAP_COPY 0x00000001")]
    public const int FILE_MAP_COPY = 0x00000001;
    [NativeTypeName("#define FILE_MAP_RESERVE 0x80000000")]
    public const uint FILE_MAP_RESERVE = 0x80000000;
    [NativeTypeName("#define FILE_MAP_TARGETS_INVALID 0x40000000")]
    public const int FILE_MAP_TARGETS_INVALID = 0x40000000;
    [NativeTypeName("#define FILE_MAP_LARGE_PAGES 0x20000000")]
    public const int FILE_MAP_LARGE_PAGES = 0x20000000;
    [NativeTypeName("#define FILE_CACHE_MAX_HARD_ENABLE 0x00000001")]
    public const int FILE_CACHE_MAX_HARD_ENABLE = 0x00000001;
    [NativeTypeName("#define FILE_CACHE_MAX_HARD_DISABLE 0x00000002")]
    public const int FILE_CACHE_MAX_HARD_DISABLE = 0x00000002;
    [NativeTypeName("#define FILE_CACHE_MIN_HARD_ENABLE 0x00000004")]
    public const int FILE_CACHE_MIN_HARD_ENABLE = 0x00000004;
    [NativeTypeName("#define FILE_CACHE_MIN_HARD_DISABLE 0x00000008")]
    public const int FILE_CACHE_MIN_HARD_DISABLE = 0x00000008;
}