// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Guid("e667af9f-cd56-4f46-83ce-032e595d70a8")]
    [NativeName("Name", "ID3D12LifetimeOwner")]
    public unsafe partial struct ID3D12LifetimeOwner
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12LifetimeOwner val)
            => Unsafe.As<ID3D12LifetimeOwner, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12LifetimeOwner
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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly void LifetimeStateUpdated(LifetimeState NewState)
        {
            var @this = (ID3D12LifetimeOwner*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3D12LifetimeOwner*, LifetimeState, void>)LpVtbl[3])(@this, NewState);
        }

    }
}
