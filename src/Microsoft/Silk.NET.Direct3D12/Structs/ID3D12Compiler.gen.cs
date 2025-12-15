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
    [Guid("8c403c12-993b-4583-80f1-6824138fa68e")]
    [NativeName("Name", "ID3D12Compiler")]
    public unsafe partial struct ID3D12Compiler : IComVtbl<ID3D12Compiler>, IComVtbl<ID3D12CompilerFactoryChild>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("8c403c12-993b-4583-80f1-6824138fa68e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12CompilerFactoryChild(ID3D12Compiler val)
            => Unsafe.As<ID3D12Compiler, ID3D12CompilerFactoryChild>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12Compiler val)
            => Unsafe.As<ID3D12Compiler, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12Compiler
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
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactory);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(Guid* riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riid, ppCompilerFactoryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, void** ppCompilerFactory)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactory);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFactory(ref Guid riid, ref void* ppCompilerFactory)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerFactoryPtr = &ppCompilerFactory)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[3])(@this, riidPtr, ppCompilerFactoryPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompilePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[4])(@this, pGroupKey, GroupVersion, pDesc);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompilePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[4])(@this, pGroupKey, GroupVersion, pDescPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompilePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PipelineStateStreamDesc* pDesc)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, GroupVersion, pDesc);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompilePipelineState([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly PipelineStateStreamDesc pDesc)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (PipelineStateStreamDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, PipelineStateStreamDesc*, int>)@this->LpVtbl[4])(@this, pGroupKeyPtr, GroupVersion, pDescPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDesc, riid, ppCompilerStateObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDesc, riid, ppCompilerStateObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDesc, riidPtr, ppCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDesc, riidPtr, ppCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, Guid* riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDescPtr, riid, ppCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, Guid* riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDescPtr, riid, ppCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, ref Guid riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDescPtr, riidPtr, ppCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, ref Guid riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pDescPtr = &pDesc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKey, GroupVersion, pDescPtr, riidPtr, ppCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDesc, riid, ppCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, Guid* riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDesc, riid, ppCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDesc, riidPtr, ppCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, ref Guid riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDesc, riidPtr, ppCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, Guid* riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDescPtr, riid, ppCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, Guid* riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDescPtr, riid, ppCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, ref Guid riid, void** ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDescPtr, riidPtr, ppCompilerStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, ref Guid riid, ref void* ppCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pDescPtr = &pDesc)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppCompilerStateObjectPtr = &ppCompilerStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, Guid*, void**, int>)@this->LpVtbl[5])(@this, pGroupKeyPtr, GroupVersion, pDescPtr, riidPtr, ppCompilerStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
            {
                fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (StateObjectDesc* pAdditionPtr = &pAddition)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKey, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAddition, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObject);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riid, ppNewCompilerStateObjectPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ID3D12CompilerStateObject* pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (Guid* riidPtr = &riid)
                    {
                        fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFrom, riidPtr, ppNewCompilerStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObject);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                    {
                        fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riid, ppNewCompilerStateObjectPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObject);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (CompilerCacheGroupKey* pGroupKeyPtr = &pGroupKey)
            {
                fixed (StateObjectDesc* pAdditionPtr = &pAddition)
                {
                    fixed (ID3D12CompilerStateObject* pCompilerStateObjectToGrowFromPtr = &pCompilerStateObjectToGrowFrom)
                    {
                        fixed (Guid* riidPtr = &riid)
                        {
                            fixed (void** ppNewCompilerStateObjectPtr = &ppNewCompilerStateObject)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, CompilerCacheGroupKey*, uint, StateObjectDesc*, ID3D12CompilerStateObject*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pGroupKeyPtr, GroupVersion, pAdditionPtr, pCompilerStateObjectToGrowFromPtr, riidPtr, ppNewCompilerStateObjectPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCacheSession(Guid* riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppCompilerCacheSession);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCacheSession(Guid* riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riid, ppCompilerCacheSessionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCacheSession(ref Guid riid, void** ppCompilerCacheSession)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppCompilerCacheSession);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCacheSession(ref Guid riid, ref void* ppCompilerCacheSession)
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppCompilerCacheSessionPtr = &ppCompilerCacheSession)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12Compiler*, Guid*, void**, int>)@this->LpVtbl[7])(@this, riidPtr, ppCompilerCacheSessionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFactory<TI0>(out ComPtr<TI0> ppCompilerFactory) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerFactory = default;
            return @this->GetFactory(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerFactory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, out ComPtr<TI0> ppCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerStateObject = default;
            return @this->CompileStateObject(pGroupKey, GroupVersion, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, out ComPtr<TI0> ppCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerStateObject = default;
            return @this->CompileStateObject(pGroupKey, GroupVersion, in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc, out ComPtr<TI0> ppCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerStateObject = default;
            return @this->CompileStateObject(in pGroupKey, GroupVersion, pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc, out ComPtr<TI0> ppCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerStateObject = default;
            return @this->CompileStateObject(in pGroupKey, GroupVersion, in pDesc, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, out ComPtr<TI1> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, out ComPtr<TI0> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, ref pCompilerStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, out ComPtr<TI1> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, out ComPtr<TI0> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, ref pCompilerStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, out ComPtr<TI1> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, out ComPtr<TI0> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, ref pCompilerStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, out ComPtr<TI1> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, SilkMarshal.GuidPtrOf<TI1>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, Guid* riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, void** ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom, ref Guid riid, ref void* ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, (ID3D12CompilerStateObject*) pCompilerStateObjectToGrowFrom.Handle, ref riid, ref ppNewCompilerStateObject);
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom, out ComPtr<TI0> ppNewCompilerStateObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppNewCompilerStateObject = default;
            return @this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, ref pCompilerStateObjectToGrowFrom, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppNewCompilerStateObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCacheSession<TI0>(out ComPtr<TI0> ppCompilerCacheSession) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppCompilerCacheSession = default;
            return @this->GetCacheSession(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppCompilerCacheSession.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetFactory<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetFactory(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileStateObject(pGroupKey, GroupVersion, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileStateObject(pGroupKey, GroupVersion, in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileStateObject(in pGroupKey, GroupVersion, pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CompileStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pDesc) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileStateObject(in pGroupKey, GroupVersion, in pDesc, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(pGroupKey, GroupVersion, pAddition, ref pCompilerStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, pCompilerStateObjectToGrowFrom, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] CompilerCacheGroupKey* pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(pGroupKey, GroupVersion, in pAddition, ref pCompilerStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI1> CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, pCompilerStateObjectToGrowFrom, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StateObjectDesc* pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(in pGroupKey, GroupVersion, pAddition, ref pCompilerStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CompileAddToStateObject<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ComPtr<TI0> pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<ID3D12CompilerStateObject>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<TI1>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, pCompilerStateObjectToGrowFrom, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CompileAddToStateObject<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly CompilerCacheGroupKey pGroupKey, uint GroupVersion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly StateObjectDesc pAddition, ref ID3D12CompilerStateObject pCompilerStateObjectToGrowFrom) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CompileAddToStateObject(in pGroupKey, GroupVersion, in pAddition, ref pCompilerStateObjectToGrowFrom, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetCacheSession<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12Compiler*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCacheSession(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
