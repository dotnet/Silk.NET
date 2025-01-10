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

[Guid("6FD519E5-9E7E-4AB4-8BE3-C76B1BD4344A")]
[NativeTypeName("struct ISearchSuggestionsRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISearchSuggestionsRequestedEventArgs
    : ISearchSuggestionsRequestedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchSuggestionsRequestedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Language(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISearchSuggestionsRequestedEventArgs, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LinguisticDetails(
        [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **")]
            ISearchQueryLinguisticDetails* value
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionsRequestedEventArgs,
                ISearchQueryLinguisticDetails*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Request(
        [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **")]
            ISearchSuggestionsRequest* value
    )
    {
        return (
            (delegate* unmanaged<
                ISearchSuggestionsRequestedEventArgs,
                ISearchSuggestionsRequest*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LinguisticDetails(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **"
            )]
                ISearchQueryLinguisticDetails* value
        );

        [VtblIndex(9)]
        HRESULT get_Request(
            [NativeTypeName("ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **")]
                ISearchSuggestionsRequest* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ISearchQueryLinguisticDetails **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISearchQueryLinguisticDetails*,
            int> get_LinguisticDetails;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ISearchSuggestionsRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISearchSuggestionsRequest*, int> get_Request;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchSuggestionsRequestedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchSuggestionsRequestedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISearchSuggestionsRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionsRequestedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISearchSuggestionsRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionsRequestedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionsRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISearchSuggestionsRequestedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchSuggestionsRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchSuggestionsRequestedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISearchSuggestionsRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchSuggestionsRequestedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchSuggestionsRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISearchSuggestionsRequestedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
