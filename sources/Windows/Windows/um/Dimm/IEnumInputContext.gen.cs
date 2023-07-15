// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IEnumInputContext.xml' path='doc/member[@name="IEnumInputContext"]/*'/>
[Guid("09B5EAB0-F997-11D1-93D4-0060B067B86E")]
[NativeTypeName("struct IEnumInputContext : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumInputContext : IEnumInputContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumInputContext));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumInputContext*, Guid*, void**, int> )(lpVtbl[0]))((IEnumInputContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumInputContext*, uint> )(lpVtbl[1]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumInputContext*, uint> )(lpVtbl[2]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumInputContext.xml' path='doc/member[@name="IEnumInputContext.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Clone(IEnumInputContext** ppEnum)
    {
        return ((delegate* unmanaged<IEnumInputContext*, IEnumInputContext**, int> )(lpVtbl[3]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <include file='IEnumInputContext.xml' path='doc/member[@name="IEnumInputContext.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, HIMC* rgInputContext, [NativeTypeName("ULONG *")] uint* pcFetched)
    {
        return ((delegate* unmanaged<IEnumInputContext*, uint, HIMC*, uint*, int> )(lpVtbl[4]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ulCount, rgInputContext, pcFetched);
    }

    /// <include file='IEnumInputContext.xml' path='doc/member[@name="IEnumInputContext.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumInputContext*, int> )(lpVtbl[5]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumInputContext.xml' path='doc/member[@name="IEnumInputContext.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
    {
        return ((delegate* unmanaged<IEnumInputContext*, uint, int> )(lpVtbl[6]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ulCount);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Clone(IEnumInputContext** ppEnum);
        [VtblIndex(4)]
        HRESULT Next([NativeTypeName("ULONG")] uint ulCount, HIMC* rgInputContext, [NativeTypeName("ULONG *")] uint* pcFetched);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Skip([NativeTypeName("ULONG")] uint ulCount);
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
        [NativeTypeName("HRESULT (IEnumInputContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumInputContext**, int> Clone;
        [NativeTypeName("HRESULT (ULONG, HIMC *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HIMC*, uint*, int> Next;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
    }
}