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

public unsafe static class DWriteFontResourceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFile(this ComPtr<IDWriteFontResource> thisVtbl, IDWriteFontFile** fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)@this->LpVtbl[3])(@this, fontFile);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFile(this ComPtr<IDWriteFontResource> thisVtbl, ref IDWriteFontFile* fontFile)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, IDWriteFontFile**, int>)@this->LpVtbl[3])(@this, fontFilePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFaceIndex(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontAxisCount(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDefaultFontAxisValues(this ComPtr<IDWriteFontResource> thisVtbl, FontAxisValue* fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)@this->LpVtbl[6])(@this, fontAxisValues, fontAxisValueCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDefaultFontAxisValues(this ComPtr<IDWriteFontResource> thisVtbl, ref FontAxisValue fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisValue*, uint, int>)@this->LpVtbl[6])(@this, fontAxisValuesPtr, fontAxisValueCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontAxisRanges(this ComPtr<IDWriteFontResource> thisVtbl, FontAxisRange* fontAxisRanges, uint fontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRanges, fontAxisRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisRanges(this ComPtr<IDWriteFontResource> thisVtbl, ref FontAxisRange fontAxisRanges, uint fontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangesPtr = &fontAxisRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontAxisRange*, uint, int>)@this->LpVtbl[7])(@this, fontAxisRangesPtr, fontAxisRangeCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontAxisAttributes GetFontAxisAttributes(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex)
    {
        var @this = thisVtbl.Handle;
        FontAxisAttributes ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, FontAxisAttributes>)@this->LpVtbl[8])(@this, axisIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, axisIndex, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)@this->LpVtbl[9])(@this, axisIndex, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetAxisValueNameCount(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint>)@this->LpVtbl[10])(@this, axisIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRange, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRange, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangePtr = &fontAxisRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRangePtr, names);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisRange* fontAxisRangePtr = &fontAxisRange)
        {
            fixed (IDWriteLocalizedStrings** namesPtr = &names)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, uint, uint, FontAxisRange*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[11])(@this, axisIndex, axisValueIndex, fontAxisRangePtr, namesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVariations(this ComPtr<IDWriteFontResource> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, Silk.NET.Core.Bool32>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFace5* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFacePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFace);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFace5* fontFace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (IDWriteFontFace5** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFace5**, int>)@this->LpVtbl[13])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFacePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFaceReference1* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference1** fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFaceReference);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFaceReference1* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (IDWriteFontFaceReference1** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontResource*, FontSimulations, FontAxisValue*, uint, IDWriteFontFaceReference1**, int>)@this->LpVtbl[14])(@this, fontSimulations, fontAxisValuesPtr, fontAxisValueCount, fontFaceReferencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontResource> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFile<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFile((IDWriteFontFile**) fontFile.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetDefaultFontAxisValues(this ComPtr<IDWriteFontResource> thisVtbl, Span<FontAxisValue> fontAxisValues, uint fontAxisValueCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDefaultFontAxisValues(ref fontAxisValues.GetPinnableReference(), fontAxisValueCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontAxisRanges(this ComPtr<IDWriteFontResource> thisVtbl, Span<FontAxisRange> fontAxisRanges, uint fontAxisRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontAxisRanges(ref fontAxisRanges.GetPinnableReference(), fontAxisRangeCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetAxisNames<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAxisNames(axisIndex, (IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, FontAxisRange* fontAxisRange, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAxisValueNames(axisIndex, axisValueIndex, fontAxisRange, (IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, Span<FontAxisRange> fontAxisRange, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAxisValueNames(axisIndex, axisValueIndex, ref fontAxisRange.GetPinnableReference(), names);
    }

    /// <summary>To be documented.</summary>
    public static int GetAxisValueNames<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, ref FontAxisRange fontAxisRange, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetAxisValueNames(axisIndex, axisValueIndex, ref fontAxisRange, (IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAxisValueNames(this ComPtr<IDWriteFontResource> thisVtbl, uint axisIndex, uint axisValueIndex, Span<FontAxisRange> fontAxisRange, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAxisValueNames(axisIndex, axisValueIndex, ref fontAxisRange.GetPinnableReference(), ref names);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(fontSimulations, fontAxisValues, fontAxisValueCount, (IDWriteFontFace5**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, IDWriteFontFace5** fontFace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFace(fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontFace);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFace<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace5>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFace(fontSimulations, in fontAxisValues, fontAxisValueCount, (IDWriteFontFace5**) fontFace.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFace(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFace5* fontFace)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFace(fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, ref fontFace);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFaceReference(fontSimulations, fontAxisValues, fontAxisValueCount, (IDWriteFontFaceReference1**) fontFaceReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, IDWriteFontFaceReference1** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFaceReference(fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontFaceReference);
    }

    /// <summary>To be documented.</summary>
    public static int CreateFontFaceReference<TI0>(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference1>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->CreateFontFaceReference(fontSimulations, in fontAxisValues, fontAxisValueCount, (IDWriteFontFaceReference1**) fontFaceReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int CreateFontFaceReference(this ComPtr<IDWriteFontResource> thisVtbl, FontSimulations fontSimulations, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, ref IDWriteFontFaceReference1* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->CreateFontFaceReference(fontSimulations, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, ref fontFaceReference);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontResource> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
