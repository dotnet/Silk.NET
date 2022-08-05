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

namespace Silk.NET.Direct2D
{
    [Guid("13d29038-c3e6-4034-9081-13b53a417992")]
    [NativeName("Name", "ID2D1TransformGraph")]
    public unsafe partial struct ID2D1TransformGraph
    {
        public static readonly Guid Guid = new("13d29038-c3e6-4034-9081-13b53a417992");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1TransformGraph val)
            => Unsafe.As<ID2D1TransformGraph, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1TransformGraph
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
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSingleTransformNode(ID2D1TransformNode* node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[4])(@this, node);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSingleTransformNode(ref ID2D1TransformNode node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* nodePtr = &node)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[4])(@this, nodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddNode(ID2D1TransformNode* node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[5])(@this, node);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddNode(ref ID2D1TransformNode node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* nodePtr = &node)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[5])(@this, nodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RemoveNode(ID2D1TransformNode* node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[6])(@this, node);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveNode(ref ID2D1TransformNode node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* nodePtr = &node)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[6])(@this, nodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetOutputNode(ID2D1TransformNode* node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[7])(@this, node);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputNode(ref ID2D1TransformNode node)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* nodePtr = &node)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, int>)LpVtbl[7])(@this, nodePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConnectNode(ID2D1TransformNode* fromNode, ID2D1TransformNode* toNode, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)LpVtbl[8])(@this, fromNode, toNode, toNodeInputIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConnectNode(ID2D1TransformNode* fromNode, ref ID2D1TransformNode toNode, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* toNodePtr = &toNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)LpVtbl[8])(@this, fromNode, toNodePtr, toNodeInputIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConnectNode(ref ID2D1TransformNode fromNode, ID2D1TransformNode* toNode, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* fromNodePtr = &fromNode)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)LpVtbl[8])(@this, fromNodePtr, toNode, toNodeInputIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConnectNode(ref ID2D1TransformNode fromNode, ref ID2D1TransformNode toNode, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* fromNodePtr = &fromNode)
            {
                fixed (ID2D1TransformNode* toNodePtr = &toNode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, ID2D1TransformNode*, ID2D1TransformNode*, uint, int>)LpVtbl[8])(@this, fromNodePtr, toNodePtr, toNodeInputIndex);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ConnectToEffectInput(uint toEffectInputIndex, ID2D1TransformNode* node, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)LpVtbl[9])(@this, toEffectInputIndex, node, toNodeInputIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ConnectToEffectInput(uint toEffectInputIndex, ref ID2D1TransformNode node, uint toNodeInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformNode* nodePtr = &node)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, ID2D1TransformNode*, uint, int>)LpVtbl[9])(@this, toEffectInputIndex, nodePtr, toNodeInputIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void Clear()
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, void>)LpVtbl[10])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPassthroughGraph(uint effectInputIndex)
        {
            var @this = (ID2D1TransformGraph*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1TransformGraph*, uint, int>)LpVtbl[11])(@this, effectInputIndex);
            return ret;
        }

    }
}
