// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDGFS
{
    [NativeTypeName("#define DDGFS_CANFLIP 0x00000001l")]
    public const int DDGFS_CANFLIP = 0x00000001;
    [NativeTypeName("#define DDGFS_ISFLIPDONE 0x00000002l")]
    public const int DDGFS_ISFLIPDONE = 0x00000002;
}