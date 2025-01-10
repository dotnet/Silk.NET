// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("46649D5B-2E93-48EB-8E61-19677878E57F")]
[NativeTypeName("struct IHttpStringContentFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpStringContentFactory
    : IHttpStringContentFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpStringContentFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpStringContentFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpStringContentFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpStringContentFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpStringContentFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpStringContentFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpStringContentFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromString(
        HSTRING content,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
    )
    {
        return (
            (delegate* unmanaged<IHttpStringContentFactory, HSTRING, IHttpContent*, int>)(
                (*lpVtbl)[6]
            )
        )(this, content, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromStringWithEncoding(
        HSTRING content,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpStringContentFactory,
                HSTRING,
                UnicodeEncoding,
                IHttpContent*,
                int>)((*lpVtbl)[7])
        )(this, content, encoding, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFromStringWithEncodingAndMediaType(
        HSTRING content,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        HSTRING mediaType,
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
    )
    {
        return (
            (delegate* unmanaged<
                IHttpStringContentFactory,
                HSTRING,
                UnicodeEncoding,
                HSTRING,
                IHttpContent*,
                int>)((*lpVtbl)[8])
        )(this, content, encoding, mediaType, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromString(
            HSTRING content,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
        );

        [VtblIndex(7)]
        HRESULT CreateFromStringWithEncoding(
            HSTRING content,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
        );

        [VtblIndex(8)]
        HRESULT CreateFromStringWithEncodingAndMediaType(
            HSTRING content,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            HSTRING mediaType,
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent **")] IHttpContent* value
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
            "HRESULT (HSTRING, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IHttpContent*, int> CreateFromString;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            UnicodeEncoding,
            IHttpContent*,
            int> CreateFromStringWithEncoding;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, HSTRING, ABI::Windows::Web::Http::IHttpContent **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            UnicodeEncoding,
            HSTRING,
            IHttpContent*,
            int> CreateFromStringWithEncodingAndMediaType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpStringContentFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpStringContentFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpStringContentFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpStringContentFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpStringContentFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpStringContentFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpStringContentFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpStringContentFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpStringContentFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpStringContentFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpStringContentFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpStringContentFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpStringContentFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpStringContentFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
