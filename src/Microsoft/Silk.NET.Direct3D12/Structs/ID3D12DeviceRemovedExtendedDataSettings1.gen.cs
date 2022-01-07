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
    [Guid("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b")]
    [NativeName("Name", "ID3D12DeviceRemovedExtendedDataSettings1")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedDataSettings1
    {
        public static readonly Guid Guid = new("dbd5ae51-3317-4f0a-adf9-1d7cedcaae0b");

        public static implicit operator ID3D12DeviceRemovedExtendedDataSettings(ID3D12DeviceRemovedExtendedDataSettings1 val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedDataSettings1, ID3D12DeviceRemovedExtendedDataSettings>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceRemovedExtendedDataSettings1 val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedDataSettings1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceRemovedExtendedDataSettings1
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
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetAutoBreadcrumbsEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[3])(@this, Enablement);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[3])(@this, Enablement);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[3])(@this, Enablement);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPageFaultEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[4])(@this, Enablement);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[4])(@this, Enablement);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[4])(@this, Enablement);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetWatsonDumpEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[5])(@this, Enablement);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[5])(@this, Enablement);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[5])(@this, Enablement);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetBreadcrumbContextEnablement(DredEnablement Enablement)
        {
            var @this = (ID3D12DeviceRemovedExtendedDataSettings1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[6])(@this, Enablement);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[6])(@this, Enablement);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedDataSettings1*, DredEnablement, void>)LpVtbl[6])(@this, Enablement);
            }
            #endif
        }

    }
}
