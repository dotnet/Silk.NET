// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("48ADDD32-3CA5-4124-ABE3-B5A72531B207")]
[NativeTypeName("struct ITransferDestination : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITransferDestination : ITransferDestination.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITransferDestination));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITransferDestination, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITransferDestination, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITransferDestination, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(ITransferAdviseSink psink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return (
            (delegate* unmanaged<ITransferDestination, ITransferAdviseSink, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, psink, pdwCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITransferDestination, uint, int>)((*lpVtbl)[4]))(
            this,
            dwCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateItem(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("DWORD")] uint dwAttributes,
        [NativeTypeName("ULONGLONG")] ulong ullSize,
        [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
        [NativeTypeName("const IID &")] Guid* riidItem,
        void** ppvItem,
        [NativeTypeName("const IID &")] Guid* riidResources,
        void** ppvResources
    )
    {
        return (
            (delegate* unmanaged<
                ITransferDestination,
                ushort*,
                uint,
                ulong,
                uint,
                Guid*,
                void**,
                Guid*,
                void**,
                int>)((*lpVtbl)[5])
        )(
            this,
            pszName,
            dwAttributes,
            ullSize,
            flags,
            riidItem,
            ppvItem,
            riidResources,
            ppvResources
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(ITransferAdviseSink psink, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(5)]
        HRESULT CreateItem(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("DWORD")] uint dwAttributes,
            [NativeTypeName("ULONGLONG")] ulong ullSize,
            [NativeTypeName("TRANSFER_SOURCE_FLAGS")] uint flags,
            [NativeTypeName("const IID &")] Guid* riidItem,
            void** ppvItem,
            [NativeTypeName("const IID &")] Guid* riidResources,
            void** ppvResources
        );
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

        [NativeTypeName("HRESULT (ITransferAdviseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITransferAdviseSink, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, ULONGLONG, TRANSFER_SOURCE_FLAGS, const IID &, void **, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            ulong,
            uint,
            Guid*,
            void**,
            Guid*,
            void**,
            int> CreateItem;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITransferDestination"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITransferDestination(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITransferDestination"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITransferDestination(Silk.NET.Windows.IUnknown value)
    {
        return new ITransferDestination(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITransferDestination"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITransferDestination"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITransferDestination value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
