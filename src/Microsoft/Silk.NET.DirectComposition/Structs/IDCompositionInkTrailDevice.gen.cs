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

namespace Silk.NET.DirectComposition
{
    [Guid("df0c7cec-cdeb-4d4a-b91c-721bf22f4e6c")]
    [NativeName("Name", "IDCompositionInkTrailDevice")]
    public unsafe partial struct IDCompositionInkTrailDevice : IComVtbl<IDCompositionInkTrailDevice>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("df0c7cec-cdeb-4d4a-b91c-721bf22f4e6c");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionInkTrailDevice val)
            => Unsafe.As<IDCompositionInkTrailDevice, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionInkTrailDevice
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
            var @this = (IDCompositionInkTrailDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionInkTrailDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionInkTrailDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail** inkTrail)
        {
            var @this = (IDCompositionInkTrailDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[3])(@this, inkTrail);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDelegatedInkTrailForSwapChain(Silk.NET.Core.Native.IUnknown* swapChain, IDCompositionDelegatedInkTrail** inkTrail)
        {
            var @this = (IDCompositionInkTrailDevice*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionInkTrailDevice*, Silk.NET.Core.Native.IUnknown*, IDCompositionDelegatedInkTrail**, int>)@this->LpVtbl[4])(@this, swapChain, inkTrail);
            return ret;
        }

    }
}
