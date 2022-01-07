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
    [Guid("6e120880-c114-4153-8036-d247051e1729")]
    [NativeName("Name", "ID3D12VideoDecodeCommandList2")]
    public unsafe partial struct ID3D12VideoDecodeCommandList2
    {
        public static readonly Guid Guid = new("6e120880-c114-4153-8036-d247051e1729");

        public static implicit operator ID3D12VideoDecodeCommandList1(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, ID3D12VideoDecodeCommandList1>(ref val);

        public static implicit operator ID3D12VideoDecodeCommandList(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, ID3D12VideoDecodeCommandList>(ref val);

        public static implicit operator ID3D12CommandList(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, ID3D12CommandList>(ref val);

        public static implicit operator ID3D12DeviceChild(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, ID3D12DeviceChild>(ref val);

        public static implicit operator ID3D12Object(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, ID3D12Object>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12VideoDecodeCommandList2 val)
            => Unsafe.As<ID3D12VideoDecodeCommandList2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12VideoDecodeCommandList2
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
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guid, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, uint* pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid guid, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid guid, ref uint pDataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid guid, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint*, void*, int>)LpVtbl[3])(@this, guidPtr, pDataSizePtr, pDataPtr);
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
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guid, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid guid, uint DataSize, void* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid guid, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, uint, void*, int>)LpVtbl[4])(@this, guidPtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guid, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid guid, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pData)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidPtr = &guid)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[5])(@this, guidPtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetName(char* Name)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName(ref char Name)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, char*, int>)LpVtbl[6])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, byte*, int>)LpVtbl[6])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvDevicePtr = &ppvDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppvDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppvDevice)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvDevicePtr = &ppvDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppvDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CommandListType GetType()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CommandListType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, CommandListType>)LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, int>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Reset(ID3D12CommandAllocator* pAllocator)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocator);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Reset(ref ID3D12CommandAllocator pAllocator)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CommandAllocator* pAllocatorPtr = &pAllocator)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12CommandAllocator*, int>)LpVtbl[10])(@this, pAllocatorPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ClearState()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, void>)LpVtbl[11])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResourceBarrier(uint NumBarriers, ResourceBarrier* pBarriers)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriers);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void ResourceBarrier(uint NumBarriers, ref ResourceBarrier pBarriers)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ResourceBarrier* pBarriersPtr = &pBarriers)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, ResourceBarrier*, void>)LpVtbl[12])(@this, NumBarriers, pBarriersPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegion);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ID3D12Resource* pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DiscardRegion* pRegionPtr = &pRegion)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResource, pRegionPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DiscardResource(ref ID3D12Resource pResource, DiscardRegion* pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegion);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DiscardResource(ref ID3D12Resource pResource, ref DiscardRegion pRegion)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pResourcePtr = &pResource)
            {
                fixed (DiscardRegion* pRegionPtr = &pRegion)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, DiscardRegion*, void>)LpVtbl[13])(@this, pResourcePtr, pRegionPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeap, Type, Index);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[14])(@this, pQueryHeapPtr, Type, Index);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EndQuery(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeap, Type, Index);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void EndQuery(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint Index)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, void>)LpVtbl[15])(@this, pQueryHeapPtr, Type, Index);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ID3D12QueryHeap* pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeap, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ID3D12Resource* pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBuffer, AlignedDestinationBufferOffset);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ResolveQueryData(ref ID3D12QueryHeap pQueryHeap, QueryType Type, uint StartIndex, uint NumQueries, ref ID3D12Resource pDestinationBuffer, ulong AlignedDestinationBufferOffset)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12QueryHeap* pQueryHeapPtr = &pQueryHeap)
            {
                fixed (ID3D12Resource* pDestinationBufferPtr = &pDestinationBuffer)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12QueryHeap*, QueryType, uint, uint, ID3D12Resource*, ulong, void>)LpVtbl[16])(@this, pQueryHeapPtr, Type, StartIndex, NumQueries, pDestinationBufferPtr, AlignedDestinationBufferOffset);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetPredication(ID3D12Resource* pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBuffer, AlignedBufferOffset, Operation);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPredication(ref ID3D12Resource pBuffer, ulong AlignedBufferOffset, PredicationOp Operation)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12Resource* pBufferPtr = &pBuffer)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12Resource*, ulong, PredicationOp, void>)LpVtbl[17])(@this, pBufferPtr, AlignedBufferOffset, Operation);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pData, Size);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[18])(@this, Metadata, pDataPtr, Size);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void BeginEvent(uint Metadata, void* pData, uint Size)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pData, Size);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginEvent<T0>(uint Metadata, ref T0 pData, uint Size) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, void*, uint, void>)LpVtbl[19])(@this, Metadata, pDataPtr, Size);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void EndEvent()
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, void>)LpVtbl[20])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecodeFrame(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments*, VideoDecodeInputStreamArguments*, void>)LpVtbl[21])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModes);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, WritebufferimmediateParameter* pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateMode* pModesPtr = &pModes)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParams, pModesPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, WritebufferimmediateMode* pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void WriteBufferImmediate(uint Count, ref WritebufferimmediateParameter pParams, ref WritebufferimmediateMode pModes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (WritebufferimmediateParameter* pParamsPtr = &pParams)
            {
                fixed (WritebufferimmediateMode* pModesPtr = &pModes)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, uint, WritebufferimmediateParameter*, WritebufferimmediateMode*, void>)LpVtbl[22])(@this, Count, pParamsPtr, pModesPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArguments);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArguments, pInputArgumentsPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArguments);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ID3D12VideoDecoder* pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoder, pOutputArgumentsPtr, pInputArgumentsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArguments);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, VideoDecodeOutputStreamArguments1* pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArguments, pInputArgumentsPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, VideoDecodeInputStreamArguments* pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArguments);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DecodeFrame1(ref ID3D12VideoDecoder pDecoder, ref VideoDecodeOutputStreamArguments1 pOutputArguments, ref VideoDecodeInputStreamArguments pInputArguments)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoDecoder* pDecoderPtr = &pDecoder)
            {
                fixed (VideoDecodeOutputStreamArguments1* pOutputArgumentsPtr = &pOutputArguments)
                {
                    fixed (VideoDecodeInputStreamArguments* pInputArgumentsPtr = &pInputArguments)
                    {
            #if NET5_0_OR_GREATER
                        ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
                        else
                        {
                            ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoDecoder*, VideoDecodeOutputStreamArguments1*, VideoDecodeInputStreamArguments*, void>)LpVtbl[23])(@this, pDecoderPtr, pOutputArgumentsPtr, pInputArgumentsPtr);
                        }
            #endif
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetProtectedResourceSession(ID3D12ProtectedResourceSession* pProtectedResourceSession)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSession);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSession);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSession);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetProtectedResourceSession(ref ID3D12ProtectedResourceSession pProtectedResourceSession)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12ProtectedResourceSession* pProtectedResourceSessionPtr = &pProtectedResourceSession)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSessionPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSessionPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12ProtectedResourceSession*, void>)LpVtbl[24])(@this, pProtectedResourceSessionPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParameters, InitializationParametersSizeInBytes);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pInitializationParametersPtr = &pInitializationParameters)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommand, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void InitializeExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pInitializationParameters, nuint InitializationParametersSizeInBytes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParameters, InitializationParametersSizeInBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void InitializeExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pInitializationParameters, nuint InitializationParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pInitializationParametersPtr = &pInitializationParameters)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[25])(@this, pExtensionCommandPtr, pInitializationParametersPtr, InitializationParametersSizeInBytes);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ID3D12VideoExtensionCommand* pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParameters, ExecutionParametersSizeInBytes);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand<T0>(ID3D12VideoExtensionCommand* pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* pExecutionParametersPtr = &pExecutionParameters)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommand, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ExecuteExtensionCommand(ref ID3D12VideoExtensionCommand pExtensionCommand, void* pExecutionParameters, nuint ExecutionParametersSizeInBytes)
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParameters, ExecutionParametersSizeInBytes);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void ExecuteExtensionCommand<T0>(ref ID3D12VideoExtensionCommand pExtensionCommand, ref T0 pExecutionParameters, nuint ExecutionParametersSizeInBytes) where T0 : unmanaged
        {
            var @this = (ID3D12VideoDecodeCommandList2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID3D12VideoExtensionCommand* pExtensionCommandPtr = &pExtensionCommand)
            {
                fixed (void* pExecutionParametersPtr = &pExecutionParameters)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<ID3D12VideoDecodeCommandList2*, ID3D12VideoExtensionCommand*, void*, nuint, void>)LpVtbl[26])(@this, pExtensionCommandPtr, pExecutionParametersPtr, ExecutionParametersSizeInBytes);
                    }
            #endif
                }
            }
        }

    }
}
