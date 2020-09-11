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
    [NativeName("Name", "IDXGIAdapter4")]
    public unsafe partial struct IDXGIAdapter4
    {
        public static implicit operator IDXGIAdapter3(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter3>(ref val);

        public readonly ref IDXGIAdapter3 AsAdapter3()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(IDXGIAdapter3*)@this;
            }
        }

        public static implicit operator IDXGIAdapter2(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter2>(ref val);

        public readonly ref IDXGIAdapter2 AsAdapter2()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(IDXGIAdapter2*)@this;
            }
        }

        public static implicit operator IDXGIAdapter1(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIAdapter1>(ref val);

        public readonly ref IDXGIAdapter1 AsAdapter1()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(IDXGIAdapter1*)@this;
            }
        }

        public static implicit operator Silk.NET.DXGI.IDXGIAdapter(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, Silk.NET.DXGI.IDXGIAdapter>(ref val);

        public readonly ref Silk.NET.DXGI.IDXGIAdapter AsAdapter()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(Silk.NET.DXGI.IDXGIAdapter*)@this;
            }
        }

        public static implicit operator IDXGIObject(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, IDXGIObject>(ref val);

        public readonly ref IDXGIObject AsObject()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(IDXGIObject*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIAdapter4 val)
            => Unsafe.As<IDXGIAdapter4, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGIAdapter4
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
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumOutputs(uint Output, IDXGIOutput** ppOutput)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, uint, IDXGIOutput**, int>)LpVtbl[7])(@this, Output, ppOutput);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int EnumOutputs(uint Output, ref IDXGIOutput* ppOutput)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, uint, IDXGIOutput**, int>)LpVtbl[7])(@this, Output, ppOutputPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(AdapterDesc* pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc*, int>)LpVtbl[8])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref AdapterDesc pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (AdapterDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc*, int>)LpVtbl[8])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckInterfaceSupport(Guid* InterfaceName, long* pUMDVersion)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, long*, int>)LpVtbl[9])(@this, InterfaceName, pUMDVersion);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckInterfaceSupport(Guid* InterfaceName, ref long pUMDVersion)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (long* pUMDVersionPtr = &pUMDVersion)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, long*, int>)LpVtbl[9])(@this, InterfaceName, pUMDVersionPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int CheckInterfaceSupport(ref Guid InterfaceName, long* pUMDVersion)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* InterfaceNamePtr = &InterfaceName)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, long*, int>)LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersion);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int CheckInterfaceSupport(ref Guid InterfaceName, ref long pUMDVersion)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (Guid* InterfaceNamePtr = &InterfaceName)
                {
                    fixed (long* pUMDVersionPtr = &pUMDVersion)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, Guid*, long*, int>)LpVtbl[9])(@this, InterfaceNamePtr, pUMDVersionPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc1(AdapterDesc1* pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc1*, int>)LpVtbl[10])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc1(ref AdapterDesc1 pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (AdapterDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc1*, int>)LpVtbl[10])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc2(AdapterDesc2* pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc2*, int>)LpVtbl[11])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc2(ref AdapterDesc2 pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (AdapterDesc2* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc2*, int>)LpVtbl[11])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(void* hEvent, uint* pdwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, void*, uint*, int>)LpVtbl[12])(@this, hEvent, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterHardwareContentProtectionTeardownStatusEvent(void* hEvent, ref uint pdwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, void*, uint*, int>)LpVtbl[12])(@this, hEvent, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, T0*, uint*, int>)LpVtbl[12])(@this, hEventPtr, pdwCookie);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterHardwareContentProtectionTeardownStatusEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    fixed (uint* pdwCookiePtr = &pdwCookie)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, T0*, uint*, int>)LpVtbl[12])(@this, hEventPtr, pdwCookiePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void UnregisterHardwareContentProtectionTeardownStatus(uint dwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                ((delegate* cdecl<IDXGIAdapter4*, uint, void>)LpVtbl[13])(@this, dwCookie);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryVideoMemoryInfo(uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, QueryVideoMemoryInfo* pVideoMemoryInfo)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfo);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int QueryVideoMemoryInfo(uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ref QueryVideoMemoryInfo pVideoMemoryInfo)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (QueryVideoMemoryInfo* pVideoMemoryInfoPtr = &pVideoMemoryInfo)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, uint, MemorySegmentGroup, QueryVideoMemoryInfo*, int>)LpVtbl[14])(@this, NodeIndex, MemorySegmentGroup, pVideoMemoryInfoPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetVideoMemoryReservation(uint NodeIndex, MemorySegmentGroup MemorySegmentGroup, ulong Reservation)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, uint, MemorySegmentGroup, ulong, int>)LpVtbl[15])(@this, NodeIndex, MemorySegmentGroup, Reservation);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(void* hEvent, uint* pdwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, void*, uint*, int>)LpVtbl[16])(@this, hEvent, pdwCookie);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent(void* hEvent, ref uint pdwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (uint* pdwCookiePtr = &pdwCookie)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, void*, uint*, int>)LpVtbl[16])(@this, hEvent, pdwCookiePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(ref T0 hEvent, uint* pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, T0*, uint*, int>)LpVtbl[16])(@this, hEventPtr, pdwCookie);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int RegisterVideoMemoryBudgetChangeNotificationEvent<T0>(ref T0 hEvent, ref uint pdwCookie) where T0 : unmanaged
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (T0* hEventPtr = &hEvent)
                {
                    fixed (uint* pdwCookiePtr = &pdwCookie)
                    {
                        ret = ((delegate* cdecl<IDXGIAdapter4*, T0*, uint*, int>)LpVtbl[16])(@this, hEventPtr, pdwCookiePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void UnregisterVideoMemoryBudgetChangeNotification(uint dwCookie)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                ((delegate* cdecl<IDXGIAdapter4*, uint, void>)LpVtbl[17])(@this, dwCookie);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc3(AdapterDesc3* pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc3*, int>)LpVtbl[18])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc3(ref AdapterDesc3 pDesc)
        {
            fixed (IDXGIAdapter4* @this = &this)
            {
                int ret = default;
                fixed (AdapterDesc3* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIAdapter4*, AdapterDesc3*, int>)LpVtbl[18])(@this, pDescPtr);
                }
                return ret;
            }
        }

    }
}
