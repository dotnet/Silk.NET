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
    [Guid("ed342442-6343-4e16-bb82-a3a577874e56")]
    [NativeName("Name", "ID3D12DeviceConfiguration1")]
    public unsafe partial struct ID3D12DeviceConfiguration1 : IComVtbl<ID3D12DeviceConfiguration1>, IComVtbl<ID3D12DeviceConfiguration>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ed342442-6343-4e16-bb82-a3a577874e56");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12DeviceConfiguration(ID3D12DeviceConfiguration1 val)
            => Unsafe.As<ID3D12DeviceConfiguration1, ID3D12DeviceConfiguration>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceConfiguration1 val)
            => Unsafe.As<ID3D12DeviceConfiguration1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceConfiguration1
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
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly DeviceConfigurationDesc GetDesc()
        {
            DeviceConfigurationDesc silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeviceConfigurationDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, DeviceConfigurationDesc*, DeviceConfigurationDesc*>)@this->LpVtbl[3])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEnabledExperimentalFeatures(Guid* pGuids, uint NumGuids)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, uint, int>)@this->LpVtbl[4])(@this, pGuids, NumGuids);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEnabledExperimentalFeatures(ref Guid pGuids, uint NumGuids)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pGuidsPtr = &pGuids)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, Guid*, uint, int>)@this->LpVtbl[4])(@this, pGuidsPtr, NumGuids);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResult, ppError);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResult, ppErrorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResultPtr, ppError);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDesc, ppResultPtr, ppErrorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResult, ppError);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, Silk.NET.Core.Native.ID3D10Blob** ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResult, ppErrorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, Silk.NET.Core.Native.ID3D10Blob** ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResultPtr, ppError);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VersionedRootSignatureDesc* pDescPtr = &pDesc)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppResultPtr = &ppResult)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorPtr = &ppError)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, VersionedRootSignatureDesc*, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[5])(@this, pDescPtr, ppResultPtr, ppErrorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Guid* riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riid, ppvDeserializer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, Guid* riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDeserializerPtr = &ppvDeserializer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riid, ppvDeserializerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, ref Guid riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riidPtr, ppvDeserializer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, ref Guid riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlob, Size, riidPtr, ppvDeserializerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobPtr = &pBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riid, ppvDeserializer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobPtr = &pBlob)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riid, ppvDeserializerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, ref Guid riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobPtr = &pBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riidPtr, ppvDeserializer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, ref Guid riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pBlobPtr = &pBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, Guid*, void**, int>)@this->LpVtbl[6])(@this, pBlobPtr, Size, riidPtr, ppvDeserializerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectName, riid, ppvDeserializer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDeserializerPtr = &ppvDeserializer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectName, riid, ppvDeserializerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectName, riidPtr, ppvDeserializer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectName, riidPtr, ppvDeserializerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializer);
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
            fixed (void** ppvDeserializerPtr = &ppvDeserializer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializerPtr);
            }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializer);
            }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer)
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlob, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializerPtr);
                }
            }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectName, riid, ppvDeserializer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectName, riid, ppvDeserializerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectName, riidPtr, ppvDeserializer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectName, riidPtr, ppvDeserializerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
                {
                    fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializerPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
                fixed (char* RootSignatureSubobjectNamePtr = &RootSignatureSubobjectName)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, char*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializerPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, Guid* riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializer);
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, Guid* riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
                fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riid, ppvDeserializerPtr);
                }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, ref Guid riid, void** ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializer);
                }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, ref Guid riid, ref void* ppvDeserializer) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pLibraryBlobPtr = &pLibraryBlob)
            {
            var RootSignatureSubobjectNamePtr = (byte*) SilkMarshal.StringToPtr(RootSignatureSubobjectName, NativeStringEncoding.LPWStr);
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDeserializerPtr = &ppvDeserializer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceConfiguration1*, void*, nuint, byte*, Guid*, void**, int>)@this->LpVtbl[7])(@this, pLibraryBlobPtr, Size, RootSignatureSubobjectNamePtr, riidPtr, ppvDeserializerPtr);
                    }
                }
            SilkMarshal.Free((nint)RootSignatureSubobjectNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref ComPtr<TI0> ppResult, ref ComPtr<TI1> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref ComPtr<TI0> ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), ref ppError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] VersionedRootSignatureDesc* pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(pDesc, ref ppResult, (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SerializeVersionedRootSignature<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref ComPtr<TI0> ppResult, ref ComPtr<TI1> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(in pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref ComPtr<TI0> ppResult, ref Silk.NET.Core.Native.ID3D10Blob* ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(in pDesc, (Silk.NET.Core.Native.ID3D10Blob**) ppResult.GetAddressOf(), ref ppError);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeVersionedRootSignature<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VersionedRootSignatureDesc pDesc, ref Silk.NET.Core.Native.ID3D10Blob* ppResult, ref ComPtr<TI0> ppError) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SerializeVersionedRootSignature(in pDesc, ref ppResult, (Silk.NET.Core.Native.ID3D10Blob**) ppError.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size, out ComPtr<TI0> ppvDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializer(pBlob, Size, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVersionedRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size, out ComPtr<TI0> ppvDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializer(in pBlob, Size, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, in RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, in RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName, out ComPtr<TI0> ppvDeserializer) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDeserializer = default;
            return @this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, RootSignatureSubobjectName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDeserializer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializer<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pBlob, nuint Size) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializer(pBlob, Size, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVersionedRootSignatureDeserializer<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pBlob, nuint Size) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializer(in pBlob, Size, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, in RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(pLibraryBlob, Size, RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* RootSignatureSubobjectName) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char RootSignatureSubobjectName) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, in RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pLibraryBlob, nuint Size, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string RootSignatureSubobjectName) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceConfiguration1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateVersionedRootSignatureDeserializerFromSubobjectInLibrary(in pLibraryBlob, Size, RootSignatureSubobjectName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
