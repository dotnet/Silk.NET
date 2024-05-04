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

public unsafe static class DWriteFontFallback1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFallback1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFallback1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* scalePtr = &scale)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* baseFamilyNamePtr = &baseFamilyName)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (float* scalePtr = &scale)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
            }
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
            }
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
            }
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
        fixed (uint* mappedLengthPtr = &mappedLength)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                }
            }
        }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSource, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (float* scalePtr = &scale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFont** mappedFontPtr = &mappedFont)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            fixed (uint* mappedLengthPtr = &mappedLength)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollection, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                    }
                }
            }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    fixed (uint* mappedLengthPtr = &mappedLength)
                    {
                        fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                        {
                            fixed (float* scalePtr = &scale)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, char*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                            }
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (float* scalePtr = &scale)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scalePtr);
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scale);
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLength, mappedFontPtr, scalePtr);
                    }
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scale);
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, IDWriteFont** mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (float* scalePtr = &scale)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFont, scalePtr);
                    }
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scale);
                    }
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteTextAnalysisSource* analysisSourcePtr = &analysisSource)
        {
            fixed (IDWriteFontCollection* baseFontCollectionPtr = &baseFontCollection)
            {
        var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                fixed (uint* mappedLengthPtr = &mappedLength)
                {
                    fixed (IDWriteFont** mappedFontPtr = &mappedFont)
                    {
                        fixed (float* scalePtr = &scale)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallback1*, IDWriteTextAnalysisSource*, uint, uint, IDWriteFontCollection*, byte*, FontWeight, FontStyle, FontStretch, uint*, IDWriteFont**, float*, int>)@this->LpVtbl[3])(@this, analysisSourcePtr, textPosition, textLength, baseFontCollectionPtr, baseFamilyNamePtr, baseWeight, baseStyle, baseStretch, mappedLengthPtr, mappedFontPtr, scalePtr);
                        }
                    }
                }
        SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1, TI2>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI2> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI2>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ComPtr<TI1> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, IDWriteTextAnalysisSource* analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(analysisSource, textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ComPtr<TI0> analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters((IDWriteTextAnalysisSource*) analysisSource.Handle, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0, TI1>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI1> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, IDWriteFontCollection* baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ComPtr<TI0> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref IDWriteFont* mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, (IDWriteFontCollection*) baseFontCollection.Handle, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, ref mappedFont, ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, in baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), in baseFamilyName.GetPinnableReference(), baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, uint* mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, mappedLength, ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, float* scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, IDWriteFont** mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int MapCharacters<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl, ref IDWriteTextAnalysisSource analysisSource, uint textPosition, uint textLength, ref IDWriteFontCollection baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, ref uint mappedLength, ref ComPtr<TI0> mappedFont, ref float scale) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->MapCharacters(ref analysisSource, textPosition, textLength, ref baseFontCollection, baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength, (IDWriteFont**) mappedFont.GetAddressOf(), ref scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, float* scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, scale);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int MapCharacters(this ComPtr<IDWriteFontFallback1> thisVtbl, Span<IDWriteTextAnalysisSource> analysisSource, uint textPosition, uint textLength, Span<IDWriteFontCollection> baseFontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, FontWeight baseWeight, FontStyle baseStyle, FontStretch baseStretch, Span<uint> mappedLength, ref IDWriteFont* mappedFont, Span<float> scale)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->MapCharacters(ref analysisSource.GetPinnableReference(), textPosition, textLength, ref baseFontCollection.GetPinnableReference(), baseFamilyName, baseWeight, baseStyle, baseStretch, ref mappedLength.GetPinnableReference(), ref mappedFont, ref scale.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFallback1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
