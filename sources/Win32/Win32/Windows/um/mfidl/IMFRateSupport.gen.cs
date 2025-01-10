// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0A9CCDBC-D797-4563-9667-94EC5D79292D")]
[NativeTypeName("struct IMFRateSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRateSupport : IMFRateSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRateSupport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRateSupport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFRateSupport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRateSupport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSlowestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
    {
        return (
            (delegate* unmanaged<IMFRateSupport, MFRATE_DIRECTION, BOOL, float*, int>)((*lpVtbl)[3])
        )(this, eDirection, fThin, pflRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFastestRate(MFRATE_DIRECTION eDirection, BOOL fThin, float* pflRate)
    {
        return (
            (delegate* unmanaged<IMFRateSupport, MFRATE_DIRECTION, BOOL, float*, int>)((*lpVtbl)[4])
        )(this, eDirection, fThin, pflRate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsRateSupported(BOOL fThin, float flRate, float* pflNearestSupportedRate)
    {
        return ((delegate* unmanaged<IMFRateSupport, BOOL, float, float*, int>)((*lpVtbl)[5]))(
            this,
            fThin,
            flRate,
            pflNearestSupportedRate
        );
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

    /// <summary>Initializes a new instance of the <see cref = "IMFRateSupport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFRateSupport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFRateSupport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFRateSupport(Silk.NET.Windows.IUnknown value)
    {
        return new IMFRateSupport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFRateSupport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFRateSupport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFRateSupport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
