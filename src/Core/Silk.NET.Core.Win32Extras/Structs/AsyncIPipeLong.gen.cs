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
    [Guid("db2f3acd-2f86-11d1-8e04-00c04fb9989a")]
    [NativeName("Name", "AsyncIPipeLong")]
    public unsafe partial struct AsyncIPipeLong : IComVtbl<AsyncIPipeLong>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("db2f3acd-2f86-11d1-8e04-00c04fb9989a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIPipeLong val)
            => Unsafe.As<AsyncIPipeLong, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIPipeLong
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
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginPull(uint cRequest)
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull(int* buf, uint* pcReturned)
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginPush(int* buf, uint cSent)
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishPush()
        {
            var @this = (AsyncIPipeLong*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeLong*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

    }
}
