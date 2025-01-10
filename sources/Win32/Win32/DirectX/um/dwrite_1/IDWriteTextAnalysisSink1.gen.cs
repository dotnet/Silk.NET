// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("B0D941A0-85E7-4D8B-9FD3-5CED9934482A")]
[NativeTypeName("struct IDWriteTextAnalysisSink1 : IDWriteTextAnalysisSink")]
[NativeInheritance("IDWriteTextAnalysisSink")]
public unsafe partial struct IDWriteTextAnalysisSink1
    : IDWriteTextAnalysisSink1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSink1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSink1, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteTextAnalysisSink1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSink1, uint>)((*lpVtbl)[2]))(this);
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
                IDWriteTextAnalysisSink1,
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
                IDWriteTextAnalysisSink1,
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
            (delegate* unmanaged<IDWriteTextAnalysisSink1, uint, uint, byte, byte, int>)(
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
                IDWriteTextAnalysisSink1,
                uint,
                uint,
                IDWriteNumberSubstitution,
                int>)((*lpVtbl)[6])
        )(this, textPosition, textLength, numberSubstitution);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetGlyphOrientation(
        [NativeTypeName("UINT32")] uint textPosition,
        [NativeTypeName("UINT32")] uint textLength,
        DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle,
        [NativeTypeName("UINT8")] byte adjustedBidiLevel,
        BOOL isSideways,
        BOOL isRightToLeft
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteTextAnalysisSink1,
                uint,
                uint,
                DWRITE_GLYPH_ORIENTATION_ANGLE,
                byte,
                BOOL,
                BOOL,
                int>)((*lpVtbl)[7])
        )(
            this,
            textPosition,
            textLength,
            glyphOrientationAngle,
            adjustedBidiLevel,
            isSideways,
            isRightToLeft
        );
    }

    public interface Interface : IDWriteTextAnalysisSink.Interface
    {
        [VtblIndex(7)]
        HRESULT SetGlyphOrientation(
            [NativeTypeName("UINT32")] uint textPosition,
            [NativeTypeName("UINT32")] uint textLength,
            DWRITE_GLYPH_ORIENTATION_ANGLE glyphOrientationAngle,
            [NativeTypeName("UINT8")] byte adjustedBidiLevel,
            BOOL isSideways,
            BOOL isRightToLeft
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

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, DWRITE_GLYPH_ORIENTATION_ANGLE, UINT8, BOOL, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            DWRITE_GLYPH_ORIENTATION_ANGLE,
            byte,
            BOOL,
            BOOL,
            int> SetGlyphOrientation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteTextAnalysisSink1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteTextAnalysisSink1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteTextAnalysisSink"/> to <see cref = "IDWriteTextAnalysisSink1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteTextAnalysisSink"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalysisSink1(
        Silk.NET.DirectX.IDWriteTextAnalysisSink value
    )
    {
        return new IDWriteTextAnalysisSink1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalysisSink1"/> to <see cref = "Silk.NET.DirectX.IDWriteTextAnalysisSink"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalysisSink1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteTextAnalysisSink(
        IDWriteTextAnalysisSink1 value
    )
    {
        return new Silk.NET.DirectX.IDWriteTextAnalysisSink(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteTextAnalysisSink1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteTextAnalysisSink1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteTextAnalysisSink1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteTextAnalysisSink1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteTextAnalysisSink1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteTextAnalysisSink1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
