// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class STREAM
{
    [NativeTypeName("#define STREAM_SET_ENCRYPTION 0x00000003")]
    public const int STREAM_SET_ENCRYPTION = 0x00000003;
    [NativeTypeName("#define STREAM_CLEAR_ENCRYPTION 0x00000004")]
    public const int STREAM_CLEAR_ENCRYPTION = 0x00000004;
    [NativeTypeName("#define STREAM_LAYOUT_ENTRY_IMMOVABLE (0x00000001)")]
    public const int STREAM_LAYOUT_ENTRY_IMMOVABLE = (0x00000001);
    [NativeTypeName("#define STREAM_LAYOUT_ENTRY_PINNED (0x00000002)")]
    public const int STREAM_LAYOUT_ENTRY_PINNED = (0x00000002);
    [NativeTypeName("#define STREAM_LAYOUT_ENTRY_RESIDENT (0x00000004)")]
    public const int STREAM_LAYOUT_ENTRY_RESIDENT = (0x00000004);
    [NativeTypeName("#define STREAM_LAYOUT_ENTRY_NO_CLUSTERS_ALLOCATED (0x00000008)")]
    public const int STREAM_LAYOUT_ENTRY_NO_CLUSTERS_ALLOCATED = (0x00000008);
    [NativeTypeName("#define STREAM_LAYOUT_ENTRY_HAS_INFORMATION (0x00000010)")]
    public const int STREAM_LAYOUT_ENTRY_HAS_INFORMATION = (0x00000010);
    [NativeTypeName("#define STREAM_EXTENT_ENTRY_AS_RETRIEVAL_POINTERS (0x00000001)")]
    public const int STREAM_EXTENT_ENTRY_AS_RETRIEVAL_POINTERS = (0x00000001);
    [NativeTypeName("#define STREAM_EXTENT_ENTRY_ALL_EXTENTS (0x00000002)")]
    public const int STREAM_EXTENT_ENTRY_ALL_EXTENTS = (0x00000002);
}