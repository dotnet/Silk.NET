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
    [Guid("3d4c0c61-18a4-41e4-bd80-481a4fc9f464")]
    [NativeName("Name", "IWICDdsFrameDecode")]
    public unsafe partial struct IWICDdsFrameDecode : IComVtbl<IWICDdsFrameDecode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3d4c0c61-18a4-41e4-bd80-481a4fc9f464");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICDdsFrameDecode val)
            => Unsafe.As<IWICDdsFrameDecode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICDdsFrameDecode
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
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocks, pHeightInBlocks);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeInBlocks(uint* pWidthInBlocks, ref uint pHeightInBlocks)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pHeightInBlocksPtr = &pHeightInBlocks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocks, pHeightInBlocksPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSizeInBlocks(ref uint pWidthInBlocks, uint* pHeightInBlocks)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthInBlocksPtr = &pWidthInBlocks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocksPtr, pHeightInBlocks);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSizeInBlocks(ref uint pWidthInBlocks, ref uint pHeightInBlocks)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthInBlocksPtr = &pWidthInBlocks)
            {
                fixed (uint* pHeightInBlocksPtr = &pHeightInBlocks)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pWidthInBlocksPtr, pHeightInBlocksPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFormatInfo(DdsFormatInfo* pFormatInfo)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, DdsFormatInfo*, int>)@this->LpVtbl[4])(@this, pFormatInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFormatInfo(ref DdsFormatInfo pFormatInfo)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DdsFormatInfo* pFormatInfoPtr = &pFormatInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, DdsFormatInfo*, int>)@this->LpVtbl[4])(@this, pFormatInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocks, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, ref byte pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyBlocks([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Rectangle<int> prcBoundsInBlocks, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer)
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* prcBoundsInBlocksPtr = &prcBoundsInBlocks)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICDdsFrameDecode*, Silk.NET.Maths.Rectangle<int>*, uint, uint, byte*, int>)@this->LpVtbl[5])(@this, prcBoundsInBlocksPtr, cbStride, cbBufferSize, pbBufferPtr);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICDdsFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
