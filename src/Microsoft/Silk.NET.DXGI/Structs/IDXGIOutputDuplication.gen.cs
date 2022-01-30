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
    [Guid("191cfac3-a341-470d-b26e-a864f428319c")]
    [NativeName("Name", "IDXGIOutputDuplication")]
    public unsafe partial struct IDXGIOutputDuplication
    {
        public static readonly Guid Guid = new("191cfac3-a341-470d-b26e-a864f428319c");

        public static implicit operator IDXGIObject(IDXGIOutputDuplication val)
            => Unsafe.As<IDXGIOutputDuplication, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutputDuplication val)
            => Unsafe.As<IDXGIOutputDuplication, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutputDuplication
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
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
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
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDesc(OutduplDesc* pDesc)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDesc);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDesc);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDesc(ref OutduplDesc pDesc)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (OutduplDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDescPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, OutduplDesc*, void>)LpVtbl[7])(@this, pDescPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResource);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, OutduplFrameInfo* pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfo, ppDesktopResourcePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, IDXGIResource** ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResource);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AcquireNextFrame(uint TimeoutInMilliseconds, ref OutduplFrameInfo pFrameInfo, ref IDXGIResource* ppDesktopResource)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplFrameInfo* pFrameInfoPtr = &pFrameInfo)
            {
                fixed (IDXGIResource** ppDesktopResourcePtr = &ppDesktopResource)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResourcePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResourcePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplFrameInfo*, IDXGIResource**, int>)LpVtbl[8])(@this, TimeoutInMilliseconds, pFrameInfoPtr, ppDesktopResourcePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Maths.Rectangle<int>* pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequired);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, Silk.NET.Maths.Rectangle<int>* pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBuffer, pDirtyRectsBufferSizeRequiredPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Maths.Rectangle<int> pDirtyRectsBuffer, uint* pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequired);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameDirtyRects(uint DirtyRectsBufferSize, ref Silk.NET.Maths.Rectangle<int> pDirtyRectsBuffer, ref uint pDirtyRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* pDirtyRectsBufferPtr = &pDirtyRectsBuffer)
            {
                fixed (uint* pDirtyRectsBufferSizeRequiredPtr = &pDirtyRectsBufferSizeRequired)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, Silk.NET.Maths.Rectangle<int>*, uint*, int>)LpVtbl[9])(@this, DirtyRectsBufferSize, pDirtyRectsBufferPtr, pDirtyRectsBufferSizeRequiredPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequired);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, OutduplMoveRect* pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBuffer, pMoveRectsBufferSizeRequiredPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, uint* pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequired);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameMoveRects(uint MoveRectsBufferSize, ref OutduplMoveRect pMoveRectBuffer, ref uint pMoveRectsBufferSizeRequired)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplMoveRect* pMoveRectBufferPtr = &pMoveRectBuffer)
            {
                fixed (uint* pMoveRectsBufferSizeRequiredPtr = &pMoveRectsBufferSizeRequired)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequiredPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequiredPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, OutduplMoveRect*, uint*, int>)LpVtbl[10])(@this, MoveRectsBufferSize, pMoveRectBufferPtr, pMoveRectsBufferSizeRequiredPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape(uint PointerShapeBufferSize, void* pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
            {
                fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBuffer, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfo);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, uint* pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
            {
                fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequired, pPointerShapeInfoPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, OutduplPointerShapeInfo* pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
            {
                fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfo);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFramePointerShape<T0>(uint PointerShapeBufferSize, ref T0 pPointerShapeBuffer, ref uint pPointerShapeBufferSizeRequired, ref OutduplPointerShapeInfo pPointerShapeInfo) where T0 : unmanaged
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pPointerShapeBufferPtr = &pPointerShapeBuffer)
            {
                fixed (uint* pPointerShapeBufferSizeRequiredPtr = &pPointerShapeBufferSizeRequired)
                {
                    fixed (OutduplPointerShapeInfo* pPointerShapeInfoPtr = &pPointerShapeInfo)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, uint, void*, uint*, OutduplPointerShapeInfo*, int>)LpVtbl[11])(@this, PointerShapeBufferSize, pPointerShapeBufferPtr, pPointerShapeBufferSizeRequiredPtr, pPointerShapeInfoPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MapDesktopSurface(MappedRect* pLockedRect)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRect);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRect);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRect);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MapDesktopSurface(ref MappedRect pLockedRect)
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MappedRect* pLockedRectPtr = &pLockedRect)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutputDuplication*, MappedRect*, int>)LpVtbl[12])(@this, pLockedRectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnMapDesktopSurface()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ReleaseFrame()
        {
            var @this = (IDXGIOutputDuplication*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutputDuplication*, int>)LpVtbl[14])(@this);
            return ret;
        }

    }
}
