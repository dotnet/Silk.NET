// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A615096F-1C57-4813-8A15-55EE6E5A839C")]
[NativeTypeName("struct ITfTransitoryExtensionSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfTransitoryExtensionSink
    : ITfTransitoryExtensionSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfTransitoryExtensionSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfTransitoryExtensionSink, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfTransitoryExtensionSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnTransitoryExtensionUpdated(
        ITfContext pic,
        [NativeTypeName("TfEditCookie")] uint ecReadOnly,
        ITfRange pResultRange,
        ITfRange pCompositionRange,
        BOOL* pfDeleteResultRange
    )
    {
        return (
            (delegate* unmanaged<
                ITfTransitoryExtensionSink,
                ITfContext,
                uint,
                ITfRange,
                ITfRange,
                BOOL*,
                int>)((*lpVtbl)[3])
        )(this, pic, ecReadOnly, pResultRange, pCompositionRange, pfDeleteResultRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnTransitoryExtensionUpdated(
            ITfContext pic,
            [NativeTypeName("TfEditCookie")] uint ecReadOnly,
            ITfRange pResultRange,
            ITfRange pCompositionRange,
            BOOL* pfDeleteResultRange
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

        [NativeTypeName(
            "HRESULT (ITfContext *, TfEditCookie, ITfRange *, ITfRange *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITfContext,
            uint,
            ITfRange,
            ITfRange,
            BOOL*,
            int> OnTransitoryExtensionUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfTransitoryExtensionSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfTransitoryExtensionSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfTransitoryExtensionSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfTransitoryExtensionSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfTransitoryExtensionSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfTransitoryExtensionSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfTransitoryExtensionSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfTransitoryExtensionSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
