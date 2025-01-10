// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1A4C1DEA-CAFC-50E7-8718-EA3F81CBFA51")]
[NativeTypeName("struct IAudioPlaybackConnection : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioPlaybackConnection
    : IAudioPlaybackConnection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioPlaybackConnection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioPlaybackConnection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT StartAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, IAsyncAction*, int>)((*lpVtbl)[7]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DeviceId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAudioPlaybackConnection, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_State(
        [NativeTypeName("ABI::Windows::Media::Audio::AudioPlaybackConnectionState *")]
            AudioPlaybackConnectionState* value
    )
    {
        return (
            (delegate* unmanaged<IAudioPlaybackConnection, AudioPlaybackConnectionState*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Open(
        [NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **")]
            IAudioPlaybackConnectionOpenResult* result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioPlaybackConnection,
                IAudioPlaybackConnectionOpenResult*,
                int>)((*lpVtbl)[10])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IAudioPlaybackConnection, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_StateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAudioPlaybackConnection,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_StateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAudioPlaybackConnection, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Start();

        [VtblIndex(7)]
        HRESULT StartAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        HRESULT get_DeviceId(HSTRING* value);

        [VtblIndex(9)]
        HRESULT get_State(
            [NativeTypeName("ABI::Windows::Media::Audio::AudioPlaybackConnectionState *")]
                AudioPlaybackConnectionState* value
        );

        [VtblIndex(10)]
        HRESULT Open(
            [NativeTypeName("ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **")]
                IAudioPlaybackConnectionOpenResult* result
        );

        [VtblIndex(11)]
        HRESULT OpenAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT add_StateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_StateChanged(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> StartAsync;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DeviceId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::AudioPlaybackConnectionState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioPlaybackConnectionState*, int> get_State;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Audio::IAudioPlaybackConnectionOpenResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAudioPlaybackConnectionOpenResult*, int> Open;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CAudioPlaybackConnectionOpenResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> OpenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CAudio__CAudioPlaybackConnection_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_StateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StateChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioPlaybackConnection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioPlaybackConnection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioPlaybackConnection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioPlaybackConnection(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioPlaybackConnection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioPlaybackConnection"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioPlaybackConnection"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioPlaybackConnection value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioPlaybackConnection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioPlaybackConnection(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioPlaybackConnection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioPlaybackConnection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioPlaybackConnection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioPlaybackConnection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
