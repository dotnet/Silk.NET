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

[Guid("4E4E26A7-44E5-4039-9099-6000EAD1F0C6")]
[NativeTypeName("struct ISearchSuggestionsRequest : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionsRequest
    : ISearchSuggestionsRequest.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionsRequest));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISearchSuggestionsRequest, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequest, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SearchSuggestionCollection(
        [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **")]
            ISearchSuggestionCollection* collection
    )
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequest, ISearchSuggestionCollection*, int>)(
                (*lpVtbl)[7]
            )
        )(this, collection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeferral(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **"
        )]
            ISearchSuggestionsRequestDeferral* deferral
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionsRequest,
                ISearchSuggestionsRequestDeferral*,
                int>)((*lpVtbl)[8])
        )(this, deferral);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_IsCanceled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_SearchSuggestionCollection(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **"
            )]
                ISearchSuggestionCollection* collection
        );

        [VtblIndex(8)]
        HRESULT GetDeferral(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **"
            )]
                ISearchSuggestionsRequestDeferral* deferral
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
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCanceled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISearchSuggestionCollection*,
            int> get_SearchSuggestionCollection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequestDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISearchSuggestionsRequestDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchSuggestionsRequest"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchSuggestionsRequest(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISearchSuggestionsRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionsRequest(Silk.NET.WinRT.IInspectable value)
    {
        return new ISearchSuggestionsRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionsRequest"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionsRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISearchSuggestionsRequest value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchSuggestionsRequest"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionsRequest(Silk.NET.Windows.IUnknown value)
    {
        return new ISearchSuggestionsRequest(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionsRequest"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionsRequest"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISearchSuggestionsRequest value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
