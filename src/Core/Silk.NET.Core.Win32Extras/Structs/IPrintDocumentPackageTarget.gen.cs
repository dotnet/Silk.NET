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
    [Guid("1b8efec4-3019-4c27-964e-367202156906")]
    [NativeName("Name", "IPrintDocumentPackageTarget")]
    public unsafe partial struct IPrintDocumentPackageTarget : IComVtbl<IPrintDocumentPackageTarget>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("1b8efec4-3019-4c27-964e-367202156906");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPrintDocumentPackageTarget val)
            => Unsafe.As<IPrintDocumentPackageTarget, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPrintDocumentPackageTarget
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
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTargetTypes(uint* targetCount, Guid** targetTypes)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCount, targetTypes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTargetTypes(uint* targetCount, ref Guid* targetTypes)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid** targetTypesPtr = &targetTypes)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCount, targetTypesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTargetTypes(ref uint targetCount, Guid** targetTypes)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* targetCountPtr = &targetCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCountPtr, targetTypes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTargetTypes(ref uint targetCount, ref Guid* targetTypes)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* targetCountPtr = &targetCount)
            {
                fixed (Guid** targetTypesPtr = &targetTypes)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, uint*, Guid**, int>)@this->LpVtbl[3])(@this, targetCountPtr, targetTypesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(Guid* guidTargetType, Guid* riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riid, ppvTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(Guid* guidTargetType, Guid* riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvTargetPtr = &ppvTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riid, ppvTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(Guid* guidTargetType, ref Guid riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riidPtr, ppvTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(Guid* guidTargetType, ref Guid riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTargetPtr = &ppvTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riidPtr, ppvTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(ref Guid guidTargetType, Guid* riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidTargetTypePtr = &guidTargetType)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riid, ppvTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(ref Guid guidTargetType, Guid* riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidTargetTypePtr = &guidTargetType)
            {
                fixed (void** ppvTargetPtr = &ppvTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riid, ppvTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(ref Guid guidTargetType, ref Guid riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidTargetTypePtr = &guidTargetType)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riidPtr, ppvTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget(ref Guid guidTargetType, ref Guid riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidTargetTypePtr = &guidTargetType)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvTargetPtr = &ppvTarget)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetTypePtr, riidPtr, ppvTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Cancel()
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPackageTarget<TI0>(Guid* guidTargetType, out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvTarget = default;
            return @this->GetPackageTarget(guidTargetType, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPackageTarget<TI0>(ref Guid guidTargetType, out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvTarget = default;
            return @this->GetPackageTarget(ref guidTargetType, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetPackageTarget<TI0>(Guid* guidTargetType) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetPackageTarget(guidTargetType, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetPackageTarget<TI0>(ref Guid guidTargetType) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetPackageTarget(ref guidTargetType, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
