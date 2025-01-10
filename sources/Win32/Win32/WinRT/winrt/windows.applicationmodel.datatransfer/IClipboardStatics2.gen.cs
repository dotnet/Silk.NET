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

[Guid("D2AC1B6A-D29F-554B-B303-F0452345FE02")]
[NativeTypeName("struct IClipboardStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IClipboardStatics2 : IClipboardStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IClipboardStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IClipboardStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IClipboardStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IClipboardStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IClipboardStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IClipboardStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IClipboardStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetHistoryItemsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IClipboardStatics2, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[6])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearHistory([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IClipboardStatics2, byte*, int>)((*lpVtbl)[7]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteItemFromHistory(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")]
            IClipboardHistoryItem item,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<IClipboardStatics2, IClipboardHistoryItem, byte*, int>)(
                (*lpVtbl)[8]
            )
        )(this, item, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHistoryItemAsContent(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *")]
            IClipboardHistoryItem item,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *"
        )]
            SetHistoryItemAsContentStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                IClipboardStatics2,
                IClipboardHistoryItem,
                SetHistoryItemAsContentStatus*,
                int>)((*lpVtbl)[9])
        )(this, item, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IsHistoryEnabled([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IClipboardStatics2, byte*, int>)((*lpVtbl)[10]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IsRoamingEnabled([NativeTypeName("boolean *")] byte* result)
    {
        return ((delegate* unmanaged<IClipboardStatics2, byte*, int>)((*lpVtbl)[11]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetContentWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")]
            IDataPackage content,
        [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *")]
            IClipboardContentOptions options,
        [NativeTypeName("boolean *")] byte* result
    )
    {
        return (
            (delegate* unmanaged<
                IClipboardStatics2,
                IDataPackage,
                IClipboardContentOptions,
                byte*,
                int>)((*lpVtbl)[12])
        )(this, content, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_HistoryChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *"
        )]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IClipboardStatics2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_HistoryChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IClipboardStatics2, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_RoamingEnabledChanged(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IClipboardStatics2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_RoamingEnabledChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IClipboardStatics2, EventRegistrationToken, int>)((*lpVtbl)[16])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_HistoryEnabledChanged(
        [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
            IEventHandler<IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IClipboardStatics2,
                IEventHandler<IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_HistoryEnabledChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IClipboardStatics2, EventRegistrationToken, int>)((*lpVtbl)[18])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetHistoryItemsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT ClearHistory([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(8)]
        HRESULT DeleteItemFromHistory(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *"
            )]
                IClipboardHistoryItem item,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(9)]
        HRESULT SetHistoryItemAsContent(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *"
            )]
                IClipboardHistoryItem item,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *"
            )]
                SetHistoryItemAsContentStatus* result
        );

        [VtblIndex(10)]
        HRESULT IsHistoryEnabled([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(11)]
        HRESULT IsRoamingEnabled([NativeTypeName("boolean *")] byte* result);

        [VtblIndex(12)]
        HRESULT SetContentWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *")]
                IDataPackage content,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *"
            )]
                IClipboardContentOptions options,
            [NativeTypeName("boolean *")] byte* result
        );

        [VtblIndex(13)]
        HRESULT add_HistoryChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *"
            )]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_HistoryChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_RoamingEnabledChanged(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_RoamingEnabledChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        HRESULT add_HistoryEnabledChanged(
            [NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")]
                IEventHandler<IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_HistoryEnabledChanged(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryItemsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetHistoryItemsAsync;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> ClearHistory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IClipboardHistoryItem, byte*, int> DeleteItemFromHistory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IClipboardHistoryItem *, ABI::Windows::ApplicationModel::DataTransfer::SetHistoryItemAsContentStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IClipboardHistoryItem,
            SetHistoryItemAsContentStatus*,
            int> SetHistoryItemAsContent;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsHistoryEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> IsRoamingEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::DataTransfer::IDataPackage *, ABI::Windows::ApplicationModel::DataTransfer::IClipboardContentOptions *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDataPackage,
            IClipboardContentOptions,
            byte*,
            int> SetContentWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_Windows__CApplicationModel__CDataTransfer__CClipboardHistoryChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_HistoryChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_HistoryChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_RoamingEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RoamingEnabledChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEventHandler<IntPtr>*,
            EventRegistrationToken*,
            int> add_HistoryEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_HistoryEnabledChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IClipboardStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IClipboardStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IClipboardStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IClipboardStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new IClipboardStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IClipboardStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IClipboardStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IClipboardStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IClipboardStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IClipboardStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new IClipboardStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IClipboardStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IClipboardStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IClipboardStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
