// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IStorageProviderBanners.xml' path='doc/member[@name="IStorageProviderBanners"]/*'/>
[Guid("5EFB46D7-47C0-4B68-ACDA-DED47C90EC91")]
[NativeTypeName("struct IStorageProviderBanners : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderBanners : IStorageProviderBanners.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderBanners));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, Guid*, void**, int> )(lpVtbl[0]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, uint> )(lpVtbl[1]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, uint> )(lpVtbl[2]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStorageProviderBanners.xml' path='doc/member[@name="IStorageProviderBanners.SetBanner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPCWSTR")] ushort* contentId)
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, ushort*, int> )(lpVtbl[3]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId, contentId);
    }

    /// <include file='IStorageProviderBanners.xml' path='doc/member[@name="IStorageProviderBanners.ClearBanner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ClearBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId)
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, int> )(lpVtbl[4]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId);
    }

    /// <include file='IStorageProviderBanners.xml' path='doc/member[@name="IStorageProviderBanners.ClearAllBanners"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ClearAllBanners([NativeTypeName("LPCWSTR")] ushort* providerIdentity)
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, int> )(lpVtbl[5]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity);
    }

    /// <include file='IStorageProviderBanners.xml' path='doc/member[@name="IStorageProviderBanners.GetBanner"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPWSTR *")] ushort** contentId)
    {
        return ((delegate* unmanaged<IStorageProviderBanners*, ushort*, ushort*, ushort**, int> )(lpVtbl[6]))((IStorageProviderBanners*)Unsafe.AsPointer(ref this), providerIdentity, subscriptionId, contentId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPCWSTR")] ushort* contentId);
        [VtblIndex(4)]
        HRESULT ClearBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId);
        [VtblIndex(5)]
        HRESULT ClearAllBanners([NativeTypeName("LPCWSTR")] ushort* providerIdentity);
        [VtblIndex(6)]
        HRESULT GetBanner([NativeTypeName("LPCWSTR")] ushort* providerIdentity, [NativeTypeName("LPCWSTR")] ushort* subscriptionId, [NativeTypeName("LPWSTR *")] ushort** contentId);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> SetBanner;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> ClearBanner;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ClearAllBanners;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort**, int> GetBanner;
    }
}