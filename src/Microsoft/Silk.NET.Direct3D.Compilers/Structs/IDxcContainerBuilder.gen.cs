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
    [Guid("334b1f50-2292-4b35-99a1-25588d8c17fe")]
    [NativeName("Name", "IDxcContainerBuilder")]
    public unsafe partial struct IDxcContainerBuilder
    {
        public static readonly Guid Guid = new("334b1f50-2292-4b35-99a1-25588d8c17fe");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerBuilder val)
            => Unsafe.As<IDxcContainerBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerBuilder
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
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pDxilContainerHeader)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeader);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeader);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeader);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pDxilContainerHeader)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pDxilContainerHeaderPtr = &pDxilContainerHeader)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeaderPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeaderPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcBlob*, int>)LpVtbl[3])(@this, pDxilContainerHeaderPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPart(uint fourCC, IDxcBlob* pSource)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSource);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSource);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSource);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddPart(uint fourCC, ref IDxcBlob pSource)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pSourcePtr = &pSource)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSourcePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSourcePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, IDxcBlob*, int>)LpVtbl[4])(@this, fourCC, pSourcePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemovePart(uint fourCC)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerBuilder*, uint, int>)LpVtbl[5])(@this, fourCC);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, uint, int>)LpVtbl[5])(@this, fourCC);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, uint, int>)LpVtbl[5])(@this, fourCC);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeContainer(IDxcOperationResult** ppResult)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SerializeContainer(ref IDxcOperationResult* ppResult)
        {
            var @this = (IDxcContainerBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcOperationResult** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerBuilder*, IDxcOperationResult**, int>)LpVtbl[6])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
