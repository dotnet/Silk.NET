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
    [Guid("4605c4cb-2019-492a-ada4-65f20bb7d67f")]
    [NativeName("Name", "IDxcUtils")]
    public unsafe partial struct IDxcUtils : IComVtbl<IDxcUtils>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("4605c4cb-2019-492a-ada4-65f20bb7d67f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcUtils val)
            => Unsafe.As<IDxcUtils, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcUtils
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
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromBlob(IDxcBlob* pBlob, uint offset, uint length, IDxcBlob** ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, uint, uint, IDxcBlob**, int>)@this->LpVtbl[3])(@this, pBlob, offset, length, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlobFromPinned([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[4])(@this, pData, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MoveToBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, IMalloc* pIMalloc, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, IMalloc*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, pData, pIMalloc, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBlob([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pData, uint size, uint codePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, void*, uint, uint, IDxcBlobEncoding**, int>)@this->LpVtbl[6])(@this, pData, size, codePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int LoadFile([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pFileName, uint* pCodePage, IDxcBlobEncoding** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, uint*, IDxcBlobEncoding**, int>)@this->LpVtbl[7])(@this, pFileName, pCodePage, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReadOnlyStreamFromBlob(IDxcBlob* pBlob, void** ppStream)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, void**, int>)@this->LpVtbl[8])(@this, pBlob, ppStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDefaultIncludeHandler(IDxcIncludeHandler** ppResult)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcIncludeHandler**, int>)@this->LpVtbl[9])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf8(IDxcBlob* pBlob, IDxcBlobUtf8** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf8**, int>)@this->LpVtbl[10])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBlobAsUtf16(IDxcBlob* pBlob, IDxcBlobUtf16** pBlobEncoding)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlobUtf16**, int>)@this->LpVtbl[11])(@this, pBlob, pBlobEncoding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDxilContainerPart([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pShader, uint DxcPart, void** ppPartData, uint* pPartSizeInBytes)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, uint, void**, uint*, int>)@this->LpVtbl[12])(@this, pShader, DxcPart, ppPartData, pPartSizeInBytes);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateReflection([Flow(Silk.NET.Core.Native.FlowDirection.In)] Buffer* pData, Guid* iid, void** ppvReflection)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, Buffer*, Guid*, void**, int>)@this->LpVtbl[13])(@this, pData, iid, ppvReflection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BuildArguments([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pSourceName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pEntryPoint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pTargetProfile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** pArguments, uint argCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Define* pDefines, uint defineCount, IDxcCompilerArgs** ppArgs)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, char*, char*, char*, char**, uint, Define*, uint, IDxcCompilerArgs**, int>)@this->LpVtbl[14])(@this, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, ppArgs);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPDBContents(IDxcBlob* pPDBBlob, IDxcBlob** ppHash, IDxcBlob** ppContainer)
        {
            var @this = (IDxcUtils*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcUtils*, IDxcBlob*, IDxcBlob**, IDxcBlob**, int>)@this->LpVtbl[15])(@this, pPDBBlob, ppHash, ppContainer);
            return ret;
        }

    }
}
