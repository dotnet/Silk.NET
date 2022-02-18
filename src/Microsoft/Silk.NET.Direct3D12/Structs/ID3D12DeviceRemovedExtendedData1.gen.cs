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
    [Guid("9727a022-cf1d-4dda-9eba-effa653fc506")]
    [NativeName("Name", "ID3D12DeviceRemovedExtendedData1")]
    public unsafe partial struct ID3D12DeviceRemovedExtendedData1
    {
        public static readonly Guid Guid = new("9727a022-cf1d-4dda-9eba-effa653fc506");

        public static implicit operator ID3D12DeviceRemovedExtendedData(ID3D12DeviceRemovedExtendedData1 val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedData1, ID3D12DeviceRemovedExtendedData>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D12DeviceRemovedExtendedData1 val)
            => Unsafe.As<ID3D12DeviceRemovedExtendedData1, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D12DeviceRemovedExtendedData1
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
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAutoBreadcrumbsOutput(DredAutoBreadcrumbsOutput* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAutoBreadcrumbsOutput(ref DredAutoBreadcrumbsOutput pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DredAutoBreadcrumbsOutput* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput*, int>)LpVtbl[3])(@this, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPageFaultAllocationOutput(DredPageFaultOutput* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPageFaultAllocationOutput(ref DredPageFaultOutput pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DredPageFaultOutput* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput*, int>)LpVtbl[4])(@this, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAutoBreadcrumbsOutput1(DredAutoBreadcrumbsOutput1* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAutoBreadcrumbsOutput1(ref DredAutoBreadcrumbsOutput1 pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DredAutoBreadcrumbsOutput1* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredAutoBreadcrumbsOutput1*, int>)LpVtbl[5])(@this, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPageFaultAllocationOutput1(DredPageFaultOutput1* pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutput);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutput);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutput);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPageFaultAllocationOutput1(ref DredPageFaultOutput1 pOutput)
        {
            var @this = (ID3D12DeviceRemovedExtendedData1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DredPageFaultOutput1* pOutputPtr = &pOutput)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutputPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutputPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D12DeviceRemovedExtendedData1*, DredPageFaultOutput1*, int>)LpVtbl[6])(@this, pOutputPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
