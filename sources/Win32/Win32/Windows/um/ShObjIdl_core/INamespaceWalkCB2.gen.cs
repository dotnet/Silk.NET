// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7AC7492B-C38E-438A-87DB-68737844FF70")]
[NativeTypeName("struct INamespaceWalkCB2 : INamespaceWalkCB")]
[NativeInheritance("INamespaceWalkCB")]
public unsafe partial struct INamespaceWalkCB2 : INamespaceWalkCB2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamespaceWalkCB2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<INamespaceWalkCB2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INamespaceWalkCB2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FoundItem(IShellFolder psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return (
            (delegate* unmanaged<INamespaceWalkCB2, IShellFolder, ITEMIDLIST*, int>)((*lpVtbl)[3])
        )(this, psf, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnterFolder(IShellFolder psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return (
            (delegate* unmanaged<INamespaceWalkCB2, IShellFolder, ITEMIDLIST*, int>)((*lpVtbl)[4])
        )(this, psf, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LeaveFolder(IShellFolder psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return (
            (delegate* unmanaged<INamespaceWalkCB2, IShellFolder, ITEMIDLIST*, int>)((*lpVtbl)[5])
        )(this, psf, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeProgressDialog(
        [NativeTypeName("LPWSTR *")] ushort** ppszTitle,
        [NativeTypeName("LPWSTR *")] ushort** ppszCancel
    )
    {
        return ((delegate* unmanaged<INamespaceWalkCB2, ushort**, ushort**, int>)((*lpVtbl)[6]))(
            this,
            ppszTitle,
            ppszCancel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WalkComplete(HRESULT hr)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2, HRESULT, int>)((*lpVtbl)[7]))(this, hr);
    }

    public interface Interface : INamespaceWalkCB.Interface
    {
        [VtblIndex(7)]
        HRESULT WalkComplete(HRESULT hr);
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

        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder, ITEMIDLIST*, int> FoundItem;

        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder, ITEMIDLIST*, int> EnterFolder;

        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder, ITEMIDLIST*, int> LeaveFolder;

        [NativeTypeName("HRESULT (LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, int> InitializeProgressDialog;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> WalkComplete;
    }

    /// <summary>Initializes a new instance of the <see cref = "INamespaceWalkCB2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public INamespaceWalkCB2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.INamespaceWalkCB"/> to <see cref = "INamespaceWalkCB2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.INamespaceWalkCB"/> instance to be converted </param>
    public static explicit operator INamespaceWalkCB2(Silk.NET.Windows.INamespaceWalkCB value)
    {
        return new INamespaceWalkCB2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INamespaceWalkCB2"/> to <see cref = "Silk.NET.Windows.INamespaceWalkCB"/>.</summary>
    /// <param name = "value">The <see cref = "INamespaceWalkCB2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.INamespaceWalkCB(INamespaceWalkCB2 value)
    {
        return new Silk.NET.Windows.INamespaceWalkCB(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "INamespaceWalkCB2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator INamespaceWalkCB2(Silk.NET.Windows.IUnknown value)
    {
        return new INamespaceWalkCB2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "INamespaceWalkCB2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "INamespaceWalkCB2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(INamespaceWalkCB2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
