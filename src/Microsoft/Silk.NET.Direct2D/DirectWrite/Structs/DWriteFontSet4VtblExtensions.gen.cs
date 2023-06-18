// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFontSet4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontSet4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontSet4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontSet4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet4> thisVtbl, IDWriteFontFaceReference* fontFaceReference, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet4> thisVtbl, IDWriteFontFace* fontFace, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex, FontPropertyID propertyId, int* exists, IDWriteLocalizedStrings** values)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, values);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, uint* propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstFontResources(this ComPtr<IDWriteFontSet4> thisVtbl, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet4> thisVtbl, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontResource(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex, IDWriteFontResource** fontResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetFontLocality(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, Locality>)@this->LpVtbl[25])(@this, listIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetExpirationEvent(this ComPtr<IDWriteFontSet4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, void*>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSourceType GetFontSourceType(this ComPtr<IDWriteFontSet4> thisVtbl, uint fontIndex)
    {
        var @this = thisVtbl.Handle;
        FontSourceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, FontSourceType>)@this->LpVtbl[27])(@this, fontIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontSourceNameLength(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, uint>)@this->LpVtbl[28])(@this, listIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSourceName(this ComPtr<IDWriteFontSet4> thisVtbl, uint listIndex, char* stringBuffer, uint stringBufferSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, uint, char*, uint, int>)@this->LpVtbl[29])(@this, listIndex, stringBuffer, stringBufferSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe uint ConvertWeightStretchStyleToFontAxisValues(this ComPtr<IDWriteFontSet4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* inputAxisValues, uint inputAxisCount, FontWeight fontWeight, FontStretch fontStretch, FontStyle fontStyle, float fontSize, FontAxisValue* outputAxisValues)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet4*, FontAxisValue*, uint, FontWeight, FontStretch, FontStyle, float, FontAxisValue*, uint>)@this->LpVtbl[30])(@this, inputAxisValues, inputAxisCount, fontWeight, fontStretch, fontStyle, fontSize, outputAxisValues);
        return ret;
    }

}
