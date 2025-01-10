// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("7C073EF2-A7F4-4045-8C32-8AB8AE640F90")]
[NativeTypeName("struct IDWriteFontSet3 : IDWriteFontSet2")]
[NativeInheritance("IDWriteFontSet2")]
[SupportedOSPlatform("windows10.0.19043.0")]
public unsafe partial struct IDWriteFontSet3 : IDWriteFontSet3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteFontSet3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteFontSet3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteFontSet3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteFontSet3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontCount()
    {
        return ((delegate* unmanaged<IDWriteFontSet3, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, IDWriteFontFaceReference*, int>)(
                (*lpVtbl)[4]
            )
        )(this, listIndex, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FindFontFaceReference(
        IDWriteFontFaceReference fontFaceReference,
        [NativeTypeName("UINT32 *")] uint* listIndex,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, IDWriteFontFaceReference, uint*, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, fontFaceReference, listIndex, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFontFace(
        IDWriteFontFace fontFace,
        [NativeTypeName("UINT32 *")] uint* listIndex,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, IDWriteFontFace, uint*, BOOL*, int>)((*lpVtbl)[6])
        )(this, fontFace, listIndex, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPropertyValues(DWRITE_FONT_PROPERTY_ID propertyID, IDWriteStringList* values)
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY_ID,
                IDWriteStringList*,
                int>)((*lpVtbl)[7])
        )(this, propertyID, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetPropertyValues(
        DWRITE_FONT_PROPERTY_ID propertyID,
        [NativeTypeName("const WCHAR *")] ushort* preferredLocaleNames,
        IDWriteStringList* values
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY_ID,
                ushort*,
                IDWriteStringList*,
                int>)((*lpVtbl)[8])
        )(this, propertyID, preferredLocaleNames, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPropertyValues(
        [NativeTypeName("UINT32")] uint listIndex,
        DWRITE_FONT_PROPERTY_ID propertyId,
        BOOL* exists,
        IDWriteLocalizedStrings* values
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                uint,
                DWRITE_FONT_PROPERTY_ID,
                BOOL*,
                IDWriteLocalizedStrings*,
                int>)((*lpVtbl)[9])
        )(this, listIndex, propertyId, exists, values);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPropertyOccurrenceCount(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* property,
        [NativeTypeName("UINT32 *")] uint* propertyOccurrenceCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, DWRITE_FONT_PROPERTY*, uint*, int>)((*lpVtbl)[10])
        )(this, property, propertyOccurrenceCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const WCHAR *")] ushort* familyName,
        DWRITE_FONT_WEIGHT fontWeight,
        DWRITE_FONT_STRETCH fontStretch,
        DWRITE_FONT_STYLE fontStyle,
        IDWriteFontSet* filteredSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                ushort*,
                DWRITE_FONT_WEIGHT,
                DWRITE_FONT_STRETCH,
                DWRITE_FONT_STYLE,
                IDWriteFontSet*,
                int>)((*lpVtbl)[11])
        )(this, familyName, fontWeight, fontStretch, fontStyle, filteredSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount,
        IDWriteFontSet* filteredSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY*,
                uint,
                IDWriteFontSet*,
                int>)((*lpVtbl)[12])
        )(this, properties, propertyCount, filteredSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMatchingFonts(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* fontProperty,
        [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues,
        [NativeTypeName("UINT32")] uint fontAxisValueCount,
        IDWriteFontSet1* matchingFonts
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY*,
                DWRITE_FONT_AXIS_VALUE*,
                uint,
                IDWriteFontSet1*,
                int>)((*lpVtbl)[13])
        )(this, fontProperty, fontAxisValues, fontAxisValueCount, matchingFonts);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFirstFontResources(IDWriteFontSet1* filteredFontSet)
    {
        return ((delegate* unmanaged<IDWriteFontSet3, IDWriteFontSet1*, int>)((*lpVtbl)[14]))(
            this,
            filteredFontSet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFilteredFonts(
        [NativeTypeName("const UINT32 *")] uint* indices,
        [NativeTypeName("UINT32")] uint indexCount,
        IDWriteFontSet1* filteredFontSet
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint*, uint, IDWriteFontSet1*, int>)(
                (*lpVtbl)[15]
            )
        )(this, indices, indexCount, filteredFontSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFilteredFonts(
        [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
        [NativeTypeName("UINT32")] uint fontAxisRangeCount,
        BOOL selectAnyRange,
        IDWriteFontSet1* filteredFontSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_AXIS_RANGE*,
                uint,
                BOOL,
                IDWriteFontSet1*,
                int>)((*lpVtbl)[16])
        )(this, fontAxisRanges, fontAxisRangeCount, selectAnyRange, filteredFontSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFilteredFonts(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount,
        BOOL selectAnyProperty,
        IDWriteFontSet1* filteredFontSet
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY*,
                uint,
                BOOL,
                IDWriteFontSet1*,
                int>)((*lpVtbl)[17])
        )(this, properties, propertyCount, selectAnyProperty, filteredFontSet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFilteredFontIndices(
        [NativeTypeName("const DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
        [NativeTypeName("UINT32")] uint fontAxisRangeCount,
        BOOL selectAnyRange,
        [NativeTypeName("UINT32 *")] uint* indices,
        [NativeTypeName("UINT32")] uint maxIndexCount,
        [NativeTypeName("UINT32 *")] uint* actualIndexCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_AXIS_RANGE*,
                uint,
                BOOL,
                uint*,
                uint,
                uint*,
                int>)((*lpVtbl)[18])
        )(
            this,
            fontAxisRanges,
            fontAxisRangeCount,
            selectAnyRange,
            indices,
            maxIndexCount,
            actualIndexCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFilteredFontIndices(
        [NativeTypeName("const DWRITE_FONT_PROPERTY *")] DWRITE_FONT_PROPERTY* properties,
        [NativeTypeName("UINT32")] uint propertyCount,
        BOOL selectAnyProperty,
        [NativeTypeName("UINT32 *")] uint* indices,
        [NativeTypeName("UINT32")] uint maxIndexCount,
        [NativeTypeName("UINT32 *")] uint* actualIndexCount
    )
    {
        return (
            (delegate* unmanaged<
                IDWriteFontSet3,
                DWRITE_FONT_PROPERTY*,
                uint,
                BOOL,
                uint*,
                uint,
                uint*,
                int>)((*lpVtbl)[19])
        )(
            this,
            properties,
            propertyCount,
            selectAnyProperty,
            indices,
            maxIndexCount,
            actualIndexCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetFontAxisRanges(
        [NativeTypeName("UINT32")] uint listIndex,
        DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
        [NativeTypeName("UINT32")] uint maxFontAxisRangeCount,
        [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(
                (*lpVtbl)[20]
            )
        )(this, listIndex, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontAxisRanges(
        DWRITE_FONT_AXIS_RANGE* fontAxisRanges,
        [NativeTypeName("UINT32")] uint maxFontAxisRangeCount,
        [NativeTypeName("UINT32 *")] uint* actualFontAxisRangeCount
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, DWRITE_FONT_AXIS_RANGE*, uint, uint*, int>)(
                (*lpVtbl)[21]
            )
        )(this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetFontFaceReference(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFaceReference1* fontFaceReference
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, IDWriteFontFaceReference1*, int>)(
                (*lpVtbl)[22]
            )
        )(this, listIndex, fontFaceReference);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateFontResource(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontResource* fontResource
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, IDWriteFontResource*, int>)((*lpVtbl)[23])
        )(this, listIndex, fontResource);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateFontFace(
        [NativeTypeName("UINT32")] uint listIndex,
        IDWriteFontFace5* fontFace
    )
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, IDWriteFontFace5*, int>)((*lpVtbl)[24])
        )(this, listIndex, fontFace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public DWRITE_LOCALITY GetFontLocality([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet3, uint, DWRITE_LOCALITY>)((*lpVtbl)[25]))(
            this,
            listIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HANDLE GetExpirationEvent()
    {
        return ((HANDLE)(((delegate* unmanaged<IDWriteFontSet3, void*>)((*lpVtbl)[26]))(this)));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public DWRITE_FONT_SOURCE_TYPE GetFontSourceType([NativeTypeName("UINT32")] uint fontIndex)
    {
        return (
            (delegate* unmanaged<IDWriteFontSet3, uint, DWRITE_FONT_SOURCE_TYPE>)((*lpVtbl)[27])
        )(this, fontIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontSourceNameLength([NativeTypeName("UINT32")] uint listIndex)
    {
        return ((delegate* unmanaged<IDWriteFontSet3, uint, uint>)((*lpVtbl)[28]))(this, listIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetFontSourceName(
        [NativeTypeName("UINT32")] uint listIndex,
        [NativeTypeName("WCHAR *")] ushort* stringBuffer,
        [NativeTypeName("UINT32")] uint stringBufferSize
    )
    {
        return ((delegate* unmanaged<IDWriteFontSet3, uint, ushort*, uint, int>)((*lpVtbl)[29]))(
            this,
            listIndex,
            stringBuffer,
            stringBufferSize
        );
    }

    public interface Interface : IDWriteFontSet2.Interface
    {
        [VtblIndex(27)]
        DWRITE_FONT_SOURCE_TYPE GetFontSourceType([NativeTypeName("UINT32")] uint fontIndex);

        [VtblIndex(28)]
        [return: NativeTypeName("UINT32")]
        uint GetFontSourceNameLength([NativeTypeName("UINT32")] uint listIndex);

        [VtblIndex(29)]
        HRESULT GetFontSourceName(
            [NativeTypeName("UINT32")] uint listIndex,
            [NativeTypeName("WCHAR *")] ushort* stringBuffer,
            [NativeTypeName("UINT32")] uint stringBufferSize
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

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetFontCount;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFaceReference **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontFaceReference*,
            int> GetFontFaceReference;

        [NativeTypeName(
            "HRESULT (IDWriteFontFaceReference *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDWriteFontFaceReference,
            uint*,
            BOOL*,
            int> FindFontFaceReference;

        [NativeTypeName(
            "HRESULT (IDWriteFontFace *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontFace, uint*, BOOL*, int> FindFontFace;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_PROPERTY_ID, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY_ID,
            IDWriteStringList*,
            int> GetPropertyValues;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_PROPERTY_ID, const WCHAR *, IDWriteStringList **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY_ID,
            ushort*,
            IDWriteStringList*,
            int> GetPropertyValues1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_PROPERTY_ID, BOOL *, IDWriteLocalizedStrings **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_PROPERTY_ID,
            BOOL*,
            IDWriteLocalizedStrings*,
            int> GetPropertyValues2;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint*,
            int> GetPropertyOccurrenceCount;

        [NativeTypeName(
            "HRESULT (const WCHAR *, DWRITE_FONT_WEIGHT, DWRITE_FONT_STRETCH, DWRITE_FONT_STYLE, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            DWRITE_FONT_WEIGHT,
            DWRITE_FONT_STRETCH,
            DWRITE_FONT_STYLE,
            IDWriteFontSet*,
            int> GetMatchingFonts;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint,
            IDWriteFontSet*,
            int> GetMatchingFonts1;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            DWRITE_FONT_AXIS_VALUE*,
            uint,
            IDWriteFontSet1*,
            int> GetMatchingFonts2;

        [NativeTypeName(
            "HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDWriteFontSet1*, int> GetFirstFontResources;

        [NativeTypeName(
            "HRESULT (const UINT32 *, UINT32, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint*, uint, IDWriteFontSet1*, int> GetFilteredFonts;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_AXIS_RANGE*,
            uint,
            BOOL,
            IDWriteFontSet1*,
            int> GetFilteredFonts1;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint,
            BOOL,
            IDWriteFontSet1*,
            int> GetFilteredFonts2;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_AXIS_RANGE *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_AXIS_RANGE*,
            uint,
            BOOL,
            uint*,
            uint,
            uint*,
            int> GetFilteredFontIndices;

        [NativeTypeName(
            "HRESULT (const DWRITE_FONT_PROPERTY *, UINT32, BOOL, UINT32 *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_PROPERTY*,
            uint,
            BOOL,
            uint*,
            uint,
            uint*,
            int> GetFilteredFontIndices1;

        [NativeTypeName(
            "HRESULT (UINT32, DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            DWRITE_FONT_AXIS_RANGE*,
            uint,
            uint*,
            int> GetFontAxisRanges;

        [NativeTypeName(
            "HRESULT (DWRITE_FONT_AXIS_RANGE *, UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DWRITE_FONT_AXIS_RANGE*,
            uint,
            uint*,
            int> GetFontAxisRanges1;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFaceReference1 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IDWriteFontFaceReference1*,
            int> GetFontFaceReference1;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontResource **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontResource*, int> CreateFontResource;

        [NativeTypeName(
            "HRESULT (UINT32, IDWriteFontFace5 **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IDWriteFontFace5*, int> CreateFontFace;

        [NativeTypeName(
            "DWRITE_LOCALITY (UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DWRITE_LOCALITY> GetFontLocality;

        [NativeTypeName("HANDLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> GetExpirationEvent;

        [NativeTypeName(
            "DWRITE_FONT_SOURCE_TYPE (UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DWRITE_FONT_SOURCE_TYPE> GetFontSourceType;

        [NativeTypeName("UINT32 (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint> GetFontSourceNameLength;

        [NativeTypeName(
            "HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetFontSourceName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteFontSet3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteFontSet3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSet2"/> to <see cref = "IDWriteFontSet3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSet2"/> instance to be converted </param>
    public static explicit operator IDWriteFontSet3(Silk.NET.DirectX.IDWriteFontSet2 value)
    {
        return new IDWriteFontSet3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSet3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSet2"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSet3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSet2(IDWriteFontSet3 value)
    {
        return new Silk.NET.DirectX.IDWriteFontSet2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSet1"/> to <see cref = "IDWriteFontSet3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSet1"/> instance to be converted </param>
    public static explicit operator IDWriteFontSet3(Silk.NET.DirectX.IDWriteFontSet1 value)
    {
        return new IDWriteFontSet3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSet3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSet1"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSet3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSet1(IDWriteFontSet3 value)
    {
        return new Silk.NET.DirectX.IDWriteFontSet1(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteFontSet"/> to <see cref = "IDWriteFontSet3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteFontSet"/> instance to be converted </param>
    public static explicit operator IDWriteFontSet3(Silk.NET.DirectX.IDWriteFontSet value)
    {
        return new IDWriteFontSet3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSet3"/> to <see cref = "Silk.NET.DirectX.IDWriteFontSet"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSet3"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteFontSet(IDWriteFontSet3 value)
    {
        return new Silk.NET.DirectX.IDWriteFontSet(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteFontSet3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteFontSet3(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteFontSet3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteFontSet3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteFontSet3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteFontSet3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
