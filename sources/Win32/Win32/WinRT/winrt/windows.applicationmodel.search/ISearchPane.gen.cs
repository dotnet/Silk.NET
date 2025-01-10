// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FDACEC38-3700-4D73-91A1-2F998674238A")]
[NativeTypeName("struct ISearchPane : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
public unsafe partial struct ISearchPane : ISearchPane.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPane));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISearchPane, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISearchPane, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchPane, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISearchPane, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISearchPane, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISearchPane, byte, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISearchPane, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_SearchHistoryContext(HSTRING value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_SearchHistoryContext(HSTRING* value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_PlaceholderText(HSTRING value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_PlaceholderText(HSTRING* value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_Visible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISearchPane, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_VisibilityChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPane,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[15])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_VisibilityChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ISearchPane, EventRegistrationToken, int>)((*lpVtbl)[16]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_QueryChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPane,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[17])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_QueryChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ISearchPane, EventRegistrationToken, int>)((*lpVtbl)[18]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_SuggestionsRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPane,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[19])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_SuggestionsRequested(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ISearchPane, EventRegistrationToken, int>)((*lpVtbl)[20]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_QuerySubmitted(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPane,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[21])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_QuerySubmitted(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ISearchPane, EventRegistrationToken, int>)((*lpVtbl)[22]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT add_ResultSuggestionChosen(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPane,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[23])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT remove_ResultSuggestionChosen(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<ISearchPane, EventRegistrationToken, int>)((*lpVtbl)[24]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT SetLocalContentSuggestionSettings(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *"
        )]
            ILocalContentSuggestionSettings settings
    )
    {
        return (
            (delegate* unmanaged<ISearchPane, ILocalContentSuggestionSettings, int>)((*lpVtbl)[25])
        )(this, settings);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT ShowOverloadDefault()
    {
        return ((delegate* unmanaged<ISearchPane, int>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT ShowOverloadWithQuery(HSTRING query)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING, int>)((*lpVtbl)[27]))(this, query);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT put_ShowOnKeyboardInput([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISearchPane, byte, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT get_ShowOnKeyboardInput([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISearchPane, byte*, int>)((*lpVtbl)[29]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
    public HRESULT TrySetQueryText(HSTRING query, [NativeTypeName("boolean *")] byte* succeeded)
    {
        return ((delegate* unmanaged<ISearchPane, HSTRING, byte*, int>)((*lpVtbl)[30]))(
            this,
            query,
            succeeded
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_SearchHistoryContext(HSTRING value);

        [VtblIndex(9)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_SearchHistoryContext(HSTRING* value);

        [VtblIndex(10)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_PlaceholderText(HSTRING value);

        [VtblIndex(11)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_PlaceholderText(HSTRING* value);

        [VtblIndex(12)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(13)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(14)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_Visible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_VisibilityChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(16)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_VisibilityChanged(EventRegistrationToken token);

        [VtblIndex(17)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_QueryChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(18)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_QueryChanged(EventRegistrationToken token);

        [VtblIndex(19)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_SuggestionsRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(20)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_SuggestionsRequested(EventRegistrationToken token);

        [VtblIndex(21)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_QuerySubmitted(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(22)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_QuerySubmitted(EventRegistrationToken token);

        [VtblIndex(23)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT add_ResultSuggestionChosen(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(24)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT remove_ResultSuggestionChosen(EventRegistrationToken token);

        [VtblIndex(25)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT SetLocalContentSuggestionSettings(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *"
            )]
                ILocalContentSuggestionSettings settings
        );

        [VtblIndex(26)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT ShowOverloadDefault();

        [VtblIndex(27)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT ShowOverloadWithQuery(HSTRING query);

        [VtblIndex(28)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT put_ShowOnKeyboardInput([NativeTypeName("boolean")] byte value);

        [VtblIndex(29)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT get_ShowOnKeyboardInput([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(30)]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        HRESULT TrySetQueryText(HSTRING query, [NativeTypeName("boolean *")] byte* succeeded);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, byte, int> put_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, byte*, int> get_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_PlaceholderText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_PlaceholderText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Visible;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneVisibilityChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_VisibilityChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_VisibilityChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQueryChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_QueryChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_QueryChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneSuggestionsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SuggestionsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SuggestionsRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneQuerySubmittedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_QuerySubmitted;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_QuerySubmitted;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CSearchPane_Windows__CApplicationModel__CSearch__CSearchPaneResultSuggestionChosenEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ResultSuggestionChosen;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_ResultSuggestionChosen;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *) __attribute__((stdcall))"
        )]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<
            TSelf*,
            ILocalContentSuggestionSettings,
            int> SetLocalContentSuggestionSettings;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, int> ShowOverloadDefault;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ShowOverloadWithQuery;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, byte, int> put_ShowOnKeyboardInput;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ShowOnKeyboardInput;

        [NativeTypeName("HRESULT (HSTRING, boolean *) __attribute__((stdcall))")]
        [Obsolete("ISearchPane may be altered or unavailable for releases after Windows 10.")]
        public delegate* unmanaged<TSelf*, HSTRING, byte*, int> TrySetQueryText;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchPane"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchPane(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISearchPane"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISearchPane(Silk.NET.WinRT.IInspectable value)
    {
        return new ISearchPane(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchPane"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchPane"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISearchPane value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchPane"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchPane(Silk.NET.Windows.IUnknown value)
    {
        return new ISearchPane(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchPane"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchPane"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISearchPane value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
