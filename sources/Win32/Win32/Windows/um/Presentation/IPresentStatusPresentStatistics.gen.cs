// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C9ED2A41-79CB-435E-964E-C8553055420C")]
[NativeTypeName("struct IPresentStatusPresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct IPresentStatusPresentStatistics
    : IPresentStatusPresentStatistics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentStatusPresentStatistics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPresentStatusPresentStatistics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPresentStatusPresentStatistics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPresentStatusPresentStatistics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged<IPresentStatusPresentStatistics, ulong>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return (
            (delegate* unmanaged<IPresentStatusPresentStatistics, PresentStatisticsKind>)(
                (*lpVtbl)[4]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("CompositionFrameId")]
    public ulong GetCompositionFrameId()
    {
        return ((delegate* unmanaged<IPresentStatusPresentStatistics, ulong>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public PresentStatus GetPresentStatus()
    {
        return (
            (delegate* unmanaged<IPresentStatusPresentStatistics, PresentStatus>)((*lpVtbl)[6])
        )(this);
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        [return: NativeTypeName("CompositionFrameId")]
        ulong GetCompositionFrameId();

        [VtblIndex(6)]
        PresentStatus GetPresentStatus();
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

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetPresentId;

        [NativeTypeName("PresentStatisticsKind () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PresentStatisticsKind> GetKind;

        [NativeTypeName("CompositionFrameId () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetCompositionFrameId;

        [NativeTypeName("PresentStatus () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PresentStatus> GetPresentStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPresentStatusPresentStatistics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPresentStatusPresentStatistics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPresentStatistics"/> to <see cref = "IPresentStatusPresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPresentStatistics"/> instance to be converted </param>
    public static explicit operator IPresentStatusPresentStatistics(
        Silk.NET.Windows.IPresentStatistics value
    )
    {
        return new IPresentStatusPresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentStatusPresentStatistics"/> to <see cref = "Silk.NET.Windows.IPresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentStatusPresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPresentStatistics(
        IPresentStatusPresentStatistics value
    )
    {
        return new Silk.NET.Windows.IPresentStatistics(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPresentStatusPresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPresentStatusPresentStatistics(Silk.NET.Windows.IUnknown value)
    {
        return new IPresentStatusPresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentStatusPresentStatistics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentStatusPresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPresentStatusPresentStatistics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
