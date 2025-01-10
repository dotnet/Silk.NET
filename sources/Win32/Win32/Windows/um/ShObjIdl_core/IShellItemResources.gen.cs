// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FF5693BE-2CE0-4D48-B5C5-40817D1ACDB9")]
[NativeTypeName("struct IShellItemResources : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItemResources : IShellItemResources.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItemResources));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItemResources, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellItemResources, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItemResources, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAttributes([NativeTypeName("DWORD *")] uint* pdwAttributes)
    {
        return ((delegate* unmanaged<IShellItemResources, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwAttributes
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSize([NativeTypeName("ULONGLONG *")] ulong* pullSize)
    {
        return ((delegate* unmanaged<IShellItemResources, ulong*, int>)((*lpVtbl)[4]))(
            this,
            pullSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTimes(FILETIME* pftCreation, FILETIME* pftWrite, FILETIME* pftAccess)
    {
        return (
            (delegate* unmanaged<IShellItemResources, FILETIME*, FILETIME*, FILETIME*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pftCreation, pftWrite, pftAccess);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTimes(
        [NativeTypeName("const FILETIME *")] FILETIME* pftCreation,
        [NativeTypeName("const FILETIME *")] FILETIME* pftWrite,
        [NativeTypeName("const FILETIME *")] FILETIME* pftAccess
    )
    {
        return (
            (delegate* unmanaged<IShellItemResources, FILETIME*, FILETIME*, FILETIME*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pftCreation, pftWrite, pftAccess);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResourceDescription(
        [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
        [NativeTypeName("LPWSTR *")] ushort** ppszDescription
    )
    {
        return (
            (delegate* unmanaged<IShellItemResources, SHELL_ITEM_RESOURCE*, ushort**, int>)(
                (*lpVtbl)[7]
            )
        )(this, pcsir, ppszDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumResources(IEnumResources* ppenumr)
    {
        return ((delegate* unmanaged<IShellItemResources, IEnumResources*, int>)((*lpVtbl)[8]))(
            this,
            ppenumr
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SupportsResource(
        [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir
    )
    {
        return (
            (delegate* unmanaged<IShellItemResources, SHELL_ITEM_RESOURCE*, int>)((*lpVtbl)[9])
        )(this, pcsir);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenResource(
        [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellItemResources, SHELL_ITEM_RESOURCE*, Guid*, void**, int>)(
                (*lpVtbl)[10]
            )
        )(this, pcsir, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateResource(
        [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellItemResources, SHELL_ITEM_RESOURCE*, Guid*, void**, int>)(
                (*lpVtbl)[11]
            )
        )(this, pcsir, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MarkForDelete()
    {
        return ((delegate* unmanaged<IShellItemResources, int>)((*lpVtbl)[12]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAttributes([NativeTypeName("DWORD *")] uint* pdwAttributes);

        [VtblIndex(4)]
        HRESULT GetSize([NativeTypeName("ULONGLONG *")] ulong* pullSize);

        [VtblIndex(5)]
        HRESULT GetTimes(FILETIME* pftCreation, FILETIME* pftWrite, FILETIME* pftAccess);

        [VtblIndex(6)]
        HRESULT SetTimes(
            [NativeTypeName("const FILETIME *")] FILETIME* pftCreation,
            [NativeTypeName("const FILETIME *")] FILETIME* pftWrite,
            [NativeTypeName("const FILETIME *")] FILETIME* pftAccess
        );

        [VtblIndex(7)]
        HRESULT GetResourceDescription(
            [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
            [NativeTypeName("LPWSTR *")] ushort** ppszDescription
        );

        [VtblIndex(8)]
        HRESULT EnumResources(IEnumResources* ppenumr);

        [VtblIndex(9)]
        HRESULT SupportsResource(
            [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir
        );

        [VtblIndex(10)]
        HRESULT OpenResource(
            [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(11)]
        HRESULT CreateResource(
            [NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(12)]
        HRESULT MarkForDelete();
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAttributes;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetSize;

        [NativeTypeName("HRESULT (FILETIME *, FILETIME *, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> GetTimes;

        [NativeTypeName(
            "HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> SetTimes;

        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            SHELL_ITEM_RESOURCE*,
            ushort**,
            int> GetResourceDescription;

        [NativeTypeName("HRESULT (IEnumResources **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumResources*, int> EnumResources;

        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, int> SupportsResource;

        [NativeTypeName(
            "HRESULT (const SHELL_ITEM_RESOURCE *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> OpenResource;

        [NativeTypeName(
            "HRESULT (const SHELL_ITEM_RESOURCE *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> CreateResource;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MarkForDelete;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellItemResources"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellItemResources(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellItemResources"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellItemResources(Silk.NET.Windows.IUnknown value)
    {
        return new IShellItemResources(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellItemResources"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellItemResources"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellItemResources value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
