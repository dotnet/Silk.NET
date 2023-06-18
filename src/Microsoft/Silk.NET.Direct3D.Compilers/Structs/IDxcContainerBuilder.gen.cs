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
    [Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
    [NativeName("Name", "IDxcContainerBuilder")]
    public unsafe partial struct IDxcContainerBuilder : IComVtbl<IDxcContainerBuilder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("334b1f50-2292-4b35-99a1-25588d8c17fe");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerBuilder val)
            => Unsafe.As<IDxcContainerBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerBuilder
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
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pDxilContainerHeader)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pDxilContainerHeader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPart(uint fourCC, IDxcBlob* pSource)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)@this->LpVtbl[4])(@this, fourCC, pSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemovePart(uint fourCC)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int>)@this->LpVtbl[5])(@this, fourCC);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeContainer(IDxcOperationResult** ppResult)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)@this->LpVtbl[6])(@this, ppResult);
            return ret;
        }

    }
}
