// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.DirectX;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVMRImagePresenterExclModeConfig.xml' path='doc/member[@name="IVMRImagePresenterExclModeConfig"]/*' />
[Guid("E6F7CE40-4673-44F1-8F77-5499D68CB4EA")]
[NativeTypeName("struct IVMRImagePresenterExclModeConfig : IVMRImagePresenterConfig")]
[NativeInheritance("IVMRImagePresenterConfig")]
public unsafe partial struct IVMRImagePresenterExclModeConfig : IVMRImagePresenterExclModeConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRImagePresenterExclModeConfig));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, Guid*, void**, int>)(lpVtbl[0]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint>)(lpVtbl[1]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint>)(lpVtbl[2]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IVMRImagePresenterConfig.SetRenderingPrefs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetRenderingPrefs([NativeTypeName("DWORD")] uint dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint, int>)(lpVtbl[3]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
    }

    /// <inheritdoc cref="IVMRImagePresenterConfig.GetRenderingPrefs" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRenderingPrefs([NativeTypeName("DWORD *")] uint* dwRenderFlags)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, uint*, int>)(lpVtbl[4]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), dwRenderFlags);
    }

    /// <include file='IVMRImagePresenterExclModeConfig.xml' path='doc/member[@name="IVMRImagePresenterExclModeConfig.SetXlcModeDDObjAndPrimarySurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpPrimarySurf)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, IDirectDraw7*, IDirectDrawSurface7*, int>)(lpVtbl[5]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), lpDDObj, lpPrimarySurf);
    }

    /// <include file='IVMRImagePresenterExclModeConfig.xml' path='doc/member[@name="IVMRImagePresenterExclModeConfig.GetXlcModeDDObjAndPrimarySurface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7 *")] IDirectDraw7** lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lpPrimarySurf)
    {
        return ((delegate* unmanaged<IVMRImagePresenterExclModeConfig*, IDirectDraw7**, IDirectDrawSurface7**, int>)(lpVtbl[6]))((IVMRImagePresenterExclModeConfig*)Unsafe.AsPointer(ref this), lpDDObj, lpPrimarySurf);
    }

    public interface Interface : IVMRImagePresenterConfig.Interface
    {
        [VtblIndex(5)]
        HRESULT SetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7")] IDirectDraw7* lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7")] IDirectDrawSurface7* lpPrimarySurf);

        [VtblIndex(6)]
        HRESULT GetXlcModeDDObjAndPrimarySurface([NativeTypeName("LPDIRECTDRAW7 *")] IDirectDraw7** lpDDObj, [NativeTypeName("LPDIRECTDRAWSURFACE7 *")] IDirectDrawSurface7** lpPrimarySurf);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetRenderingPrefs;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetRenderingPrefs;

        [NativeTypeName("HRESULT (LPDIRECTDRAW7, LPDIRECTDRAWSURFACE7) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw7*, IDirectDrawSurface7*, int> SetXlcModeDDObjAndPrimarySurface;

        [NativeTypeName("HRESULT (LPDIRECTDRAW7 *, LPDIRECTDRAWSURFACE7 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw7**, IDirectDrawSurface7**, int> GetXlcModeDDObjAndPrimarySurface;
    }
}
