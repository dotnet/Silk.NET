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
    [Guid("4315d938-f369-4f93-95a2-252017cc3807")]
    [NativeName("Name", "IDxcPdbUtils2")]
    public unsafe partial struct IDxcPdbUtils2 : IComVtbl<IDxcPdbUtils2>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4315d938-f369-4f93-95a2-252017cc3807");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcPdbUtils2 val)
            => Unsafe.As<IDxcPdbUtils2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcPdbUtils2
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
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxil);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pPdbOrDxil)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pPdbOrDxilPtr = &pPdbOrDxil)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob*, int>)@this->LpVtbl[3])(@this, pPdbOrDxilPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[4])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[4])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, IDxcBlobEncoding** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSource(uint uIndex, ref IDxcBlobEncoding* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[6])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSourceName(uint uIndex, ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[6])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDBCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[7])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLibraryPDBCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[7])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB(uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, IDxcBlobWide** ppLibraryName)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtils, ppLibraryName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB(uint uIndex, IDxcPdbUtils2** ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppLibraryNamePtr = &ppLibraryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtils, ppLibraryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB(uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, IDxcBlobWide** ppLibraryName)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcPdbUtils2** ppOutPdbUtilsPtr = &ppOutPdbUtils)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtilsPtr, ppLibraryName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB(uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcPdbUtils2** ppOutPdbUtilsPtr = &ppOutPdbUtils)
            {
                fixed (IDxcBlobWide** ppLibraryNamePtr = &ppLibraryName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcPdbUtils2**, IDxcBlobWide**, int>)@this->LpVtbl[8])(@this, uIndex, ppOutPdbUtilsPtr, ppLibraryNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlagCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[9])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlagCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[9])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[10])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFlag(uint uIndex, ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[10])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[11])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[11])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[12])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArg(uint uIndex, ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[12])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPairCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[13])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPairCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[13])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, IDxcBlobWide** ppName, IDxcBlobWide** ppValue)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppName, ppValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, IDxcBlobWide** ppName, ref IDxcBlobWide* ppValue)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppValuePtr = &ppValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppName, ppValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, ref IDxcBlobWide* ppName, IDxcBlobWide** ppValue)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppNamePtr = &ppName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppNamePtr, ppValue);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair(uint uIndex, ref IDxcBlobWide* ppName, ref IDxcBlobWide* ppValue)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppNamePtr = &ppName)
            {
                fixed (IDxcBlobWide** ppValuePtr = &ppValue)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, IDxcBlobWide**, int>)@this->LpVtbl[14])(@this, uIndex, ppNamePtr, ppValuePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefineCount(uint* pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[15])(@this, pCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefineCount(ref uint pCount)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[15])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[16])(@this, uIndex, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDefine(uint uIndex, ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint, IDxcBlobWide**, int>)@this->LpVtbl[16])(@this, uIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[17])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTargetProfile(ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[17])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[18])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEntryPoint(ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[18])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[19])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMainFileName(ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[19])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[20])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetHash(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[20])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(IDxcBlobWide** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[21])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetName(ref IDxcBlobWide* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlobWide**, int>)@this->LpVtbl[21])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(IDxcVersionInfo** ppVersionInfo)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersionInfo(ref IDxcVersionInfo* ppVersionInfo)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcVersionInfo** ppVersionInfoPtr = &ppVersionInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcVersionInfo**, int>)@this->LpVtbl[22])(@this, ppVersionInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustomToolchainID(uint* pID)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[23])(@this, pID);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCustomToolchainID(ref uint pID)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pIDPtr = &pID)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, uint*, int>)@this->LpVtbl[23])(@this, pIDPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustomToolchainData(IDxcBlob** ppBlob)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[24])(@this, ppBlob);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCustomToolchainData(ref IDxcBlob* ppBlob)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppBlobPtr = &ppBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[24])(@this, ppBlobPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWholeDxil(IDxcBlob** ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[25])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetWholeDxil(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, IDxcBlob**, int>)@this->LpVtbl[25])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsFullPDB()
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Silk.NET.Core.Bool32>)@this->LpVtbl[26])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 IsPDBRef()
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcPdbUtils2*, Silk.NET.Core.Bool32>)@this->LpVtbl[27])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Load<TI0>(ComPtr<TI0> pPdbOrDxil) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Load((IDxcBlob*) pPdbOrDxil.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSource<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSource(uIndex, (IDxcBlobEncoding**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSourceName<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSourceName(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLibraryPDB<TI0, TI1>(uint uIndex, ref ComPtr<TI0> ppOutPdbUtils, ref ComPtr<TI1> ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcPdbUtils2>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetLibraryPDB(uIndex, (IDxcPdbUtils2**) ppOutPdbUtils.GetAddressOf(), (IDxcBlobWide**) ppLibraryName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB<TI0>(uint uIndex, ref ComPtr<TI0> ppOutPdbUtils, ref IDxcBlobWide* ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcPdbUtils2>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetLibraryPDB(uIndex, (IDxcPdbUtils2**) ppOutPdbUtils.GetAddressOf(), ref ppLibraryName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLibraryPDB<TI0>(uint uIndex, ref IDxcPdbUtils2* ppOutPdbUtils, ref ComPtr<TI0> ppLibraryName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetLibraryPDB(uIndex, ref ppOutPdbUtils, (IDxcBlobWide**) ppLibraryName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFlag<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFlag(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArg<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetArg(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetArgPair<TI0, TI1>(uint uIndex, ref ComPtr<TI0> ppName, ref ComPtr<TI1> ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetArgPair(uIndex, (IDxcBlobWide**) ppName.GetAddressOf(), (IDxcBlobWide**) ppValue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair<TI0>(uint uIndex, ref ComPtr<TI0> ppName, ref IDxcBlobWide* ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetArgPair(uIndex, (IDxcBlobWide**) ppName.GetAddressOf(), ref ppValue);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetArgPair<TI0>(uint uIndex, ref IDxcBlobWide* ppName, ref ComPtr<TI0> ppValue) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetArgPair(uIndex, ref ppName, (IDxcBlobWide**) ppValue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDefine<TI0>(uint uIndex, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetDefine(uIndex, (IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetTargetProfile<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetTargetProfile((IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEntryPoint<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEntryPoint((IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMainFileName<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetMainFileName((IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetHash<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetHash((IDxcBlob**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetName<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetName((IDxcBlobWide**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersionInfo<TI0>(ref ComPtr<TI0> ppVersionInfo) where TI0 : unmanaged, IComVtbl<IDxcVersionInfo>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetVersionInfo((IDxcVersionInfo**) ppVersionInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCustomToolchainData<TI0>(ref ComPtr<TI0> ppBlob) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetCustomToolchainData((IDxcBlob**) ppBlob.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetWholeDxil<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetWholeDxil((IDxcBlob**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcPdbUtils2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
