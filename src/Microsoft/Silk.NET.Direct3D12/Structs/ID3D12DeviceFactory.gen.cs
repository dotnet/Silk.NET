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
    [Guid("61f307d3-d34e-4e7c-8374-3ba4de23cccb")]
    [NativeName("Name", "ID3D12DeviceFactory")]
    public unsafe partial struct ID3D12DeviceFactory : IComVtbl<ID3D12DeviceFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("61f307d3-d34e-4e7c-8374-3ba4de23cccb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceFactory val)
            => Unsafe.As<ID3D12DeviceFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceFactory
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
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromGlobalState()
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, int>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ApplyToGlobalState()
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFlags(DeviceFactoryFlags flags)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, DeviceFactoryFlags, int>)@this->LpVtbl[5])(@this, flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly DeviceFactoryFlags GetFlags()
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            DeviceFactoryFlags ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, DeviceFactoryFlags>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(Guid* clsid, Guid* iid, void** ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(Guid* clsid, Guid* iid, ref void* ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(Guid* clsid, ref Guid iid, void** ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(Guid* clsid, ref Guid iid, ref void* ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsid, iidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(ref Guid clsid, Guid* iid, void** ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(ref Guid clsid, Guid* iid, ref void* ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(ref Guid clsid, ref Guid iid, void** ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface(ref Guid clsid, ref Guid iid, ref void* ppv)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidPtr = &clsid)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Guid*, Guid*, void**, int>)@this->LpVtbl[7])(@this, clsidPtr, iidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructs, pConfigurationStructSizesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructsPtr, pConfigurationStructSizes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
            {
                fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDs, pConfigurationStructsPtr, pConfigurationStructSizesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, uint* pConfigurationStructSizes)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pIIDsPtr = &pIIDs)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructs, pConfigurationStructSizes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, void* pConfigurationStructs, ref uint pConfigurationStructSizes)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pIIDsPtr = &pIIDs)
            {
                fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructs, pConfigurationStructSizesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, uint* pConfigurationStructSizes) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pIIDsPtr = &pIIDs)
            {
                fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructsPtr, pConfigurationStructSizes);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EnableExperimentalFeatures<T0>(uint NumFeatures, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pIIDs, ref T0 pConfigurationStructs, ref uint pConfigurationStructSizes) where T0 : unmanaged
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pIIDsPtr = &pIIDs)
            {
                fixed (void* pConfigurationStructsPtr = &pConfigurationStructs)
                {
                    fixed (uint* pConfigurationStructSizesPtr = &pConfigurationStructSizes)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, uint, Guid*, void*, uint*, int>)@this->LpVtbl[8])(@this, NumFeatures, pIIDsPtr, pConfigurationStructsPtr, pConfigurationStructSizesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riid, ppvDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riid, ppvDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riidPtr, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(Silk.NET.Core.Native.IUnknown* adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapter, FeatureLevel, riidPtr, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riid, ppvDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riid, ppvDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riidPtr, ppvDevice);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* adapterPtr = &adapter)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvDevicePtr = &ppvDevice)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceFactory*, Silk.NET.Core.Native.IUnknown*, Silk.NET.Core.Native.D3DFeatureLevel, Guid*, void**, int>)@this->LpVtbl[9])(@this, adapterPtr, FeatureLevel, riidPtr, ppvDevicePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetConfigurationInterface<TI0>(Guid* clsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetConfigurationInterface(clsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetConfigurationInterface<TI0>(ref Guid clsid, out ComPtr<TI0> ppv) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppv = default;
            return @this->GetConfigurationInterface(ref clsid, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppv.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDevice<TI0, TI1>(ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, out ComPtr<TI1> ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice<TI0>(ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, Guid* riid, ref void* ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, riid, ref ppvDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice<TI0>(ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, void** ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, ref riid, ppvDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDevice<TI0>(ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, ref Guid riid, ref void* ppvDevice) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDevice((Silk.NET.Core.Native.IUnknown*) adapter.Handle, FeatureLevel, ref riid, ref ppvDevice);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel, out ComPtr<TI0> ppvDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvDevice = default;
            return @this->CreateDevice(ref adapter, FeatureLevel, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetConfigurationInterface<TI0>(Guid* clsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetConfigurationInterface(clsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetConfigurationInterface<TI0>(ref Guid clsid) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetConfigurationInterface(ref clsid, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateDevice<TI0, TI1>(ComPtr<TI0> adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDevice(adapter, FeatureLevel, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDevice<TI0>(ref Silk.NET.Core.Native.IUnknown adapter, Silk.NET.Core.Native.D3DFeatureLevel FeatureLevel) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12DeviceFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDevice(ref adapter, FeatureLevel, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
