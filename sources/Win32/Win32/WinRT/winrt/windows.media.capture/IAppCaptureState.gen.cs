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

[Guid("73134372-D4EB-44CE-9538-465F506AC4EA")]
[NativeTypeName("struct IAppCaptureState : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppCaptureState : IAppCaptureState.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppCaptureState));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppCaptureState, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppCaptureState, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppCaptureState, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppCaptureState, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppCaptureState, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppCaptureState, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsTargetRunning([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureState, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureState, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppCaptureState, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IAppCaptureState, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RestartMicrophoneCapture()
    {
        return ((delegate* unmanaged<IAppCaptureState, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MicrophoneCaptureState(
        [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *")]
            AppCaptureMicrophoneCaptureState* value
    )
    {
        return (
            (delegate* unmanaged<IAppCaptureState, AppCaptureMicrophoneCaptureState*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppCaptureState, uint*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_MicrophoneCaptureStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureState,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppCaptureState, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT add_CaptureTargetClosed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppCaptureState,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT remove_CaptureTargetClosed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppCaptureState, EventRegistrationToken, int>)((*lpVtbl)[16])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsTargetRunning([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_IsHistoricalCaptureEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_ShouldCaptureMicrophone([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_ShouldCaptureMicrophone([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT RestartMicrophoneCapture();

        [VtblIndex(11)]
        HRESULT get_MicrophoneCaptureState(
            [NativeTypeName("ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *")]
                AppCaptureMicrophoneCaptureState* value
        );

        [VtblIndex(12)]
        HRESULT get_MicrophoneCaptureError([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT add_MicrophoneCaptureStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(14)]
        HRESULT remove_MicrophoneCaptureStateChanged(EventRegistrationToken token);

        [VtblIndex(15)]
        HRESULT add_CaptureTargetClosed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        HRESULT remove_CaptureTargetClosed(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsTargetRunning;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsHistoricalCaptureEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_ShouldCaptureMicrophone;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestartMicrophoneCapture;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppCaptureMicrophoneCaptureState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppCaptureMicrophoneCaptureState*,
            int> get_MicrophoneCaptureState;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MicrophoneCaptureError;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_Windows__CMedia__CCapture__CAppCaptureMicrophoneCaptureStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MicrophoneCaptureStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_MicrophoneCaptureStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppCaptureState_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CaptureTargetClosed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CaptureTargetClosed;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppCaptureState"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppCaptureState(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppCaptureState"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppCaptureState(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppCaptureState(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureState"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureState"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppCaptureState value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppCaptureState"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppCaptureState(Silk.NET.Windows.IUnknown value)
    {
        return new IAppCaptureState(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppCaptureState"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppCaptureState"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppCaptureState value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
