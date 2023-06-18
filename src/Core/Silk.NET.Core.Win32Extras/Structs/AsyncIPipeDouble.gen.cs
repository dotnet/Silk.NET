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
    [Guid("db2f3acf-2f86-11d1-8e04-00c04fb9989a")]
    [NativeName("Name", "AsyncIPipeDouble")]
    public unsafe partial struct AsyncIPipeDouble : IComVtbl<AsyncIPipeDouble>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("db2f3acf-2f86-11d1-8e04-00c04fb9989a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(AsyncIPipeDouble val)
            => Unsafe.As<AsyncIPipeDouble, Silk.NET.Core.Native.IUnknown>(ref val);

        public AsyncIPipeDouble
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
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginPull(uint cRequest)
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, uint, int>)@this->LpVtbl[3])(@this, cRequest);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FinishPull(double* buf, uint* pcReturned)
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, double*, uint*, int>)@this->LpVtbl[4])(@this, buf, pcReturned);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginPush(double* buf, uint cSent)
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, double*, uint, int>)@this->LpVtbl[5])(@this, buf, cSent);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FinishPush()
        {
            var @this = (AsyncIPipeDouble*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<AsyncIPipeDouble*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

    }
}
