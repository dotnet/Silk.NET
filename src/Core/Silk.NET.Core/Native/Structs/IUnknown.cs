// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    public unsafe partial struct IUnknown
    {
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IUnknown* @this = &this)
            {
                return ((delegate* cdecl<IUnknown*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IUnknown* @this = &this)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    return ((delegate* cdecl<IUnknown*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IUnknown* @this = &this)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    return ((delegate* cdecl<IUnknown*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IUnknown* @this = &this)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        return ((delegate* cdecl<IUnknown*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IUnknown* @this = &this)
            {
                return ((delegate* cdecl<IUnknown*, uint>)LpVtbl[1])(@this);
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IUnknown* @this = &this)
            {
                return ((delegate* cdecl<IUnknown*, uint>)LpVtbl[2])(@this);
            }
        }
    }
}
