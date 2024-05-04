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
    [Guid("469e07f7-045a-48d5-aa12-68a478cdf75d")]
    [NativeName("Name", "ID3D11ModuleInstance")]
    public unsafe partial struct ID3D11ModuleInstance : IComVtbl<ID3D11ModuleInstance>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("469e07f7-045a-48d5-aa12-68a478cdf75d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11ModuleInstance val)
            => Unsafe.As<ID3D11ModuleInstance, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11ModuleInstance
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
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBufferByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindResourceByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindSamplerByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSamplerByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSamplerByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pName, uDstSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)@this->LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindResourceAsUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrvNamePtr = &pSrvName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrvNamePtr = (byte*) SilkMarshal.StringToPtr(pSrvName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)@this->LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            SilkMarshal.Free((nint)pSrvNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
