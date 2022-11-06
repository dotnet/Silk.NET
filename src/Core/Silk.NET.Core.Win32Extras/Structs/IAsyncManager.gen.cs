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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("0000002a-0000-0000-c000-000000000046")]
    [NativeName("Name", "IAsyncManager")]
    public unsafe partial struct IAsyncManager : IComVtbl<IAsyncManager>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000002a-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IAsyncManager val)
            => Unsafe.As<IAsyncManager, Silk.NET.Core.Native.IUnknown>(ref val);

        public IAsyncManager
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
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int CompleteCall(int Result)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, int, int>)@this->LpVtbl[3])(@this, Result);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(Guid* riid, void** pInterface)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, pInterface);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(Guid* riid, ref void* pInterface)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** pInterfacePtr = &pInterface)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, pInterfacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(ref Guid riid, void** pInterface)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, pInterface);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCallContext(ref Guid riid, ref void* pInterface)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** pInterfacePtr = &pInterface)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, pInterfacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetState(uint* pulStateFlags)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint*, int>)@this->LpVtbl[5])(@this, pulStateFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetState(ref uint pulStateFlags)
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pulStateFlagsPtr = &pulStateFlags)
            {
                ret = ((delegate* unmanaged[Cdecl]<IAsyncManager*, uint*, int>)@this->LpVtbl[5])(@this, pulStateFlagsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCallContext<TI0>(out ComPtr<TI0> pInterface) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            pInterface = default;
            return @this->GetCallContext(SilkMarshal.GuidPtrOf<TI0>(), (void**) pInterface.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetCallContext<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IAsyncManager*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetCallContext(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
