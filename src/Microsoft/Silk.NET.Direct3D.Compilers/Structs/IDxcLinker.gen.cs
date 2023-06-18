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
    [Guid("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6")]
    [NativeName("Name", "IDxcLinker")]
    public unsafe partial struct IDxcLinker : IComVtbl<IDxcLinker>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f1b5be2a-62dd-4327-a1c2-42ac1e1e78e6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcLinker val)
            => Unsafe.As<IDxcLinker, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcLinker
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
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterLibrary([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pLibName, IDxcBlob* pLib)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Thiscall]<IDxcLinker*, char*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pLibName, pLib);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pLibNames, uint libCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcLinker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcLinker*, char*, char*, char**, uint, char**, uint, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pEntryName, pTargetProfile, pLibNames, libCount, pArguments, argCount, ppResult);
            return ret;
        }

    }
}
