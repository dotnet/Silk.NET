// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfLMLattice.xml' path='doc/member[@name="ITfLMLattice"]/*' />
[Guid("D4236675-A5BF-4570-9D42-5D6D7B02D59B")]
[NativeTypeName("struct ITfLMLattice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLMLattice : ITfLMLattice.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLMLattice));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLMLattice*, Guid*, void**, int>)(lpVtbl[0]))((ITfLMLattice*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLMLattice*, uint>)(lpVtbl[1]))((ITfLMLattice*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLMLattice*, uint>)(lpVtbl[2]))((ITfLMLattice*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfLMLattice.xml' path='doc/member[@name="ITfLMLattice.QueryType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported)
    {
        return ((delegate* unmanaged<ITfLMLattice*, Guid*, BOOL*, int>)(lpVtbl[3]))((ITfLMLattice*)Unsafe.AsPointer(ref this), rguidType, pfSupported);
    }

    /// <include file='ITfLMLattice.xml' path='doc/member[@name="ITfLMLattice.EnumLatticeElements"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumLatticeElements([NativeTypeName("DWORD")] uint dwFrameStart, [NativeTypeName("const GUID &")] Guid* rguidType, IEnumTfLatticeElements** ppEnum)
    {
        return ((delegate* unmanaged<ITfLMLattice*, uint, Guid*, IEnumTfLatticeElements**, int>)(lpVtbl[4]))((ITfLMLattice*)Unsafe.AsPointer(ref this), dwFrameStart, rguidType, ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryType([NativeTypeName("const GUID &")] Guid* rguidType, BOOL* pfSupported);

        [VtblIndex(4)]
        HRESULT EnumLatticeElements([NativeTypeName("DWORD")] uint dwFrameStart, [NativeTypeName("const GUID &")] Guid* rguidType, IEnumTfLatticeElements** ppEnum);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (const GUID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL*, int> QueryType;

        [NativeTypeName("HRESULT (DWORD, const GUID &, IEnumTfLatticeElements **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, IEnumTfLatticeElements**, int> EnumLatticeElements;
    }
}
