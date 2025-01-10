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

[Guid("6E866D48-06AF-4462-8158-99388D5DCA81")]
[NativeTypeName("struct IHttpCookiePairHeaderValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpCookiePairHeaderValueStatics
    : IHttpCookiePairHeaderValueStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpCookiePairHeaderValueStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpCookiePairHeaderValueStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpCookiePairHeaderValueStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpCookiePairHeaderValueStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpCookiePairHeaderValueStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpCookiePairHeaderValueStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpCookiePairHeaderValueStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")]
            IHttpCookiePairHeaderValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IHttpCookiePairHeaderValueStatics,
                HSTRING,
                IHttpCookiePairHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, input, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")]
            IHttpCookiePairHeaderValue* cookiePairHeaderValue,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<
                IHttpCookiePairHeaderValueStatics,
                HSTRING,
                IHttpCookiePairHeaderValue*,
                byte*,
                int>)((*lpVtbl)[7])
        )(this, input, cookiePairHeaderValue, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")]
                IHttpCookiePairHeaderValue* result
        );

        [VtblIndex(7)]
        HRESULT TryParse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **")]
                IHttpCookiePairHeaderValue* cookiePairHeaderValue,
            [NativeTypeName("boolean *")] byte* succeeded
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IHttpCookiePairHeaderValue*, int> Parse;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpCookiePairHeaderValue **, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpCookiePairHeaderValue*,
            byte*,
            int> TryParse;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpCookiePairHeaderValueStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpCookiePairHeaderValueStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpCookiePairHeaderValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpCookiePairHeaderValueStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpCookiePairHeaderValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCookiePairHeaderValueStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCookiePairHeaderValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpCookiePairHeaderValueStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpCookiePairHeaderValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpCookiePairHeaderValueStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpCookiePairHeaderValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpCookiePairHeaderValueStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpCookiePairHeaderValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpCookiePairHeaderValueStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
