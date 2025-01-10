// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5027351C-7D5E-4ADC-B8D3-DF5C6031B9CC")]
[NativeTypeName("struct IDownloadOperation3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDownloadOperation3 : IDownloadOperation3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDownloadOperation3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDownloadOperation3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDownloadOperation3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDownloadOperation3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDownloadOperation3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDownloadOperation3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDownloadOperation3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsRandomAccessRequired([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDownloadOperation3, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_IsRandomAccessRequired([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IDownloadOperation3, byte, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetResultRandomAccessStreamReference(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
            IRandomAccessStreamReference* stream
    )
    {
        return (
            (delegate* unmanaged<IDownloadOperation3, IRandomAccessStreamReference*, int>)(
                (*lpVtbl)[8]
            )
        )(this, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDownloadedRanges(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **"
        )]
            IVector<BackgroundTransferFileRange>** value
    )
    {
        return (
            (delegate* unmanaged<IDownloadOperation3, IVector<BackgroundTransferFileRange>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_RangesDownloaded(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferRangesDownloadedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IDownloadOperation3,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_RangesDownloaded(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<IDownloadOperation3, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_RequestedUri(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
    )
    {
        return ((delegate* unmanaged<IDownloadOperation3, IUriRuntimeClass, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_RecoverableWebErrorStatuses(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CWebErrorStatus_t **"
        )]
            IVector<WebErrorStatus>** value
    )
    {
        return (
            (delegate* unmanaged<IDownloadOperation3, IVector<WebErrorStatus>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CurrentWebErrorStatus(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CWeb__CWebErrorStatus_t **"
        )]
            IReference<WebErrorStatus>** value
    )
    {
        return (
            (delegate* unmanaged<IDownloadOperation3, IReference<WebErrorStatus>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsRandomAccessRequired([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_IsRandomAccessRequired([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT GetResultRandomAccessStreamReference(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStreamReference **")]
                IRandomAccessStreamReference* stream
        );

        [VtblIndex(9)]
        HRESULT GetDownloadedRanges(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **"
            )]
                IVector<BackgroundTransferFileRange>** value
        );

        [VtblIndex(10)]
        HRESULT add_RangesDownloaded(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferRangesDownloadedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(11)]
        HRESULT remove_RangesDownloaded(EventRegistrationToken eventCookie);

        [VtblIndex(12)]
        HRESULT put_RequestedUri(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass value
        );

        [VtblIndex(13)]
        HRESULT get_RecoverableWebErrorStatuses(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CWebErrorStatus_t **"
            )]
                IVector<WebErrorStatus>** value
        );

        [VtblIndex(14)]
        HRESULT get_CurrentWebErrorStatus(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CWeb__CWebErrorStatus_t **"
            )]
                IReference<WebErrorStatus>** value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsRandomAccessRequired;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsRandomAccessRequired;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStreamReference **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRandomAccessStreamReference*,
            int> GetResultRandomAccessStreamReference;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferFileRange_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector<BackgroundTransferFileRange>**,
            int> GetDownloadedRanges;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_Windows__CNetworking__CBackgroundTransfer__CBackgroundTransferRangesDownloadedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RangesDownloaded;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_RangesDownloaded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, int> put_RequestedUri;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CWeb__CWebErrorStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector<WebErrorStatus>**,
            int> get_RecoverableWebErrorStatuses;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CWeb__CWebErrorStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IReference<WebErrorStatus>**,
            int> get_CurrentWebErrorStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDownloadOperation3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDownloadOperation3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDownloadOperation3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDownloadOperation3(Silk.NET.WinRT.IInspectable value)
    {
        return new IDownloadOperation3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDownloadOperation3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDownloadOperation3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDownloadOperation3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDownloadOperation3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDownloadOperation3(Silk.NET.Windows.IUnknown value)
    {
        return new IDownloadOperation3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDownloadOperation3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDownloadOperation3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDownloadOperation3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
