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

namespace Silk.NET.Direct3D11
{
    [Guid("465217f2-5568-43cf-b5b9-f61d54531ca1")]
    [NativeName("Name", "ID3D11VideoProcessorEnumerator1")]
    public unsafe partial struct ID3D11VideoProcessorEnumerator1 : IComVtbl<ID3D11VideoProcessorEnumerator1>, IComVtbl<ID3D11VideoProcessorEnumerator>, IComVtbl<ID3D11DeviceChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("465217f2-5568-43cf-b5b9-f61d54531ca1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D11VideoProcessorEnumerator(ID3D11VideoProcessorEnumerator1 val)
            => Unsafe.As<ID3D11VideoProcessorEnumerator1, ID3D11VideoProcessorEnumerator>(ref val);

        public static implicit operator ID3D11DeviceChild(ID3D11VideoProcessorEnumerator1 val)
            => Unsafe.As<ID3D11VideoProcessorEnumerator1, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoProcessorEnumerator1 val)
            => Unsafe.As<ID3D11VideoProcessorEnumerator1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoProcessorEnumerator1
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
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, ID3D11Device**, void>)@this->LpVtbl[3])(@this, ppDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint*, void*, int>)@this->LpVtbl[4])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, uint, void*, int>)@this->LpVtbl[5])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[6])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorContentDesc(VideoProcessorContentDesc* pContentDesc)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorContentDesc*, int>)@this->LpVtbl[7])(@this, pContentDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoProcessorFormat(Silk.NET.DXGI.Format Format, uint* pFlags)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, uint*, int>)@this->LpVtbl[8])(@this, Format, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCaps(VideoProcessorCaps* pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorCaps*, int>)@this->LpVtbl[9])(@this, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorRateConversionCaps(uint TypeIndex, VideoProcessorRateConversionCaps* pCaps)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, VideoProcessorRateConversionCaps*, int>)@this->LpVtbl[10])(@this, TypeIndex, pCaps);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorCustomRate(uint TypeIndex, uint CustomRateIndex, VideoProcessorCustomRate* pRate)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, uint, uint, VideoProcessorCustomRate*, int>)@this->LpVtbl[11])(@this, TypeIndex, CustomRateIndex, pRate);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVideoProcessorFilterRange(VideoProcessorFilter Filter, VideoProcessorFilterRange* pRange)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, VideoProcessorFilter, VideoProcessorFilterRange*, int>)@this->LpVtbl[12])(@this, Filter, pRange);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckVideoProcessorFormatConversion(Silk.NET.DXGI.Format InputFormat, Silk.NET.DXGI.ColorSpaceType InputColorSpace, Silk.NET.DXGI.Format OutputFormat, Silk.NET.DXGI.ColorSpaceType OutputColorSpace, int* pSupported)
        {
            var @this = (ID3D11VideoProcessorEnumerator1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoProcessorEnumerator1*, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, Silk.NET.DXGI.Format, Silk.NET.DXGI.ColorSpaceType, int*, int>)@this->LpVtbl[13])(@this, InputFormat, InputColorSpace, OutputFormat, OutputColorSpace, pSupported);
            return ret;
        }

    }
}
