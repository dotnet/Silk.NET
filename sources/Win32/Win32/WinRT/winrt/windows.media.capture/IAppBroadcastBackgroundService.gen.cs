// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BAD1E72A-FA94-46F9-95FC-D71511CDA70B")]
[NativeTypeName("struct IAppBroadcastBackgroundService : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastBackgroundService
    : IAppBroadcastBackgroundService.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastBackgroundService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastBackgroundService, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastBackgroundService, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastBackgroundService, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_PlugInState(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState")]
            AppBroadcastPlugInState value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, AppBroadcastPlugInState, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PlugInState(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")]
            AppBroadcastPlugInState* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, AppBroadcastPlugInState*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_SignInInfo(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *")]
            IAppBroadcastBackgroundServiceSignInInfo value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                IAppBroadcastBackgroundServiceSignInInfo,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SignInInfo(
        [NativeTypeName(
            "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **"
        )]
            IAppBroadcastBackgroundServiceSignInInfo* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                IAppBroadcastBackgroundServiceSignInInfo*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_StreamInfo(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *")]
            IAppBroadcastBackgroundServiceStreamInfo value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                IAppBroadcastBackgroundServiceStreamInfo,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StreamInfo(
        [NativeTypeName(
            "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **"
        )]
            IAppBroadcastBackgroundServiceStreamInfo* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                IAppBroadcastBackgroundServiceStreamInfo*,
                int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppId(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, HSTRING*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BroadcastTitle(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, HSTRING*, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_ViewerCount([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IAppBroadcastBackgroundService, uint, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastBackgroundService, uint*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT TerminateBroadcast(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason")]
            AppBroadcastTerminationReason reason,
        [NativeTypeName("UINT32")] uint providerSpecificReason
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                AppBroadcastTerminationReason,
                uint,
                int>)((*lpVtbl)[16])
        )(this, reason, providerSpecificReason);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT add_HeartbeatRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastBackgroundService,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT remove_HeartbeatRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, EventRegistrationToken, int>)(
                (*lpVtbl)[18]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_TitleId(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IAppBroadcastBackgroundService, HSTRING*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_PlugInState(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState")]
                AppBroadcastPlugInState value
        );

        [VtblIndex(7)]
        HRESULT get_PlugInState(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPlugInState *")]
                AppBroadcastPlugInState* value
        );

        [VtblIndex(8)]
        HRESULT put_SignInInfo(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *"
            )]
                IAppBroadcastBackgroundServiceSignInInfo value
        );

        [VtblIndex(9)]
        HRESULT get_SignInInfo(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **"
            )]
                IAppBroadcastBackgroundServiceSignInInfo* value
        );

        [VtblIndex(10)]
        HRESULT put_StreamInfo(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *"
            )]
                IAppBroadcastBackgroundServiceStreamInfo value
        );

        [VtblIndex(11)]
        HRESULT get_StreamInfo(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **"
            )]
                IAppBroadcastBackgroundServiceStreamInfo* value
        );

        [VtblIndex(12)]
        HRESULT get_AppId(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_BroadcastTitle(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_ViewerCount([NativeTypeName("UINT32")] uint value);

        [VtblIndex(15)]
        HRESULT get_ViewerCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT TerminateBroadcast(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastTerminationReason")]
                AppBroadcastTerminationReason reason,
            [NativeTypeName("UINT32")] uint providerSpecificReason
        );

        [VtblIndex(17)]
        HRESULT add_HeartbeatRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        HRESULT remove_HeartbeatRequested(EventRegistrationToken token);

        [VtblIndex(19)]
        HRESULT get_TitleId(HSTRING* value);
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
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastPlugInState) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppBroadcastPlugInState, int> put_PlugInState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastPlugInState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppBroadcastPlugInState*, int> get_PlugInState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastBackgroundServiceSignInInfo,
            int> put_SignInInfo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceSignInInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastBackgroundServiceSignInInfo*,
            int> get_SignInInfo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastBackgroundServiceStreamInfo,
            int> put_StreamInfo;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastBackgroundServiceStreamInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastBackgroundServiceStreamInfo*,
            int> get_StreamInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AppId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_BroadcastTitle;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_ViewerCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_ViewerCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastTerminationReason, UINT32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastTerminationReason,
            uint,
            int> TerminateBroadcast;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastBackgroundService_Windows__CMedia__CCapture__CAppBroadcastHeartbeatRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_HeartbeatRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_HeartbeatRequested;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TitleId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastBackgroundService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastBackgroundService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastBackgroundService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastBackgroundService(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAppBroadcastBackgroundService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastBackgroundService"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastBackgroundService"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAppBroadcastBackgroundService value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastBackgroundService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastBackgroundService(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastBackgroundService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastBackgroundService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastBackgroundService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastBackgroundService value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
