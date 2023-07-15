// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class QUERY
{
    [NativeTypeName("#define QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX (0x00000004)")]
    public const int QUERY_ACTCTX_FLAG_USE_ACTIVE_ACTCTX = (0x00000004);
    [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE (0x00000008)")]
    public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_HMODULE = (0x00000008);
    [NativeTypeName("#define QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS (0x00000010)")]
    public const int QUERY_ACTCTX_FLAG_ACTCTX_IS_ADDRESS = (0x00000010);
    [NativeTypeName("#define QUERY_ACTCTX_FLAG_NO_ADDREF (0x80000000)")]
    public const uint QUERY_ACTCTX_FLAG_NO_ADDREF = (0x80000000);
}