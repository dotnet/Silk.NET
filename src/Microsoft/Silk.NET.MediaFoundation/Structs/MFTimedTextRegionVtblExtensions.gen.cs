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

namespace Silk.NET.MediaFoundation;

public unsafe static class MFTimedTextRegionVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextRegion> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextRegion> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IMFTimedTextRegion> thisVtbl, char** name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, char**, int>)@this->LpVtbl[3])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IMFTimedTextRegion> thisVtbl, ref char* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, char**, int>)@this->LpVtbl[3])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, double* pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pY, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, double* pY, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pY, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, ref double pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pYPtr = &pY)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pYPtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, ref double pY, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pYPtr = &pY)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pYPtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pX, double* pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pXPtr = &pX)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pXPtr, pY, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pX, double* pY, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pXPtr = &pX)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pXPtr, pY, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pX, ref double pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pXPtr = &pX)
        {
            fixed (double* pYPtr = &pY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pXPtr, pYPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pX, ref double pY, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pXPtr = &pX)
        {
            fixed (double* pYPtr = &pY)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pXPtr, pYPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, double* pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeight, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, double* pHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeight, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, ref double pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pHeightPtr = &pHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeightPtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, ref double pHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pHeightPtr = &pHeight)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeightPtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pWidth, double* pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pWidthPtr = &pWidth)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidthPtr, pHeight, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pWidth, double* pHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pWidthPtr = &pWidth)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidthPtr, pHeight, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pWidth, ref double pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pWidthPtr = &pWidth)
        {
            fixed (double* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidthPtr, pHeightPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pWidth, ref double pHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pWidthPtr = &pWidth)
        {
            fixed (double* pHeightPtr = &pHeight)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidthPtr, pHeightPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor(this ComPtr<IMFTimedTextRegion> thisVtbl, _MFARGB* bgColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, _MFARGB*, int>)@this->LpVtbl[6])(@this, bgColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IMFTimedTextRegion> thisVtbl, ref _MFARGB bgColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* bgColorPtr = &bgColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, _MFARGB*, int>)@this->LpVtbl[6])(@this, bgColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWritingMode(this ComPtr<IMFTimedTextRegion> thisVtbl, TimedTextWritingMode* writingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextWritingMode*, int>)@this->LpVtbl[7])(@this, writingMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWritingMode(this ComPtr<IMFTimedTextRegion> thisVtbl, ref TimedTextWritingMode writingMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextWritingMode* writingModePtr = &writingMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextWritingMode*, int>)@this->LpVtbl[7])(@this, writingModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDisplayAlignment(this ComPtr<IMFTimedTextRegion> thisVtbl, TimedTextDisplayAlignment* displayAlign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextDisplayAlignment*, int>)@this->LpVtbl[8])(@this, displayAlign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayAlignment(this ComPtr<IMFTimedTextRegion> thisVtbl, ref TimedTextDisplayAlignment displayAlign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextDisplayAlignment* displayAlignPtr = &displayAlign)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextDisplayAlignment*, int>)@this->LpVtbl[8])(@this, displayAlignPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pLineHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeight, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pLineHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeight, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pLineHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pLineHeightPtr = &pLineHeight)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeightPtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double pLineHeight, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* pLineHeightPtr = &pLineHeight)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeightPtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetClipOverflow(this ComPtr<IMFTimedTextRegion> thisVtbl, int* clipOverflow)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[10])(@this, clipOverflow);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetClipOverflow(this ComPtr<IMFTimedTextRegion> thisVtbl, ref int clipOverflow)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* clipOverflowPtr = &clipOverflow)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[10])(@this, clipOverflowPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, end, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, end, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* endPtr = &end)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, endPtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* endPtr = &end)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, endPtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, ref double after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* afterPtr = &after)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, afterPtr, end, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, ref double after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* afterPtr = &after)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, afterPtr, end, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, ref double after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* afterPtr = &after)
        {
            fixed (double* endPtr = &end)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, afterPtr, endPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, ref double after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* afterPtr = &after)
        {
            fixed (double* endPtr = &end)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, afterPtr, endPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, after, end, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, double* after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, after, end, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, double* after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* endPtr = &end)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, after, endPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, double* after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* endPtr = &end)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, after, endPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, ref double after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* afterPtr = &after)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, afterPtr, end, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, ref double after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, afterPtr, end, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, ref double after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (double* endPtr = &end)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, afterPtr, endPtr, unitType);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, ref double start, ref double after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* startPtr = &start)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (double* endPtr = &end)
                {
                    fixed (TimedTextUnitType* unitTypePtr = &unitType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, afterPtr, endPtr, unitTypePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, after, end, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, double* after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, after, end, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, double* after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* endPtr = &end)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, after, endPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, double* after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* endPtr = &end)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, after, endPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, ref double after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* afterPtr = &after)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, afterPtr, end, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, ref double after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, afterPtr, end, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, ref double after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (double* endPtr = &end)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, afterPtr, endPtr, unitType);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, double* start, ref double after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* afterPtr = &after)
            {
                fixed (double* endPtr = &end)
                {
                    fixed (TimedTextUnitType* unitTypePtr = &unitType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, afterPtr, endPtr, unitTypePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, after, end, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, double* after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, after, end, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, double* after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* endPtr = &end)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, after, endPtr, unitType);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, double* after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* endPtr = &end)
                {
                    fixed (TimedTextUnitType* unitTypePtr = &unitType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, after, endPtr, unitTypePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, ref double after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* afterPtr = &after)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, afterPtr, end, unitType);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, ref double after, double* end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* afterPtr = &after)
                {
                    fixed (TimedTextUnitType* unitTypePtr = &unitType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, afterPtr, end, unitTypePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, ref double after, ref double end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* afterPtr = &after)
                {
                    fixed (double* endPtr = &end)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, afterPtr, endPtr, unitType);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, ref double before, ref double start, ref double after, ref double end, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* beforePtr = &before)
        {
            fixed (double* startPtr = &start)
            {
                fixed (double* afterPtr = &after)
                {
                    fixed (double* endPtr = &end)
                    {
                        fixed (TimedTextUnitType* unitTypePtr = &unitType)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, startPtr, afterPtr, endPtr, unitTypePtr);
                        }
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetWrap(this ComPtr<IMFTimedTextRegion> thisVtbl, int* wrap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[12])(@this, wrap);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetWrap(this ComPtr<IMFTimedTextRegion> thisVtbl, ref int wrap)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* wrapPtr = &wrap)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[12])(@this, wrapPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetZIndex(this ComPtr<IMFTimedTextRegion> thisVtbl, int* zIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[13])(@this, zIndex);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetZIndex(this ComPtr<IMFTimedTextRegion> thisVtbl, ref int zIndex)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* zIndexPtr = &zIndex)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[13])(@this, zIndexPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetScrollMode(this ComPtr<IMFTimedTextRegion> thisVtbl, TimedTextScrollMode* scrollMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextScrollMode*, int>)@this->LpVtbl[14])(@this, scrollMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetScrollMode(this ComPtr<IMFTimedTextRegion> thisVtbl, ref TimedTextScrollMode scrollMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextScrollMode* scrollModePtr = &scrollMode)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextScrollMode*, int>)@this->LpVtbl[14])(@this, scrollModePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextRegion> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetName(this ComPtr<IMFTimedTextRegion> thisVtbl, string[] nameSa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var name = (char**) SilkMarshal.StringArrayToPtr(nameSa);
        var ret = @this->GetName(name);
        SilkMarshal.CopyPtrToStringArray((nint) name, nameSa);
        SilkMarshal.Free((nint) name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, double* pY, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(pX, pY, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, Span<double> pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(pX, ref pY.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pX, Span<double> pY, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(pX, ref pY.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pX, double* pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(ref pX.GetPinnableReference(), pY, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pX, double* pY, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(ref pX.GetPinnableReference(), pY, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pX, Span<double> pY, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(ref pX.GetPinnableReference(), ref pY.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetPosition(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pX, Span<double> pY, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPosition(ref pX.GetPinnableReference(), ref pY.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, double* pHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(pWidth, pHeight, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, Span<double> pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(pWidth, ref pHeight.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pWidth, Span<double> pHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(pWidth, ref pHeight.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pWidth, double* pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(ref pWidth.GetPinnableReference(), pHeight, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pWidth, double* pHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(ref pWidth.GetPinnableReference(), pHeight, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pWidth, Span<double> pHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(ref pWidth.GetPinnableReference(), ref pHeight.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetExtent(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pWidth, Span<double> pHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetExtent(ref pWidth.GetPinnableReference(), ref pHeight.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<_MFARGB> bgColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBackgroundColor(ref bgColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWritingMode(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<TimedTextWritingMode> writingMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWritingMode(ref writingMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetDisplayAlignment(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<TimedTextDisplayAlignment> displayAlign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDisplayAlignment(ref displayAlign.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, double* pLineHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineHeight(pLineHeight, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pLineHeight, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineHeight(ref pLineHeight.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetLineHeight(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> pLineHeight, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetLineHeight(ref pLineHeight.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetClipOverflow(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<int> clipOverflow)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetClipOverflow(ref clipOverflow.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, after, end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, after, ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, double* after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, after, ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, Span<double> after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, ref after.GetPinnableReference(), end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, Span<double> after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, ref after.GetPinnableReference(), end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, Span<double> after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, ref after.GetPinnableReference(), ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, double* start, Span<double> after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, start, ref after.GetPinnableReference(), ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), after, end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, double* after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), after, end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, double* after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), after, ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, double* after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), after, ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, Span<double> after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), ref after.GetPinnableReference(), end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, Span<double> after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), ref after.GetPinnableReference(), end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, Span<double> after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), ref after.GetPinnableReference(), ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, double* before, Span<double> start, Span<double> after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(before, ref start.GetPinnableReference(), ref after.GetPinnableReference(), ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, after, end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, double* after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, after, end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, double* after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, after, ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, double* after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, after, ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, Span<double> after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, ref after.GetPinnableReference(), end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, Span<double> after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, ref after.GetPinnableReference(), end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, Span<double> after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, ref after.GetPinnableReference(), ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, double* start, Span<double> after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), start, ref after.GetPinnableReference(), ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, double* after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), after, end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, double* after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), after, end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, double* after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), after, ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, double* after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), after, ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, Span<double> after, double* end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), ref after.GetPinnableReference(), end, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, Span<double> after, double* end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), ref after.GetPinnableReference(), end, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, Span<double> after, Span<double> end, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), ref after.GetPinnableReference(), ref end.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetPadding(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<double> before, Span<double> start, Span<double> after, Span<double> end, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetPadding(ref before.GetPinnableReference(), ref start.GetPinnableReference(), ref after.GetPinnableReference(), ref end.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetWrap(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<int> wrap)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetWrap(ref wrap.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetZIndex(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<int> zIndex)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetZIndex(ref zIndex.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetScrollMode(this ComPtr<IMFTimedTextRegion> thisVtbl, Span<TimedTextScrollMode> scrollMode)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetScrollMode(ref scrollMode.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextRegion> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
