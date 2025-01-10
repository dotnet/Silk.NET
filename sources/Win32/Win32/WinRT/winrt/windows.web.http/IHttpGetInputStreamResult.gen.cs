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

[Guid("D5D63463-13AA-4EE0-BE95-A0C39FE91203")]
[NativeTypeName("struct IHttpGetInputStreamResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpGetInputStreamResult
    : IHttpGetInputStreamResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpGetInputStreamResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpGetInputStreamResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, HRESULT*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RequestMessage(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")]
            IHttpRequestMessage* value
    )
    {
        return (
            (delegate* unmanaged<IHttpGetInputStreamResult, IHttpRequestMessage*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ResponseMessage(
        [NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")]
            IHttpResponseMessage* value
    )
    {
        return (
            (delegate* unmanaged<IHttpGetInputStreamResult, IHttpResponseMessage*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IHttpGetInputStreamResult, byte*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Value(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
    )
    {
        return (
            (delegate* unmanaged<IHttpGetInputStreamResult, IInputStream*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ExtendedError(HRESULT* value);

        [VtblIndex(7)]
        HRESULT get_RequestMessage(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpRequestMessage **")]
                IHttpRequestMessage* value
        );

        [VtblIndex(8)]
        HRESULT get_ResponseMessage(
            [NativeTypeName("ABI::Windows::Web::Http::IHttpResponseMessage **")]
                IHttpResponseMessage* value
        );

        [VtblIndex(9)]
        HRESULT get_Succeeded([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Value(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
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

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> get_ExtendedError;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpRequestMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpRequestMessage*, int> get_RequestMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Web::Http::IHttpResponseMessage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpResponseMessage*, int> get_ResponseMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Succeeded;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInputStream*, int> get_Value;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpGetInputStreamResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpGetInputStreamResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpGetInputStreamResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpGetInputStreamResult(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpGetInputStreamResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpGetInputStreamResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpGetInputStreamResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpGetInputStreamResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpGetInputStreamResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpGetInputStreamResult(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpGetInputStreamResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpGetInputStreamResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpGetInputStreamResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpGetInputStreamResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
