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
        public readonly unsafe int GetSourceCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
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
        public readonly unsafe int GetSourceName(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[6])(@this, uIndex, pResult);
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
        public readonly unsafe int GetFlag(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[8])(@this, uIndex, pResult);
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
        public readonly unsafe int GetArg(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[10])(@this, uIndex, pResult);
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
        public readonly unsafe int GetArgPair(uint uIndex, char** pName, char** pValue)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, char**, int>)@this->LpVtbl[12])(@this, uIndex, pName, pValue);
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
        public readonly unsafe int GetDefine(uint uIndex, char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, uint, char**, int>)@this->LpVtbl[14])(@this, uIndex, pResult);
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
        public readonly unsafe int GetEntryPoint(char** pResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char**, int>)@this->LpVtbl[16])(@this, pResult);
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
        public readonly unsafe int GetHash(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcBlob**, int>)@this->LpVtbl[18])(@this, ppResult);
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
        public readonly unsafe int GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
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
        public readonly unsafe int CompileForFullPDB(IDxcResult** ppResult)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, IDxcResult**, int>)@this->LpVtbl[24])(@this, ppResult);
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
        public readonly unsafe int OverrideRootSignature([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pRootSignature)
        {
            var @this = (IDxcPdbUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils*, char*, int>)@this->LpVtbl[26])(@this, pRootSignature);
            return ret;
        }

    }
}
