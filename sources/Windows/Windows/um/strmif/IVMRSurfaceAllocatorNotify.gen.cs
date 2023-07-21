// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify"]/*' />
[Guid("AADA05A8-5A4E-4729-AF0B-CEA27AED51E2")]
[NativeTypeName("struct IVMRSurfaceAllocatorNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRSurfaceAllocatorNotify : IVMRSurfaceAllocatorNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRSurfaceAllocatorNotify));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, Guid*, void**, int>)(lpVtbl[0]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, uint>)(lpVtbl[1]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, uint>)(lpVtbl[2]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.AdviseSurfaceAllocator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseSurfaceAllocator([NativeTypeName("DWORD_PTR")] nuint dwUserID, IVMRSurfaceAllocator* lpIVRMSurfaceAllocator)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, nuint, IVMRSurfaceAllocator*, int>)(lpVtbl[3]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), dwUserID, lpIVRMSurfaceAllocator);
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.SetDDrawDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, HMONITOR hMonitor)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, IDirectDraw7*, HMONITOR, int>)(lpVtbl[4]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), lpDDrawDevice, hMonitor);
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.ChangeDDrawDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ChangeDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, HMONITOR hMonitor)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, IDirectDraw7*, HMONITOR, int>)(lpVtbl[5]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), lpDDrawDevice, hMonitor);
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.RestoreDDrawSurfaces"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RestoreDDrawSurfaces()
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, int>)(lpVtbl[6]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.NotifyEvent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NotifyEvent([NativeTypeName("LONG")] int EventCode, [NativeTypeName("LONG_PTR")] nint Param1, [NativeTypeName("LONG_PTR")] nint Param2)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, int, nint, nint, int>)(lpVtbl[7]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), EventCode, Param1, Param2);
    }

    /// <include file='IVMRSurfaceAllocatorNotify.xml' path='doc/member[@name="IVMRSurfaceAllocatorNotify.SetBorderColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetBorderColor(COLORREF clrBorder)
    {
        return ((delegate* unmanaged<IVMRSurfaceAllocatorNotify*, COLORREF, int>)(lpVtbl[8]))((IVMRSurfaceAllocatorNotify*)Unsafe.AsPointer(ref this), clrBorder);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseSurfaceAllocator([NativeTypeName("DWORD_PTR")] nuint dwUserID, IVMRSurfaceAllocator* lpIVRMSurfaceAllocator);

        [VtblIndex(4)]
        HRESULT SetDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, HMONITOR hMonitor);

        [VtblIndex(5)]
        HRESULT ChangeDDrawDevice([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDrawDevice, HMONITOR hMonitor);

        [VtblIndex(6)]
        HRESULT RestoreDDrawSurfaces();

        [VtblIndex(7)]
        HRESULT NotifyEvent([NativeTypeName("LONG")] int EventCode, [NativeTypeName("LONG_PTR")] nint Param1, [NativeTypeName("LONG_PTR")] nint Param2);

        [VtblIndex(8)]
        HRESULT SetBorderColor(COLORREF clrBorder);
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

        [NativeTypeName("HRESULT (DWORD_PTR, IVMRSurfaceAllocator *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, IVMRSurfaceAllocator*, int> AdviseSurfaceAllocator;

        [NativeTypeName("HRESULT (LPDIRECTDRAW7, HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw7*, HMONITOR, int> SetDDrawDevice;

        [NativeTypeName("HRESULT (LPDIRECTDRAW7, HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw7*, HMONITOR, int> ChangeDDrawDevice;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestoreDDrawSurfaces;

        [NativeTypeName("HRESULT (LONG, LONG_PTR, LONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, nint, nint, int> NotifyEvent;

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBorderColor;
    }
}
