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
    [NativeName("Name", "IDXGIOutput1")]
    public unsafe partial struct IDXGIOutput1
    {
        public static implicit operator IDXGIOutput(IDXGIOutput1 val)
            => Unsafe.As<IDXGIOutput1, IDXGIOutput>(ref val);

        public readonly ref IDXGIOutput AsOutput()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                return ref *(IDXGIOutput*)@this;
            }
        }

        public static implicit operator IDXGIObject(IDXGIOutput1 val)
            => Unsafe.As<IDXGIOutput1, IDXGIObject>(ref val);

        public readonly ref IDXGIObject AsObject()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                return ref *(IDXGIObject*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutput1 val)
            => Unsafe.As<IDXGIOutput1, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDXGIOutput1
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
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint, T0*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* NamePtr = &Name)
                {
                    fixed (uint* pDataSizePtr = &pDataSize)
                    {
                        fixed (T0* pDataPtr = &pData)
                        {
                            ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, uint*, T0*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, void** ppParent)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (void** ppParentPtr = &ppParent)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppParentPtr = &ppParent)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(OutputDesc* pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, OutputDesc*, int>)LpVtbl[7])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref OutputDesc pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (OutputDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, OutputDesc*, int>)LpVtbl[7])(@this, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pNumModesPtr = &pNumModes)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pNumModesPtr = &pNumModes)
                {
                    fixed (ModeDesc* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                        {
                            ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int WaitForVBlank()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, int>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int TakeOwnership(Silk.NET.Core.Native.IUnknown* pDevice, int Exclusive)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevice, Exclusive);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int TakeOwnership(ref Silk.NET.Core.Native.IUnknown pDevice, int Exclusive)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevicePtr, Exclusive);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void ReleaseOwnership()
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                ((delegate* cdecl<IDXGIOutput1*, void>)LpVtbl[12])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetGammaControlCapabilities(GammaControlCapabilities* pGammaCaps)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCaps);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetGammaControlCapabilities(ref GammaControlCapabilities pGammaCaps)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCapsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetGammaControl(GammaControl* pArray)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, GammaControl*, int>)LpVtbl[14])(@this, pArray);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetGammaControl(ref GammaControl pArray)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (GammaControl* pArrayPtr = &pArray)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, GammaControl*, int>)LpVtbl[14])(@this, pArrayPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetGammaControl(GammaControl* pArray)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, GammaControl*, int>)LpVtbl[15])(@this, pArray);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetGammaControl(ref GammaControl pArray)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (GammaControl* pArrayPtr = &pArray)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, GammaControl*, int>)LpVtbl[15])(@this, pArrayPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurface);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetDisplaySurface(ref IDXGISurface pScanoutSurface)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurfacePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestination);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplaySurfaceData(ref IDXGISurface pDestination)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (IDXGISurface* pDestinationPtr = &pDestination)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestinationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, FrameStatistics*, int>)LpVtbl[18])(@this, pStats);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetFrameStatistics(ref FrameStatistics pStats)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (FrameStatistics* pStatsPtr = &pStats)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, FrameStatistics*, int>)LpVtbl[18])(@this, pStatsPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pNumModesPtr = &pNumModes)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (uint* pNumModesPtr = &pNumModes)
                {
                    fixed (ModeDesc1* pDescPtr = &pDesc)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
                {
                    fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                    {
                        fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                        {
                            ret = ((delegate* cdecl<IDXGIOutput1*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestination);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDisplaySurfaceData1(ref IDXGIResource pDestination)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (IDXGIResource* pDestinationPtr = &pDestination)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestinationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplication);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
                {
                    ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            fixed (IDXGIOutput1* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
                {
                    fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                    {
                        ret = ((delegate* cdecl<IDXGIOutput1*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
                    }
                }
                return ret;
            }
        }

    }
}
