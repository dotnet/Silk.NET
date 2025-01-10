// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2AF2D06A-DD5B-4927-A0B4-54F19C91FADE")]
[NativeTypeName("struct ITfTextLayoutSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfTextLayoutSink : ITfTextLayoutSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfTextLayoutSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfTextLayoutSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfTextLayoutSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfTextLayoutSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnLayoutChange(ITfContext pic, TfLayoutCode lcode, ITfContextView pView)
    {
        return (
            (delegate* unmanaged<ITfTextLayoutSink, ITfContext, TfLayoutCode, ITfContextView, int>)(
                (*lpVtbl)[3]
            )
        )(this, pic, lcode, pView);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnLayoutChange(ITfContext pic, TfLayoutCode lcode, ITfContextView pView);
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
            "HRESULT (ITfContext *, TfLayoutCode, ITfContextView *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITfContext,
            TfLayoutCode,
            ITfContextView,
            int> OnLayoutChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfTextLayoutSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfTextLayoutSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfTextLayoutSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfTextLayoutSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfTextLayoutSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfTextLayoutSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfTextLayoutSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfTextLayoutSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
