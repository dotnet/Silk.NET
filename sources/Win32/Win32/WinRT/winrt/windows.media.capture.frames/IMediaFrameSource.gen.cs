// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D6782953-90DB-46A8-8ADD-2AA884A8D253")]
[NativeTypeName("struct IMediaFrameSource : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSource : IMediaFrameSource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSource));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaFrameSource, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaFrameSource, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFrameSource, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMediaFrameSource, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMediaFrameSource, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMediaFrameSource, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Info(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **")]
            IMediaFrameSourceInfo* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSource, IMediaFrameSourceInfo*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Controller(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **")]
            IMediaFrameSourceController* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSource, IMediaFrameSourceController*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedFormats(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<IMediaFrameSource, IVectorView<IntPtr>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CurrentFormat(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
            IMediaFrameFormat* value
    )
    {
        return ((delegate* unmanaged<IMediaFrameSource, IMediaFrameFormat*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFormatAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")]
            IMediaFrameFormat format,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSource, IMediaFrameFormat, IAsyncAction*, int>)(
                (*lpVtbl)[10]
            )
        )(this, format, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_FormatChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IMediaFrameSource,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_FormatChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IMediaFrameSource, EventRegistrationToken, int>)((*lpVtbl)[12])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT TryGetCameraIntrinsics(
        [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")]
            IMediaFrameFormat format,
        [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
            ICameraIntrinsics* value
    )
    {
        return (
            (delegate* unmanaged<IMediaFrameSource, IMediaFrameFormat, ICameraIntrinsics*, int>)(
                (*lpVtbl)[13]
            )
        )(this, format, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Info(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **")]
                IMediaFrameSourceInfo* value
        );

        [VtblIndex(7)]
        HRESULT get_Controller(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **")]
                IMediaFrameSourceController* value
        );

        [VtblIndex(8)]
        HRESULT get_SupportedFormats(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT get_CurrentFormat(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **")]
                IMediaFrameFormat* value
        );

        [VtblIndex(10)]
        HRESULT SetFormatAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")]
                IMediaFrameFormat format,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* value
        );

        [VtblIndex(11)]
        HRESULT add_FormatChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_FormatChanged(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT TryGetCameraIntrinsics(
            [NativeTypeName("ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *")]
                IMediaFrameFormat format,
            [NativeTypeName("ABI::Windows::Media::Devices::Core::ICameraIntrinsics **")]
                ICameraIntrinsics* value
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
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameSourceInfo*, int> get_Info;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameSourceController **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameSourceController*, int> get_Controller;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_SupportedFormats;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameFormat*, int> get_CurrentFormat;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaFrameFormat, IAsyncAction*, int> SetFormatAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CFrames__CMediaFrameSource_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FormatChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FormatChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::Frames::IMediaFrameFormat *, ABI::Windows::Media::Devices::Core::ICameraIntrinsics **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMediaFrameFormat,
            ICameraIntrinsics*,
            int> TryGetCameraIntrinsics;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaFrameSource"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaFrameSource(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMediaFrameSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMediaFrameSource(Silk.NET.WinRT.IInspectable value)
    {
        return new IMediaFrameSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSource"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMediaFrameSource value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaFrameSource"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaFrameSource(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaFrameSource(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFrameSource"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFrameSource"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaFrameSource value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
