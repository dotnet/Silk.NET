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

public unsafe static class DWriteFontSet2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontSet2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontSet2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontSet2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontFaceReference**, int>)@this->LpVtbl[4])(@this, listIndex, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, uint* listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndex, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* listIndexPtr = &listIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, ref uint listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* listIndexPtr = &listIndex)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReference, listIndexPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFaceReference fontFaceReference, uint* listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndex, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFaceReference fontFaceReference, ref uint listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFaceReference*, uint*, int*, int>)@this->LpVtbl[5])(@this, fontFaceReferencePtr, listIndexPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, uint* listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndex, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, ref uint listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* listIndexPtr = &listIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, ref uint listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* listIndexPtr = &listIndex)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFace, listIndexPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFace fontFace, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFace fontFace, uint* listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndex, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFace fontFace, ref uint listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            fixed (uint* listIndexPtr = &listIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontFace fontFace, ref uint listIndex, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            fixed (uint* listIndexPtr = &listIndex)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontFace*, uint*, int*, int>)@this->LpVtbl[6])(@this, fontFacePtr, listIndexPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, int* exists, IDWriteLocalizedStrings** values)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, values);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, int* exists, ref IDWriteLocalizedStrings* values)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** valuesPtr = &values)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, exists, valuesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, ref int exists, IDWriteLocalizedStrings** values)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, values);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, ref int exists, ref IDWriteLocalizedStrings* values)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            fixed (IDWriteLocalizedStrings** valuesPtr = &values)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, FontPropertyID, int*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, listIndex, propertyId, existsPtr, valuesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, uint* propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, ref uint propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, property, propertyOccurrenceCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty property, uint* propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertyPtr = &property)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty property, ref uint propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertyPtr = &property)
        {
            fixed (uint* propertyOccurrenceCountPtr = &propertyOccurrenceCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint*, int>)@this->LpVtbl[10])(@this, propertyPtr, propertyOccurrenceCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, properties, propertyCount, filteredSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            fixed (IDWriteFontSet** filteredSetPtr = &filteredSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, IDWriteFontSet**, int>)@this->LpVtbl[12])(@this, propertiesPtr, propertyCount, filteredSetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstFontResources(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstFontResources(this ComPtr<IDWriteFontSet2> thisVtbl, ref IDWriteFontSet1* filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, IDWriteFontSet1**, int>)@this->LpVtbl[14])(@this, filteredFontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref IDWriteFontSet1* filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, properties, propertyCount, selectAnyProperty, filteredFontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, propertiesPtr, propertyCount, selectAnyProperty, filteredFontSet);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref IDWriteFontSet1* filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            fixed (IDWriteFontSet1** filteredFontSetPtr = &filteredFontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, IDWriteFontSet1**, int>)@this->LpVtbl[17])(@this, propertiesPtr, propertyCount, selectAnyProperty, filteredFontSetPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, ref uint actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualIndexCountPtr = &actualIndexCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indicesPtr = &indices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, ref uint actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indicesPtr = &indices)
        {
            fixed (uint* actualIndexCountPtr = &actualIndexCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, properties, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, ref uint actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            fixed (uint* actualIndexCountPtr = &actualIndexCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            fixed (uint* indicesPtr = &indices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref uint indices, uint maxIndexCount, ref uint actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            fixed (uint* indicesPtr = &indices)
            {
                fixed (uint* actualIndexCountPtr = &actualIndexCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontProperty*, uint, Silk.NET.Core.Bool32, uint*, uint, uint*, int>)@this->LpVtbl[19])(@this, propertiesPtr, propertyCount, selectAnyProperty, indicesPtr, maxIndexCount, actualIndexCountPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, ref uint actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualFontAxisRangeCountPtr = &actualFontAxisRangeCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRanges, maxFontAxisRangeCount, actualFontAxisRangeCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, ref FontAxisRange fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRangesPtr, maxFontAxisRangeCount, actualFontAxisRangeCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, ref FontAxisRange fontAxisRanges, uint maxFontAxisRangeCount, ref uint actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
        {
            fixed (uint* actualFontAxisRangeCountPtr = &actualFontAxisRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, FontAxisRange*, uint, uint*, int>)@this->LpVtbl[21])(@this, fontAxisRangesPtr, maxFontAxisRangeCount, actualFontAxisRangeCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontResource(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, IDWriteFontResource** fontResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResource);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontResource(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref IDWriteFontResource* fontResource)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontResource** fontResourcePtr = &fontResource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontResource**, int>)@this->LpVtbl[23])(@this, listIndex, fontResourcePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref IDWriteFontFace5* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[24])(@this, listIndex, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Locality GetFontLocality(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex)
    {
        var @this = thisVtbl.Handle;
        Locality ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, uint, Locality>)@this->LpVtbl[25])(@this, listIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetExpirationEvent(this ComPtr<IDWriteFontSet2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSet2*, void*>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSet2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFaceReference<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFaceReference(listIndex, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFaceReference, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, uint* listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(fontFaceReference, listIndex, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFaceReference, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, listIndex, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, Span<uint> listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(fontFaceReference, ref listIndex.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFaceReference, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFaceReference* fontFaceReference, Span<uint> listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(fontFaceReference, ref listIndex.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFaceReference<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFaceReference, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle, ref listIndex, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(ref fontFaceReference.GetPinnableReference(), listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference, uint* listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(ref fontFaceReference.GetPinnableReference(), listIndex, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference, Span<uint> listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(ref fontFaceReference.GetPinnableReference(), ref listIndex.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFaceReference(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference, Span<uint> listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFaceReference(ref fontFaceReference.GetPinnableReference(), ref listIndex.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFace, uint* listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, uint* listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(fontFace, listIndex, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFace, uint* listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, listIndex, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, Span<uint> listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(fontFace, ref listIndex.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFace, ref uint listIndex, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, IDWriteFontFace* fontFace, Span<uint> listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(fontFace, ref listIndex.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFace<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ComPtr<TI0> fontFace, ref uint listIndex, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->FindFontFace((IDWriteFontFace*) fontFace.Handle, ref listIndex, ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFace> fontFace, uint* listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(ref fontFace.GetPinnableReference(), listIndex, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFace> fontFace, uint* listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(ref fontFace.GetPinnableReference(), listIndex, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFace> fontFace, Span<uint> listIndex, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(ref fontFace.GetPinnableReference(), ref listIndex.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindFontFace(this ComPtr<IDWriteFontSet2> thisVtbl, Span<IDWriteFontFace> fontFace, Span<uint> listIndex, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFontFace(ref fontFace.GetPinnableReference(), ref listIndex.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, int* exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPropertyValues(listIndex, propertyId, exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, Span<int> exists, IDWriteLocalizedStrings** values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyValues(listIndex, propertyId, ref exists.GetPinnableReference(), values);
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyValues<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, ref int exists, ref ComPtr<TI0> values) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetPropertyValues(listIndex, propertyId, ref exists, (IDWriteLocalizedStrings**) values.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyValues(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, FontPropertyID propertyId, Span<int> exists, ref IDWriteLocalizedStrings* values)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyValues(listIndex, propertyId, ref exists.GetPinnableReference(), ref values);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* property, Span<uint> propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyOccurrenceCount(property, ref propertyOccurrenceCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> property, uint* propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyOccurrenceCount(in property.GetPinnableReference(), propertyOccurrenceCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetPropertyOccurrenceCount(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> property, Span<uint> propertyOccurrenceCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPropertyOccurrenceCount(in property.GetPinnableReference(), ref propertyOccurrenceCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, IDWriteFontSet** filteredSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in properties.GetPinnableReference(), propertyCount, filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, ref ComPtr<TI0> filteredSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(in properties, propertyCount, (IDWriteFontSet**) filteredSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, ref IDWriteFontSet* filteredSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in properties.GetPinnableReference(), propertyCount, ref filteredSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetFirstFontResources<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFirstFontResources((IDWriteFontSet1**) filteredFontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFilteredFonts(properties, propertyCount, selectAnyProperty, (IDWriteFontSet1**) filteredFontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, IDWriteFontSet1** filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFonts(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, filteredFontSet);
    }

    /// <summary>To be documented.</summary>
    public static int GetFilteredFonts<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref ComPtr<TI0> filteredFontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFilteredFonts(in properties, propertyCount, selectAnyProperty, (IDWriteFontSet1**) filteredFontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFonts(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, ref IDWriteFontSet1* filteredFontSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFonts(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, ref filteredFontSet);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, Span<uint> actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(properties, propertyCount, selectAnyProperty, indices, maxIndexCount, ref actualIndexCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, Span<uint> indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(properties, propertyCount, selectAnyProperty, ref indices.GetPinnableReference(), maxIndexCount, actualIndexCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, Span<uint> indices, uint maxIndexCount, Span<uint> actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(properties, propertyCount, selectAnyProperty, ref indices.GetPinnableReference(), maxIndexCount, ref actualIndexCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, indices, maxIndexCount, actualIndexCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, uint* indices, uint maxIndexCount, Span<uint> actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, indices, maxIndexCount, ref actualIndexCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, Span<uint> indices, uint maxIndexCount, uint* actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, ref indices.GetPinnableReference(), maxIndexCount, actualIndexCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetFilteredFontIndices(this ComPtr<IDWriteFontSet2> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount, Silk.NET.Core.Bool32 selectAnyProperty, Span<uint> indices, uint maxIndexCount, Span<uint> actualIndexCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFilteredFontIndices(in properties.GetPinnableReference(), propertyCount, selectAnyProperty, ref indices.GetPinnableReference(), maxIndexCount, ref actualIndexCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, FontAxisRange* fontAxisRanges, uint maxFontAxisRangeCount, Span<uint> actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAxisRanges(fontAxisRanges, maxFontAxisRangeCount, ref actualFontAxisRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, Span<FontAxisRange> fontAxisRanges, uint maxFontAxisRangeCount, uint* actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAxisRanges(ref fontAxisRanges.GetPinnableReference(), maxFontAxisRangeCount, actualFontAxisRangeCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisRanges(this ComPtr<IDWriteFontSet2> thisVtbl, Span<FontAxisRange> fontAxisRanges, uint maxFontAxisRangeCount, Span<uint> actualFontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAxisRanges(ref fontAxisRanges.GetPinnableReference(), maxFontAxisRangeCount, ref actualFontAxisRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontResource<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref ComPtr<TI0> fontResource) where TI0 : unmanaged, IComVtbl<IDWriteFontResource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontResource(listIndex, (IDWriteFontResource**) fontResource.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFace<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl, uint listIndex, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(listIndex, (IDWriteFontFace5**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontSet2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
