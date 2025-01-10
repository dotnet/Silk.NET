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

[Guid("61EBF5C7-EFEA-4346-9554-981D7E198FFE")]
[NativeTypeName("struct IDataPackage : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataPackage : IDataPackage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataPackage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataPackage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataPackage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataPackage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataPackage, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataPackage, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataPackage, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetView(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")]
            IDataPackageView* result
    )
    {
        return ((delegate* unmanaged<IDataPackage, IDataPackageView*, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Properties(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **")]
            IDataPackagePropertySet* value
    )
    {
        return ((delegate* unmanaged<IDataPackage, IDataPackagePropertySet*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RequestedOperation(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")]
            DataPackageOperation* value
    )
    {
        return ((delegate* unmanaged<IDataPackage, DataPackageOperation*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_RequestedOperation(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")]
            DataPackageOperation value
    )
    {
        return ((delegate* unmanaged<IDataPackage, DataPackageOperation, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_OperationCompleted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDataPackage,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_OperationCompleted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDataPackage, EventRegistrationToken, int>)((*lpVtbl)[11]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_Destroyed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDataPackage,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_Destroyed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IDataPackage, EventRegistrationToken, int>)((*lpVtbl)[13]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetData(HSTRING formatId, IInspectable value)
    {
        return ((delegate* unmanaged<IDataPackage, HSTRING, IInspectable, int>)((*lpVtbl)[14]))(
            this,
            formatId,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetDataProvider(
        HSTRING formatId,
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *")]
            IDataProviderHandler delayRenderer
    )
    {
        return (
            (delegate* unmanaged<IDataPackage, HSTRING, IDataProviderHandler, int>)((*lpVtbl)[15])
        )(this, formatId, delayRenderer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetText(HSTRING value)
    {
        return ((delegate* unmanaged<IDataPackage, HSTRING, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete(
        "SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink."
    )]
    public HRESULT SetUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return ((delegate* unmanaged<IDataPackage, IUriRuntimeClass, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetHtmlFormat(HSTRING value)
    {
        return ((delegate* unmanaged<IDataPackage, HSTRING, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_ResourceMap(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
        )]
            IMap<HSTRING, IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IDataPackage, IMap<HSTRING, IntPtr>**, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetRtf(HSTRING value)
    {
        return ((delegate* unmanaged<IDataPackage, HSTRING, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetBitmap(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
            IRandomAccessStreamReference value
    )
    {
        return (
            (delegate* unmanaged<IDataPackage, IRandomAccessStreamReference, int>)((*lpVtbl)[21])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetStorageItemsReadOnly(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* value
    )
    {
        return ((delegate* unmanaged<IDataPackage, IIterable<IntPtr>*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetStorageItems(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
        )]
            IIterable<IntPtr>* value,
        [NativeTypeName("boolean")] byte readOnly
    )
    {
        return ((delegate* unmanaged<IDataPackage, IIterable<IntPtr>*, byte, int>)((*lpVtbl)[23]))(
            this,
            value,
            readOnly
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetView(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **")]
                IDataPackageView* result
        );

        [VtblIndex(7)]
        HRESULT get_Properties(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **"
            )]
                IDataPackagePropertySet* value
        );

        [VtblIndex(8)]
        HRESULT get_RequestedOperation(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *")]
                DataPackageOperation* value
        );

        [VtblIndex(9)]
        HRESULT put_RequestedOperation(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation")]
                DataPackageOperation value
        );

        [VtblIndex(10)]
        HRESULT add_OperationCompleted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_OperationCompleted(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_Destroyed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_Destroyed(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT SetData(HSTRING formatId, IInspectable value);

        [VtblIndex(15)]
        HRESULT SetDataProvider(
            HSTRING formatId,
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *")]
                IDataProviderHandler delayRenderer
        );

        [VtblIndex(16)]
        HRESULT SetText(HSTRING value);

        [VtblIndex(17)]
        [Obsolete(
            "SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink."
        )]
        HRESULT SetUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(18)]
        HRESULT SetHtmlFormat(HSTRING value);

        [VtblIndex(19)]
        HRESULT get_ResourceMap(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **"
            )]
                IMap<HSTRING, IntPtr>** value
        );

        [VtblIndex(20)]
        HRESULT SetRtf(HSTRING value);

        [VtblIndex(21)]
        HRESULT SetBitmap(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference *")]
                IRandomAccessStreamReference value
        );

        [VtblIndex(22)]
        HRESULT SetStorageItemsReadOnly(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* value
        );

        [VtblIndex(23)]
        HRESULT SetStorageItems(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *"
            )]
                IIterable<IntPtr>* value,
            [NativeTypeName("boolean")] byte readOnly
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
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackageView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackageView*, int> GetView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackagePropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataPackagePropertySet*, int> get_Properties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DataPackageOperation*, int> get_RequestedOperation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::DataPackageOperation) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DataPackageOperation, int> put_RequestedOperation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_Windows__CApplicationModel__CDataTransfer__COperationCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_OperationCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_OperationCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CDataTransfer__CDataPackage_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Destroyed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Destroyed;

        [NativeTypeName("HRESULT (HSTRING, IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, IInspectable, int> SetData;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::DataTransfer::IDataProviderHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IDataProviderHandler, int> SetDataProvider;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetText;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SetUri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD).Instead, use SetWebLink or SetApplicationLink."
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> SetUri;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetHtmlFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMap_2_HSTRING_Windows__CStorage__CStreams__CRandomAccessStreamReference_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMap<HSTRING, IntPtr>**, int> get_ResourceMap;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetRtf;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStreamReference, int> SetBitmap;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIterable<IntPtr>*, int> SetStorageItemsReadOnly;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CStorage__CIStorageItem_t *, boolean) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIterable<IntPtr>*, byte, int> SetStorageItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataPackage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataPackage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataPackage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataPackage(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataPackage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackage"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackage"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataPackage value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataPackage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataPackage(Silk.NET.Windows.IUnknown value)
    {
        return new IDataPackage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataPackage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataPackage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataPackage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
