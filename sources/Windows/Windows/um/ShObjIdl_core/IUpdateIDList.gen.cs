// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUpdateIDList.xml' path='doc/member[@name="IUpdateIDList"]/*'/>
[Guid("6589B6D2-5F8D-4B9E-B7E0-23CDD9717D8C")]
[NativeTypeName("struct IUpdateIDList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUpdateIDList : IUpdateIDList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUpdateIDList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUpdateIDList*, Guid*, void**, int> )(lpVtbl[0]))((IUpdateIDList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUpdateIDList*, uint> )(lpVtbl[1]))((IUpdateIDList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUpdateIDList*, uint> )(lpVtbl[2]))((IUpdateIDList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUpdateIDList.xml' path='doc/member[@name="IUpdateIDList.Update"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Update(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlIn, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
    {
        return ((delegate* unmanaged<IUpdateIDList*, IBindCtx*, ITEMIDLIST*, ITEMIDLIST**, int> )(lpVtbl[3]))((IUpdateIDList*)Unsafe.AsPointer(ref this), pbc, pidlIn, ppidlOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Update(IBindCtx* pbc, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlIn, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut);
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
        [NativeTypeName("HRESULT (IBindCtx *, LPCITEMIDLIST, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx*, ITEMIDLIST*, ITEMIDLIST**, int> Update;
    }
}