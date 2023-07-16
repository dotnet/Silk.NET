// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MAX
{
    [NativeTypeName("#define MAX_FW_BUCKET_ID_LENGTH 132")]
    public const int MAX_FW_BUCKET_ID_LENGTH = 132;
    [NativeTypeName("#define MAX_INTERFACE_CODES 8")]
    public const int MAX_INTERFACE_CODES = 8;
    [NativeTypeName("#define MAX_VOLUME_ID_SIZE 36")]
    public const int MAX_VOLUME_ID_SIZE = 36;
    [NativeTypeName("#define MAX_VOLUME_TEMPLATE_SIZE 40")]
    public const int MAX_VOLUME_TEMPLATE_SIZE = 40;
}