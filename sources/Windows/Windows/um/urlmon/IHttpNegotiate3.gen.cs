// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHttpNegotiate3.xml' path='doc/member[@name="IHttpNegotiate3"]/*'/>
[Guid("57B6C80A-34C2-4602-BC26-66A02FC57153")]
[NativeTypeName("struct IHttpNegotiate3 : IHttpNegotiate2")]
[NativeInheritance("IHttpNegotiate2")]
public unsafe partial struct IHttpNegotiate3 : IHttpNegotiate3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, Guid*, void**, int> )(lpVtbl[0]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, uint> )(lpVtbl[1]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, uint> )(lpVtbl[2]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IHttpNegotiate.BeginningTransaction"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginningTransaction([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPCWSTR")] ushort* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalHeaders)
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, ushort*, ushort*, uint, ushort**, int> )(lpVtbl[3]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
    }

    /// <inheritdoc cref = "IHttpNegotiate.OnResponse"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] ushort* szResponseHeaders, [NativeTypeName("LPCWSTR")] ushort* szRequestHeaders, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalRequestHeaders)
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, uint, ushort*, ushort*, ushort**, int> )(lpVtbl[4]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
    }

    /// <inheritdoc cref = "IHttpNegotiate2.GetRootSecurityId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetRootSecurityId(byte* pbSecurityId, [NativeTypeName("DWORD *")] uint* pcbSecurityId, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, byte*, uint*, nuint, int> )(lpVtbl[5]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this), pbSecurityId, pcbSecurityId, dwReserved);
    }

    /// <include file='IHttpNegotiate3.xml' path='doc/member[@name="IHttpNegotiate3.GetSerializedClientCertContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSerializedClientCertContext(byte** ppbCert, [NativeTypeName("DWORD *")] uint* pcbCert)
    {
        return ((delegate* unmanaged<IHttpNegotiate3*, byte**, uint*, int> )(lpVtbl[6]))((IHttpNegotiate3*)Unsafe.AsPointer(ref this), ppbCert, pcbCert);
    }

    public interface Interface : IHttpNegotiate2.Interface
    {
        [VtblIndex(6)]
        HRESULT GetSerializedClientCertContext(byte** ppbCert, [NativeTypeName("DWORD *")] uint* pcbCert);
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
        public delegate* unmanaged<TSelf*, ushort*, ushort*, uint, ushort**, int> BeginningTransaction;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, ushort**, int> OnResponse;
        [NativeTypeName("HRESULT (BYTE *, DWORD *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint*, nuint, int> GetRootSecurityId;
        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetSerializedClientCertContext;
    }
}