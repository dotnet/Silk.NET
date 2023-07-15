// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFrameworkInputPane.xml' path='doc/member[@name="IFrameworkInputPane"]/*'/>
[Guid("5752238B-24F0-495A-82F1-2FD593056796")]
[NativeTypeName("struct IFrameworkInputPane : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFrameworkInputPane : IFrameworkInputPane.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFrameworkInputPane));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, Guid*, void**, int> )(lpVtbl[0]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, uint> )(lpVtbl[1]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, uint> )(lpVtbl[2]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFrameworkInputPane.xml' path='doc/member[@name="IFrameworkInputPane.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(IUnknown* pWindow, IFrameworkInputPaneHandler* pHandler, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, IUnknown*, IFrameworkInputPaneHandler*, uint*, int> )(lpVtbl[3]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this), pWindow, pHandler, pdwCookie);
    }

    /// <include file='IFrameworkInputPane.xml' path='doc/member[@name="IFrameworkInputPane.AdviseWithHWND"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AdviseWithHWND(HWND hwnd, IFrameworkInputPaneHandler* pHandler, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, HWND, IFrameworkInputPaneHandler*, uint*, int> )(lpVtbl[4]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this), hwnd, pHandler, pdwCookie);
    }

    /// <include file='IFrameworkInputPane.xml' path='doc/member[@name="IFrameworkInputPane.Unadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, uint, int> )(lpVtbl[5]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='IFrameworkInputPane.xml' path='doc/member[@name="IFrameworkInputPane.Location"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Location(RECT* prcInputPaneScreenLocation)
    {
        return ((delegate* unmanaged<IFrameworkInputPane*, RECT*, int> )(lpVtbl[6]))((IFrameworkInputPane*)Unsafe.AsPointer(ref this), prcInputPaneScreenLocation);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(IUnknown* pWindow, IFrameworkInputPaneHandler* pHandler, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(4)]
        HRESULT AdviseWithHWND(HWND hwnd, IFrameworkInputPaneHandler* pHandler, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(5)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie);
        [VtblIndex(6)]
        HRESULT Location(RECT* prcInputPaneScreenLocation);
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
        [NativeTypeName("HRESULT (IUnknown *, IFrameworkInputPaneHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, IFrameworkInputPaneHandler*, uint*, int> Advise;
        [NativeTypeName("HRESULT (HWND, IFrameworkInputPaneHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IFrameworkInputPaneHandler*, uint*, int> AdviseWithHWND;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> Location;
    }
}