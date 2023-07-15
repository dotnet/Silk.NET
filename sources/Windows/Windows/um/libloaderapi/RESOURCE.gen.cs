// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class RESOURCE
{
    [NativeTypeName("#define RESOURCE_ENUM_LN (0x0001)")]
    public const int RESOURCE_ENUM_LN = (0x0001);
    [NativeTypeName("#define RESOURCE_ENUM_MUI (0x0002)")]
    public const int RESOURCE_ENUM_MUI = (0x0002);
    [NativeTypeName("#define RESOURCE_ENUM_MUI_SYSTEM (0x0004)")]
    public const int RESOURCE_ENUM_MUI_SYSTEM = (0x0004);
    [NativeTypeName("#define RESOURCE_ENUM_VALIDATE (0x0008)")]
    public const int RESOURCE_ENUM_VALIDATE = (0x0008);
    [NativeTypeName("#define RESOURCE_ENUM_MODULE_EXACT (0x0010)")]
    public const int RESOURCE_ENUM_MODULE_EXACT = (0x0010);
}