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

namespace Silk.NET.Direct3D12
{
    [Guid("01d393c5-c9b0-42a1-958c-c26b02d4d097")]
    [NativeName("Name", "ID3D12Tools2")]
    public unsafe partial struct ID3D12Tools2 : IComVtbl<ID3D12Tools2>, IComVtbl<ID3D12Tools1>, IComVtbl<ID3D12Tools>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("01d393c5-c9b0-42a1-958c-c26b02d4d097");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Tools1(ID3D12Tools2 val)
            => Unsafe.As<ID3D12Tools2, ID3D12Tools1>(ref val);

        public static implicit operator ID3D12Tools(ID3D12Tools2 val)
            => Unsafe.As<ID3D12Tools2, ID3D12Tools>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Tools2 val)
            => Unsafe.As<ID3D12Tools2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Tools2
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
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void EnableShaderInstrumentation(Silk.NET.Core.Bool32 bEnable)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[3])(@this, bEnable);
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 ShaderInstrumentationEnabled()
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Bool32>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReserveGPUVARangesAtCreate(GpuVirtualAddressRange* pRanges, uint uiNumRanges)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, GpuVirtualAddressRange*, uint, int>)@this->LpVtbl[5])(@this, pRanges, uiNumRanges);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReserveGPUVARangesAtCreate(ref GpuVirtualAddressRange pRanges, uint uiNumRanges)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GpuVirtualAddressRange* pRangesPtr = &pRanges)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, GpuVirtualAddressRange*, uint, int>)@this->LpVtbl[5])(@this, pRangesPtr, uiNumRanges);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearReservedGPUVARangesList()
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, void>)@this->LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetApplicationSpecificDriverState(Silk.NET.Core.Native.IUnknown* pAdapter, Silk.NET.Core.Native.ID3D10Blob* pBlob)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapter, pBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetApplicationSpecificDriverState(Silk.NET.Core.Native.IUnknown* pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapter, pBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetApplicationSpecificDriverState(ref Silk.NET.Core.Native.IUnknown pAdapter, Silk.NET.Core.Native.ID3D10Blob* pBlob)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pAdapterPtr = &pAdapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapterPtr, pBlob);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationSpecificDriverState(ref Silk.NET.Core.Native.IUnknown pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob)
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pAdapterPtr = &pAdapter)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob* pBlobPtr = &pBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Tools2*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.ID3D10Blob*, int>)@this->LpVtbl[7])(@this, pAdapterPtr, pBlobPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationSpecificDriverState<TI0, TI1>(ComPtr<TI0> pAdapter, ComPtr<TI1> pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetApplicationSpecificDriverState((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, (Silk.NET.Core.Native.ID3D10Blob*) pBlob.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationSpecificDriverState<TI0>(ComPtr<TI0> pAdapter, ref Silk.NET.Core.Native.ID3D10Blob pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetApplicationSpecificDriverState((Silk.NET.Core.Native.IUnknown*) pAdapter.Handle, ref pBlob);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationSpecificDriverState<TI0>(ref Silk.NET.Core.Native.IUnknown pAdapter, ComPtr<TI0> pBlob) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetApplicationSpecificDriverState(ref pAdapter, (Silk.NET.Core.Native.ID3D10Blob*) pBlob.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Tools2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
