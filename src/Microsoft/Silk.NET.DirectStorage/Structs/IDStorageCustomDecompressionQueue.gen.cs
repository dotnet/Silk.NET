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

namespace Silk.NET.DirectStorage
{
    [Guid("97179b2f-2c21-49ca-8291-4e1bf4a160df")]
    [NativeName("Name", "IDStorageCustomDecompressionQueue")]
    public unsafe partial struct IDStorageCustomDecompressionQueue
    {
        public static readonly Guid Guid = new("97179b2f-2c21-49ca-8291-4e1bf4a160df");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageCustomDecompressionQueue val)
            => Unsafe.As<IDStorageCustomDecompressionQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageCustomDecompressionQueue
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
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetEvent()
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, void*>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequests(uint maxRequests, CustomDecompressionRequest* requests, uint* numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequests);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequests);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequests);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequests(uint maxRequests, CustomDecompressionRequest* requests, ref uint numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* numRequestsPtr = &numRequests)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequestsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequestsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requests, numRequestsPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRequests(uint maxRequests, ref CustomDecompressionRequest requests, uint* numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomDecompressionRequest* requestsPtr = &requests)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequests);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequests);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequests);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRequests(uint maxRequests, ref CustomDecompressionRequest requests, ref uint numRequests)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomDecompressionRequest* requestsPtr = &requests)
            {
                fixed (uint* numRequestsPtr = &numRequests)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequestsPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequestsPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionRequest*, uint*, int>)LpVtbl[4])(@this, maxRequests, requestsPtr, numRequestsPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRequestResults(uint numResults, CustomDecompressionResult* results)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, results);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, results);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, results);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetRequestResults(uint numResults, ref CustomDecompressionResult results)
        {
            var @this = (IDStorageCustomDecompressionQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CustomDecompressionResult* resultsPtr = &results)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, resultsPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, resultsPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageCustomDecompressionQueue*, uint, CustomDecompressionResult*, int>)LpVtbl[5])(@this, numResults, resultsPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
