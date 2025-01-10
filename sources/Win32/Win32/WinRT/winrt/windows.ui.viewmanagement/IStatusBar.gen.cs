// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0FFCC5BF-98D0-4864-B1E8-B3F4020BE8B4")]
[NativeTypeName("struct IStatusBar : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStatusBar : IStatusBar.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStatusBar));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStatusBar, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStatusBar, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStatusBar, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStatusBar, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStatusBar, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStatusBar, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
    )
    {
        return ((delegate* unmanaged<IStatusBar, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT HideAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
    )
    {
        return ((delegate* unmanaged<IStatusBar, IAsyncAction*, int>)((*lpVtbl)[7]))(
            this,
            returnValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackgroundOpacity(double* value)
    {
        return ((delegate* unmanaged<IStatusBar, double*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackgroundOpacity(double value)
    {
        return ((delegate* unmanaged<IStatusBar, double, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return ((delegate* unmanaged<IStatusBar, IReference<Color>**, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_ForegroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return ((delegate* unmanaged<IStatusBar, IReference<Color>*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_BackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
            IReference<Color>** value
    )
    {
        return ((delegate* unmanaged<IStatusBar, IReference<Color>**, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_BackgroundColor(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
            IReference<Color>* value
    )
    {
        return ((delegate* unmanaged<IStatusBar, IReference<Color>*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProgressIndicator(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **")]
            IStatusBarProgressIndicator* value
    )
    {
        return (
            (delegate* unmanaged<IStatusBar, IStatusBarProgressIndicator*, int>)((*lpVtbl)[14])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_OccludedRect(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IStatusBar, Rect*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_Showing(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IStatusBar,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, eventHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_Showing(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IStatusBar, EventRegistrationToken, int>)((*lpVtbl)[17]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_Hiding(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IStatusBar,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, eventHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_Hiding(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IStatusBar, EventRegistrationToken, int>)((*lpVtbl)[19]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
        );

        [VtblIndex(7)]
        HRESULT HideAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* returnValue
        );

        [VtblIndex(8)]
        HRESULT get_BackgroundOpacity(double* value);

        [VtblIndex(9)]
        HRESULT put_BackgroundOpacity(double value);

        [VtblIndex(10)]
        HRESULT get_ForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(11)]
        HRESULT put_ForegroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(12)]
        HRESULT get_BackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **")]
                IReference<Color>** value
        );

        [VtblIndex(13)]
        HRESULT put_BackgroundColor(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *")]
                IReference<Color>* value
        );

        [VtblIndex(14)]
        HRESULT get_ProgressIndicator(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **")]
                IStatusBarProgressIndicator* value
        );

        [VtblIndex(15)]
        HRESULT get_OccludedRect([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(16)]
        HRESULT add_Showing(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(17)]
        HRESULT remove_Showing(EventRegistrationToken token);

        [VtblIndex(18)]
        HRESULT add_Hiding(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(19)]
        HRESULT remove_Hiding(EventRegistrationToken token);
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> ShowAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> HideAsync;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_BackgroundOpacity;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_BackgroundOpacity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_ForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_ForegroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>**, int> get_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CUI__CColor_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<Color>*, int> put_BackgroundColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::IStatusBarProgressIndicator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStatusBarProgressIndicator*, int> get_ProgressIndicator;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_OccludedRect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CStatusBar_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Hiding;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Hiding;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStatusBar"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStatusBar(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStatusBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStatusBar(Silk.NET.WinRT.IInspectable value)
    {
        return new IStatusBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStatusBar"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStatusBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStatusBar value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStatusBar"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStatusBar(Silk.NET.Windows.IUnknown value)
    {
        return new IStatusBar(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStatusBar"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStatusBar"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStatusBar value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
