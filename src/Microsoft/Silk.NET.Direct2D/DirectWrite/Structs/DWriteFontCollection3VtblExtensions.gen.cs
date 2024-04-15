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

public unsafe static class DWriteFontCollection3VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontCollection3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontCollection3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontFamilyCount(this ComPtr<IDWriteFontCollection3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFontCollection3> thisVtbl, uint index, IDWriteFontFamily** fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IDWriteFontCollection3> thisVtbl, uint index, ref IDWriteFontFamily* fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFamily** fontFamilyPtr = &fontFamily)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamilyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indexPtr = &index)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, indexPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* indexPtr = &index)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, indexPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (uint* indexPtr = &index)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (uint* indexPtr = &index)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, exists);
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, uint* index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, existsPtr);
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, ref uint index, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (uint* indexPtr = &index)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, exists);
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, ref uint index, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (uint* indexPtr = &index)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, existsPtr);
            }
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, IDWriteFontFace* fontFace, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, IDWriteFontFace* fontFace, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, fontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, ref IDWriteFontFace fontFace, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFacePtr, font);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, ref IDWriteFontFace fontFace, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFace* fontFacePtr = &fontFace)
        {
            fixed (IDWriteFont** fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFacePtr, fontPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontCollection3> thisVtbl, IDWriteFontSet** fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontSet**, int>)@this->LpVtbl[7])(@this, fontSet);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSet(this ComPtr<IDWriteFontCollection3> thisVtbl, ref IDWriteFontSet* fontSet)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontSet** fontSetPtr = &fontSet)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, IDWriteFontSet**, int>)@this->LpVtbl[7])(@this, fontSetPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValues, fontAxisValueCount, fontList);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontList2** fontListPtr = &fontList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValues, fontAxisValueCount, fontListPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValuesPtr, fontAxisValueCount, fontList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (IDWriteFontList2** fontListPtr = &fontList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyName, fontAxisValuesPtr, fontAxisValueCount, fontListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValues, fontAxisValueCount, fontList);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (IDWriteFontList2** fontListPtr = &fontList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValues, fontAxisValueCount, fontListPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValuesPtr, fontAxisValueCount, fontList);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* familyNamePtr = &familyName)
        {
            fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
            {
                fixed (IDWriteFontList2** fontListPtr = &fontList)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, char*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValuesPtr, fontAxisValueCount, fontListPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValues, fontAxisValueCount, fontList);
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (IDWriteFontList2** fontListPtr = &fontList)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValues, fontAxisValueCount, fontListPtr);
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValuesPtr, fontAxisValueCount, fontList);
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
        fixed (FontAxisValue* fontAxisValuesPtr = &fontAxisValues)
        {
            fixed (IDWriteFontList2** fontListPtr = &fontList)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, byte*, FontAxisValue*, uint, IDWriteFontList2**, int>)@this->LpVtbl[10])(@this, familyNamePtr, fontAxisValuesPtr, fontAxisValueCount, fontListPtr);
            }
        }
        SilkMarshal.Free((nint)familyNamePtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFamilyModel GetFontFamilyModel(this ComPtr<IDWriteFontCollection3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFamilyModel ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, FontFamilyModel>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void* GetExpirationEvent(this ComPtr<IDWriteFontCollection3> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        void* ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection3*, void*>)@this->LpVtbl[13])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontCollection3> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFamily<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, uint index, ref ComPtr<TI0> fontFamily) where TI0 : unmanaged, IComVtbl<IDWriteFontFamily>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFamily(index, (IDWriteFontFamily**) fontFamily.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, uint* index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(in familyName.GetPinnableReference(), index, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(in familyName.GetPinnableReference(), index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(in familyName.GetPinnableReference(), ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(in familyName.GetPinnableReference(), ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, uint* index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, index, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, Span<uint> index, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, ref index.GetPinnableReference(), exists);
    }

    /// <summary>To be documented.</summary>
    public static int FindFamilyName(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, Span<uint> index, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->FindFamilyName(familyName, ref index.GetPinnableReference(), ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFromFontFace<TI0, TI1>(this ComPtr<IDWriteFontCollection3> thisVtbl, ComPtr<TI0> fontFace, ref ComPtr<TI1> font) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFromFontFace((IDWriteFontFace*) fontFace.Handle, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, ComPtr<TI0> fontFace, ref IDWriteFont* font) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFromFontFace((IDWriteFontFace*) fontFace.Handle, ref font);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, Span<IDWriteFontFace> fontFace, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontFromFontFace(ref fontFace.GetPinnableReference(), font);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFromFontFace<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, ref IDWriteFontFace fontFace, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFromFontFace(ref fontFace, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFromFontFace(this ComPtr<IDWriteFontCollection3> thisVtbl, Span<IDWriteFontFace> fontFace, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontFromFontFace(ref fontFace.GetPinnableReference(), ref font);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSet<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, ref ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontSet((IDWriteFontSet**) fontSet.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(familyName, fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, ref fontList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in familyName.GetPinnableReference(), fontAxisValues, fontAxisValueCount, fontList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(in familyName, fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in familyName.GetPinnableReference(), fontAxisValues, fontAxisValueCount, ref fontList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in familyName.GetPinnableReference(), in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontList);
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(in familyName, in fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(in familyName.GetPinnableReference(), in fontAxisValues.GetPinnableReference(), fontAxisValueCount, ref fontList);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FontAxisValue* fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(familyName, fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, IDWriteFontList2** fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, fontList);
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FontAxisValue fontAxisValues, uint fontAxisValueCount, ref ComPtr<TI0> fontList) where TI0 : unmanaged, IComVtbl<IDWriteFontList2>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues, fontAxisValueCount, (IDWriteFontList2**) fontList.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontCollection3> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FontAxisValue> fontAxisValues, uint fontAxisValueCount, ref IDWriteFontList2* fontList)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetMatchingFonts(familyName, in fontAxisValues.GetPinnableReference(), fontAxisValueCount, ref fontList);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontCollection3> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
