// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("361BBDC7-E6EE-4E13-BE58-58E2240C810F")]
[NativeTypeName("struct IExplorerBrowserEvents : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExplorerBrowserEvents : IExplorerBrowserEvents.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExplorerBrowserEvents));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, ITEMIDLIST*, int>)((*lpVtbl)[3]))(
            this,
            pidlFolder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnViewCreated(IShellView psv)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, IShellView, int>)((*lpVtbl)[4]))(
            this,
            psv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnNavigationComplete([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, ITEMIDLIST*, int>)((*lpVtbl)[5]))(
            this,
            pidlFolder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNavigationFailed([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder)
    {
        return ((delegate* unmanaged<IExplorerBrowserEvents, ITEMIDLIST*, int>)((*lpVtbl)[6]))(
            this,
            pidlFolder
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnNavigationPending([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder);

        [VtblIndex(4)]
        HRESULT OnViewCreated(IShellView psv);

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
        public delegate* unmanaged<TSelf*, IShellView, int> OnViewCreated;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> OnNavigationComplete;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> OnNavigationFailed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExplorerBrowserEvents"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExplorerBrowserEvents(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExplorerBrowserEvents"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExplorerBrowserEvents(Silk.NET.Windows.IUnknown value)
    {
        return new IExplorerBrowserEvents(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExplorerBrowserEvents"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExplorerBrowserEvents"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExplorerBrowserEvents value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
