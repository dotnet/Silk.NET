// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2"]/*' />
[Guid("157CFBE4-A78D-4156-B384-61FDAC41E686")]
[NativeTypeName("struct IProtectionPolicyManagerInterop2 : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IProtectionPolicyManagerInterop2 : IProtectionPolicyManagerInterop2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerInterop2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, Guid*, void**, int>)(lpVtbl[0]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint>)(lpVtbl[1]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint>)(lpVtbl[2]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, uint*, Guid**, int>)(lpVtbl[3]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HSTRING*, int>)(lpVtbl[4]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, TrustLevel*, int>)(lpVtbl[5]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2.RequestAccessForAppWithWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessForAppWithWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HWND, HSTRING, HSTRING, Guid*, void**, int>)(lpVtbl[6]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, riid, asyncOperation);
    }

    /// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2.RequestAccessWithAuditingInfoForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessWithAuditingInfoForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HWND, HSTRING, HSTRING, IUnknown*, Guid*, void**, int>)(lpVtbl[7]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, auditInfoUnk, riid, asyncOperation);
    }

    /// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2.RequestAccessWithMessageForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestAccessWithMessageForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, IUnknown* auditInfoUnk, HSTRING messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HWND, HSTRING, HSTRING, IUnknown*, HSTRING, Guid*, void**, int>)(lpVtbl[8]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, auditInfoUnk, messageFromApp, riid, asyncOperation);
    }

    /// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2.RequestAccessForAppWithAuditingInfoForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessForAppWithAuditingInfoForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HWND, HSTRING, HSTRING, IUnknown*, Guid*, void**, int>)(lpVtbl[9]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, auditInfoUnk, riid, asyncOperation);
    }

    /// <include file='IProtectionPolicyManagerInterop2.xml' path='doc/member[@name="IProtectionPolicyManagerInterop2.RequestAccessForAppWithMessageForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RequestAccessForAppWithMessageForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, IUnknown* auditInfoUnk, HSTRING messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop2*, HWND, HSTRING, HSTRING, IUnknown*, HSTRING, Guid*, void**, int>)(lpVtbl[10]))((IProtectionPolicyManagerInterop2*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, appPackageFamilyName, auditInfoUnk, messageFromApp, riid, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessForAppWithWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);

        [VtblIndex(7)]
        HRESULT RequestAccessWithAuditingInfoForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);

        [VtblIndex(8)]
        HRESULT RequestAccessWithMessageForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, IUnknown* auditInfoUnk, HSTRING messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);

        [VtblIndex(9)]
        HRESULT RequestAccessForAppWithAuditingInfoForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, IUnknown* auditInfoUnk, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);

        [VtblIndex(10)]
        HRESULT RequestAccessForAppWithMessageForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING appPackageFamilyName, IUnknown* auditInfoUnk, HSTRING messageFromApp, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);
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

        [NativeTypeName("HRESULT (HWND, HSTRING, HSTRING, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, Guid*, void**, int> RequestAccessForAppWithWindowAsync;

        [NativeTypeName("HRESULT (HWND, HSTRING, HSTRING, IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, IUnknown*, Guid*, void**, int> RequestAccessWithAuditingInfoForWindowAsync;

        [NativeTypeName("HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, IUnknown*, HSTRING, Guid*, void**, int> RequestAccessWithMessageForWindowAsync;

        [NativeTypeName("HRESULT (HWND, HSTRING, HSTRING, IUnknown *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, IUnknown*, Guid*, void**, int> RequestAccessForAppWithAuditingInfoForWindowAsync;

        [NativeTypeName("HRESULT (HWND, HSTRING, HSTRING, IUnknown *, HSTRING, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, IUnknown*, HSTRING, Guid*, void**, int> RequestAccessForAppWithMessageForWindowAsync;
    }
}
