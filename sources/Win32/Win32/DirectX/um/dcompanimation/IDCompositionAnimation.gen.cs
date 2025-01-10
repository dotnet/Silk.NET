// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcompanimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("CBFD91D9-51B2-45E4-B3DE-D19CCFB863C5")]
[NativeTypeName("struct IDCompositionAnimation : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionAnimation : IDCompositionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDCompositionAnimation, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAbsoluteBeginTime(LARGE_INTEGER beginTime)
    {
        return ((delegate* unmanaged<IDCompositionAnimation, LARGE_INTEGER, int>)((*lpVtbl)[4]))(
            this,
            beginTime
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddCubic(
        double beginOffset,
        float constantCoefficient,
        float linearCoefficient,
        float quadraticCoefficient,
        float cubicCoefficient
    )
    {
        return (
            (delegate* unmanaged<IDCompositionAnimation, double, float, float, float, float, int>)(
                (*lpVtbl)[5]
            )
        )(
            this,
            beginOffset,
            constantCoefficient,
            linearCoefficient,
            quadraticCoefficient,
            cubicCoefficient
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddSinusoidal(
        double beginOffset,
        float bias,
        float amplitude,
        float frequency,
        float phase
    )
    {
        return (
            (delegate* unmanaged<IDCompositionAnimation, double, float, float, float, float, int>)(
                (*lpVtbl)[6]
            )
        )(this, beginOffset, bias, amplitude, frequency, phase);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddRepeat(double beginOffset, double durationToRepeat)
    {
        return ((delegate* unmanaged<IDCompositionAnimation, double, double, int>)((*lpVtbl)[7]))(
            this,
            beginOffset,
            durationToRepeat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT End(double endOffset, float endValue)
    {
        return ((delegate* unmanaged<IDCompositionAnimation, double, float, int>)((*lpVtbl)[8]))(
            this,
            endOffset,
            endValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reset();

        [VtblIndex(4)]
        HRESULT SetAbsoluteBeginTime(LARGE_INTEGER beginTime);

        [VtblIndex(5)]
        HRESULT AddCubic(
            double beginOffset,
            float constantCoefficient,
            float linearCoefficient,
            float quadraticCoefficient,
            float cubicCoefficient
        );

        [VtblIndex(6)]
        HRESULT AddSinusoidal(
            double beginOffset,
            float bias,
            float amplitude,
            float frequency,
            float phase
        );

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

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
