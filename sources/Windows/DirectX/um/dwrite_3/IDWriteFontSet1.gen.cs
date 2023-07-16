// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1"]/*'/>
[Guid("7E9FDA85-6C92-4053-BC47-7AE3530DB4D3")]
[NativeTypeName("struct IDWriteFontSet1 : IDWriteFontSet")]
[NativeInheritance("IDWriteFontSet")]
public unsafe partial struct IDWriteFontSet1 : IDWriteFontSet1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint> )(lpVtbl[1]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint> )(lpVtbl[2]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetFontCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint> )(lpVtbl[3]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, IDWriteFontFaceReference**, int> )(lpVtbl[4]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFontSet.FindFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, IDWriteFontFaceReference*, uint*, BOOL*, int> )(lpVtbl[5]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
    }

    /// <inheritdoc cref = "IDWriteFontSet.FindFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFontFace(IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, IDWriteFontFace*, uint*, BOOL*, int> )(lpVtbl[6]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int> )(lpVtbl[7]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, IDWriteStringList** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int> )(lpVtbl[8]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, BOOL* exists, IDWriteLocalizedStrings** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, DWRITE_FONT_PROPERTY_ID, BOOL*, IDWriteLocalizedStrings**, int> )(lpVtbl[9]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyOccurrenceCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY*, uint*, int> )(lpVtbl[10]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetMatchingFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int> )(lpVtbl[11]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetMatchingFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, IDWriteFontSet** filteredSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int> )(lpVtbl[12]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetMatchingFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontSet1**, int> )(lpVtbl[13]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFirstFontResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, IDWriteFontSet1**, int> )(lpVtbl[14]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), filteredFontSet);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFilteredFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint*, uint, IDWriteFontSet1**, int> )(lpVtbl[15]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFilteredFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, IDWriteFontSet1**, int> )(lpVtbl[16]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFilteredFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY*, uint, BOOL, IDWriteFontSet1**, int> )(lpVtbl[17]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFilteredFontIndices"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, uint*, uint, uint*, int> )(lpVtbl[18]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFilteredFontIndices"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_PROPERTY*, uint, BOOL, uint*, uint, uint*, int> )(lpVtbl[19]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFontAxisRanges"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> )(lpVtbl[20]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFontAxisRanges"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> )(lpVtbl[21]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFontFaceReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, IDWriteFontFaceReference1**, int> )(lpVtbl[22]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.CreateFontResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateFontResource([NativeTypeName("UINT32")] uint listIndex, IDWriteFontResource** fontResource)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, IDWriteFontResource**, int> )(lpVtbl[23]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontResource);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.CreateFontFace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateFontFace([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFace5** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, IDWriteFontFace5**, int> )(lpVtbl[24]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex, fontFace);
    }

    /// <include file='IDWriteFontSet1.xml' path='doc/member[@name="IDWriteFontSet1.GetFontLocality"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet1*, uint, DWRITE_LOCALITY> )(lpVtbl[25]))((IDWriteFontSet1*)Unsafe.AsPointer(ref this), listIndex);
    }

    public interface Interface : IDWriteFontSet.Interface
    {
        [VtblIndex(13)]
        HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontSet1** matchingFonts);
        [VtblIndex(14)]
        HRESULT GetFirstFontResources(IDWriteFontSet1** filteredFontSet);
        [VtblIndex(15)]
        HRESULT GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, IDWriteFontSet1** filteredFontSet);
        [VtblIndex(16)]
        HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet);
        [VtblIndex(17)]
        HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet);
        [VtblIndex(18)]
        HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount);
        [VtblIndex(19)]
        HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount);
        [VtblIndex(20)]
        HRESULT GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount);
        [VtblIndex(21)]
        HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount);
        [VtblIndex(22)]
        HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference1** fontFaceReference);
        [VtblIndex(23)]
        HRESULT CreateFontResource([NativeTypeName("UINT32")] uint listIndex, IDWriteFontResource** fontResource);
        [VtblIndex(24)]
        HRESULT CreateFontFace([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFace5** fontFace);
        [VtblIndex(25)]
        DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex);
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
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFaceReference**, int> GetFontFaceReference;
        [NativeTypeName("HRESULT (IDWriteFontFaceReference *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFaceReference*, uint*, BOOL*, int> FindFontFaceReference;
        [NativeTypeName("HRESULT (IDWriteFontFace *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontFace*, uint*, BOOL*, int> FindFontFace;
        [NativeTypeName("HRESULT (DWRITE_FONT_PROPERTY_ID, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int> GetPropertyValues;
        [NativeTypeName("HRESULT (DWRITE_FONT_PROPERTY_ID, const WCHAR *, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int> GetPropertyValues1;
        [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_PROPERTY_ID, BOOL *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_PROPERTY_ID, BOOL*, IDWriteLocalizedStrings**, int> GetPropertyValues2;
        [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY*, uint*, int> GetPropertyOccurrenceCount;
        [NativeTypeName("HRESULT (const WCHAR *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int> GetMatchingFonts;
        [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int> GetMatchingFonts1;
        [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontSet1**, int> GetMatchingFonts2;
        [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1**, int> GetFirstFontResources;
        [NativeTypeName("HRESULT (const UINT32 *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint, IDWriteFontSet1**, int> GetFilteredFonts;
        [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, IDWriteFontSet1**, int> GetFilteredFonts1;
        [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY*, uint, BOOL, IDWriteFontSet1**, int> GetFilteredFonts2;
        [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, uint*, uint, uint*, int> GetFilteredFontIndices;
        [NativeTypeName("HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_PROPERTY*, uint, BOOL, uint*, uint, uint*, int> GetFilteredFontIndices1;
        [NativeTypeName("HRESULT (UINT32, DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> GetFontAxisRanges;
        [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> GetFontAxisRanges1;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFaceReference1**, int> GetFontFaceReference1;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontResource**, int> CreateFontResource;
        [NativeTypeName("HRESULT (UINT32, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFace5**, int> CreateFontFace;
        [NativeTypeName("DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;
    }
}