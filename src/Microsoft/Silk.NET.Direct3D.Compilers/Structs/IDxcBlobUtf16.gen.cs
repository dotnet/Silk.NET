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
    [Guid("a3f84eab-0faa-497e-a39c-ee6ed60b2d84")]
    [NativeName("Name", "IDxcBlobUtf16")]
    public unsafe partial struct IDxcBlobUtf16
    {
        public static readonly Guid Guid = new("a3f84eab-0faa-497e-a39c-ee6ed60b2d84");

        public static implicit operator IDxcBlobEncoding(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, IDxcBlobEncoding>(ref val);

        public static implicit operator IDxcBlob(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, IDxcBlob>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlobUtf16 val)
            => Unsafe.As<IDxcBlobUtf16, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcBlobUtf16
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
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetBufferPointer()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, void*>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetBufferSize()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, ref uint pCodePage)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCodePagePtr = &pCodePage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(ref int pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pKnownPtr = &pKnown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncoding(ref int pKnown, ref uint pCodePage)
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pKnownPtr = &pKnown)
            {
                fixed (uint* pCodePagePtr = &pCodePage)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe char* GetStringPointer()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            char* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, char*>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)]
        public readonly string GetStringPointerS()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf16*, string>)LpVtbl[6])(@this);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, string>)LpVtbl[6])(@this);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf16*, string>)LpVtbl[6])(@this);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetStringLength()
        {
            var @this = (IDxcBlobUtf16*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf16*, nuint>)LpVtbl[7])(@this);
            return ret;
        }

    }
}
