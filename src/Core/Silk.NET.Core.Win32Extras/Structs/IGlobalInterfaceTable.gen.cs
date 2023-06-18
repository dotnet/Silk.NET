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
    [Guid("00000146-0000-0000-c000-000000000046")]
    [NativeName("Name", "IGlobalInterfaceTable")]
    public unsafe partial struct IGlobalInterfaceTable : IComVtbl<IGlobalInterfaceTable>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000146-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IGlobalInterfaceTable val)
            => Unsafe.As<IGlobalInterfaceTable, Silk.NET.Core.Native.IUnknown>(ref val);

        public IGlobalInterfaceTable
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
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterInterfaceInGlobal(Silk.NET.Core.Native.IUnknown* pUnk, Guid* riid, uint* pdwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, Silk.NET.Core.Native.IUnknown*, Guid*, uint*, int>)@this->LpVtbl[3])(@this, pUnk, riid, pdwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RevokeInterfaceFromGlobal(uint dwCookie)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, int>)@this->LpVtbl[4])(@this, dwCookie);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInterfaceFromGlobal(uint dwCookie, Guid* riid, void** ppv)
        {
            var @this = (IGlobalInterfaceTable*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IGlobalInterfaceTable*, uint, Guid*, void**, int>)@this->LpVtbl[5])(@this, dwCookie, riid, ppv);
            return ret;
        }

    }
}
