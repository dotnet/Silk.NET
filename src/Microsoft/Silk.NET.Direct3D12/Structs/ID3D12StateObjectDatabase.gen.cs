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
    [Guid("c56060b7-b5fc-4135-98e0-a1e9997eace0")]
    [NativeName("Name", "ID3D12StateObjectDatabase")]
    public unsafe partial struct ID3D12StateObjectDatabase : IComVtbl<ID3D12StateObjectDatabase>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c56060b7-b5fc-4135-98e0-a1e9997eace0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12StateObjectDatabase val)
            => Unsafe.As<ID3D12StateObjectDatabase, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12StateObjectDatabase
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
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetApplicationDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] ApplicationDesc* pApplicationDesc)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, ApplicationDesc*, int>)@this->LpVtbl[3])(@this, pApplicationDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetApplicationDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly ApplicationDesc pApplicationDesc)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ApplicationDesc* pApplicationDescPtr = &pApplicationDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, ApplicationDesc*, int>)@this->LpVtbl[3])(@this, pApplicationDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetApplicationDesc(PfnApplicationDescFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, PfnApplicationDescFunc, void*, int>)@this->LpVtbl[4])(@this, CallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetApplicationDesc<T0>(PfnApplicationDescFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, PfnApplicationDescFunc, void*, int>)@this->LpVtbl[4])(@this, CallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipelineStateDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKey, KeySize, Version, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipelineStateDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKey, KeySize, Version, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StorePipelineStateDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKeyPtr, KeySize, Version, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StorePipelineStateDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[5])(@this, pKeyPtr, KeySize, Version, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindPipelineStateDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKey, KeySize, CallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindPipelineStateDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKey, KeySize, CallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindPipelineStateDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, void* pContext) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKeyPtr, KeySize, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindPipelineStateDesc<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnPipelineStateFunc CallbackFunc, ref T1 pContext) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnPipelineStateFunc, void*, int>)@this->LpVtbl[6])(@this, pKeyPtr, KeySize, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDesc, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDescPtr, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKey, KeySize, Version, pDescPtr, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDesc, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDesc, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDescPtr, pStateObjectToGrowFromKey, StateObjectToGrowFromKeySize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StoreStateObjectDesc<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint Version, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T1 pStateObjectToGrowFromKey, uint StateObjectToGrowFromKeySize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    fixed (void* pStateObjectToGrowFromKeyPtr = &pStateObjectToGrowFromKey)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint, StateObjectDesc*, void*, uint, int>)@this->LpVtbl[7])(@this, pKeyPtr, KeySize, Version, pDescPtr, pStateObjectToGrowFromKeyPtr, StateObjectToGrowFromKeySize);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindStateObjectDesc([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, CallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKey, KeySize, CallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindStateObjectDesc<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, void* pContext) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindStateObjectDesc<T0, T1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, PfnStateObjectFunc CallbackFunc, ref T1 pContext) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, PfnStateObjectFunc, void*, int>)@this->LpVtbl[8])(@this, pKeyPtr, KeySize, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindObjectVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, uint* pVersion)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindObjectVersion([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pKey, uint KeySize, ref uint pVersion)
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pVersionPtr = &pVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKey, KeySize, pVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindObjectVersion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, uint* pVersion) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pVersion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindObjectVersion<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 pKey, uint KeySize, ref uint pVersion) where T0 : unmanaged
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pKeyPtr = &pKey)
            {
                fixed (uint* pVersionPtr = &pVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectDatabase*, void*, uint, uint*, int>)@this->LpVtbl[9])(@this, pKeyPtr, KeySize, pVersionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectDatabase*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
