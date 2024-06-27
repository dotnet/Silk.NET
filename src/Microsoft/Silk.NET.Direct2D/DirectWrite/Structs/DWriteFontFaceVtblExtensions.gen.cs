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

public unsafe static class DWriteFontFaceVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFaceType GetType(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontFaceType>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, uint* numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFilesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, ref uint numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFiles);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, ref uint numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFilesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIndex(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontSimulations>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFontFace> thisVtbl, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace> thisVtbl, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ushort GetGlyphCount(this ComPtr<IDWriteFontFace> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndicesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndices);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndicesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, exists);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, existsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFontTable(this ComPtr<IDWriteFontFace> thisVtbl, void* tableContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace> thisVtbl, ref T0 tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* tableContextPtr = &tableContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, void*, void>)@this->LpVtbl[13])(@this, tableContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderingMode* renderingModePtr = &renderingMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (RenderingMode* renderingModePtr = &renderingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingModePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFace> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles<TI0>(this ComPtr<IDWriteFontFace> thisVtbl, uint* numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, Span<uint> numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static int GetFiles<TI0>(this ComPtr<IDWriteFontFace> thisVtbl, ref uint numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(ref numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace> thisVtbl, Span<uint> numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), ref fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace> thisVtbl, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetMetrics(ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(codePoints, codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, glyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace> thisVtbl, Span<T0> tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFontTable(ref tableContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, RenderingMode* renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, renderingParams, ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, ref RenderingMode renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, ref renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, transform, ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFace> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
