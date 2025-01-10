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

[Guid("2564711D-AA89-4D12-82E3-F72A92E33966")]
[NativeTypeName("struct IStorageProviderGetContentInfoForPathResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageProviderGetContentInfoForPathResult
    : IStorageProviderGetContentInfoForPathResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderGetContentInfoForPathResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")]
            StorageProviderUriSourceStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderGetContentInfoForPathResult,
                StorageProviderUriSourceStatus*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Status(
        [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")]
            StorageProviderUriSourceStatus value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderGetContentInfoForPathResult,
                StorageProviderUriSourceStatus,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ContentUri(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, HSTRING*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ContentUri(HSTRING value)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, HSTRING, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, HSTRING*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ContentId(HSTRING value)
    {
        return (
            (delegate* unmanaged<IStorageProviderGetContentInfoForPathResult, HSTRING, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Status(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *")]
                StorageProviderUriSourceStatus* value
        );

        [VtblIndex(7)]
        HRESULT put_Status(
            [NativeTypeName("ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus")]
                StorageProviderUriSourceStatus value
        );

        [VtblIndex(8)]
        HRESULT get_ContentUri(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_ContentUri(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_ContentId(HSTRING value);
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderUriSourceStatus*, int> get_Status;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Provider::StorageProviderUriSourceStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, StorageProviderUriSourceStatus, int> put_Status;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentUri;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContentUri;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContentId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderGetContentInfoForPathResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderGetContentInfoForPathResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageProviderGetContentInfoForPathResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageProviderGetContentInfoForPathResult(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStorageProviderGetContentInfoForPathResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderGetContentInfoForPathResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderGetContentInfoForPathResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStorageProviderGetContentInfoForPathResult value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderGetContentInfoForPathResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderGetContentInfoForPathResult(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageProviderGetContentInfoForPathResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderGetContentInfoForPathResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderGetContentInfoForPathResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageProviderGetContentInfoForPathResult value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
