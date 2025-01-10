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

[Guid("8660B4D6-969B-4E3C-AC3A-8B042EE4EE63")]
[NativeTypeName("struct IAppBroadcastServices : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastServices : IAppBroadcastServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppBroadcastServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppBroadcastServices, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CaptureTargetType(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *")]
            AppBroadcastCaptureTargetType* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastServices, AppBroadcastCaptureTargetType*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CaptureTargetType(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType")]
            AppBroadcastCaptureTargetType value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastServices, AppBroadcastCaptureTargetType, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BroadcastTitle(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BroadcastTitle(HSTRING value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BroadcastLanguage(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BroadcastLanguage(HSTRING value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppBroadcastServices, byte*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EnterBroadcastModeAsync(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugIn *")]
            IAppBroadcastPlugIn plugIn,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastServices,
                IAppBroadcastPlugIn,
                IAsyncOperation<uint>**,
                int>)((*lpVtbl)[14])
        )(this, plugIn, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ExitBroadcastMode(
        [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason")]
            AppBroadcastExitBroadcastModeReason reason
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastServices, AppBroadcastExitBroadcastModeReason, int>)(
                (*lpVtbl)[15]
            )
        )(this, reason);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT StartBroadcast()
    {
        return ((delegate* unmanaged<IAppBroadcastServices, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PauseBroadcast()
    {
        return ((delegate* unmanaged<IAppBroadcastServices, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ResumeBroadcast()
    {
        return ((delegate* unmanaged<IAppBroadcastServices, int>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT StartPreview(
        [NativeTypeName("ABI::Windows::Foundation::Size")] Size desiredSize,
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreview **")]
            IAppBroadcastPreview* preview
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastServices, Size, IAppBroadcastPreview*, int>)(
                (*lpVtbl)[19]
            )
        )(this, desiredSize, preview);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_State(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastState **")]
            IAppBroadcastState* value
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastServices, IAppBroadcastState*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CaptureTargetType(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *")]
                AppBroadcastCaptureTargetType* value
        );

        [VtblIndex(7)]
        HRESULT put_CaptureTargetType(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType")]
                AppBroadcastCaptureTargetType value
        );

        [VtblIndex(8)]
        HRESULT get_BroadcastTitle(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_BroadcastTitle(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_BroadcastLanguage(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_BroadcastLanguage(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(13)]
        HRESULT get_CanCapture([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT EnterBroadcastModeAsync(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPlugIn *")]
                IAppBroadcastPlugIn plugIn,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** operation
        );

        [VtblIndex(15)]
        HRESULT ExitBroadcastMode(
            [NativeTypeName("ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason")]
                AppBroadcastExitBroadcastModeReason reason
        );

        [VtblIndex(16)]
        HRESULT StartBroadcast();

        [VtblIndex(17)]
        HRESULT PauseBroadcast();

        [VtblIndex(18)]
        HRESULT ResumeBroadcast();

        [VtblIndex(19)]
        HRESULT StartPreview(
            [NativeTypeName("ABI::Windows::Foundation::Size")] Size desiredSize,
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastPreview **")]
                IAppBroadcastPreview* preview
        );

        [VtblIndex(20)]
        HRESULT get_State(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastState **")]
                IAppBroadcastState* value
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
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCaptureTargetType*,
            int> get_CaptureTargetType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastCaptureTargetType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastCaptureTargetType,
            int> put_CaptureTargetType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_BroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_BroadcastTitle;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_BroadcastLanguage;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanCapture;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastPlugIn *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppBroadcastPlugIn,
            IAsyncOperation<uint>**,
            int> EnterBroadcastModeAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::AppBroadcastExitBroadcastModeReason) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AppBroadcastExitBroadcastModeReason,
            int> ExitBroadcastMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StartBroadcast;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PauseBroadcast;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeBroadcast;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Size, ABI::Windows::Media::Capture::IAppBroadcastPreview **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Size, IAppBroadcastPreview*, int> StartPreview;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastState **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastState*, int> get_State;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastServices(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastServices"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastServices value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastServices(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
