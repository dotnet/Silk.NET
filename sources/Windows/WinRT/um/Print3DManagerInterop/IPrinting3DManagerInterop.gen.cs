// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Print3DManagerInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='IPrinting3DManagerInterop.xml' path='doc/member[@name="IPrinting3DManagerInterop"]/*'/>
[Guid("9CA31010-1484-4587-B26B-DDDF9F9CAECD")]
[NativeTypeName("struct IPrinting3DManagerInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrinting3DManagerInterop : IPrinting3DManagerInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrinting3DManagerInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, Guid*, void**, int> )(lpVtbl[0]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint> )(lpVtbl[1]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint> )(lpVtbl[2]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInspectable.GetIids"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, uint*, Guid**, int> )(lpVtbl[3]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref = "IInspectable.GetRuntimeClassName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, HSTRING*, int> )(lpVtbl[4]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref = "IInspectable.GetTrustLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, TrustLevel*, int> )(lpVtbl[5]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrinting3DManagerInterop.xml' path='doc/member[@name="IPrinting3DManagerInterop.GetForWindow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** printManager)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, HWND, Guid*, void**, int> )(lpVtbl[6]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, printManager);
    }

    /// <include file='IPrinting3DManagerInterop.xml' path='doc/member[@name="IPrinting3DManagerInterop.ShowPrintUIForWindowAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ShowPrintUIForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation)
    {
        return ((delegate* unmanaged<IPrinting3DManagerInterop*, HWND, Guid*, void**, int> )(lpVtbl[7]))((IPrinting3DManagerInterop*)Unsafe.AsPointer(ref this), appWindow, riid, asyncOperation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetForWindow(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** printManager);
        [VtblIndex(7)]
        HRESULT ShowPrintUIForWindowAsync(HWND appWindow, [NativeTypeName("const IID &")] Guid* riid, void** asyncOperation);
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
        public delegate* unmanaged<TSelf*, HWND, Guid*, void**, int> ShowPrintUIForWindowAsync;
    }
}