// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D.Compilers
{
    [NativeName("Name", "IDxcIncludeHandler")]
    public unsafe partial struct IDxcIncludeHandler
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(IDxcIncludeHandler val)
            => Unsafe.As<IDxcIncludeHandler, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public IDxcIncludeHandler
        (
            void** lpVtbl = default
        )
        {
            LpVtbl = lpVtbl;
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<IDxcIncludeHandler*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcIncludeHandler*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<IDxcIncludeHandler*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(char* pFilename, IDxcBlob** ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSource);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(char* pFilename, ref IDxcBlob* ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
                {
                    ret = ((delegate* cdecl<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilename, ppIncludeSourcePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(ref char pFilename, IDxcBlob** ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (char* pFilenamePtr = &pFilename)
                {
                    ret = ((delegate* cdecl<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(ref char pFilename, ref IDxcBlob* ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
                fixed (char* pFilenamePtr = &pFilename)
                {
                    fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
                    {
                        ret = ((delegate* cdecl<IDxcIncludeHandler*, char*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(string pFilename, IDxcBlob** ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
            var pFilenamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFilename);
                ret = ((delegate* cdecl<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSource);
            Marshal.FreeHGlobal((IntPtr)pFilenamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int LoadSource(string pFilename, ref IDxcBlob* ppIncludeSource)
        {
            fixed (IDxcIncludeHandler* @this = &this)
            {
                int ret = default;
            var pFilenamePtr = (byte*) Marshal.StringToHGlobalAnsi(pFilename);
                fixed (IDxcBlob** ppIncludeSourcePtr = &ppIncludeSource)
                {
                    ret = ((delegate* cdecl<IDxcIncludeHandler*, byte*, IDxcBlob**, int>)LpVtbl[3])(@this, pFilenamePtr, ppIncludeSourcePtr);
                }
            Marshal.FreeHGlobal((IntPtr)pFilenamePtr);
                return ret;
            }
        }

    }
}
