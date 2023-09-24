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
    [Guid("00000123-a8f2-4877-ba0a-fd2b6645fb94")]
    [NativeName("Name", "IWICBitmapLock")]
    public unsafe partial struct IWICBitmapLock : IComVtbl<IWICBitmapLock>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000123-a8f2-4877-ba0a-fd2b6645fb94");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapLock val)
            => Unsafe.As<IWICBitmapLock, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapLock
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
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(uint* puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiHeightPtr = &puiHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidth, puiHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSize(ref uint puiWidth, uint* puiHeight)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSize(ref uint puiWidth, ref uint puiHeight)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiWidthPtr = &puiWidth)
            {
                fixed (uint* puiHeightPtr = &puiHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, uint*, int>)@this->LpVtbl[3])(@this, puiWidthPtr, puiHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStride(uint* pcbStride)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, int>)@this->LpVtbl[4])(@this, pcbStride);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStride(ref uint pcbStride)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbStridePtr = &pcbStride)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, int>)@this->LpVtbl[4])(@this, pcbStridePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataPointer(uint* pcbBufferSize, byte** ppbData)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSize, ppbData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataPointer(uint* pcbBufferSize, ref byte* ppbData)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte** ppbDataPtr = &ppbData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSize, ppbDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataPointer(ref uint pcbBufferSize, byte** ppbData)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbBufferSizePtr = &pcbBufferSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSizePtr, ppbData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataPointer(ref uint pcbBufferSize, ref byte* ppbData)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbBufferSizePtr = &pcbBufferSize)
            {
                fixed (byte** ppbDataPtr = &ppbData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pcbBufferSizePtr, ppbDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormat(Guid* pPixelFormat)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormat(ref Guid pPixelFormat)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pPixelFormatPtr = &pPixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapLock*, Guid*, int>)@this->LpVtbl[6])(@this, pPixelFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDataPointer(uint* pcbBufferSize, string[] ppbDataSa)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppbData = (byte**) SilkMarshal.StringArrayToPtr(ppbDataSa);
            var ret = @this->GetDataPointer(pcbBufferSize, ppbData);
            SilkMarshal.CopyPtrToStringArray((nint) ppbData, ppbDataSa);
            SilkMarshal.Free((nint) ppbData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDataPointer(ref uint pcbBufferSize, string[] ppbDataSa)
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var ppbData = (byte**) SilkMarshal.StringArrayToPtr(ppbDataSa);
            var ret = @this->GetDataPointer(ref pcbBufferSize, ppbData);
            SilkMarshal.CopyPtrToStringArray((nint) ppbData, ppbDataSa);
            SilkMarshal.Free((nint) ppbData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapLock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
