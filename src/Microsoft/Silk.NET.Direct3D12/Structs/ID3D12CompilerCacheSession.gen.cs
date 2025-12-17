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
    [Guid("5704e5e6-054b-4738-b661-7b0d68d8dde2")]
    [NativeName("Name", "ID3D12CompilerCacheSession")]
    public unsafe partial struct ID3D12CompilerCacheSession : IComVtbl<ID3D12CompilerCacheSession>, IComVtbl<ID3D12CompilerFactoryChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5704e5e6-054b-4738-b661-7b0d68d8dde2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12CompilerFactoryChild(ID3D12CompilerCacheSession val)
            => Unsafe.As<ID3D12CompilerCacheSession, ID3D12CompilerFactoryChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12CompilerCacheSession val)
            => Unsafe.As<ID3D12CompilerCacheSession, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12CompilerCacheSession
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
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint* pGroupVersion)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKey, pGroupVersion);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, ref uint pGroupVersion)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pGroupVersionPtr = &pGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKey, pGroupVersionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint* pGroupVersion)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, pGroupVersion);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindGroup([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, ref uint pGroupVersion)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (uint* pGroupVersionPtr = &pGroupVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, pGroupVersionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersion, CallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersion, CallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersionPtr, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKey, pExpectedGroupVersionPtr, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersion, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersion, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, CallbackFunc, pContext);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindGroupValueKeys<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, PfnCompilerCacheSessionGroupValueKeysFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
                {
                    fixed (void* pContextPtr = &pContext)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, PfnCompilerCacheSessionGroupValueKeysFunc, void*, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, CallbackFunc, pContextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKey, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersion, ValueTypeFlags, CallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindGroupValues([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContext);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindGroupValues<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly uint pExpectedGroupVersion, CompilerValueTypeFlags ValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc CallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (uint* pExpectedGroupVersionPtr = &pExpectedGroupVersion)
                {
                    fixed (void* pContextPtr = &pContext)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint*, CompilerValueTypeFlags, PfnCompilerCacheSessionGroupValuesFunc, void*, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, pExpectedGroupVersionPtr, ValueTypeFlags, CallbackFunc, pContextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pContextPtr = &pContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValues, NumTypedValues, pCallbackFunc, pContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKey, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValues, NumTypedValues, pCallbackFunc, pContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, CompilerCacheTypedValue* pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                fixed (void* pContextPtr = &pContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValues, NumTypedValues, pCallbackFunc, pContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, void* pContext)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContext);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindValue<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, ref CompilerCacheTypedValue pTypedValues, uint NumTypedValues, PfnCompilerCacheSessionAllocationFunc pCallbackFunc, ref T0 pContext) where T0 : unmanaged
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                fixed (CompilerCacheTypedValue* pTypedValuesPtr = &pTypedValues)
                {
                    fixed (void* pContextPtr = &pContext)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedValue*, uint, PfnCompilerCacheSessionAllocationFunc, void*, int>)@this->LpVtbl[7])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues, pCallbackFunc, pContextPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ApplicationDesc* GetApplicationDesc()
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ApplicationDesc* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, ApplicationDesc*>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CompilerTarget GetCompilerTarget()
        {
            CompilerTarget silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CompilerTarget* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerTarget*, CompilerTarget*>)@this->LpVtbl[9])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly CompilerValueTypeFlags GetValueTypes()
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            CompilerValueTypeFlags ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerValueTypeFlags>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKeys, uint NumValueKeys)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKey, GroupVersion, pValueKeys, NumValueKeys);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKeys, uint NumValueKeys)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeysPtr = &pValueKeys)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKey, GroupVersion, pValueKeysPtr, NumValueKeys);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKeys, uint NumValueKeys)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKeyPtr, GroupVersion, pValueKeys, NumValueKeys);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StoreGroupValueKeys([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKeys, uint NumValueKeys)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (CompilerCacheValueKey* pValueKeysPtr = &pValueKeys)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheGroupKey*, uint, CompilerCacheValueKey*, uint, int>)@this->LpVtbl[11])(@this, pGroupKeyPtr, GroupVersion, pValueKeysPtr, NumValueKeys);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheTypedConstValue* pTypedValues, uint NumTypedValues)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKey, pTypedValues, NumTypedValues);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheValueKey* pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheTypedConstValue pTypedValues, uint NumTypedValues)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheTypedConstValue* pTypedValuesPtr = &pTypedValues)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKey, pTypedValuesPtr, NumTypedValues);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StoreValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheTypedConstValue* pTypedValues, uint NumTypedValues)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKeyPtr, pTypedValues, NumTypedValues);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StoreValue([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheValueKey pValueKey, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheTypedConstValue pTypedValues, uint NumTypedValues)
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheValueKey* pValueKeyPtr = &pValueKey)
            {
                fixed (CompilerCacheTypedConstValue* pTypedValuesPtr = &pTypedValues)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12CompilerCacheSession*, CompilerCacheValueKey*, CompilerCacheTypedConstValue*, uint, int>)@this->LpVtbl[12])(@this, pValueKeyPtr, pTypedValuesPtr, NumTypedValues);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFactory<TI0>(out ComPtr<TI0> ppCompilerFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerFactory = default;
            return @this->GetFactory(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetFactory<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12CompilerCacheSession*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetFactory(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
