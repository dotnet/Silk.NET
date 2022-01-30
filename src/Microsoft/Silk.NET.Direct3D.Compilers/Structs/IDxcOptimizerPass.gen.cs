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
    [Guid("ae2cd79f-cc22-453f-9b6b-b124e7a5204c")]
    [NativeName("Name", "IDxcOptimizerPass")]
    public unsafe partial struct IDxcOptimizerPass
    {
        public static readonly Guid Guid = new("ae2cd79f-cc22-453f-9b6b-b124e7a5204c");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcOptimizerPass val)
            => Unsafe.As<IDxcOptimizerPass, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDxcOptimizerPass
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
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionName(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionName(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDescription(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgCount(uint* pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCount);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCount);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCount);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetOptionArgCount(ref uint pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCountPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCountPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCountPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResult);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResult);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResult);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResultPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResultPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResultPtr);
                }
            #endif
            }
            return ret;
        }

    }
}
