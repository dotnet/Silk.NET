// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
public static partial class DDGBS
{
    [NativeTypeName("#define DDGBS_CANBLT 0x00000001l")]
    public const int DDGBS_CANBLT = 0x00000001;
    [NativeTypeName("#define DDGBS_ISBLTDONE 0x00000002l")]
    public const int DDGBS_ISBLTDONE = 0x00000002;
}