// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IInternetSecurityMgrSite.xml' path='doc/member[@name="IInternetSecurityMgrSite"]/*' />
[Guid("79EAC9ED-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetSecurityMgrSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetSecurityMgrSite : IInternetSecurityMgrSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetSecurityMgrSite));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetSecurityMgrSite*, Guid*, void**, int>)(lpVtbl[0]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetSecurityMgrSite*, uint>)(lpVtbl[1]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetSecurityMgrSite*, uint>)(lpVtbl[2]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetSecurityMgrSite.xml' path='doc/member[@name="IInternetSecurityMgrSite.GetWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow(HWND* phwnd)
    {
        return ((delegate* unmanaged<IInternetSecurityMgrSite*, HWND*, int>)(lpVtbl[3]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), phwnd);
    }

    /// <include file='IInternetSecurityMgrSite.xml' path='doc/member[@name="IInternetSecurityMgrSite.EnableModeless"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnableModeless(BOOL fEnable)
    {
        return ((delegate* unmanaged<IInternetSecurityMgrSite*, BOOL, int>)(lpVtbl[4]))((IInternetSecurityMgrSite*)Unsafe.AsPointer(ref this), fEnable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow(HWND* phwnd);

        [VtblIndex(4)]
        HRESULT EnableModeless(BOOL fEnable);
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

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetWindow;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> EnableModeless;
    }
}
