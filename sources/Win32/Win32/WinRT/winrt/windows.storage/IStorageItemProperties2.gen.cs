// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8E86A951-04B9-4BD2-929D-FEF3F71621D0")]
[NativeTypeName("struct IStorageItemProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemProperties2
    : IStorageItemProperties2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemProperties2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageItemProperties2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageItemProperties2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageItemProperties2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageItemProperties2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageItemProperties2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageItemProperties2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageItemProperties2,
                ThumbnailMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, mode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultOptions(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode,
        [NativeTypeName("UINT32")] uint requestedSize,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageItemProperties2,
                ThumbnailMode,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, mode, requestedSize, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetScaledImageAsThumbnailAsync(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode,
        [NativeTypeName("UINT32")] uint requestedSize,
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")]
            ThumbnailOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageItemProperties2,
                ThumbnailMode,
                uint,
                ThumbnailOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, mode, requestedSize, options, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetScaledImageAsThumbnailAsyncOverloadDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName("UINT32")] uint requestedSize,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT GetScaledImageAsThumbnailAsync(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName("UINT32")] uint requestedSize,
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")]
                ThumbnailOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            IAsyncOperation<IntPtr>**,
            int> GetScaledImageAsThumbnailAsyncOverloadDefaultSizeDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            uint,
            IAsyncOperation<IntPtr>**,
            int> GetScaledImageAsThumbnailAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            uint,
            ThumbnailOptions,
            IAsyncOperation<IntPtr>**,
            int> GetScaledImageAsThumbnailAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageItemProperties2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageItemProperties2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageItemProperties2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageItemProperties2(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageItemProperties2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItemProperties2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItemProperties2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageItemProperties2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageItemProperties2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageItemProperties2(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageItemProperties2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItemProperties2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItemProperties2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageItemProperties2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
