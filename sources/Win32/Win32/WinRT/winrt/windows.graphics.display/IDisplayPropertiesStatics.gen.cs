// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.display.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6937ED8D-30EA-4DED-8271-4553FF02F68A")]
[NativeTypeName("struct IDisplayPropertiesStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
)]
public unsafe partial struct IDisplayPropertiesStatics
    : IDisplayPropertiesStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDisplayPropertiesStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDisplayPropertiesStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_CurrentOrientation(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
            DisplayOrientations* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, DisplayOrientations*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_NativeOrientation(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
            DisplayOrientations* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, DisplayOrientations*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_AutoRotationPreferences(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
            DisplayOrientations* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, DisplayOrientations*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT put_AutoRotationPreferences(
        [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")]
            DisplayOrientations value
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, DisplayOrientations, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT add_OrientationChanged(
        [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
            IDisplayPropertiesEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayPropertiesStatics,
                IDisplayPropertiesEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT remove_OrientationChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_ResolutionScale(
        [NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")]
            ResolutionScale* value
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, ResolutionScale*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_LogicalDpi(float* value)
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, float*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT add_LogicalDpiChanged(
        [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
            IDisplayPropertiesEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayPropertiesStatics,
                IDisplayPropertiesEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT remove_LogicalDpiChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[15]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDisplayPropertiesStatics, byte*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT add_StereoEnabledChanged(
        [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
            IDisplayPropertiesEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayPropertiesStatics,
                IDisplayPropertiesEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT remove_StereoEnabledChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[18]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT GetColorProfileAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[19]
            )
        )(this, asyncInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT add_ColorProfileChanged(
        [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
            IDisplayPropertiesEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayPropertiesStatics,
                IDisplayPropertiesEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT remove_ColorProfileChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[21]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT add_DisplayContentsInvalidated(
        [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
            IDisplayPropertiesEventHandler handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IDisplayPropertiesStatics,
                IDisplayPropertiesEventHandler,
                EventRegistrationToken*,
                int>)((*lpVtbl)[22])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete(
        "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
    )]
    public HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IDisplayPropertiesStatics, EventRegistrationToken, int>)(
                (*lpVtbl)[23]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_CurrentOrientation(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
                DisplayOrientations* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_NativeOrientation(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
                DisplayOrientations* value
        );

        [VtblIndex(8)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_AutoRotationPreferences(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations *")]
                DisplayOrientations* value
        );

        [VtblIndex(9)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT put_AutoRotationPreferences(
            [NativeTypeName("ABI::Windows::Graphics::Display::DisplayOrientations")]
                DisplayOrientations value
        );

        [VtblIndex(10)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT add_OrientationChanged(
            [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
                IDisplayPropertiesEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT remove_OrientationChanged(EventRegistrationToken token);

        [VtblIndex(12)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_ResolutionScale(
            [NativeTypeName("ABI::Windows::Graphics::Display::ResolutionScale *")]
                ResolutionScale* value
        );

        [VtblIndex(13)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_LogicalDpi(float* value);

        [VtblIndex(14)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT add_LogicalDpiChanged(
            [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
                IDisplayPropertiesEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(15)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT remove_LogicalDpiChanged(EventRegistrationToken token);

        [VtblIndex(16)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT get_StereoEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT add_StereoEnabledChanged(
            [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
                IDisplayPropertiesEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT remove_StereoEnabledChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT GetColorProfileAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
        );

        [VtblIndex(20)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT add_ColorProfileChanged(
            [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
                IDisplayPropertiesEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(21)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT remove_ColorProfileChanged(EventRegistrationToken token);

        [VtblIndex(22)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT add_DisplayContentsInvalidated(
            [NativeTypeName("ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *")]
                IDisplayPropertiesEventHandler handler,
            EventRegistrationToken* token
        );

        [VtblIndex(23)]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        HRESULT remove_DisplayContentsInvalidated(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations*, int> get_CurrentOrientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations*, int> get_NativeOrientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations*, int> get_AutoRotationPreferences;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::DisplayOrientations) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, DisplayOrientations, int> put_AutoRotationPreferences;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPropertiesEventHandler,
            EventRegistrationToken*,
            int> add_OrientationChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_OrientationChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::ResolutionScale *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, ResolutionScale*, int> get_ResolutionScale;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, float*, int> get_LogicalDpi;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPropertiesEventHandler,
            EventRegistrationToken*,
            int> add_LogicalDpiChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_LogicalDpiChanged;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_StereoEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPropertiesEventHandler,
            EventRegistrationToken*,
            int> add_StereoEnabledChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_StereoEnabledChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetColorProfileAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPropertiesEventHandler,
            EventRegistrationToken*,
            int> add_ColorProfileChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ColorProfileChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Display::IDisplayPropertiesEventHandler *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayPropertiesEventHandler,
            EventRegistrationToken*,
            int> add_DisplayContentsInvalidated;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete(
            "DisplayProperties may be altered or unavailable for releases after Windows Phone 8.1. Instead, use DisplayInformation."
        )]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_DisplayContentsInvalidated;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDisplayPropertiesStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDisplayPropertiesStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDisplayPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDisplayPropertiesStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IDisplayPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayPropertiesStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDisplayPropertiesStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDisplayPropertiesStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDisplayPropertiesStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IDisplayPropertiesStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDisplayPropertiesStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDisplayPropertiesStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDisplayPropertiesStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
