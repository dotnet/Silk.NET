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
    [Guid("eb0cb9e8-7996-11d2-872e-0000f8080859")]
    [NativeName("Name", "IReleaseMarshalBuffers")]
    public unsafe partial struct IReleaseMarshalBuffers : IComVtbl<IReleaseMarshalBuffers>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("eb0cb9e8-7996-11d2-872e-0000f8080859");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IReleaseMarshalBuffers val)
            => Unsafe.As<IReleaseMarshalBuffers, Silk.NET.Core.Native.IUnknown>(ref val);

        public IReleaseMarshalBuffers
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
            var @this = (IReleaseMarshalBuffers*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IReleaseMarshalBuffers*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IReleaseMarshalBuffers*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseMarshalBuffer(RPCOLEMessage* pMsg, uint dwFlags, Silk.NET.Core.Native.IUnknown* pChnl)
        {
            var @this = (IReleaseMarshalBuffers*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IReleaseMarshalBuffers*, RPCOLEMessage*, uint, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pMsg, dwFlags, pChnl);
            return ret;
        }

    }
}
