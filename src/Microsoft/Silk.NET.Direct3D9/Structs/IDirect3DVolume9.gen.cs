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

namespace Silk.NET.Direct3D9
{
    [Guid("24f416e6-1f67-4aa7-b88e-d33f6f3128a1")]
    [NativeName("Name", "IDirect3DVolume9")]
    public unsafe partial struct IDirect3DVolume9
    {
        public static readonly Guid Guid = new("24f416e6-1f67-4aa7-b88e-d33f6f3128a1");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDirect3DVolume9 val)
            => Unsafe.As<IDirect3DVolume9, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDirect3DVolume9
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
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(IDirect3DDevice9** ppDevice)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref IDirect3DDevice9* ppDevice)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDirect3DDevice9** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, IDirect3DDevice9**, int>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pData, SizeOfData, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguid, pDataPtr, SizeOfData, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid refguid, void* pData, uint SizeOfData, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pData, SizeOfData, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint SizeOfData, uint Flags) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint, uint, int>)LpVtbl[4])(@this, refguidPtr, pDataPtr, SizeOfData, Flags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizeOfDataPtr = &pSizeOfData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pData, pSizeOfDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguid, pDataPtr, pSizeOfDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, uint* pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid refguid, void* pData, ref uint pSizeOfData)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pData, pSizeOfDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, uint* pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid refguid, ref T0 pData, ref uint pSizeOfData) where T0 : unmanaged
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
                fixed (void* pDataPtr = &pData)
                {
                    fixed (uint* pSizeOfDataPtr = &pSizeOfData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void*, uint*, int>)LpVtbl[5])(@this, refguidPtr, pDataPtr, pSizeOfDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FreePrivateData(Guid* refguid)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguid);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FreePrivateData(ref Guid refguid)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* refguidPtr = &refguid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, int>)LpVtbl[6])(@this, refguidPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(Guid* riid, void** ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(Guid* riid, ref void* ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppContainerPtr = &ppContainer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainerPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainerPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppContainerPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(ref Guid riid, void** ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainer);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainer);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainer);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainer(ref Guid riid, ref void* ppContainer)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppContainerPtr = &ppContainer)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainerPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainerPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppContainerPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(VolumeDesc* pDesc)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref VolumeDesc pDesc)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VolumeDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, VolumeDesc*, int>)LpVtbl[8])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(LockedBox* pLockedVolume, Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBox, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBox, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBox, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(LockedBox* pLockedVolume, ref Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Box* pBoxPtr = &pBox)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBoxPtr, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBoxPtr, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolume, pBoxPtr, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LockBox(ref LockedBox pLockedVolume, Box* pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBox, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBox, Flags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBox, Flags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int LockBox(ref LockedBox pLockedVolume, ref Box pBox, uint Flags)
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LockedBox* pLockedVolumePtr = &pLockedVolume)
            {
                fixed (Box* pBoxPtr = &pBox)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBoxPtr, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBoxPtr, Flags);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, LockedBox*, Box*, uint, int>)LpVtbl[9])(@this, pLockedVolumePtr, pBoxPtr, Flags);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnlockBox()
        {
            var @this = (IDirect3DVolume9*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDirect3DVolume9*, int>)LpVtbl[10])(@this);
            return ret;
        }

    }
}
