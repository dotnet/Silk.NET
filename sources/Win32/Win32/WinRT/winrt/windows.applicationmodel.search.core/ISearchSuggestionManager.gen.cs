// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.search.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3F0C50A1-CB9D-497B-B500-3C04AC959AD2")]
[NativeTypeName("struct ISearchSuggestionManager : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionManager
    : ISearchSuggestionManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISearchSuggestionManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SearchHistoryContext(HSTRING* value)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_SearchHistoryContext(HSTRING value)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLocalContentSuggestionSettings(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *"
        )]
            ILocalContentSuggestionSettings settings
    )
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, ILocalContentSuggestionSettings, int>)(
                (*lpVtbl)[10]
            )
        )(this, settings);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetQuery(HSTRING queryText)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            queryText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetQueryWithLanguage(HSTRING queryText, HSTRING language)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, HSTRING, HSTRING, int>)((*lpVtbl)[12])
        )(this, queryText, language);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetQueryWithSearchQueryLinguisticDetails(
        HSTRING queryText,
        HSTRING language,
        [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *")]
            ISearchQueryLinguisticDetails linguisticDetails
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionManager,
                HSTRING,
                HSTRING,
                ISearchQueryLinguisticDetails,
                int>)((*lpVtbl)[13])
        )(this, queryText, language, linguisticDetails);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Suggestions(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **"
        )]
            IObservableVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, IObservableVector<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT AddToHistory(HSTRING queryText)
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, HSTRING, int>)((*lpVtbl)[15]))(
            this,
            queryText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AddToHistoryWithLanguage(HSTRING queryText, HSTRING language)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, HSTRING, HSTRING, int>)((*lpVtbl)[16])
        )(this, queryText, language);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ClearHistory()
    {
        return ((delegate* unmanaged<ISearchSuggestionManager, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT add_SuggestionsRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[18])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT remove_SuggestionsRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, EventRegistrationToken, int>)(
                (*lpVtbl)[19]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT add_RequestingFocusOnKeyboardInput(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionManager,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[20])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT remove_RequestingFocusOnKeyboardInput(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionManager, EventRegistrationToken, int>)(
                (*lpVtbl)[21]
            )
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SearchHistoryEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_SearchHistoryEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_SearchHistoryContext(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_SearchHistoryContext(HSTRING value);

        [VtblIndex(10)]
        HRESULT SetLocalContentSuggestionSettings(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *"
            )]
                ILocalContentSuggestionSettings settings
        );

        [VtblIndex(11)]
        HRESULT SetQuery(HSTRING queryText);

        [VtblIndex(12)]
        HRESULT SetQueryWithLanguage(HSTRING queryText, HSTRING language);

        [VtblIndex(13)]
        HRESULT SetQueryWithSearchQueryLinguisticDetails(
            HSTRING queryText,
            HSTRING language,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *"
            )]
                ISearchQueryLinguisticDetails linguisticDetails
        );

        [VtblIndex(14)]
        HRESULT get_Suggestions(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **"
            )]
                IObservableVector<IntPtr>** value
        );

        [VtblIndex(15)]
        HRESULT AddToHistory(HSTRING queryText);

        [VtblIndex(16)]
        HRESULT AddToHistoryWithLanguage(HSTRING queryText, HSTRING language);

        [VtblIndex(17)]
        HRESULT ClearHistory();

        [VtblIndex(18)]
        HRESULT add_SuggestionsRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(19)]
        HRESULT remove_SuggestionsRequested(EventRegistrationToken token);

        [VtblIndex(20)]
        HRESULT add_RequestingFocusOnKeyboardInput(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(21)]
        HRESULT remove_RequestingFocusOnKeyboardInput(EventRegistrationToken token);
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
        public delegate* unmanaged<TSelf*, byte*, int> get_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_SearchHistoryEnabled;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SearchHistoryContext;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_SearchHistoryContext;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ILocalContentSuggestionSettings *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ILocalContentSuggestionSettings,
            int> SetLocalContentSuggestionSettings;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> SetQuery;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> SetQueryWithLanguage;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            ISearchQueryLinguisticDetails,
            int> SetQueryWithSearchQueryLinguisticDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIObservableVector_1_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestion_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IObservableVector<IntPtr>**, int> get_Suggestions;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> AddToHistory;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> AddToHistoryWithLanguage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearHistory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionsRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SuggestionsRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SuggestionsRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CSearch__CCore__CSearchSuggestionManager_Windows__CApplicationModel__CSearch__CCore__CRequestingFocusOnKeyboardInputEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_RequestingFocusOnKeyboardInput;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            EventRegistrationToken,
            int> remove_RequestingFocusOnKeyboardInput;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchSuggestionManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchSuggestionManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISearchSuggestionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionManager(Silk.NET.WinRT.IInspectable value)
    {
        return new ISearchSuggestionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionManager"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISearchSuggestionManager value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchSuggestionManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionManager(Silk.NET.Windows.IUnknown value)
    {
        return new ISearchSuggestionManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISearchSuggestionManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
