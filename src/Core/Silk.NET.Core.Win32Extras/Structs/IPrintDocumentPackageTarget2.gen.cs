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
    [Guid("c560298a-535c-48f9-866a-632540660cb4")]
    [NativeName("Name", "IPrintDocumentPackageTarget2")]
    public unsafe partial struct IPrintDocumentPackageTarget2 : IComVtbl<IPrintDocumentPackageTarget2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c560298a-535c-48f9-866a-632540660cb4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IPrintDocumentPackageTarget2 val)
            => Unsafe.As<IPrintDocumentPackageTarget2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IPrintDocumentPackageTarget2
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
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetIsTargetIppPrinter(int* isIppPrinter)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, int*, int>)@this->LpVtbl[3])(@this, isIppPrinter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetIsTargetIppPrinter(ref int isIppPrinter)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* isIppPrinterPtr = &isIppPrinter)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, int*, int>)@this->LpVtbl[3])(@this, isIppPrinterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetIppPrintDevice(Guid* riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetIppPrintDevice(Guid* riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvTargetPtr = &ppvTarget)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetIppPrintDevice(ref Guid riid, void** ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetIppPrintDevice(ref Guid riid, ref void* ppvTarget)
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvTargetPtr = &ppvTarget)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IPrintDocumentPackageTarget2*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTargetIppPrintDevice<TI0>(out ComPtr<TI0> ppvTarget) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvTarget = default;
            return @this->GetTargetIppPrintDevice(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvTarget.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetTargetIppPrintDevice<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IPrintDocumentPackageTarget2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetTargetIppPrintDevice(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
