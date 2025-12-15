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
    [Guid("597985ab-9b75-4dbb-be23-0761195bebee")]
    [NativeName("Name", "ID3D12GBVDiagnostics")]
    public unsafe partial struct ID3D12GBVDiagnostics : IComVtbl<ID3D12GBVDiagnostics>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("597985ab-9b75-4dbb-be23-0761195bebee");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12GBVDiagnostics val)
            => Unsafe.As<ID3D12GBVDiagnostics, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12GBVDiagnostics
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
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVEntireSubresourceStatesData(ID3D12Resource* pResource, int* pData, uint DataSize)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResource, pData, DataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVEntireSubresourceStatesData(ID3D12Resource* pResource, ref int pData, uint DataSize)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResource, pDataPtr, DataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVEntireSubresourceStatesData(ref ID3D12Resource pResource, int* pData, uint DataSize)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResourcePtr, pData, DataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVEntireSubresourceStatesData(ref ID3D12Resource pResource, ref int pData, uint DataSize)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (int* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, uint, int>)@this->LpVtbl[3])(@this, pResourcePtr, pDataPtr, DataSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVSubresourceState(ID3D12Resource* pResource, uint Subresource, int* pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResource, Subresource, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVSubresourceState(ID3D12Resource* pResource, uint Subresource, ref int pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResource, Subresource, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVSubresourceState(ref ID3D12Resource pResource, uint Subresource, int* pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVSubresourceState(ref ID3D12Resource pResource, uint Subresource, ref int pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (int* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, uint, int*, int>)@this->LpVtbl[4])(@this, pResourcePtr, Subresource, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceUniformState(ID3D12Resource* pResource, int* pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResource, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceUniformState(ID3D12Resource* pResource, ref int pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResource, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceUniformState(ref ID3D12Resource pResource, int* pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResourcePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVResourceUniformState(ref ID3D12Resource pResource, ref int pData)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (int* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, int*, int>)@this->LpVtbl[5])(@this, pResourcePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHash, pSubresourceStatesByteOffsetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pResourceHashPtr = &pResourceHash)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ID3D12Resource* pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResource, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHash, pSubresourceStatesByteOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* pResourceHashPtr = &pResourceHash)
                {
                    fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDesc, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
                {
                    fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHash, pSubresourceStatesByteOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo(ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
                {
                    fixed (uint* pResourceHashPtr = &pResourceHash)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffset);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVResourceInfo(ref ID3D12Resource pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset)
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (ResourceDesc* pResourceDescPtr = &pResourceDesc)
                {
                    fixed (uint* pResourceHashPtr = &pResourceHash)
                    {
                        fixed (uint* pSubresourceStatesByteOffsetPtr = &pSubresourceStatesByteOffset)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, ID3D12Resource*, ResourceDesc*, uint*, uint*, int>)@this->LpVtbl[6])(@this, pResourcePtr, pResourceDescPtr, pResourceHashPtr, pSubresourceStatesByteOffsetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void GBVReserved0()
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, void>)@this->LpVtbl[7])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void GBVReserved1()
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GBVDiagnostics*, void>)@this->LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVEntireSubresourceStatesData<TI0>(ComPtr<TI0> pResource, int* pData, uint DataSize) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVEntireSubresourceStatesData((ID3D12Resource*) pResource.Handle, pData, DataSize);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVEntireSubresourceStatesData<TI0>(ComPtr<TI0> pResource, ref int pData, uint DataSize) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVEntireSubresourceStatesData((ID3D12Resource*) pResource.Handle, ref pData, DataSize);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVSubresourceState<TI0>(ComPtr<TI0> pResource, uint Subresource, int* pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVSubresourceState((ID3D12Resource*) pResource.Handle, Subresource, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVSubresourceState<TI0>(ComPtr<TI0> pResource, uint Subresource, ref int pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVSubresourceState((ID3D12Resource*) pResource.Handle, Subresource, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceUniformState<TI0>(ComPtr<TI0> pResource, int* pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceUniformState((ID3D12Resource*) pResource.Handle, pData);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVResourceUniformState<TI0>(ComPtr<TI0> pResource, ref int pData) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceUniformState((ID3D12Resource*) pResource.Handle, ref pData);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, ref pResourceHash, pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ResourceDesc* pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, pResourceDesc, ref pResourceHash, ref pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, pResourceHash, pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, uint* pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, pResourceHash, ref pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, uint* pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, ref pResourceHash, pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGBVResourceInfo<TI0>(ComPtr<TI0> pResource, ref ResourceDesc pResourceDesc, ref uint pResourceHash, ref uint pSubresourceStatesByteOffset) where TI0 : unmanaged, IComVtbl<ID3D12Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGBVResourceInfo((ID3D12Resource*) pResource.Handle, ref pResourceDesc, ref pResourceHash, ref pSubresourceStatesByteOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12GBVDiagnostics*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
