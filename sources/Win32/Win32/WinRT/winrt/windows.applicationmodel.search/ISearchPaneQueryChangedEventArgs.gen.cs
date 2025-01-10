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

[Guid("3C064FE9-2351-4248-A529-7110F464A785")]
[NativeTypeName("struct ISearchPaneQueryChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
)]
public unsafe partial struct ISearchPaneQueryChangedEventArgs
    : ISearchPaneQueryChangedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISearchPaneQueryChangedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISearchPaneQueryChangedEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISearchPaneQueryChangedEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT get_QueryText(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, HSTRING*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT get_Language(HSTRING* value)
    {
        return (
            (delegate* unmanaged<ISearchPaneQueryChangedEventArgs, HSTRING*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT get_LinguisticDetails(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **"
        )]
            ISearchPaneQueryLinguisticDetails* value
    )
    {
        return (
            (delegate* unmanaged<
                ISearchPaneQueryChangedEventArgs,
                ISearchPaneQueryLinguisticDetails*,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_QueryText(HSTRING* value);

        [VtblIndex(7)]
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(8)]
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_LinguisticDetails(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **"
            )]
                ISearchPaneQueryLinguisticDetails* value
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
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_QueryText;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Search::ISearchPaneQueryLinguisticDetails **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "ISearchPaneQueryChangedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<
            TSelf*,
            ISearchPaneQueryLinguisticDetails*,
            int> get_LinguisticDetails;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISearchPaneQueryChangedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISearchPaneQueryChangedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISearchPaneQueryChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISearchPaneQueryChangedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISearchPaneQueryChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchPaneQueryChangedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchPaneQueryChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISearchPaneQueryChangedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISearchPaneQueryChangedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISearchPaneQueryChangedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISearchPaneQueryChangedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISearchPaneQueryChangedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISearchPaneQueryChangedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISearchPaneQueryChangedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
