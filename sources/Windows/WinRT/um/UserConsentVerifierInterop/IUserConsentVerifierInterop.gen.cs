// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserConsentVerifierInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IUserConsentVerifierInterop.xml' path='doc/member[@name="IUserConsentVerifierInterop"]/*'/>
[Guid("39E050C3-4E74-441A-8DC0-B81104DF949C")]
[NativeTypeName("struct IUserConsentVerifierInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserConsentVerifierInterop : IUserConsentVerifierInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserConsentVerifierInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, Guid*, void**, int> )(lpVtbl[0]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint> )(lpVtbl[1]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint> )(lpVtbl[2]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, HSTRING*, int> )(lpVtbl[4]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, TrustLevel*, int> )(lpVtbl[5]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IUserConsentVerifierInterop.xml' path='doc/member[@name="IUserConsentVerifierInterop.RequestVerificationForWindowAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestVerificationForWindowAsync(HWND appWindow, HSTRING message, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IUserConsentVerifierInterop*, HWND, HSTRING, Guid*, void**, int> )(lpVtbl[6]))((IUserConsentVerifierInterop*)Unsafe.AsPointer(ref this), appWindow, message, riid, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestVerificationForWindowAsync(HWND appWindow, HSTRING message, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);
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
        [NativeTypeName("HRESULT (HWND, HSTRING, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, HSTRING, Guid*, void**, int> RequestVerificationForWindowAsync;
    }
}