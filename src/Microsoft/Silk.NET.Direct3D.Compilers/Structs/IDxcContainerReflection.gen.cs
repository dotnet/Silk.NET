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

namespace Silk.NET.Direct3D.Compilers
{
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
    [NativeName("Name", "IDxcContainerReflection")]
    public unsafe partial struct IDxcContainerReflection : IComVtbl<IDxcContainerReflection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d2c21b26-8350-4bdc-976a-331ce6f4c54c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerReflection val)
            => Unsafe.As<IDxcContainerReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerReflection
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
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pContainer)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pContainer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartCount(uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)@this->LpVtbl[4])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartKind(uint idx, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[5])(@this, idx, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartContent(uint idx, IDxcBlob** ppResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)@this->LpVtbl[6])(@this, idx, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFirstPartKind(uint kind, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)@this->LpVtbl[7])(@this, kind, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, Guid* iid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)@this->LpVtbl[8])(@this, idx, iid, ppvObject);
            return ret;
        }

    }
}
