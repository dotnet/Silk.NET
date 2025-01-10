// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_RELOCATION
{
    [NativeTypeName("__AnonymousRecord_winnt_L19971_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint SymbolTableIndex;

    [NativeTypeName("WORD")]
    public ushort Type;

    [UnscopedRef]
    public ref uint VirtualAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.VirtualAddress; }
    }

    [UnscopedRef]
    public ref uint RelocCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.RelocCount; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualAddress;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint RelocCount;
    }
}
