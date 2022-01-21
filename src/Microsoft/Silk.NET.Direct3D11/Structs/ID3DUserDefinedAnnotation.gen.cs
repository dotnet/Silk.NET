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

namespace Silk.NET.Direct3D11
{
    [Guid("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab")]
    [NativeName("Name", "ID3DUserDefinedAnnotation")]
    public unsafe partial struct ID3DUserDefinedAnnotation
    {
        public static readonly Guid Guid = new("b2daad8b-03d4-4dbf-95eb-32ab4b63d0ab");

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
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginEvent(char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, Name);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, Name);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginEvent(ref char Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, NamePtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, int>)LpVtbl[3])(@this, NamePtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginEvent([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<ID3DUserDefinedAnnotation*, byte*, int>)LpVtbl[3])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, int>)LpVtbl[3])(@this, NamePtr);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, byte*, int>)LpVtbl[3])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndEvent()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetMarker(char* Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, Name);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, Name);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, Name);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker(ref char Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* NamePtr = &Name)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, NamePtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, NamePtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, char*, void>)LpVtbl[5])(@this, NamePtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetMarker([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string Name)
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var NamePtr = (byte*) SilkMarshal.StringToPtr(Name, NativeStringEncoding.LPWStr);
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<ID3DUserDefinedAnnotation*, byte*, void>)LpVtbl[5])(@this, NamePtr);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, byte*, void>)LpVtbl[5])(@this, NamePtr);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<ID3DUserDefinedAnnotation*, byte*, void>)LpVtbl[5])(@this, NamePtr);
            }
            #endif
            SilkMarshal.Free((nint)NamePtr);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetStatus()
        {
            var @this = (ID3DUserDefinedAnnotation*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3DUserDefinedAnnotation*, int>)LpVtbl[6])(@this);
            return ret;
        }

    }
}
