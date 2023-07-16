// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class HEAP
{
    /// <include file='HEAP.xml' path='doc/member[@name="HEAP.HEAP_MAKE_TAG_FLAGS"]/*'/>
    [return: NativeTypeName("DWORD")]
    public static uint HEAP_MAKE_TAG_FLAGS([NativeTypeName("DWORD")] uint TagBase, [NativeTypeName("DWORD")] uint Tag)
    {
        return ((uint)((TagBase) + ((Tag) << 18)));
    }

    [NativeTypeName("#define HEAP_NO_SERIALIZE 0x00000001")]
    public const int HEAP_NO_SERIALIZE = 0x00000001;
    [NativeTypeName("#define HEAP_GROWABLE 0x00000002")]
    public const int HEAP_GROWABLE = 0x00000002;
    [NativeTypeName("#define HEAP_GENERATE_EXCEPTIONS 0x00000004")]
    public const int HEAP_GENERATE_EXCEPTIONS = 0x00000004;
    [NativeTypeName("#define HEAP_ZERO_MEMORY 0x00000008")]
    public const int HEAP_ZERO_MEMORY = 0x00000008;
    [NativeTypeName("#define HEAP_REALLOC_IN_PLACE_ONLY 0x00000010")]
    public const int HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;
    [NativeTypeName("#define HEAP_TAIL_CHECKING_ENABLED 0x00000020")]
    public const int HEAP_TAIL_CHECKING_ENABLED = 0x00000020;
    [NativeTypeName("#define HEAP_FREE_CHECKING_ENABLED 0x00000040")]
    public const int HEAP_FREE_CHECKING_ENABLED = 0x00000040;
    [NativeTypeName("#define HEAP_DISABLE_COALESCE_ON_FREE 0x00000080")]
    public const int HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;
    [NativeTypeName("#define HEAP_CREATE_ALIGN_16 0x00010000")]
    public const int HEAP_CREATE_ALIGN_16 = 0x00010000;
    [NativeTypeName("#define HEAP_CREATE_ENABLE_TRACING 0x00020000")]
    public const int HEAP_CREATE_ENABLE_TRACING = 0x00020000;
    [NativeTypeName("#define HEAP_CREATE_ENABLE_EXECUTE 0x00040000")]
    public const int HEAP_CREATE_ENABLE_EXECUTE = 0x00040000;
    [NativeTypeName("#define HEAP_MAXIMUM_TAG 0x0FFF")]
    public const int HEAP_MAXIMUM_TAG = 0x0FFF;
    [NativeTypeName("#define HEAP_PSEUDO_TAG_FLAG 0x8000")]
    public const int HEAP_PSEUDO_TAG_FLAG = 0x8000;
    [NativeTypeName("#define HEAP_TAG_SHIFT 18")]
    public const int HEAP_TAG_SHIFT = 18;
    [NativeTypeName("#define HEAP_CREATE_SEGMENT_HEAP 0x00000100")]
    public const int HEAP_CREATE_SEGMENT_HEAP = 0x00000100;
    [NativeTypeName("#define HEAP_CREATE_HARDENED 0x00000200")]
    public const int HEAP_CREATE_HARDENED = 0x00000200;
    [NativeTypeName("#define HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION 1")]
    public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;
}