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

namespace Silk.NET.DirectWrite
{
    [Guid("eaf3a2da-ecf4-4d24-b644-b34f6842024b")]
    [NativeName("Name", "IDWritePixelSnapping")]
    public unsafe partial struct IDWritePixelSnapping : IComVtbl<IDWritePixelSnapping>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("eaf3a2da-ecf4-4d24-b644-b34f6842024b");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWritePixelSnapping val)
            => Unsafe.As<IDWritePixelSnapping, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWritePixelSnapping
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
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsPixelSnappingDisabled(void* clientDrawingContext, int* isDisabled)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCurrentTransform(void* clientDrawingContext, Matrix* transform)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelsPerDip(void* clientDrawingContext, float* pixelsPerDip)
        {
            var @this = (IDWritePixelSnapping*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
            return ret;
        }

    }
}
