// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_SYSTEM_STORE_RELOCATE_PARA
{
    [NativeTypeName("__AnonymousRecord_wincrypt_L9538_C5")]
    public _Anonymous1_e__Union Anonymous1;

    [NativeTypeName("__AnonymousRecord_wincrypt_L9542_C5")]
    public _Anonymous2_e__Union Anonymous2;

    [UnscopedRef]
    public ref HKEY hKeyBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.hKeyBase; }
    }

    [UnscopedRef]
    public ref void* pvBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous1.pvBase; }
    }

    [UnscopedRef]
    public ref void* pvSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pvSystemStore; }
    }

    [UnscopedRef]
    public ref sbyte* pszSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pszSystemStore; }
    }

    [UnscopedRef]
    public ref ushort* pwszSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous2.pwszSystemStore; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        [FieldOffset(0)]
        public HKEY hKeyBase;

        [FieldOffset(0)]
        public void* pvBase;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        [FieldOffset(0)]
        public void* pvSystemStore;

        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszSystemStore;

        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pwszSystemStore;
    }
}
