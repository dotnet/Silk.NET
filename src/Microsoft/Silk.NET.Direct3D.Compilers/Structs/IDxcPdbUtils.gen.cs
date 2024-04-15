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
    public unsafe partial struct IDxcPdbUtils : IComVtbl<IDxcPdbUtils>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e6c9647e-9d6a-4c3b-b94c-524b5a6c343d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxil);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxilPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, IDxcBlobEncoding** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, ref IDxcBlobEncoding* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlagCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlagCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[7])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[9])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPairCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPairCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[11])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, char** pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, ref char* pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValuePtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pNamePtr, pValue);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pNamePtr, pValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefineCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefineCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[13])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[15])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[17])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref char* pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** pResultPtr = &pResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[19])(@this, pResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsFullPDB()
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, Silk.NET.Core.Bool32>)@this->LpVtbl[20])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullPDB(IDxcBlob** ppFullPDB)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDB);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFullPDB(ref IDxcBlob* ppFullPDB)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppFullPDBPtr = &ppFullPDB)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[21])(@this, ppFullPDBPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(ref IDxcVersionInfo* ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetCompiler(IDxcCompiler3* pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompiler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompiler(ref IDxcCompiler3 pCompiler)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcCompiler3* pCompilerPtr = &pCompiler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcCompiler3*, int>)@this->LpVtbl[23])(@this, pCompilerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(IDxcResult** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CompileForFullPDB(ref IDxcResult* ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideArgs(ArgPair* pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairs, uNumArgPairs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideArgs(ref ArgPair pArgPairs, uint uNumArgPairs)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ArgPair* pArgPairsPtr = &pArgPairs)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, ArgPair*, uint, int>)@this->LpVtbl[25])(@this, pArgPairsPtr, uNumArgPairs);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OverrideRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pRootSignaturePtr = &pRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int OverrideRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pRootSignaturePtr = (byte*) SilkMarshal.StringToPtr(pRootSignature, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, byte*, int>)@this->LpVtbl[26])(@this, pRootSignaturePtr);
            SilkMarshal.Free((nint)pRootSignaturePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pPdbOrDxil) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((IDxcBlob*) pPdbOrDxil.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSource<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSource(uIndex, (IDxcBlobEncoding**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceName(uint uIndex, string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetSourceName(uIndex, pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlag(uint uIndex, string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetFlag(uIndex, pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArg(uint uIndex, string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetArg(uIndex, pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPair(uint uIndex, string[] pNameSa, string[] pValueSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
            var pValue = (char**) SilkMarshal.StringArrayToPtr(pValueSa);
            var ret = @this->GetArgPair(uIndex, pName, pValue);
            SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
            SilkMarshal.Free((nint) pName);
            SilkMarshal.CopyPtrToStringArray((nint) pValue, pValueSa);
            SilkMarshal.Free((nint) pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, string[] pNameSa, ref char* pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pName = (char**) SilkMarshal.StringArrayToPtr(pNameSa);
            var ret = @this->GetArgPair(uIndex, pName, ref pValue);
            SilkMarshal.CopyPtrToStringArray((nint) pName, pNameSa);
            SilkMarshal.Free((nint) pName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, ref char* pName, string[] pValueSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pValue = (char**) SilkMarshal.StringArrayToPtr(pValueSa);
            var ret = @this->GetArgPair(uIndex, ref pName, pValue);
            SilkMarshal.CopyPtrToStringArray((nint) pValue, pValueSa);
            SilkMarshal.Free((nint) pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefine(uint uIndex, string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetDefine(uIndex, pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTargetProfile(string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetTargetProfile(pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEntryPoint(string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetEntryPoint(pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMainFileName(string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetMainFileName(pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHash<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetHash((IDxcBlob**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetName(string[] pResultSa)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var pResult = (char**) SilkMarshal.StringArrayToPtr(pResultSa);
            var ret = @this->GetName(pResult);
            SilkMarshal.CopyPtrToStringArray((nint) pResult, pResultSa);
            SilkMarshal.Free((nint) pResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFullPDB<TI0>(ref ComPtr<TI0> ppFullPDB) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFullPDB((IDxcBlob**) ppFullPDB.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersionInfo<TI0>(ref ComPtr<TI0> ppVersionInfo) where TI0 : unmanaged, IComVtbl<IDxcVersionInfo>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetVersionInfo((IDxcVersionInfo**) ppVersionInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetCompiler<TI0>(ComPtr<TI0> pCompiler) where TI0 : unmanaged, IComVtbl<IDxcCompiler3>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetCompiler((IDxcCompiler3*) pCompiler.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CompileForFullPDB<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcResult>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CompileForFullPDB((IDxcResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
