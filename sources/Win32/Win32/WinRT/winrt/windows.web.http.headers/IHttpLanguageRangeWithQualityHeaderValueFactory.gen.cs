// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("7BB83970-780F-4C83-9FE4-DC3087F6BD55")]
[NativeTypeName("struct IHttpLanguageRangeWithQualityHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpLanguageRangeWithQualityHeaderValueFactory
    : IHttpLanguageRangeWithQualityHeaderValueFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_IHttpLanguageRangeWithQualityHeaderValueFactory)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                IHttpLanguageRangeWithQualityHeaderValueFactory,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IHttpLanguageRangeWithQualityHeaderValueFactory, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IHttpLanguageRangeWithQualityHeaderValueFactory, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                IHttpLanguageRangeWithQualityHeaderValueFactory,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpLanguageRangeWithQualityHeaderValueFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                IHttpLanguageRangeWithQualityHeaderValueFactory,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLanguageRange(
        HSTRING languageRange,
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **"
        )]
            IHttpLanguageRangeWithQualityHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpLanguageRangeWithQualityHeaderValueFactory,
                HSTRING,
                IHttpLanguageRangeWithQualityHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, languageRange, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromLanguageRangeWithQuality(
        HSTRING languageRange,
        double quality,
        [NativeTypeName(
            "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **"
        )]
            IHttpLanguageRangeWithQualityHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpLanguageRangeWithQualityHeaderValueFactory,
                HSTRING,
                double,
                IHttpLanguageRangeWithQualityHeaderValue*,
                int>)((*lpVtbl)[7])
        )(this, languageRange, quality, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLanguageRange(
            HSTRING languageRange,
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **"
            )]
                IHttpLanguageRangeWithQualityHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromLanguageRangeWithQuality(
            HSTRING languageRange,
            double quality,
            [NativeTypeName(
                "ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **"
            )]
                IHttpLanguageRangeWithQualityHeaderValue* value
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpLanguageRangeWithQualityHeaderValue*,
            int> CreateFromLanguageRange;

        [NativeTypeName(
            "HRESULT (HSTRING, DOUBLE, ABI::Windows::Web::Http::Headers::IHttpLanguageRangeWithQualityHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            double,
            IHttpLanguageRangeWithQualityHeaderValue*,
            int> CreateFromLanguageRangeWithQuality;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpLanguageRangeWithQualityHeaderValueFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpLanguageRangeWithQualityHeaderValueFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpLanguageRangeWithQualityHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpLanguageRangeWithQualityHeaderValueFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpLanguageRangeWithQualityHeaderValueFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpLanguageRangeWithQualityHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpLanguageRangeWithQualityHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpLanguageRangeWithQualityHeaderValueFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
