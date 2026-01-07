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
    [Guid("d5e82917-f0f1-44cf-ae5e-ce222dd0b884")]
    [NativeName("Name", "ID3D12StateObjectProperties2")]
    public unsafe partial struct ID3D12StateObjectProperties2 : IComVtbl<ID3D12StateObjectProperties2>, IComVtbl<ID3D12StateObjectProperties1>, IComVtbl<ID3D12StateObjectProperties>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d5e82917-f0f1-44cf-ae5e-ce222dd0b884");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID3D12StateObjectProperties1(ID3D12StateObjectProperties2 val)
            => Unsafe.As<ID3D12StateObjectProperties2, ID3D12StateObjectProperties1>(ref val);

        public static implicit operator ID3D12StateObjectProperties(ID3D12StateObjectProperties2 val)
            => Unsafe.As<ID3D12StateObjectProperties2, ID3D12StateObjectProperties>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12StateObjectProperties2 val)
            => Unsafe.As<ID3D12StateObjectProperties2, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12StateObjectProperties2
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
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, void*>)@this->LpVtbl[3])(@this, pExportName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void* GetShaderIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            void* ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, void*>)@this->LpVtbl[3])(@this, pExportNamePtr);
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, ulong>)@this->LpVtbl[4])(@this, pExportName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetShaderStackSize([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, ulong>)@this->LpVtbl[4])(@this, pExportNamePtr);
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetPipelineStackSize()
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ulong>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPipelineStackSize(ulong PipelineStackSizeInBytes)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ulong, void>)@this->LpVtbl[6])(@this, PipelineStackSizeInBytes);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramName);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, char*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
            }
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ProgramIdentifier GetProgramIdentifier([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName)
        {
            ProgramIdentifier silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ProgramIdentifier* ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, ProgramIdentifier*, byte*, ProgramIdentifier*>)@this->LpVtbl[7])(@this, pSilkDotNetReturnFixupResult, pProgramNamePtr);
            SilkMarshal.Free((nint)pProgramNamePtr);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riid, ppvRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riidPtr, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramName, riidPtr, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pProgramNamePtr = &pProgramName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignature);
            SilkMarshal.Free((nint)pProgramNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riid, ppvRootSignaturePtr);
            }
            SilkMarshal.Free((nint)pProgramNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignature);
            }
            SilkMarshal.Free((nint)pProgramNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pProgramNamePtr = (byte*) SilkMarshal.StringToPtr(pProgramName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[8])(@this, pProgramNamePtr, riidPtr, ppvRootSignaturePtr);
                }
            }
            SilkMarshal.Free((nint)pProgramNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riid, ppvRootSignature);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riid, ppvRootSignaturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riidPtr, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportName, riidPtr, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignature);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignaturePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignature);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pExportNamePtr = &pExportName)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, char*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignaturePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Guid* riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignature);
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, Guid* riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riid, ppvRootSignaturePtr);
            }
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, ref Guid riid, void** ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignature);
            }
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, ref Guid riid, ref void* ppvRootSignature)
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pExportNamePtr = (byte*) SilkMarshal.StringToPtr(pExportName, NativeStringEncoding.LPWStr);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvRootSignaturePtr = &ppvRootSignature)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12StateObjectProperties2*, byte*, Guid*, void**, int>)@this->LpVtbl[9])(@this, pExportNamePtr, riidPtr, ppvRootSignaturePtr);
                }
            }
            SilkMarshal.Free((nint)pExportNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForProgram(pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForProgram(in pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForProgram(pProgramName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForShader(pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForShader(in pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName, out ComPtr<TI0> ppvRootSignature) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvRootSignature = default;
            return @this->GetGlobalRootSignatureForShader(pExportName, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvRootSignature.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(pProgramName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(in pProgramName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetGlobalRootSignatureForProgram<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pProgramName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForProgram(pProgramName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* pExportName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(pExportName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char pExportName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(in pExportName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> GetGlobalRootSignatureForShader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string pExportName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D12StateObjectProperties2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->GetGlobalRootSignatureForShader(pExportName, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
