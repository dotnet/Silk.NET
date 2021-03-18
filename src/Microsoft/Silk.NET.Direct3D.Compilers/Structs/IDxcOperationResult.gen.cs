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
    [Guid("cedb484a-d4e9-445a-b991-ca21ca157dc2")]
    [NativeName("Name", "IDxcOperationResult")]
    public unsafe partial struct IDxcOperationResult
    {
        public static readonly Guid Guid = new("cedb484a-d4e9-445a-b991-ca21ca157dc2");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOperationResult val)
            => Unsafe.As<IDxcOperationResult, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcOperationResult
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
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOperationResult*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStatus(int* pStatus)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, int*, int>)LpVtbl[3])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStatus(ref int pStatus)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, int*, int>)LpVtbl[3])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResult(IDxcBlob** pResult)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlob**, int>)LpVtbl[4])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResult(ref IDxcBlob* pResult)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlob**, int>)LpVtbl[4])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetErrorBuffer(IDxcBlobEncoding** pErrors)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pErrors);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetErrorBuffer(ref IDxcBlobEncoding* pErrors)
        {
            var @this = (IDxcOperationResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** pErrorsPtr = &pErrors)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOperationResult*, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, pErrorsPtr);
            }
            return ret;
        }

    }
}
