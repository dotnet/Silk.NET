// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionName(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionName(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[3])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDescription(char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetDescription(ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, char**, int>)LpVtbl[4])(@this, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionArgCount(uint* pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCount);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int GetOptionArgCount(ref uint pCount)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (uint* pCountPtr = &pCount)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint*, int>)LpVtbl[5])(@this, pCountPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionArgName(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[6])(@this, argIndex, ppResultPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, char** ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResult);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int GetOptionArgDescription(uint argIndex, ref char* ppResult)
        {
            var @this = (IDxcOptimizerPass*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char** ppResultPtr = &ppResult)
            {
                ret = ((delegate* unmanaged[Cdecl]<IDxcOptimizerPass*, uint, char**, int>)LpVtbl[7])(@this, argIndex, ppResultPtr);
            }
            return ret;
        }

    }
}
