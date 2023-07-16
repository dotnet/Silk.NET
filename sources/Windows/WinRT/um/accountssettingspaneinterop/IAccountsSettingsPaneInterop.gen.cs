// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accountssettingspaneinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IAccountsSettingsPaneInterop.xml' path='doc/member[@name="IAccountsSettingsPaneInterop"]/*'/>
[Guid("D3EE12AD-3865-4362-9746-B75A682DF0E6")]
[NativeTypeName("struct IAccountsSettingsPaneInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAccountsSettingsPaneInterop : IAccountsSettingsPaneInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAccountsSettingsPaneInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, Guid*, void**, int> )(lpVtbl[0]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint> )(lpVtbl[1]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint> )(lpVtbl[2]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, HSTRING*, int> )(lpVtbl[4]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, TrustLevel*, int> )(lpVtbl[5]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAccountsSettingsPaneInterop.xml' path='doc/member[@name="IAccountsSettingsPaneInterop.GetForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** accountsSettingsPane)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, HWND, Guid*, void**, int> )(lpVtbl[6]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, accountsSettingsPane);
    }

    /// <include file='IAccountsSettingsPaneInterop.xml' path='doc/member[@name="IAccountsSettingsPaneInterop.ShowManageAccountsForWindowAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowManageAccountsForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, HWND, Guid*, void**, int> )(lpVtbl[7]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
    }

    /// <include file='IAccountsSettingsPaneInterop.xml' path='doc/member[@name="IAccountsSettingsPaneInterop.ShowAddAccountForWindowAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowAddAccountForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction)
    {
        return ((delegate* unmanaged<IAccountsSettingsPaneInterop*, HWND, Guid*, void**, int> )(lpVtbl[8]))((IAccountsSettingsPaneInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncAction);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** accountsSettingsPane);
        [VtblIndex(7)]
        HRESULT ShowManageAccountsForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction);
        [VtblIndex(8)]
        HRESULT ShowAddAccountForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncAction);
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
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> GetForWindow;
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> ShowManageAccountsForWindowAsync;
        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> ShowAddAccountForWindowAsync;
    }
}