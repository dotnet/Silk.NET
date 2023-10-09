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

namespace Silk.NET.Core.Native
{
    [Guid("af86e2e0-b12d-4c6a-9c5a-d7aa65101e90")]
    [NativeName("Name", "IInspectable")]
    public unsafe partial struct IInspectable : IComVtbl<IInspectable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("af86e2e0-b12d-4c6a-9c5a-d7aa65101e90");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IInspectable val)
            => Unsafe.As<IInspectable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IInspectable
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
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IInspectable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIids(uint* iidCount, Guid** iids)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCount, iids);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIids(uint* iidCount, ref Guid* iids)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid** iidsPtr = &iids)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCount, iidsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIids(ref uint iidCount, Guid** iids)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* iidCountPtr = &iidCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCountPtr, iids);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIids(ref uint iidCount, ref Guid* iids)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* iidCountPtr = &iidCount)
            {
                fixed (Guid** iidsPtr = &iids)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IInspectable*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, iidCountPtr, iidsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetRuntimeClassName(WinString* className)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, WinString*, int>)@this->LpVtbl[4])(@this, className);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetRuntimeClassName(ref WinString className)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (WinString* classNamePtr = &className)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, WinString*, int>)@this->LpVtbl[4])(@this, classNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTrustLevel(TrustLevel* trustLevel)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IInspectable*, TrustLevel*, int>)@this->LpVtbl[5])(@this, trustLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTrustLevel(ref TrustLevel trustLevel)
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TrustLevel* trustLevelPtr = &trustLevel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IInspectable*, TrustLevel*, int>)@this->LpVtbl[5])(@this, trustLevelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IInspectable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
