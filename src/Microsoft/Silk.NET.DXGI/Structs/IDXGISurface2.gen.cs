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
    [NativeName("Name", "IDXGISurface2")]
    public unsafe partial struct IDXGISurface2
    {
        public static implicit operator IDXGISurface1(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, IDXGISurface1>(ref val);

        public readonly ref IDXGISurface1 AsSurface1()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                return ref *(IDXGISurface1*)@this;
            }
        }

        public static implicit operator IDXGISurface(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, IDXGISurface>(ref val);

        public readonly ref IDXGISurface AsSurface()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                return ref *(IDXGISurface*)@this;
            }
        }

        public static implicit operator IDXGIDeviceSubObject(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, IDXGIDeviceSubObject>(ref val);

        public readonly ref IDXGIDeviceSubObject AsDeviceSubObject()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                return ref *(IDXGIDeviceSubObject*)@this;
            }
        }

        public static implicit operator IDXGIObject(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, IDXGIObject>(ref val);

        public readonly ref IDXGIObject AsObject()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                return ref *(IDXGIObject*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGISurface2 val)
            => Unsafe.As<IDXGISurface2, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGISurface2
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
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGISurface2*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (void** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppDevicePtr = &ppDevice)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(SurfaceDesc* pDesc)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, SurfaceDesc*, int>)LpVtbl[8])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref SurfaceDesc pDesc)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, SurfaceDesc*, int>)LpVtbl[8])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Map(MappedRect* pLockedRect, uint MapFlags)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, MappedRect*, uint, int>)LpVtbl[9])(@this, pLockedRect, MapFlags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Map(ref MappedRect pLockedRect, uint MapFlags)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (MappedRect* pLockedRectPtr = &pLockedRect)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, MappedRect*, uint, int>)LpVtbl[9])(@this, pLockedRectPtr, MapFlags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Unmap()
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, int>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDC(int Discard, IntPtr* phdc)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, int, IntPtr*, int>)LpVtbl[11])(@this, Discard, phdc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDC(int Discard, ref IntPtr phdc)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (IntPtr* phdcPtr = &phdc)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, int, IntPtr*, int>)LpVtbl[11])(@this, Discard, phdcPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int ReleaseDC(Silk.NET.Core.Native.TagRect* pDirtyRect)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[12])(@this, pDirtyRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int ReleaseDC(ref Silk.NET.Core.Native.TagRect pDirtyRect)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDirtyRectPtr = &pDirtyRect)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[12])(@this, pDirtyRectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(Guid* riid, void** ppParentResource, uint* pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riid, ppParentResource, pSubresourceIndex);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(Guid* riid, void** ppParentResource, ref uint pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riid, ppParentResource, pSubresourceIndexPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(Guid* riid, ref void* ppParentResource, uint* pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentResourcePtr = &ppParentResource)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riid, ppParentResourcePtr, pSubresourceIndex);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(Guid* riid, ref void* ppParentResource, ref uint pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentResourcePtr = &ppParentResource)
                {
                    fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riid, ppParentResourcePtr, pSubresourceIndexPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(ref Guid riid, void** ppParentResource, uint* pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riidPtr, ppParentResource, pSubresourceIndex);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(ref Guid riid, void** ppParentResource, ref uint pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riidPtr, ppParentResource, pSubresourceIndexPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(ref Guid riid, ref void* ppParentResource, uint* pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentResourcePtr = &ppParentResource)
                    {
                        ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riidPtr, ppParentResourcePtr, pSubresourceIndex);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetResource(ref Guid riid, ref void* ppParentResource, ref uint pSubresourceIndex)
        {
            fixed (IDXGISurface2* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentResourcePtr = &ppParentResource)
                    {
                        fixed (uint* pSubresourceIndexPtr = &pSubresourceIndex)
                        {
                            ret = ((delegate* cdecl<IDXGISurface2*, Guid*, void**, uint*, int>)LpVtbl[13])(@this, riidPtr, ppParentResourcePtr, pSubresourceIndexPtr);
                        }
                    }
                }
                return ret;
            }
        }

    }
}
