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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "ID3DUserDefinedAnnotation")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DUserDefinedAnnotation val)
            => Unsafe.As<ID3DUserDefinedAnnotation, Silk.NET.Core.Native.IUnknown>(ref val);

        public readonly ref Silk.NET.Core.Native.IUnknown AsUnknown()
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                return ref *(Silk.NET.Core.Native.IUnknown*)@this;
            }
        }

        public ID3DUserDefinedAnnotation
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
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvObjectPtr = &ppvObject)
                    {
                        ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint AddRef()
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, uint>)LpVtbl[1])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public uint Release()
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                uint ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, uint>)LpVtbl[2])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe int BeginEvent(char* Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, Name);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BeginEvent(ref char Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                fixed (char* NamePtr = &Name)
                {
                    ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, NamePtr);
                }
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int BeginEvent(string Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, byte*, int>)LpVtbl[3])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public int EndEvent()
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, int>)LpVtbl[4])(@this);
                return ret;
            }
        }

        /// <summary>To be added.</summary>
        public unsafe void SetMarker(char* Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                ((delegate* cdecl<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, Name);
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker(ref char Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                fixed (char* NamePtr = &Name)
                {
                    ((delegate* cdecl<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, NamePtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public void SetMarker(string Name)
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
                ((delegate* cdecl<ID3DUserDefinedAnnotation*, byte*, void>)LpVtbl[5])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            }
        }

        /// <summary>To be added.</summary>
        public int GetStatus()
        {
            fixed (ID3DUserDefinedAnnotation* @this = &this)
            {
                int ret = default;
                ret = ((delegate* cdecl<ID3DUserDefinedAnnotation*, int>)LpVtbl[6])(@this);
                return ret;
            }
        }

    }
}
