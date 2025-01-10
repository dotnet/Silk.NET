// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("86462810-593B-4916-9764-19C08E9CE110")]
[NativeTypeName("struct ITfContextOwnerCompositionServices : ITfContextComposition")]
[NativeInheritance("ITfContextComposition")]
public unsafe partial struct ITfContextOwnerCompositionServices
    : ITfContextOwnerCompositionServices.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextOwnerCompositionServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfContextOwnerCompositionServices, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionServices, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartComposition(
        [NativeTypeName("TfEditCookie")] uint ecWrite,
        ITfRange pCompositionRange,
        ITfCompositionSink pSink,
        ITfComposition* ppComposition
    )
    {
        return (
            (delegate* unmanaged<
                ITfContextOwnerCompositionServices,
                uint,
                ITfRange,
                ITfCompositionSink,
                ITfComposition*,
                int>)((*lpVtbl)[3])
        )(this, ecWrite, pCompositionRange, pSink, ppComposition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumCompositions(IEnumITfCompositionView* ppEnum)
    {
        return (
            (delegate* unmanaged<
                ITfContextOwnerCompositionServices,
                IEnumITfCompositionView*,
                int>)((*lpVtbl)[4])
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindComposition(
        [NativeTypeName("TfEditCookie")] uint ecRead,
        ITfRange pTestRange,
        IEnumITfCompositionView* ppEnum
    )
    {
        return (
            (delegate* unmanaged<
                ITfContextOwnerCompositionServices,
                uint,
                ITfRange,
                IEnumITfCompositionView*,
                int>)((*lpVtbl)[5])
        )(this, ecRead, pTestRange, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TakeOwnership(
        [NativeTypeName("TfEditCookie")] uint ecWrite,
        ITfCompositionView pComposition,
        ITfCompositionSink pSink,
        ITfComposition* ppComposition
    )
    {
        return (
            (delegate* unmanaged<
                ITfContextOwnerCompositionServices,
                uint,
                ITfCompositionView,
                ITfCompositionSink,
                ITfComposition*,
                int>)((*lpVtbl)[6])
        )(this, ecWrite, pComposition, pSink, ppComposition);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TerminateComposition(ITfCompositionView pComposition)
    {
        return (
            (delegate* unmanaged<ITfContextOwnerCompositionServices, ITfCompositionView, int>)(
                (*lpVtbl)[7]
            )
        )(this, pComposition);
    }

    public interface Interface : ITfContextComposition.Interface
    {
        [VtblIndex(7)]
        HRESULT TerminateComposition(ITfCompositionView pComposition);
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

        [NativeTypeName(
            "HRESULT (TfEditCookie, ITfRange *, ITfCompositionSink *, ITfComposition **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITfRange,
            ITfCompositionSink,
            ITfComposition*,
            int> StartComposition;

        [NativeTypeName("HRESULT (IEnumITfCompositionView **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumITfCompositionView*, int> EnumCompositions;

        [NativeTypeName(
            "HRESULT (TfEditCookie, ITfRange *, IEnumITfCompositionView **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITfRange,
            IEnumITfCompositionView*,
            int> FindComposition;

        [NativeTypeName(
            "HRESULT (TfEditCookie, ITfCompositionView *, ITfCompositionSink *, ITfComposition **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ITfCompositionView,
            ITfCompositionSink,
            ITfComposition*,
            int> TakeOwnership;

        [NativeTypeName("HRESULT (ITfCompositionView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompositionView, int> TerminateComposition;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfContextOwnerCompositionServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfContextOwnerCompositionServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfContextComposition"/> to <see cref = "ITfContextOwnerCompositionServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfContextComposition"/> instance to be converted </param>
    public static explicit operator ITfContextOwnerCompositionServices(
        Silk.NET.Windows.ITfContextComposition value
    )
    {
        return new ITfContextOwnerCompositionServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfContextOwnerCompositionServices"/> to <see cref = "Silk.NET.Windows.ITfContextComposition"/>.</summary>
    /// <param name = "value">The <see cref = "ITfContextOwnerCompositionServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfContextComposition(
        ITfContextOwnerCompositionServices value
    )
    {
        return new Silk.NET.Windows.ITfContextComposition(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfContextOwnerCompositionServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfContextOwnerCompositionServices(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITfContextOwnerCompositionServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfContextOwnerCompositionServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfContextOwnerCompositionServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITfContextOwnerCompositionServices value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
