// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IViewObject2.xml' path='doc/member[@name="IViewObject2"]/*'/>
[Guid("00000127-0000-0000-C000-000000000046")]
[NativeTypeName("struct IViewObject2 : IViewObject")]
[NativeInheritance("IViewObject")]
public unsafe partial struct IViewObject2 : IViewObject2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IViewObject2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IViewObject2*, Guid*, void**, int> )(lpVtbl[0]))((IViewObject2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IViewObject2*, uint> )(lpVtbl[1]))((IViewObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IViewObject2*, uint> )(lpVtbl[2]))((IViewObject2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IViewObject.Draw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hdcTargetDev, HDC hdcDraw, [NativeTypeName("LPCRECTL")] RECTL* lprcBounds, [NativeTypeName("LPCRECTL")] RECTL* lprcWBounds, [NativeTypeName("BOOL (*)(ULONG_PTR) __attribute__((stdcall))")] delegate* unmanaged<nuint, BOOL> pfnContinue, [NativeTypeName("ULONG_PTR")] nuint dwContinue)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, int, void*, DVTARGETDEVICE*, HDC, HDC, RECTL*, RECTL*, delegate* unmanaged<nuint, BOOL> , nuint, int> )(lpVtbl[3]))((IViewObject2*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hdcTargetDev, hdcDraw, lprcBounds, lprcWBounds, pfnContinue, dwContinue);
    }

    /// <inheritdoc cref = "IViewObject.GetColorSet"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetColorSet([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, DVTARGETDEVICE* ptd, HDC hicTargetDev, LOGPALETTE** ppColorSet)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, int, void*, DVTARGETDEVICE*, HDC, LOGPALETTE**, int> )(lpVtbl[4]))((IViewObject2*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, ptd, hicTargetDev, ppColorSet);
    }

    /// <inheritdoc cref = "IViewObject.Freeze"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Freeze([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, void* pvAspect, [NativeTypeName("DWORD *")] uint* pdwFreeze)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, int, void*, uint*, int> )(lpVtbl[5]))((IViewObject2*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, pvAspect, pdwFreeze);
    }

    /// <inheritdoc cref = "IViewObject.Unfreeze"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Unfreeze([NativeTypeName("DWORD")] uint dwFreeze)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, int> )(lpVtbl[6]))((IViewObject2*)Unsafe.AsPointer(ref this), dwFreeze);
    }

    /// <inheritdoc cref = "IViewObject.SetAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAdvise([NativeTypeName("DWORD")] uint aspects, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvSink)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, uint, IAdviseSink*, int> )(lpVtbl[7]))((IViewObject2*)Unsafe.AsPointer(ref this), aspects, advf, pAdvSink);
    }

    /// <inheritdoc cref = "IViewObject.GetAdvise"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAdvise([NativeTypeName("DWORD *")] uint* pAspects, [NativeTypeName("DWORD *")] uint* pAdvf, IAdviseSink** ppAdvSink)
    {
        return ((delegate* unmanaged<IViewObject2*, uint*, uint*, IAdviseSink**, int> )(lpVtbl[8]))((IViewObject2*)Unsafe.AsPointer(ref this), pAspects, pAdvf, ppAdvSink);
    }

    /// <include file='IViewObject2.xml' path='doc/member[@name="IViewObject2.GetExtent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel)
    {
        return ((delegate* unmanaged<IViewObject2*, uint, int, DVTARGETDEVICE*, SIZE*, int> )(lpVtbl[9]))((IViewObject2*)Unsafe.AsPointer(ref this), dwDrawAspect, lindex, ptd, lpsizel);
    }

    public interface Interface : IViewObject.Interface
    {
        [VtblIndex(9)]
        HRESULT GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("LONG")] int lindex, DVTARGETDEVICE* ptd, [NativeTypeName("LPSIZEL")] SIZE* lpsizel);
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
    }
}