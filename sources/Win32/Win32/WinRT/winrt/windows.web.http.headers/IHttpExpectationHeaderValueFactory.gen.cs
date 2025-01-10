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

[Guid("4EA275CB-D53E-4868-8856-1E21A5030DC0")]
[NativeTypeName("struct IHttpExpectationHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpExpectationHeaderValueFactory
    : IHttpExpectationHeaderValueFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpExpectationHeaderValueFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpExpectationHeaderValueFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpExpectationHeaderValueFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpExpectationHeaderValueFactory, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IHttpExpectationHeaderValueFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpExpectationHeaderValueFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpExpectationHeaderValueFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromName(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")]
            IHttpExpectationHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpExpectationHeaderValueFactory,
                HSTRING,
                IHttpExpectationHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, name, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNameWithValue(
        HSTRING name,
        HSTRING value,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")]
            IHttpExpectationHeaderValue* expectationHeaderValue
    )
    {
        return (
            (delegate* unmanaged<
                IHttpExpectationHeaderValueFactory,
                HSTRING,
                HSTRING,
                IHttpExpectationHeaderValue*,
                int>)((*lpVtbl)[7])
        )(this, name, value, expectationHeaderValue);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromName(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")]
                IHttpExpectationHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromNameWithValue(
            HSTRING name,
            HSTRING value,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **")]
                IHttpExpectationHeaderValue* expectationHeaderValue
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpExpectationHeaderValue*,
            int> CreateFromName;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpExpectationHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IHttpExpectationHeaderValue*,
            int> CreateFromNameWithValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpExpectationHeaderValueFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpExpectationHeaderValueFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpExpectationHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpExpectationHeaderValueFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpExpectationHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpExpectationHeaderValueFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpExpectationHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpExpectationHeaderValueFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpExpectationHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpExpectationHeaderValueFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpExpectationHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpExpectationHeaderValueFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpExpectationHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpExpectationHeaderValueFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
