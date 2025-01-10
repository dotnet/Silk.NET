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

[Guid("C452C451-D99C-40AA-9399-90EEB98FC613")]
[NativeTypeName("struct IHttpChallengeHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpChallengeHeaderValueFactory
    : IHttpChallengeHeaderValueFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpChallengeHeaderValueFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpChallengeHeaderValueFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpChallengeHeaderValueFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpChallengeHeaderValueFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpChallengeHeaderValueFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpChallengeHeaderValueFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpChallengeHeaderValueFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromScheme(
        HSTRING scheme,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")]
            IHttpChallengeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpChallengeHeaderValueFactory,
                HSTRING,
                IHttpChallengeHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, scheme, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromSchemeWithToken(
        HSTRING scheme,
        HSTRING token,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")]
            IHttpChallengeHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpChallengeHeaderValueFactory,
                HSTRING,
                HSTRING,
                IHttpChallengeHeaderValue*,
                int>)((*lpVtbl)[7])
        )(this, scheme, token, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromScheme(
            HSTRING scheme,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")]
                IHttpChallengeHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromSchemeWithToken(
            HSTRING scheme,
            HSTRING token,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **")]
                IHttpChallengeHeaderValue* value
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpChallengeHeaderValue*,
            int> CreateFromScheme;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpChallengeHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IHttpChallengeHeaderValue*,
            int> CreateFromSchemeWithToken;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpChallengeHeaderValueFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpChallengeHeaderValueFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpChallengeHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpChallengeHeaderValueFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpChallengeHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpChallengeHeaderValueFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpChallengeHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpChallengeHeaderValueFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpChallengeHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpChallengeHeaderValueFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpChallengeHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpChallengeHeaderValueFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpChallengeHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpChallengeHeaderValueFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
