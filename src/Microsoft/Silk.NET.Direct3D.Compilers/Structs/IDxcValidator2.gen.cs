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
    public unsafe partial struct IDxcValidator2 : IComVtbl<IDxcValidator2>, IComVtbl<IDxcValidator>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("458e1fd1-b1b2-4750-a6e1-9c10f03bed92");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(IDxcBlob* pShader, uint Flags, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate(IDxcBlob* pShader, uint Flags, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShader, Flags, ppResultPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResult);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, IDxcOperationResult**, int>)@this->LpVtbl[3])(@this, pShaderPtr, Flags, ppResultPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, IDxcOperationResult** ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug(IDxcBlob* pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcode, ppResultPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResult);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShader, Flags, pOptDebugBitcodePtr, ppResultPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResult);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcode, ppResultPtr);
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
                    ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResult);
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
                        ret = ((delegate* unmanaged[Stdcall]<IDxcValidator2*, IDxcBlob*, uint, Buffer*, IDxcOperationResult**, int>)@this->LpVtbl[4])(@this, pShaderPtr, Flags, pOptDebugBitcodePtr, ppResultPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Validate<TI0, TI1>(ComPtr<TI0> pShader, uint Flags, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Validate((IDxcBlob*) pShader.Handle, Flags, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Validate<TI0>(ComPtr<TI0> pShader, uint Flags, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Validate((IDxcBlob*) pShader.Handle, Flags, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly int Validate<TI0>(ref IDxcBlob pShader, uint Flags, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Validate(ref pShader, Flags, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug<TI0, TI1>(ComPtr<TI0> pShader, uint Flags, Buffer* pOptDebugBitcode, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug<TI0>(ComPtr<TI0> pShader, uint Flags, Buffer* pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, pOptDebugBitcode, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateWithDebug<TI0, TI1>(ComPtr<TI0> pShader, uint Flags, ref Buffer pOptDebugBitcode, ref ComPtr<TI1> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI1>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, ref pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug<TI0>(ComPtr<TI0> pShader, uint Flags, ref Buffer pOptDebugBitcode, ref IDxcOperationResult* ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug((IDxcBlob*) pShader.Handle, Flags, ref pOptDebugBitcode, ref ppResult);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ValidateWithDebug<TI0>(ref IDxcBlob pShader, uint Flags, Buffer* pOptDebugBitcode, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug(ref pShader, Flags, pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int ValidateWithDebug<TI0>(ref IDxcBlob pShader, uint Flags, ref Buffer pOptDebugBitcode, ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcOperationResult>, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->ValidateWithDebug(ref pShader, Flags, ref pOptDebugBitcode, (IDxcOperationResult**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcValidator2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
