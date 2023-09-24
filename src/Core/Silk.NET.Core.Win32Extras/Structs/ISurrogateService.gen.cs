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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("000001d4-0000-0000-c000-000000000046")]
    [NativeName("Name", "ISurrogateService")]
    public unsafe partial struct ISurrogateService : IComVtbl<ISurrogateService>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("000001d4-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ISurrogateService val)
            => Unsafe.As<ISurrogateService, Silk.NET.Core.Native.IUnknown>(ref val);

        public ISurrogateService
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
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(Guid* rguidProcessID, IProcessLock* pProcessLock, int* pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLock, pfApplicationAware);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(Guid* rguidProcessID, IProcessLock* pProcessLock, ref int pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLock, pfApplicationAwarePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(Guid* rguidProcessID, ref IProcessLock pProcessLock, int* pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLockPtr, pfApplicationAware);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(Guid* rguidProcessID, ref IProcessLock pProcessLock, ref int pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
            {
                fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessID, pProcessLockPtr, pfApplicationAwarePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(ref Guid rguidProcessID, IProcessLock* pProcessLock, int* pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLock, pfApplicationAware);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(ref Guid rguidProcessID, IProcessLock* pProcessLock, ref int pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
            {
                fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLock, pfApplicationAwarePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init(ref Guid rguidProcessID, ref IProcessLock pProcessLock, int* pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
            {
                fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLockPtr, pfApplicationAware);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Init(ref Guid rguidProcessID, ref IProcessLock pProcessLock, ref int pfApplicationAware)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidProcessIDPtr = &rguidProcessID)
            {
                fixed (IProcessLock* pProcessLockPtr = &pProcessLock)
                {
                    fixed (int* pfApplicationAwarePtr = &pfApplicationAware)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, IProcessLock*, int*, int>)@this->LpVtbl[3])(@this, rguidProcessIDPtr, pProcessLockPtr, pfApplicationAwarePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ApplicationLaunch(Guid* rguidApplID, ApplicationType appType)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, ApplicationType, int>)@this->LpVtbl[4])(@this, rguidApplID, appType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ApplicationLaunch(ref Guid rguidApplID, ApplicationType appType)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidApplIDPtr = &rguidApplID)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, ApplicationType, int>)@this->LpVtbl[4])(@this, rguidApplIDPtr, appType);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ApplicationFree(Guid* rguidApplID)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, int>)@this->LpVtbl[5])(@this, rguidApplID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ApplicationFree(ref Guid rguidApplID)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* rguidApplIDPtr = &rguidApplID)
            {
                ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, Guid*, int>)@this->LpVtbl[5])(@this, rguidApplIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CatalogRefresh(uint ulReserved)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, uint, int>)@this->LpVtbl[6])(@this, ulReserved);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessShutdown(ShutdownType shutdownType)
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ISurrogateService*, ShutdownType, int>)@this->LpVtbl[7])(@this, shutdownType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init<TI0>(Guid* rguidProcessID, ComPtr<TI0> pProcessLock, int* pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Init(rguidProcessID, (IProcessLock*) pProcessLock.Handle, pfApplicationAware);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init<TI0>(Guid* rguidProcessID, ComPtr<TI0> pProcessLock, ref int pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Init(rguidProcessID, (IProcessLock*) pProcessLock.Handle, ref pfApplicationAware);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Init<TI0>(ref Guid rguidProcessID, ComPtr<TI0> pProcessLock, int* pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Init(ref rguidProcessID, (IProcessLock*) pProcessLock.Handle, pfApplicationAware);
        }

        /// <summary>To be documented.</summary>
        public readonly int Init<TI0>(ref Guid rguidProcessID, ComPtr<TI0> pProcessLock, ref int pfApplicationAware) where TI0 : unmanaged, IComVtbl<IProcessLock>, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Init(ref rguidProcessID, (IProcessLock*) pProcessLock.Handle, ref pfApplicationAware);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ISurrogateService*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
