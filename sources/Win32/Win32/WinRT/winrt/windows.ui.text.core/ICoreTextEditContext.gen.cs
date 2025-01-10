// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BF6608AF-4041-47C3-B263-A918EB5EAEF2")]
[NativeTypeName("struct ICoreTextEditContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreTextEditContext : ICoreTextEditContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreTextEditContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICoreTextEditContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICoreTextEditContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICoreTextEditContext, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Name(HSTRING value)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputScope(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")]
            CoreTextInputScope* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, CoreTextInputScope*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InputScope(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")]
            CoreTextInputScope value
    )
    {
        return ((delegate* unmanaged<ICoreTextEditContext, CoreTextInputScope, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IsReadOnly([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICoreTextEditContext, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InputPaneDisplayPolicy(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *")]
            CoreTextInputPaneDisplayPolicy* value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, CoreTextInputPaneDisplayPolicy*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_InputPaneDisplayPolicy(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy")]
            CoreTextInputPaneDisplayPolicy value
    )
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, CoreTextInputPaneDisplayPolicy, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT add_TextRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[14])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT remove_TextRequested(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[15])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_SelectionRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_SelectionRequested(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[17])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_LayoutRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_LayoutRequested(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[19])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_TextUpdating(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_TextUpdating(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[21])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT add_SelectionUpdating(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[22])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT remove_SelectionUpdating(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[23])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT add_FormatUpdating(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[24])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT remove_FormatUpdating(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[25])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT add_CompositionStarted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[26])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT remove_CompositionStarted(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[27])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT add_CompositionCompleted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[28])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT remove_CompositionCompleted(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[29])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT add_FocusRemoved(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* cookie
    )
    {
        return (
            (delegate* unmanaged<
                ICoreTextEditContext,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[30])
        )(this, handler, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT remove_FocusRemoved(EventRegistrationToken cookie)
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, EventRegistrationToken, int>)((*lpVtbl)[31])
        )(this, cookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT NotifyFocusEnter()
    {
        return ((delegate* unmanaged<ICoreTextEditContext, int>)((*lpVtbl)[32]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT NotifyFocusLeave()
    {
        return ((delegate* unmanaged<ICoreTextEditContext, int>)((*lpVtbl)[33]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT NotifyTextChanged(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange modifiedRange,
        [NativeTypeName("INT32")] int newLength,
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange newSelection
    )
    {
        return (
            (delegate* unmanaged<ICoreTextEditContext, CoreTextRange, int, CoreTextRange, int>)(
                (*lpVtbl)[34]
            )
        )(this, modifiedRange, newLength, newSelection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT NotifySelectionChanged(
        [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange selection
    )
    {
        return ((delegate* unmanaged<ICoreTextEditContext, CoreTextRange, int>)((*lpVtbl)[35]))(
            this,
            selection
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT NotifyLayoutChanged()
    {
        return ((delegate* unmanaged<ICoreTextEditContext, int>)((*lpVtbl)[36]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Name(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_InputScope(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope *")]
                CoreTextInputScope* value
        );

        [VtblIndex(9)]
        HRESULT put_InputScope(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputScope")]
                CoreTextInputScope value
        );

        [VtblIndex(10)]
        HRESULT get_IsReadOnly([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IsReadOnly([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_InputPaneDisplayPolicy(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *")]
                CoreTextInputPaneDisplayPolicy* value
        );

        [VtblIndex(13)]
        HRESULT put_InputPaneDisplayPolicy(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy")]
                CoreTextInputPaneDisplayPolicy value
        );

        [VtblIndex(14)]
        HRESULT add_TextRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(15)]
        HRESULT remove_TextRequested(EventRegistrationToken cookie);

        [VtblIndex(16)]
        HRESULT add_SelectionRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(17)]
        HRESULT remove_SelectionRequested(EventRegistrationToken cookie);

        [VtblIndex(18)]
        HRESULT add_LayoutRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(19)]
        HRESULT remove_LayoutRequested(EventRegistrationToken cookie);

        [VtblIndex(20)]
        HRESULT add_TextUpdating(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(21)]
        HRESULT remove_TextUpdating(EventRegistrationToken cookie);

        [VtblIndex(22)]
        HRESULT add_SelectionUpdating(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(23)]
        HRESULT remove_SelectionUpdating(EventRegistrationToken cookie);

        [VtblIndex(24)]
        HRESULT add_FormatUpdating(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(25)]
        HRESULT remove_FormatUpdating(EventRegistrationToken cookie);

        [VtblIndex(26)]
        HRESULT add_CompositionStarted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(27)]
        HRESULT remove_CompositionStarted(EventRegistrationToken cookie);

        [VtblIndex(28)]
        HRESULT add_CompositionCompleted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(29)]
        HRESULT remove_CompositionCompleted(EventRegistrationToken cookie);

        [VtblIndex(30)]
        HRESULT add_FocusRemoved(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* cookie
        );

        [VtblIndex(31)]
        HRESULT remove_FocusRemoved(EventRegistrationToken cookie);

        [VtblIndex(32)]
        HRESULT NotifyFocusEnter();

        [VtblIndex(33)]
        HRESULT NotifyFocusLeave();

        [VtblIndex(34)]
        HRESULT NotifyTextChanged(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")]
                CoreTextRange modifiedRange,
            [NativeTypeName("INT32")] int newLength,
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")]
                CoreTextRange newSelection
        );

        [VtblIndex(35)]
        HRESULT NotifySelectionChanged(
            [NativeTypeName("ABI::Windows::UI::Text::Core::CoreTextRange")] CoreTextRange selection
        );

        [VtblIndex(36)]
        HRESULT NotifyLayoutChanged();
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextInputScope*, int> get_InputScope;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputScope) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextInputScope, int> put_InputScope;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsReadOnly;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsReadOnly;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreTextInputPaneDisplayPolicy*,
            int> get_InputPaneDisplayPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextInputPaneDisplayPolicy) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreTextInputPaneDisplayPolicy,
            int> put_InputPaneDisplayPolicy;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_TextRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_TextRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SelectionRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SelectionRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextLayoutRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_LayoutRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_LayoutRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextTextUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_TextUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_TextUpdating;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextSelectionUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SelectionUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SelectionUpdating;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextFormatUpdatingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FormatUpdating;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FormatUpdating;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionStartedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CompositionStarted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CompositionStarted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_Windows__CUI__CText__CCore__CCoreTextCompositionCompletedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_CompositionCompleted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_CompositionCompleted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CText__CCore__CCoreTextEditContext_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_FocusRemoved;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_FocusRemoved;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyFocusEnter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyFocusLeave;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange, INT32, ABI::Windows::UI::Text::Core::CoreTextRange) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CoreTextRange,
            int,
            CoreTextRange,
            int> NotifyTextChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Text::Core::CoreTextRange) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CoreTextRange, int> NotifySelectionChanged;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyLayoutChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICoreTextEditContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICoreTextEditContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICoreTextEditContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICoreTextEditContext(Silk.NET.WinRT.IInspectable value)
    {
        return new ICoreTextEditContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextEditContext"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextEditContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICoreTextEditContext value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICoreTextEditContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICoreTextEditContext(Silk.NET.Windows.IUnknown value)
    {
        return new ICoreTextEditContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICoreTextEditContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICoreTextEditContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICoreTextEditContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
