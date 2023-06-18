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
    [Guid("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af")]
    [NativeName("Name", "IPrintDocumentPackageStatusEvent")]
    public unsafe partial struct IPrintDocumentPackageStatusEvent : IComVtbl<IPrintDocumentPackageStatusEvent>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("ed90c8ad-5c34-4d05-a1ec-0e8a9b3ad7af");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPrintDocumentPackageStatusEvent val)
            => Unsafe.As<IPrintDocumentPackageStatusEvent, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPrintDocumentPackageStatusEvent
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
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfoCount(uint* pctinfo)
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint*, int>)@this->LpVtbl[3])(@this, pctinfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTypeInfo(uint iTInfo, uint lcid, Silk.NET.Core.Native.IUnknown** ppTInfo)
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, uint, uint, Silk.NET.Core.Native.IUnknown**, int>)@this->LpVtbl[4])(@this, iTInfo, lcid, ppTInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIDsOfNames(Guid* riid, char** rgszNames, uint cNames, uint lcid, int* rgDispId)
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, Guid*, char**, uint, uint, int*, int>)@this->LpVtbl[5])(@this, riid, rgszNames, cNames, lcid, rgDispId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Invoke(int dispIdMember, Guid* riid, uint lcid, ushort wFlags, DispatchParams* pDispParams, Variant* pVarResult, ExceptionInfo* pExcepInfo, uint* puArgErr)
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, int, Guid*, uint, ushort, DispatchParams*, Variant*, ExceptionInfo*, uint*, int>)@this->LpVtbl[6])(@this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int PackageStatusUpdated(MIDLMIDLItfDocumenttarget000000020001* packageStatus)
        {
            var @this = (IPrintDocumentPackageStatusEvent*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageStatusEvent*, MIDLMIDLItfDocumenttarget000000020001*, int>)@this->LpVtbl[7])(@this, packageStatus);
            return ret;
        }

    }
}
