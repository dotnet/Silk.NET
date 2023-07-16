// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class STORAGE
{
    [NativeTypeName("#define STORAGE_INFO_FLAGS_ALIGNED_DEVICE 0x00000001")]
    public const int STORAGE_INFO_FLAGS_ALIGNED_DEVICE = 0x00000001;
    [NativeTypeName("#define STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE 0x00000002")]
    public const int STORAGE_INFO_FLAGS_PARTITION_ALIGNED_ON_DEVICE = 0x00000002;
    [NativeTypeName("#define STORAGE_INFO_OFFSET_UNKNOWN (0xffffffff)")]
    public const uint STORAGE_INFO_OFFSET_UNKNOWN = (0xffffffff);
}