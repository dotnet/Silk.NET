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
    [Guid("00000003-0000-0000-c000-000000000046")]
    [NativeName("Name", "IMarshal")]
    public unsafe partial struct IMarshal : IComVtbl<IMarshal>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("00000003-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMarshal val)
            => Unsafe.As<IMarshal, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMarshal
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
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetUnmarshalClass(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, Guid* pCid)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void*, uint, void*, uint, Guid*, int>)@this->LpVtbl[3])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMarshalSizeMax(Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags, uint* pSize)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Guid*, void*, uint, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void* pv, uint dwDestContext, void* pvDestContext, uint mshlflags)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void*, uint, void*, uint, int>)@this->LpVtbl[5])(@this, pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnmarshalInterface(Silk.NET.Core.Win32Extras.IStream* pStm, Guid* riid, void** ppv)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, Guid*, void**, int>)@this->LpVtbl[6])(@this, pStm, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReleaseMarshalData(Silk.NET.Core.Win32Extras.IStream* pStm)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, Silk.NET.Core.Win32Extras.IStream*, int>)@this->LpVtbl[7])(@this, pStm);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DisconnectObject(uint dwReserved)
        {
            var @this = (IMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IMarshal*, uint, int>)@this->LpVtbl[8])(@this, dwReserved);
            return ret;
        }

    }
}
