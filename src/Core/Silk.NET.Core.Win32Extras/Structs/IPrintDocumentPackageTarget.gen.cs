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
        public readonly unsafe int GetPackageTarget(Guid* guidTargetType, Guid* riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget*, Guid*, Guid*, void**, int>)@this->LpVtbl[4])(@this, guidTargetType, riid, ppvTarget);
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

    }
}
