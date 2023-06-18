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

namespace Silk.NET.Direct3D11
{
    [Guid("54133220-1ce8-43d3-8236-9855c5ceecff")]
    [NativeName("Name", "ID3D11FunctionLinkingGraph")]
    public unsafe partial struct ID3D11FunctionLinkingGraph : IComVtbl<ID3D11FunctionLinkingGraph>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("54133220-1ce8-43d3-8236-9855c5ceecff");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11FunctionLinkingGraph val)
            => Unsafe.As<ID3D11FunctionLinkingGraph, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11FunctionLinkingGraph
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
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateModuleInstance(ID3D11ModuleInstance** ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInputSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] ParameterDesc* pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)@this->LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)@this->LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValue(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)@this->LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)@this->LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastError(Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[9])(@this, ppErrorBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateHlsl(uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[10])(@this, uFlags, ppBuffer);
            return ret;
        }

    }
}
