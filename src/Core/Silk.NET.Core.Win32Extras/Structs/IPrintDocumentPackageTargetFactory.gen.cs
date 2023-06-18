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
    [Guid("d2959bf7-b31b-4a3d-9600-712eb1335ba4")]
    [NativeName("Name", "IPrintDocumentPackageTargetFactory")]
    public unsafe partial struct IPrintDocumentPackageTargetFactory : IComVtbl<IPrintDocumentPackageTargetFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d2959bf7-b31b-4a3d-9600-712eb1335ba4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPrintDocumentPackageTargetFactory val)
            => Unsafe.As<IPrintDocumentPackageTargetFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPrintDocumentPackageTargetFactory
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
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDocumentPackageTargetForPrintJob([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* printerName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* jobName, Silk.NET.Core.Win32Extras.IStream* jobOutputStream, Silk.NET.Core.Win32Extras.IStream* jobPrintTicketStream, IPrintDocumentPackageTarget** docPackageTarget)
        {
            var @this = (IPrintDocumentPackageTargetFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTargetFactory*, char*, char*, Silk.NET.Core.Win32Extras.IStream*, Silk.NET.Core.Win32Extras.IStream*, IPrintDocumentPackageTarget**, int>)@this->LpVtbl[3])(@this, printerName, jobName, jobOutputStream, jobPrintTicketStream, docPackageTarget);
            return ret;
        }

    }
}
