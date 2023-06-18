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
    [Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3")]
    [NativeName("Name", "ID3D12PipelineLibrary1")]
    public unsafe partial struct ID3D12PipelineLibrary1 : IComVtbl<ID3D12PipelineLibrary1>, IComVtbl<ID3D12PipelineLibrary>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("80eabf42-2568-4e5e-bd82-c37f86961dc3");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12PipelineLibrary(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12PipelineLibrary>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12PipelineLibrary1 val)
            => Unsafe.As<ID3D12PipelineLibrary1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12PipelineLibrary1
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
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, ID3D12PipelineState* pPipeline)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ID3D12PipelineState*, int>)@this->LpVtbl[8])(@this, pName, pPipeline);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadGraphicsPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GraphicsPipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, GraphicsPipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadComputePipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComputePipelineStateDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, ComputePipelineStateDesc*, Guid*, void**, int>)@this->LpVtbl[10])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetSerializedSize()
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, nuint>)@this->LpVtbl[11])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(void* pData, nuint DataSizeInBytes)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, void*, nuint, int>)@this->LpVtbl[12])(@this, pData, DataSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadPipeline([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc, Guid* riid, void** ppPipelineState)
        {
            var @this = (ID3D12PipelineLibrary1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12PipelineLibrary1*, char*, PipelineStateStreamDesc*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pName, pDesc, riid, ppPipelineState);
            return ret;
        }

    }
}
