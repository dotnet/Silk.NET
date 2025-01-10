// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("60D32930-13DA-11D3-9EC6-C4FCAEF5C7BE")]
[NativeTypeName("struct IAMVideoDecimationProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMVideoDecimationProperties
    : IAMVideoDecimationProperties.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMVideoDecimationProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAMVideoDecimationProperties, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMVideoDecimationProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMVideoDecimationProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryDecimationUsage(DECIMATION_USAGE* lpUsage)
    {
        return (
            (delegate* unmanaged<IAMVideoDecimationProperties, DECIMATION_USAGE*, int>)(
                (*lpVtbl)[3]
            )
        )(this, lpUsage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDecimationUsage(DECIMATION_USAGE Usage)
    {
        return (
            (delegate* unmanaged<IAMVideoDecimationProperties, DECIMATION_USAGE, int>)((*lpVtbl)[4])
        )(this, Usage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryDecimationUsage(DECIMATION_USAGE* lpUsage);

        [VtblIndex(4)]
        HRESULT SetDecimationUsage(DECIMATION_USAGE Usage);
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

        [NativeTypeName("HRESULT (DECIMATION_USAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DECIMATION_USAGE*, int> QueryDecimationUsage;

        [NativeTypeName("HRESULT (DECIMATION_USAGE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DECIMATION_USAGE, int> SetDecimationUsage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMVideoDecimationProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMVideoDecimationProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMVideoDecimationProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMVideoDecimationProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IAMVideoDecimationProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMVideoDecimationProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMVideoDecimationProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMVideoDecimationProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
