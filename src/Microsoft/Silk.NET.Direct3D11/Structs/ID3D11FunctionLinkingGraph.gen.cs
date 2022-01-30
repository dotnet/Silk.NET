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
    public unsafe partial struct ID3D11FunctionLinkingGraph
    {
        public static readonly Guid Guid = new("54133220-1ce8-43d3-8236-9855c5ceecff");

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateModuleInstance(ID3D11ModuleInstance** ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBuffer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateModuleInstance(ID3D11ModuleInstance** ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBufferPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBufferPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstance, ppErrorBufferPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateModuleInstance(ref ID3D11ModuleInstance* ppModuleInstance, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBuffer);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBuffer);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBuffer);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateModuleInstance(ref ID3D11ModuleInstance* ppModuleInstance, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance** ppModuleInstancePtr = &ppModuleInstance)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBufferPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBufferPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11ModuleInstance**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, ppModuleInstancePtr, ppErrorBufferPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInputSignature(ParameterDesc* pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInputSignature(ParameterDesc* pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode** ppInputNodePtr = &ppInputNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParameters, cInputParameters, ppInputNodePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInputSignature(ref ParameterDesc pInputParameters, uint cInputParameters, ID3D11LinkingNode** ppInputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ParameterDesc* pInputParametersPtr = &pInputParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetInputSignature(ref ParameterDesc pInputParameters, uint cInputParameters, ref ID3D11LinkingNode* ppInputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ParameterDesc* pInputParametersPtr = &pInputParameters)
            {
                fixed (ID3D11LinkingNode** ppInputNodePtr = &ppInputNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[4])(@this, pInputParametersPtr, cInputParameters, ppInputNodePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputSignature(ParameterDesc* pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputSignature(ParameterDesc* pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode** ppOutputNodePtr = &ppOutputNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParameters, cOutputParameters, ppOutputNodePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputSignature(ref ParameterDesc pOutputParameters, uint cOutputParameters, ID3D11LinkingNode** ppOutputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ParameterDesc* pOutputParametersPtr = &pOutputParameters)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputSignature(ref ParameterDesc pOutputParameters, uint cOutputParameters, ref ID3D11LinkingNode* ppOutputNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ParameterDesc* pOutputParametersPtr = &pOutputParameters)
            {
                fixed (ID3D11LinkingNode** ppOutputNodePtr = &ppOutputNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ParameterDesc*, uint, ID3D11LinkingNode**, int>)LpVtbl[5])(@this, pOutputParametersPtr, cOutputParameters, ppOutputNodePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFunctionNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(byte* pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespace, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
                    fixed (byte* pFunctionNamePtr = &pFunctionName)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
                    fixed (byte* pFunctionNamePtr = &pFunctionName)
                    {
                        fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction(ref byte pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pModuleInstanceNamespacePtr = &pModuleInstanceNamespace)
            {
                fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
                {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
            #endif
                    }
            SilkMarshal.Free((nint)pFunctionNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNode);
            }
            #endif
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionName, ppCallNodePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
                }
            #endif
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (byte* pFunctionNamePtr = &pFunctionName)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNode);
            }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ID3D11Module* pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototype, pFunctionNamePtr, ppCallNodePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pFunctionNamePtr);
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNode);
                }
            #endif
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, byte* pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionName, ppCallNodePtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, ref byte pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
                fixed (byte* pFunctionNamePtr = &pFunctionName)
                {
                    fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                        }
            #endif
                    }
                }
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ID3D11LinkingNode** ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNode);
                }
            #endif
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CallFunction([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pModuleInstanceNamespace, ref ID3D11Module pModuleWithFunctionPrototype, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFunctionName, ref ID3D11LinkingNode* ppCallNode)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pModuleInstanceNamespacePtr = (byte*) SilkMarshal.StringToPtr(pModuleInstanceNamespace, NativeStringEncoding.LPStr);
            fixed (ID3D11Module* pModuleWithFunctionPrototypePtr = &pModuleWithFunctionPrototype)
            {
            var pFunctionNamePtr = (byte*) SilkMarshal.StringToPtr(pFunctionName, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode** ppCallNodePtr = &ppCallNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, byte*, ID3D11Module*, byte*, ID3D11LinkingNode**, int>)LpVtbl[6])(@this, pModuleInstanceNamespacePtr, pModuleWithFunctionPrototypePtr, pFunctionNamePtr, ppCallNodePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)pFunctionNamePtr);
            }
            SilkMarshal.Free((nint)pModuleInstanceNamespacePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValue(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNode, DstParameterIndex);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValue(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNode, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValue(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ID3D11LinkingNode* pDstNode, int DstParameterIndex)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNode, DstParameterIndex);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNode, DstParameterIndex);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNode, DstParameterIndex);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PassValue(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref ID3D11LinkingNode pDstNode, int DstParameterIndex)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, ID3D11LinkingNode*, int, int>)LpVtbl[7])(@this, pSrcNodePtr, SrcParameterIndex, pDstNodePtr, DstParameterIndex);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
                    fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            }
            #endif
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                }
            #endif
            }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
                }
            }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ID3D11LinkingNode* pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
            {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNode, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzle);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
                    fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, byte* pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzle, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
                    fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
                    fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
                    fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                    {
                        fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                        {
            #if NET5_0_OR_GREATER
                            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                            if (SilkMarshal.IsWinapiStdcall)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                            }
                            else
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                            }
            #endif
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, ref byte pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
                fixed (byte* pSrcSwizzlePtr = &pSrcSwizzle)
                {
                    fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                    {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzle);
                }
            #endif
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
                fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
                }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ID3D11LinkingNode* pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNode, DstParameterIndex, pDstSwizzlePtr);
                }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, byte* pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzle);
                    }
            #endif
                }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, ref byte pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
                    fixed (byte* pDstSwizzlePtr = &pDstSwizzle)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                        }
            #endif
                    }
                }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PassValueWithSwizzle(ref ID3D11LinkingNode pSrcNode, int SrcParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrcSwizzle, ref ID3D11LinkingNode pDstNode, int DstParameterIndex, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pDstSwizzle)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11LinkingNode* pSrcNodePtr = &pSrcNode)
            {
            var pSrcSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pSrcSwizzle, NativeStringEncoding.LPStr);
                fixed (ID3D11LinkingNode* pDstNodePtr = &pDstNode)
                {
            var pDstSwizzlePtr = (byte*) SilkMarshal.StringToPtr(pDstSwizzle, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, ID3D11LinkingNode*, int, byte*, ID3D11LinkingNode*, int, byte*, int>)LpVtbl[8])(@this, pSrcNodePtr, SrcParameterIndex, pSrcSwizzlePtr, pDstNodePtr, DstParameterIndex, pDstSwizzlePtr);
                    }
            #endif
            SilkMarshal.Free((nint)pDstSwizzlePtr);
                }
            SilkMarshal.Free((nint)pSrcSwizzlePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastError(Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBuffer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBuffer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBuffer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastError(ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBufferPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBufferPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[9])(@this, ppErrorBufferPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateHlsl(uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBuffer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBuffer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBuffer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GenerateHlsl(uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppBuffer)
        {
            var @this = (ID3D11FunctionLinkingGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppBufferPtr = &ppBuffer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBufferPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBufferPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionLinkingGraph*, uint, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[10])(@this, uFlags, ppBufferPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
