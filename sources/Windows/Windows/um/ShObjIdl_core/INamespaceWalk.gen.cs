// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='INamespaceWalk.xml' path='doc/member[@name="INamespaceWalk"]/*'/>
[Guid("57CED8A7-3F4A-432C-9350-30F24483F74F")]
[NativeTypeName("struct INamespaceWalk : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INamespaceWalk : INamespaceWalk.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamespaceWalk));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INamespaceWalk*, Guid*, void**, int> )(lpVtbl[0]))((INamespaceWalk*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INamespaceWalk*, uint> )(lpVtbl[1]))((INamespaceWalk*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INamespaceWalk*, uint> )(lpVtbl[2]))((INamespaceWalk*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INamespaceWalk.xml' path='doc/member[@name="INamespaceWalk.Walk"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Walk(IUnknown* punkToWalk, [NativeTypeName("DWORD")] uint dwFlags, int cDepth, INamespaceWalkCB* pnswcb)
    {
        return ((delegate* unmanaged<INamespaceWalk*, IUnknown*, uint, int, INamespaceWalkCB*, int> )(lpVtbl[3]))((INamespaceWalk*)Unsafe.AsPointer(ref this), punkToWalk, dwFlags, cDepth, pnswcb);
    }

    /// <include file='INamespaceWalk.xml' path='doc/member[@name="INamespaceWalk.GetIDArrayResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIDArrayResult(uint* pcItems, [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** prgpidl)
    {
        return ((delegate* unmanaged<INamespaceWalk*, uint*, ITEMIDLIST***, int> )(lpVtbl[4]))((INamespaceWalk*)Unsafe.AsPointer(ref this), pcItems, prgpidl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Walk(IUnknown* punkToWalk, [NativeTypeName("DWORD")] uint dwFlags, int cDepth, INamespaceWalkCB* pnswcb);
        [VtblIndex(4)]
        HRESULT GetIDArrayResult(uint* pcItems, [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** prgpidl);
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
        [NativeTypeName("HRESULT (IUnknown *, DWORD, int, INamespaceWalkCB *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int, INamespaceWalkCB*, int> Walk;
        [NativeTypeName("HRESULT (UINT *, LPITEMIDLIST **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ITEMIDLIST***, int> GetIDArrayResult;
    }
}