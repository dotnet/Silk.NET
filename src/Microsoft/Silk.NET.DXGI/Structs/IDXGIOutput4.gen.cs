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
    [Guid("dc7dca35-2196-414d-9f53-617884032a60")]
    [NativeName("Name", "IDXGIOutput4")]
    public unsafe partial struct IDXGIOutput4
    {
        public static readonly Guid Guid = new("dc7dca35-2196-414d-9f53-617884032a60");

        public static implicit operator IDXGIOutput3(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, IDXGIOutput3>(ref val);

        public static implicit operator IDXGIOutput2(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, IDXGIOutput2>(ref val);

        public static implicit operator IDXGIOutput1(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, IDXGIOutput1>(ref val);

        public static implicit operator IDXGIOutput(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, IDXGIOutput>(ref val);

        public static implicit operator IDXGIObject(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, IDXGIObject>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDXGIOutput4 val)
            => Unsafe.As<IDXGIOutput4, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDXGIOutput4
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
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(Guid* Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData<T0>(Guid* Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, Name, DataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateData(ref Guid Name, uint DataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateData<T0>(ref Guid Name, uint DataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint, void*, int>)LpVtbl[3])(@this, NamePtr, DataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknown);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(Guid* Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, Name, pUnknownPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] Silk.NET.Core.Native.IUnknown* pUnknown)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknown);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPrivateDataInterface(ref Guid Name, [Flow(FlowDirection.In)] in Silk.NET.Core.Native.IUnknown pUnknown)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pUnknownPtr = &pUnknown)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[4])(@this, NamePtr, pUnknownPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pData);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pDataPtr = &pData)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSize, pDataPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(Guid* Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(Guid* Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pDataSizePtr = &pDataSize)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, Name, pDataSizePtr, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, uint* pDataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pData);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData<T0>(ref Guid Name, uint* pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (void* pDataPtr = &pData)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSize, pDataPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPrivateData(ref Guid Name, ref uint pDataSize, void* pData)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pData);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPrivateData<T0>(ref Guid Name, ref uint pDataSize, ref T0 pData) where T0 : unmanaged
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* NamePtr = &Name)
            {
                fixed (uint* pDataSizePtr = &pDataSize)
                {
                    fixed (void* pDataPtr = &pData)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, uint*, void*, int>)LpVtbl[5])(@this, NamePtr, pDataSizePtr, pDataPtr);
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
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParent);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(Guid* riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppParentPtr = &ppParent)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riid, ppParentPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, void** ppParent)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParent);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetParent(ref Guid riid, ref void* ppParent)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppParentPtr = &ppParent)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Guid*, void**, int>)LpVtbl[6])(@this, riidPtr, ppParentPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(OutputDesc* pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref OutputDesc pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (OutputDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, OutputDesc*, int>)LpVtbl[7])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc* pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc*, int>)LpVtbl[8])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ModeDesc* pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ModeDesc* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode(ref ModeDesc pModeToMatch, ref ModeDesc pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc*, ModeDesc*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[9])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WaitForVBlank()
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, int>)LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TakeOwnership(Silk.NET.Core.Native.IUnknown* pDevice, int Exclusive)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevice, Exclusive);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevice, Exclusive);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevice, Exclusive);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int TakeOwnership(ref Silk.NET.Core.Native.IUnknown pDevice, int Exclusive)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevicePtr, Exclusive);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevicePtr, Exclusive);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, int, int>)LpVtbl[11])(@this, pDevicePtr, Exclusive);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseOwnership()
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, void>)LpVtbl[12])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControlCapabilities(GammaControlCapabilities* pGammaCaps)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCaps);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCaps);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCaps);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControlCapabilities(ref GammaControlCapabilities pGammaCaps)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControlCapabilities* pGammaCapsPtr = &pGammaCaps)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCapsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCapsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControlCapabilities*, int>)LpVtbl[13])(@this, pGammaCapsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArray);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArray);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArray);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArrayPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArrayPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[14])(@this, pArrayPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGammaControl(GammaControl* pArray)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArray);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArray);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArray);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGammaControl(ref GammaControl pArray)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GammaControl* pArrayPtr = &pArray)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArrayPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArrayPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, GammaControl*, int>)LpVtbl[15])(@this, pArrayPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetDisplaySurface(IDXGISurface* pScanoutSurface)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurface);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurface);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurface);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetDisplaySurface(ref IDXGISurface pScanoutSurface)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface* pScanoutSurfacePtr = &pScanoutSurface)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurfacePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurfacePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[16])(@this, pScanoutSurfacePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData(IDXGISurface* pDestination)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestination);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestination);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestination);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData(ref IDXGISurface pDestination)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGISurface* pDestinationPtr = &pDestination)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestinationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestinationPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGISurface*, int>)LpVtbl[17])(@this, pDestinationPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFrameStatistics(FrameStatistics* pStats)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStats);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStats);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStats);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFrameStatistics(ref FrameStatistics pStats)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FrameStatistics* pStatsPtr = &pStats)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStatsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStatsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, FrameStatistics*, int>)LpVtbl[18])(@this, pStatsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, uint* pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModes, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ModeDesc1* pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplayModeList1(Silk.NET.DXGI.Format EnumFormat, uint Flags, ref uint pNumModes, ref ModeDesc1 pDesc)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pNumModesPtr = &pNumModes)
            {
                fixed (ModeDesc1* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, uint, uint*, ModeDesc1*, int>)LpVtbl[19])(@this, EnumFormat, Flags, pNumModesPtr, pDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevice);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatch, pConcernedDevicePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ModeDesc1* pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatch, pClosestMatchPtr, pConcernedDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevice);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ModeDesc1* pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatch, pConcernedDevicePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, Silk.NET.Core.Native.IUnknown* pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevice);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindClosestMatchingMode1(ref ModeDesc1 pModeToMatch, ref ModeDesc1 pClosestMatch, ref Silk.NET.Core.Native.IUnknown pConcernedDevice)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ModeDesc1* pModeToMatchPtr = &pModeToMatch)
            {
                fixed (ModeDesc1* pClosestMatchPtr = &pClosestMatch)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, ModeDesc1*, ModeDesc1*, Silk.NET.Core.Native.IUnknown*, int>)LpVtbl[20])(@this, pModeToMatchPtr, pClosestMatchPtr, pConcernedDevicePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDisplaySurfaceData1(IDXGIResource* pDestination)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestination);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestination);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestination);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDisplaySurfaceData1(ref IDXGIResource pDestination)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIResource* pDestinationPtr = &pDestination)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestinationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestinationPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, IDXGIResource*, int>)LpVtbl[21])(@this, pDestinationPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplication);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplication);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplication);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(Silk.NET.Core.Native.IUnknown* pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevice, ppOutputDuplicationPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, IDXGIOutputDuplication** ppOutputDuplication)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplication);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DuplicateOutput(ref Silk.NET.Core.Native.IUnknown pDevice, ref IDXGIOutputDuplication* ppOutputDuplication)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pDevicePtr = &pDevice)
            {
                fixed (IDXGIOutputDuplication** ppOutputDuplicationPtr = &ppOutputDuplication)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.Core.Native.IUnknown*, IDXGIOutputDuplication**, int>)LpVtbl[22])(@this, pDevicePtr, ppOutputDuplicationPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SupportsOverlays()
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, int>)LpVtbl[23])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevice, pFlagsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlaySupport(Silk.NET.DXGI.Format EnumFormat, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                fixed (uint* pFlagsPtr = &pFlags)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[24])(@this, EnumFormat, pConcernedDevicePtr, pFlagsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlags);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, Silk.NET.Core.Native.IUnknown* pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pFlagsPtr = &pFlags)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevice, pFlagsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, uint* pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlags);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CheckOverlayColorSpaceSupport(Silk.NET.DXGI.Format Format, ColorSpaceType ColorSpace, ref Silk.NET.Core.Native.IUnknown pConcernedDevice, ref uint pFlags)
        {
            var @this = (IDXGIOutput4*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* pConcernedDevicePtr = &pConcernedDevice)
            {
                fixed (uint* pFlagsPtr = &pFlags)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDXGIOutput4*, Silk.NET.DXGI.Format, ColorSpaceType, Silk.NET.Core.Native.IUnknown*, uint*, int>)LpVtbl[25])(@this, Format, ColorSpace, pConcernedDevicePtr, pFlagsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
