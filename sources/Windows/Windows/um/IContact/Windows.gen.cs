// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define CGD_DEFAULT 0x00000000")]
    public const int CGD_DEFAULT = 0x00000000;
    [NativeTypeName("#define CGD_UNKNOWN_PROPERTY 0x00000000")]
    public const int CGD_UNKNOWN_PROPERTY = 0x00000000;
    [NativeTypeName("#define CGD_STRING_PROPERTY 0x00000001")]
    public const int CGD_STRING_PROPERTY = 0x00000001;
    [NativeTypeName("#define CGD_DATE_PROPERTY 0x00000002")]
    public const int CGD_DATE_PROPERTY = 0x00000002;
    [NativeTypeName("#define CGD_BINARY_PROPERTY 0x00000004")]
    public const int CGD_BINARY_PROPERTY = 0x00000004;
    [NativeTypeName("#define CGD_ARRAY_NODE 0x00000008")]
    public const int CGD_ARRAY_NODE = 0x00000008;
}