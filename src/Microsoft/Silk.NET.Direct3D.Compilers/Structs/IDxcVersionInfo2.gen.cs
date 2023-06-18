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
    [Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83")]
    [NativeName("Name", "IDxcVersionInfo2")]
    public unsafe partial struct IDxcVersionInfo2 : IComVtbl<IDxcVersionInfo2>, IComVtbl<IDxcVersionInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fb6904c4-42f0-4b62-9c46-983af7da7c83");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcVersionInfo(IDxcVersionInfo2 val)
            => Unsafe.As<IDxcVersionInfo2, IDxcVersionInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcVersionInfo2 val)
            => Unsafe.As<IDxcVersionInfo2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcVersionInfo2
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
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint* pMajor, uint* pMinor)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, uint*, int>)@this->LpVtbl[3])(@this, pMajor, pMinor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlags(uint* pFlags)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, int>)@this->LpVtbl[4])(@this, pFlags);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommitInfo(uint* pCommitCount, byte** pCommitHash)
        {
            var @this = (IDxcVersionInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcVersionInfo2*, uint*, byte**, int>)@this->LpVtbl[5])(@this, pCommitCount, pCommitHash);
            return ret;
        }

    }
}
