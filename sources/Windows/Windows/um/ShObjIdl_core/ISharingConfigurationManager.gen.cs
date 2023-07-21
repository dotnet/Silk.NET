// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager"]/*' />
[Guid("B4CD448A-9C86-4466-9201-2E62105B87AE")]
[NativeTypeName("struct ISharingConfigurationManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISharingConfigurationManager : ISharingConfigurationManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISharingConfigurationManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, Guid*, void**, int>)(lpVtbl[0]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[1]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, uint>)(lpVtbl[2]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.CreateShare"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateShare(DEF_SHARE_ID dsid, SHARE_ROLE role)
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE, int>)(lpVtbl[3]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, role);
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.DeleteShare"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DeleteShare(DEF_SHARE_ID dsid)
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[4]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.ShareExists"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ShareExists(DEF_SHARE_ID dsid)
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, int>)(lpVtbl[5]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid);
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.GetSharePermissions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSharePermissions(DEF_SHARE_ID dsid, SHARE_ROLE* pRole)
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, DEF_SHARE_ID, SHARE_ROLE*, int>)(lpVtbl[6]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this), dsid, pRole);
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.SharePrinters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SharePrinters()
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[7]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.StopSharingPrinters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT StopSharingPrinters()
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[8]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISharingConfigurationManager.xml' path='doc/member[@name="ISharingConfigurationManager.ArePrintersShared"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ArePrintersShared()
    {
        return ((delegate* unmanaged<ISharingConfigurationManager*, int>)(lpVtbl[9]))((ISharingConfigurationManager*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateShare(DEF_SHARE_ID dsid, SHARE_ROLE role);

        [VtblIndex(4)]
        HRESULT DeleteShare(DEF_SHARE_ID dsid);

        [VtblIndex(5)]
        HRESULT ShareExists(DEF_SHARE_ID dsid);

        [VtblIndex(6)]
        HRESULT GetSharePermissions(DEF_SHARE_ID dsid, SHARE_ROLE* pRole);

        [VtblIndex(7)]
        HRESULT SharePrinters();

        [VtblIndex(8)]
        HRESULT StopSharingPrinters();

        [VtblIndex(9)]
        HRESULT ArePrintersShared();
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

        [NativeTypeName("HRESULT (DEF_SHARE_ID, SHARE_ROLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEF_SHARE_ID, SHARE_ROLE, int> CreateShare;

        [NativeTypeName("HRESULT (DEF_SHARE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEF_SHARE_ID, int> DeleteShare;

        [NativeTypeName("HRESULT (DEF_SHARE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEF_SHARE_ID, int> ShareExists;

        [NativeTypeName("HRESULT (DEF_SHARE_ID, SHARE_ROLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEF_SHARE_ID, SHARE_ROLE*, int> GetSharePermissions;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SharePrinters;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopSharingPrinters;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ArePrintersShared;
    }
}
