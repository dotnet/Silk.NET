// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumOLEVERB.xml' path='doc/member[@name="IEnumOLEVERB"]/*'/>
[Guid("00000104-0000-0000-C000-000000000046")]
[NativeTypeName("struct IEnumOLEVERB : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumOLEVERB : IEnumOLEVERB.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumOLEVERB));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, Guid*, void**, int> )(lpVtbl[0]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, uint> )(lpVtbl[1]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, uint> )(lpVtbl[2]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumOLEVERB.xml' path='doc/member[@name="IEnumOLEVERB.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, uint, OLEVERB*, uint*, int> )(lpVtbl[3]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IEnumOLEVERB.xml' path='doc/member[@name="IEnumOLEVERB.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, uint, int> )(lpVtbl[4]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumOLEVERB.xml' path='doc/member[@name="IEnumOLEVERB.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, int> )(lpVtbl[5]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumOLEVERB.xml' path='doc/member[@name="IEnumOLEVERB.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumOLEVERB** ppenum)
    {
        return ((delegate* unmanaged<IEnumOLEVERB*, IEnumOLEVERB**, int> )(lpVtbl[6]))((IEnumOLEVERB*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("LPOLEVERB")] OLEVERB* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumOLEVERB** ppenum);
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
        [NativeTypeName("HRESULT (ULONG, LPOLEVERB, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, OLEVERB*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumOLEVERB**, int> Clone;
    }
}