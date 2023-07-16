// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
public static partial class DDSPD
{
    [NativeTypeName("#define DDSPD_IUNKNOWNPOINTER 0x00000001L")]
    public const int DDSPD_IUNKNOWNPOINTER = 0x00000001;
    [NativeTypeName("#define DDSPD_VOLATILE 0x00000002L")]
    public const int DDSPD_VOLATILE = 0x00000002;
}