// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "IDXGISwapChain3")]
    public unsafe partial struct IDXGISwapChain3
    {
        public static implicit operator IDXGISwapChain2(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, IDXGISwapChain2>(ref val);

        public readonly ref IDXGISwapChain2 AsSwapChain2()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(IDXGISwapChain2*)@this;
            }
        }

        public static implicit operator IDXGISwapChain1(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, IDXGISwapChain1>(ref val);

        public readonly ref IDXGISwapChain1 AsSwapChain1()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(IDXGISwapChain1*)@this;
            }
        }

        public static implicit operator Silk.NET.DXGI.IDXGISwapChain(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, Silk.NET.DXGI.IDXGISwapChain>(ref val);

        public readonly ref Silk.NET.DXGI.IDXGISwapChain AsSwapChain()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(Silk.NET.DXGI.IDXGISwapChain*)@this;
            }
        }

        public static implicit operator IDXGIDeviceSubObject(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, IDXGIDeviceSubObject>(ref val);

        public readonly ref IDXGIDeviceSubObject AsDeviceSubObject()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(IDXGIDeviceSubObject*)@this;
            }
        }

        public static implicit operator IDXGIObject(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, IDXGIObject>(ref val);

        public readonly ref IDXGIObject AsObject()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(IDXGIObject*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISwapChain3 val)
            => Unsafe.As<IDXGISwapChain3, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGISwapChain3
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppDevicePtr = &ppDevice)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present(uint SyncInterval, uint Flags)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, Guid* riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (void** ppSurfacePtr = &ppSurface)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, void** ppSurface)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBuffer(uint Buffer, ref Guid riid, ref void* ppSurface)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppSurfacePtr = &ppSurface)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetFullscreenState(int Fullscreen, IDXGIOutput* pTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetFullscreenState(int Fullscreen, ref IDXGIOutput pTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput* pTargetPtr = &pTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(int* pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, IDXGIOutput** ppTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenState(ref int pFullscreen, ref IDXGIOutput* ppTarget)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (int* pFullscreenPtr = &pFullscreen)
                {
                    fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref SwapChainDesc pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeTarget(ModeDesc* pNewTargetParameters)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ResizeTarget(ref ModeDesc pNewTargetParameters)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetContainingOutput(ref IDXGIOutput* ppOutput)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameStatistics(ref FrameStatistics pStats)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (FrameStatistics* pStatsPtr = &pStats)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLastPresentCount(ref uint pLastPresentCount)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc1(SwapChainDesc1* pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc1(ref SwapChainDesc1 pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFullscreenDesc(SwapChainFullscreenDesc* pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFullscreenDesc(ref SwapChainFullscreenDesc pDesc)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetHwnd(IntPtr* pHwnd)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, IntPtr*, int>)LpVtbl[20])(@this, pHwnd);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetHwnd(ref IntPtr pHwnd)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (IntPtr* pHwndPtr = &pHwnd)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, IntPtr*, int>)LpVtbl[20])(@this, pHwndPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(Guid* refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnk);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(Guid* refiid, ref void* ppUnk)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (void** ppUnkPtr = &ppUnk)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnkPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(ref Guid refiid, void** ppUnk)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* refiidPtr = &refiid)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnk);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetCoreWindow(ref Guid refiid, ref void* ppUnk)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Guid* refiidPtr = &refiid)
                {
                    fixed (void** ppUnkPtr = &ppUnk)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Present1(uint SyncInterval, uint PresentFlags, ref PresentParameters pPresentParameters)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int IsTemporaryMonoSupported()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, int>)LpVtbl[23])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRestrictToOutput(ref IDXGIOutput* ppRestrictToOutput)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetBackgroundColor(D3Dcolorvalue* pColor)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (D3Dcolorvalue* pColorPtr = &pColor)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetBackgroundColor(D3Dcolorvalue* pColor)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColor);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (D3Dcolorvalue* pColorPtr = &pColor)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColorPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetRotation(ModeRotation Rotation)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, ModeRotation, int>)LpVtbl[27])(@this, Rotation);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetRotation(ModeRotation* pRotation)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, ModeRotation*, int>)LpVtbl[28])(@this, pRotation);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetRotation(ref ModeRotation pRotation)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (ModeRotation* pRotationPtr = &pRotation)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, ModeRotation*, int>)LpVtbl[28])(@this, pRotationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetSourceSize(uint Width, uint Height)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, int>)LpVtbl[29])(@this, Width, Height);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(uint* pWidth, uint* pHeight)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeight);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(uint* pWidth, ref uint pHeight)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pHeightPtr = &pHeight)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeightPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSourceSize(ref uint pWidth, uint* pHeight)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeight);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetSourceSize(ref uint pWidth, ref uint pHeight)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pWidthPtr = &pWidth)
                {
                    fixed (uint* pHeightPtr = &pHeight)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMaximumFrameLatency(uint MaxLatency)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, int>)LpVtbl[31])(@this, MaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, int>)LpVtbl[32])(@this, pMaxLatency);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pMaxLatencyPtr = &pMaxLatency)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint*, int>)LpVtbl[32])(@this, pMaxLatencyPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void* GetFrameLatencyWaitableObject()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                void* ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, void*>)LpVtbl[33])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetMatrixTransform(Matrix3X2F* pMatrix)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrixPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetMatrixTransform(Matrix3X2F* pMatrix)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrix);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrixPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetCurrentBackBufferIndex()
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint>)LpVtbl[36])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckColorSpaceSupport(ColorSpaceType ColorSpace, uint* pColorSpaceSupport)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, ColorSpaceType, uint*, int>)LpVtbl[37])(@this, ColorSpace, pColorSpaceSupport);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckColorSpaceSupport(ColorSpaceType ColorSpace, ref uint pColorSpaceSupport)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pColorSpaceSupportPtr = &pColorSpaceSupport)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, ColorSpaceType, uint*, int>)LpVtbl[37])(@this, ColorSpace, pColorSpaceSupportPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetColorSpace1(ColorSpaceType ColorSpace)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, ColorSpaceType, int>)LpVtbl[38])(@this, ColorSpace);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeBuffers1(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, Silk.NET.Core.Native.IUnknown** ppPresentQueue)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeBuffers1(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, uint* pCreationNodeMask, ref Silk.NET.Core.Native.IUnknown* ppPresentQueue)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown** ppPresentQueuePtr = &ppPresentQueue)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueuePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeBuffers1(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, ref uint pCreationNodeMask, Silk.NET.Core.Native.IUnknown** ppPresentQueue)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pCreationNodeMaskPtr = &pCreationNodeMask)
                {
                    ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMaskPtr, ppPresentQueue);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ResizeBuffers1(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format Format, uint SwapChainFlags, ref uint pCreationNodeMask, ref Silk.NET.Core.Native.IUnknown* ppPresentQueue)
        {
            fixed (IDXGISwapChain3* @this = &this)
            {
                int ret = default;
                fixed (uint* pCreationNodeMaskPtr = &pCreationNodeMask)
                {
                    fixed (Silk.NET.Core.Native.IUnknown** ppPresentQueuePtr = &ppPresentQueue)
                    {
                        ret = ((delegate* cdecl<IDXGISwapChain3*, uint, uint, uint, Silk.NET.DXGI.Format, uint, uint*, Silk.NET.Core.Native.IUnknown**, int>)LpVtbl[39])(@this, BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMaskPtr, ppPresentQueuePtr);
                    }
                }
                return ret;
            }
        }

    }
}
