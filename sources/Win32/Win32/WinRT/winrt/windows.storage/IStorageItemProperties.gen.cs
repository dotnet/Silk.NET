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

[Guid("86664478-8029-46FE-A789-1C2F3E2FFB5C")]
[NativeTypeName("struct IStorageItemProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageItemProperties : IStorageItemProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageItemProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageItemProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageItemProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageItemProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageItemProperties, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageItemProperties, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageItemProperties, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetThumbnailAsyncOverloadDefaultSizeDefaultOptions(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageItemProperties,
                ThumbnailMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, mode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetThumbnailAsyncOverloadDefaultOptions(
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
                IStorageItemProperties,
                ThumbnailMode,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, mode, requestedSize, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetThumbnailAsync(
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
                IStorageItemProperties,
                ThumbnailMode,
                uint,
                ThumbnailOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, mode, requestedSize, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageItemProperties, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DisplayType(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageItemProperties, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_FolderRelativeId(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageItemProperties, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **")]
            IStorageItemContentProperties* value
    )
    {
        return (
            (delegate* unmanaged<IStorageItemProperties, IStorageItemContentProperties*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetThumbnailAsyncOverloadDefaultSizeDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT GetThumbnailAsyncOverloadDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName("UINT32")] uint requestedSize,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT GetThumbnailAsync(
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

        [VtblIndex(9)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_DisplayType(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_FolderRelativeId(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **"
            )]
                IStorageItemContentProperties* value
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
            int> GetThumbnailAsyncOverloadDefaultSizeDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            uint,
            IAsyncOperation<IntPtr>**,
            int> GetThumbnailAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CFileProperties__CStorageItemThumbnail_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            uint,
            ThumbnailOptions,
            IAsyncOperation<IntPtr>**,
            int> GetThumbnailAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FolderRelativeId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::IStorageItemContentProperties **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageItemContentProperties*, int> get_Properties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageItemProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageItemProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageItemProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageItemProperties(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageItemProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItemProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItemProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageItemProperties value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageItemProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageItemProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageItemProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageItemProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageItemProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageItemProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
