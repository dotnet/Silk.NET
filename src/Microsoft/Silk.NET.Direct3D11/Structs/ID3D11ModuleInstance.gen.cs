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
    public unsafe partial struct ID3D11ModuleInstance
    {
        public static readonly Guid Guid = new("469e07f7-045a-48d5-aa12-68a478cdf75d");

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
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
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
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBuffer(uint uSrcSlot, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[3])(@this, uSrcSlot, uDstSlot, cbDstOffset);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindConstantBufferByName(byte* pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pName, uDstSlot, cbDstOffset);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBufferByName(ref byte pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindConstantBufferByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint cbDstOffset)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[4])(@this, pNamePtr, uDstSlot, cbDstOffset);
            }
            #endif
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResource(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[5])(@this, uSrcSlot, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindResourceByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pName, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pName, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pName, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[6])(@this, pNamePtr, uDstSlot, uCount);
            }
            #endif
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSampler(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[7])(@this, uSrcSlot, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindSamplerByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pName, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pName, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pName, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSamplerByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindSamplerByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[8])(@this, pNamePtr, uDstSlot, uCount);
            }
            #endif
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessView(uint uSrcSlot, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[9])(@this, uSrcSlot, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindUnorderedAccessViewByName(byte* pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pName, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pName, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pName, uDstSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessViewByName(ref byte pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pNamePtr = &pName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindUnorderedAccessViewByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pName, uint uDstSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pNamePtr = (byte*) SilkMarshal.StringToPtr(pName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[10])(@this, pNamePtr, uDstSlot, uCount);
            }
            #endif
            SilkMarshal.Free((nint)pNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessView(uint uSrcSrvSlot, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, uint, uint, uint, int>)LpVtbl[11])(@this, uSrcSrvSlot, uDstUavSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BindResourceAsUnorderedAccessViewByName(byte* pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvName, uDstUavSlot, uCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName(ref byte pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pSrvNamePtr = &pSrvName)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BindResourceAsUnorderedAccessViewByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pSrvName, uint uDstUavSlot, uint uCount)
        {
            var @this = (ID3D11ModuleInstance*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pSrvNamePtr = (byte*) SilkMarshal.StringToPtr(pSrvName, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11ModuleInstance*, byte*, uint, uint, int>)LpVtbl[12])(@this, pSrvNamePtr, uDstUavSlot, uCount);
            }
            #endif
            SilkMarshal.Free((nint)pSrvNamePtr);
            return ret;
        }

    }
}
