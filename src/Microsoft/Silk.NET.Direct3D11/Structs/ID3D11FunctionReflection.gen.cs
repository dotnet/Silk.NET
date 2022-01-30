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

namespace Silk.NET.Direct3D11
{
    [Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4")]
    [NativeName("Name", "ID3D11FunctionReflection")]
    public unsafe partial struct ID3D11FunctionReflection
    {
        public static readonly Guid Guid = new("207bcecb-d683-4a06-a8a3-9b149b9f73a4");

        public ID3D11FunctionReflection
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
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref FunctionDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (FunctionDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, FunctionDesc*, int>)LpVtbl[0])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint BufferIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[1])(@this, BufferIndex);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[2])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[3])(@this, ResourceIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[4])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, Name, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDesc);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[5])(@this, NamePtr, pDescPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11FunctionParameterReflection* GetFunctionParameter(int ParameterIndex)
        {
            var @this = (ID3D11FunctionReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11FunctionParameterReflection* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11FunctionReflection*, int, ID3D11FunctionParameterReflection*>)LpVtbl[6])(@this, ParameterIndex);
            }
            #endif
            return ret;
        }

    }
}
