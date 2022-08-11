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

namespace Silk.NET.Direct2D
{
    [Guid("fd0ecb6b-91e6-411e-8655-395e760f91b4")]
    [NativeName("Name", "ID2D1GdiMetafileSink1")]
    public unsafe partial struct ID2D1GdiMetafileSink1
    {
        public static readonly Guid Guid = new("fd0ecb6b-91e6-411e-8655-395e760f91b4");

        public static implicit operator ID2D1GdiMetafileSink(ID2D1GdiMetafileSink1 val)
            => Unsafe.As<ID2D1GdiMetafileSink1, ID2D1GdiMetafileSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1GdiMetafileSink1 val)
            => Unsafe.As<ID2D1GdiMetafileSink1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1GdiMetafileSink1
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
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessRecord(uint recordType, void* recordData, uint recordDataSize)
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void*, uint, int>)LpVtbl[3])(@this, recordType, recordData, recordDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessRecord<T0>(uint recordType, ref T0 recordData, uint recordDataSize) where T0 : unmanaged
        {
            var @this = (ID2D1GdiMetafileSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* recordDataPtr = &recordData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiMetafileSink1*, uint, void*, uint, int>)LpVtbl[3])(@this, recordType, recordDataPtr, recordDataSize);
            }
            return ret;
        }

    }
}
