// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHttpNegotiate.xml' path='doc/member[@name="IHttpNegotiate"]/*'/>
[Guid("79EAC9D2-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IHttpNegotiate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHttpNegotiate : IHttpNegotiate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpNegotiate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpNegotiate*, Guid*, void**, int> )(lpVtbl[0]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHttpNegotiate*, uint> )(lpVtbl[1]))((IHttpNegotiate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpNegotiate*, uint> )(lpVtbl[2]))((IHttpNegotiate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpNegotiate.xml' path='doc/member[@name="IHttpNegotiate.BeginningTransaction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginningTransaction([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPCWSTR")] ushort* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalHeaders)
    {
        return ((delegate* unmanaged<IHttpNegotiate*, ushort*, ushort*, uint, ushort**, int> )(lpVtbl[3]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), szURL, szHeaders, dwReserved, pszAdditionalHeaders);
    }

    /// <include file='IHttpNegotiate.xml' path='doc/member[@name="IHttpNegotiate.OnResponse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] ushort* szResponseHeaders, [NativeTypeName("LPCWSTR")] ushort* szRequestHeaders, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalRequestHeaders)
    {
        return ((delegate* unmanaged<IHttpNegotiate*, uint, ushort*, ushort*, ushort**, int> )(lpVtbl[4]))((IHttpNegotiate*)Unsafe.AsPointer(ref this), dwResponseCode, szResponseHeaders, szRequestHeaders, pszAdditionalRequestHeaders);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginningTransaction([NativeTypeName("LPCWSTR")] ushort* szURL, [NativeTypeName("LPCWSTR")] ushort* szHeaders, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalHeaders);
        [VtblIndex(4)]
        HRESULT OnResponse([NativeTypeName("DWORD")] uint dwResponseCode, [NativeTypeName("LPCWSTR")] ushort* szResponseHeaders, [NativeTypeName("LPCWSTR")] ushort* szRequestHeaders, [NativeTypeName("LPWSTR *")] ushort** pszAdditionalRequestHeaders);
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
    }
}