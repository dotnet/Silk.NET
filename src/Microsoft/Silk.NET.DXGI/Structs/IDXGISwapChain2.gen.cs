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

namespace Silk.NET.DXGI
{
    [Guid("a8be2ac4-199f-4946-b331-79599fb98de7")]
    [NativeName("Name", "IDXGISwapChain2")]
    public unsafe partial struct IDXGISwapChain2 : IComVtbl<IDXGISwapChain2>, IComVtbl<IDXGISwapChain1>, IComVtbl<Silk.NET.DXGI.IDXGISwapChain>, IComVtbl<Silk.NET.DXGI.IDXGIDeviceSubObject>, IComVtbl<Silk.NET.DXGI.IDXGIObject>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a8be2ac4-199f-4946-b331-79599fb98de7");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDXGISwapChain1(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, IDXGISwapChain1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGISwapChain(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGISwapChain>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIDeviceSubObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGIDeviceSubObject>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGIObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGISwapChain2
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
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)@this->LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, Name, pUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknown);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pData);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)@this->LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, void** ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riid, ppParentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParent);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[6])(@this, riidPtr, ppParentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevice);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDevicePtr = &ppDevice)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppDevicePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevice);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present(uint SyncInterval, uint Flags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[8])(@this, SyncInterval, Flags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, Guid* riid, ref void* ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppSurfacePtr = &ppSurface)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, ref Guid riid, void** ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, ref Guid riid, ref void* ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)@this->LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFullscreenState(Silk.NET.Core.Bool32 Fullscreen, IDXGIOutput* pTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFullscreenState(Silk.NET.Core.Bool32 Fullscreen, ref IDXGIOutput pTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pTargetPtr = &pTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32, IDXGIOutput*, int>)@this->LpVtbl[10])(@this, Fullscreen, pTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(int* pFullscreen, ref IDXGIOutput* ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(ref int pFullscreen, IDXGIOutput** ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pFullscreenPtr = &pFullscreen)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(ref int pFullscreen, ref IDXGIOutput* ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pFullscreenPtr = &pFullscreen)
            {
                fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)@this->LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref SwapChainDesc pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)@this->LpVtbl[12])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)@this->LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResizeTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] ModeDesc* pNewTargetParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeTarget([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ModeDesc pNewTargetParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)@this->LpVtbl[14])(@this, pNewTargetParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingOutput(ref IDXGIOutput* ppOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[15])(@this, ppOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStats);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)@this->LpVtbl[16])(@this, pStatsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastPresentCount(ref uint pLastPresentCount)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[17])(@this, pLastPresentCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc1(SwapChainDesc1* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc1(ref SwapChainDesc1 pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)@this->LpVtbl[18])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenDesc(SwapChainFullscreenDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFullscreenDesc(ref SwapChainFullscreenDesc pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)@this->LpVtbl[19])(@this, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHwnd(nint* pHwnd)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)@this->LpVtbl[20])(@this, pHwnd);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHwnd(ref nint pHwnd)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pHwndPtr = &pHwnd)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)@this->LpVtbl[20])(@this, pHwndPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(Guid* refiid, void** ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnk);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(Guid* refiid, ref void* ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppUnkPtr = &ppUnk)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiid, ppUnkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(ref Guid refiid, void** ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refiidPtr = &refiid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnk);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(ref Guid refiid, ref void* ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refiidPtr = &refiid)
            {
                fixed (void** ppUnkPtr = &ppUnk)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)@this->LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present1(uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PresentParameters* pPresentParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present1(uint SyncInterval, uint PresentFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PresentParameters pPresentParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)@this->LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsTemporaryMonoSupported()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Silk.NET.Core.Bool32>)@this->LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutput);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRestrictToOutput(ref IDXGIOutput* ppRestrictToOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)@this->LpVtbl[24])(@this, ppRestrictToOutputPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackgroundColor([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in D3Dcolorvalue pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D3Dcolorvalue* pColorPtr = &pColor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[25])(@this, pColorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackgroundColor(D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D3Dcolorvalue* pColorPtr = &pColor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)@this->LpVtbl[26])(@this, pColorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRotation(ModeRotation Rotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation, int>)@this->LpVtbl[27])(@this, Rotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRotation(ModeRotation* pRotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRotation(ref ModeRotation pRotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeRotation* pRotationPtr = &pRotation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)@this->LpVtbl[28])(@this, pRotationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceSize(uint Width, uint Height)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)@this->LpVtbl[29])(@this, Width, Height);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(uint* pWidth, uint* pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeight);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(uint* pWidth, ref uint pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pHeightPtr = &pHeight)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidth, pHeightPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(ref uint pWidth, uint* pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthPtr = &pWidth)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidthPtr, pHeight);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceSize(ref uint pWidth, ref uint pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pWidthPtr = &pWidth)
            {
                fixed (uint* pHeightPtr = &pHeight)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)@this->LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, int>)@this->LpVtbl[31])(@this, MaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxLatencyPtr = &pMaxLatency)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)@this->LpVtbl[32])(@this, pMaxLatencyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetFrameLatencyWaitableObject()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, void*>)@this->LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMatrixTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMatrixTransform([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Matrix3X2F pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[34])(@this, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatrixTransform(Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrix);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)@this->LpVtbl[35])(@this, pMatrixPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface<TI0>(Guid* Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface<TI0>(ref Guid Name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ComPtr<TI0> pUnknown) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetPrivateDataInterface(ref Name, (Silk.NET.Core.Native.IUnknown*) pUnknown.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetParent<TI0>(out ComPtr<TI0> ppParent) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppParent = default;
            return @this->GetParent(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppParent.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDevice<TI0>(out ComPtr<TI0> ppDevice) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppDevice = default;
            return @this->GetDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppDevice.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffer<TI0>(uint Buffer, out ComPtr<TI0> ppSurface) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppSurface = default;
            return @this->GetBuffer(Buffer, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppSurface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFullscreenState<TI0>(Silk.NET.Core.Bool32 Fullscreen, ComPtr<TI0> pTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetFullscreenState(Fullscreen, (IDXGIOutput*) pTarget.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState<TI0>(int* pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFullscreenState(pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFullscreenState<TI0>(ref int pFullscreen, ref ComPtr<TI0> ppTarget) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFullscreenState(ref pFullscreen, (IDXGIOutput**) ppTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainingOutput<TI0>(ref ComPtr<TI0> ppOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetContainingOutput((IDXGIOutput**) ppOutput.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCoreWindow<TI0>(out ComPtr<TI0> ppUnk) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppUnk = default;
            return @this->GetCoreWindow(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppUnk.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRestrictToOutput<TI0>(ref ComPtr<TI0> ppRestrictToOutput) where TI0 : unmanaged, IComVtbl<IDXGIOutput>, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetRestrictToOutput((IDXGIOutput**) ppRestrictToOutput.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetParent<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetParent(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetBuffer<TI0>(uint Buffer) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetBuffer(Buffer, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetCoreWindow<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCoreWindow(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
