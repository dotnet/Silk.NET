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
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxil);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob*, int>)LpVtbl[3])(@this, pPdbOrDxilPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[4])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, IDxcBlobEncoding** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, ref IDxcBlobEncoding* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)LpVtbl[5])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[6])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlagCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlagCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[7])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[8])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[9])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[10])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPairCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPairCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[11])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, char** pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, ref char* pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pName, pValuePtr);
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
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
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
                    ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, char**, int>)LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefineCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefineCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint*, int>)LpVtbl[13])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, uint, char**, int>)LpVtbl[14])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[15])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[16])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[17])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[18])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char**, int>)LpVtbl[19])(@this, pResultPtr);
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
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDB);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullPDB(ref IDxcBlob* ppFullPDB)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppFullPDBPtr = &ppFullPDB)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcBlob**, int>)LpVtbl[21])(@this, ppFullPDBPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(ref IDxcVersionInfo* ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcVersionInfo**, int>)LpVtbl[22])(@this, ppVersionInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCompiler(IDxcCompiler3* pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompiler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompiler(ref IDxcCompiler3 pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcCompiler3* pCompilerPtr = &pCompiler)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcCompiler3*, int>)LpVtbl[23])(@this, pCompilerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(IDxcResult** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(ref IDxcResult* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, IDxcResult**, int>)LpVtbl[24])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideArgs(ArgPair* pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideArgs(ref ArgPair pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ArgPair* pArgPairsPtr = &pArgPairs)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, ArgPair*, uint, int>)LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideRootSignature(char* pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature(ref char pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, char*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pRootSignaturePtr = (byte*) SilkMarshal.StringToPtr(pRootSignature, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<IDxcPdbUtils*, byte*, int>)LpVtbl[26])(@this, pRootSignaturePtr);
            SilkMarshal.Free((nint)pRootSignaturePtr);
            return ret;
        }

    }
}
