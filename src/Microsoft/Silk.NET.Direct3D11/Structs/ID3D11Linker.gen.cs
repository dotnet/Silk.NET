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
    public unsafe partial struct ID3D11Linker : IComVtbl<ID3D11Linker>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("59a6cd0e-e10d-4c1f-88c0-63aba1daf30e");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

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
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pEntryNamePtr = &pEntryName)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            fixed (byte* pTargetNamePtr = &pTargetName)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ID3D11ModuleInstance* pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
            fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntry, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                }
            }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryName, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
                    fixed (byte* pTargetNamePtr = &pTargetName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
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
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
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
                                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
            SilkMarshal.Free((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
            SilkMarshal.Free((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
                fixed (byte* pEntryNamePtr = &pEntryName)
                {
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
            SilkMarshal.Free((nint)pTargetNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetName, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                    }
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                    }
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
                fixed (byte* pTargetNamePtr = &pTargetName)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                    {
                        fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                        }
                    }
                }
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBuffer);
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, Silk.NET.Core.Native.ID3D10Blob** ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlob, ppErrorBufferPtr);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, Silk.NET.Core.Native.ID3D10Blob** ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBuffer);
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pEntryPtr = &pEntry)
            {
            var pEntryNamePtr = (byte*) SilkMarshal.StringToPtr(pEntryName, NativeStringEncoding.LPStr);
            var pTargetNamePtr = (byte*) SilkMarshal.StringToPtr(pTargetName, NativeStringEncoding.LPStr);
                fixed (Silk.NET.Core.Native.ID3D10Blob** ppShaderBlobPtr = &ppShaderBlob)
                {
                    fixed (Silk.NET.Core.Native.ID3D10Blob** ppErrorBufferPtr = &ppErrorBuffer)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, byte*, byte*, uint, Silk.NET.Core.Native.ID3D10Blob**, Silk.NET.Core.Native.ID3D10Blob**, int>)@this->LpVtbl[3])(@this, pEntryPtr, pEntryNamePtr, pTargetNamePtr, uFlags, ppShaderBlobPtr, ppErrorBufferPtr);
                    }
                }
            SilkMarshal.Free((nint)pTargetNamePtr);
            SilkMarshal.Free((nint)pEntryNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UseLibrary(ID3D11ModuleInstance* pLibraryMI)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMI);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UseLibrary(ref ID3D11ModuleInstance pLibraryMI)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID3D11ModuleInstance* pLibraryMIPtr = &pLibraryMI)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, ID3D11ModuleInstance*, int>)@this->LpVtbl[4])(@this, pLibraryMIPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddClipPlaneFromCBuffer(uint uCBufferSlot, uint uCBufferEntry)
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID3D11Linker*, uint, uint, int>)@this->LpVtbl[5])(@this, uCBufferSlot, uCBufferEntry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1, TI2>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref ComPtr<TI2> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI2>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI1> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ComPtr<TI0> pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link((ID3D11ModuleInstance*) pEntry.Handle, pEntryName, pTargetName, uFlags, ref ppShaderBlob, ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, in pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, in pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Link<TI0, TI1>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref ComPtr<TI1> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI1>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref ComPtr<TI0> ppShaderBlob, ref Silk.NET.Core.Native.ID3D10Blob* ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, (Silk.NET.Core.Native.ID3D10Blob**) ppShaderBlob.GetAddressOf(), ref ppErrorBuffer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Link<TI0>(ref ID3D11ModuleInstance pEntry, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pEntryName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPStr)] string pTargetName, uint uFlags, ref Silk.NET.Core.Native.ID3D10Blob* ppShaderBlob, ref ComPtr<TI0> ppErrorBuffer) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.ID3D10Blob>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Link(ref pEntry, pEntryName, pTargetName, uFlags, ref ppShaderBlob, (Silk.NET.Core.Native.ID3D10Blob**) ppErrorBuffer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int UseLibrary<TI0>(ComPtr<TI0> pLibraryMI) where TI0 : unmanaged, IComVtbl<ID3D11ModuleInstance>, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UseLibrary((ID3D11ModuleInstance*) pLibraryMI.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID3D11Linker*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
