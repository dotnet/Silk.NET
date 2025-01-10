// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8C93BE27-AD94-4DA0-8FD4-2413132D124E")]
[NativeTypeName("struct IIndependentFlipFramePresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct IIndependentFlipFramePresentStatistics
    : IIndependentFlipFramePresentStatistics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIndependentFlipFramePresentStatistics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IIndependentFlipFramePresentStatistics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIndependentFlipFramePresentStatistics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIndependentFlipFramePresentStatistics, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged<IIndependentFlipFramePresentStatistics, ulong>)((*lpVtbl)[3]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return (
            (delegate* unmanaged<IIndependentFlipFramePresentStatistics, PresentStatisticsKind>)(
                (*lpVtbl)[4]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public LUID GetOutputAdapterLUID()
    {
        LUID result;
        return *(
            (delegate* unmanaged<IIndependentFlipFramePresentStatistics, LUID*, LUID*>)(
                (*lpVtbl)[5]
            )
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public uint GetOutputVidPnSourceId()
    {
        return ((delegate* unmanaged<IIndependentFlipFramePresentStatistics, uint>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT_PTR")]
    public nuint GetContentTag()
    {
        return ((delegate* unmanaged<IIndependentFlipFramePresentStatistics, nuint>)((*lpVtbl)[7]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public SystemInterruptTime GetDisplayedTime()
    {
        SystemInterruptTime result;
        return *(
            (delegate* unmanaged<
                IIndependentFlipFramePresentStatistics,
                SystemInterruptTime*,
                SystemInterruptTime*>)((*lpVtbl)[8])
        )(this, &result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public SystemInterruptTime GetPresentDuration()
    {
        SystemInterruptTime result;
        return *(
            (delegate* unmanaged<
                IIndependentFlipFramePresentStatistics,
                SystemInterruptTime*,
                SystemInterruptTime*>)((*lpVtbl)[9])
        )(this, &result);
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        LUID GetOutputAdapterLUID();

        [VtblIndex(6)]
        uint GetOutputVidPnSourceId();

        [VtblIndex(7)]
        [return: NativeTypeName("UINT_PTR")]
        nuint GetContentTag();

        [VtblIndex(8)]
        SystemInterruptTime GetDisplayedTime();

        [VtblIndex(9)]
        SystemInterruptTime GetPresentDuration();
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

        [NativeTypeName("LUID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LUID*, LUID*> GetOutputAdapterLUID;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetOutputVidPnSourceId;

        [NativeTypeName("UINT_PTR () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetContentTag;

        [NativeTypeName("SystemInterruptTime () __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            SystemInterruptTime*,
            SystemInterruptTime*> GetDisplayedTime;

        [NativeTypeName("SystemInterruptTime () __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            SystemInterruptTime*,
            SystemInterruptTime*> GetPresentDuration;
    }

    /// <summary>Initializes a new instance of the <see cref = "IIndependentFlipFramePresentStatistics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IIndependentFlipFramePresentStatistics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPresentStatistics"/> to <see cref = "IIndependentFlipFramePresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPresentStatistics"/> instance to be converted </param>
    public static explicit operator IIndependentFlipFramePresentStatistics(
        Silk.NET.Windows.IPresentStatistics value
    )
    {
        return new IIndependentFlipFramePresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIndependentFlipFramePresentStatistics"/> to <see cref = "Silk.NET.Windows.IPresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "IIndependentFlipFramePresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPresentStatistics(
        IIndependentFlipFramePresentStatistics value
    )
    {
        return new Silk.NET.Windows.IPresentStatistics(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IIndependentFlipFramePresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IIndependentFlipFramePresentStatistics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IIndependentFlipFramePresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IIndependentFlipFramePresentStatistics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IIndependentFlipFramePresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IIndependentFlipFramePresentStatistics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
