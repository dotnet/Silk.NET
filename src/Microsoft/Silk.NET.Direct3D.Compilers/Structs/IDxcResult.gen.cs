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
    [Guid("58346cda-dde7-4497-9461-6f87af5e0659")]
    [NativeName("Name", "IDxcResult")]
    public unsafe partial struct IDxcResult : IComVtbl<IDxcResult>, IComVtbl<IDxcOperationResult>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("58346cda-dde7-4497-9461-6f87af5e0659");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDxcOperationResult(IDxcResult val)
            => Unsafe.As<IDxcResult, IDxcOperationResult>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcResult val)
            => Unsafe.As<IDxcResult, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcResult
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
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetStatus(int* pStatus)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, int*, int>)@this->LpVtbl[3])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStatus(ref int pStatus)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, int*, int>)@this->LpVtbl[3])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResult(IDxcBlob** ppResult)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResult);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetResult(ref IDxcBlob* ppResult)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlob**, int>)@this->LpVtbl[4])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetErrorBuffer(IDxcBlobEncoding** ppErrors)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrors);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetErrorBuffer(ref IDxcBlobEncoding* ppErrors)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobEncoding** ppErrorsPtr = &ppErrors)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, IDxcBlobEncoding**, int>)@this->LpVtbl[5])(@this, ppErrorsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 HasOutput(OutKind dxcOutKind)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Silk.NET.Core.Bool32>)@this->LpVtbl[6])(@this, dxcOutKind);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, Guid* iid, void** ppvObject, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObject, ppOutputName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, Guid* iid, void** ppvObject, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObject, ppOutputNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, Guid* iid, ref void* ppvObject, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObjectPtr, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, Guid* iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iid, ppvObjectPtr, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, ref Guid iid, void** ppvObject, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObject, ppOutputName);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, ref Guid iid, void** ppvObject, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObject, ppOutputNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, IDxcBlobWide** ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObjectPtr, ppOutputName);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput(OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, ref IDxcBlobWide* ppOutputName)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    fixed (IDxcBlobWide** ppOutputNamePtr = &ppOutputName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcResult*, OutKind, Guid*, void**, IDxcBlobWide**, int>)@this->LpVtbl[7])(@this, dxcOutKind, iidPtr, ppvObjectPtr, ppOutputNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetNumOutputs()
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint>)@this->LpVtbl[8])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OutKind GetOutputByIndex(uint Index)
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OutKind ret = default;
            ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, uint, OutKind>)@this->LpVtbl[9])(@this, Index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly OutKind PrimaryOutput()
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            OutKind ret = default;
            ret = ((delegate* unmanaged[Thiscall]<IDxcResult*, OutKind>)@this->LpVtbl[10])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetResult<TI0>(ref ComPtr<TI0> ppResult) where TI0 : unmanaged, IComVtbl<IDxcBlob>, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetResult((IDxcBlob**) ppResult.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetErrorBuffer<TI0>(ref ComPtr<TI0> ppErrors) where TI0 : unmanaged, IComVtbl<IDxcBlobEncoding>, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetErrorBuffer((IDxcBlobEncoding**) ppErrors.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOutput<TI0, TI1>(OutKind dxcOutKind, ref ComPtr<TI0> ppvObject, ref ComPtr<TI1> ppOutputName) where TI0 : unmanaged, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI1>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(dxcOutKind, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(OutKind dxcOutKind, ref ComPtr<TI0> ppvObject, ref IDxcBlobWide* ppOutputName) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(dxcOutKind, SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf(), ref ppOutputName);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(OutKind dxcOutKind, Guid* iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(dxcOutKind, iid, ref ppvObject, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(OutKind dxcOutKind, ref Guid iid, void** ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(dxcOutKind, ref iid, ppvObject, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOutput<TI0>(OutKind dxcOutKind, ref Guid iid, ref void* ppvObject, ref ComPtr<TI0> ppOutputName) where TI0 : unmanaged, IComVtbl<IDxcBlobWide>, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetOutput(dxcOutKind, ref iid, ref ppvObject, (IDxcBlobWide**) ppOutputName.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDxcResult*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
