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
    [Guid("458e1fd1-b1b2-4750-a6e1-9c10f03bed92")]
    [NativeName("Name", "IDxcValidator2")]
    public unsafe partial struct IDxcValidator2
    {
        public static readonly Guid Guid = new("458e1fd1-b1b2-4750-a6e1-9c10f03bed92");

        public static implicit operator IDxcValidator(IDxcValidator2 val)
            => Unsafe.As<IDxcValidator2, IDxcValidator>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcValidator2 val)
            => Unsafe.As<IDxcValidator2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcValidator2
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
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(ref IDxcBlob pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(ref IDxcBlob pShader, uint Flags, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pShaderPtr = &pShader)
            {
                fixed (Buffer* pOptDebugBitcodePtr = &pOptDebugBitcode)
                {
                    fixed (IDxcOperationResult** ppResultPtr = &ppResult)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

    }
}
