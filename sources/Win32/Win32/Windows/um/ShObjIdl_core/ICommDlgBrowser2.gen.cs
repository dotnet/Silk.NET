// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("10339516-2894-11D2-9039-00C04F8EEB3E")]
[NativeTypeName("struct ICommDlgBrowser2 : ICommDlgBrowser")]
[NativeInheritance("ICommDlgBrowser")]
public unsafe partial struct ICommDlgBrowser2 : ICommDlgBrowser2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICommDlgBrowser2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICommDlgBrowser2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDefaultCommand(IShellView ppshv)
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, IShellView, int>)((*lpVtbl)[3]))(
            this,
            ppshv
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnStateChange(IShellView ppshv, [NativeTypeName("ULONG")] uint uChange)
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, IShellView, uint, int>)((*lpVtbl)[4]))(
            this,
            ppshv,
            uChange
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IncludeObject(
        IShellView ppshv,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl
    )
    {
        return (
            (delegate* unmanaged<ICommDlgBrowser2, IShellView, ITEMIDLIST*, int>)((*lpVtbl)[5])
        )(this, ppshv, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Notify(IShellView ppshv, [NativeTypeName("DWORD")] uint dwNotifyType)
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, IShellView, uint, int>)((*lpVtbl)[6]))(
            this,
            ppshv,
            dwNotifyType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDefaultMenuText(
        IShellView ppshv,
        [NativeTypeName("LPWSTR")] ushort* pszText,
        int cchMax
    )
    {
        return (
            (delegate* unmanaged<ICommDlgBrowser2, IShellView, ushort*, int, int>)((*lpVtbl)[7])
        )(this, ppshv, pszText, cchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetViewFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ICommDlgBrowser2, uint*, int>)((*lpVtbl)[8]))(this, pdwFlags);
    }

    public interface Interface : ICommDlgBrowser.Interface
    {
        [VtblIndex(6)]
        HRESULT Notify(IShellView ppshv, [NativeTypeName("DWORD")] uint dwNotifyType);

        [VtblIndex(7)]
        HRESULT GetDefaultMenuText(
            IShellView ppshv,
            [NativeTypeName("LPWSTR")] ushort* pszText,
            int cchMax
        );

        [VtblIndex(8)]
        HRESULT GetViewFlags([NativeTypeName("DWORD *")] uint* pdwFlags);
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

        [NativeTypeName("HRESULT (IShellView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, int> OnDefaultCommand;

        [NativeTypeName("HRESULT (IShellView *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, uint, int> OnStateChange;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, ITEMIDLIST*, int> IncludeObject;

        [NativeTypeName("HRESULT (IShellView *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, uint, int> Notify;

        [NativeTypeName("HRESULT (IShellView *, LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellView, ushort*, int, int> GetDefaultMenuText;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetViewFlags;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICommDlgBrowser2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICommDlgBrowser2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ICommDlgBrowser"/> to <see cref = "ICommDlgBrowser2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ICommDlgBrowser"/> instance to be converted </param>
    public static explicit operator ICommDlgBrowser2(Silk.NET.Windows.ICommDlgBrowser value)
    {
        return new ICommDlgBrowser2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommDlgBrowser2"/> to <see cref = "Silk.NET.Windows.ICommDlgBrowser"/>.</summary>
    /// <param name = "value">The <see cref = "ICommDlgBrowser2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ICommDlgBrowser(ICommDlgBrowser2 value)
    {
        return new Silk.NET.Windows.ICommDlgBrowser(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICommDlgBrowser2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICommDlgBrowser2(Silk.NET.Windows.IUnknown value)
    {
        return new ICommDlgBrowser2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICommDlgBrowser2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICommDlgBrowser2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICommDlgBrowser2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
