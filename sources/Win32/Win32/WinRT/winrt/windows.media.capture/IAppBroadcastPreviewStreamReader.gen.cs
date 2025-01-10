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

[Guid("92228D50-DB3F-40A8-8CD4-F4E371DDAB37")]
[NativeTypeName("struct IAppBroadcastPreviewStreamReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPreviewStreamReader
    : IAppBroadcastPreviewStreamReader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastPreviewStreamReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VideoStride([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppBroadcastPreviewStreamReader, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_VideoBitmapPixelFormat(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
            BitmapPixelFormat* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, BitmapPixelFormat*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_VideoBitmapAlphaMode(
        [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
            BitmapAlphaMode* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, BitmapAlphaMode*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryGetNextVideoFrame(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **")]
            IAppBroadcastPreviewStreamVideoFrame* frame
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastPreviewStreamReader,
                IAppBroadcastPreviewStreamVideoFrame*,
                int>)((*lpVtbl)[11])
        )(this, frame);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_VideoFrameArrived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastPreviewStreamReader,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_VideoFrameArrived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreviewStreamReader, EventRegistrationToken, int>)(
                (*lpVtbl)[13]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoWidth([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_VideoHeight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_VideoStride([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT get_VideoBitmapPixelFormat(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapPixelFormat *")]
                BitmapPixelFormat* value
        );

        [VtblIndex(10)]
        HRESULT get_VideoBitmapAlphaMode(
            [NativeTypeName("ABI::Windows::Graphics::Imaging::BitmapAlphaMode *")]
                BitmapAlphaMode* value
        );

        [VtblIndex(11)]
        HRESULT TryGetNextVideoFrame(
            [NativeTypeName(
                "ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **"
            )]
                IAppBroadcastPreviewStreamVideoFrame* frame
        );

        [VtblIndex(12)]
        HRESULT add_VideoFrameArrived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_VideoFrameArrived(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_VideoWidth;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_VideoHeight;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_VideoStride;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapPixelFormat *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapPixelFormat*, int> get_VideoBitmapPixelFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Imaging::BitmapAlphaMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BitmapAlphaMode*, int> get_VideoBitmapAlphaMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamVideoFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastPreviewStreamVideoFrame*,
            int> TryGetNextVideoFrame;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreviewStreamReader_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VideoFrameArrived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_VideoFrameArrived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastPreviewStreamReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastPreviewStreamReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastPreviewStreamReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastPreviewStreamReader(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IAppBroadcastPreviewStreamReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastPreviewStreamReader"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastPreviewStreamReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IAppBroadcastPreviewStreamReader value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastPreviewStreamReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastPreviewStreamReader(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppBroadcastPreviewStreamReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastPreviewStreamReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastPreviewStreamReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppBroadcastPreviewStreamReader value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
