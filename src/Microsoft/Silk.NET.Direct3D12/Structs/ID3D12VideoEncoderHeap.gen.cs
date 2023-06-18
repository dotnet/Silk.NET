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
    [Guid("22b35d96-876a-44c0-b25e-fb8c9c7f1c4a")]
    [NativeName("Name", "ID3D12VideoEncoderHeap")]
    public unsafe partial struct ID3D12VideoEncoderHeap : IComVtbl<ID3D12VideoEncoderHeap>, IComVtbl<ID3D12Pageable>, IComVtbl<ID3D12DeviceChild>, IComVtbl<ID3D12Object>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("22b35d96-876a-44c0-b25e-fb8c9c7f1c4a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12Pageable(ID3D12VideoEncoderHeap val)
            => Unsafe.As<ID3D12VideoEncoderHeap, ID3D12Pageable>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoEncoderHeap val)
            => Unsafe.As<ID3D12VideoEncoderHeap, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoEncoderHeap val)
            => Unsafe.As<ID3D12VideoEncoderHeap, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoEncoderHeap val)
            => Unsafe.As<ID3D12VideoEncoderHeap, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoEncoderHeap
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
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, Guid*, uint*, void*, int>)@this->LpVtbl[3])(@this, guid, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, Guid*, uint, void*, int>)@this->LpVtbl[4])(@this, guid, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[5])(@this, guid, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* Name)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, char*, int>)@this->LpVtbl[6])(@this, Name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNodeMask()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, uint>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly VideoEncoderHeapFlags GetEncoderHeapFlags()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            VideoEncoderHeapFlags ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, VideoEncoderHeapFlags>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly VideoEncoderCodec GetCodec()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            VideoEncoderCodec ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, VideoEncoderCodec>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCodecProfile(VideoEncoderProfileDesc dstProfile)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, VideoEncoderProfileDesc, int>)@this->LpVtbl[11])(@this, dstProfile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCodecLevel(VideoEncoderLevelSetting dstLevel)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, VideoEncoderLevelSetting, int>)@this->LpVtbl[12])(@this, dstLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetResolutionListCount()
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, uint>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResolutionList(uint ResolutionsListCount, VideoEncoderPictureResolutionDesc* pResolutionList)
        {
            var @this = (ID3D12VideoEncoderHeap*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoEncoderHeap*, uint, VideoEncoderPictureResolutionDesc*, int>)@this->LpVtbl[14])(@this, ResolutionsListCount, pResolutionList);
            return ret;
        }

    }
}
