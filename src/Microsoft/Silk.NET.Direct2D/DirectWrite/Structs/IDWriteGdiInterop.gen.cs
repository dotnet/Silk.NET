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

namespace Silk.NET.DirectWrite
{
    [Guid("1edd9491-9853-4299-898f-6432983b6f3a")]
    [NativeName("Name", "IDWriteGdiInterop")]
    public unsafe partial struct IDWriteGdiInterop : IComVtbl<IDWriteGdiInterop>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1edd9491-9853-4299-898f-6432983b6f3a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteGdiInterop val)
            => Unsafe.As<IDWriteGdiInterop, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteGdiInterop
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
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, IDWriteFont** font)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref IDWriteFont* font)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFont, fontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, IDWriteFont** font) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* logFontPtr = &logFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFontPtr, font);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref IDWriteFont* font) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* logFontPtr = &logFont)
            {
                fixed (IDWriteFont** fontPtr = &font)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, void*, IDWriteFont**, int>)@this->LpVtbl[3])(@this, logFontPtr, fontPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(IDWriteFont* font, void* logFont, int* isSystemFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(IDWriteFont* font, void* logFont, ref int isSystemFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSystemFontPtr = &isSystemFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFont, isSystemFontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<T0>(IDWriteFont* font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* logFontPtr = &logFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFontPtr, isSystemFont);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<T0>(IDWriteFont* font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* logFontPtr = &logFont)
            {
                fixed (int* isSystemFontPtr = &isSystemFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, font, logFontPtr, isSystemFontPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(ref IDWriteFont font, void* logFont, int* isSystemFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont* fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFont, isSystemFont);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT(ref IDWriteFont font, void* logFont, ref int isSystemFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont* fontPtr = &font)
            {
                fixed (int* isSystemFontPtr = &isSystemFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFont, isSystemFontPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<T0>(ref IDWriteFont font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont* fontPtr = &font)
            {
                fixed (void* logFontPtr = &logFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFontPtr, isSystemFont);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConvertFontToLOGFONT<T0>(ref IDWriteFont font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont* fontPtr = &font)
            {
                fixed (void* logFontPtr = &logFont)
                {
                    fixed (int* isSystemFontPtr = &isSystemFont)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFont*, void*, int*, int>)@this->LpVtbl[4])(@this, fontPtr, logFontPtr, isSystemFontPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT(IDWriteFontFace* font, void* logFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFont);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT<T0>(IDWriteFontFace* font, ref T0 logFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* logFontPtr = &logFont)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, font, logFontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT(ref IDWriteFontFace font, void* logFont)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, fontPtr, logFont);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConvertFontFaceToLOGFONT<T0>(ref IDWriteFontFace font, ref T0 logFont) where T0 : unmanaged
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontPtr = &font)
            {
                fixed (void* logFontPtr = &logFont)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, IDWriteFontFace*, void*, int>)@this->LpVtbl[5])(@this, fontPtr, logFontPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceFromHdc(nint hdc, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceFromHdc(nint hdc, ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, IDWriteFontFace**, int>)@this->LpVtbl[6])(@this, hdc, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapRenderTarget(nint hdc, uint width, uint height, IDWriteBitmapRenderTarget** renderTarget)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapRenderTarget(nint hdc, uint width, uint height, ref IDWriteBitmapRenderTarget* renderTarget)
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteBitmapRenderTarget** renderTargetPtr = &renderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteGdiInterop*, nint, uint, uint, IDWriteBitmapRenderTarget**, int>)@this->LpVtbl[7])(@this, hdc, width, height, renderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFromLOGFONT<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* logFont, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFromLOGFONT(logFont, (IDWriteFont**) font.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFromLOGFONT<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 logFont, ref ComPtr<TI0> font) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFromLOGFONT(in logFont, (IDWriteFont**) font.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<TI0>(ComPtr<TI0> font, void* logFont, int* isSystemFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, logFont, isSystemFont);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<TI0>(ComPtr<TI0> font, void* logFont, ref int isSystemFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, logFont, ref isSystemFont);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontToLOGFONT<T0, TI0>(ComPtr<TI0> font, ref T0 logFont, int* isSystemFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, ref logFont, isSystemFont);
        }

        /// <summary>To be documented.</summary>
        public readonly int ConvertFontToLOGFONT<T0, TI0>(ComPtr<TI0> font, ref T0 logFont, ref int isSystemFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontToLOGFONT((IDWriteFont*) font.Handle, ref logFont, ref isSystemFont);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConvertFontFaceToLOGFONT<TI0>(ComPtr<TI0> font, void* logFont) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontFaceToLOGFONT((IDWriteFontFace*) font.Handle, logFont);
        }

        /// <summary>To be documented.</summary>
        public readonly int ConvertFontFaceToLOGFONT<T0, TI0>(ComPtr<TI0> font, ref T0 logFont) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ConvertFontFaceToLOGFONT((IDWriteFontFace*) font.Handle, ref logFont);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFaceFromHdc<TI0>(nint hdc, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceFromHdc(hdc, (IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapRenderTarget<TI0>(nint hdc, uint width, uint height, ref ComPtr<TI0> renderTarget) where TI0 : unmanaged, IComVtbl<IDWriteBitmapRenderTarget>, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapRenderTarget(hdc, width, height, (IDWriteBitmapRenderTarget**) renderTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteGdiInterop*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
