// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_AUX_SYMBOL_TOKEN_DEF
{
    public byte bAuxType;
    public byte bReserved;

    [NativeTypeName("DWORD")]
    public uint SymbolTableIndex;

    [NativeTypeName("BYTE[12]")]
    public _rgbReserved_e__FixedBuffer rgbReserved;

    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    [InlineArray(12)]
    public partial struct _rgbReserved_e__FixedBuffer
    {
        public byte e0;
    }
}
