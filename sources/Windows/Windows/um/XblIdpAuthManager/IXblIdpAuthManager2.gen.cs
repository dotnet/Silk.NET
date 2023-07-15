// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXblIdpAuthManager2.xml' path='doc/member[@name="IXblIdpAuthManager2"]/*'/>
[Guid("BF8C0950-8389-43DD-9A76-A19728EC5DC5")]
[NativeTypeName("struct IXblIdpAuthManager2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXblIdpAuthManager2 : IXblIdpAuthManager2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXblIdpAuthManager2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager2*, Guid*, void**, int> )(lpVtbl[0]))((IXblIdpAuthManager2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXblIdpAuthManager2*, uint> )(lpVtbl[1]))((IXblIdpAuthManager2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXblIdpAuthManager2*, uint> )(lpVtbl[2]))((IXblIdpAuthManager2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXblIdpAuthManager2.xml' path='doc/member[@name="IXblIdpAuthManager2.GetUserlessTokenAndSignatureWithTokenResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetUserlessTokenAndSignatureWithTokenResult([NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaTarget, [NativeTypeName("LPCWSTR")] ushort* msaPolicy, [NativeTypeName("LPCWSTR")] ushort* httpMethod, [NativeTypeName("LPCWSTR")] ushort* uri, [NativeTypeName("LPCWSTR")] ushort* headers, byte* body, [NativeTypeName("DWORD")] uint bodySize, BOOL forceRefresh, IXblIdpAuthTokenResult** result)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager2*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, byte*, uint, BOOL, IXblIdpAuthTokenResult**, int> )(lpVtbl[3]))((IXblIdpAuthManager2*)Unsafe.AsPointer(ref this), appSid, msaTarget, msaPolicy, httpMethod, uri, headers, body, bodySize, forceRefresh, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetUserlessTokenAndSignatureWithTokenResult([NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaTarget, [NativeTypeName("LPCWSTR")] ushort* msaPolicy, [NativeTypeName("LPCWSTR")] ushort* httpMethod, [NativeTypeName("LPCWSTR")] ushort* uri, [NativeTypeName("LPCWSTR")] ushort* headers, byte* body, [NativeTypeName("DWORD")] uint bodySize, BOOL forceRefresh, IXblIdpAuthTokenResult** result);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, BYTE *, DWORD, BOOL, IXblIdpAuthTokenResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, byte*, uint, BOOL, IXblIdpAuthTokenResult**, int> GetUserlessTokenAndSignatureWithTokenResult;
    }
}