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

[Guid("5810CD44-0CA0-4701-B3FA-BEC5182AE4F6")]
[NativeTypeName("struct IDWriteTextAnalysisSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteTextAnalysisSink
    : IDWriteTextAnalysisSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteTextAnalysisSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetScriptAnalysis(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")] DWRITE_SCRIPT_ANALYSIS* scriptAnalysis
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalysisSink,
                uint,
                uint,
                DWRITE_SCRIPT_ANALYSIS*,
                int>)((*lpVtbl)[3])
        )(this, textPosition, textLength, scriptAnalysis);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetLineBreakpoints(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")] DWRITE_LINE_BREAKPOINT* lineBreakpoints
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalysisSink,
                uint,
                uint,
                DWRITE_LINE_BREAKPOINT*,
                int>)((*lpVtbl)[4])
        )(this, textPosition, textLength, lineBreakpoints);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetBidiLevel(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        [NativeTypeName("UINT8")] byte explicitLevel,
        [NativeTypeName("UINT8")] byte resolvedLevel
    )
    {
        return (
            (delegate* unmanaged<IDWriteTextAnalysisSink, uint, uint, byte, byte, int>)(
                (*lpVtbl)[5]
            )
        )(this, textPosition, textLength, explicitLevel, resolvedLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetNumberSubstitution(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        IDWriteNumberSubstitution numberSubstitution
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalysisSink,
                uint,
                uint,
                IDWriteNumberSubstitution,
                int>)((*lpVtbl)[6])
        )(this, textPosition, textLength, numberSubstitution);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetScriptAnalysis(
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            [NativeTypeName("const DWRITE_SCRIPT_ANALYSIS *")]
                DWRITE_SCRIPT_ANALYSIS* scriptAnalysis
        );

        [VtblIndex(4)]
        HRESULT SetLineBreakpoints(
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            [NativeTypeName("const DWRITE_LINE_BREAKPOINT *")]
                DWRITE_LINE_BREAKPOINT* lineBreakpoints
        );

        [VtblIndex(5)]
        HRESULT SetBidiLevel(
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            [NativeTypeName("UINT8")] byte explicitLevel,
            [NativeTypeName("UINT8")] byte resolvedLevel
        );

        [VtblIndex(6)]
        HRESULT SetNumberSubstitution(
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            IDWriteNumberSubstitution numberSubstitution
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
            "HRESULT (UINT32, UINT32, const DWRITE_SCRIPT_ANALYSIS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DWRITE_SCRIPT_ANALYSIS*,
            int> SetScriptAnalysis;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, const DWRITE_LINE_BREAKPOINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DWRITE_LINE_BREAKPOINT*,
            int> SetLineBreakpoints;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, UINT8, UINT8) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, byte, byte, int> SetBidiLevel;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, IDWriteNumberSubstitution *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IDWriteNumberSubstitution,
            int> SetNumberSubstitution;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteTextAnalysisSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteTextAnalysisSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteTextAnalysisSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalysisSink(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteTextAnalysisSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalysisSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalysisSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteTextAnalysisSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
