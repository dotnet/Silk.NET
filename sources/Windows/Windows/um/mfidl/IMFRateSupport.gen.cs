// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFRateSupport.xml' path='doc/member[@name="IMFRateSupport"]/*'/>
[Guid("0A9CCDBC-D797-4563-9667-94EC5D79292D")]
[NativeTypeName("struct IMFRateSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRateSupport : IMFRateSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRateSupport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRateSupport*, Guid*, void**, int> )(lpVtbl[0]))((IMFRateSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRateSupport*, uint> )(lpVtbl[1]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRateSupport*, uint> )(lpVtbl[2]))((IMFRateSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRateSupport.xml' path='doc/member[@name="IMFRateSupport.GetSlowestRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSlowestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
    {
        return ((delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int> )(lpVtbl[3]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
    }

    /// <include file='IMFRateSupport.xml' path='doc/member[@name="IMFRateSupport.GetFastestRate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFastestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
    {
        return ((delegate* unmanaged<IMFRateSupport*, MFRATE_DIRECTION, BOOL, float*, int> )(lpVtbl[4]))((IMFRateSupport*)Unsafe.AsPointer(ref this), eDirection, fThin, pflRate);
    }

    /// <include file='IMFRateSupport.xml' path='doc/member[@name="IMFRateSupport.IsRateSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsRateSupported(BOOL fThin, float flRate, float* pflNearestSupportedRate)
    {
        return ((delegate* unmanaged<IMFRateSupport*, BOOL, float, float*, int> )(lpVtbl[5]))((IMFRateSupport*)Unsafe.AsPointer(ref this), fThin, flRate, pflNearestSupportedRate);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSlowestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate);
        [VtblIndex(4)]
        HRESULT GetFastestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate);
        [VtblIndex(5)]
        HRESULT IsRateSupported(BOOL fThin, float flRate, float* pflNearestSupportedRate);
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
        [NativeTypeName("HRESULT (MFRATE_DIRECTION, BOOL, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFRATE_DIRECTION, BOOL, float*, int> GetSlowestRate;
        [NativeTypeName("HRESULT (MFRATE_DIRECTION, BOOL, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFRATE_DIRECTION, BOOL, float*, int> GetFastestRate;
        [NativeTypeName("HRESULT (BOOL, float, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, float, float*, int> IsRateSupported;
    }
}