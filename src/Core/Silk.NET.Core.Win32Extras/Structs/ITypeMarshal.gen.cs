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

namespace Silk.NET.Core.Win32Extras
{
    [Guid("0000002d-0000-0000-c000-000000000046")]
    [NativeName("Name", "ITypeMarshal")]
    public unsafe partial struct ITypeMarshal : IComVtbl<ITypeMarshal>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("0000002d-0000-0000-c000-000000000046");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ITypeMarshal val)
            => Unsafe.As<ITypeMarshal, Silk.NET.Core.Native.IUnknown>(ref val);

        public ITypeMarshal
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
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size(void* pvType, uint dwDestContext, void* pvDestContext, uint* pSize)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContext, pSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size(void* pvType, uint dwDestContext, void* pvDestContext, ref uint pSize)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pSizePtr = &pSize)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContext, pSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint* pSize) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContextPtr, pSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, ref uint pSize) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvType, dwDestContext, pvDestContextPtr, pSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint* pSize) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContext, pSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, ref uint pSize) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (uint* pSizePtr = &pSize)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContext, pSizePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Size<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint* pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, pSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Size<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, ref uint pSize) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (uint* pSizePtr = &pSize)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint*, int>)@this->LpVtbl[3])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, pSizePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWrittenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pBufferPtr = &pBuffer)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
            SilkMarshal.Free((nint)pBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal(void* pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbWrittenPtr = &pcbWritten)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
            }
            SilkMarshal.Free((nint)pBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    fixed (uint* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(void* pvType, uint dwDestContext, ref T0 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvDestContextPtr = &pvDestContext)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvType, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWritten);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBuffer, pcbWrittenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    fixed (uint* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWritten);
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0>(ref T0 pvType, uint dwDestContext, void* pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                fixed (uint* pcbWrittenPtr = &pcbWritten)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContext, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                }
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, byte* pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWritten);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, byte* pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (uint* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBuffer, pcbWrittenPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, ref byte pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (byte* pBufferPtr = &pBuffer)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, ref byte pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
                    fixed (byte* pBufferPtr = &pBuffer)
                    {
                        fixed (uint* pcbWrittenPtr = &pcbWritten)
                        {
                            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWritten);
            SilkMarshal.Free((nint)pBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Marshal<T0, T1>(ref T0 pvType, uint dwDestContext, ref T1 pvDestContext, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbWritten) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (void* pvDestContextPtr = &pvDestContext)
                {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                    fixed (uint* pcbWrittenPtr = &pcbWritten)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, void*, uint, byte*, uint*, int>)@this->LpVtbl[4])(@this, pvTypePtr, dwDestContext, pvDestContextPtr, cbBufferLength, pBufferPtr, pcbWrittenPtr);
                    }
            SilkMarshal.Free((nint)pBufferPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, uint* pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBuffer, pcbRead);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, ref uint pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBuffer, pcbReadPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, uint* pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pBufferPtr = &pBuffer)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, ref uint pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pBufferPtr = &pBuffer)
            {
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
            SilkMarshal.Free((nint)pBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal(void* pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbRead)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbReadPtr = &pcbRead)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvType, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
            }
            SilkMarshal.Free((nint)pBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, uint* pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBuffer, pcbRead);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, byte* pBuffer, ref uint pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBuffer, pcbReadPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, uint* pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, ref byte pBuffer, ref uint pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                fixed (byte* pBufferPtr = &pBuffer)
                {
                    fixed (uint* pcbReadPtr = &pcbRead)
                    {
                        ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint* pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbRead);
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Unmarshal<T0>(ref T0 pvType, uint dwFlags, uint cbBufferLength, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, ref uint pcbRead) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
            var pBufferPtr = (byte*) SilkMarshal.StringToPtr(pBuffer, NativeStringEncoding.UTF8);
                fixed (uint* pcbReadPtr = &pcbRead)
                {
                    ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, uint, uint, byte*, uint*, int>)@this->LpVtbl[5])(@this, pvTypePtr, dwFlags, cbBufferLength, pBufferPtr, pcbReadPtr);
                }
            SilkMarshal.Free((nint)pBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Free(void* pvType)
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, int>)@this->LpVtbl[6])(@this, pvType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Free<T0>(ref T0 pvType) where T0 : unmanaged
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* pvTypePtr = &pvType)
            {
                ret = ((delegate* unmanaged[Cdecl]<ITypeMarshal*, void*, int>)@this->LpVtbl[6])(@this, pvTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ITypeMarshal*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
