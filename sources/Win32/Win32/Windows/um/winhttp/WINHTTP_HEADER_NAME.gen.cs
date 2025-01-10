// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct WINHTTP_HEADER_NAME
{
    [FieldOffset(0)]
    [NativeTypeName("PCWSTR")]
    public ushort* pwszName;

    [FieldOffset(0)]
    [NativeTypeName("PCSTR")]
    public sbyte* pszName;
}
