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
    [Guid("d2c21b26-8350-4bdc-976a-331ce6f4c54c")]
    [NativeName("Name", "IDxcContainerReflection")]
    public unsafe partial struct IDxcContainerReflection
    {
        public static readonly Guid Guid = new("d2c21b26-8350-4bdc-976a-331ce6f4c54c");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcContainerReflection val)
            => Unsafe.As<IDxcContainerReflection, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcContainerReflection
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
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Load(IDxcBlob* pContainer)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainer);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainer);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainer);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Load(ref IDxcBlob pContainer)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob* pContainerPtr = &pContainer)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainerPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainerPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, IDxcBlob*, int>)LpVtbl[3])(@this, pContainerPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartCount(uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPartCount(ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint*, int>)LpVtbl[4])(@this, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartKind(uint idx, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPartKind(uint idx, ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[5])(@this, idx, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartContent(uint idx, IDxcBlob** ppResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartContent(uint idx, ref IDxcBlob* ppResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDxcBlob** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, IDxcBlob**, int>)LpVtbl[6])(@this, idx, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFirstPartKind(uint kind, uint* pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFirstPartKind(uint kind, ref uint pResult)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pResultPtr = &pResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, uint*, int>)LpVtbl[7])(@this, kind, pResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, Guid* iid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, Guid* iid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, ref Guid iid, void** ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPartReflection(uint idx, ref Guid iid, ref void* ppvObject)
        {
            var @this = (IDxcContainerReflection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcContainerReflection*, uint, Guid*, void**, int>)LpVtbl[8])(@this, idx, iidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

    }
}
