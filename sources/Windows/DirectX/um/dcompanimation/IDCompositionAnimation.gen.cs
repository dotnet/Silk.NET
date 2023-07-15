// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation"]/*'/>
[Guid("CBFD91D9-51B2-45E4-B3DE-D19CCFB863C5")]
[NativeTypeName("struct IDCompositionAnimation : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionAnimation : IDCompositionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAnimation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, uint> )(lpVtbl[1]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, uint> )(lpVtbl[2]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, int> )(lpVtbl[3]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.SetAbsoluteBeginTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAbsoluteBeginTime(LARGE_INTEGER beginTime)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, LARGE_INTEGER, int> )(lpVtbl[4]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginTime);
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.AddCubic"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, double, float, float, float, float, int> )(lpVtbl[5]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, constantCoefficient, linearCoefficient, quadraticCoefficient, cubicCoefficient);
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.AddSinusoidal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, double, float, float, float, float, int> )(lpVtbl[6]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, bias, amplitude, frequency, phase);
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.AddRepeat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddRepeat(double beginOffset, double durationToRepeat)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, double, double, int> )(lpVtbl[7]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), beginOffset, durationToRepeat);
    }

    /// <include file='IDCompositionAnimation.xml' path='doc/member[@name="IDCompositionAnimation.End"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT End(double endOffset, float endValue)
    {
        return ((delegate* unmanaged<IDCompositionAnimation*, double, float, int> )(lpVtbl[8]))((IDCompositionAnimation*)Unsafe.AsPointer(ref this), endOffset, endValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reset();
        [VtblIndex(4)]
        HRESULT SetAbsoluteBeginTime(LARGE_INTEGER beginTime);
        [VtblIndex(5)]
        HRESULT AddCubic(double beginOffset, float constantCoefficient, float linearCoefficient, float quadraticCoefficient, float cubicCoefficient);
        [VtblIndex(6)]
        HRESULT AddSinusoidal(double beginOffset, float bias, float amplitude, float frequency, float phase);
        [VtblIndex(7)]
        HRESULT AddRepeat(double beginOffset, double durationToRepeat);
        [VtblIndex(8)]
        HRESULT End(double endOffset, float endValue);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (LARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, int> SetAbsoluteBeginTime;
        [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, float, float, float, float, int> AddCubic;
        [NativeTypeName("HRESULT (double, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, float, float, float, float, int> AddSinusoidal;
        [NativeTypeName("HRESULT (double, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, double, int> AddRepeat;
        [NativeTypeName("HRESULT (double, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, float, int> End;
    }
}