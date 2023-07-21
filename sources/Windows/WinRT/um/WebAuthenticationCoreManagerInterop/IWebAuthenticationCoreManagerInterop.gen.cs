// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebAuthenticationCoreManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IWebAuthenticationCoreManagerInterop.xml' path='doc/member[@name="IWebAuthenticationCoreManagerInterop"]/*' />
[Guid("F4B8E804-811E-4436-B69C-44CB67B72084")]
[NativeTypeName("struct IWebAuthenticationCoreManagerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebAuthenticationCoreManagerInterop : IWebAuthenticationCoreManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebAuthenticationCoreManagerInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, Guid*, void**, int>)(lpVtbl[0]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[1]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint>)(lpVtbl[2]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HSTRING*, int>)(lpVtbl[4]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, TrustLevel*, int>)(lpVtbl[5]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IWebAuthenticationCoreManagerInterop.xml' path='doc/member[@name="IWebAuthenticationCoreManagerInterop.RequestTokenForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestTokenForWindowAsync(HWND appWindow, IInspectable* request, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HWND, IInspectable*, Guid*, void**, int>)(lpVtbl[6]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, riid, asyncInfo);
    }

    /// <include file='IWebAuthenticationCoreManagerInterop.xml' path='doc/member[@name="IWebAuthenticationCoreManagerInterop.RequestTokenWithWebAccountForWindowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestTokenWithWebAccountForWindowAsync(HWND appWindow, IInspectable* request, IInspectable* webAccount, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo)
    {
        return ((delegate* unmanaged<IWebAuthenticationCoreManagerInterop*, HWND, IInspectable*, IInspectable*, Guid*, void**, int>)(lpVtbl[7]))((IWebAuthenticationCoreManagerInterop*)Unsafe.AsPointer(ref this), appWindow, request, webAccount, riid, asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestTokenForWindowAsync(HWND appWindow, IInspectable* request, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo);

        [VtblIndex(7)]
        HRESULT RequestTokenWithWebAccountForWindowAsync(HWND appWindow, IInspectable* request, IInspectable* webAccount, [NativeTypeName("const IID &")] Guid* riid, void** asyncInfo);
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

        [NativeTypeName("HRESULT (HWND, IInspectable *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IInspectable*, Guid*, void**, int> RequestTokenForWindowAsync;

        [NativeTypeName("HRESULT (HWND, IInspectable *, IInspectable *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IInspectable*, IInspectable*, Guid*, void**, int> RequestTokenWithWebAccountForWindowAsync;
    }
}
