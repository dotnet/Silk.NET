// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource"]/*'/>
[Guid("1F803A76-6871-48E8-987F-B975551C50F2")]
[NativeTypeName("struct IDWriteFontResource : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteFontResource : IDWriteFontResource.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontResource));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint> )(lpVtbl[1]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint> )(lpVtbl[2]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetFontFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFontFile(IDWriteFontFile** fontFile)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, IDWriteFontFile**, int> )(lpVtbl[3]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetFontFaceIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFaceIndex()
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint> )(lpVtbl[4]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetFontAxisCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontAxisCount()
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint> )(lpVtbl[5]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetDefaultFontAxisValues"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDefaultFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_AXIS_VALUE*, uint, int> )(lpVtbl[6]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetFontAxisRanges"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_AXIS_RANGE*, uint, int> )(lpVtbl[7]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetFontAxisAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes([NativeTypeName("UINT32")] uint axisIndex)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint, DWRITE_FONT_AXIS_ATTRIBUTES> )(lpVtbl[8]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetAxisNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAxisNames([NativeTypeName("UINT32")] uint axisIndex, IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int> )(lpVtbl[9]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetAxisValueNameCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT32")]
    public uint GetAxisValueNameCount([NativeTypeName("UINT32")] uint axisIndex)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint, uint> )(lpVtbl[10]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.GetAxisValueNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAxisValueNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("UINT32")] uint axisValueIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRange, IDWriteLocalizedStrings** names)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, uint, uint, DWRITE_FONT_AXIS_RANGE*, IDWriteLocalizedStrings**, int> )(lpVtbl[11]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.HasVariations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL HasVariations()
    {
        return ((delegate* unmanaged<IDWriteFontResource*, int> )(lpVtbl[12]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.CreateFontFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFace5** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFace5**, int> )(lpVtbl[13]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
    }

    /// <include file='IDWriteFontResource.xml' path='doc/member[@name="IDWriteFontResource.CreateFontFaceReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int> )(lpVtbl[14]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFontFile(IDWriteFontFile** fontFile);
        [VtblIndex(4)]
        [return: NativeTypeName("UINT32")]
        uint GetFontFaceIndex();
        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        uint GetFontAxisCount();
        [VtblIndex(6)]
        HRESULT GetDefaultFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);
        [VtblIndex(7)]
        HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount);
        [VtblIndex(8)]
        DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes([NativeTypeName("UINT32")] uint axisIndex);
        [VtblIndex(9)]
        HRESULT GetAxisNames([NativeTypeName("UINT32")] uint axisIndex, IDWriteLocalizedStrings** names);
        [VtblIndex(10)]
        [return: NativeTypeName("UINT32")]
        uint GetAxisValueNameCount([NativeTypeName("UINT32")] uint axisIndex);
        [VtblIndex(11)]
        HRESULT GetAxisValueNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("UINT32")] uint axisValueIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRange, IDWriteLocalizedStrings** names);
        [VtblIndex(12)]
        BOOL HasVariations();
        [VtblIndex(13)]
        HRESULT CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFace5** fontFace);
        [VtblIndex(14)]
        HRESULT CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference);
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
        [NativeTypeName("HRESULT (IDWriteFontFile **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFile**, int> GetFontFile;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontFaceIndex;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontAxisCount;
        [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetDefaultFontAxisValues;
        [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_RANGE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_RANGE*, uint, int> GetFontAxisRanges;
        [NativeTypeName("DWRITE_FONT_AXIS_ATTRIBUTES (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_AXIS_ATTRIBUTES> GetFontAxisAttributes;
        [NativeTypeName("HRESULT (UINT32, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteLocalizedStrings**, int> GetAxisNames;
        [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetAxisValueNameCount;
        [NativeTypeName("HRESULT (UINT32, UINT32, DWRITE_FONT_AXIS_RANGE *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, DWRITE_FONT_AXIS_RANGE*, IDWriteLocalizedStrings**, int> GetAxisValueNames;
        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HasVariations;
        [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFace5**, int> CreateFontFace;
        [NativeTypeName("HRESULT (DWRITE_FONT_SIMULATIONS, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int> CreateFontFaceReference;
    }
}