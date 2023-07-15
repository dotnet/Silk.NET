// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteTextAnalysisSource1.xml' path='doc/member[@name="IDWriteTextAnalysisSource1"]/*'/>
[Guid("639CFAD8-0FB4-4B21-A58A-067920120009")]
[NativeTypeName("struct IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource")]
[NativeInheritance("IDWriteTextAnalysisSource")]
public unsafe partial struct IDWriteTextAnalysisSource1 : IDWriteTextAnalysisSource1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteTextAnalysisSource1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint> )(lpVtbl[1]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint> )(lpVtbl[2]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextAnalysisSource.GetTextAtPosition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTextAtPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int> )(lpVtbl[3]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
    }

    /// <inheritdoc cref = "IDWriteTextAnalysisSource.GetTextBeforePosition"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTextBeforePosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("const WCHAR **")] ushort** textString, [NativeTypeName("UINT32 *")] uint* textLength)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, ushort**, uint*, int> )(lpVtbl[4]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textString, textLength);
    }

    /// <inheritdoc cref = "IDWriteTextAnalysisSource.GetParagraphReadingDirection"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public DWRITE_READING_DIRECTION GetParagraphReadingDirection()
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, DWRITE_READING_DIRECTION> )(lpVtbl[5]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteTextAnalysisSource.GetLocaleName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLocaleName([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, [NativeTypeName("const WCHAR **")] ushort** localeName)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, ushort**, int> )(lpVtbl[6]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, localeName);
    }

    /// <inheritdoc cref = "IDWriteTextAnalysisSource.GetNumberSubstitution"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetNumberSubstitution([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int> )(lpVtbl[7]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, numberSubstitution);
    }

    /// <include file='IDWriteTextAnalysisSource1.xml' path='doc/member[@name="IDWriteTextAnalysisSource1.GetVerticalGlyphOrientation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVerticalGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8 *")] byte* bidiLevel)
    {
        return ((delegate* unmanaged<IDWriteTextAnalysisSource1*, uint, uint*, DWRITE_VERTICAL_GLYPH_ORIENTATION*, byte*, int> )(lpVtbl[8]))((IDWriteTextAnalysisSource1*)Unsafe.AsPointer(ref this), textPosition, textLength, glyphOrientation, bidiLevel);
    }

    public interface Interface : IDWriteTextAnalysisSource.Interface
    {
        [VtblIndex(8)]
        HRESULT GetVerticalGlyphOrientation([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32 *")] uint* textLength, DWRITE_VERTICAL_GLYPH_ORIENTATION* glyphOrientation, [NativeTypeName("UINT8 *")] byte* bidiLevel);
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
        [NativeTypeName("HRESULT (UINT32, const WCHAR **, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, uint*, int> GetTextAtPosition;
        [NativeTypeName("HRESULT (UINT32, const WCHAR **, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, uint*, int> GetTextBeforePosition;
        [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_READING_DIRECTION> GetParagraphReadingDirection;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, const WCHAR **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, ushort**, int> GetLocaleName;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, IDWriteNumberSubstitution **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, IDWriteNumberSubstitution**, int> GetNumberSubstitution;
        [NativeTypeName("HRESULT (UINT32, UINT32 *, DWRITE_VERTICAL_GLYPH_ORIENTATION *, UINT8 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, DWRITE_VERTICAL_GLYPH_ORIENTATION*, byte*, int> GetVerticalGlyphOrientation;
    }
}