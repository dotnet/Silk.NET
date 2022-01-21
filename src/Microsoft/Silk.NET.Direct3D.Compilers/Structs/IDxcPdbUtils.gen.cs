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
    [Guid("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d")]
    [NativeName("Name", "IDxcPdbUtils")]
    public unsafe partial struct IDxcPdbUtils
    {
        public static readonly Guid Guid = new("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcPdbUtils val)
            => Unsafe.As<IDxcPdbUtils, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcPdbUtils
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
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxil);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxil);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxil);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxilPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxilPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxilPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, IDxcBlobEncoding** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, ref IDxcBlobEncoding* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlagCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlagCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPairCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPairCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, char** pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValue);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValue);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValue);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, ref char* pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pValuePtr = &pValue)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValuePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValuePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValuePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, ref char* pName, char** pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pNamePtr = &pName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, ref char* pName, ref char* pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pNamePtr = &pName)
            {
                fixed (char** pValuePtr = &pValue)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefineCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefineCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsFullPDB()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, int>)LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullPDB(IDxcBlob** ppFullPDB)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDB);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDB);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDB);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullPDB(ref IDxcBlob* ppFullPDB)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppFullPDBPtr = &ppFullPDB)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDBPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDBPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDBPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfo);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfo);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfo);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(ref IDxcVersionInfo* ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfoPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfoPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfoPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCompiler(IDxcCompiler3* pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompiler);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompiler);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompiler);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompiler(ref IDxcCompiler3 pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcCompiler3* pCompilerPtr = &pCompiler)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompilerPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompilerPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompilerPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(IDxcResult** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(ref IDxcResult* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcResult** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideArgs(ArgPair* pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideArgs(ref ArgPair pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ArgPair* pArgPairsPtr = &pArgPairs)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideRootSignature(char* pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignature);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignature);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignature);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature(ref char pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pRootSignaturePtr = &pRootSignature)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pRootSignaturePtr = (byte*) SilkMarshal.StringToPtr(pRootSignature, NativeStringEncoding.UTF8);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcPdbUtils*, byte*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, byte*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, byte*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            }
            #endif
            SilkMarshal.Free((nint)pRootSignaturePtr);
            return ret;
        }

    }
}
