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
    [Guid("c8d22afc-bc47-4bdf-9b04-787e49ce3f58")]
    [NativeName("Name", "IMFTimedTextRegion")]
    public unsafe partial struct IMFTimedTextRegion : IComVtbl<IMFTimedTextRegion>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c8d22afc-bc47-4bdf-9b04-787e49ce3f58");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFTimedTextRegion val)
            => Unsafe.As<IMFTimedTextRegion, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFTimedTextRegion
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
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly uint AddRef()
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** name)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, char**, int>)@this->LpVtbl[3])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* name)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, char**, int>)@this->LpVtbl[3])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPosition(double* pX, double* pY, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pY, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPosition(double* pX, double* pY, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pY, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPosition(double* pX, ref double pY, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pYPtr = &pY)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pX, pYPtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPosition(double* pX, ref double pY, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPosition(ref double pX, double* pY, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pXPtr = &pX)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[4])(@this, pXPtr, pY, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPosition(ref double pX, double* pY, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPosition(ref double pX, ref double pY, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetPosition(ref double pX, ref double pY, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetExtent(double* pWidth, double* pHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeight, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExtent(double* pWidth, double* pHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeight, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExtent(double* pWidth, ref double pHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidth, pHeightPtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExtent(double* pWidth, ref double pHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetExtent(ref double pWidth, double* pHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pWidthPtr = &pWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[5])(@this, pWidthPtr, pHeight, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExtent(ref double pWidth, double* pHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetExtent(ref double pWidth, ref double pHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetExtent(ref double pWidth, ref double pHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetBackgroundColor(_MFARGB* bgColor)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, _MFARGB*, int>)@this->LpVtbl[6])(@this, bgColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackgroundColor(ref _MFARGB bgColor)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (_MFARGB* bgColorPtr = &bgColor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, _MFARGB*, int>)@this->LpVtbl[6])(@this, bgColorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWritingMode(TimedTextWritingMode* writingMode)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextWritingMode*, int>)@this->LpVtbl[7])(@this, writingMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWritingMode(ref TimedTextWritingMode writingMode)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextWritingMode* writingModePtr = &writingMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextWritingMode*, int>)@this->LpVtbl[7])(@this, writingModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayAlignment(TimedTextDisplayAlignment* displayAlign)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextDisplayAlignment*, int>)@this->LpVtbl[8])(@this, displayAlign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayAlignment(ref TimedTextDisplayAlignment displayAlign)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextDisplayAlignment* displayAlignPtr = &displayAlign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextDisplayAlignment*, int>)@this->LpVtbl[8])(@this, displayAlignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineHeight(double* pLineHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeight, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineHeight(double* pLineHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeight, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLineHeight(ref double pLineHeight, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* pLineHeightPtr = &pLineHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, TimedTextUnitType*, int>)@this->LpVtbl[9])(@this, pLineHeightPtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLineHeight(ref double pLineHeight, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetClipOverflow(int* clipOverflow)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[10])(@this, clipOverflow);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetClipOverflow(ref int clipOverflow)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* clipOverflowPtr = &clipOverflow)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[10])(@this, clipOverflowPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, double* start, double* after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, end, unitType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, double* start, double* after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextUnitType* unitTypePtr = &unitType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, end, unitTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, double* start, double* after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* endPtr = &end)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, after, endPtr, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, double* start, double* after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, double* start, ref double after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* afterPtr = &after)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, start, afterPtr, end, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, double* start, ref double after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, double* start, ref double after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, double* start, ref double after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, double* after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* startPtr = &start)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, before, startPtr, after, end, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(double* before, ref double start, double* after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, double* after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, double* after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, ref double after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, ref double after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, ref double after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(double* before, ref double start, ref double after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, double* after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (double* beforePtr = &before)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, double*, double*, double*, double*, TimedTextUnitType*, int>)@this->LpVtbl[11])(@this, beforePtr, start, after, end, unitType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPadding(ref double before, double* start, double* after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, double* after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, double* after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, ref double after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, ref double after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, ref double after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, double* start, ref double after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, double* after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, double* after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, double* after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, double* after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, ref double after, double* end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, ref double after, double* end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetPadding(ref double before, ref double start, ref double after, ref double end, TimedTextUnitType* unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly int GetPadding(ref double before, ref double start, ref double after, ref double end, ref TimedTextUnitType unitType)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
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
        public readonly unsafe int GetWrap(int* wrap)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[12])(@this, wrap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWrap(ref int wrap)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* wrapPtr = &wrap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[12])(@this, wrapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetZIndex(int* zIndex)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[13])(@this, zIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetZIndex(ref int zIndex)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* zIndexPtr = &zIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, int*, int>)@this->LpVtbl[13])(@this, zIndexPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetScrollMode(TimedTextScrollMode* scrollMode)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextScrollMode*, int>)@this->LpVtbl[14])(@this, scrollMode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetScrollMode(ref TimedTextScrollMode scrollMode)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TimedTextScrollMode* scrollModePtr = &scrollMode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFTimedTextRegion*, TimedTextScrollMode*, int>)@this->LpVtbl[14])(@this, scrollModePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetName(string[] nameSa)
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var name = (char**) SilkMarshal.StringArrayToPtr(nameSa);
            var ret = @this->GetName(name);
            SilkMarshal.CopyPtrToStringArray((nint) name, nameSa);
            SilkMarshal.Free((nint) name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFTimedTextRegion*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
