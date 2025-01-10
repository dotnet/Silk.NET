// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("663014A6-B75E-5DBD-995C-F0117FA3FB61")]
[NativeTypeName("struct IAppWindow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppWindow : IAppWindow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppWindow));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppWindow, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppWindow, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppWindow, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppWindow, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppWindow, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppWindow, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Content(
        [NativeTypeName("ABI::Windows::UI::IUIContentRoot **")] IUIContentRoot* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IUIContentRoot*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DispatcherQueue(
        [NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IDispatcherQueue*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Frame(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowFrame **")]
            IAppWindowFrame* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindowFrame*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppWindow, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_PersistedStateId(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppWindow, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_PersistedStateId(HSTRING value)
    {
        return ((delegate* unmanaged<IAppWindow, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Presenter(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresenter **")]
            IAppWindowPresenter* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindowPresenter*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<IAppWindow, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<IAppWindow, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_TitleBar(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **")]
            IAppWindowTitleBar* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindowTitleBar*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UIContext(
        [NativeTypeName("ABI::Windows::UI::IUIContext **")] IUIContext* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IUIContext*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_WindowingEnvironment(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")]
            IWindowingEnvironment* value
    )
    {
        return ((delegate* unmanaged<IAppWindow, IWindowingEnvironment*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CloseAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAsyncAction*, int>)((*lpVtbl)[18]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetPlacement(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPlacement **")]
            IAppWindowPlacement* result
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindowPlacement*, int>)((*lpVtbl)[19]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetDisplayRegions(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **"
        )]
            IVectorView<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IAppWindow, IVectorView<IntPtr>**, int>)((*lpVtbl)[20]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RequestMoveToDisplayRegion(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")]
            IDisplayRegion displayRegion
    )
    {
        return ((delegate* unmanaged<IAppWindow, IDisplayRegion, int>)((*lpVtbl)[21]))(
            this,
            displayRegion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT RequestMoveAdjacentToCurrentView()
    {
        return ((delegate* unmanaged<IAppWindow, int>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT RequestMoveAdjacentToWindow(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")] IAppWindow anchorWindow
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindow, int>)((*lpVtbl)[23]))(
            this,
            anchorWindow
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RequestMoveRelativeToWindowContent(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")]
            IAppWindow anchorWindow,
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAppWindow, Point, int>)((*lpVtbl)[24]))(
            this,
            anchorWindow,
            contentOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT RequestMoveRelativeToCurrentViewContent(
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset
    )
    {
        return ((delegate* unmanaged<IAppWindow, Point, int>)((*lpVtbl)[25]))(this, contentOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT RequestMoveRelativeToDisplayRegion(
        [NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")]
            IDisplayRegion displayRegion,
        [NativeTypeName("ABI::Windows::Foundation::Point")] Point displayRegionOffset
    )
    {
        return ((delegate* unmanaged<IAppWindow, IDisplayRegion, Point, int>)((*lpVtbl)[26]))(
            this,
            displayRegion,
            displayRegionOffset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT RequestSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size frameSize)
    {
        return ((delegate* unmanaged<IAppWindow, Size, int>)((*lpVtbl)[27]))(this, frameSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TryShowAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return ((delegate* unmanaged<IAppWindow, IAsyncOperation<byte>**, int>)((*lpVtbl)[28]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT add_Changed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppWindow,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[29])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT remove_Changed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAppWindow, EventRegistrationToken, int>)((*lpVtbl)[30]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT add_Closed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppWindow,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[31])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAppWindow, EventRegistrationToken, int>)((*lpVtbl)[32]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT add_CloseRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IAppWindow,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[33])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT remove_CloseRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IAppWindow, EventRegistrationToken, int>)((*lpVtbl)[34]))(
            this,
            token
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Content(
            [NativeTypeName("ABI::Windows::UI::IUIContentRoot **")] IUIContentRoot* value
        );

        [VtblIndex(7)]
        HRESULT get_DispatcherQueue(
            [NativeTypeName("ABI::Windows::System::IDispatcherQueue **")] IDispatcherQueue* value
        );

        [VtblIndex(8)]
        HRESULT get_Frame(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowFrame **")]
                IAppWindowFrame* value
        );

        [VtblIndex(9)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_PersistedStateId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_PersistedStateId(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Presenter(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPresenter **")]
                IAppWindowPresenter* value
        );

        [VtblIndex(13)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_TitleBar(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **")]
                IAppWindowTitleBar* value
        );

        [VtblIndex(16)]
        HRESULT get_UIContext(
            [NativeTypeName("ABI::Windows::UI::IUIContext **")] IUIContext* value
        );

        [VtblIndex(17)]
        HRESULT get_WindowingEnvironment(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IWindowingEnvironment **")]
                IWindowingEnvironment* value
        );

        [VtblIndex(18)]
        HRESULT CloseAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(19)]
        HRESULT GetPlacement(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindowPlacement **")]
                IAppWindowPlacement* result
        );

        [VtblIndex(20)]
        HRESULT GetDisplayRegions(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **"
            )]
                IVectorView<IntPtr>** result
        );

        [VtblIndex(21)]
        HRESULT RequestMoveToDisplayRegion(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")]
                IDisplayRegion displayRegion
        );

        [VtblIndex(22)]
        HRESULT RequestMoveAdjacentToCurrentView();

        [VtblIndex(23)]
        HRESULT RequestMoveAdjacentToWindow(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")]
                IAppWindow anchorWindow
        );

        [VtblIndex(24)]
        HRESULT RequestMoveRelativeToWindowContent(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IAppWindow *")]
                IAppWindow anchorWindow,
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset
        );

        [VtblIndex(25)]
        HRESULT RequestMoveRelativeToCurrentViewContent(
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point contentOffset
        );

        [VtblIndex(26)]
        HRESULT RequestMoveRelativeToDisplayRegion(
            [NativeTypeName("ABI::Windows::UI::WindowManagement::IDisplayRegion *")]
                IDisplayRegion displayRegion,
            [NativeTypeName("ABI::Windows::Foundation::Point")] Point displayRegionOffset
        );

        [VtblIndex(27)]
        HRESULT RequestSize([NativeTypeName("ABI::Windows::Foundation::Size")] Size frameSize);

        [VtblIndex(28)]
        HRESULT TryShowAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(29)]
        HRESULT add_Changed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(30)]
        HRESULT remove_Changed(EventRegistrationToken token);

        [VtblIndex(31)]
        HRESULT add_Closed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(32)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(33)]
        HRESULT add_CloseRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(34)]
        HRESULT remove_CloseRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (ABI::Windows::UI::IUIContentRoot **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIContentRoot*, int> get_Content;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IDispatcherQueue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDispatcherQueue*, int> get_DispatcherQueue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowFrame **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppWindowFrame*, int> get_Frame;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PersistedStateId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_PersistedStateId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPresenter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppWindowPresenter*, int> get_Presenter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowTitleBar **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppWindowTitleBar*, int> get_TitleBar;

        [NativeTypeName("HRESULT (ABI::Windows::UI::IUIContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIContext*, int> get_UIContext;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IWindowingEnvironment **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWindowingEnvironment*, int> get_WindowingEnvironment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> CloseAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindowPlacement **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppWindowPlacement*, int> GetPlacement;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CWindowManagement__CDisplayRegion_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> GetDisplayRegions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IDisplayRegion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDisplayRegion, int> RequestMoveToDisplayRegion;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RequestMoveAdjacentToCurrentView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindow *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppWindow, int> RequestMoveAdjacentToWindow;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IAppWindow *, ABI::Windows::Foundation::Point) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppWindow,
            Point,
            int> RequestMoveRelativeToWindowContent;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Point) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Point, int> RequestMoveRelativeToCurrentViewContent;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::WindowManagement::IDisplayRegion *, ABI::Windows::Foundation::Point) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDisplayRegion,
            Point,
            int> RequestMoveRelativeToDisplayRegion;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size, int> RequestSize;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> TryShowAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Changed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Changed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CWindowManagement__CAppWindow_Windows__CUI__CWindowManagement__CAppWindowCloseRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CloseRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CloseRequested;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppWindow"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppWindow(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppWindow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppWindow(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppWindow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindow"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindow"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppWindow value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppWindow"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppWindow(Silk.NET.Windows.IUnknown value)
    {
        return new IAppWindow(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppWindow"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppWindow"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppWindow value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
