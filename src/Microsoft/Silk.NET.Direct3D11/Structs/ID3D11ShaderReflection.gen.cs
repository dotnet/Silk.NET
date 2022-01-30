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
    [Guid("8d536ca1-0cca-4956-a837-786963755584")]
    [NativeName("Name", "ID3D11ShaderReflection")]
    public unsafe partial struct ID3D11ShaderReflection
    {
        public static readonly Guid Guid = new("8d536ca1-0cca-4956-a837-786963755584");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ShaderReflection val)
            => Unsafe.As<ID3D11ShaderReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ShaderReflection
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
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDesc(ShaderDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDesc(ref ShaderDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, ShaderDesc*, int>)LpVtbl[3])(@this, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByIndex(uint Index)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[4])(@this, Index);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[4])(@this, Index);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[4])(@this, Index);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(byte* Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName(ref byte Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionConstantBuffer* GetConstantBufferByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionConstantBuffer* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionConstantBuffer*>)LpVtbl[5])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDesc(uint ResourceIndex, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDesc(uint ResourceIndex, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, ShaderInputBindDesc*, int>)LpVtbl[6])(@this, ResourceIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetInputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetInputParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SignatureParameterDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[7])(@this, ParameterIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutputParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOutputParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SignatureParameterDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[8])(@this, ParameterIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatchConstantParameterDesc(uint ParameterIndex, SignatureParameterDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPatchConstantParameterDesc(uint ParameterIndex, ref SignatureParameterDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SignatureParameterDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint, SignatureParameterDesc*, int>)LpVtbl[9])(@this, ParameterIndex, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(byte* Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName(ref byte Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ID3D11ShaderReflectionVariable* GetVariableByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ID3D11ShaderReflectionVariable* ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ID3D11ShaderReflectionVariable*>)LpVtbl[10])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDesc);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(byte* Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, Name, pDescPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName(ref byte Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName(ref byte Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* NamePtr = &Name)
            {
                fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ShaderInputBindDesc* pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDesc);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResourceBindingDescByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string Name, ref ShaderInputBindDesc pDesc)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPStr);
            fixed (ShaderInputBindDesc* pDescPtr = &pDesc)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, byte*, ShaderInputBindDesc*, int>)LpVtbl[11])(@this, NamePtr, pDescPtr);
                }
            #endif
            }
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMovInstructionCount()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[12])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMovcInstructionCount()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetConversionInstructionCount()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[14])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetBitwiseInstructionCount()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[15])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Native.D3DPrimitive GetGSInputPrimitive()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Native.D3DPrimitive ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DPrimitive>)LpVtbl[16])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsSampleFrequencyShader()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, int>)LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumInterfaceSlots()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint>)LpVtbl[18])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMinFeatureLevel(Silk.NET.Core.Native.D3DFeatureLevel* pLevel)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevel);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevel);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevel);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMinFeatureLevel(ref Silk.NET.Core.Native.D3DFeatureLevel pLevel)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.D3DFeatureLevel* pLevelPtr = &pLevel)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevelPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevelPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, Silk.NET.Core.Native.D3DFeatureLevel*, int>)LpVtbl[19])(@this, pLevelPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZ);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(uint* pSizeX, uint* pSizeY, ref uint pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeZPtr = &pSizeZ)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeY, pSizeZPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(uint* pSizeX, ref uint pSizeY, uint* pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeYPtr = &pSizeY)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZ);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(uint* pSizeX, ref uint pSizeY, ref uint pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeYPtr = &pSizeY)
            {
                fixed (uint* pSizeZPtr = &pSizeZ)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeX, pSizeYPtr, pSizeZPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(ref uint pSizeX, uint* pSizeY, uint* pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeXPtr = &pSizeX)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZ);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(ref uint pSizeX, uint* pSizeY, ref uint pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeXPtr = &pSizeX)
            {
                fixed (uint* pSizeZPtr = &pSizeZ)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeY, pSizeZPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetThreadGroupSize(ref uint pSizeX, ref uint pSizeY, uint* pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeXPtr = &pSizeX)
            {
                fixed (uint* pSizeYPtr = &pSizeY)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZ);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetThreadGroupSize(ref uint pSizeX, ref uint pSizeY, ref uint pSizeZ)
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (uint* pSizeXPtr = &pSizeX)
            {
                fixed (uint* pSizeYPtr = &pSizeY)
                {
                    fixed (uint* pSizeZPtr = &pSizeZ)
                    {
            #if NET5_0_OR_GREATER
                        ret = ((delegate* unmanaged<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
            #else
                        if (SilkMarshal.IsWinapiStdcall)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
                        }
                        else
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11ShaderReflection*, uint*, uint*, uint*, uint>)LpVtbl[20])(@this, pSizeXPtr, pSizeYPtr, pSizeZPtr);
                        }
            #endif
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ulong GetRequiresFlags()
        {
            var @this = (ID3D11ShaderReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ulong ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ShaderReflection*, ulong>)LpVtbl[21])(@this);
            return ret;
        }

    }
}
