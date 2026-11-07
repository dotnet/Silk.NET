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

namespace Silk.NET.MediaFoundation
{
    [Guid("09b2455d-b834-4f01-a347-9052e21c450e")]
    [NativeName("Name", "IMFTimedTextStyle")]
    public unsafe partial struct IMFTimedTextStyle : IComVtbl<IMFTimedTextStyle>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("09b2455d-b834-4f01-a347-9052e21c450e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextStyle val)
            => Unsafe.As<IMFTimedTextStyle, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextStyle
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** name)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[3])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* name)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[3])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsExternal()
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, Silk.NET.Core.Bool32>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(char** fontFamily)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[5])(@this, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(ref char* fontFamily)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** fontFamilyPtr = &fontFamily)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, char**, int>)@this->LpVtbl[5])(@this, fontFamilyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSize(double* fontSize, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSize, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSize(double* fontSize, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSize, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontSize(ref double fontSize, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* fontSizePtr = &fontSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, double*, TimedTextUnitType*, int>)@this->LpVtbl[6])(@this, fontSizePtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontSize(ref double fontSize, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetColor(_MFARGB* color)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[7])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColor(ref _MFARGB color)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[7])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackgroundColor(_MFARGB* bgColor)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[8])(@this, bgColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackgroundColor(ref _MFARGB bgColor)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* bgColorPtr = &bgColor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, int>)@this->LpVtbl[8])(@this, bgColorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetShowBackgroundAlways(int* showBackgroundAlways)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[9])(@this, showBackgroundAlways);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetShowBackgroundAlways(ref int showBackgroundAlways)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* showBackgroundAlwaysPtr = &showBackgroundAlways)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[9])(@this, showBackgroundAlwaysPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontStyle(TimedTextFontStyle* fontStyle)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextFontStyle*, int>)@this->LpVtbl[10])(@this, fontStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontStyle(ref TimedTextFontStyle fontStyle)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextFontStyle* fontStylePtr = &fontStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextFontStyle*, int>)@this->LpVtbl[10])(@this, fontStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBold(int* bold)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[11])(@this, bold);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBold(ref int bold)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* boldPtr = &bold)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[11])(@this, boldPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRightToLeft(int* rightToLeft)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[12])(@this, rightToLeft);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRightToLeft(ref int rightToLeft)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* rightToLeftPtr = &rightToLeft)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, int*, int>)@this->LpVtbl[12])(@this, rightToLeftPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAlignment(TimedTextAlignment* textAlign)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextAlignment*, int>)@this->LpVtbl[13])(@this, textAlign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextAlignment(ref TimedTextAlignment textAlign)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextAlignment* textAlignPtr = &textAlign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, TimedTextAlignment*, int>)@this->LpVtbl[13])(@this, textAlignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextDecoration(uint* textDecoration)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint*, int>)@this->LpVtbl[14])(@this, textDecoration);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTextDecoration(ref uint textDecoration)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* textDecorationPtr = &textDecoration)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, uint*, int>)@this->LpVtbl[14])(@this, textDecorationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(_MFARGB* color, double* thickness, double* blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadius, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(_MFARGB* color, double* thickness, double* blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadius, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(_MFARGB* color, double* thickness, ref double blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* blurRadiusPtr = &blurRadius)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thickness, blurRadiusPtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(_MFARGB* color, double* thickness, ref double blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(_MFARGB* color, ref double thickness, double* blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* thicknessPtr = &thickness)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, color, thicknessPtr, blurRadius, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(_MFARGB* color, ref double thickness, double* blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(_MFARGB* color, ref double thickness, ref double blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(_MFARGB* color, ref double thickness, ref double blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, double* thickness, double* blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextStyle*, _MFARGB*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[15])(@this, colorPtr, thickness, blurRadius, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextOutline(ref _MFARGB color, double* thickness, double* blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, double* thickness, ref double blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, double* thickness, ref double blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, ref double thickness, double* blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, ref double thickness, double* blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetTextOutline(ref _MFARGB color, ref double thickness, ref double blurRadius, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetTextOutline(ref _MFARGB color, ref double thickness, ref double blurRadius, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetName(string[] nameSa)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var name = (char**) SilkMarshal.StringArrayToPtr(nameSa);
            var ret = @this->GetName(name);
            SilkMarshal.CopyPtrToStringArray((nint) name, nameSa);
            SilkMarshal.Free((nint) name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamily(string[] fontFamilySa)
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var fontFamily = (char**) SilkMarshal.StringArrayToPtr(fontFamilySa);
            var ret = @this->GetFontFamily(fontFamily);
            SilkMarshal.CopyPtrToStringArray((nint) fontFamily, fontFamilySa);
            SilkMarshal.Free((nint) fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextStyle*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
