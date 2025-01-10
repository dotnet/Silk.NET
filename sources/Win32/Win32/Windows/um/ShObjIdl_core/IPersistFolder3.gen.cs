// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CEF04FDF-FE72-11D2-87A5-00C04F6837CF")]
[NativeTypeName("struct IPersistFolder3 : IPersistFolder2")]
[NativeInheritance("IPersistFolder2")]
public unsafe partial struct IPersistFolder3 : IPersistFolder3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistFolder3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistFolder3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistFolder3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistFolder3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistFolder3, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IPersistFolder3, ITEMIDLIST*, int>)((*lpVtbl)[4]))(this, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurFolder([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IPersistFolder3, ITEMIDLIST**, int>)((*lpVtbl)[5]))(
            this,
            ppidl
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeEx(
        IBindCtx pbc,
        [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlRoot,
        [NativeTypeName("const PERSIST_FOLDER_TARGET_INFO *")] PERSIST_FOLDER_TARGET_INFO* ppfti
    )
    {
        return (
            (delegate* unmanaged<
                IPersistFolder3,
                IBindCtx,
                ITEMIDLIST*,
                PERSIST_FOLDER_TARGET_INFO*,
                int>)((*lpVtbl)[6])
        )(this, pbc, pidlRoot, ppfti);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFolderTargetInfo(PERSIST_FOLDER_TARGET_INFO* ppfti)
    {
        return (
            (delegate* unmanaged<IPersistFolder3, PERSIST_FOLDER_TARGET_INFO*, int>)((*lpVtbl)[7])
        )(this, ppfti);
    }

    public interface Interface : IPersistFolder2.Interface
    {
        [VtblIndex(6)]
        HRESULT InitializeEx(
            IBindCtx pbc,
            [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlRoot,
            [NativeTypeName("const PERSIST_FOLDER_TARGET_INFO *")] PERSIST_FOLDER_TARGET_INFO* ppfti
        );

        [VtblIndex(7)]
        HRESULT GetFolderTargetInfo(PERSIST_FOLDER_TARGET_INFO* ppfti);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> Initialize;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetCurFolder;

        [NativeTypeName(
            "HRESULT (IBindCtx *, LPCITEMIDLIST, const PERSIST_FOLDER_TARGET_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBindCtx,
            ITEMIDLIST*,
            PERSIST_FOLDER_TARGET_INFO*,
            int> InitializeEx;

        [NativeTypeName("HRESULT (PERSIST_FOLDER_TARGET_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PERSIST_FOLDER_TARGET_INFO*, int> GetFolderTargetInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistFolder3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistFolder3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersistFolder2"/> to <see cref = "IPersistFolder3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersistFolder2"/> instance to be converted </param>
    public static explicit operator IPersistFolder3(Silk.NET.Windows.IPersistFolder2 value)
    {
        return new IPersistFolder3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFolder3"/> to <see cref = "Silk.NET.Windows.IPersistFolder2"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFolder3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersistFolder2(IPersistFolder3 value)
    {
        return new Silk.NET.Windows.IPersistFolder2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersistFolder"/> to <see cref = "IPersistFolder3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersistFolder"/> instance to be converted </param>
    public static explicit operator IPersistFolder3(Silk.NET.Windows.IPersistFolder value)
    {
        return new IPersistFolder3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFolder3"/> to <see cref = "Silk.NET.Windows.IPersistFolder"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFolder3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersistFolder(IPersistFolder3 value)
    {
        return new Silk.NET.Windows.IPersistFolder(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistFolder3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistFolder3(Silk.NET.Windows.IPersist value)
    {
        return new IPersistFolder3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFolder3"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFolder3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistFolder3 value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistFolder3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistFolder3(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistFolder3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFolder3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFolder3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistFolder3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
