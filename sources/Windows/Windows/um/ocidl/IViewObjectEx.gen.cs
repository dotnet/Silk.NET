// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx"]/*'/>
[Guid("3AF24292-0C96-11CE-A0CF-00AA00600AB8")]
[NativeTypeName("struct IViewObjectEx : IViewObject2")]
[NativeInheritance("IViewObject2")]
public unsafe partial struct IViewObjectEx : IViewObjectEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewObjectEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IViewObjectEx*, Guid*, void**, int> )(lpVtbl[0]))((IViewObjectEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint> )(lpVtbl[1]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint> )(lpVtbl[2]))((IViewObjectEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IViewObject.Draw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hdcTargetDev, HDC hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* unmanaged<nuint, BOOL> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, HDC, HDC, RECTL*, RECTL*, delegate* unmanaged<nuint, BOOL> , nuint, int> )(lpVtbl[3]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
    }

    /// <inheritdoc cref = "IViewObject.GetColorSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hicTargetDev, LOGPALETTE** ppColorSet)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, DVTARGETDEVICE*, HDC, LOGPALETTE**, int> )(lpVtbl[4]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
    }

    /// <inheritdoc cref = "IViewObject.Freeze"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int, void*, uint*, int> )(lpVtbl[5]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
    }

    /// <inheritdoc cref = "IViewObject.Unfreeze"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int> )(lpVtbl[6]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwFreeze);
    }

    /// <inheritdoc cref = "IViewObject.SetAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, uint, IAdviseSink*, int> )(lpVtbl[7]))((IViewObjectEx*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
    }

    /// <inheritdoc cref = "IViewObject.GetAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, IAdviseSink** ppAdvSink)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint*, uint*, IAdviseSink**, int> )(lpVtbl[8]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
    }

    /// <inheritdoc cref = "IViewObject2.GetExtent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int, DVTARGETDEVICE*, SIZE*, int> )(lpVtbl[9]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, ptd, lpsizel);
    }

    /// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx.GetRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPRECTL")] RECTL* pRect)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, RECTL*, int> )(lpVtbl[10]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRect);
    }

    /// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx.GetViewStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetViewStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint*, int> )(lpVtbl[11]))((IViewObjectEx*)Unsafe.AsPointer(ref this), pdwStatus);
    }

    /// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx.QueryHitPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryHitPoint([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, POINT ptlLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, RECT*, POINT, int, uint*, int> )(lpVtbl[12]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, ptlLoc, lCloseHint, pHitResult);
    }

    /// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx.QueryHitRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT QueryHitRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LPCRECT")] RECT* pRectLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, RECT*, RECT*, int, uint*, int> )(lpVtbl[13]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, pRectBounds, pRectLoc, lCloseHint, pHitResult);
    }

    /// <include file='IViewObjectEx.xml' path='doc/member[@name="IViewObjectEx.GetNaturalExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNaturalExtent([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, HDC hicTargetDev, DVEXTENTINFO* pExtentInfo, [NativeTypeName("LPSIZEL")] SIZE* pSizel)
    {
        return ((delegate* unmanaged<IViewObjectEx*, uint, int, DVTARGETDEVICE*, HDC, DVEXTENTINFO*, SIZE*, int> )(lpVtbl[14]))((IViewObjectEx*)Unsafe.AsPointer(ref this), dwAspect, lindex, ptd, hicTargetDev, pExtentInfo, pSizel);
    }

    public interface Interface : IViewObject2.Interface
    {
        [VtblIndex(10)]
        HRESULT GetRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPRECTL")] RECTL* pRect);
        [VtblIndex(11)]
        HRESULT GetViewStatus([NativeTypeName("DWORD *")] uint* pdwStatus);
        [VtblIndex(12)]
        HRESULT QueryHitPoint([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, POINT ptlLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult);
        [VtblIndex(13)]
        HRESULT QueryHitRect([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LPCRECT")] RECT* pRectBounds, [NativeTypeName("LPCRECT")] RECT* pRectLoc, [NativeTypeName("LONG")] int lCloseHint, [NativeTypeName("DWORD *")] uint* pHitResult);
        [VtblIndex(14)]
        HRESULT GetNaturalExtent([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, HDC hicTargetDev, DVEXTENTINFO* pExtentInfo, [NativeTypeName("LPSIZEL")] SIZE* pSizel);
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
        [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, HDC, LPCRECTL, LPCRECTL, BOOL (*)(ULONG_PTR) __attribute__((stdcall)), ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void*, DVTARGETDEVICE*, HDC, HDC, RECTL*, RECTL*, delegate* unmanaged<nuint, BOOL> , nuint, int> Draw;
        [NativeTypeName("HRESULT (DWORD, LONG, void *, DVTARGETDEVICE *, HDC, LOGPALETTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void*, DVTARGETDEVICE*, HDC, LOGPALETTE**, int> GetColorSet;
        [NativeTypeName("HRESULT (DWORD, LONG, void *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void*, uint*, int> Freeze;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unfreeze;
        [NativeTypeName("HRESULT (DWORD, DWORD, IAdviseSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, IAdviseSink*, int> SetAdvise;
        [NativeTypeName("HRESULT (DWORD *, DWORD *, IAdviseSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, IAdviseSink**, int> GetAdvise;
        [NativeTypeName("HRESULT (DWORD, LONG, DVTARGETDEVICE *, LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, DVTARGETDEVICE*, SIZE*, int> GetExtent;
        [NativeTypeName("HRESULT (DWORD, LPRECTL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECTL*, int> GetRect;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetViewStatus;
        [NativeTypeName("HRESULT (DWORD, LPCRECT, POINT, LONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, POINT, int, uint*, int> QueryHitPoint;
        [NativeTypeName("HRESULT (DWORD, LPCRECT, LPCRECT, LONG, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, RECT*, RECT*, int, uint*, int> QueryHitRect;
        [NativeTypeName("HRESULT (DWORD, LONG, DVTARGETDEVICE *, HDC, DVEXTENTINFO *, LPSIZEL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, DVTARGETDEVICE*, HDC, DVEXTENTINFO*, SIZE*, int> GetNaturalExtent;
    }
}