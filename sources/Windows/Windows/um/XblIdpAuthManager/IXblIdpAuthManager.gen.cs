// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager"]/*'/>
[Guid("EB5DDB08-8BBF-449B-AC21-B02DDEB3B136")]
[NativeTypeName("struct IXblIdpAuthManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXblIdpAuthManager : IXblIdpAuthManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXblIdpAuthManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, Guid*, void**, int> )(lpVtbl[0]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, uint> )(lpVtbl[1]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, uint> )(lpVtbl[2]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.SetGamerAccount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGamerAccount([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* xuid)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, int> )(lpVtbl[3]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, xuid);
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.GetGamerAccount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGamerAccount([NativeTypeName("LPWSTR *")] ushort** msaAccountId, [NativeTypeName("LPWSTR *")] ushort** xuid)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, ushort**, int> )(lpVtbl[4]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, xuid);
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.SetAppViewInitialized"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAppViewInitialized([NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaAccountId)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, int> )(lpVtbl[5]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), appSid, msaAccountId);
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.GetEnvironment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, int> )(lpVtbl[6]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), environment);
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.GetSandbox"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort**, int> )(lpVtbl[7]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), sandbox);
    }

    /// <include file='IXblIdpAuthManager.xml' path='doc/member[@name="IXblIdpAuthManager.GetTokenAndSignatureWithTokenResult"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTokenAndSignatureWithTokenResult([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaTarget, [NativeTypeName("LPCWSTR")] ushort* msaPolicy, [NativeTypeName("LPCWSTR")] ushort* httpMethod, [NativeTypeName("LPCWSTR")] ushort* uri, [NativeTypeName("LPCWSTR")] ushort* headers, byte* body, [NativeTypeName("DWORD")] uint bodySize, BOOL forceRefresh, IXblIdpAuthTokenResult** result)
    {
        return ((delegate* unmanaged<IXblIdpAuthManager*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, byte*, uint, BOOL, IXblIdpAuthTokenResult**, int> )(lpVtbl[8]))((IXblIdpAuthManager*)Unsafe.AsPointer(ref this), msaAccountId, appSid, msaTarget, msaPolicy, httpMethod, uri, headers, body, bodySize, forceRefresh, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGamerAccount([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* xuid);
        [VtblIndex(4)]
        HRESULT GetGamerAccount([NativeTypeName("LPWSTR *")] ushort** msaAccountId, [NativeTypeName("LPWSTR *")] ushort** xuid);
        [VtblIndex(5)]
        HRESULT SetAppViewInitialized([NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaAccountId);
        [VtblIndex(6)]
        HRESULT GetEnvironment([NativeTypeName("LPWSTR *")] ushort** environment);
        [VtblIndex(7)]
        HRESULT GetSandbox([NativeTypeName("LPWSTR *")] ushort** sandbox);
        [VtblIndex(8)]
        HRESULT GetTokenAndSignatureWithTokenResult([NativeTypeName("LPCWSTR")] ushort* msaAccountId, [NativeTypeName("LPCWSTR")] ushort* appSid, [NativeTypeName("LPCWSTR")] ushort* msaTarget, [NativeTypeName("LPCWSTR")] ushort* msaPolicy, [NativeTypeName("LPCWSTR")] ushort* httpMethod, [NativeTypeName("LPCWSTR")] ushort* uri, [NativeTypeName("LPCWSTR")] ushort* headers, byte* body, [NativeTypeName("DWORD")] uint bodySize, BOOL forceRefresh, IXblIdpAuthTokenResult** result);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetGamerAccount;
        [NativeTypeName("HRESULT (LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, int> GetGamerAccount;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetAppViewInitialized;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetEnvironment;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSandbox;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, BYTE *, DWORD, BOOL, IXblIdpAuthTokenResult **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, ushort*, byte*, uint, BOOL, IXblIdpAuthTokenResult**, int> GetTokenAndSignatureWithTokenResult;
    }
}