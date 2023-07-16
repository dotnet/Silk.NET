// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CONTAINER
{
    [NativeTypeName("#define CONTAINER_VOLUME_STATE_HOSTING_CONTAINER (0x00000001)")]
    public const int CONTAINER_VOLUME_STATE_HOSTING_CONTAINER = (0x00000001);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_SCRATCH_ROOT (0x00000001)")]
    public const int CONTAINER_ROOT_INFO_FLAG_SCRATCH_ROOT = (0x00000001);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_LAYER_ROOT (0x00000002)")]
    public const int CONTAINER_ROOT_INFO_FLAG_LAYER_ROOT = (0x00000002);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_ROOT (0x00000004)")]
    public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_ROOT = (0x00000004);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_TARGET_ROOT (0x00000008)")]
    public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_TARGET_ROOT = (0x00000008);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_EXCEPTION_ROOT (0x00000010)")]
    public const int CONTAINER_ROOT_INFO_FLAG_VIRTUALIZATION_EXCEPTION_ROOT = (0x00000010);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_ROOT (0x00000020)")]
    public const int CONTAINER_ROOT_INFO_FLAG_BIND_ROOT = (0x00000020);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_TARGET_ROOT (0x00000040)")]
    public const int CONTAINER_ROOT_INFO_FLAG_BIND_TARGET_ROOT = (0x00000040);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_EXCEPTION_ROOT (0x00000080)")]
    public const int CONTAINER_ROOT_INFO_FLAG_BIND_EXCEPTION_ROOT = (0x00000080);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_BIND_DO_NOT_MAP_NAME (0x00000100)")]
    public const int CONTAINER_ROOT_INFO_FLAG_BIND_DO_NOT_MAP_NAME = (0x00000100);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_FLAG_UNION_LAYER_ROOT (0x00000200)")]
    public const int CONTAINER_ROOT_INFO_FLAG_UNION_LAYER_ROOT = (0x00000200);
    [NativeTypeName("#define CONTAINER_ROOT_INFO_VALID_FLAGS (0x000003ff)")]
    public const int CONTAINER_ROOT_INFO_VALID_FLAGS = (0x000003ff);
}