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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "IDirect3DIndexBuffer9")]
    public unsafe partial struct IDirect3DIndexBuffer9
    {
        public static implicit operator IDirect3DResource9(IDirect3DIndexBuffer9 val)
            => Unsafe.As<IDirect3DIndexBuffer9, IDirect3DResource9>(ref val);

        public readonly ref IDirect3DResource9 AsDirect3DResource9()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                return ref *(IDirect3DResource9*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DIndexBuffer9 val)
            => Unsafe.As<IDirect3DIndexBuffer9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DIndexBuffer9
        (
            char* name = default,
            uint length = default,
            uint usage = default,
            Format format = default,
            Pool pool = default,
            uint priority = default,
            uint lockCount = default,
            void** lpVtbl = default
        )
        {
            Name = name;
            Length = length;
            Usage = usage;
            Format = format;
            Pool = pool;
            Priority = priority;
            LockCount = lockCount;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Length")]
        public uint Length;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Usage")]
        public uint Usage;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Format Format;

        [NativeName("Type", "D3DPOOL")]
        [NativeName("Type.Name", "D3DPOOL")]
        [NativeName("Name", "Pool")]
        public Pool Pool;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Priority")]
        public uint Priority;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "LockCount")]
        public uint LockCount;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                        {
                            ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FreePrivateData(Guid* refguid)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, int>)LpVtbl[6])(@this, refguid);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int FreePrivateData(ref Guid refguid)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint SetPriority(uint PriorityNew)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetPriority()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PreLoad()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DIndexBuffer9*, void>)LpVtbl[9])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public Resourcetype GetType()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                Resourcetype ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, Resourcetype>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Lock(uint OffsetToLock, uint SizeToLock, void** ppbData, uint Flags)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbData, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int Lock(uint OffsetToLock, uint SizeToLock, ref void* ppbData, uint Flags)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (void** ppbDataPtr = &ppbData)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, uint, uint, void**, uint, int>)LpVtbl[11])(@this, OffsetToLock, SizeToLock, ppbDataPtr, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int Unlock()
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, int>)LpVtbl[12])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDesc(IndexbufferDesc* pDesc)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, IndexbufferDesc*, int>)LpVtbl[13])(@this, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetDesc(ref IndexbufferDesc pDesc)
        {
            fixed (IDirect3DIndexBuffer9* @this = &this)
            {
                int ret = default;
                fixed (IndexbufferDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDirect3DIndexBuffer9*, IndexbufferDesc*, int>)LpVtbl[13])(@this, pDescPtr);
                }
                return ret;
            }
        }

    }
}
