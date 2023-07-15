// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IExplorerBrowserEvents.xml' path='doc/member[@name="IExplorerBrowserEvents"]/*'/>
[Guid("361BBDC7-E6EE-4E13-BE58-58E2240C810F")]
[NativeTypeName("struct IExplorerBrowserEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerBrowserEvents : IExplorerBrowserEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerBrowserEvents));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, Guid*, void**, int> )(lpVtbl[0]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, uint> )(lpVtbl[1]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, uint> )(lpVtbl[2]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExplorerBrowserEvents.xml' path='doc/member[@name="IExplorerBrowserEvents.OnNavigationPending"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> )(lpVtbl[3]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
    }

    /// <include file='IExplorerBrowserEvents.xml' path='doc/member[@name="IExplorerBrowserEvents.OnViewCreated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnViewCreated(IShellView* psv)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, IShellView*, int> )(lpVtbl[4]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), psv);
    }

    /// <include file='IExplorerBrowserEvents.xml' path='doc/member[@name="IExplorerBrowserEvents.OnNavigationComplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> )(lpVtbl[5]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
    }

    /// <include file='IExplorerBrowserEvents.xml' path='doc/member[@name="IExplorerBrowserEvents.OnNavigationFailed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents*, ITEMIDLIST*, int> )(lpVtbl[6]))((IExplorerBrowserEvents*)Unsafe.AsPointer(ref this), pidlFolder);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);
        [VtblIndex(4)]
        HRESULT OnViewCreated(IShellView* psv);
        [VtblIndex(5)]
        HRESULT OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);
        [VtblIndex(6)]
        HRESULT OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);
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
        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> OnNavigationPending;
        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView*, int> OnViewCreated;
        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> OnNavigationComplete;
        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> OnNavigationFailed;
    }
}