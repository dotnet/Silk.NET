// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IProtectionPolicyManagerInterop.xml' path='doc/member[@name="IProtectionPolicyManagerInterop"]/*'/>
[Guid("4652651D-C1FE-4BA1-9F0A-C0F56596F721")]
[NativeTypeName("struct IProtectionPolicyManagerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IProtectionPolicyManagerInterop : IProtectionPolicyManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectionPolicyManagerInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, Guid*, void**, int> )(lpVtbl[0]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint> )(lpVtbl[1]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint> )(lpVtbl[2]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HSTRING*, int> )(lpVtbl[4]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, TrustLevel*, int> )(lpVtbl[5]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IProtectionPolicyManagerInterop.xml' path='doc/member[@name="IProtectionPolicyManagerInterop.RequestAccessForWindowAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HWND, HSTRING, HSTRING, Guid*, void**, int> )(lpVtbl[6]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, sourceIdentity, targetIdentity, riid, asyncOperation);
    }

    /// <include file='IProtectionPolicyManagerInterop.xml' path='doc/member[@name="IProtectionPolicyManagerInterop.GetForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** result)
    {
        return ((delegate* unmanaged<IProtectionPolicyManagerInterop*, HWND, Guid*, void**, int> )(lpVtbl[7]))((IProtectionPolicyManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessForWindowAsync(HWND appWindow, HSTRING sourceIdentity, HSTRING targetIdentity, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);
        [VtblIndex(7)]
        HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** result);
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
        public delegate* unmanaged<TSelf*, HWND, HSTRING, HSTRING, Guid*, void**, int> RequestAccessForWindowAsync;
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> GetForWindow;
    }
}