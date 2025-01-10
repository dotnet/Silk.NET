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

[Guid("98B017CE-FFC1-5B11-AE77-CC17AFEC1049")]
[NativeTypeName("struct IStorageProviderKnownFolderSyncInfo : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderKnownFolderSyncInfo
    : IStorageProviderKnownFolderSyncInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderKnownFolderSyncInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderDisplayName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProviderDisplayName(HSTRING value)
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, HSTRING, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KnownFolderEntries(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderKnownFolderEntry_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderKnownFolderSyncInfo, IVector<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SyncRequested(
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler **"
        )]
            IStorageProviderKnownFolderSyncRequestedHandler* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderSyncInfo,
                IStorageProviderKnownFolderSyncRequestedHandler*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SyncRequested(
        [NativeTypeName(
            "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler *"
        )]
            IStorageProviderKnownFolderSyncRequestedHandler value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderKnownFolderSyncInfo,
                IStorageProviderKnownFolderSyncRequestedHandler,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderDisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ProviderDisplayName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_KnownFolderEntries(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderKnownFolderEntry_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT get_SyncRequested(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler **"
            )]
                IStorageProviderKnownFolderSyncRequestedHandler* value
        );

        [VtblIndex(10)]
        HRESULT put_SyncRequested(
            [NativeTypeName(
                "ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler *"
            )]
                IStorageProviderKnownFolderSyncRequestedHandler value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ProviderDisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ProviderDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CProvider__CStorageProviderKnownFolderEntry_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_KnownFolderEntries;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageProviderKnownFolderSyncRequestedHandler*,
            int> get_SyncRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::IStorageProviderKnownFolderSyncRequestedHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageProviderKnownFolderSyncRequestedHandler,
            int> put_SyncRequested;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderKnownFolderSyncInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderKnownFolderSyncInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderKnownFolderSyncInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderKnownFolderSyncInfo(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStorageProviderKnownFolderSyncInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderKnownFolderSyncInfo"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderKnownFolderSyncInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStorageProviderKnownFolderSyncInfo value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderKnownFolderSyncInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderKnownFolderSyncInfo(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageProviderKnownFolderSyncInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderKnownFolderSyncInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderKnownFolderSyncInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageProviderKnownFolderSyncInfo value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
