// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDWriteFontSet4.xml' path='doc/member[@name="IDWriteFontSet4"]/*'/>
[Guid("EEC175FC-BEA9-4C86-8B53-CCBDD7DF0C82")]
[NativeTypeName("struct IDWriteFontSet4 : IDWriteFontSet3")]
[NativeInheritance("IDWriteFontSet3")]
public unsafe partial struct IDWriteFontSet4 : IDWriteFontSet4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint> )(lpVtbl[1]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint> )(lpVtbl[2]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetFontCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint> )(lpVtbl[3]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFaceReference**, int> )(lpVtbl[4]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFontSet.FindFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFontFaceReference(IDWriteFontFaceReference* fontFaceReference, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontFaceReference*, uint*, BOOL*, int> )(lpVtbl[5]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFaceReference, listIndex, exists);
    }

    /// <inheritdoc cref = "IDWriteFontSet.FindFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFontFace(IDWriteFontFace* fontFace, [NativeTypeName("UINT32 *")] uint* listIndex, BOOL* exists)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontFace*, uint*, BOOL*, int> )(lpVtbl[6]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontFace, listIndex, exists);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY_ID, IDWriteStringList**, int> )(lpVtbl[7]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames, IDWriteStringList** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY_ID, ushort*, IDWriteStringList**, int> )(lpVtbl[8]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), propertyID, preferredLocaleNames, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyValues"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyValues([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_PROPERTY_ID propertyId, BOOL* exists, IDWriteLocalizedStrings** values)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, DWRITE_FONT_PROPERTY_ID, BOOL*, IDWriteLocalizedStrings**, int> )(lpVtbl[9]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, propertyId, exists, values);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetPropertyOccurrenceCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyOccurrenceCount([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property, [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY*, uint*, int> )(lpVtbl[10]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), property, propertyOccurrenceCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetMatchingFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, IDWriteFontSet** filteredSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, ushort*, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet**, int> )(lpVtbl[11]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontWeight, fontStretch, fontStyle, filteredSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet.GetMatchingFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, IDWriteFontSet** filteredSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY*, uint, IDWriteFontSet**, int> )(lpVtbl[12]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, filteredSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetMatchingFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMatchingFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, IDWriteFontSet1** matchingFonts)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontSet1**, int> )(lpVtbl[13]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFirstFontResources"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFirstFontResources(IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, IDWriteFontSet1**, int> )(lpVtbl[14]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), filteredFontSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFilteredFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFilteredFonts([NativeTypeName("const UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint indexCount, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint*, uint, IDWriteFontSet1**, int> )(lpVtbl[15]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), indices, indexCount, filteredFontSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFilteredFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, IDWriteFontSet1**, int> )(lpVtbl[16]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFilteredFonts"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFilteredFonts([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY*, uint, BOOL, IDWriteFontSet1**, int> )(lpVtbl[17]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, filteredFontSet);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFilteredFontIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount, BOOL selectAnyRange, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_AXIS_RANGE*, uint, BOOL, uint*, uint, uint*, int> )(lpVtbl[18]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount, selectAnyRange, indices, maxIndexCount, actualIndexCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFilteredFontIndices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFilteredFontIndices([NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties, [NativeTypeName("UINT32")] uint propertyCount, BOOL selectAnyProperty, [NativeTypeName("UINT32 *")] uint* indices, [NativeTypeName("UINT32")] uint maxIndexCount, [NativeTypeName("UINT32 *")] uint* actualIndexCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_PROPERTY*, uint, BOOL, uint*, uint, uint*, int> )(lpVtbl[19]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFontAxisRanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetFontAxisRanges([NativeTypeName("UINT32")] uint listIndex, DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> )(lpVtbl[20]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFontAxisRanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontAxisRanges(DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint maxFontAxisRangeCount, [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int> )(lpVtbl[21]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFontFaceReference"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetFontFaceReference([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFaceReference1** fontFaceReference)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFaceReference1**, int> )(lpVtbl[22]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFaceReference);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.CreateFontResource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateFontResource([NativeTypeName("UINT32")] uint listIndex, IDWriteFontResource** fontResource)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontResource**, int> )(lpVtbl[23]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontResource);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.CreateFontFace"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateFontFace([NativeTypeName("UINT32")] uint listIndex, IDWriteFontFace5** fontFace)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, IDWriteFontFace5**, int> )(lpVtbl[24]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, fontFace);
    }

    /// <inheritdoc cref = "IDWriteFontSet1.GetFontLocality"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, DWRITE_LOCALITY> )(lpVtbl[25]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
    }

    /// <inheritdoc cref = "IDWriteFontSet2.GetExpirationEvent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HANDLE GetExpirationEvent()
    {
        return ((HANDLE)(((delegate* unmanaged<IDWriteFontSet4*, void*> )(lpVtbl[26]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this))));
    }

    /// <inheritdoc cref = "IDWriteFontSet3.GetFontSourceType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public DWRITE_FONT_SOURCE_TYPE GetFontSourceType([NativeTypeName("UINT32")] uint fontIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, DWRITE_FONT_SOURCE_TYPE> )(lpVtbl[27]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), fontIndex);
    }

    /// <inheritdoc cref = "IDWriteFontSet3.GetFontSourceNameLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontSourceNameLength([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, uint> )(lpVtbl[28]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex);
    }

    /// <inheritdoc cref = "IDWriteFontSet3.GetFontSourceName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetFontSourceName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, uint, ushort*, uint, int> )(lpVtbl[29]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
    }

    /// <include file='IDWriteFontSet4.xml' path='doc/member[@name="IDWriteFontSet4.ConvertWeightStretchStyleToFontAxisValues"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    [return: NativeTypeName("UINT32")]
    public uint ConvertWeightStretchStyleToFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* inputAxisValues, [NativeTypeName("UINT32")] uint inputAxisCount, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, float fontSize, DWRITE_FONT_AXIS_VALUE* outputAxisValues)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, float, DWRITE_FONT_AXIS_VALUE*, uint> )(lpVtbl[30]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), inputAxisValues, inputAxisCount, fontWeight, fontStretch, fontStyle, fontSize, outputAxisValues);
    }

    /// <include file='IDWriteFontSet4.xml' path='doc/member[@name="IDWriteFontSet4.GetMatchingFonts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, DWRITE_FONT_SIMULATIONS allowedSimulations, IDWriteFontSet4** matchingFonts)
    {
        return ((delegate* unmanaged<IDWriteFontSet4*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontSet4**, int> )(lpVtbl[31]))((IDWriteFontSet4*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, allowedSimulations, matchingFonts);
    }

    public interface Interface : IDWriteFontSet3.Interface
    {
        [VtblIndex(30)]
        [return: NativeTypeName("UINT32")]
        uint ConvertWeightStretchStyleToFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* inputAxisValues, [NativeTypeName("UINT32")] uint inputAxisCount, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STRETCH fontStretch, DWRITE_FONT_STYLE fontStyle, float fontSize, DWRITE_FONT_AXIS_VALUE* outputAxisValues);
        [VtblIndex(31)]
        HRESULT GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, DWRITE_FONT_SIMULATIONS allowedSimulations, IDWriteFontSet4** matchingFonts);
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
        [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetExpirationEvent;
        [NativeTypeName("DWRITE_FONT_SOURCE_TYPE (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_SOURCE_TYPE> GetFontSourceType;
        [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetFontSourceNameLength;
        [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetFontSourceName;
        [NativeTypeName("UINT32 (const DWRITE_FONT_AXIS_VALUE *, UINT32, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, float, DWRITE_FONT_AXIS_VALUE *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, float, DWRITE_FONT_AXIS_VALUE*, uint> ConvertWeightStretchStyleToFontAxisValues;
        [NativeTypeName("HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, DWRITE_FONT_SIMULATIONS, IDWriteFontSet4 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, DWRITE_FONT_SIMULATIONS, IDWriteFontSet4**, int> GetMatchingFonts3;
    }
}