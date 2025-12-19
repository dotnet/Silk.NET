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

public unsafe static class MFTimedTextStyleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IMFTimedTextStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IMFTimedTextStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IMFTimedTextStyle> thisVtbl, char** name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[3])(@this, name);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetName(this ComPtr<IMFTimedTextStyle> thisVtbl, ref char* name)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** namePtr = &name)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[3])(@this, namePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static Silk.NET.Core.Bool32 IsExternal(this ComPtr<IMFTimedTextStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        Silk.NET.Core.Bool32 ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Silk.NET.Core.Bool32>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IMFTimedTextStyle> thisVtbl, char** fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[5])(@this, fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontFamily(this ComPtr<IMFTimedTextStyle> thisVtbl, ref char* fontFamily)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (char** fontFamilyPtr = &fontFamily)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[5])(@this, fontFamilyPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, double* fontSize, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSize, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, double* fontSize, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSize, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, ref double fontSize, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* fontSizePtr = &fontSize)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSizePtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, ref double fontSize, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* fontSizePtr = &fontSize)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSizePtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetColor(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[7])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetColor(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[7])(@this, colorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBackgroundColor(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* bgColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[8])(@this, bgColor);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB bgColor)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* bgColorPtr = &bgColor)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[8])(@this, bgColorPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetShowBackgroundAlways(this ComPtr<IMFTimedTextStyle> thisVtbl, int* showBackgroundAlways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[9])(@this, showBackgroundAlways);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetShowBackgroundAlways(this ComPtr<IMFTimedTextStyle> thisVtbl, ref int showBackgroundAlways)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* showBackgroundAlwaysPtr = &showBackgroundAlways)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[9])(@this, showBackgroundAlwaysPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontStyle(this ComPtr<IMFTimedTextStyle> thisVtbl, TimedTextFontStyle* fontStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextFontStyle*, int>)@this->LpVtbl[10])(@this, fontStyle);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetFontStyle(this ComPtr<IMFTimedTextStyle> thisVtbl, ref TimedTextFontStyle fontStyle)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextFontStyle* fontStylePtr = &fontStyle)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextFontStyle*, int>)@this->LpVtbl[10])(@this, fontStylePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetBold(this ComPtr<IMFTimedTextStyle> thisVtbl, int* bold)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[11])(@this, bold);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetBold(this ComPtr<IMFTimedTextStyle> thisVtbl, ref int bold)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* boldPtr = &bold)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[11])(@this, boldPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetRightToLeft(this ComPtr<IMFTimedTextStyle> thisVtbl, int* rightToLeft)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[12])(@this, rightToLeft);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetRightToLeft(this ComPtr<IMFTimedTextStyle> thisVtbl, ref int rightToLeft)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (int* rightToLeftPtr = &rightToLeft)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[12])(@this, rightToLeftPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextAlignment(this ComPtr<IMFTimedTextStyle> thisVtbl, TimedTextAlignment* textAlign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextAlignment*, int>)@this->LpVtbl[13])(@this, textAlign);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextAlignment(this ComPtr<IMFTimedTextStyle> thisVtbl, ref TimedTextAlignment textAlign)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextAlignment* textAlignPtr = &textAlign)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextAlignment*, int>)@this->LpVtbl[13])(@this, textAlignPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextDecoration(this ComPtr<IMFTimedTextStyle> thisVtbl, uint* textDecoration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint*, int>)@this->LpVtbl[14])(@this, textDecoration);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextDecoration(this ComPtr<IMFTimedTextStyle> thisVtbl, ref uint textDecoration)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (uint* textDecorationPtr = &textDecoration)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint*, int>)@this->LpVtbl[14])(@this, textDecorationPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadius, unitType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, double* blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (TimedTextUnitType* unitTypePtr = &unitType)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadius, unitTypePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, ref double blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* blurRadiusPtr = &blurRadius)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadiusPtr, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, ref double blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* blurRadiusPtr = &blurRadius)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadiusPtr, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, ref double thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* thicknessPtr = &thickness)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thicknessPtr, blurRadius, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, ref double thickness, double* blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* thicknessPtr = &thickness)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thicknessPtr, blurRadius, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, ref double thickness, ref double blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* thicknessPtr = &thickness)
        {
            fixed (double* blurRadiusPtr = &blurRadius)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thicknessPtr, blurRadiusPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, ref double thickness, ref double blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (double* thicknessPtr = &thickness)
        {
            fixed (double* blurRadiusPtr = &blurRadius)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thicknessPtr, blurRadiusPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, double* thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thickness, blurRadius, unitType);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, double* thickness, double* blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thickness, blurRadius, unitTypePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, double* thickness, ref double blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* blurRadiusPtr = &blurRadius)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thickness, blurRadiusPtr, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, double* thickness, ref double blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* blurRadiusPtr = &blurRadius)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thickness, blurRadiusPtr, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, ref double thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* thicknessPtr = &thickness)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thicknessPtr, blurRadius, unitType);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, ref double thickness, double* blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* thicknessPtr = &thickness)
            {
                fixed (TimedTextUnitType* unitTypePtr = &unitType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thicknessPtr, blurRadius, unitTypePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, ref double thickness, ref double blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* thicknessPtr = &thickness)
            {
                fixed (double* blurRadiusPtr = &blurRadius)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thicknessPtr, blurRadiusPtr, unitType);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, ref _MFARGB color, ref double thickness, ref double blurRadius, ref TimedTextUnitType unitType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (_MFARGB* colorPtr = &color)
        {
            fixed (double* thicknessPtr = &thickness)
            {
                fixed (double* blurRadiusPtr = &blurRadius)
                {
                    fixed (TimedTextUnitType* unitTypePtr = &unitType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thicknessPtr, blurRadiusPtr, unitTypePtr);
                    }
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IMFTimedTextStyle> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetName(this ComPtr<IMFTimedTextStyle> thisVtbl, string[] nameSa)
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
    public static int GetFontFamily(this ComPtr<IMFTimedTextStyle> thisVtbl, string[] fontFamilySa)
    {
        var @this = thisVtbl.Handle;
        // StringArrayOverloader
        var fontFamily = (char**) SilkMarshal.StringArrayToPtr(fontFamilySa);
        var ret = @this->GetFontFamily(fontFamily);
        SilkMarshal.CopyPtrToStringArray((nint) fontFamily, fontFamilySa);
        SilkMarshal.Free((nint) fontFamily);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, double* fontSize, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSize(fontSize, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<double> fontSize, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSize(ref fontSize.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontSize(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<double> fontSize, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontSize(ref fontSize.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetColor(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetColor(ref color.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBackgroundColor(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> bgColor)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBackgroundColor(ref bgColor.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetShowBackgroundAlways(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<int> showBackgroundAlways)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetShowBackgroundAlways(ref showBackgroundAlways.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetFontStyle(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<TimedTextFontStyle> fontStyle)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetFontStyle(ref fontStyle.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetBold(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<int> bold)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetBold(ref bold.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetRightToLeft(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<int> rightToLeft)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetRightToLeft(ref rightToLeft.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTextAlignment(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<TimedTextAlignment> textAlign)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextAlignment(ref textAlign.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetTextDecoration(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<uint> textDecoration)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextDecoration(ref textDecoration.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, double* blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, thickness, blurRadius, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, Span<double> blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, thickness, ref blurRadius.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, double* thickness, Span<double> blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, thickness, ref blurRadius.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, Span<double> thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, ref thickness.GetPinnableReference(), blurRadius, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, Span<double> thickness, double* blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, ref thickness.GetPinnableReference(), blurRadius, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, Span<double> thickness, Span<double> blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, ref thickness.GetPinnableReference(), ref blurRadius.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, _MFARGB* color, Span<double> thickness, Span<double> blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(color, ref thickness.GetPinnableReference(), ref blurRadius.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, double* thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), thickness, blurRadius, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, double* thickness, double* blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), thickness, blurRadius, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, double* thickness, Span<double> blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), thickness, ref blurRadius.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, double* thickness, Span<double> blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), thickness, ref blurRadius.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, Span<double> thickness, double* blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), ref thickness.GetPinnableReference(), blurRadius, unitType);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, Span<double> thickness, double* blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), ref thickness.GetPinnableReference(), blurRadius, ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, Span<double> thickness, Span<double> blurRadius, TimedTextUnitType* unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), ref thickness.GetPinnableReference(), ref blurRadius.GetPinnableReference(), unitType);
    }

    /// <summary>To be documented.</summary>
    public static int GetTextOutline(this ComPtr<IMFTimedTextStyle> thisVtbl, Span<_MFARGB> color, Span<double> thickness, Span<double> blurRadius, Span<TimedTextUnitType> unitType)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetTextOutline(ref color.GetPinnableReference(), ref thickness.GetPinnableReference(), ref blurRadius.GetPinnableReference(), ref unitType.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IMFTimedTextStyle> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
