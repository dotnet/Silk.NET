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

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "ID3DInclude")]
    public unsafe partial struct ID3DInclude : IComVtbl<ID3DInclude>
    {
        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public ID3DInclude
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
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppData, pBytesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] byte* pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileName, pParentData, ppDataPtr, pBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In)] in byte pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pFileNamePtr = &pFileName)
            {
                fixed (void** ppDataPtr = &ppData)
                {
                    fixed (uint* pBytesPtr = &pBytes)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytes);
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] void** ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (uint* pBytesPtr = &pBytes)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppData, pBytesPtr);
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, uint* pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void** ppDataPtr = &ppData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytes);
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Open(D3DIncludeType IncludeType, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pFileName, [Flow(FlowDirection.In)] void* pParentData, [Flow(FlowDirection.In)] in void* ppData, ref uint pBytes)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pFileNamePtr = (byte*) SilkMarshal.StringToPtr(pFileName, NativeStringEncoding.LPStr);
            fixed (void** ppDataPtr = &ppData)
            {
                fixed (uint* pBytesPtr = &pBytes)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, D3DIncludeType, byte*, void*, void**, uint*, int>)@this->LpVtbl[0])(@this, IncludeType, pFileNamePtr, pParentData, ppDataPtr, pBytesPtr);
                }
            }
            SilkMarshal.Free((nint)pFileNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Close([Flow(FlowDirection.In)] void* pData)
        {
            var @this = (ID3DInclude*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DInclude*, void*, int>)@this->LpVtbl[1])(@this, pData);
            return ret;
        }

    }
}
