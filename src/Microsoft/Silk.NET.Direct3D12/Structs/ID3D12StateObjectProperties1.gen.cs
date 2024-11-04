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

namespace Silk.NET.Direct3D12
{
    [Guid("460caac7-1d24-446a-a184-ca67db494138")]
    [NativeName("Name", "ID3D12StateObjectProperties1")]
    public unsafe partial struct ID3D12StateObjectProperties1 : IComVtbl<ID3D12StateObjectProperties1>, IComVtbl<ID3D12StateObjectProperties>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("460caac7-1d24-446a-a184-ca67db494138");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12StateObjectProperties(ID3D12StateObjectProperties1 val)
            => Unsafe.As<ID3D12StateObjectProperties1, ID3D12StateObjectProperties>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12StateObjectProperties1 val)
            => Unsafe.As<ID3D12StateObjectProperties1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12StateObjectProperties1
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
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, char*, void*>)@this->LpVtbl[3])(@this, pExportName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, char*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, byte*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, char*, ulong>)@this->LpVtbl[4])(@this, pExportName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, char*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, byte*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetPipelineStackSize()
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, ulong>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineStackSize(ulong PipelineStackSizeInBytes)
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, ulong, void>)@this->LpVtbl[6])(@this, PipelineStackSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramName);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties1*, ProgramIdentifier*, byte*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
            SilkMarshal.Free((nint)pProgramNamePtr);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
