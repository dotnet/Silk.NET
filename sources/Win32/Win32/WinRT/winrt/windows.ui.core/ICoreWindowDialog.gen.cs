// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E7392CE0-C78D-427E-8B2C-01FF420C69D5")]
[NativeTypeName("struct ICoreWindowDialog : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowDialog : ICoreWindowDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowDialog));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreWindowDialog, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Showing(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreWindowDialog,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Showing(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreWindowDialog, EventRegistrationToken, int>)((*lpVtbl)[7])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, Size*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, Size*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, HSTRING, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, int*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, int, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Commands(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return ((delegate* unmanaged<ICoreWindowDialog, IVector<IntPtr>**, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<ICoreWindowDialog, uint, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BackButtonCommand(
        [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")]
            IUICommandInvokedHandler* value
    )
    {
        return (
            (delegate* unmanaged<ICoreWindowDialog, IUICommandInvokedHandler*, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_BackButtonCommand(
        [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")]
            IUICommandInvokedHandler value
    )
    {
        return (
            (delegate* unmanaged<ICoreWindowDialog, IUICommandInvokedHandler, int>)((*lpVtbl)[20])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ShowAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **"
        )]
            IAsyncOperation<IntPtr>** asyncInfo
    )
    {
        return (
            (delegate* unmanaged<ICoreWindowDialog, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[21])
        )(this, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Showing(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(7)]
        HRESULT remove_Showing(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_Commands(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(15)]
        HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT get_BackButtonCommand(
            [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")]
                IUICommandInvokedHandler* value
        );

        [VtblIndex(20)]
        HRESULT put_BackButtonCommand(
            [NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")]
                IUICommandInvokedHandler value
        );

        [VtblIndex(21)]
        HRESULT ShowAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **"
            )]
                IAsyncOperation<IntPtr>** asyncInfo
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_MaxSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Size*, int> get_MinSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_IsInteractionDelayed;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_IsInteractionDelayed;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_Commands;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_CancelCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_CancelCommandIndex;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUICommandInvokedHandler*, int> get_BackButtonCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUICommandInvokedHandler, int> put_BackButtonCommand;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> ShowAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreWindowDialog"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreWindowDialog(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreWindowDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreWindowDialog(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreWindowDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowDialog"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreWindowDialog value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreWindowDialog"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreWindowDialog(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreWindowDialog(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreWindowDialog"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreWindowDialog"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreWindowDialog value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
