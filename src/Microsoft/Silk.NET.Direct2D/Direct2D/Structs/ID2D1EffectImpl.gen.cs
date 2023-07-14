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
    [Guid("a248fd3f-3e6c-4e63-9f03-7f68ecc91db9")]
    [NativeName("Name", "ID2D1EffectImpl")]
    public unsafe partial struct ID2D1EffectImpl : IComVtbl<ID2D1EffectImpl>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a248fd3f-3e6c-4e63-9f03-7f68ecc91db9");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1EffectImpl val)
            => Unsafe.As<ID2D1EffectImpl, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1EffectImpl
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
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContext, transformGraph);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ID2D1EffectContext* effectContext, ref ID2D1TransformGraph transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContext, transformGraphPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Initialize(ref ID2D1EffectContext effectContext, ID2D1TransformGraph* transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1EffectContext* effectContextPtr = &effectContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContextPtr, transformGraph);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize(ref ID2D1EffectContext effectContext, ref ID2D1TransformGraph transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1EffectContext* effectContextPtr = &effectContext)
            {
                fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)@this->LpVtbl[3])(@this, effectContextPtr, transformGraphPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int PrepareForRender(ChangeType changeType)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ChangeType, int>)@this->LpVtbl[4])(@this, changeType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetGraph(ID2D1TransformGraph* transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1TransformGraph*, int>)@this->LpVtbl[5])(@this, transformGraph);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGraph(ref ID2D1TransformGraph transformGraph)
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformGraph* transformGraphPtr = &transformGraph)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1EffectImpl*, ID2D1TransformGraph*, int>)@this->LpVtbl[5])(@this, transformGraphPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0, TI1>(ComPtr<TI0> effectContext, ComPtr<TI1> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1EffectContext>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI1>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((ID2D1EffectContext*) effectContext.Handle, (ID2D1TransformGraph*) transformGraph.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ComPtr<TI0> effectContext, ref ID2D1TransformGraph transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1EffectContext>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize((ID2D1EffectContext*) effectContext.Handle, ref transformGraph);
        }

        /// <summary>To be documented.</summary>
        public readonly int Initialize<TI0>(ref ID2D1EffectContext effectContext, ComPtr<TI0> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Initialize(ref effectContext, (ID2D1TransformGraph*) transformGraph.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGraph<TI0>(ComPtr<TI0> transformGraph) where TI0 : unmanaged, IComVtbl<ID2D1TransformGraph>, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetGraph((ID2D1TransformGraph*) transformGraph.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1EffectImpl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
