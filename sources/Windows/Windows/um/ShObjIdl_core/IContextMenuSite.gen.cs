// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IContextMenuSite.xml' path='doc/member[@name="IContextMenuSite"]/*'/>
[Guid("0811AEBE-0B87-4C54-9E72-548CF649016B")]
[NativeTypeName("struct IContextMenuSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContextMenuSite : IContextMenuSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContextMenuSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContextMenuSite*, Guid*, void**, int> )(lpVtbl[0]))((IContextMenuSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContextMenuSite*, uint> )(lpVtbl[1]))((IContextMenuSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContextMenuSite*, uint> )(lpVtbl[2]))((IContextMenuSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IContextMenuSite.xml' path='doc/member[@name="IContextMenuSite.DoContextMenuPopup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoContextMenuPopup(IUnknown* punkContextMenu, uint fFlags, POINT pt)
    {
        return ((delegate* unmanaged<IContextMenuSite*, IUnknown*, uint, POINT, int> )(lpVtbl[3]))((IContextMenuSite*)Unsafe.AsPointer(ref this), punkContextMenu, fFlags, pt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoContextMenuPopup(IUnknown* punkContextMenu, uint fFlags, POINT pt);
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
        [NativeTypeName("HRESULT (IUnknown *, UINT, POINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, POINT, int> DoContextMenuPopup;
    }
}