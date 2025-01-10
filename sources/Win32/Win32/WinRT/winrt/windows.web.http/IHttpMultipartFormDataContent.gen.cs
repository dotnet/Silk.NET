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

[Guid("64D337E2-E967-4624-B6D1-CF74604A4A42")]
[NativeTypeName("struct IHttpMultipartFormDataContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpMultipartFormDataContent
    : IHttpMultipartFormDataContent.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpMultipartFormDataContent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IHttpMultipartFormDataContent, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpMultipartFormDataContent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpMultipartFormDataContent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IHttpMultipartFormDataContent, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpMultipartFormDataContent, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IHttpMultipartFormDataContent, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Add(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content
    )
    {
        return (
            (delegate* unmanaged<IHttpMultipartFormDataContent, IHttpContent, int>)((*lpVtbl)[6])
        )(this, content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddWithName(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
        HSTRING name
    )
    {
        return (
            (delegate* unmanaged<IHttpMultipartFormDataContent, IHttpContent, HSTRING, int>)(
                (*lpVtbl)[7]
            )
        )(this, content, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT AddWithNameAndFileName(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
        HSTRING name,
        HSTRING fileName
    )
    {
        return (
            (delegate* unmanaged<
                IHttpMultipartFormDataContent,
                IHttpContent,
                HSTRING,
                HSTRING,
                int>)((*lpVtbl)[8])
        )(this, content, name, fileName);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Add(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content
        );

        [VtblIndex(7)]
        HRESULT AddWithName(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
            HSTRING name
        );

        [VtblIndex(8)]
        HRESULT AddWithNameAndFileName(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpContent *")] IHttpContent content,
            HSTRING name,
            HSTRING fileName
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
            "HRESULT (ABI::Windows::Web::Http::IHttpContent *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContent, int> Add;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpContent *, HSTRING) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContent, HSTRING, int> AddWithName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpContent *, HSTRING, HSTRING) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHttpContent,
            HSTRING,
            HSTRING,
            int> AddWithNameAndFileName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpMultipartFormDataContent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpMultipartFormDataContent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpMultipartFormDataContent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpMultipartFormDataContent(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpMultipartFormDataContent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMultipartFormDataContent"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMultipartFormDataContent"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpMultipartFormDataContent value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpMultipartFormDataContent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpMultipartFormDataContent(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpMultipartFormDataContent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpMultipartFormDataContent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpMultipartFormDataContent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpMultipartFormDataContent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
