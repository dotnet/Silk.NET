// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AB41D127-C101-4C0A-911D-F9F2E9D08E64")]
[NativeTypeName("struct ICompositionFramePresentStatistics : IPresentStatistics")]
[NativeInheritance("IPresentStatistics")]
public unsafe partial struct ICompositionFramePresentStatistics
    : ICompositionFramePresentStatistics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionFramePresentStatistics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionFramePresentStatistics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionFramePresentStatistics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionFramePresentStatistics, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT64")]
    public ulong GetPresentId()
    {
        return ((delegate* unmanaged<ICompositionFramePresentStatistics, ulong>)((*lpVtbl)[3]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public PresentStatisticsKind GetKind()
    {
        return (
            (delegate* unmanaged<ICompositionFramePresentStatistics, PresentStatisticsKind>)(
                (*lpVtbl)[4]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT_PTR")]
    public nuint GetContentTag()
    {
        return ((delegate* unmanaged<ICompositionFramePresentStatistics, nuint>)((*lpVtbl)[5]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("CompositionFrameId")]
    public ulong GetCompositionFrameId()
    {
        return ((delegate* unmanaged<ICompositionFramePresentStatistics, ulong>)((*lpVtbl)[6]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetDisplayInstanceArray(
        uint* displayInstanceArrayCount,
        [NativeTypeName("const CompositionFrameDisplayInstance **")]
            CompositionFrameDisplayInstance** displayInstanceArray
    )
    {
        (
            (delegate* unmanaged<
                ICompositionFramePresentStatistics,
                uint*,
                CompositionFrameDisplayInstance**,
                void>)((*lpVtbl)[7])
        )(this, displayInstanceArrayCount, displayInstanceArray);
    }

    public interface Interface : IPresentStatistics.Interface
    {
        [VtblIndex(5)]
        [return: NativeTypeName("UINT_PTR")]
        nuint GetContentTag();

        [VtblIndex(6)]
        [return: NativeTypeName("CompositionFrameId")]
        ulong GetCompositionFrameId();

        [VtblIndex(7)]
        void GetDisplayInstanceArray(
            uint* displayInstanceArrayCount,
            [NativeTypeName("const CompositionFrameDisplayInstance **")]
                CompositionFrameDisplayInstance** displayInstanceArray
        );
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

        [NativeTypeName("UINT_PTR () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint> GetContentTag;

        [NativeTypeName("CompositionFrameId () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetCompositionFrameId;

        [NativeTypeName(
            "void (UINT *, const CompositionFrameDisplayInstance **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint*,
            CompositionFrameDisplayInstance**,
            void> GetDisplayInstanceArray;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionFramePresentStatistics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionFramePresentStatistics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPresentStatistics"/> to <see cref = "ICompositionFramePresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPresentStatistics"/> instance to be converted </param>
    public static explicit operator ICompositionFramePresentStatistics(
        Silk.NET.Windows.IPresentStatistics value
    )
    {
        return new ICompositionFramePresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionFramePresentStatistics"/> to <see cref = "Silk.NET.Windows.IPresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionFramePresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPresentStatistics(
        ICompositionFramePresentStatistics value
    )
    {
        return new Silk.NET.Windows.IPresentStatistics(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionFramePresentStatistics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionFramePresentStatistics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICompositionFramePresentStatistics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionFramePresentStatistics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionFramePresentStatistics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICompositionFramePresentStatistics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
