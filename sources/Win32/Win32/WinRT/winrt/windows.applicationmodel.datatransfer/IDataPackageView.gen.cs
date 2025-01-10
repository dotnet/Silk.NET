// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.datatransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7B840471-5900-4D85-A90B-10CB85FE3552")]
[NativeTypeName("struct IDataPackageView : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackageView : IDataPackageView.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackageView));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataPackageView, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataPackageView, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPackageView, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataPackageView, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPackageView, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataPackageView, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Properties(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **"
        )]
            IDataPackagePropertySetView* value
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IDataPackagePropertySetView*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestedOperation(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")]
            DataPackageOperation* value
    )
    {
        return ((delegate* unmanaged<IDataPackageView, DataPackageOperation*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReportOperationCompleted(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")]
            DataPackageOperation value
    )
    {
        return ((delegate* unmanaged<IDataPackageView, DataPackageOperation, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AvailableFormats(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
            IVectorView<HSTRING>** formatIds
    )
    {
        return ((delegate* unmanaged<IDataPackageView, IVectorView<HSTRING>**, int>)((*lpVtbl)[9]))(
            this,
            formatIds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Contains(HSTRING formatId, [NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDataPackageView, HSTRING, byte*, int>)((*lpVtbl)[10]))(
            this,
            formatId,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetDataAsync(
        HSTRING formatId,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, formatId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetTextAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<HSTRING>**, int>)((*lpVtbl)[12])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCustomTextAsync(
        HSTRING formatId,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, HSTRING, IAsyncOperation<HSTRING>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, formatId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync."
    )]
    public HRESULT GetUriAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[14])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetHtmlFormatAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<HSTRING>**, int>)((*lpVtbl)[15])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetResourceMapAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[16])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetRtfAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<HSTRING>**, int>)((*lpVtbl)[17])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetBitmapAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[18])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetStorageItemsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataPackageView, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[19])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **"
            )]
                IDataPackagePropertySetView* value
        );

        [VtblIndex(7)]
        HRESULT get_RequestedOperation(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")]
                DataPackageOperation* value
        );

        [VtblIndex(8)]
        HRESULT ReportOperationCompleted(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")]
                DataPackageOperation value
        );

        [VtblIndex(9)]
        HRESULT get_AvailableFormats(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **")]
                IVectorView<HSTRING>** formatIds
        );

        [VtblIndex(10)]
        HRESULT Contains(HSTRING formatId, [NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT GetDataAsync(
            HSTRING formatId,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT GetTextAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(13)]
        HRESULT GetCustomTextAsync(
            HSTRING formatId,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(14)]
        [Obsolete(
            "GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync."
        )]
        HRESULT GetUriAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(15)]
        HRESULT GetHtmlFormatAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(16)]
        HRESULT GetResourceMapAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(17)]
        HRESULT GetRtfAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** operation
        );

        [VtblIndex(18)]
        HRESULT GetBitmapAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(19)]
        HRESULT GetStorageItemsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
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
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySetView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackagePropertySetView*, int> get_Properties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DataPackageOperation*, int> get_RequestedOperation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DataPackageOperation, int> ReportOperationCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<HSTRING>**, int> get_AvailableFormats;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> Contains;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetDataAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<HSTRING>**, int> GetTextAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<HSTRING>**,
            int> GetCustomTextAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "GetUriAsync may be altered or unavailable for releases after Windows 8.1. Instead, use GetWebLinkAsync or GetApplicationLinkAsync."
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetUriAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<HSTRING>**, int> GetHtmlFormatAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetResourceMapAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<HSTRING>**, int> GetRtfAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetBitmapAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetStorageItemsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPackageView"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPackageView(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPackageView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPackageView(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPackageView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackageView"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackageView"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPackageView value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPackageView"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPackageView(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPackageView(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackageView"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackageView"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPackageView value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
