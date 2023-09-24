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
    [Guid("8939f66e-c46a-4c21-a9d1-98b327ce1679")]
    [NativeName("Name", "IWICJpegFrameDecode")]
    public unsafe partial struct IWICJpegFrameDecode : IComVtbl<IWICJpegFrameDecode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8939f66e-c46a-4c21-a9d1-98b327ce1679");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICJpegFrameDecode val)
            => Unsafe.As<IWICJpegFrameDecode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICJpegFrameDecode
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
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportIndexing(int* pfIndexingSupported)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int*, int>)@this->LpVtbl[3])(@this, pfIndexingSupported);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportIndexing(ref int pfIndexingSupported)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfIndexingSupportedPtr = &pfIndexingSupported)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int*, int>)@this->LpVtbl[3])(@this, pfIndexingSupportedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetIndexing(JpegIndexingOptions options, uint horizontalIntervalSize)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegIndexingOptions, uint, int>)@this->LpVtbl[4])(@this, options, horizontalIntervalSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ClearIndexing()
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAcHuffmanTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[6])(@this, scanIndex, tableIndex, pAcHuffmanTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAcHuffmanTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegACHuffmanTable pAcHuffmanTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTablePtr = &pAcHuffmanTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[6])(@this, scanIndex, tableIndex, pAcHuffmanTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDcHuffmanTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[7])(@this, scanIndex, tableIndex, pDcHuffmanTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDcHuffmanTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegDCHuffmanTable pDcHuffmanTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTablePtr = &pDcHuffmanTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[7])(@this, scanIndex, tableIndex, pDcHuffmanTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetQuantizationTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[8])(@this, scanIndex, tableIndex, pQuantizationTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetQuantizationTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegQuantizationTable pQuantizationTable)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTablePtr = &pQuantizationTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[8])(@this, scanIndex, tableIndex, pQuantizationTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameHeader(JpegFrameHeader* pFrameHeader)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegFrameHeader*, int>)@this->LpVtbl[9])(@this, pFrameHeader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameHeader(ref JpegFrameHeader pFrameHeader)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (JpegFrameHeader* pFrameHeaderPtr = &pFrameHeader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, JpegFrameHeader*, int>)@this->LpVtbl[9])(@this, pFrameHeaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetScanHeader(uint scanIndex, JpegScanHeader* pScanHeader)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, JpegScanHeader*, int>)@this->LpVtbl[10])(@this, scanIndex, pScanHeader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetScanHeader(uint scanIndex, ref JpegScanHeader pScanHeader)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (JpegScanHeader* pScanHeaderPtr = &pScanHeader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, JpegScanHeader*, int>)@this->LpVtbl[10])(@this, scanIndex, pScanHeaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, uint* pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, byte* pbScanData, ref uint pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanData, pcbScanDataActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, ref byte pbScanData, uint* pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbScanDataPtr = &pbScanData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, ref byte pbScanData, ref uint pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbScanDataPtr = &pbScanData)
            {
                fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData, uint* pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActual);
            SilkMarshal.Free((nint)pbScanDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyScan(uint scanIndex, uint scanOffset, uint cbScanData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData, ref uint pcbScanDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
            fixed (uint* pcbScanDataActualPtr = &pcbScanDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, uint, byte*, uint*, int>)@this->LpVtbl[11])(@this, scanIndex, scanOffset, cbScanData, pbScanDataPtr, pcbScanDataActualPtr);
            }
            SilkMarshal.Free((nint)pbScanDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, uint* pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyMinimalStream(uint streamOffset, uint cbStreamData, byte* pbStreamData, ref uint pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamData, pcbStreamDataActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyMinimalStream(uint streamOffset, uint cbStreamData, ref byte pbStreamData, uint* pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbStreamDataPtr = &pbStreamData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyMinimalStream(uint streamOffset, uint cbStreamData, ref byte pbStreamData, ref uint pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbStreamDataPtr = &pbStreamData)
            {
                fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CopyMinimalStream(uint streamOffset, uint cbStreamData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbStreamData, uint* pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbStreamDataPtr = (byte*) SilkMarshal.StringToPtr(pbStreamData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActual);
            SilkMarshal.Free((nint)pbStreamDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CopyMinimalStream(uint streamOffset, uint cbStreamData, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbStreamData, ref uint pcbStreamDataActual)
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbStreamDataPtr = (byte*) SilkMarshal.StringToPtr(pbStreamData, NativeStringEncoding.UTF8);
            fixed (uint* pcbStreamDataActualPtr = &pcbStreamDataActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameDecode*, uint, uint, byte*, uint*, int>)@this->LpVtbl[12])(@this, streamOffset, cbStreamData, pbStreamDataPtr, pcbStreamDataActualPtr);
            }
            SilkMarshal.Free((nint)pbStreamDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICJpegFrameDecode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
