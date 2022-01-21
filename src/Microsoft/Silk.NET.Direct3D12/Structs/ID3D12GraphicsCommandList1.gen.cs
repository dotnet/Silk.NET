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

namespace Silk.NET.Direct3D12
{
    [Guid("553103fb-1fe7-4557-bb38-946d7d0e7ca7")]
    [NativeName("Name", "ID3D12GraphicsCommandList1")]
    public unsafe partial struct ID3D12GraphicsCommandList1
    {
        public static readonly Guid Guid = new("553103fb-1fe7-4557-bb38-946d7d0e7ca7");

        public static implicit operator ID3D12GraphicsCommandList(ID3D12GraphicsCommandList1 val)
            => Unsafe.As<ID3D12GraphicsCommandList1, ID3D12GraphicsCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12GraphicsCommandList1 val)
            => Unsafe.As<ID3D12GraphicsCommandList1, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12GraphicsCommandList1 val)
            => Unsafe.As<ID3D12GraphicsCommandList1, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12GraphicsCommandList1 val)
            => Unsafe.As<ID3D12GraphicsCommandList1, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12GraphicsCommandList1 val)
            => Unsafe.As<ID3D12GraphicsCommandList1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12GraphicsCommandList1
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
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
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
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CommandListType>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator, ID3D12PipelineState* pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialState);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialState);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator, ref ID3D12PipelineState pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocator, pInitialStatePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ref ID3D12CommandAllocator pAllocator, ID3D12PipelineState* pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialState);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator, ref ID3D12PipelineState pInitialState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
                fixed (ID3D12PipelineState* pInitialStatePtr = &pInitialState)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandAllocator*, ID3D12PipelineState*, int>)LpVtbl[10])(@this, pAllocatorPtr, pInitialStatePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState(ref ID3D12PipelineState pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineStatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[11])(@this, pPipelineStatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInstanced(uint VertexCountPerInstance, uint InstanceCount, uint StartVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, uint, uint, void>)LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, uint, uint, void>)LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, uint, uint, void>)LpVtbl[12])(@this, VertexCountPerInstance, InstanceCount, StartVertexLocation, StartInstanceLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawIndexedInstanced(uint IndexCountPerInstance, uint InstanceCount, uint StartIndexLocation, int BaseVertexLocation, uint StartInstanceLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, uint, int, uint, void>)LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, uint, int, uint, void>)LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, uint, int, uint, void>)LpVtbl[13])(@this, IndexCountPerInstance, InstanceCount, StartIndexLocation, BaseVertexLocation, StartInstanceLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Dispatch(uint ThreadGroupCountX, uint ThreadGroupCountY, uint ThreadGroupCountZ)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[14])(@this, ThreadGroupCountX, ThreadGroupCountY, ThreadGroupCountZ);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, NumBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyBufferRegion(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, ulong, void>)LpVtbl[15])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, NumBytes);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBox);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Box* pSrcBoxPtr = &pSrcBox)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(TextureCopyLocation* pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pSrcPtr = &pSrc)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDst, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBox);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, TextureCopyLocation* pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (Box* pSrcBoxPtr = &pSrcBox)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrc, pSrcBoxPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, Box* pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBox);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTextureRegion(ref TextureCopyLocation pDst, uint DstX, uint DstY, uint DstZ, ref TextureCopyLocation pSrc, ref Box pSrcBox)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TextureCopyLocation* pDstPtr = &pDst)
            {
                fixed (TextureCopyLocation* pSrcPtr = &pSrc)
                {
                    fixed (Box* pSrcBoxPtr = &pSrcBox)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, TextureCopyLocation*, uint, uint, uint, TextureCopyLocation*, Box*, void>)LpVtbl[16])(@this, pDstPtr, DstX, DstY, DstZ, pSrcPtr, pSrcBoxPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D12Resource* pDstResource, ID3D12Resource* pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResource);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResource);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ID3D12Resource* pDstResource, ref ID3D12Resource pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResource, pSrcResourcePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyResource(ref ID3D12Resource pDstResource, ID3D12Resource* pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResource);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyResource(ref ID3D12Resource pDstResource, ref ID3D12Resource pSrcResource)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ID3D12Resource*, void>)LpVtbl[17])(@this, pDstResourcePtr, pSrcResourcePtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ID3D12Resource* pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResource, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, TiledResourceCoordinate* pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinate, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBuffer, BufferStartOffsetInBytes, Flags);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, TileRegionSize* pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSize, pBufferPtr, BufferStartOffsetInBytes, Flags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ID3D12Resource* pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBuffer, BufferStartOffsetInBytes, Flags);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void CopyTiles(ref ID3D12Resource pTiledResource, ref TiledResourceCoordinate pTileRegionStartCoordinate, ref TileRegionSize pTileRegionSize, ref ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, TileCopyFlags Flags)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pTiledResourcePtr = &pTiledResource)
            {
                fixed (TiledResourceCoordinate* pTileRegionStartCoordinatePtr = &pTileRegionStartCoordinate)
                {
                    fixed (TileRegionSize* pTileRegionSizePtr = &pTileRegionSize)
                    {
                        fixed (ID3D12Resource* pBufferPtr = &pBuffer)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, TiledResourceCoordinate*, TileRegionSize*, ID3D12Resource*, ulong, TileCopyFlags, void>)LpVtbl[18])(@this, pTiledResourcePtr, pTileRegionStartCoordinatePtr, pTileRegionSizePtr, pBufferPtr, BufferStartOffsetInBytes, Flags);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResource, SrcSubresource, Format);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ID3D12Resource* pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResource, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResource, SrcSubresource, Format);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresource(ref ID3D12Resource pDstResource, uint DstSubresource, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.DXGI.Format Format)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, ID3D12Resource*, uint, Silk.NET.DXGI.Format, void>)LpVtbl[19])(@this, pDstResourcePtr, DstSubresource, pSrcResourcePtr, SrcSubresource, Format);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetPrimitiveTopology(Silk.NET.Core.Native.D3DPrimitiveTopology PrimitiveTopology)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[20])(@this, PrimitiveTopology);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[20])(@this, PrimitiveTopology);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, Silk.NET.Core.Native.D3DPrimitiveTopology, void>)LpVtbl[20])(@this, PrimitiveTopology);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetViewports(uint NumViewports, Viewport* pViewports)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewports);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewports);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewports);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetViewports(uint NumViewports, ref Viewport pViewports)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Viewport* pViewportsPtr = &pViewports)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewportsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewportsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, Viewport*, void>)LpVtbl[21])(@this, NumViewports, pViewportsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RSSetScissorRects(uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RSSetScissorRects(uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[22])(@this, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetBlendFactor([Count(Count = 4)] float* BlendFactor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetBlendFactor([Count(Count = 4)] ref float BlendFactor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* BlendFactorPtr = &BlendFactor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, float*, void>)LpVtbl[23])(@this, BlendFactorPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetStencilRef(uint StencilRef)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[24])(@this, StencilRef);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[24])(@this, StencilRef);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[24])(@this, StencilRef);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPipelineState(ID3D12PipelineState* pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineState);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineState);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineState);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineState(ref ID3D12PipelineState pPipelineState)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12PipelineState* pPipelineStatePtr = &pPipelineState)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineStatePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineStatePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12PipelineState*, void>)LpVtbl[25])(@this, pPipelineStatePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ResourceBarrier*, void>)LpVtbl[26])(@this, NumBarriers, pBarriersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteBundle(ID3D12GraphicsCommandList* pCommandList)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandList);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandList);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandList);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteBundle(ref ID3D12GraphicsCommandList pCommandList)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12GraphicsCommandList* pCommandListPtr = &pCommandList)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandListPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandListPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12GraphicsCommandList*, void>)LpVtbl[27])(@this, pCommandListPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ID3D12DescriptorHeap** ppDescriptorHeaps)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeaps);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescriptorHeaps(uint NumDescriptorHeaps, ref ID3D12DescriptorHeap* ppDescriptorHeaps)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12DescriptorHeap** ppDescriptorHeapsPtr = &ppDescriptorHeaps)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ID3D12DescriptorHeap**, void>)LpVtbl[28])(@this, NumDescriptorHeaps, ppDescriptorHeapsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignature);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignature);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignature);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignaturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignaturePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[29])(@this, pRootSignaturePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRootSignature(ID3D12RootSignature* pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignature);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignature);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignature);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootSignature(ref ID3D12RootSignature pRootSignature)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12RootSignature* pRootSignaturePtr = &pRootSignature)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignaturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignaturePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12RootSignature*, void>)LpVtbl[30])(@this, pRootSignaturePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[31])(@this, RootParameterIndex, BaseDescriptor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootDescriptorTable(uint RootParameterIndex, GpuDescriptorHandle BaseDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, GpuDescriptorHandle, void>)LpVtbl[32])(@this, RootParameterIndex, BaseDescriptor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[33])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRoot32BitConstant(uint RootParameterIndex, uint SrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, uint, void>)LpVtbl[34])(@this, RootParameterIndex, SrcData, DestOffsetIn32BitValues);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetComputeRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[35])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetGraphicsRoot32BitConstants(uint RootParameterIndex, uint Num32BitValuesToSet, void* pSrcData, uint DestOffsetIn32BitValues)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcData, DestOffsetIn32BitValues);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRoot32BitConstants<T0>(uint RootParameterIndex, uint Num32BitValuesToSet, ref T0 pSrcData, uint DestOffsetIn32BitValues) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pSrcDataPtr = &pSrcData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, void*, uint, void>)LpVtbl[36])(@this, RootParameterIndex, Num32BitValuesToSet, pSrcDataPtr, DestOffsetIn32BitValues);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[37])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootConstantBufferView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[38])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[39])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootShaderResourceView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[40])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetComputeRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[41])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetGraphicsRootUnorderedAccessView(uint RootParameterIndex, ulong BufferLocation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, ulong, void>)LpVtbl[42])(@this, RootParameterIndex, BufferLocation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetIndexBuffer(IndexBufferView* pView)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pView);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pView);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pView);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetIndexBuffer(ref IndexBufferView pView)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IndexBufferView* pViewPtr = &pView)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pViewPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pViewPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, IndexBufferView*, void>)LpVtbl[43])(@this, pViewPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void IASetVertexBuffers(uint StartSlot, uint NumViews, VertexBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void IASetVertexBuffers(uint StartSlot, uint NumViews, ref VertexBufferView pViews)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VertexBufferView* pViewsPtr = &pViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, VertexBufferView*, void>)LpVtbl[44])(@this, StartSlot, NumViews, pViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SOSetTargets(uint StartSlot, uint NumViews, StreamOutputBufferView* pViews)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViews);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViews);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViews);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SOSetTargets(uint StartSlot, uint NumViews, ref StreamOutputBufferView pViews)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (StreamOutputBufferView* pViewsPtr = &pViews)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, StreamOutputBufferView*, void>)LpVtbl[45])(@this, StartSlot, NumViews, pViewsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, CpuDescriptorHandle* pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptors, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, CpuDescriptorHandle* pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptor);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetRenderTargets(uint NumRenderTargetDescriptors, ref CpuDescriptorHandle pRenderTargetDescriptors, int RTsSingleHandleToDescriptorRange, ref CpuDescriptorHandle pDepthStencilDescriptor)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (CpuDescriptorHandle* pRenderTargetDescriptorsPtr = &pRenderTargetDescriptors)
            {
                fixed (CpuDescriptorHandle* pDepthStencilDescriptorPtr = &pDepthStencilDescriptor)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, CpuDescriptorHandle*, int, CpuDescriptorHandle*, void>)LpVtbl[46])(@this, NumRenderTargetDescriptors, pRenderTargetDescriptorsPtr, RTsSingleHandleToDescriptorRange, pDepthStencilDescriptorPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearDepthStencilView(CpuDescriptorHandle DepthStencilView, ClearFlags ClearFlags, float Depth, byte Stencil, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, ClearFlags, float, byte, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[47])(@this, DepthStencilView, ClearFlags, Depth, Stencil, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] float* ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBA, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearRenderTargetView(CpuDescriptorHandle RenderTargetView, [Count(Count = 4)] ref float ColorRGBA, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ColorRGBAPtr = &ColorRGBA)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, CpuDescriptorHandle, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[48])(@this, RenderTargetView, ColorRGBAPtr, NumRects, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] uint* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* ValuesPtr = &Values)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewUint(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref uint Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (uint* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, uint*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[49])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRects);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, Values, NumRects, pRectsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ID3D12Resource* pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* ValuesPtr = &Values)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResource, ValuesPtr, NumRects, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRects);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] float* Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, Values, NumRects, pRectsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, Silk.NET.Maths.Rectangle<int>* pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (float* ValuesPtr = &Values)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRects);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearUnorderedAccessViewFloat(GpuDescriptorHandle ViewGPUHandleInCurrentHeap, CpuDescriptorHandle ViewCPUHandle, ref ID3D12Resource pResource, [Count(Count = 4)] ref float Values, uint NumRects, ref Silk.NET.Maths.Rectangle<int> pRects)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (float* ValuesPtr = &Values)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pRectsPtr = &pRects)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, GpuDescriptorHandle, CpuDescriptorHandle, ID3D12Resource*, float*, uint, Silk.NET.Maths.Rectangle<int>*, void>)LpVtbl[50])(@this, ViewGPUHandleInCurrentHeap, ViewCPUHandle, pResourcePtr, ValuesPtr, NumRects, pRectsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegion);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegion);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegion);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegionPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResource, pRegionPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegion);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegion);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegion);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[51])(@this, pResourcePtr, pRegionPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeap, Type, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeap, Type, Index);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeap, Type, Index);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[52])(@this, pQueryHeapPtr, Type, Index);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeap, Type, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeap, Type, Index);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeap, Type, Index);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[53])(@this, pQueryHeapPtr, Type, Index);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[54])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[55])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pData, Size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pData, Size);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pData, Size);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pDataPtr, Size);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pDataPtr, Size);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[56])(@this, Metadata, pDataPtr, Size);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pData, Size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pData, Size);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pData, Size);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pDataPtr, Size);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pDataPtr, Size);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void*, uint, void>)LpVtbl[57])(@this, Metadata, pDataPtr, Size);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, void>)LpVtbl[58])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ID3D12CommandSignature* pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignature, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ID3D12Resource* pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBuffer, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ID3D12Resource* pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBuffer, CountBufferOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteIndirect(ref ID3D12CommandSignature pCommandSignature, uint MaxCommandCount, ref ID3D12Resource pArgumentBuffer, ulong ArgumentBufferOffset, ref ID3D12Resource pCountBuffer, ulong CountBufferOffset)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12CommandSignature* pCommandSignaturePtr = &pCommandSignature)
            {
                fixed (ID3D12Resource* pArgumentBufferPtr = &pArgumentBuffer)
                {
                    fixed (ID3D12Resource* pCountBufferPtr = &pCountBuffer)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12CommandSignature*, uint, ID3D12Resource*, ulong, ID3D12Resource*, ulong, void>)LpVtbl[59])(@this, pCommandSignaturePtr, MaxCommandCount, pArgumentBufferPtr, ArgumentBufferOffset, pCountBufferPtr, CountBufferOffset);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[60])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ID3D12Resource* pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBuffer, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ID3D12Resource* pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBuffer, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRanges);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ID3D12Resource** ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResources, pDependentSubresourceRangesPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, SubresourceRangeUint64* pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRanges);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void AtomicCopyBufferUINT64(ref ID3D12Resource pDstBuffer, ulong DstOffset, ref ID3D12Resource pSrcBuffer, ulong SrcOffset, uint Dependencies, ref ID3D12Resource* ppDependentResources, ref SubresourceRangeUint64 pDependentSubresourceRanges)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstBufferPtr = &pDstBuffer)
            {
                fixed (ID3D12Resource* pSrcBufferPtr = &pSrcBuffer)
                {
                    fixed (ID3D12Resource** ppDependentResourcesPtr = &ppDependentResources)
                    {
                        fixed (SubresourceRangeUint64* pDependentSubresourceRangesPtr = &pDependentSubresourceRanges)
                        {
            #if NET5_0_OR_GREATER
                            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                            }
                            else
                            {
                                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, ulong, ID3D12Resource*, ulong, uint, ID3D12Resource**, SubresourceRangeUint64*, void>)LpVtbl[61])(@this, pDstBufferPtr, DstOffset, pSrcBufferPtr, SrcOffset, Dependencies, ppDependentResourcesPtr, pDependentSubresourceRangesPtr);
                            }
            #endif
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void OMSetDepthBounds(float Min, float Max)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, float, float, void>)LpVtbl[62])(@this, Min, Max);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, float, float, void>)LpVtbl[62])(@this, Min, Max);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, float, float, void>)LpVtbl[62])(@this, Min, Max);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, SamplePosition* pSamplePositions)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositions);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetSamplePositions(uint NumSamplesPerPixel, uint NumPixels, ref SamplePosition pSamplePositions)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (SamplePosition* pSamplePositionsPtr = &pSamplePositions)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, uint, SamplePosition*, void>)LpVtbl[63])(@this, NumSamplesPerPixel, NumPixels, pSamplePositionsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ID3D12Resource* pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResource, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRect, Format, ResolveMode);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ID3D12Resource* pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResource, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, Silk.NET.Maths.Rectangle<int>* pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRect, Format, ResolveMode);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveSubresourceRegion(ref ID3D12Resource pDstResource, uint DstSubresource, uint DstX, uint DstY, ref ID3D12Resource pSrcResource, uint SrcSubresource, ref Silk.NET.Maths.Rectangle<int> pSrcRect, Silk.NET.DXGI.Format Format, ResolveMode ResolveMode)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDstResourcePtr = &pDstResource)
            {
                fixed (ID3D12Resource* pSrcResourcePtr = &pSrcResource)
                {
                    fixed (Silk.NET.Maths.Rectangle<int>* pSrcRectPtr = &pSrcRect)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, ID3D12Resource*, uint, uint, uint, ID3D12Resource*, uint, Silk.NET.Maths.Rectangle<int>*, Silk.NET.DXGI.Format, ResolveMode, void>)LpVtbl[64])(@this, pDstResourcePtr, DstSubresource, DstX, DstY, pSrcResourcePtr, SrcSubresource, pSrcRectPtr, Format, ResolveMode);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetViewInstanceMask(uint Mask)
        {
            var @this = (ID3D12GraphicsCommandList1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[65])(@this, Mask);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[65])(@this, Mask);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12GraphicsCommandList1*, uint, void>)LpVtbl[65])(@this, Mask);
            }
            #endif
        }

    }
}
