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

namespace Silk.NET.Direct3D11.Extensions.D3D11On12
{
    [Guid("85611e73-70a9-490e-9614-a9e302777904")]
    [NativeName("Name", "ID3D11On12Device")]
    public unsafe partial struct ID3D11On12Device : IComVtbl<ID3D11On12Device>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("85611e73-70a9-490e-9614-a9e302777904");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11On12Device val)
            => Unsafe.As<ID3D11On12Device, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11On12Device
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
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppResource11Ptr = &ppResource11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riid, ppResource11Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riidPtr, ppResource11);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11, InState, OutState, riidPtr, ppResource11Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riid, ppResource11);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riid, ppResource11Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riidPtr, ppResource11);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(Silk.NET.Core.Native.IUnknown* pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResource11Ptr = &ppResource11)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12, pFlags11Ptr, InState, OutState, riidPtr, ppResource11Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riid, ppResource11);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (void** ppResource11Ptr = &ppResource11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riid, ppResource11Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riidPtr, ppResource11);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppResource11Ptr = &ppResource11)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11, InState, OutState, riidPtr, ppResource11Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riid, ppResource11);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
                {
                    fixed (void** ppResource11Ptr = &ppResource11)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riid, ppResource11Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riidPtr, ppResource11);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pResource12Ptr = &pResource12)
            {
                fixed (ResourceFlags* pFlags11Ptr = &pFlags11)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppResource11Ptr = &ppResource11)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, Silk.NET.Core.Native.IUnknown*, ResourceFlags*, Silk.NET.Direct3D12.ResourceStates, Silk.NET.Direct3D12.ResourceStates, Guid*, void**, int>)@this->LpVtbl[3])(@this, pResource12Ptr, pFlags11Ptr, InState, OutState, riidPtr, ppResource11Ptr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResources, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Resource* ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource** ppResourcesPtr = &ppResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[4])(@this, ppResourcesPtr, NumResources);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AcquireWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] ID3D11Resource** ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResources, NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AcquireWrappedResources([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ID3D11Resource* ppResources, uint NumResources)
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Resource** ppResourcesPtr = &ppResources)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11On12Device*, ID3D11Resource**, uint, void>)@this->LpVtbl[5])(@this, ppResourcesPtr, NumResources);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0, TI1>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI1> ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResource11 = default;
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResource11.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, riid, ref ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, ref riid, ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, pFlags11, InState, OutState, ref riid, ref ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateWrappedResource<TI0, TI1>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI1> ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResource11 = default;
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppResource11.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, Guid* riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, riid, ref ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, void** ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, ref riid, ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, ref Guid riid, ref void* ppResource11) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateWrappedResource((Silk.NET.Core.Native.IUnknown*) pResource12.Handle, in pFlags11, InState, OutState, ref riid, ref ppResource11);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateWrappedResource<TI0>(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI0> ppResource11) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResource11 = default;
            return @this->CreateWrappedResource(ref pResource12, pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResource11.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateWrappedResource<TI0>(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState, out ComPtr<TI0> ppResource11) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppResource11 = default;
            return @this->CreateWrappedResource(ref pResource12, in pFlags11, InState, OutState, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppResource11.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseWrappedResources<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, uint NumResources) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->ReleaseWrappedResources((ID3D11Resource**) ppResources.GetAddressOf(), NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly void AcquireWrappedResources<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> ppResources, uint NumResources) where TI0 : unmanaged, IComVtbl<ID3D11Resource>, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->AcquireWrappedResources((ID3D11Resource**) ppResources.GetAddressOf(), NumResources);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CreateWrappedResource<TI0, TI1>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateWrappedResource(pResource12, pFlags11, InState, OutState, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateWrappedResource<TI0, TI1>(ComPtr<TI0> pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateWrappedResource(pResource12, in pFlags11, InState, OutState, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateWrappedResource<TI0>(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ResourceFlags* pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateWrappedResource(ref pResource12, pFlags11, InState, OutState, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateWrappedResource<TI0>(ref Silk.NET.Core.Native.IUnknown pResource12, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ResourceFlags pFlags11, Silk.NET.Direct3D12.ResourceStates InState, Silk.NET.Direct3D12.ResourceStates OutState) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11On12Device*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateWrappedResource(ref pResource12, in pFlags11, InState, OutState, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
