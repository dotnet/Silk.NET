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
    [Guid("3da636c9-ba71-4024-a301-30cbf125305b")]
    [NativeName("Name", "IDxcBlobUtf8")]
    public unsafe partial struct IDxcBlobUtf8
    {
        public static readonly Guid Guid = new("3da636c9-ba71-4024-a301-30cbf125305b");

        public static implicit operator IDxcBlobEncoding(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, IDxcBlobEncoding>(ref val);

        public static implicit operator IDxcBlob(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, IDxcBlob>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcBlobUtf8 val)
            => Unsafe.As<IDxcBlobUtf8, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcBlobUtf8
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
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetBufferPointer()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, void*>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetBufferSize()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, nuint>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePage);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(int* pKnown, ref uint pCodePage)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCodePagePtr = &pCodePage)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnown, pCodePagePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEncoding(ref int pKnown, uint* pCodePage)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pKnownPtr = &pKnown)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePage);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEncoding(ref int pKnown, ref uint pCodePage)
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pKnownPtr = &pKnown)
            {
                fixed (uint* pCodePagePtr = &pCodePage)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, int*, uint*, int>)LpVtbl[5])(@this, pKnownPtr, pCodePagePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe byte* GetStringPointer()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            byte* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, byte*>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)]
        public readonly string GetStringPointerS()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            string ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcBlobUtf8*, string>)LpVtbl[6])(@this);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, string>)LpVtbl[6])(@this);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcBlobUtf8*, string>)LpVtbl[6])(@this);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly nuint GetStringLength()
        {
            var @this = (IDxcBlobUtf8*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            nuint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcBlobUtf8*, nuint>)LpVtbl[7])(@this);
            return ret;
        }

    }
}
