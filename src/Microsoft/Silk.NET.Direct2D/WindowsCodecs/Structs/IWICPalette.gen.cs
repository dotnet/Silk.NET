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

namespace Silk.NET.WindowsCodecs
{
    [Guid("00000040-a8f2-4877-ba0a-fd2b6645fb94")]
    [NativeName("Name", "IWICPalette")]
    public unsafe partial struct IWICPalette : IComVtbl<IWICPalette>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000040-a8f2-4877-ba0a-fd2b6645fb94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPalette val)
            => Unsafe.As<IWICPalette, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPalette
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
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializePredefined(BitmapPaletteType ePaletteType, Silk.NET.Core.Bool32 fAddTransparentColor)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, ePaletteType, fAddTransparentColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitializeCustom(uint* pColors, uint cCount)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)@this->LpVtbl[4])(@this, pColors, cCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeCustom(ref uint pColors, uint cCount)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pColorsPtr = &pColors)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, uint, int>)@this->LpVtbl[4])(@this, pColorsPtr, cCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitializeFromBitmap(IWICBitmapSource* pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, pISurface, cCount, fAddTransparentColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromBitmap(ref IWICBitmapSource pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pISurfacePtr = &pISurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICBitmapSource*, uint, Silk.NET.Core.Bool32, int>)@this->LpVtbl[5])(@this, pISurfacePtr, cCount, fAddTransparentColor);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitializeFromPalette(IWICPalette* pIPalette)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromPalette(ref IWICPalette pIPalette)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette* pIPalettePtr = &pIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, IWICPalette*, int>)@this->LpVtbl[6])(@this, pIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetType(BitmapPaletteType* pePaletteType)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType*, int>)@this->LpVtbl[7])(@this, pePaletteType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetType(ref BitmapPaletteType pePaletteType)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPaletteType* pePaletteTypePtr = &pePaletteType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, BitmapPaletteType*, int>)@this->LpVtbl[7])(@this, pePaletteTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorCount(uint* pcCount)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)@this->LpVtbl[8])(@this, pcCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorCount(ref uint pcCount)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint*, int>)@this->LpVtbl[8])(@this, pcCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColors(uint cCount, uint* pColors, uint* pcActualColors)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColors, pcActualColors);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColors(uint cCount, uint* pColors, ref uint pcActualColors)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualColorsPtr = &pcActualColors)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColors, pcActualColorsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColors(uint cCount, ref uint pColors, uint* pcActualColors)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pColorsPtr = &pColors)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColorsPtr, pcActualColors);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColors(uint cCount, ref uint pColors, ref uint pcActualColors)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pColorsPtr = &pColors)
            {
                fixed (uint* pcActualColorsPtr = &pcActualColors)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, uint, uint*, uint*, int>)@this->LpVtbl[9])(@this, cCount, pColorsPtr, pcActualColorsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsBlackWhite(int* pfIsBlackWhite)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[10])(@this, pfIsBlackWhite);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsBlackWhite(ref int pfIsBlackWhite)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIsBlackWhitePtr = &pfIsBlackWhite)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[10])(@this, pfIsBlackWhitePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsGrayscale(int* pfIsGrayscale)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[11])(@this, pfIsGrayscale);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsGrayscale(ref int pfIsGrayscale)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIsGrayscalePtr = &pfIsGrayscale)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[11])(@this, pfIsGrayscalePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int HasAlpha(int* pfHasAlpha)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[12])(@this, pfHasAlpha);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int HasAlpha(ref int pfHasAlpha)
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfHasAlphaPtr = &pfHasAlpha)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPalette*, int*, int>)@this->LpVtbl[12])(@this, pfHasAlphaPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromBitmap<TI0>(ComPtr<TI0> pISurface, uint cCount, Silk.NET.Core.Bool32 fAddTransparentColor) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InitializeFromBitmap((IWICBitmapSource*) pISurface.Handle, cCount, fAddTransparentColor);
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromPalette<TI0>(ComPtr<TI0> pIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->InitializeFromPalette((IWICPalette*) pIPalette.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPalette*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
