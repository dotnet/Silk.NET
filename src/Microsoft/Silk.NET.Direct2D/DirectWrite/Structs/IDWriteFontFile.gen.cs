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
    [Guid("739d886a-cef5-47dc-8769-1a8b41bebbb0")]
    [NativeName("Name", "IDWriteFontFile")]
    public unsafe partial struct IDWriteFontFile : IComVtbl<IDWriteFontFile>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("739d886a-cef5-47dc-8769-1a8b41bebbb0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFile val)
            => Unsafe.As<IDWriteFontFile, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFile
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
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReferenceKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, uint* fontFileReferenceKeySize)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReferenceKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fontFileReferenceKey, ref uint fontFileReferenceKeySize)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* fontFileReferenceKeySizePtr = &fontFileReferenceKeySize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReferenceKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fontFileReferenceKey, uint* fontFileReferenceKeySize)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetReferenceKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fontFileReferenceKey, ref uint fontFileReferenceKeySize)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (uint* fontFileReferenceKeySizePtr = &fontFileReferenceKeySize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, void**, uint*, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLoader(IDWriteFontFileLoader** fontFileLoader)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLoader(ref IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader** fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, IDWriteFontFileLoader**, int>)@this->LpVtbl[4])(@this, fontFileLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFaces);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numberOfFacesPtr = &numberOfFaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceType, numberOfFacesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceTypePtr, numberOfFaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileType, fontFaceTypePtr, numberOfFacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceType, numberOfFaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceType, numberOfFacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceTypePtr, numberOfFaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(int* isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FontFileType* fontFileTypePtr = &fontFileType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    fixed (uint* numberOfFacesPtr = &numberOfFaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontType, fontFileTypePtr, fontFaceTypePtr, numberOfFacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceType, numberOfFaces);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, FontFileType* fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (uint* numberOfFacesPtr = &numberOfFaces)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceType, numberOfFacesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceTypePtr, numberOfFaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, FontFileType* fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                {
                    fixed (uint* numberOfFacesPtr = &numberOfFaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileType, fontFaceTypePtr, numberOfFacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFileType* fontFileTypePtr = &fontFileType)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceType, numberOfFaces);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, ref FontFileType fontFileType, FontFaceType* fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFileType* fontFileTypePtr = &fontFileType)
                {
                    fixed (uint* numberOfFacesPtr = &numberOfFaces)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceType, numberOfFacesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Analyze(ref int isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, uint* numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFileType* fontFileTypePtr = &fontFileType)
                {
                    fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceTypePtr, numberOfFaces);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Analyze(ref int isSupportedFontType, ref FontFileType fontFileType, ref FontFaceType fontFaceType, ref uint numberOfFaces)
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isSupportedFontTypePtr = &isSupportedFontType)
            {
                fixed (FontFileType* fontFileTypePtr = &fontFileType)
                {
                    fixed (FontFaceType* fontFaceTypePtr = &fontFaceType)
                    {
                        fixed (uint* numberOfFacesPtr = &numberOfFaces)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFile*, int*, FontFileType*, FontFaceType*, uint*, int>)@this->LpVtbl[5])(@this, isSupportedFontTypePtr, fontFileTypePtr, fontFaceTypePtr, numberOfFacesPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLoader<TI0>(ref ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetLoader((IDWriteFontFileLoader**) fontFileLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFile*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
