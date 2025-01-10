// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.casting.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CD951653-C2F1-4498-8B78-5FB4CD3640DD")]
[NativeTypeName("struct ICastingConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICastingConnection : ICastingConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICastingConnection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICastingConnection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICastingConnection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICastingConnection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICastingConnection, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICastingConnection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICastingConnection, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_State(
        [NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionState *")]
            CastingConnectionState* value
    )
    {
        return (
            (delegate* unmanaged<ICastingConnection, CastingConnectionState*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Device(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingDevice **")] ICastingDevice* value
    )
    {
        return ((delegate* unmanaged<ICastingConnection, ICastingDevice*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Source(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")] ICastingSource* value
    )
    {
        return ((delegate* unmanaged<ICastingConnection, ICastingSource*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Source(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource value
    )
    {
        return ((delegate* unmanaged<ICastingConnection, ICastingSource, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_StateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICastingConnection,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICastingConnection, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_ErrorOccurred(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ICastingConnection,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_ErrorOccurred(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ICastingConnection, EventRegistrationToken, int>)((*lpVtbl)[13])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT RequestStartCastingAsync(
        [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource value,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **"
        )]
            IAsyncOperation<CastingConnectionErrorStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ICastingConnection,
                ICastingSource,
                IAsyncOperation<CastingConnectionErrorStatus>**,
                int>)((*lpVtbl)[14])
        )(this, value, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT DisconnectAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **"
        )]
            IAsyncOperation<CastingConnectionErrorStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ICastingConnection,
                IAsyncOperation<CastingConnectionErrorStatus>**,
                int>)((*lpVtbl)[15])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_State(
            [NativeTypeName("ABI::Windows::Media::Casting::CastingConnectionState *")]
                CastingConnectionState* value
        );

        [VtblIndex(7)]
        HRESULT get_Device(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingDevice **")]
                ICastingDevice* value
        );

        [VtblIndex(8)]
        HRESULT get_Source(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource **")]
                ICastingSource* value
        );

        [VtblIndex(9)]
        HRESULT put_Source(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource value
        );

        [VtblIndex(10)]
        HRESULT add_StateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_StateChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_ErrorOccurred(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_ErrorOccurred(EventRegistrationToken token);

        [VtblIndex(14)]
        HRESULT RequestStartCastingAsync(
            [NativeTypeName("ABI::Windows::Media::Casting::ICastingSource *")] ICastingSource value,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **"
            )]
                IAsyncOperation<CastingConnectionErrorStatus>** operation
        );

        [VtblIndex(15)]
        HRESULT DisconnectAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **"
            )]
                IAsyncOperation<CastingConnectionErrorStatus>** operation
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
            "HRESULT (ABI::Windows::Media::Casting::CastingConnectionState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CastingConnectionState*, int> get_State;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Casting::ICastingDevice **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICastingDevice*, int> get_Device;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Casting::ICastingSource **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICastingSource*, int> get_Source;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Casting::ICastingSource *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICastingSource, int> put_Source;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCasting__CCastingConnection_Windows__CMedia__CCasting__CCastingConnectionErrorOccurredEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ErrorOccurred;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ErrorOccurred;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Casting::ICastingSource *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICastingSource,
            IAsyncOperation<CastingConnectionErrorStatus>**,
            int> RequestStartCastingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CCasting__CCastingConnectionErrorStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<CastingConnectionErrorStatus>**,
            int> DisconnectAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICastingConnection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICastingConnection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICastingConnection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICastingConnection(Silk.NET.WinRT.IInspectable value)
    {
        return new ICastingConnection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingConnection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingConnection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICastingConnection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICastingConnection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICastingConnection(Silk.NET.Windows.IUnknown value)
    {
        return new ICastingConnection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICastingConnection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICastingConnection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICastingConnection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
