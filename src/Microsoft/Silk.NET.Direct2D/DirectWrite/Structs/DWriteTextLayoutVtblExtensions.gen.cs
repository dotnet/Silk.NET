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

public unsafe static class DWriteTextLayoutVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTextAlignment(this ComPtr<IDWriteTextLayout> thisVtbl, TextAlignment textAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextAlignment, int>)@this->LpVtbl[3])(@this, textAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetParagraphAlignment(this ComPtr<IDWriteTextLayout> thisVtbl, ParagraphAlignment paragraphAlignment)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ParagraphAlignment, int>)@this->LpVtbl[4])(@this, paragraphAlignment);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetWordWrapping(this ComPtr<IDWriteTextLayout> thisVtbl, WordWrapping wordWrapping)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, WordWrapping, int>)@this->LpVtbl[5])(@this, wordWrapping);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetReadingDirection(this ComPtr<IDWriteTextLayout> thisVtbl, ReadingDirection readingDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ReadingDirection, int>)@this->LpVtbl[6])(@this, readingDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFlowDirection(this ComPtr<IDWriteTextLayout> thisVtbl, FlowDirection flowDirection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FlowDirection, int>)@this->LpVtbl[7])(@this, flowDirection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetIncrementalTabStop(this ComPtr<IDWriteTextLayout> thisVtbl, float incrementalTabStop)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)@this->LpVtbl[8])(@this, incrementalTabStop);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ref IDWriteInlineObject trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptions, trimmingSignPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSign);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ref IDWriteInlineObject trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
        {
            fixed (IDWriteInlineObject* trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject*, int>)@this->LpVtbl[9])(@this, trimmingOptionsPtr, trimmingSignPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod lineSpacingMethod, float lineSpacing, float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod, float, float, int>)@this->LpVtbl[10])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static TextAlignment GetTextAlignment(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        TextAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextAlignment>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ParagraphAlignment GetParagraphAlignment(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ParagraphAlignment ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ParagraphAlignment>)@this->LpVtbl[12])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static WordWrapping GetWordWrapping(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        WordWrapping ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, WordWrapping>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static ReadingDirection GetReadingDirection(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ReadingDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ReadingDirection>)@this->LpVtbl[14])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FlowDirection GetFlowDirection(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FlowDirection ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FlowDirection>)@this->LpVtbl[15])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetIncrementalTabStop(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)@this->LpVtbl[16])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, Trimming* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, Trimming* trimmingOptions, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptions, trimmingSignPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, ref Trimming trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSign);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, ref Trimming trimmingOptions, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Trimming* trimmingOptionsPtr = &trimmingOptions)
        {
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Trimming*, IDWriteInlineObject**, int>)@this->LpVtbl[17])(@this, trimmingOptionsPtr, trimmingSignPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baseline);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, ref float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* baselinePtr = &baseline)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacing, baselinePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* lineSpacingPtr = &lineSpacing)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baseline);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, ref float lineSpacing, ref float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* lineSpacingPtr = &lineSpacing)
        {
            fixed (float* baselinePtr = &baseline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethod, lineSpacingPtr, baselinePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baseline);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineSpacingMethod lineSpacingMethod, float* lineSpacing, ref float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
        {
            fixed (float* baselinePtr = &baseline)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacing, baselinePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
        {
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baseline);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineSpacingMethod lineSpacingMethod, ref float lineSpacing, ref float baseline)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineSpacingMethod* lineSpacingMethodPtr = &lineSpacingMethod)
        {
            fixed (float* lineSpacingPtr = &lineSpacing)
            {
                fixed (float* baselinePtr = &baseline)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineSpacingMethod*, float*, float*, int>)@this->LpVtbl[18])(@this, lineSpacingMethodPtr, lineSpacingPtr, baselinePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteTextLayout> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteTextLayout> thisVtbl, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection**, int>)@this->LpVtbl[19])(@this, fontCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyNameLength(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)@this->LpVtbl[20])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, char* fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, ref char fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, byte*, uint, int>)@this->LpVtbl[21])(@this, fontFamilyNamePtr, nameSize);
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetFontWeight(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontWeight>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetFontStyle(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStyle>)@this->LpVtbl[23])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetFontStretch(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStretch>)@this->LpVtbl[24])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetFontSize(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)@this->LpVtbl[25])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetLocaleNameLength(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, char* localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, uint, int>)@this->LpVtbl[27])(@this, localeName, nameSize);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, ref char localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, byte*, uint, int>)@this->LpVtbl[27])(@this, localeNamePtr, nameSize);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxWidth(this ComPtr<IDWriteTextLayout> thisVtbl, float maxWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)@this->LpVtbl[28])(@this, maxWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetMaxHeight(this ComPtr<IDWriteTextLayout> thisVtbl, float maxHeight)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)@this->LpVtbl[29])(@this, maxHeight);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontCollection(this ComPtr<IDWriteTextLayout> thisVtbl, IDWriteFontCollection* fontCollection, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollection, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontCollection(this ComPtr<IDWriteTextLayout> thisVtbl, ref IDWriteFontCollection fontCollection, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection*, TextRange, int>)@this->LpVtbl[30])(@this, fontCollectionPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* fontFamilyNamePtr = &fontFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyNamePtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, byte*, TextRange, int>)@this->LpVtbl[31])(@this, fontFamilyNamePtr, textRange);
        SilkMarshal.Free((nint)fontFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontWeight(this ComPtr<IDWriteTextLayout> thisVtbl, FontWeight fontWeight, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontWeight, TextRange, int>)@this->LpVtbl[32])(@this, fontWeight, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStyle(this ComPtr<IDWriteTextLayout> thisVtbl, FontStyle fontStyle, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStyle, TextRange, int>)@this->LpVtbl[33])(@this, fontStyle, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontStretch(this ComPtr<IDWriteTextLayout> thisVtbl, FontStretch fontStretch, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, FontStretch, TextRange, int>)@this->LpVtbl[34])(@this, fontStretch, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetFontSize(this ComPtr<IDWriteTextLayout> thisVtbl, float fontSize, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, TextRange, int>)@this->LpVtbl[35])(@this, fontSize, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, Silk.NET.Core.Bool32 hasUnderline, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[36])(@this, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, Silk.NET.Core.Bool32 hasStrikethrough, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Silk.NET.Core.Bool32, TextRange, int>)@this->LpVtbl[37])(@this, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, ref Silk.NET.Core.Native.IUnknown drawingEffect, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* drawingEffectPtr = &drawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Silk.NET.Core.Native.IUnknown*, TextRange, int>)@this->LpVtbl[38])(@this, drawingEffectPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, IDWriteInlineObject* inlineObject, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, ref IDWriteInlineObject inlineObject, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject* inlineObjectPtr = &inlineObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteInlineObject*, TextRange, int>)@this->LpVtbl[39])(@this, inlineObjectPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, IDWriteTypography* typography, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, ref IDWriteTypography typography, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTypography* typographyPtr = &typography)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteTypography*, TextRange, int>)@this->LpVtbl[40])(@this, typographyPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeName, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* localeNamePtr = &localeName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, char*, TextRange, int>)@this->LpVtbl[41])(@this, localeNamePtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, byte*, TextRange, int>)@this->LpVtbl[41])(@this, localeNamePtr, textRange);
        SilkMarshal.Free((nint)localeNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxWidth(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)@this->LpVtbl[42])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMaxHeight(this ComPtr<IDWriteTextLayout> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)@this->LpVtbl[43])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasUnderline, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasUnderline, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextRange* textRangePtr = &textRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderline, textRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref int hasUnderline, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* hasUnderlinePtr = &hasUnderline)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderlinePtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref int hasUnderline, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* hasUnderlinePtr = &hasUnderline)
        {
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[51])(@this, currentPosition, hasUnderlinePtr, textRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasStrikethrough, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasStrikethrough, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextRange* textRangePtr = &textRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethrough, textRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref int hasStrikethrough, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* hasStrikethroughPtr = &hasStrikethrough)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethroughPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref int hasStrikethrough, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* hasStrikethroughPtr = &hasStrikethrough)
        {
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, int*, TextRange*, int>)@this->LpVtbl[52])(@this, currentPosition, hasStrikethroughPtr, textRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextRange* textRangePtr = &textRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffect, textRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref Silk.NET.Core.Native.IUnknown* drawingEffect, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** drawingEffectPtr = &drawingEffect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffectPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref Silk.NET.Core.Native.IUnknown* drawingEffect, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown** drawingEffectPtr = &drawingEffect)
        {
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Native.IUnknown**, TextRange*, int>)@this->LpVtbl[53])(@this, currentPosition, drawingEffectPtr, textRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteInlineObject** inlineObject, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteInlineObject** inlineObject, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextRange* textRangePtr = &textRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObject, textRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteInlineObject* inlineObject, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject** inlineObjectPtr = &inlineObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObjectPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteInlineObject* inlineObject, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteInlineObject** inlineObjectPtr = &inlineObject)
        {
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, TextRange*, int>)@this->LpVtbl[54])(@this, currentPosition, inlineObjectPtr, textRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteTypography** typography, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRange);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteTypography** typography, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextRange* textRangePtr = &textRange)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typography, textRangePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteTypography* typography, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTypography** typographyPtr = &typography)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typographyPtr, textRange);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteTypography* typography, ref TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTypography** typographyPtr = &typography)
        {
            fixed (TextRange* textRangePtr = &textRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, TextRange*, int>)@this->LpVtbl[55])(@this, currentPosition, typographyPtr, textRangePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteTextLayout> thisVtbl, void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, renderer, originX, originY);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteTextLayout> thisVtbl, void* clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextRenderer* rendererPtr = &renderer)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContext, rendererPtr, originX, originY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteTextLayout> thisVtbl, ref T0 clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContextPtr, renderer, originX, originY);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0>(this ComPtr<IDWriteTextLayout> thisVtbl, ref T0 clientDrawingContext, ref IDWriteTextRenderer renderer, float originX, float originY) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void* clientDrawingContextPtr = &clientDrawingContext)
        {
            fixed (IDWriteTextRenderer* rendererPtr = &renderer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)@this->LpVtbl[58])(@this, clientDrawingContextPtr, rendererPtr, originX, originY);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, LineMetrics* lineMetrics, uint maxLineCount, uint* actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, LineMetrics* lineMetrics, uint maxLineCount, ref uint actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualLineCountPtr = &actualLineCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetrics, maxLineCount, actualLineCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineMetrics lineMetrics, uint maxLineCount, uint* actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineMetrics* lineMetricsPtr = &lineMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetricsPtr, maxLineCount, actualLineCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref LineMetrics lineMetrics, uint maxLineCount, ref uint actualLineCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (LineMetrics* lineMetricsPtr = &lineMetrics)
        {
            fixed (uint* actualLineCountPtr = &actualLineCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, LineMetrics*, uint, uint*, int>)@this->LpVtbl[59])(@this, lineMetricsPtr, maxLineCount, actualLineCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, TextMetrics* textMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref TextMetrics textMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TextMetrics* textMetricsPtr = &textMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, TextMetrics*, int>)@this->LpVtbl[60])(@this, textMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetOverhangMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, OverhangMetrics* overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangs);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetOverhangMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref OverhangMetrics overhangs)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (OverhangMetrics* overhangsPtr = &overhangs)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, OverhangMetrics*, int>)@this->LpVtbl[61])(@this, overhangsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ClusterMetrics* clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ClusterMetrics* clusterMetrics, uint maxClusterCount, ref uint actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualClusterCountPtr = &actualClusterCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetrics, maxClusterCount, actualClusterCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref ClusterMetrics clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClusterMetrics* clusterMetricsPtr = &clusterMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetricsPtr, maxClusterCount, actualClusterCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ref ClusterMetrics clusterMetrics, uint maxClusterCount, ref uint actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ClusterMetrics* clusterMetricsPtr = &clusterMetrics)
        {
            fixed (uint* actualClusterCountPtr = &actualClusterCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ClusterMetrics*, uint, uint*, int>)@this->LpVtbl[62])(@this, clusterMetricsPtr, maxClusterCount, actualClusterCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int DetermineMinWidth(this ComPtr<IDWriteTextLayout> thisVtbl, float* minWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float*, int>)@this->LpVtbl[63])(@this, minWidth);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int DetermineMinWidth(this ComPtr<IDWriteTextLayout> thisVtbl, ref float minWidth)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* minWidthPtr = &minWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float*, int>)@this->LpVtbl[63])(@this, minWidthPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, int* isInside, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInside, hitTestMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, ref int isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isInsidePtr = &isInside)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInsidePtr, hitTestMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, ref int isInside, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isInsidePtr = &isInside)
        {
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHit, isInsidePtr, hitTestMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, ref int isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isTrailingHitPtr = &isTrailingHit)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInside, hitTestMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, ref int isTrailingHit, int* isInside, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isTrailingHitPtr = &isTrailingHit)
        {
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInside, hitTestMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, ref int isTrailingHit, ref int isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isTrailingHitPtr = &isTrailingHit)
        {
            fixed (int* isInsidePtr = &isInside)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInsidePtr, hitTestMetrics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, ref int isTrailingHit, ref int isInside, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isTrailingHitPtr = &isTrailingHit)
        {
            fixed (int* isInsidePtr = &isInside)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, int*, int*, HitTestMetrics*, int>)@this->LpVtbl[64])(@this, pointX, pointY, isTrailingHitPtr, isInsidePtr, hitTestMetricsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointY, hitTestMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, ref float pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointYPtr = &pointY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointYPtr, hitTestMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, ref float pointY, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointYPtr = &pointY)
        {
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointX, pointYPtr, hitTestMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, float* pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointXPtr = &pointX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointY, hitTestMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, float* pointY, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointXPtr = &pointX)
        {
            fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointY, hitTestMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, ref float pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointXPtr = &pointX)
        {
            fixed (float* pointYPtr = &pointY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointYPtr, hitTestMetrics);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, ref float pointX, ref float pointY, ref HitTestMetrics hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* pointXPtr = &pointX)
        {
            fixed (float* pointYPtr = &pointY)
            {
                fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, Silk.NET.Core.Bool32, float*, float*, HitTestMetrics*, int>)@this->LpVtbl[65])(@this, textPosition, isTrailingHit, pointXPtr, pointYPtr, hitTestMetricsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, ref uint actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualHitTestMetricsCountPtr = &actualHitTestMetricsCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, ref HitTestMetrics hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetricsPtr, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, ref HitTestMetrics hitTestMetrics, uint maxHitTestMetricsCount, ref uint actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (HitTestMetrics* hitTestMetricsPtr = &hitTestMetrics)
        {
            fixed (uint* actualHitTestMetricsCountPtr = &actualHitTestMetricsCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, HitTestMetrics*, uint, uint*, int>)@this->LpVtbl[66])(@this, textPosition, textLength, originX, originY, hitTestMetricsPtr, maxHitTestMetricsCount, actualHitTestMetricsCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteTextLayout> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetTrimming(trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Trimming* trimmingOptions, Span<IDWriteInlineObject> trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTrimming(trimmingOptions, ref trimmingSign.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Trimming> trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTrimming(in trimmingOptions.GetPinnableReference(), trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static int SetTrimming<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Trimming trimmingOptions, ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetTrimming(in trimmingOptions, (IDWriteInlineObject*) trimmingSign.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Trimming> trimmingOptions, Span<IDWriteInlineObject> trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTrimming(in trimmingOptions.GetPinnableReference(), ref trimmingSign.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, Trimming* trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTrimming(trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, Span<Trimming> trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTrimming(ref trimmingOptions.GetPinnableReference(), trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static int GetTrimming<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ref Trimming trimmingOptions, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTrimming(ref trimmingOptions, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTrimming(this ComPtr<IDWriteTextLayout> thisVtbl, Span<Trimming> trimmingOptions, ref IDWriteInlineObject* trimmingSign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTrimming(ref trimmingOptions.GetPinnableReference(), ref trimmingSign);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, float* lineSpacing, Span<float> baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(lineSpacingMethod, lineSpacing, ref baseline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, Span<float> lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(lineSpacingMethod, ref lineSpacing.GetPinnableReference(), baseline);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, LineSpacingMethod* lineSpacingMethod, Span<float> lineSpacing, Span<float> baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(lineSpacingMethod, ref lineSpacing.GetPinnableReference(), ref baseline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineSpacingMethod> lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(ref lineSpacingMethod.GetPinnableReference(), lineSpacing, baseline);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineSpacingMethod> lineSpacingMethod, float* lineSpacing, Span<float> baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(ref lineSpacingMethod.GetPinnableReference(), lineSpacing, ref baseline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineSpacingMethod> lineSpacingMethod, Span<float> lineSpacing, float* baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(ref lineSpacingMethod.GetPinnableReference(), ref lineSpacing.GetPinnableReference(), baseline);
    }

    /// <summary>To be documented.</summary>
    public static int GetLineSpacing(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineSpacingMethod> lineSpacingMethod, Span<float> lineSpacing, Span<float> baseline)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineSpacing(ref lineSpacingMethod.GetPinnableReference(), ref lineSpacing.GetPinnableReference(), ref baseline.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontCollection<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, Span<char> fontFamilyName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontFamilyName(ref fontFamilyName.GetPinnableReference(), nameSize);
    }

    /// <summary>To be documented.</summary>
    public static int GetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, Span<char> localeName, uint nameSize)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLocaleName(ref localeName.GetPinnableReference(), nameSize);
    }

    /// <summary>To be documented.</summary>
    public static int SetFontCollection<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ComPtr<TI0> fontCollection, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetFontCollection((IDWriteFontCollection*) fontCollection.Handle, textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetFontCollection(this ComPtr<IDWriteTextLayout> thisVtbl, Span<IDWriteFontCollection> fontCollection, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFontCollection(ref fontCollection.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetFontFamilyName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> fontFamilyName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetFontFamilyName(in fontFamilyName.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetDrawingEffect<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ComPtr<TI0> drawingEffect, TextRange textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetDrawingEffect((Silk.NET.Core.Native.IUnknown*) drawingEffect.Handle, textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> drawingEffect, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetDrawingEffect(ref drawingEffect.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetInlineObject<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ComPtr<TI0> inlineObject, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetInlineObject((IDWriteInlineObject*) inlineObject.Handle, textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, Span<IDWriteInlineObject> inlineObject, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetInlineObject(ref inlineObject.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetTypography<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ComPtr<TI0> typography, TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetTypography((IDWriteTypography*) typography.Handle, textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, Span<IDWriteTypography> typography, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetTypography(ref typography.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int SetLocaleName(this ComPtr<IDWriteTextLayout> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> localeName, TextRange textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetLocaleName(in localeName.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasUnderline, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnderline(currentPosition, hasUnderline, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Span<int> hasUnderline, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnderline(currentPosition, ref hasUnderline.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnderline(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Span<int> hasUnderline, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnderline(currentPosition, ref hasUnderline.GetPinnableReference(), ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, int* hasStrikethrough, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStrikethrough(currentPosition, hasStrikethrough, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Span<int> hasStrikethrough, TextRange* textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStrikethrough(currentPosition, ref hasStrikethrough.GetPinnableReference(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static int GetStrikethrough(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Span<int> hasStrikethrough, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetStrikethrough(currentPosition, ref hasStrikethrough.GetPinnableReference(), ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> drawingEffect, TextRange* textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDrawingEffect(currentPosition, (Silk.NET.Core.Native.IUnknown**) drawingEffect.GetAddressOf(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, Silk.NET.Core.Native.IUnknown** drawingEffect, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDrawingEffect(currentPosition, drawingEffect, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDrawingEffect<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> drawingEffect, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetDrawingEffect(currentPosition, (Silk.NET.Core.Native.IUnknown**) drawingEffect.GetAddressOf(), ref textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDrawingEffect(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref Silk.NET.Core.Native.IUnknown* drawingEffect, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDrawingEffect(currentPosition, ref drawingEffect, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> inlineObject, TextRange* textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInlineObject(currentPosition, (IDWriteInlineObject**) inlineObject.GetAddressOf(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteInlineObject** inlineObject, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInlineObject(currentPosition, inlineObject, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInlineObject<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> inlineObject, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInlineObject(currentPosition, (IDWriteInlineObject**) inlineObject.GetAddressOf(), ref textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInlineObject(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteInlineObject* inlineObject, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInlineObject(currentPosition, ref inlineObject, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> typography, TextRange* textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypography(currentPosition, (IDWriteTypography**) typography.GetAddressOf(), textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, IDWriteTypography** typography, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypography(currentPosition, typography, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTypography<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref ComPtr<TI0> typography, ref TextRange textRange) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetTypography(currentPosition, (IDWriteTypography**) typography.GetAddressOf(), ref textRange);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTypography(this ComPtr<IDWriteTextLayout> thisVtbl, uint currentPosition, ref IDWriteTypography* typography, Span<TextRange> textRange)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTypography(currentPosition, ref typography, ref textRange.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, void* clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY) where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw(this ComPtr<IDWriteTextLayout> thisVtbl, void* clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(clientDrawingContext, ref renderer.GetPinnableReference(), originX, originY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Draw<T0>(this ComPtr<IDWriteTextLayout> thisVtbl, Span<T0> clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), renderer, originX, originY);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0, TI0>(this ComPtr<IDWriteTextLayout> thisVtbl, ref T0 clientDrawingContext, ComPtr<TI0> renderer, float originX, float originY) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteTextRenderer>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->Draw(ref clientDrawingContext, (IDWriteTextRenderer*) renderer.Handle, originX, originY);
    }

    /// <summary>To be documented.</summary>
    public static int Draw<T0>(this ComPtr<IDWriteTextLayout> thisVtbl, Span<T0> clientDrawingContext, Span<IDWriteTextRenderer> renderer, float originX, float originY) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->Draw(ref clientDrawingContext.GetPinnableReference(), ref renderer.GetPinnableReference(), originX, originY);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, LineMetrics* lineMetrics, uint maxLineCount, Span<uint> actualLineCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineMetrics(lineMetrics, maxLineCount, ref actualLineCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineMetrics> lineMetrics, uint maxLineCount, uint* actualLineCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineMetrics(ref lineMetrics.GetPinnableReference(), maxLineCount, actualLineCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetLineMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<LineMetrics> lineMetrics, uint maxLineCount, Span<uint> actualLineCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineMetrics(ref lineMetrics.GetPinnableReference(), maxLineCount, ref actualLineCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<TextMetrics> textMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMetrics(ref textMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetOverhangMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<OverhangMetrics> overhangs)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetOverhangMetrics(ref overhangs.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, ClusterMetrics* clusterMetrics, uint maxClusterCount, Span<uint> actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClusterMetrics(clusterMetrics, maxClusterCount, ref actualClusterCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<ClusterMetrics> clusterMetrics, uint maxClusterCount, uint* actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClusterMetrics(ref clusterMetrics.GetPinnableReference(), maxClusterCount, actualClusterCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetClusterMetrics(this ComPtr<IDWriteTextLayout> thisVtbl, Span<ClusterMetrics> clusterMetrics, uint maxClusterCount, Span<uint> actualClusterCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClusterMetrics(ref clusterMetrics.GetPinnableReference(), maxClusterCount, ref actualClusterCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int DetermineMinWidth(this ComPtr<IDWriteTextLayout> thisVtbl, Span<float> minWidth)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->DetermineMinWidth(ref minWidth.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, int* isInside, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, isTrailingHit, isInside, ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, Span<int> isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, isTrailingHit, ref isInside.GetPinnableReference(), hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, int* isTrailingHit, Span<int> isInside, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, isTrailingHit, ref isInside.GetPinnableReference(), ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, Span<int> isTrailingHit, int* isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, ref isTrailingHit.GetPinnableReference(), isInside, hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, Span<int> isTrailingHit, int* isInside, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, ref isTrailingHit.GetPinnableReference(), isInside, ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, Span<int> isTrailingHit, Span<int> isInside, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, ref isTrailingHit.GetPinnableReference(), ref isInside.GetPinnableReference(), hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static int HitTestPoint(this ComPtr<IDWriteTextLayout> thisVtbl, float pointX, float pointY, Span<int> isTrailingHit, Span<int> isInside, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestPoint(pointX, pointY, ref isTrailingHit.GetPinnableReference(), ref isInside.GetPinnableReference(), ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, float* pointY, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, pointX, pointY, ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, Span<float> pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, pointX, ref pointY.GetPinnableReference(), hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, float* pointX, Span<float> pointY, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, pointX, ref pointY.GetPinnableReference(), ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, Span<float> pointX, float* pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, ref pointX.GetPinnableReference(), pointY, hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, Span<float> pointX, float* pointY, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, ref pointX.GetPinnableReference(), pointY, ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, Span<float> pointX, Span<float> pointY, HitTestMetrics* hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, ref pointX.GetPinnableReference(), ref pointY.GetPinnableReference(), hitTestMetrics);
    }

    /// <summary>To be documented.</summary>
    public static int HitTestTextPosition(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, Silk.NET.Core.Bool32 isTrailingHit, Span<float> pointX, Span<float> pointY, Span<HitTestMetrics> hitTestMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextPosition(textPosition, isTrailingHit, ref pointX.GetPinnableReference(), ref pointY.GetPinnableReference(), ref hitTestMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, HitTestMetrics* hitTestMetrics, uint maxHitTestMetricsCount, Span<uint> actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextRange(textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, ref actualHitTestMetricsCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, Span<HitTestMetrics> hitTestMetrics, uint maxHitTestMetricsCount, uint* actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextRange(textPosition, textLength, originX, originY, ref hitTestMetrics.GetPinnableReference(), maxHitTestMetricsCount, actualHitTestMetricsCount);
    }

    /// <summary>To be documented.</summary>
    public static int HitTestTextRange(this ComPtr<IDWriteTextLayout> thisVtbl, uint textPosition, uint textLength, float originX, float originY, Span<HitTestMetrics> hitTestMetrics, uint maxHitTestMetricsCount, Span<uint> actualHitTestMetricsCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HitTestTextRange(textPosition, textLength, originX, originY, ref hitTestMetrics.GetPinnableReference(), maxHitTestMetricsCount, ref actualHitTestMetricsCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteTextLayout> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
