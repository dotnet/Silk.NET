// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("EFFA7DB0-1D44-596B-8464-928800C5E2D8")]
[NativeTypeName("struct IStorageProviderKnownFolderEntry : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderKnownFolderEntry
    : IStorageProviderKnownFolderEntry.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderKnownFolderEntry));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderEntry, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderEntry, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderEntry, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderEntry, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderEntry, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderEntry, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_KnownFolderId(Guid* value)
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderEntry, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_KnownFolderId(Guid value)
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderEntry, Guid, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus *")]
            StorageProviderKnownFolderSyncStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderEntry,
                StorageProviderKnownFolderSyncStatus*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus")]
            StorageProviderKnownFolderSyncStatus value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderEntry,
                StorageProviderKnownFolderSyncStatus,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_KnownFolderId(Guid* value);

        [VtblIndex(7)]
        HRESULT put_KnownFolderId(Guid value);

        [VtblIndex(8)]
        HRESULT get_Status(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus *"
            )]
                StorageProviderKnownFolderSyncStatus* value
        );

        [VtblIndex(9)]
        HRESULT put_Status(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus"
            )]
                StorageProviderKnownFolderSyncStatus value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_KnownFolderId;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> put_KnownFolderId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderKnownFolderSyncStatus*, int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderKnownFolderSyncStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderKnownFolderSyncStatus, int> put_Status;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderKnownFolderEntry"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderKnownFolderEntry(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderKnownFolderEntry"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderKnownFolderEntry(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStorageProviderKnownFolderEntry(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderKnownFolderEntry"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderKnownFolderEntry"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStorageProviderKnownFolderEntry value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderKnownFolderEntry"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderKnownFolderEntry(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageProviderKnownFolderEntry(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderKnownFolderEntry"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderKnownFolderEntry"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageProviderKnownFolderEntry value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
