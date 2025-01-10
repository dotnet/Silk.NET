// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("8339FDE3-106F-47AB-8373-1C6295EB10B3")]
[NativeTypeName("struct IDWriteInlineObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteInlineObject : IDWriteInlineObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteInlineObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteInlineObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteInlineObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteInlineObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(
        void* clientDrawingContext,
        IDWriteTextRenderer renderer,
        float originX,
        float originY,
        BOOL isSideways,
        BOOL isRightToLeft,
        IUnknown clientDrawingEffect
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteInlineObject,
                void*,
                IDWriteTextRenderer,
                float,
                float,
                BOOL,
                BOOL,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(
            this,
            clientDrawingContext,
            renderer,
            originX,
            originY,
            isSideways,
            isRightToLeft,
            clientDrawingEffect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetrics(DWRITE_INLINE_OBJECT_METRICS* metrics)
    {
        return (
            (delegate* unmanaged<IDWriteInlineObject, DWRITE_INLINE_OBJECT_METRICS*, int>)(
                (*lpVtbl)[4]
            )
        )(this, metrics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
    {
        return (
            (delegate* unmanaged<IDWriteInlineObject, DWRITE_OVERHANG_METRICS*, int>)((*lpVtbl)[5])
        )(this, overhangs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetBreakConditions(
        DWRITE_BREAK_CONDITION* breakConditionBefore,
        DWRITE_BREAK_CONDITION* breakConditionAfter
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteInlineObject,
                DWRITE_BREAK_CONDITION*,
                DWRITE_BREAK_CONDITION*,
                int>)((*lpVtbl)[6])
        )(this, breakConditionBefore, breakConditionAfter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(
            void* clientDrawingContext,
            IDWriteTextRenderer renderer,
            float originX,
            float originY,
            BOOL isSideways,
            BOOL isRightToLeft,
            IUnknown clientDrawingEffect
        );

        [VtblIndex(4)]
        HRESULT GetMetrics(DWRITE_INLINE_OBJECT_METRICS* metrics);

        [VtblIndex(5)]
        HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs);

        [VtblIndex(6)]
        HRESULT GetBreakConditions(
            DWRITE_BREAK_CONDITION* breakConditionBefore,
            DWRITE_BREAK_CONDITION* breakConditionAfter
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
            "HRESULT (void *, IDWriteTextRenderer *, FLOAT, FLOAT, BOOL, BOOL, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            void*,
            IDWriteTextRenderer,
            float,
            float,
            BOOL,
            BOOL,
            IUnknown,
            int> Draw;

        [NativeTypeName(
            "HRESULT (DWRITE_INLINE_OBJECT_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_INLINE_OBJECT_METRICS*, int> GetMetrics;

        [NativeTypeName(
            "HRESULT (DWRITE_OVERHANG_METRICS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_OVERHANG_METRICS*, int> GetOverhangMetrics;

        [NativeTypeName(
            "HRESULT (DWRITE_BREAK_CONDITION *, DWRITE_BREAK_CONDITION *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_BREAK_CONDITION*,
            DWRITE_BREAK_CONDITION*,
            int> GetBreakConditions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteInlineObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteInlineObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteInlineObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteInlineObject(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteInlineObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteInlineObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteInlineObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteInlineObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
