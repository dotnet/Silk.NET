// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IVMRMixerBitmap.xml' path='doc/member[@name="IVMRMixerBitmap"]/*' />
[Guid("1E673275-0257-40AA-AF20-7C608D4A0428")]
[NativeTypeName("struct IVMRMixerBitmap : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVMRMixerBitmap : IVMRMixerBitmap.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVMRMixerBitmap));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, Guid*, void**, int>)(lpVtbl[0]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, uint>)(lpVtbl[1]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, uint>)(lpVtbl[2]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVMRMixerBitmap.xml' path='doc/member[@name="IVMRMixerBitmap.SetAlphaBitmap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAlphaBitmap([NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms)
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[3]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
    }

    /// <include file='IVMRMixerBitmap.xml' path='doc/member[@name="IVMRMixerBitmap.UpdateAlphaBitmapParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UpdateAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[4]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
    }

    /// <include file='IVMRMixerBitmap.xml' path='doc/member[@name="IVMRMixerBitmap.GetAlphaBitmapParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms)
    {
        return ((delegate* unmanaged<IVMRMixerBitmap*, VMRALPHABITMAP*, int>)(lpVtbl[5]))((IVMRMixerBitmap*)Unsafe.AsPointer(ref this), pBmpParms);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAlphaBitmap([NativeTypeName("const VMRALPHABITMAP *")] VMRALPHABITMAP* pBmpParms);

        [VtblIndex(4)]
        HRESULT UpdateAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms);

        [VtblIndex(5)]
        HRESULT GetAlphaBitmapParameters([NativeTypeName("PVMRALPHABITMAP")] VMRALPHABITMAP* pBmpParms);
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

        [NativeTypeName("HRESULT (const VMRALPHABITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> SetAlphaBitmap;

        [NativeTypeName("HRESULT (PVMRALPHABITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> UpdateAlphaBitmapParameters;

        [NativeTypeName("HRESULT (PVMRALPHABITMAP) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VMRALPHABITMAP*, int> GetAlphaBitmapParameters;
    }
}
