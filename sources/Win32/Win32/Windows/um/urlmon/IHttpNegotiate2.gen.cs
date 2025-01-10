// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4F9F9FCB-E0F4-48EB-B7AB-FA2EA9365CB4")]
[NativeTypeName("struct IHttpNegotiate2 : IHttpNegotiate")]
[NativeInheritance("IHttpNegotiate")]
public unsafe partial struct IHttpNegotiate2 : IHttpNegotiate2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpNegotiate2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpNegotiate2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpNegotiate2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginningTransaction(
        [NativeTypeName("LPCWSTR")] ushort* szURL,
        [NativeTypeName("LPCWSTR")] ushort* szHeaders,
        [NativeTypeName("DWORD")] uint dwReserved,
        [NativeTypeName("LPWSTR *")] ushort** pszAdditionalHeaders
    )
    {
        return (
            (delegate* unmanaged<IHttpNegotiate2, ushort*, ushort*, uint, ushort**, int>)(
                (*lpVtbl)[3]
            )
        )(this, szURL, szHeaders, dwReserved, pszAdditionalHeaders);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnResponse(
        [NativeTypeName("DWORD")] uint dwResponseCode,
        [NativeTypeName("LPCWSTR")] ushort* szResponseHeaders,
        [NativeTypeName("LPCWSTR")] ushort* szRequestHeaders,
        [NativeTypeName("LPWSTR *")] ushort** pszAdditionalRequestHeaders
    )
    {
        return (
            (delegate* unmanaged<IHttpNegotiate2, uint, ushort*, ushort*, ushort**, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRootSecurityId(
        byte* pbSecurityId,
        [NativeTypeName("DWORD *")] uint* pcbSecurityId,
        [NativeTypeName("DWORD_PTR")] nuint dwReserved
    )
    {
        return ((delegate* unmanaged<IHttpNegotiate2, byte*, uint*, nuint, int>)((*lpVtbl)[5]))(
            this,
            pbSecurityId,
            pcbSecurityId,
            dwReserved
        );
    }

    public interface Interface : IHttpNegotiate.Interface
    {
        [VtblIndex(5)]
        HRESULT GetRootSecurityId(
            byte* pbSecurityId,
            [NativeTypeName("DWORD *")] uint* pcbSecurityId,
            [NativeTypeName("DWORD_PTR")] nuint dwReserved
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, DWORD, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint,
            ushort**,
            int> BeginningTransaction;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, ushort**, int> OnResponse;

        [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, nuint, int> GetRootSecurityId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpNegotiate2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpNegotiate2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IHttpNegotiate"/> to <see cref = "IHttpNegotiate2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IHttpNegotiate"/> instance to be converted </param>
    public static explicit operator IHttpNegotiate2(Silk.NET.Windows.IHttpNegotiate value)
    {
        return new IHttpNegotiate2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpNegotiate2"/> to <see cref = "Silk.NET.Windows.IHttpNegotiate"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpNegotiate2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IHttpNegotiate(IHttpNegotiate2 value)
    {
        return new Silk.NET.Windows.IHttpNegotiate(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpNegotiate2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpNegotiate2(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpNegotiate2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpNegotiate2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpNegotiate2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpNegotiate2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
