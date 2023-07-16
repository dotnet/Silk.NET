// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static unsafe partial class WC
{
    [NativeTypeName("#define WC_DIALOG (MAKEINTATOM(0x8002))")]
    public static ushort* WC_DIALOG => ((ushort*)((nuint)((ushort)(0x8002))));
}