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

namespace Silk.NET.Direct3D11
{
    [Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4")]
    [NativeName("Name", "ID3D11VideoContext")]
    public unsafe partial struct ID3D11VideoContext
    {
        public static readonly Guid Guid = new("61f21c45-3c0e-4a74-9cea-67100d9ad5e4");

        public static implicit operator ID3D11DeviceChild(ID3D11VideoContext val)
            => Unsafe.As<ID3D11VideoContext, ID3D11DeviceChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11VideoContext val)
            => Unsafe.As<ID3D11VideoContext, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11VideoContext
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
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID3D11Device** ppDevice)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevice);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID3D11Device* ppDevice)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Device** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11Device**, void>)LpVtbl[3])(@this, ppDevicePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guid, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint*, void*, int>)LpVtbl[4])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, uint, void*, int>)LpVtbl[5])(@this, guidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guid, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[6])(@this, guidPtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBuffer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppBufferPtr = &ppBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSize, ppBufferPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBuffer);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBufferSizePtr = &pBufferSize)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoder, Type, pBufferSizePtr, ppBufferPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBuffer);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, uint* pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (void** ppBufferPtr = &ppBuffer)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSize, ppBufferPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, void** ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBuffer);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type, ref uint pBufferSize, ref void* ppBuffer)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (uint* pBufferSizePtr = &pBufferSize)
                {
                    fixed (void** ppBufferPtr = &ppBuffer)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, uint*, void**, int>)LpVtbl[7])(@this, pDecoderPtr, Type, pBufferSizePtr, ppBufferPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseDecoderBuffer(ID3D11VideoDecoder* pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoder, Type);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoder, Type);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoder, Type);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseDecoderBuffer(ref ID3D11VideoDecoder pDecoder, VideoDecoderBufferType Type)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoderPtr, Type);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoderPtr, Type);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderBufferType, int>)LpVtbl[8])(@this, pDecoderPtr, Type);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKey);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContentKeyPtr = &pContentKey)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pView, ContentKeySize, pContentKeyPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKey);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ID3D11VideoDecoder* pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoder, pViewPtr, ContentKeySize, pContentKeyPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKey);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ID3D11VideoDecoderOutputView* pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pView, ContentKeySize, pContentKeyPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderBeginFrame(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, void* pContentKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKey);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderBeginFrame<T0>(ref ID3D11VideoDecoder pDecoder, ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, ref T0 pContentKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (ID3D11VideoDecoderOutputView* pViewPtr = &pView)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, ID3D11VideoDecoderOutputView*, uint, void*, int>)LpVtbl[9])(@this, pDecoderPtr, pViewPtr, ContentKeySize, pContentKeyPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderEndFrame(ID3D11VideoDecoder* pDecoder)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoder);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoder);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoder);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderEndFrame(ref ID3D11VideoDecoder pDecoder)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, int>)LpVtbl[10])(@this, pDecoderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ID3D11VideoDecoder* pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoder, NumBuffers, pBufferDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, VideoDecoderBufferDesc* pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SubmitDecoderBuffers(ref ID3D11VideoDecoder pDecoder, uint NumBuffers, ref VideoDecoderBufferDesc pBufferDesc)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderBufferDesc* pBufferDescPtr = &pBufferDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, uint, VideoDecoderBufferDesc*, int>)LpVtbl[11])(@this, pDecoderPtr, NumBuffers, pBufferDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ID3D11VideoDecoder* pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoder, pExtensionDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DecoderExtension(ref ID3D11VideoDecoder pDecoder, VideoDecoderExtension* pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DecoderExtension(ref ID3D11VideoDecoder pDecoder, ref VideoDecoderExtension pExtensionData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecoderExtension* pExtensionDataPtr = &pExtensionData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoDecoder*, VideoDecoderExtension*, int>)LpVtbl[12])(@this, pDecoderPtr, pExtensionDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessor, Enable, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[13])(@this, pVideoProcessorPtr, Enable, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessor, YCbCr, pColorPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColor);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int YCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, VideoColor*, void>)LpVtbl[14])(@this, pVideoProcessorPtr, YCbCr, pColorPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpace);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessor, pColorSpacePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpace);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[15])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessor, AlphaFillMode, StreamIndex);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode AlphaFillMode, uint StreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode, uint, void>)LpVtbl[16])(@this, pVideoProcessorPtr, AlphaFillMode, StreamIndex);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessor, Enable, Size);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int Enable, Silk.NET.Maths.Vector2D<int> Size)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, Silk.NET.Maths.Vector2D<int>, void>)LpVtbl[17])(@this, pVideoProcessorPtr, Enable, Size);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessor, Enable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessor, Enable);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessor, Enable);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int, void>)LpVtbl[18])(@this, pVideoProcessorPtr, Enable);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[19])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, Enabled, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ID3D11VideoProcessor* pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* EnabledPtr = &Enabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessor, EnabledPtr, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, int* Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, Enabled, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRect);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputTargetRect(ref ID3D11VideoProcessor pVideoProcessor, ref int Enabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* EnabledPtr = &Enabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[20])(@this, pVideoProcessorPtr, EnabledPtr, pRectPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoColor* pColorPtr = &pColor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCr, pColorPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColor);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ID3D11VideoProcessor* pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pYCbCrPtr = &pYCbCr)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessor, pYCbCrPtr, pColorPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColor);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, int* pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoColor* pColorPtr = &pColor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCr, pColorPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, VideoColor* pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColor);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputBackgroundColor(ref ID3D11VideoProcessor pVideoProcessor, ref int pYCbCr, ref VideoColor pColor)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pYCbCrPtr = &pYCbCr)
                {
                    fixed (VideoColor* pColorPtr = &pColor)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, VideoColor*, void>)LpVtbl[21])(@this, pVideoProcessorPtr, pYCbCrPtr, pColorPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpace);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessor, pColorSpacePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpace);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputColorSpace(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorColorSpace*, void>)LpVtbl[22])(@this, pVideoProcessorPtr, pColorSpacePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndex);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pStreamIndexPtr = &pStreamIndex)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillMode, pStreamIndexPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndex);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ID3D11VideoProcessor* pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessor, pAlphaFillModePtr, pStreamIndexPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndex);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, VideoProcessorAlphaFillMode* pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pStreamIndexPtr = &pStreamIndex)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillMode, pStreamIndexPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, uint* pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndex);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputAlphaFillMode(ref ID3D11VideoProcessor pVideoProcessor, ref VideoProcessorAlphaFillMode pAlphaFillMode, ref uint pStreamIndex)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorAlphaFillMode* pAlphaFillModePtr = &pAlphaFillMode)
                {
                    fixed (uint* pStreamIndexPtr = &pStreamIndex)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, VideoProcessorAlphaFillMode*, uint*, void>)LpVtbl[23])(@this, pVideoProcessorPtr, pAlphaFillModePtr, pStreamIndexPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSize);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabled, pSizePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSize);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessor, pEnabledPtr, pSizePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSize);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabled, pSizePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, Silk.NET.Maths.Vector2D<int>* pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSize);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputConstriction(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled, ref Silk.NET.Maths.Vector2D<int> pSize)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* pSizePtr = &pSize)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, Silk.NET.Maths.Vector2D<int>*, void>)LpVtbl[24])(@this, pVideoProcessorPtr, pEnabledPtr, pSizePtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabled);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabled);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabled);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ID3D11VideoProcessor* pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessor, pEnabledPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabled);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetOutputStereoMode(ref ID3D11VideoProcessor pVideoProcessor, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, int*, void>)LpVtbl[25])(@this, pVideoProcessorPtr, pEnabledPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessor, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuid, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetOutputExtension(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetOutputExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, Guid*, uint, void*, int>)LpVtbl[26])(@this, pVideoProcessorPtr, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessor, StreamIndex, FrameFormat);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat FrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat, void>)LpVtbl[27])(@this, pVideoProcessorPtr, StreamIndex, FrameFormat);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[28])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessor, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRate);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate OutputRate, int RepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate, int, Silk.NET.DXGI.Rational*, void>)LpVtbl[29])(@this, pVideoProcessorPtr, StreamIndex, OutputRate, RepeatFrame, pCustomRatePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[30])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessor, StreamIndex, Enable, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[31])(@this, pVideoProcessorPtr, StreamIndex, Enable, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessor, StreamIndex, Enable, Alpha);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Alpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, void>)LpVtbl[32])(@this, pVideoProcessorPtr, StreamIndex, Enable, Alpha);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[33])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessor, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatio);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[34])(@this, pVideoProcessorPtr, StreamIndex, Enable, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessor, StreamIndex, Enable, Lower, Upper);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, float Lower, float Upper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, float, float, void>)LpVtbl[35])(@this, pVideoProcessorPtr, StreamIndex, Enable, Lower, Upper);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessor, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorStereoFormat Format, int LeftViewFrame0, int BaseViewFrame0, VideoProcessorStereoFlipMode FlipMode, int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorStereoFormat, int, int, VideoProcessorStereoFlipMode, int, void>)LpVtbl[36])(@this, pVideoProcessorPtr, StreamIndex, Enable, Format, LeftViewFrame0, BaseViewFrame0, FlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessor, StreamIndex, Enable);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, void>)LpVtbl[37])(@this, pVideoProcessorPtr, StreamIndex, Enable);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessor, StreamIndex, Filter, Enable, Level);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int Enable, int Level)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int, int, void>)LpVtbl[38])(@this, pVideoProcessorPtr, StreamIndex, Filter, Enable, Level);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorSetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorSetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[39])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormat);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessor, StreamIndex, pFrameFormatPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoFrameFormat* pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormat);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFrameFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoFrameFormat pFrameFormat)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoFrameFormat* pFrameFormatPtr = &pFrameFormat)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoFrameFormat*, void>)LpVtbl[40])(@this, pVideoProcessorPtr, StreamIndex, pFrameFormatPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpace);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessor, StreamIndex, pColorSpacePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorColorSpace* pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpace);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamColorSpace(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorColorSpace pColorSpace)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorColorSpace* pColorSpacePtr = &pColorSpace)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorColorSpace*, void>)LpVtbl[41])(@this, pVideoProcessorPtr, StreamIndex, pColorSpacePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pRepeatFramePtr = &pRepeatFrame)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessor, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRate);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFrame, pCustomRatePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRate);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorOutputRate* pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pRepeatFramePtr = &pRepeatFrame)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRate, pRepeatFramePtr, pCustomRatePtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRate);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, int* pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFrame, pCustomRatePtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, Silk.NET.DXGI.Rational* pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRate);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamOutputRate(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref VideoProcessorOutputRate pOutputRate, ref int pRepeatFrame, ref Silk.NET.DXGI.Rational pCustomRate)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorOutputRate* pOutputRatePtr = &pOutputRate)
                {
                    fixed (int* pRepeatFramePtr = &pRepeatFrame)
                    {
                        fixed (Silk.NET.DXGI.Rational* pCustomRatePtr = &pCustomRate)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorOutputRate*, int*, Silk.NET.DXGI.Rational*, void>)LpVtbl[42])(@this, pVideoProcessorPtr, StreamIndex, pOutputRatePtr, pRepeatFramePtr, pCustomRatePtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamSourceRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[43])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRect);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabled, pRectPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRect);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pRectPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.Maths.Rectangle<int>* pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRect);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamDestRect(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.Maths.Rectangle<int> pRect)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectPtr = &pRect)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[44])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pRectPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlpha);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pAlphaPtr = &pAlpha)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabled, pAlphaPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlpha);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pAlphaPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlpha);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pAlphaPtr = &pAlpha)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pAlphaPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlpha);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAlpha(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pAlpha)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pAlphaPtr = &pAlpha)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, void>)LpVtbl[45])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pAlphaPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntries);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* pEntriesPtr = &pEntries)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessor, StreamIndex, Count, pEntriesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, uint* pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntries);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPalette(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, uint Count, ref uint pEntries)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (uint* pEntriesPtr = &pEntries)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, uint, uint*, void>)LpVtbl[46])(@this, pVideoProcessorPtr, StreamIndex, Count, pEntriesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatio);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatio, pDestinationAspectRatioPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatio);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatio);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, Silk.NET.DXGI.Rational* pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatio, pDestinationAspectRatioPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, Silk.NET.DXGI.Rational* pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatio);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamPixelAspectRatio(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref Silk.NET.DXGI.Rational pSourceAspectRatio, ref Silk.NET.DXGI.Rational pDestinationAspectRatio)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (Silk.NET.DXGI.Rational* pSourceAspectRatioPtr = &pSourceAspectRatio)
                    {
                        fixed (Silk.NET.DXGI.Rational* pDestinationAspectRatioPtr = &pDestinationAspectRatio)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, Silk.NET.DXGI.Rational*, Silk.NET.DXGI.Rational*, void>)LpVtbl[47])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pSourceAspectRatioPtr, pDestinationAspectRatioPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpper);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pUpperPtr = &pUpper)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLower, pUpperPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpper);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* pLowerPtr = &pLower)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpper);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessor, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpper);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pUpperPtr = &pUpper)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLower, pUpperPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpper);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (float* pLowerPtr = &pLower)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabled, pLowerPtr, pUpperPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpper);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, float* pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pUpperPtr = &pUpper)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLower, pUpperPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, float* pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpper);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamLumaKey(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled, ref float pLower, ref float pUpper)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (float* pLowerPtr = &pLower)
                    {
                        fixed (float* pUpperPtr = &pUpper)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, float*, float*, void>)LpVtbl[48])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr, pLowerPtr, pUpperPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* MonoOffsetPtr = &MonoOffset)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* MonoOffsetPtr = &MonoOffset)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* MonoOffsetPtr = &MonoOffset)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorStereoFormat* pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormat, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* MonoOffsetPtr = &MonoOffset)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, int* pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffset);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* MonoOffsetPtr = &MonoOffset)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipMode, MonoOffsetPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, int* pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0, pFlipModePtr, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffset);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, VideoProcessorStereoFlipMode* pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (int* MonoOffsetPtr = &MonoOffset)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipMode, MonoOffsetPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, int* MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffset);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamStereoFormat(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorStereoFormat pFormat, ref int pLeftViewFrame0, ref int pBaseViewFrame0, ref VideoProcessorStereoFlipMode pFlipMode, ref int MonoOffset)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorStereoFormat* pFormatPtr = &pFormat)
                    {
                        fixed (int* pLeftViewFrame0Ptr = &pLeftViewFrame0)
                        {
                            fixed (int* pBaseViewFrame0Ptr = &pBaseViewFrame0)
                            {
                                fixed (VideoProcessorStereoFlipMode* pFlipModePtr = &pFlipMode)
                                {
                                    fixed (int* MonoOffsetPtr = &MonoOffset)
                                    {
            #if NET5_0_OR_GREATER
                                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
            #else
                                        if (SilkMarshal.IsWinapiStdcall)
                                        {
                                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                        }
                                        else
                                        {
                                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorStereoFormat*, int*, int*, VideoProcessorStereoFlipMode*, int*, void>)LpVtbl[49])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pFormatPtr, pLeftViewFrame0Ptr, pBaseViewFrame0Ptr, pFlipModePtr, MonoOffsetPtr);
                                        }
            #endif
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabled);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessor, StreamIndex, pEnabledPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabled);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamAutoProcessingMode(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnabled)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, void>)LpVtbl[50])(@this, pVideoProcessorPtr, StreamIndex, pEnabledPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevel);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pLevelPtr = &pLevel)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabled, pLevelPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevel);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnabledPtr = &pEnabled)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessor, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevel);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, int* pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pLevelPtr = &pLevel)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabled, pLevelPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, int* pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevel);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamFilter(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, VideoProcessorFilter Filter, ref int pEnabled, ref int pLevel)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnabledPtr = &pEnabled)
                {
                    fixed (int* pLevelPtr = &pLevel)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, VideoProcessorFilter, int*, int*, void>)LpVtbl[51])(@this, pVideoProcessorPtr, StreamIndex, Filter, pEnabledPtr, pLevelPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessor, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, Guid* pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuid, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorGetStreamExtension(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorGetStreamExtension<T0>(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref Guid pExtensionGuid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (Guid* pExtensionGuidPtr = &pExtensionGuid)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, Guid*, uint, void*, int>)LpVtbl[52])(@this, pVideoProcessorPtr, StreamIndex, pExtensionGuidPtr, DataSize, pDataPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreams);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pView, OutputFrame, StreamCount, pStreamsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreams);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ID3D11VideoProcessor* pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessor, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreams);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ID3D11VideoProcessorOutputView* pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pView, OutputFrame, StreamCount, pStreamsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, VideoProcessorStream* pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreams);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int VideoProcessorBlt(ref ID3D11VideoProcessor pVideoProcessor, ref ID3D11VideoProcessorOutputView pView, uint OutputFrame, uint StreamCount, ref VideoProcessorStream pStreams)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (ID3D11VideoProcessorOutputView* pViewPtr = &pView)
                {
                    fixed (VideoProcessorStream* pStreamsPtr = &pStreams)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, ID3D11VideoProcessorOutputView*, uint, uint, VideoProcessorStream*, int>)LpVtbl[53])(@this, pVideoProcessorPtr, pViewPtr, OutputFrame, StreamCount, pStreamsPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ID3D11CryptoSession* pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange<T0>(ID3D11CryptoSession* pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSession, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateCryptoSessionKeyExchange(ref ID3D11CryptoSession pCryptoSession, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateCryptoSessionKeyExchange<T0>(ref ID3D11CryptoSession pCryptoSession, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[54])(@this, pCryptoSessionPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIV);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pIVPtr = &pIV)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EncryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EncryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, uint, void*, void>)LpVtbl[55])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pIVPtr = &pIV)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pContentKeyPtr = &pContentKey)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pContentKeyPtr = &pContentKey)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ID3D11CryptoSession* pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSession, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pIVPtr = &pIV)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pContentKeyPtr = &pContentKey)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ID3D11Texture2D* pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurface, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pIVPtr = &pIV)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (void* pContentKeyPtr = &pContentKey)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ID3D11Texture2D* pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurface, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIV);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pIVPtr = &pIV)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKey, IVSize, pIVPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, EncryptedBlockInfo* pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (void* pContentKeyPtr = &pContentKey)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfo, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, void* pIV)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIV);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, void* pContentKey, uint IVSize, ref T0 pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pIVPtr = &pIV)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKey, IVSize, pIVPtr);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecryptionBlt<T0>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, void* pIV) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pContentKeyPtr = &pContentKey)
                            {
            #if NET5_0_OR_GREATER
                                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
            #else
                                if (SilkMarshal.IsWinapiStdcall)
                                {
                                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                                }
                                else
                                {
                                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIV);
                                }
            #endif
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecryptionBlt<T0, T1>(ref ID3D11CryptoSession pCryptoSession, ref ID3D11Texture2D pSrcSurface, ref ID3D11Texture2D pDstSurface, ref EncryptedBlockInfo pEncryptedBlockInfo, uint ContentKeySize, ref T0 pContentKey, uint IVSize, ref T1 pIV) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (ID3D11Texture2D* pSrcSurfacePtr = &pSrcSurface)
                {
                    fixed (ID3D11Texture2D* pDstSurfacePtr = &pDstSurface)
                    {
                        fixed (EncryptedBlockInfo* pEncryptedBlockInfoPtr = &pEncryptedBlockInfo)
                        {
                            fixed (void* pContentKeyPtr = &pContentKey)
                            {
                                fixed (void* pIVPtr = &pIV)
                                {
            #if NET5_0_OR_GREATER
                                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
            #else
                                    if (SilkMarshal.IsWinapiStdcall)
                                    {
                                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                    }
                                    else
                                    {
                                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, ID3D11Texture2D*, ID3D11Texture2D*, EncryptedBlockInfo*, uint, void*, uint, void*, void>)LpVtbl[56])(@this, pCryptoSessionPtr, pSrcSurfacePtr, pDstSurfacePtr, pEncryptedBlockInfoPtr, ContentKeySize, pContentKeyPtr, IVSize, pIVPtr);
                                    }
            #endif
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumber);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh<T0>(ID3D11CryptoSession* pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pRandomNumberPtr = &pRandomNumber)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSession, RandomNumberSize, pRandomNumberPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void StartSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, void* pRandomNumber)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumber);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void StartSessionKeyRefresh<T0>(ref ID3D11CryptoSession pCryptoSession, uint RandomNumberSize, ref T0 pRandomNumber) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pRandomNumberPtr = &pRandomNumber)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, void>)LpVtbl[57])(@this, pCryptoSessionPtr, RandomNumberSize, pRandomNumberPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FinishSessionKeyRefresh(ID3D11CryptoSession* pCryptoSession)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSession);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSession);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSession);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void FinishSessionKeyRefresh(ref ID3D11CryptoSession pCryptoSession)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSessionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSessionPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, void>)LpVtbl[58])(@this, pCryptoSessionPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ID3D11CryptoSession* pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKey);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey<T0>(ID3D11CryptoSession* pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pReadbackKeyPtr = &pReadbackKey)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSession, KeySize, pReadbackKeyPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncryptionBltKey(ref ID3D11CryptoSession pCryptoSession, uint KeySize, void* pReadbackKey)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKey);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncryptionBltKey<T0>(ref ID3D11CryptoSession pCryptoSession, uint KeySize, ref T0 pReadbackKey) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11CryptoSession* pCryptoSessionPtr = &pCryptoSession)
            {
                fixed (void* pReadbackKeyPtr = &pReadbackKey)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11CryptoSession*, uint, void*, int>)LpVtbl[59])(@this, pCryptoSessionPtr, KeySize, pReadbackKeyPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ID3D11AuthenticatedChannel* pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange<T0>(ID3D11AuthenticatedChannel* pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannel, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int NegotiateAuthenticatedChannelKeyExchange(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, void* pData)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int NegotiateAuthenticatedChannelKeyExchange<T0>(ref ID3D11AuthenticatedChannel pChannel, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, int>)LpVtbl[60])(@this, pChannelPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInput, OutputSize, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutput);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0, T1>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                fixed (void* pOutputPtr = &pOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannel, InputSize, pInputPtr, OutputSize, pOutputPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, void* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutput);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, uint OutputSize, ref T0 pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pOutputPtr = &pOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInput, OutputSize, pOutputPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, void* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutput);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryAuthenticatedChannel<T0, T1>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, uint OutputSize, ref T1 pOutput) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    fixed (void* pOutputPtr = &pOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, uint, void*, int>)LpVtbl[61])(@this, pChannelPtr, InputSize, pInputPtr, OutputSize, pOutputPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ID3D11AuthenticatedChannel* pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInput, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutput);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ID3D11AuthenticatedChannel* pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pInputPtr = &pInput)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannel, InputSize, pInputPtr, pOutputPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, AuthenticatedConfigureOutput* pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutput);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, void* pInput, ref AuthenticatedConfigureOutput pOutput)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInput, pOutputPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, AuthenticatedConfigureOutput* pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutput);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConfigureAuthenticatedChannel<T0>(ref ID3D11AuthenticatedChannel pChannel, uint InputSize, ref T0 pInput, ref AuthenticatedConfigureOutput pOutput) where T0 : unmanaged
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11AuthenticatedChannel* pChannelPtr = &pChannel)
            {
                fixed (void* pInputPtr = &pInput)
                {
                    fixed (AuthenticatedConfigureOutput* pOutputPtr = &pOutput)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11AuthenticatedChannel*, uint, void*, AuthenticatedConfigureOutput*, int>)LpVtbl[62])(@this, pChannelPtr, InputSize, pInputPtr, pOutputPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorSetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessor, StreamIndex, Enable, Rotation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorSetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int Enable, VideoProcessorRotation Rotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int, VideoProcessorRotation, void>)LpVtbl[63])(@this, pVideoProcessorPtr, StreamIndex, Enable, Rotation);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnable, pRotationPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotation);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ID3D11VideoProcessor* pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (int* pEnablePtr = &pEnable)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessor, StreamIndex, pEnablePtr, pRotationPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotation);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, int* pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnable, pRotationPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, VideoProcessorRotation* pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotation);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void VideoProcessorGetStreamRotation(ref ID3D11VideoProcessor pVideoProcessor, uint StreamIndex, ref int pEnable, ref VideoProcessorRotation pRotation)
        {
            var @this = (ID3D11VideoContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D11VideoProcessor* pVideoProcessorPtr = &pVideoProcessor)
            {
                fixed (int* pEnablePtr = &pEnable)
                {
                    fixed (VideoProcessorRotation* pRotationPtr = &pRotation)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D11VideoContext*, ID3D11VideoProcessor*, uint, int*, VideoProcessorRotation*, void>)LpVtbl[64])(@this, pVideoProcessorPtr, StreamIndex, pEnablePtr, pRotationPtr);
                        }
            #endif
                    }
                }
            }
        }

    }
}
