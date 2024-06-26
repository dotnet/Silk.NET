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
    [Guid("2f0c601f-d2c6-468c-abfa-49495d983ed1")]
    [NativeName("Name", "IWICJpegFrameEncode")]
    public unsafe partial struct IWICJpegFrameEncode : IComVtbl<IWICJpegFrameEncode>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("2f0c601f-d2c6-468c-abfa-49495d983ed1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICJpegFrameEncode val)
            => Unsafe.As<IWICJpegFrameEncode, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICJpegFrameEncode
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
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAcHuffmanTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[3])(@this, scanIndex, tableIndex, pAcHuffmanTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAcHuffmanTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegACHuffmanTable pAcHuffmanTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegACHuffmanTable* pAcHuffmanTablePtr = &pAcHuffmanTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegACHuffmanTable*, int>)@this->LpVtbl[3])(@this, scanIndex, tableIndex, pAcHuffmanTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDcHuffmanTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[4])(@this, scanIndex, tableIndex, pDcHuffmanTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDcHuffmanTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegDCHuffmanTable pDcHuffmanTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegDCHuffmanTable* pDcHuffmanTablePtr = &pDcHuffmanTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegDCHuffmanTable*, int>)@this->LpVtbl[4])(@this, scanIndex, tableIndex, pDcHuffmanTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetQuantizationTable(uint scanIndex, uint tableIndex, Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[5])(@this, scanIndex, tableIndex, pQuantizationTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetQuantizationTable(uint scanIndex, uint tableIndex, ref Silk.NET.DXGI.JpegQuantizationTable pQuantizationTable)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.JpegQuantizationTable* pQuantizationTablePtr = &pQuantizationTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, uint, Silk.NET.DXGI.JpegQuantizationTable*, int>)@this->LpVtbl[5])(@this, scanIndex, tableIndex, pQuantizationTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteScan(uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbScanData)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteScan(uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbScanData)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbScanDataPtr = &pbScanData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteScan(uint cbScanData, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbScanData)
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbScanDataPtr = (byte*) SilkMarshal.StringToPtr(pbScanData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICJpegFrameEncode*, uint, byte*, int>)@this->LpVtbl[6])(@this, cbScanData, pbScanDataPtr);
            SilkMarshal.Free((nint)pbScanDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICJpegFrameEncode*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
