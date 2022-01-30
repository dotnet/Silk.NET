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
    [Guid("30961379-4609-4a41-998e-54fe567ee0c1")]
    [NativeName("Name", "IDXGIResource1")]
    public unsafe partial struct IDXGIResource1
    {
        public static readonly Guid Guid = new("30961379-4609-4a41-998e-54fe567ee0c1");

        public static implicit operator IDXGIResource(IDXGIResource1 val)
            => Unsafe.As<IDXGIResource1, IDXGIResource>(ref val);

        public static implicit operator IDXGIDeviceSubObject(IDXGIResource1 val)
            => Unsafe.As<IDXGIResource1, IDXGIDeviceSubObject>(ref val);

        public static implicit operator IDXGIObject(IDXGIResource1 val)
            => Unsafe.As<IDXGIResource1, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIResource1 val)
            => Unsafe.As<IDXGIResource1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIResource1
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
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
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
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, void** ppDevice)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(Guid* riid, ref void* ppDevice)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDevicePtr = &ppDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riid, ppDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, void** ppDevice)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDevice(ref Guid riid, ref void* ppDevice)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppDevicePtr = &ppDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Guid*, void**, int>)LpVtbl[7])(@this, riidPtr, ppDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedHandle(void** pSharedHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSharedHandle(ref void* pSharedHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pSharedHandlePtr = &pSharedHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, void**, int>)LpVtbl[8])(@this, pSharedHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUsage(uint* pUsage)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsage);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsage);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsage);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetUsage(ref uint pUsage)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pUsagePtr = &pUsage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsagePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsagePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint*, int>)LpVtbl[9])(@this, pUsagePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetEvictionPriority(uint EvictionPriority)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, uint, int>)LpVtbl[10])(@this, EvictionPriority);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, int>)LpVtbl[10])(@this, EvictionPriority);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint, int>)LpVtbl[10])(@this, EvictionPriority);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEvictionPriority(uint* pEvictionPriority)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriority);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriority);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriority);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEvictionPriority(ref uint pEvictionPriority)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pEvictionPriorityPtr = &pEvictionPriority)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriorityPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriorityPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint*, int>)LpVtbl[11])(@this, pEvictionPriorityPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubresourceSurface(uint index, IDXGISurface2** ppSurface)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSubresourceSurface(uint index, ref IDXGISurface2* ppSurface)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface2** ppSurfacePtr = &ppSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, uint, IDXGISurface2**, int>)LpVtbl[12])(@this, index, ppSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pHandlePtr = &pHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpName, pHandlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* lpNamePtr = &lpName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* lpNamePtr = &lpName)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandle);
            }
            #endif
            SilkMarshal.Free((nint)lpNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(Silk.NET.Core.Native.SecurityAttributes* pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            fixed (void** pHandlePtr = &pHandle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributes, dwAccess, lpNamePtr, pHandlePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)lpNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, char* lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpName, pHandlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* lpNamePtr = &lpName)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, ref char lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
                fixed (char* lpNamePtr = &lpName)
                {
                    fixed (void** pHandlePtr = &pHandle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, char*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, void** pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandle);
                }
            #endif
            SilkMarshal.Free((nint)lpNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedHandle(ref Silk.NET.Core.Native.SecurityAttributes pAttributes, uint dwAccess, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string lpName, ref void* pHandle)
        {
            var @this = (IDXGIResource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.SecurityAttributes* pAttributesPtr = &pAttributes)
            {
            var lpNamePtr = (byte*) SilkMarshal.StringToPtr(lpName, NativeStringEncoding.LPWStr);
                fixed (void** pHandlePtr = &pHandle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIResource1*, Silk.NET.Core.Native.SecurityAttributes*, uint, byte*, void**, int>)LpVtbl[13])(@this, pAttributesPtr, dwAccess, lpNamePtr, pHandlePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)lpNamePtr);
            }
            return ret;
        }

    }
}
