// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISimpleFrameSite.xml' path='doc/member[@name="ISimpleFrameSite"]/*'/>
[Guid("742B0E01-14E6-101B-914E-00AA00300CAB")]
[NativeTypeName("struct ISimpleFrameSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISimpleFrameSite : ISimpleFrameSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISimpleFrameSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISimpleFrameSite*, Guid*, void**, int> )(lpVtbl[0]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISimpleFrameSite*, uint> )(lpVtbl[1]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISimpleFrameSite*, uint> )(lpVtbl[2]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISimpleFrameSite.xml' path='doc/member[@name="ISimpleFrameSite.PreMessageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT PreMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, LRESULT* plResult, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<ISimpleFrameSite*, HWND, uint, WPARAM, LPARAM, LRESULT*, uint*, int> )(lpVtbl[3]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, pdwCookie);
    }

    /// <include file='ISimpleFrameSite.xml' path='doc/member[@name="ISimpleFrameSite.PostMessageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PostMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, LRESULT* plResult, [NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ISimpleFrameSite*, HWND, uint, WPARAM, LPARAM, LRESULT*, uint, int> )(lpVtbl[4]))((ISimpleFrameSite*)Unsafe.AsPointer(ref this), hWnd, msg, wp, lp, plResult, dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT PreMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, LRESULT* plResult, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(4)]
        HRESULT PostMessageFilter(HWND hWnd, uint msg, WPARAM wp, LPARAM lp, LRESULT* plResult, [NativeTypeName("DWORD")] uint dwCookie);
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
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, LRESULT*, uint*, int> PreMessageFilter;
        [NativeTypeName("HRESULT (HWND, UINT, WPARAM, LPARAM, LRESULT *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, WPARAM, LPARAM, LRESULT*, uint, int> PostMessageFilter;
    }
}