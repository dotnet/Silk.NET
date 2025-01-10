// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5F20AA40-B57A-4F34-96AB-3576F377CC79")]
[NativeTypeName("struct ITfContextOwnerCompositionSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfContextOwnerCompositionSink
    : ITfContextOwnerCompositionSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfContextOwnerCompositionSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfContextOwnerCompositionSink, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfContextOwnerCompositionSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnStartComposition(ITfCompositionView pComposition, BOOL* pfOk)
    {
        return (
            (delegate* unmanaged<ITfContextOwnerCompositionSink, ITfCompositionView, BOOL*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pComposition, pfOk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnUpdateComposition(ITfCompositionView pComposition, ITfRange pRangeNew)
    {
        return (
            (delegate* unmanaged<
                ITfContextOwnerCompositionSink,
                ITfCompositionView,
                ITfRange,
                int>)((*lpVtbl)[4])
        )(this, pComposition, pRangeNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnEndComposition(ITfCompositionView pComposition)
    {
        return (
            (delegate* unmanaged<ITfContextOwnerCompositionSink, ITfCompositionView, int>)(
                (*lpVtbl)[5]
            )
        )(this, pComposition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnStartComposition(ITfCompositionView pComposition, BOOL* pfOk);

        [VtblIndex(4)]
        HRESULT OnUpdateComposition(ITfCompositionView pComposition, ITfRange pRangeNew);

        [VtblIndex(5)]
        HRESULT OnEndComposition(ITfCompositionView pComposition);
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

        [NativeTypeName("HRESULT (ITfCompositionView *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompositionView, BOOL*, int> OnStartComposition;

        [NativeTypeName("HRESULT (ITfCompositionView *, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompositionView, ITfRange, int> OnUpdateComposition;

        [NativeTypeName("HRESULT (ITfCompositionView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfCompositionView, int> OnEndComposition;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfContextOwnerCompositionSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfContextOwnerCompositionSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfContextOwnerCompositionSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfContextOwnerCompositionSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfContextOwnerCompositionSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfContextOwnerCompositionSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfContextOwnerCompositionSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfContextOwnerCompositionSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
