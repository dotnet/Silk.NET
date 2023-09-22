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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("969dc708-5c76-11d1-8d86-0000f804b057")]
    [NativeName("Name", "IThumbnailExtractor")]
    public unsafe partial struct IThumbnailExtractor : IComVtbl<IThumbnailExtractor>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("969dc708-5c76-11d1-8d86-0000f804b057");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IThumbnailExtractor val)
            => Unsafe.As<IThumbnailExtractor, Silk.NET.Core.Native.IUnknown>(ref val);

        public IThumbnailExtractor
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
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** phOutputBitmapPtr = &phOutputBitmap)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(IStorage* pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulOutputLengthPtr = &pulOutputLength)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStg, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                {
                    fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLength, pulOutputHeightPtr, phOutputBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputLengthPtr = &pulOutputLength)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputLengthPtr = &pulOutputLength)
                {
                    fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeight, phOutputBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputLengthPtr = &pulOutputLength)
                {
                    fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail(ref IStorage pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                fixed (uint* pulOutputLengthPtr = &pulOutputLength)
                {
                    fixed (uint* pulOutputHeightPtr = &pulOutputHeight)
                    {
                        fixed (void** phOutputBitmapPtr = &phOutputBitmap)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, uint, uint, uint*, uint*, void**, int>)@this->LpVtbl[3])(@this, pStgPtr, ulLength, ulHeight, pulOutputLengthPtr, pulOutputHeightPtr, phOutputBitmapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OnFileUpdated(IStorage* pStg)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, int>)@this->LpVtbl[4])(@this, pStg);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OnFileUpdated(ref IStorage pStg)
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IStorage* pStgPtr = &pStg)
            {
                ret = ((delegate* unmanaged[Cdecl]<IThumbnailExtractor*, IStorage*, int>)@this->LpVtbl[4])(@this, pStgPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, pulOutputHeight, ref phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight, phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, uint* pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, pulOutputLength, ref pulOutputHeight, ref phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, pulOutputHeight, phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, uint* pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, pulOutputHeight, ref phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, void** phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, ref pulOutputHeight, phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ExtractThumbnail<TI0>(ComPtr<TI0> pStg, uint ulLength, uint ulHeight, ref uint pulOutputLength, ref uint pulOutputHeight, ref void* phOutputBitmap) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ExtractThumbnail((IStorage*) pStg.Handle, ulLength, ulHeight, ref pulOutputLength, ref pulOutputHeight, ref phOutputBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly int OnFileUpdated<TI0>(ComPtr<TI0> pStg) where TI0 : unmanaged, IComVtbl<IStorage>, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->OnFileUpdated((IStorage*) pStg.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IThumbnailExtractor*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
