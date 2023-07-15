// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl"]/*'/>
[Guid("1C1A17B0-BED0-415D-974B-DC6696131599")]
[NativeTypeName("struct IVMRMixerControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRMixerControl : IVMRMixerControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRMixerControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, Guid*, void**, int> )(lpVtbl[0]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint> )(lpVtbl[1]))((IVMRMixerControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint> )(lpVtbl[2]))((IVMRMixerControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.SetAlpha"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAlpha([NativeTypeName("DWORD")] uint dwStreamID, float Alpha)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, float, int> )(lpVtbl[3]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, Alpha);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.GetAlpha"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAlpha([NativeTypeName("DWORD")] uint dwStreamID, float* pAlpha)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, float*, int> )(lpVtbl[4]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pAlpha);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.SetZOrder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD")] uint dwZ)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, uint, int> )(lpVtbl[5]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, dwZ);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.GetZOrder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD *")] uint* pZ)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, uint*, int> )(lpVtbl[6]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pZ);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.SetOutputRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const NORMALIZEDRECT *")] NORMALIZEDRECT* pRect)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, NORMALIZEDRECT*, int> )(lpVtbl[7]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pRect);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.GetOutputRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, NORMALIZEDRECT* pRect)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, NORMALIZEDRECT*, int> )(lpVtbl[8]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwStreamID, pRect);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.SetBackgroundClr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetBackgroundClr(COLORREF ClrBkg)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, COLORREF, int> )(lpVtbl[9]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), ClrBkg);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.GetBackgroundClr"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetBackgroundClr(COLORREF* lpClrBkg)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, COLORREF*, int> )(lpVtbl[10]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), lpClrBkg);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.SetMixingPrefs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetMixingPrefs([NativeTypeName("DWORD")] uint dwMixerPrefs)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint, int> )(lpVtbl[11]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), dwMixerPrefs);
    }

    /// <include file='IVMRMixerControl.xml' path='doc/member[@name="IVMRMixerControl.GetMixingPrefs"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMixingPrefs([NativeTypeName("DWORD *")] uint* pdwMixerPrefs)
    {
        return ((delegate* unmanaged<IVMRMixerControl*, uint*, int> )(lpVtbl[12]))((IVMRMixerControl*)Unsafe.AsPointer(ref this), pdwMixerPrefs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAlpha([NativeTypeName("DWORD")] uint dwStreamID, float Alpha);
        [VtblIndex(4)]
        HRESULT GetAlpha([NativeTypeName("DWORD")] uint dwStreamID, float* pAlpha);
        [VtblIndex(5)]
        HRESULT SetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD")] uint dwZ);
        [VtblIndex(6)]
        HRESULT GetZOrder([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("DWORD *")] uint* pZ);
        [VtblIndex(7)]
        HRESULT SetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, [NativeTypeName("const NORMALIZEDRECT *")] NORMALIZEDRECT* pRect);
        [VtblIndex(8)]
        HRESULT GetOutputRect([NativeTypeName("DWORD")] uint dwStreamID, NORMALIZEDRECT* pRect);
        [VtblIndex(9)]
        HRESULT SetBackgroundClr(COLORREF ClrBkg);
        [VtblIndex(10)]
        HRESULT GetBackgroundClr(COLORREF* lpClrBkg);
        [VtblIndex(11)]
        HRESULT SetMixingPrefs([NativeTypeName("DWORD")] uint dwMixerPrefs);
        [VtblIndex(12)]
        HRESULT GetMixingPrefs([NativeTypeName("DWORD *")] uint* pdwMixerPrefs);
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
        [NativeTypeName("HRESULT (DWORD, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, int> SetAlpha;
        [NativeTypeName("HRESULT (DWORD, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetAlpha;
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetZOrder;
        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetZOrder;
        [NativeTypeName("HRESULT (DWORD, const NORMALIZEDRECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, NORMALIZEDRECT*, int> SetOutputRect;
        [NativeTypeName("HRESULT (DWORD, NORMALIZEDRECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, NORMALIZEDRECT*, int> GetOutputRect;
        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBackgroundClr;
        [NativeTypeName("HRESULT (COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF*, int> GetBackgroundClr;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMixingPrefs;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMixingPrefs;
    }
}