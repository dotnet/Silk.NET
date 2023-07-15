// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class GET
{
    [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_PIN (0x00000001)")]
    public const int GET_MODULE_HANDLE_EX_FLAG_PIN = (0x00000001);
    [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT (0x00000002)")]
    public const int GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = (0x00000002);
    [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS (0x00000004)")]
    public const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = (0x00000004);
}