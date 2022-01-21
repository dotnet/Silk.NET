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
    [Guid("e9eb5314-33aa-42b2-a718-d77f58b1f1c7")]
    [NativeName("Name", "ID3D12SDKConfiguration")]
    public unsafe partial struct ID3D12SDKConfiguration
    {
        public static readonly Guid Guid = new("e9eb5314-33aa-42b2-a718-d77f58b1f1c7");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12SDKConfiguration val)
            => Unsafe.As<ID3D12SDKConfiguration, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12SDKConfiguration
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
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetSDKVersion(uint SDKVersion, byte* SDKPath)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPath);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPath);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPath);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSDKVersion(uint SDKVersion, ref byte SDKPath)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* SDKPathPtr = &SDKPath)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetSDKVersion(uint SDKVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string SDKPath)
        {
            var @this = (ID3D12SDKConfiguration*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var SDKPathPtr = (byte*) SilkMarshal.StringToPtr(SDKPath, NativeStringEncoding.LPStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12SDKConfiguration*, uint, byte*, int>)LpVtbl[3])(@this, SDKVersion, SDKPathPtr);
            }
            #endif
            SilkMarshal.Free((nint)SDKPathPtr);
            return ret;
        }

    }
}
