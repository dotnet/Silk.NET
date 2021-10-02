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
    [Guid("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e")]
    [NativeName("Name", "ID3D11Linker")]
    public unsafe partial struct ID3D11Linker
    {
        public static readonly Guid Guid = new("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID3D11Linker val)
            => Unsafe.As<ID3D11Linker, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID3D11Linker
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
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, byte* pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                        {
                            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                            {
                                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, ref byte pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, ref byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, string pEntryName, string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pEntryName);
            var pTargetNamePtr = (byte*) Marshal.StringToHGlobalAnsi(pTargetName);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            Marshal.FreeHGlobal((nint)pTargetNamePtr);
            Marshal.FreeHGlobal((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UseLibrary(ID3D11ModuleInstance* pLibraryMI)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, int>)LpVtbl[4])(@this, pLibraryMI);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UseLibrary(ref ID3D11ModuleInstance pLibraryMI)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pLibraryMIPtr = &pLibraryMI)
            {
                ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, ID3D11ModuleInstance*, int>)LpVtbl[4])(@this, pLibraryMIPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ID3D11Linker*, uint, uint, int>)LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
            return ret;
        }

    }
}
