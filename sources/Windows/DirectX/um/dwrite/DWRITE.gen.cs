// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DWRITE
{
    [NativeTypeName("#define DWRITE_ALPHA_MAX 255")]
    public const int DWRITE_ALPHA_MAX = 255;
    [NativeTypeName("#define DWRITE_ERR_BASE 0x5000")]
    public const int DWRITE_ERR_BASE = 0x5000;
}