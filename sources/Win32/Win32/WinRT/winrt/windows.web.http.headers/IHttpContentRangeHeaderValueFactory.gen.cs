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

[Guid("3F5BD691-A03C-4456-9A6F-EF27ECD03CAE")]
[NativeTypeName("struct IHttpContentRangeHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContentRangeHeaderValueFactory
    : IHttpContentRangeHeaderValueFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContentRangeHeaderValueFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpContentRangeHeaderValueFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpContentRangeHeaderValueFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpContentRangeHeaderValueFactory, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IHttpContentRangeHeaderValueFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpContentRangeHeaderValueFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpContentRangeHeaderValueFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromLength(
        [NativeTypeName("UINT64")] ulong length,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
            IHttpContentRangeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentRangeHeaderValueFactory,
                ulong,
                IHttpContentRangeHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, length, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromRange(
        [NativeTypeName("UINT64")] ulong from,
        [NativeTypeName("UINT64")] ulong to,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
            IHttpContentRangeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentRangeHeaderValueFactory,
                ulong,
                ulong,
                IHttpContentRangeHeaderValue*,
                int>)((*lpVtbl)[7])
        )(this, from, to, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromRangeWithLength(
        [NativeTypeName("UINT64")] ulong from,
        [NativeTypeName("UINT64")] ulong to,
        [NativeTypeName("UINT64")] ulong length,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
            IHttpContentRangeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContentRangeHeaderValueFactory,
                ulong,
                ulong,
                ulong,
                IHttpContentRangeHeaderValue*,
                int>)((*lpVtbl)[8])
        )(this, from, to, length, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromLength(
            [NativeTypeName("UINT64")] ulong length,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
                IHttpContentRangeHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromRange(
            [NativeTypeName("UINT64")] ulong from,
            [NativeTypeName("UINT64")] ulong to,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
                IHttpContentRangeHeaderValue* value
        );

        [VtblIndex(8)]
        HRESULT CreateFromRangeWithLength(
            [NativeTypeName("UINT64")] ulong from,
            [NativeTypeName("UINT64")] ulong to,
            [NativeTypeName("UINT64")] ulong length,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **")]
                IHttpContentRangeHeaderValue* value
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
            "HRESULT (UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            IHttpContentRangeHeaderValue*,
            int> CreateFromLength;

        [NativeTypeName(
            "HRESULT (UINT64, UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            ulong,
            IHttpContentRangeHeaderValue*,
            int> CreateFromRange;

        [NativeTypeName(
            "HRESULT (UINT64, UINT64, UINT64, ABI::Windows::Web::Http::Headers::IHttpContentRangeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ulong,
            ulong,
            ulong,
            IHttpContentRangeHeaderValue*,
            int> CreateFromRangeWithLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpContentRangeHeaderValueFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpContentRangeHeaderValueFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpContentRangeHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpContentRangeHeaderValueFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpContentRangeHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContentRangeHeaderValueFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContentRangeHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpContentRangeHeaderValueFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpContentRangeHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpContentRangeHeaderValueFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpContentRangeHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContentRangeHeaderValueFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContentRangeHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpContentRangeHeaderValueFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
