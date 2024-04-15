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

public unsafe static class DWriteFontFace4VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFaceType GetType(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontFaceType>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, uint* numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFilesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, ref uint numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFiles);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, ref uint numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFilesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIndex(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontSimulations>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ushort GetGlyphCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndicesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndices);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndicesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, exists);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, ref int exists)
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
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, existsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, void* tableContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref T0 tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* tableContextPtr = &tableContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[13])(@this, tableContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
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
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderingMode* renderingModePtr = &renderingMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (RenderingMode* renderingModePtr = &renderingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingModePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCaretMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, CaretMetrics* caretMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetCaretMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, ref CaretMetrics caretMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (CaretMetrics* caretMetricsPtr = &caretMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualRangeCountPtr = &actualRangeCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMonospacedFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvancesPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvances, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvancesPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustmentsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustments);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustmentsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasKerningPairs(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ref ushort verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndicesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndices);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ref ushort verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
        {
            fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndicesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsColorFont(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Silk.NET.Core.Bool32>)@this->LpVtbl[30])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetColorPaletteCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[31])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetPaletteEntryCount(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint>)@this->LpVtbl[32])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPaletteEntries(this ComPtr<IDWriteFontFace4> thisVtbl, uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Silk.NET.DXGI.D3Dcolorvalue* paletteEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntries);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries(this ComPtr<IDWriteFontFace4> thisVtbl, uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, ref Silk.NET.DXGI.D3Dcolorvalue paletteEntries)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.DXGI.D3Dcolorvalue* paletteEntriesPtr = &paletteEntries)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, uint, uint, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[33])(@this, colorPaletteIndex, firstEntryIndex, entryCount, paletteEntriesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteFontFaceReference** fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReference);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFaceReference(this ComPtr<IDWriteFontFace4> thisVtbl, ref IDWriteFontFaceReference* fontFaceReference)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteFontFaceReference**, int>)@this->LpVtbl[35])(@this, fontFaceReferencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetPanose(this ComPtr<IDWriteFontFace4> thisVtbl, Panose* panose)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Panose*, void>)@this->LpVtbl[36])(@this, panose);
    }

    /// <summary>To be documented.</summary>
    public static void GetPanose(this ComPtr<IDWriteFontFace4> thisVtbl, ref Panose panose)
    {
        var @this = thisVtbl.Handle;
        fixed (Panose* panosePtr = &panose)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, Panose*, void>)@this->LpVtbl[36])(@this, panosePtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static FontWeight GetWeight(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontWeight ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontWeight>)@this->LpVtbl[37])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStretch GetStretch(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStretch ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStretch>)@this->LpVtbl[38])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontStyle GetStyle(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, FontStyle>)@this->LpVtbl[39])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFace4> thisVtbl, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[40])(@this, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFontFace4> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFaceNames(this ComPtr<IDWriteFontFace4> thisVtbl, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[41])(@this, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStrings, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStringsPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** informationalStringsPtr = &informationalStrings)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, InformationalStringID, IDWriteLocalizedStrings**, int*, int>)@this->LpVtbl[42])(@this, informationalStringID, informationalStringsPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasCharacter(this ComPtr<IDWriteFontFace4> thisVtbl, uint unicodeValue)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[43])(@this, unicodeValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsCharacterLocal(this ComPtr<IDWriteFontFace4> thisVtbl, uint unicodeValue)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, uint, Silk.NET.Core.Bool32>)@this->LpVtbl[45])(@this, unicodeValue);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsGlyphLocal(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, Silk.NET.Core.Bool32>)@this->LpVtbl[46])(@this, glyphId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isLocalPtr = &isLocal)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, characters, characterCount, enqueueIfNotLocal, isLocalPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* charactersPtr = &characters)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char* charactersPtr = &characters)
        {
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, char*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocalPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, byte*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocal);
        SilkMarshal.Free((nint)charactersPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        var charactersPtr = (byte*) SilkMarshal.StringToPtr(characters, NativeStringEncoding.UTF8);
        fixed (int* isLocalPtr = &isLocal)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, byte*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[47])(@this, charactersPtr, characterCount, enqueueIfNotLocal, isLocalPtr);
        }
        SilkMarshal.Free((nint)charactersPtr);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocal);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* isLocalPtr = &isLocal)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndices, glyphCount, enqueueIfNotLocal, isLocalPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndicesPtr, glyphCount, enqueueIfNotLocal, isLocal);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, ref int isLocal)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* isLocalPtr = &isLocal)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort*, uint, Silk.NET.Core.Bool32, int*, int>)@this->LpVtbl[48])(@this, glyphIndicesPtr, glyphCount, enqueueIfNotLocal, isLocalPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static GlyphImageFormats GetGlyphImageFormats(this ComPtr<IDWriteFontFace4> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        GlyphImageFormats ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, GlyphImageFormats>)@this->LpVtbl[50])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, void** glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContext);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, GlyphImageData* glyphData, ref void* glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** glyphDataContextPtr = &glyphDataContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphData, glyphDataContextPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, ref GlyphImageData glyphData, void** glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphImageData* glyphDataPtr = &glyphData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphDataPtr, glyphDataContext);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, ref GlyphImageData glyphData, ref void* glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphImageData* glyphDataPtr = &glyphData)
        {
            fixed (void** glyphDataContextPtr = &glyphDataContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, ushort, uint, GlyphImageFormats, GlyphImageData*, void**, int>)@this->LpVtbl[51])(@this, glyphId, pixelsPerEm, glyphImageFormat, glyphDataPtr, glyphDataContextPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, void* glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseGlyphImageData<T0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref T0 glyphDataContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* glyphDataContextPtr = &glyphDataContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace4*, void*, void>)@this->LpVtbl[52])(@this, glyphDataContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace4> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, uint* numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, Span<uint> numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static int GetFiles<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref uint numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(ref numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace4> thisVtbl, Span<uint> numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), ref fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetMetrics(ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(codePoints, codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, glyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace4> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace4> thisVtbl, Span<T0> tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFontTable(ref tableContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, RenderingMode* renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, renderingParams, ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, ref RenderingMode renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, ref renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, transform, ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static void GetCaretMetrics(this ComPtr<IDWriteFontFace4> thisVtbl, Span<CaretMetrics> caretMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCaretMetrics(ref caretMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, unicodeRanges, ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), actualRangeCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFontFace4> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace4> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, glyphIndices, ref glyphAdvanceAdjustments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvanceAdjustments);
    }

    /// <summary>To be documented.</summary>
    public static int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvanceAdjustments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, Span<ushort> verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, nominalGlyphIndices, ref verticalGlyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, in nominalGlyphIndices.GetPinnableReference(), verticalGlyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace4> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> nominalGlyphIndices, Span<ushort> verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, in nominalGlyphIndices.GetPinnableReference(), ref verticalGlyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetPaletteEntries(this ComPtr<IDWriteFontFace4> thisVtbl, uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, Span<Silk.NET.DXGI.D3Dcolorvalue> paletteEntries)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPaletteEntries(colorPaletteIndex, firstEntryIndex, entryCount, ref paletteEntries.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontFaceReference<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontFaceReference((IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static void GetPanose(this ComPtr<IDWriteFontFace4> thisVtbl, Span<Panose> panose)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetPanose(ref panose.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFamilyNames<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFamilyNames((IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFaceNames<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFaceNames((IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, int* exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, IDWriteLocalizedStrings** informationalStrings, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInformationalStrings(informationalStringID, informationalStrings, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetInformationalStrings<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, ref ComPtr<TI0> informationalStrings, ref int exists) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetInformationalStrings(informationalStringID, (IDWriteLocalizedStrings**) informationalStrings.GetAddressOf(), ref exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetInformationalStrings(this ComPtr<IDWriteFontFace4> thisVtbl, InformationalStringID informationalStringID, ref IDWriteLocalizedStrings* informationalStrings, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetInformationalStrings(informationalStringID, ref informationalStrings, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, Span<int> isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreCharactersLocal(characters, characterCount, enqueueIfNotLocal, ref isLocal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreCharactersLocal(in characters.GetPinnableReference(), characterCount, enqueueIfNotLocal, isLocal);
    }

    /// <summary>To be documented.</summary>
    public static int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, Span<int> isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreCharactersLocal(in characters.GetPinnableReference(), characterCount, enqueueIfNotLocal, ref isLocal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int AreCharactersLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string characters, uint characterCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, Span<int> isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreCharactersLocal(characters, characterCount, enqueueIfNotLocal, ref isLocal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, Span<int> isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreGlyphsLocal(glyphIndices, glyphCount, enqueueIfNotLocal, ref isLocal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, int* isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreGlyphsLocal(in glyphIndices.GetPinnableReference(), glyphCount, enqueueIfNotLocal, isLocal);
    }

    /// <summary>To be documented.</summary>
    public static int AreGlyphsLocal(this ComPtr<IDWriteFontFace4> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Silk.NET.Core.Bool32 enqueueIfNotLocal, Span<int> isLocal)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->AreGlyphsLocal(in glyphIndices.GetPinnableReference(), glyphCount, enqueueIfNotLocal, ref isLocal.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, Span<GlyphImageData> glyphData, void** glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphImageData(glyphId, pixelsPerEm, glyphImageFormat, ref glyphData.GetPinnableReference(), glyphDataContext);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphImageData(this ComPtr<IDWriteFontFace4> thisVtbl, ushort glyphId, uint pixelsPerEm, GlyphImageFormats glyphImageFormat, Span<GlyphImageData> glyphData, ref void* glyphDataContext)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphImageData(glyphId, pixelsPerEm, glyphImageFormat, ref glyphData.GetPinnableReference(), ref glyphDataContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseGlyphImageData<T0>(this ComPtr<IDWriteFontFace4> thisVtbl, Span<T0> glyphDataContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseGlyphImageData(ref glyphDataContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFace4> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
