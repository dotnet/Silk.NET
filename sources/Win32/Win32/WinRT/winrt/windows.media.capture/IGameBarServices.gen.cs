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

[Guid("2DBEAD57-50A6-499E-8C6C-D330A7311796")]
[NativeTypeName("struct IGameBarServices : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGameBarServices : IGameBarServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGameBarServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGameBarServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGameBarServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGameBarServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGameBarServices, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGameBarServices, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGameBarServices, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TargetCapturePolicy(
        [NativeTypeName("ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *")]
            GameBarTargetCapturePolicy* value
    )
    {
        return (
            (delegate* unmanaged<IGameBarServices, GameBarTargetCapturePolicy*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableCapture()
    {
        return ((delegate* unmanaged<IGameBarServices, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DisableCapture()
    {
        return ((delegate* unmanaged<IGameBarServices, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_TargetInfo(
        [NativeTypeName("ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **")]
            IGameBarServicesTargetInfo* value
    )
    {
        return (
            (delegate* unmanaged<IGameBarServices, IGameBarServicesTargetInfo*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SessionId(HSTRING* value)
    {
        return ((delegate* unmanaged<IGameBarServices, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_AppBroadcastServices(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastServices **")]
            IAppBroadcastServices* value
    )
    {
        return (
            (delegate* unmanaged<IGameBarServices, IAppBroadcastServices*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_AppCaptureServices(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureServices **")]
            IAppCaptureServices* value
    )
    {
        return ((delegate* unmanaged<IGameBarServices, IAppCaptureServices*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_CommandReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IGameBarServices,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_CommandReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IGameBarServices, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TargetCapturePolicy(
            [NativeTypeName("ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *")]
                GameBarTargetCapturePolicy* value
        );

        [VtblIndex(7)]
        HRESULT EnableCapture();

        [VtblIndex(8)]
        HRESULT DisableCapture();

        [VtblIndex(9)]
        HRESULT get_TargetInfo(
            [NativeTypeName("ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **")]
                IGameBarServicesTargetInfo* value
        );

        [VtblIndex(10)]
        HRESULT get_SessionId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_AppBroadcastServices(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastServices **")]
                IAppBroadcastServices* value
        );

        [VtblIndex(12)]
        HRESULT get_AppCaptureServices(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppCaptureServices **")]
                IAppCaptureServices* value
        );

        [VtblIndex(13)]
        HRESULT add_CommandReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_CommandReceived(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Media::Capture::GameBarTargetCapturePolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GameBarTargetCapturePolicy*,
            int> get_TargetCapturePolicy;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnableCapture;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisableCapture;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IGameBarServicesTargetInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IGameBarServicesTargetInfo*, int> get_TargetInfo;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SessionId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastServices **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastServices*, int> get_AppBroadcastServices;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppCaptureServices **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppCaptureServices*, int> get_AppCaptureServices;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CGameBarServices_Windows__CMedia__CCapture__CGameBarServicesCommandEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CommandReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CommandReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGameBarServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGameBarServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGameBarServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGameBarServices(Silk.NET.WinRT.IInspectable value)
    {
        return new IGameBarServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGameBarServices"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGameBarServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGameBarServices value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGameBarServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGameBarServices(Silk.NET.Windows.IUnknown value)
    {
        return new IGameBarServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGameBarServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGameBarServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGameBarServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
