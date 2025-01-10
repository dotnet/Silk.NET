// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("AA2D9A40-909F-4BBA-BF8B-0C0D296F14F0")]
[NativeTypeName("struct IMediaDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaDeviceStatics : IMediaDeviceStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaDeviceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaDeviceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioCaptureSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            selector
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAudioRenderSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            selector
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVideoCaptureSelector(HSTRING* selector)
    {
        return ((delegate* unmanaged<IMediaDeviceStatics, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            selector
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaultAudioCaptureId(
        [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
        HSTRING* deviceId
    )
    {
        return (
            (delegate* unmanaged<IMediaDeviceStatics, AudioDeviceRole, HSTRING*, int>)((*lpVtbl)[9])
        )(this, role, deviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDefaultAudioRenderId(
        [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
        HSTRING* deviceId
    )
    {
        return (
            (delegate* unmanaged<IMediaDeviceStatics, AudioDeviceRole, HSTRING*, int>)(
                (*lpVtbl)[10]
            )
        )(this, role, deviceId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_DefaultAudioCaptureDeviceChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaDeviceStatics,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_DefaultAudioCaptureDeviceChanged(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IMediaDeviceStatics, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT add_DefaultAudioRenderDeviceChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                IMediaDeviceStatics,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[13])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT remove_DefaultAudioRenderDeviceChanged(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<IMediaDeviceStatics, EventRegistrationToken, int>)((*lpVtbl)[14])
        )(this, cookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAudioCaptureSelector(HSTRING* selector);

        [VtblIndex(7)]
        HRESULT GetAudioRenderSelector(HSTRING* selector);

        [VtblIndex(8)]
        HRESULT GetVideoCaptureSelector(HSTRING* selector);

        [VtblIndex(9)]
        HRESULT GetDefaultAudioCaptureId(
            [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
            HSTRING* deviceId
        );

        [VtblIndex(10)]
        HRESULT GetDefaultAudioRenderId(
            [NativeTypeName("ABI::Windows::Media::Devices::AudioDeviceRole")] AudioDeviceRole role,
            HSTRING* deviceId
        );

        [VtblIndex(11)]
        HRESULT add_DefaultAudioCaptureDeviceChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(12)]
        HRESULT remove_DefaultAudioCaptureDeviceChanged(EventRegistrationToken cookie);

        [VtblIndex(13)]
        HRESULT add_DefaultAudioRenderDeviceChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(14)]
        HRESULT remove_DefaultAudioRenderDeviceChanged(EventRegistrationToken cookie);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetAudioCaptureSelector;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetAudioRenderSelector;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetVideoCaptureSelector;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioDeviceRole, HSTRING*, int> GetDefaultAudioCaptureId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::AudioDeviceRole, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AudioDeviceRole, HSTRING*, int> GetDefaultAudioRenderId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioCaptureDeviceChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DefaultAudioCaptureDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DefaultAudioCaptureDeviceChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_IInspectable_Windows__CMedia__CDevices__CDefaultAudioRenderDeviceChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_DefaultAudioRenderDeviceChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DefaultAudioRenderDeviceChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaDeviceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaDeviceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaDeviceStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaDeviceStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaDeviceStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaDeviceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaDeviceStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
