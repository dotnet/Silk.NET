// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IConfigInterleaving.xml' path='doc/member[@name="IConfigInterleaving"]/*'/>
[Guid("BEE3D220-157B-11D0-BD23-00A0C911CE86")]
[NativeTypeName("struct IConfigInterleaving : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConfigInterleaving : IConfigInterleaving.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConfigInterleaving));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConfigInterleaving*, Guid*, void**, int> )(lpVtbl[0]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IConfigInterleaving*, uint> )(lpVtbl[1]))((IConfigInterleaving*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConfigInterleaving*, uint> )(lpVtbl[2]))((IConfigInterleaving*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IConfigInterleaving.xml' path='doc/member[@name="IConfigInterleaving.put_Mode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT put_Mode(InterleavingMode mode)
    {
        return ((delegate* unmanaged<IConfigInterleaving*, InterleavingMode, int> )(lpVtbl[3]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IConfigInterleaving.xml' path='doc/member[@name="IConfigInterleaving.get_Mode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Mode(InterleavingMode* pMode)
    {
        return ((delegate* unmanaged<IConfigInterleaving*, InterleavingMode*, int> )(lpVtbl[4]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), pMode);
    }

    /// <include file='IConfigInterleaving.xml' path='doc/member[@name="IConfigInterleaving.put_Interleaving"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT put_Interleaving([NativeTypeName("const REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("const REFERENCE_TIME *")] long* prtPreroll)
    {
        return ((delegate* unmanaged<IConfigInterleaving*, long*, long*, int> )(lpVtbl[5]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), prtInterleave, prtPreroll);
    }

    /// <include file='IConfigInterleaving.xml' path='doc/member[@name="IConfigInterleaving.get_Interleaving"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Interleaving([NativeTypeName("REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("REFERENCE_TIME *")] long* prtPreroll)
    {
        return ((delegate* unmanaged<IConfigInterleaving*, long*, long*, int> )(lpVtbl[6]))((IConfigInterleaving*)Unsafe.AsPointer(ref this), prtInterleave, prtPreroll);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT put_Mode(InterleavingMode mode);
        [VtblIndex(4)]
        HRESULT get_Mode(InterleavingMode* pMode);
        [VtblIndex(5)]
        HRESULT put_Interleaving([NativeTypeName("const REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("const REFERENCE_TIME *")] long* prtPreroll);
        [VtblIndex(6)]
        HRESULT get_Interleaving([NativeTypeName("REFERENCE_TIME *")] long* prtInterleave, [NativeTypeName("REFERENCE_TIME *")] long* prtPreroll);
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
        [NativeTypeName("HRESULT (InterleavingMode) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InterleavingMode, int> put_Mode;
        [NativeTypeName("HRESULT (InterleavingMode *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InterleavingMode*, int> get_Mode;
        [NativeTypeName("HRESULT (const REFERENCE_TIME *, const REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> put_Interleaving;
        [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> get_Interleaving;
    }
}