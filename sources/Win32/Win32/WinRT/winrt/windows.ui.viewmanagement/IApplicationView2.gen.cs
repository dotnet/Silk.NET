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

[Guid("E876B196-A545-40DC-B594-450CBA68CC00")]
[NativeTypeName("struct IApplicationView2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationView2 : IApplicationView2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationView2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationView2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationView2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationView2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationView2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationView2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationView2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
    )]
    public HRESULT get_SuppressSystemOverlays([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IApplicationView2, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
    )]
    public HRESULT put_SuppressSystemOverlays([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IApplicationView2, byte, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VisibleBounds(
        [NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value
    )
    {
        return ((delegate* unmanaged<IApplicationView2, Rect*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_VisibleBoundsChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationView2,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_VisibleBoundsChanged(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IApplicationView2, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDesiredBoundsMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode")]
            ApplicationViewBoundsMode boundsMode,
        [NativeTypeName("boolean *")] byte* success
    )
    {
        return (
            (delegate* unmanaged<IApplicationView2, ApplicationViewBoundsMode, byte*, int>)(
                (*lpVtbl)[11]
            )
        )(this, boundsMode, success);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_DesiredBoundsMode(
        [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *")]
            ApplicationViewBoundsMode* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationView2, ApplicationViewBoundsMode*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
        )]
        HRESULT get_SuppressSystemOverlays([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        [Obsolete(
            "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
        )]
        HRESULT put_SuppressSystemOverlays([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_VisibleBounds([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value);

        [VtblIndex(9)]
        HRESULT add_VisibleBoundsChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_VisibleBoundsChanged(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT SetDesiredBoundsMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode")]
                ApplicationViewBoundsMode boundsMode,
            [NativeTypeName("boolean *")] byte* success
        );

        [VtblIndex(12)]
        HRESULT get_DesiredBoundsMode(
            [NativeTypeName("ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *")]
                ApplicationViewBoundsMode* value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete(
            "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte*, int> get_SuppressSystemOverlays;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete(
            "Use the TryEnterFullScreen method and IsFullScreenMode property instead of SuppressSystemOverlays. For more info, see MSDN."
        )]
        public delegate* unmanaged<TSelf*, byte, int> put_SuppressSystemOverlays;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Rect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Rect*, int> get_VisibleBounds;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CViewManagement__CApplicationView_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VisibleBoundsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_VisibleBoundsChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ApplicationViewBoundsMode,
            byte*,
            int> SetDesiredBoundsMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::ViewManagement::ApplicationViewBoundsMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ApplicationViewBoundsMode*, int> get_DesiredBoundsMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationView2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationView2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationView2(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationView2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationView2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationView2(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationView2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationView2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationView2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationView2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
