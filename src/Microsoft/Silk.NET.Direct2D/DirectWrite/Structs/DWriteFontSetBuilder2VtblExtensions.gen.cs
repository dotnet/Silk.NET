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

public unsafe static class DWriteFontSetBuilder2VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontSetBuilder2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontSetBuilder2> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFaceReference fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference* fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFaceReference*, int>)@this->LpVtbl[4])(@this, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontSet fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet* fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet*, int>)@this->LpVtbl[5])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet** fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontSet**, int>)@this->LpVtbl[6])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFontFile(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, int>)@this->LpVtbl[7])(@this, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontProperty* propertiesPtr = &properties)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, propertiesPtr, propertyCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, properties, propertyCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
        {
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, propertiesPtr, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, propertiesPtr, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, properties, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                fixed (FontProperty* propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFile, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, propertiesPtr, propertyCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontProperty* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, propertiesPtr, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, properties, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
            {
                fixed (FontProperty* propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, propertiesPtr, propertyCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (FontProperty* propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, propertiesPtr, propertyCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, properties, propertyCount);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref IDWriteFontFile fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile* fontFilePtr = &fontFile)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
                {
                    fixed (FontProperty* propertiesPtr = &properties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontSetBuilder2*, IDWriteFontFile*, uint, FontSimulations, FontAxisValue*, uint, FontAxisRange*, uint, FontProperty*, uint, int>)@this->LpVtbl[8])(@this, fontFilePtr, fontFaceIndex, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontAxisRangesPtr, fontAxisRangeCount, propertiesPtr, propertyCount);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontFaceReference((IDWriteFontFaceReference*) fontFaceReference.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFaceReference(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFaceReference> fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontFaceReference(ref fontFaceReference.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontSet((IDWriteFontSet*) fontSet.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontSet(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontSet> fontSet)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontSet(ref fontSet.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontSet<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ref ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontSet((IDWriteFontSet**) fontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFontFile((IDWriteFontFile*) fontFile.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int AddFontFile(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFontFile(ref fontFile.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges, fontAxisRangeCount, in properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, in fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, in fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, in fontAxisValues, fontAxisValueCount, in fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, IDWriteFontFile* fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(fontFile, fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static int AddFont<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, ComPtr<TI0> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisRange fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontProperty properties, uint propertyCount) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->AddFont((IDWriteFontFile*) fontFile.Handle, fontFaceIndex, fontSimulations, in fontAxisValues, fontAxisValueCount, in fontAxisRanges, fontAxisRangeCount, in properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, fontAxisValues, fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisRange* fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontAxisRanges, fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontProperty* properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, properties, propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static int AddFont(this ComPtr<IDWriteFontSetBuilder2> thisVtbl, Span<IDWriteFontFile> fontFile, uint fontFaceIndex, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontProperty> properties, uint propertyCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AddFont(ref fontFile.GetPinnableReference(), fontFaceIndex, fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, in fontAxisRanges.GetPinnableReference(), fontAxisRangeCount, in properties.GetPinnableReference(), propertyCount);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontSetBuilder2> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
