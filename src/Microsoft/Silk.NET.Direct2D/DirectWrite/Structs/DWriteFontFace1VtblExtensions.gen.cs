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

public unsafe static class DWriteFontFace1VtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontFaceType GetType(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontFaceType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, FontFaceType>)@this->LpVtbl[3])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, uint* numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFiles);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, uint* numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFiles, fontFilesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, ref uint numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFiles);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, ref uint numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* numberOfFilesPtr = &numberOfFiles)
        {
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, numberOfFilesPtr, fontFilesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIndex(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static FontSimulations GetSimulations(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        FontSimulations ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, FontSimulations>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsSymbolFont(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Silk.NET.Core.Bool32>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, FontMetrics*, void>)@this->LpVtbl[8])(@this, fontFaceMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static ushort GetGlyphCount(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        ushort ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, ushort>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[10])(@this, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePoints, codePointCount, glyphIndicesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndices);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint codePoints, uint codePointCount, ref ushort glyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* codePointsPtr = &codePoints)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint*, uint, ushort*, int>)@this->LpVtbl[11])(@this, codePointsPtr, codePointCount, glyphIndicesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, exists);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* existsPtr = &exists)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContext, existsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableContextPtr = &tableContext)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSize, tableContextPtr, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, ref uint tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* tableSizePtr = &tableSize)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableData, tableSizePtr, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, exists);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContext, existsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (void** tableContextPtr = &tableContext)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSize, tableContextPtr, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, exists);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, void** tableContext, ref int exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContext, existsPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** tableDataPtr = &tableData)
        {
            fixed (uint* tableSizePtr = &tableSize)
            {
                fixed (void** tableContextPtr = &tableContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, exists);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, ref uint tableSize, ref void* tableContext, ref int exists)
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
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, void**, uint*, void**, int*, int>)@this->LpVtbl[12])(@this, openTypeTableTag, tableDataPtr, tableSizePtr, tableContextPtr, existsPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void ReleaseFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, void* tableContext)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, void*, void>)@this->LpVtbl[13])(@this, tableContext);
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace1> thisVtbl, ref T0 tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        fixed (void* tableContextPtr = &tableContext)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, void*, void>)@this->LpVtbl[13])(@this, tableContextPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (float* glyphAdvancesPtr = &glyphAdvances)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndices, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvances, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySinkPtr = &geometrySink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (float* glyphAdvancesPtr = &glyphAdvances)
            {
                fixed (GlyphOffset* glyphOffsetsPtr = &glyphOffsets)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySink);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphOffset glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, ref Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink geometrySink)
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
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, ushort*, float*, GlyphOffset*, uint, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink*, int>)@this->LpVtbl[14])(@this, emSize, glyphIndicesPtr, glyphAdvancesPtr, glyphOffsetsPtr, glyphCount, isSideways, isRightToLeft, geometrySinkPtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (RenderingMode* renderingModePtr = &renderingMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParams, renderingModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingMode);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ref IDWriteRenderingParams renderingParams, ref RenderingMode renderingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteRenderingParams* renderingParamsPtr = &renderingParams)
        {
            fixed (RenderingMode* renderingModePtr = &renderingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, MeasuringMode, IDWriteRenderingParams*, RenderingMode*, int>)@this->LpVtbl[15])(@this, emSize, pixelsPerDip, measuringMode, renderingParamsPtr, renderingModePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetrics);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transform, fontFaceMetricsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetrics);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, ref FontMetrics fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (FontMetrics* fontFaceMetricsPtr = &fontFaceMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, FontMetrics*, int>)@this->LpVtbl[16])(@this, emSize, pixelsPerDip, transformPtr, fontFaceMetricsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transform, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndices, glyphCount, glyphMetricsPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetrics, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, uint glyphCount, ref GlyphMetrics glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (GlyphMetrics* glyphMetricsPtr = &glyphMetrics)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, ushort*, uint, GlyphMetrics*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[17])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, glyphIndicesPtr, glyphCount, glyphMetricsPtr, isSideways);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetCaretMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, CaretMetrics* caretMetrics)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetrics);
    }

    /// <summary>To be documented.</summary>
    public static void GetCaretMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, ref CaretMetrics caretMetrics)
    {
        var @this = thisVtbl.Handle;
        fixed (CaretMetrics* caretMetricsPtr = &caretMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, CaretMetrics*, void>)@this->LpVtbl[20])(@this, caretMetricsPtr);
        }
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* actualRangeCountPtr = &actualRangeCount)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRanges, actualRangeCountPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCount);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, ref UnicodeRange unicodeRanges, ref uint actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (UnicodeRange* unicodeRangesPtr = &unicodeRanges)
        {
            fixed (uint* actualRangeCountPtr = &actualRangeCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, UnicodeRange*, uint*, int>)@this->LpVtbl[21])(@this, maxRangeCount, unicodeRangesPtr, actualRangeCountPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsMonospacedFont(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Silk.NET.Core.Bool32>)@this->LpVtbl[22])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvances, isSideways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndices, glyphAdvancesPtr, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvances, isSideways);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, Silk.NET.Core.Bool32, int>)@this->LpVtbl[23])(@this, glyphCount, glyphIndicesPtr, glyphAdvancesPtr, isSideways);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvancesPtr = &glyphAdvances)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (int* glyphAdvancesPtr = &glyphAdvances)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvancesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvances);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Matrix* transformPtr = &transform)
        {
            fixed (ushort* glyphIndicesPtr = &glyphIndices)
            {
                fixed (int* glyphAdvancesPtr = &glyphAdvances)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, float, float, Matrix*, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, uint, ushort*, int*, int>)@this->LpVtbl[24])(@this, emSize, pixelsPerDip, transformPtr, useGdiNatural, isSideways, glyphCount, glyphIndicesPtr, glyphAdvancesPtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustments);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, ref int glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndices, glyphAdvanceAdjustmentsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustments);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort glyphIndices, ref int glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* glyphIndicesPtr = &glyphIndices)
        {
            fixed (int* glyphAdvanceAdjustmentsPtr = &glyphAdvanceAdjustments)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, int*, int>)@this->LpVtbl[25])(@this, glyphCount, glyphIndicesPtr, glyphAdvanceAdjustmentsPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasKerningPairs(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndices);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, ref ushort verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndices, verticalGlyphIndicesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndices);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort nominalGlyphIndices, ref ushort verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ushort* nominalGlyphIndicesPtr = &nominalGlyphIndices)
        {
            fixed (ushort* verticalGlyphIndicesPtr = &verticalGlyphIndices)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, uint, ushort*, ushort*, int>)@this->LpVtbl[28])(@this, glyphCount, nominalGlyphIndicesPtr, verticalGlyphIndicesPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 HasVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFace1*, Silk.NET.Core.Bool32>)@this->LpVtbl[29])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFace1> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl, uint* numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, Span<uint> numberOfFiles, IDWriteFontFile** fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static int GetFiles<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl, ref uint numberOfFiles, ref ComPtr<TI0> fontFiles) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFiles(ref numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFiles(this ComPtr<IDWriteFontFace1> thisVtbl, Span<uint> numberOfFiles, ref IDWriteFontFile* fontFiles)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFiles(ref numberOfFiles.GetPinnableReference(), ref fontFiles);
    }

    /// <summary>To be documented.</summary>
    public static void GetMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetMetrics(ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphMetrics(in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(codePoints, codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, ushort* glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, glyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphIndicesA(this ComPtr<IDWriteFontFace1> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> codePoints, uint codePointCount, Span<ushort> glyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphIndicesA(in codePoints.GetPinnableReference(), codePointCount, ref glyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void** tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, uint* tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, tableSize, ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, void** tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, int* exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, exists);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int TryGetFontTable(this ComPtr<IDWriteFontFace1> thisVtbl, uint openTypeTableTag, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* tableData, Span<uint> tableSize, ref void* tableContext, Span<int> exists)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->TryGetFontTable(openTypeTableTag, in tableData, ref tableSize.GetPinnableReference(), ref tableContext, ref exists.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static void ReleaseFontTable<T0>(this ComPtr<IDWriteFontFace1> thisVtbl, Span<T0> tableContext) where T0 : unmanaged
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->ReleaseFontTable(ref tableContext.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, glyphIndices, in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), glyphAdvances, in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphOffset* glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), glyphOffsets, glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink* geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, geometrySink);
    }

    /// <summary>To be documented.</summary>
    public static int GetGlyphRunOutline(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> glyphAdvances, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GlyphOffset> glyphOffsets, uint glyphCount, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft, Span<Silk.NET.Direct2D.ID2D1SimplifiedGeometrySink> geometrySink)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGlyphRunOutline(emSize, in glyphIndices.GetPinnableReference(), in glyphAdvances.GetPinnableReference(), in glyphOffsets.GetPinnableReference(), glyphCount, isSideways, isRightToLeft, ref geometrySink.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, RenderingMode* renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, IDWriteRenderingParams* renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, renderingParams, ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, ComPtr<TI0> renderingParams, ref RenderingMode renderingMode) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, (IDWriteRenderingParams*) renderingParams.Handle, ref renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, RenderingMode* renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), renderingMode);
    }

    /// <summary>To be documented.</summary>
    public static int GetRecommendedRenderingMode(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, MeasuringMode measuringMode, Span<IDWriteRenderingParams> renderingParams, Span<RenderingMode> renderingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRecommendedRenderingMode(emSize, pixelsPerDip, measuringMode, ref renderingParams.GetPinnableReference(), ref renderingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, transform, ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, FontMetrics* fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), fontFaceMetrics);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Span<FontMetrics> fontFaceMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), ref fontFaceMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, transform, useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, glyphIndices, glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, GlyphMetrics* glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, glyphMetrics, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, uint glyphCount, Span<GlyphMetrics> glyphMetrics, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphMetrics(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, in glyphIndices.GetPinnableReference(), glyphCount, ref glyphMetrics.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static void GetCaretMetrics(this ComPtr<IDWriteFontFace1> thisVtbl, Span<CaretMetrics> caretMetrics)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        @this->GetCaretMetrics(ref caretMetrics.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, UnicodeRange* unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, unicodeRanges, ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, uint* actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), actualRangeCount);
    }

    /// <summary>To be documented.</summary>
    public static int GetUnicodeRanges(this ComPtr<IDWriteFontFace1> thisVtbl, uint maxRangeCount, Span<UnicodeRange> unicodeRanges, Span<uint> actualRangeCount)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetUnicodeRanges(maxRangeCount, ref unicodeRanges.GetPinnableReference(), ref actualRangeCount.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances, isSideways);
    }

    /// <summary>To be documented.</summary>
    public static int GetDesignGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances, Silk.NET.Core.Bool32 isSideways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDesignGlyphAdvances(glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference(), isSideways);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, transform, useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, glyphIndices, glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, glyphIndices, ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvances);
    }

    /// <summary>To be documented.</summary>
    public static int GetGdiCompatibleGlyphAdvances(this ComPtr<IDWriteFontFace1> thisVtbl, float emSize, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Matrix> transform, Silk.NET.Core.Bool32 useGdiNatural, Silk.NET.Core.Bool32 isSideways, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvances)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetGdiCompatibleGlyphAdvances(emSize, pixelsPerDip, in transform.GetPinnableReference(), useGdiNatural, isSideways, glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvances.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* glyphIndices, Span<int> glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, glyphIndices, ref glyphAdvanceAdjustments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, int* glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, in glyphIndices.GetPinnableReference(), glyphAdvanceAdjustments);
    }

    /// <summary>To be documented.</summary>
    public static int GetKerningPairAdjustments(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> glyphIndices, Span<int> glyphAdvanceAdjustments)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetKerningPairAdjustments(glyphCount, in glyphIndices.GetPinnableReference(), ref glyphAdvanceAdjustments.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* nominalGlyphIndices, Span<ushort> verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, nominalGlyphIndices, ref verticalGlyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> nominalGlyphIndices, ushort* verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, in nominalGlyphIndices.GetPinnableReference(), verticalGlyphIndices);
    }

    /// <summary>To be documented.</summary>
    public static int GetVerticalGlyphVariants(this ComPtr<IDWriteFontFace1> thisVtbl, uint glyphCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> nominalGlyphIndices, Span<ushort> verticalGlyphIndices)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetVerticalGlyphVariants(glyphCount, in nominalGlyphIndices.GetPinnableReference(), ref verticalGlyphIndices.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFace1> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
