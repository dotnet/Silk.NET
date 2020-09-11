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
    [NativeName("Name", "IDirect3DTexture9")]
    public unsafe partial struct IDirect3DTexture9
    {
        public static implicit operator IDirect3DBaseTexture9(IDirect3DTexture9 val)
            => Unsafe.As<IDirect3DTexture9, IDirect3DBaseTexture9>(ref val);

        public readonly ref IDirect3DBaseTexture9 AsDirect3DBaseTexture9()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                return ref *(IDirect3DBaseTexture9*)@this;
            }
        }

        public static implicit operator IDirect3DResource9(IDirect3DTexture9 val)
            => Unsafe.As<IDirect3DTexture9, IDirect3DResource9>(ref val);

        public readonly ref IDirect3DResource9 AsDirect3DResource9()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                return ref *(IDirect3DResource9*)@this;
            }
        }

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DTexture9 val)
            => Unsafe.As<IDirect3DTexture9, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDirect3DTexture9
        (
            char* name = default,
            uint width = default,
            uint height = default,
            uint levels = default,
            uint usage = default,
            Format format = default,
            Pool pool = default,
            uint priority = default,
            uint lOD = default,
            Texturefiltertype filterType = default,
            uint lockCount = default,
            void** lpVtbl = default
        )
        {
            Name = name;
            Width = width;
            Height = height;
            Levels = levels;
            Usage = usage;
            Format = format;
            Pool = pool;
            Priority = priority;
            LOD = lOD;
            FilterType = filterType;
            LockCount = lockCount;
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "Name")]
        public char* Name;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Levels")]
        public uint Levels;

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

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LOD")]
        public uint LOD;

        [NativeName("Type", "D3DTEXTUREFILTERTYPE")]
        [NativeName("Type.Name", "D3DTEXTUREFILTERTYPE")]
        [NativeName("Name", "FilterType")]
        public Texturefiltertype FilterType;

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
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (T0* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    fixed (T0* pDataPtr = &pData)
                    {
                        fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                        {
                            ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, T0*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int FreePrivateData(Guid* refguid)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, int>)LpVtbl[6])(@this, refguid);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int FreePrivateData(ref Guid refguid)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Guid* refguidPtr = &refguid)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint SetPriority(uint PriorityNew)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, uint>)LpVtbl[7])(@this, PriorityNew);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetPriority()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint>)LpVtbl[8])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void PreLoad()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DTexture9*, void>)LpVtbl[9])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public Resourcetype GetType()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                Resourcetype ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Resourcetype>)LpVtbl[10])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint SetLOD(uint LODNew)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, uint>)LpVtbl[11])(@this, LODNew);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetLOD()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint>)LpVtbl[12])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint GetLevelCount()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint>)LpVtbl[13])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int SetAutoGenFilterType(Texturefiltertype FilterType)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Texturefiltertype, int>)LpVtbl[14])(@this, FilterType);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public Texturefiltertype GetAutoGenFilterType()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                Texturefiltertype ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Texturefiltertype>)LpVtbl[15])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public void GenerateMipSubLevels()
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                ((delegate* cdecl<IDirect3DTexture9*, void>)LpVtbl[16])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetLevelDesc(uint Level, SurfaceDesc* pDesc)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDesc);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int GetLevelDesc(uint Level, ref SurfaceDesc pDesc)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (SurfaceDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, uint, SurfaceDesc*, int>)LpVtbl[17])(@this, Level, pDescPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSurfaceLevel(uint Level, IDirect3DSurface9** ppSurfaceLevel)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, Level, ppSurfaceLevel);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int GetSurfaceLevel(uint Level, ref IDirect3DSurface9* ppSurfaceLevel)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (IDirect3DSurface9** ppSurfaceLevelPtr = &ppSurfaceLevel)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, uint, IDirect3DSurface9**, int>)LpVtbl[18])(@this, Level, ppSurfaceLevelPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LockRect(uint Level, LockedRect* pLockedRect, Silk.NET.Core.Native.TagRect* pRect, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, LockedRect*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[19])(@this, Level, pLockedRect, pRect, Flags);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LockRect(uint Level, LockedRect* pLockedRect, ref Silk.NET.Core.Native.TagRect pRect, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, uint, LockedRect*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[19])(@this, Level, pLockedRect, pRectPtr, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LockRect(uint Level, ref LockedRect pLockedRect, Silk.NET.Core.Native.TagRect* pRect, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (LockedRect* pLockedRectPtr = &pLockedRect)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, uint, LockedRect*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[19])(@this, Level, pLockedRectPtr, pRect, Flags);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int LockRect(uint Level, ref LockedRect pLockedRect, ref Silk.NET.Core.Native.TagRect pRect, uint Flags)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (LockedRect* pLockedRectPtr = &pLockedRect)
                {
                    fixed (Silk.NET.Core.Native.TagRect* pRectPtr = &pRect)
                    {
                        ret = ((delegate* cdecl<IDirect3DTexture9*, uint, LockedRect*, Silk.NET.Core.Native.TagRect*, uint, int>)LpVtbl[19])(@this, Level, pLockedRectPtr, pRectPtr, Flags);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int UnlockRect(uint Level)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, uint, int>)LpVtbl[20])(@this, Level);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int AddDirtyRect(Silk.NET.Core.Native.TagRect* pDirtyRect)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDirect3DTexture9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[21])(@this, pDirtyRect);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int AddDirtyRect(ref Silk.NET.Core.Native.TagRect pDirtyRect)
        {
            fixed (IDirect3DTexture9* @this = &this)
            {
                int ret = default;
                fixed (Silk.NET.Core.Native.TagRect* pDirtyRectPtr = &pDirtyRect)
                {
                    ret = ((delegate* cdecl<IDirect3DTexture9*, Silk.NET.Core.Native.TagRect*, int>)LpVtbl[21])(@this, pDirtyRectPtr);
                }
                return ret;
            }
        }

    }
}
