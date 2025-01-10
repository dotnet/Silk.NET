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

[Guid("14B60F5A-6E4A-4B80-A14F-67EE77D153E7")]
[NativeTypeName("struct IAppBroadcastPreview : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastPreview : IAppBroadcastPreview.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastPreview));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppBroadcastPreview, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT StopPreview()
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_PreviewState(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPreviewState *")]
            AppBroadcastPreviewState* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreview, AppBroadcastPreviewState*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ErrorCode(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
            IReference<uint>** value
    )
    {
        return ((delegate* unmanaged<IAppBroadcastPreview, IReference<uint>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_PreviewStateChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreview_Windows__CMedia__CCapture__CAppBroadcastPreviewStateChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastPreview,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_PreviewStateChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreview, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_PreviewStreamReader(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamReader **")]
            IAppBroadcastPreviewStreamReader* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastPreview, IAppBroadcastPreviewStreamReader*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT StopPreview();

        [VtblIndex(7)]
        HRESULT get_PreviewState(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastPreviewState *")]
                AppBroadcastPreviewState* value
        );

        [VtblIndex(8)]
        HRESULT get_ErrorCode(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t **")]
                IReference<uint>** value
        );

        [VtblIndex(9)]
        HRESULT add_PreviewStateChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreview_Windows__CMedia__CCapture__CAppBroadcastPreviewStateChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_PreviewStateChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT get_PreviewStreamReader(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamReader **")]
                IAppBroadcastPreviewStreamReader* value
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopPreview;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastPreviewState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppBroadcastPreviewState*, int> get_PreviewState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<uint>**, int> get_ErrorCode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CMedia__CCapture__CAppBroadcastPreview_Windows__CMedia__CCapture__CAppBroadcastPreviewStateChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_PreviewStateChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_PreviewStateChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPreviewStreamReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastPreviewStreamReader*,
            int> get_PreviewStreamReader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastPreview"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastPreview(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastPreview"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastPreview(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastPreview(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastPreview"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastPreview"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastPreview value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastPreview"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastPreview(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastPreview(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastPreview"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastPreview"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastPreview value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
