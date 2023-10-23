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
    [Guid("5cacdb4c-407e-41b3-b936-d0f010cd6732")]
    [NativeName("Name", "IWICDdsEncoder")]
    public unsafe partial struct IWICDdsEncoder : IComVtbl<IWICDdsEncoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5cacdb4c-407e-41b3-b936-d0f010cd6732");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICDdsEncoder val)
            => Unsafe.As<IWICDdsEncoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICDdsEncoder
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
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetParameters(DdsParameters* pParameters)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetParameters(ref DdsParameters pParameters)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DdsParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[3])(@this, pParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParameters(DdsParameters* pParameters)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[4])(@this, pParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParameters(ref DdsParameters pParameters)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DdsParameters* pParametersPtr = &pParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, DdsParameters*, int>)@this->LpVtbl[4])(@this, pParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSliceIndexPtr = &pSliceIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevel, pSliceIndexPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevelPtr, pSliceIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMipLevelPtr = &pMipLevel)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndex, pMipLevelPtr, pSliceIndexPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevel, pSliceIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevel, pSliceIndexPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevelPtr, pSliceIndex);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(IWICBitmapFrameEncode** ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pArrayIndexPtr = &pArrayIndex)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    fixed (uint* pSliceIndexPtr = &pSliceIndex)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncode, pArrayIndexPtr, pMipLevelPtr, pSliceIndexPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevel, pSliceIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pSliceIndexPtr = &pSliceIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevel, pSliceIndexPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevelPtr, pSliceIndex);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pMipLevelPtr = &pMipLevel)
                {
                    fixed (uint* pSliceIndexPtr = &pSliceIndex)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndex, pMipLevelPtr, pSliceIndexPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pArrayIndexPtr = &pArrayIndex)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevel, pSliceIndex);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pArrayIndexPtr = &pArrayIndex)
                {
                    fixed (uint* pSliceIndexPtr = &pSliceIndex)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevel, pSliceIndexPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pArrayIndexPtr = &pArrayIndex)
                {
                    fixed (uint* pMipLevelPtr = &pMipLevel)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevelPtr, pSliceIndex);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame(ref IWICBitmapFrameEncode* ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex)
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode** ppIFrameEncodePtr = &ppIFrameEncode)
            {
                fixed (uint* pArrayIndexPtr = &pArrayIndex)
                {
                    fixed (uint* pMipLevelPtr = &pMipLevel)
                    {
                        fixed (uint* pSliceIndexPtr = &pSliceIndex)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICDdsEncoder*, IWICBitmapFrameEncode**, uint*, uint*, uint*, int>)@this->LpVtbl[5])(@this, ppIFrameEncodePtr, pArrayIndexPtr, pMipLevelPtr, pSliceIndexPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, pMipLevel, pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, uint* pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, pMipLevel, ref pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, ref pMipLevel, pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, uint* pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), pArrayIndex, ref pMipLevel, ref pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, pMipLevel, pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, uint* pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, pMipLevel, ref pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, uint* pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, ref pMipLevel, pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNewFrame<TI0>(ref ComPtr<TI0> ppIFrameEncode, ref uint pArrayIndex, ref uint pMipLevel, ref uint pSliceIndex) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNewFrame((IWICBitmapFrameEncode**) ppIFrameEncode.GetAddressOf(), ref pArrayIndex, ref pMipLevel, ref pSliceIndex);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
