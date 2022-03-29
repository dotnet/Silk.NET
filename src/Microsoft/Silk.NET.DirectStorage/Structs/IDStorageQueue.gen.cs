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
    [Guid("cfdbd83f-9e06-4fda-8ea5-69042137f49b")]
    [NativeName("Name", "IDStorageQueue")]
    public unsafe partial struct IDStorageQueue
    {
        public static readonly Guid Guid = new("cfdbd83f-9e06-4fda-8ea5-69042137f49b");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageQueue val)
            => Unsafe.As<IDStorageQueue, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageQueue
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
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueRequest([Flow(FlowDirection.In)] Request* request)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, request);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, request);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, request);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueRequest([Flow(FlowDirection.In)] in Request request)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Request* requestPtr = &request)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, requestPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, requestPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Request*, void>)LpVtbl[3])(@this, requestPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueStatus(IDStorageStatusArray* statusArray, uint index)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArray, index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArray, index);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArray, index);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueStatus(ref IDStorageStatusArray statusArray, uint index)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDStorageStatusArray* statusArrayPtr = &statusArray)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArrayPtr, index);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArrayPtr, index);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDStorageQueue*, IDStorageStatusArray*, uint, void>)LpVtbl[4])(@this, statusArrayPtr, index);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void EnqueueSignal(Silk.NET.Direct3D12.ID3D12Fence* fence, ulong value)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fence, value);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fence, value);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fence, value);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void EnqueueSignal(ref Silk.NET.Direct3D12.ID3D12Fence fence, ulong value)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Direct3D12.ID3D12Fence* fencePtr = &fence)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fencePtr, value);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fencePtr, value);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDStorageQueue*, Silk.NET.Direct3D12.ID3D12Fence*, ulong, void>)LpVtbl[5])(@this, fencePtr, value);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void Submit()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)LpVtbl[6])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly void CancelRequestsWithTag(ulong mask, ulong value)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, ulong, ulong, void>)LpVtbl[7])(@this, mask, value);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ulong, ulong, void>)LpVtbl[7])(@this, mask, value);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, ulong, ulong, void>)LpVtbl[7])(@this, mask, value);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Close()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void>)LpVtbl[8])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetErrorEvent()
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageQueue*, void*>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RetrieveErrorRecord(ErrorRecord* record)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, record);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, record);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, record);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void RetrieveErrorRecord(ref ErrorRecord record)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ErrorRecord* recordPtr = &record)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, recordPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, recordPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDStorageQueue*, ErrorRecord*, void>)LpVtbl[10])(@this, recordPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Query(QueueInfo* info)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, info);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, info);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, info);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void Query(ref QueueInfo info)
        {
            var @this = (IDStorageQueue*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (QueueInfo* infoPtr = &info)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, infoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, infoPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IDStorageQueue*, QueueInfo*, void>)LpVtbl[11])(@this, infoPtr);
                }
            #endif
            }
        }

    }
}
