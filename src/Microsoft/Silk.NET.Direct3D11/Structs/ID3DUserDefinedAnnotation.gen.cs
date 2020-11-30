// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab")]
    [NativeName("Name", "ID3DUserDefinedAnnotation")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3DUserDefinedAnnotation val)
            => Unsafe.As<ID3DUserDefinedAnnotation, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3DUserDefinedAnnotation
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
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int BeginEvent(char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, Name);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BeginEvent(ref char Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (char* NamePtr = &Name)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, NamePtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int BeginEvent(string Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, byte*, int>)LpVtbl[3])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly int EndEvent()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, int>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void SetMarker(char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, Name);
        }

        /// <summary>To be added.</summary>
        public readonly void SetMarker(ref char Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* NamePtr = &Name)
            {
                ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, NamePtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void SetMarker(string Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var NamePtr = (byte*) Marshal.StringToHGlobalAnsi(Name);
            ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, byte*, void>)LpVtbl[5])(@this, NamePtr);
            Marshal.FreeHGlobal((IntPtr)NamePtr);
        }

        /// <summary>To be added.</summary>
        public readonly int GetStatus()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, int>)LpVtbl[6])(@this);
            return ret;
        }

    }
}
