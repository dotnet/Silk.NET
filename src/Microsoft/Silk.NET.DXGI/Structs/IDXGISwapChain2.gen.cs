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
    public unsafe partial struct IDXGISwapChain2
    {
        public static readonly Guid Guid = new("a8be2ac4-199f-4946-b331-79599fb98de7");

        public static implicit operator IDXGISwapChain1(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, IDXGISwapChain1>(ref val);

        public static implicit operator Silk.NET.DXGI.IDXGISwapChain(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, Silk.NET.DXGI.IDXGISwapChain>(ref val);

        public static implicit operator IDXGIDeviceSubObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, IDXGIDeviceSubObject>(ref val);

        public static implicit operator IDXGIObject(IDXGISwapChain2 val)
            => Unsafe.As<IDXGISwapChain2, IDXGIObject>(ref val);

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
            #endif
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
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
            #endif
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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present(uint SyncInterval, uint Flags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, uint, int>)LpVtbl[8])(@this, SyncInterval, Flags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, Guid* riid, void** ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffer(uint Buffer, Guid* riid, ref void* ppSurface)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppSurfacePtr = &ppSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riid, ppSurfacePtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurface);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, Guid*, void**, int>)LpVtbl[9])(@this, Buffer, riidPtr, ppSurfacePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetFullscreenState(int Fullscreen, IDXGIOutput* pTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTarget);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetFullscreenState(int Fullscreen, ref IDXGIOutput pTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput* pTargetPtr = &pTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int, IDXGIOutput*, int>)LpVtbl[10])(@this, Fullscreen, pTargetPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(int* pFullscreen, IDXGIOutput** ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTarget);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenState(int* pFullscreen, ref IDXGIOutput* ppTarget)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppTargetPtr = &ppTarget)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreen, ppTargetPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTarget);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, int*, IDXGIOutput**, int>)LpVtbl[11])(@this, pFullscreenPtr, ppTargetPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(SwapChainDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref SwapChainDesc pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainDesc*, int>)LpVtbl[12])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeBuffers(uint BufferCount, uint Width, uint Height, Silk.NET.DXGI.Format NewFormat, uint SwapChainFlags)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, uint, uint, Silk.NET.DXGI.Format, uint, int>)LpVtbl[13])(@this, BufferCount, Width, Height, NewFormat, SwapChainFlags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ResizeTarget(ModeDesc* pNewTargetParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParameters);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResizeTarget(ref ModeDesc pNewTargetParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pNewTargetParametersPtr = &pNewTargetParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, ModeDesc*, int>)LpVtbl[14])(@this, pNewTargetParametersPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingOutput(IDXGIOutput** ppOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainingOutput(ref IDXGIOutput* ppOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppOutputPtr = &ppOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[15])(@this, ppOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStats);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, FrameStatistics*, int>)LpVtbl[16])(@this, pStatsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastPresentCount(uint* pLastPresentCount)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastPresentCount(ref uint pLastPresentCount)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pLastPresentCountPtr = &pLastPresentCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, int>)LpVtbl[17])(@this, pLastPresentCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc1(SwapChainDesc1* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc1(ref SwapChainDesc1 pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainDesc1* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainDesc1*, int>)LpVtbl[18])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullscreenDesc(SwapChainFullscreenDesc* pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFullscreenDesc(ref SwapChainFullscreenDesc pDesc)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SwapChainFullscreenDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, SwapChainFullscreenDesc*, int>)LpVtbl[19])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHwnd(nint* pHwnd)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwnd);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwnd);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwnd);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHwnd(ref nint pHwnd)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (nint* pHwndPtr = &pHwnd)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwndPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwndPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, nint*, int>)LpVtbl[20])(@this, pHwndPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(Guid* refiid, void** ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnk);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnk);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnk);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCoreWindow(Guid* refiid, ref void* ppUnk)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppUnkPtr = &ppUnk)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnkPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnkPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiid, ppUnkPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnk);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnk);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnk);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Guid*, void**, int>)LpVtbl[21])(@this, refiidPtr, ppUnkPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Present1(uint SyncInterval, uint PresentFlags, PresentParameters* pPresentParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParameters);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Present1(uint SyncInterval, uint PresentFlags, ref PresentParameters pPresentParameters)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PresentParameters* pPresentParametersPtr = &pPresentParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, uint, PresentParameters*, int>)LpVtbl[22])(@this, SyncInterval, PresentFlags, pPresentParametersPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsTemporaryMonoSupported()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRestrictToOutput(ref IDXGIOutput* ppRestrictToOutput)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutput** ppRestrictToOutputPtr = &ppRestrictToOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, IDXGIOutput**, int>)LpVtbl[24])(@this, ppRestrictToOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetBackgroundColor(D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColor);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColor);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D3Dcolorvalue* pColorPtr = &pColor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColorPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[25])(@this, pColorPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBackgroundColor(D3Dcolorvalue* pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColor);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColor);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBackgroundColor(ref D3Dcolorvalue pColor)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (D3Dcolorvalue* pColorPtr = &pColor)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColorPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, D3Dcolorvalue*, int>)LpVtbl[26])(@this, pColorPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRotation(ModeRotation Rotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, ModeRotation, int>)LpVtbl[27])(@this, Rotation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation, int>)LpVtbl[27])(@this, Rotation);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, ModeRotation, int>)LpVtbl[27])(@this, Rotation);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRotation(ModeRotation* pRotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotation);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotation);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRotation(ref ModeRotation pRotation)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeRotation* pRotationPtr = &pRotation)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotationPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, ModeRotation*, int>)LpVtbl[28])(@this, pRotationPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSourceSize(uint Width, uint Height)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, uint, int>)LpVtbl[29])(@this, Width, Height);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, uint, int>)LpVtbl[29])(@this, Width, Height);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, uint, int>)LpVtbl[29])(@this, Width, Height);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(uint* pWidth, uint* pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeight);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeight);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeight);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceSize(uint* pWidth, ref uint pHeight)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pHeightPtr = &pHeight)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeightPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeightPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidth, pHeightPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeight);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeight);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeight);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, uint*, int>)LpVtbl[30])(@this, pWidthPtr, pHeightPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMaximumFrameLatency(uint MaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint, int>)LpVtbl[31])(@this, MaxLatency);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint, int>)LpVtbl[31])(@this, MaxLatency);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint, int>)LpVtbl[31])(@this, MaxLatency);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMaximumFrameLatency(uint* pMaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatency);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatency);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatency);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMaximumFrameLatency(ref uint pMaxLatency)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMaxLatencyPtr = &pMaxLatency)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatencyPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatencyPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, uint*, int>)LpVtbl[32])(@this, pMaxLatencyPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetFrameLatencyWaitableObject()
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, void*>)LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetMatrixTransform(Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrix);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrix);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrix);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrixPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrixPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[34])(@this, pMatrixPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMatrixTransform(Matrix3X2F* pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrix);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrix);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrix);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMatrixTransform(ref Matrix3X2F pMatrix)
        {
            var @this = (IDXGISwapChain2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix3X2F* pMatrixPtr = &pMatrix)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrixPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrixPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGISwapChain2*, Matrix3X2F*, int>)LpVtbl[35])(@this, pMatrixPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
