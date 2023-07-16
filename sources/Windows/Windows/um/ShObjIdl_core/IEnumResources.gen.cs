// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IEnumResources.xml' path='doc/member[@name="IEnumResources"]/*'/>
[Guid("2DD81FE3-A83C-4DA9-A330-47249D345BA1")]
[NativeTypeName("struct IEnumResources : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumResources : IEnumResources.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumResources));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumResources*, Guid*, void**, int> )(lpVtbl[0]))((IEnumResources*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumResources*, uint> )(lpVtbl[1]))((IEnumResources*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumResources*, uint> )(lpVtbl[2]))((IEnumResources*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumResources.xml' path='doc/member[@name="IEnumResources.Next"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, SHELL_ITEM_RESOURCE* psir, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IEnumResources*, uint, SHELL_ITEM_RESOURCE*, uint*, int> )(lpVtbl[3]))((IEnumResources*)Unsafe.AsPointer(ref this), celt, psir, pceltFetched);
    }

    /// <include file='IEnumResources.xml' path='doc/member[@name="IEnumResources.Skip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IEnumResources*, uint, int> )(lpVtbl[4]))((IEnumResources*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IEnumResources.xml' path='doc/member[@name="IEnumResources.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumResources*, int> )(lpVtbl[5]))((IEnumResources*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumResources.xml' path='doc/member[@name="IEnumResources.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumResources** ppenumr)
    {
        return ((delegate* unmanaged<IEnumResources*, IEnumResources**, int> )(lpVtbl[6]))((IEnumResources*)Unsafe.AsPointer(ref this), ppenumr);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, SHELL_ITEM_RESOURCE* psir, [NativeTypeName("ULONG *")] uint* pceltFetched);
        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);
        [VtblIndex(5)]
        HRESULT Reset();
        [VtblIndex(6)]
        HRESULT Clone(IEnumResources** ppenumr);
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
        [NativeTypeName("HRESULT (ULONG, SHELL_ITEM_RESOURCE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, SHELL_ITEM_RESOURCE*, uint*, int> Next;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (IEnumResources **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumResources**, int> Clone;
    }
}