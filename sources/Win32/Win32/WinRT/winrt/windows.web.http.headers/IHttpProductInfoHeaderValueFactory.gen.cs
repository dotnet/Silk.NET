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

[Guid("24220FBE-EABE-4464-B460-EC010B7C41E2")]
[NativeTypeName("struct IHttpProductInfoHeaderValueFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpProductInfoHeaderValueFactory
    : IHttpProductInfoHeaderValueFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpProductInfoHeaderValueFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpProductInfoHeaderValueFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpProductInfoHeaderValueFactory, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpProductInfoHeaderValueFactory, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IHttpProductInfoHeaderValueFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IHttpProductInfoHeaderValueFactory, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpProductInfoHeaderValueFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromComment(
        HSTRING productComment,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")]
            IHttpProductInfoHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpProductInfoHeaderValueFactory,
                HSTRING,
                IHttpProductInfoHeaderValue*,
                int>)((*lpVtbl)[6])
        )(this, productComment, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromNameWithVersion(
        HSTRING productName,
        HSTRING productVersion,
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")]
            IHttpProductInfoHeaderValue* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpProductInfoHeaderValueFactory,
                HSTRING,
                HSTRING,
                IHttpProductInfoHeaderValue*,
                int>)((*lpVtbl)[7])
        )(this, productName, productVersion, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromComment(
            HSTRING productComment,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")]
                IHttpProductInfoHeaderValue* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromNameWithVersion(
            HSTRING productName,
            HSTRING productVersion,
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **")]
                IHttpProductInfoHeaderValue* value
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IHttpProductInfoHeaderValue*,
            int> CreateFromComment;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Web::Http::Headers::IHttpProductInfoHeaderValue **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IHttpProductInfoHeaderValue*,
            int> CreateFromNameWithVersion;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpProductInfoHeaderValueFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpProductInfoHeaderValueFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpProductInfoHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpProductInfoHeaderValueFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IHttpProductInfoHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpProductInfoHeaderValueFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpProductInfoHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IHttpProductInfoHeaderValueFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpProductInfoHeaderValueFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpProductInfoHeaderValueFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IHttpProductInfoHeaderValueFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpProductInfoHeaderValueFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpProductInfoHeaderValueFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IHttpProductInfoHeaderValueFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
