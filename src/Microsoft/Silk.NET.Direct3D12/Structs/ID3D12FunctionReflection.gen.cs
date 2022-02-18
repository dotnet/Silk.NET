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
    [Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799")]
    [NativeName("Name", "ID3D12FunctionReflection")]
    public unsafe partial struct ID3D12FunctionReflection
    {
        public static readonly Guid Guid = new("1108795c-2772-4ba9-b2a8-d464dc7e2799");

        public ID3D12FunctionReflection
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
        public readonly unsafe int GetDesc(FunctionDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionConstantBuffer* GetConstantBufferByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12ShaderReflectionVariable* GetVariableByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ID3D12ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D12FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D12FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D12FunctionParameterReflection* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12FunctionReflection*, int, ID3D12FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            }
            #endif
            return ret;
        }

    }
}
