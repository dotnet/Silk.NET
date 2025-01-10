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

[Guid("7C2659A8-6672-4E90-9A9A-F39766F7F576")]
[NativeTypeName("struct IHttpDateOrDeltaHeaderValueStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpDateOrDeltaHeaderValueStatics
    : IHttpDateOrDeltaHeaderValueStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpDateOrDeltaHeaderValueStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpDateOrDeltaHeaderValueStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Parse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
            IHttpDateOrDeltaHeaderValue* result
    )
    {
        return (
            (delegate* unmanaged<
                IHttpDateOrDeltaHeaderValueStatics,
                HSTRING,
                IHttpDateOrDeltaHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, input, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryParse(
        HSTRING input,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
            IHttpDateOrDeltaHeaderValue* dateOrDeltaHeaderValue,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<
                IHttpDateOrDeltaHeaderValueStatics,
                HSTRING,
                IHttpDateOrDeltaHeaderValue*,
                byte*,
                int>)((*lpVtbl)[7])
        )(this, input, dateOrDeltaHeaderValue, succeeded);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Parse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
                IHttpDateOrDeltaHeaderValue* result
        );

        [VtblIndex(7)]
        HRESULT TryParse(
            HSTRING input,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **")]
                IHttpDateOrDeltaHeaderValue* dateOrDeltaHeaderValue,
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IHttpDateOrDeltaHeaderValue*, int> Parse;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpDateOrDeltaHeaderValue **, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpDateOrDeltaHeaderValue*,
            byte*,
            int> TryParse;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpDateOrDeltaHeaderValueStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpDateOrDeltaHeaderValueStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpDateOrDeltaHeaderValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpDateOrDeltaHeaderValueStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpDateOrDeltaHeaderValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpDateOrDeltaHeaderValueStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpDateOrDeltaHeaderValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpDateOrDeltaHeaderValueStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpDateOrDeltaHeaderValueStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpDateOrDeltaHeaderValueStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpDateOrDeltaHeaderValueStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpDateOrDeltaHeaderValueStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpDateOrDeltaHeaderValueStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpDateOrDeltaHeaderValueStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
