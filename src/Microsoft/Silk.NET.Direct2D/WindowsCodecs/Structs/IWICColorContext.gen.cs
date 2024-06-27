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

namespace Silk.NET.WindowsCodecs
{
    [Guid("3c613a02-34b2-44ea-9a7c-45aea9c6fd6d")]
    [NativeName("Name", "IWICColorContext")]
    public unsafe partial struct IWICColorContext : IComVtbl<IWICColorContext>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("3c613a02-34b2-44ea-9a7c-45aea9c6fd6d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICColorContext val)
            => Unsafe.As<IWICColorContext, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICColorContext
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
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitializeFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, char*, int>)@this->LpVtbl[3])(@this, wzFilename);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, char*, int>)@this->LpVtbl[3])(@this, wzFilenamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, int>)@this->LpVtbl[3])(@this, wzFilenamePtr);
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InitializeFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pbBuffer, uint cbBufferSize)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBuffer, cbBufferSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pbBuffer, uint cbBufferSize)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBufferPtr, cbBufferSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromMemory([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, uint cbBufferSize)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, byte*, uint, int>)@this->LpVtbl[4])(@this, pbBufferPtr, cbBufferSize);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InitializeFromExifColorSpace(uint value)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, int>)@this->LpVtbl[5])(@this, value);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetType(ColorContextType* pType)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, ColorContextType*, int>)@this->LpVtbl[6])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetType(ref ColorContextType pType)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ColorContextType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, ColorContextType*, int>)@this->LpVtbl[6])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProfileBytes(uint cbBuffer, byte* pbBuffer, uint* pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBuffer, pcbActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProfileBytes(uint cbBuffer, byte* pbBuffer, ref uint pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBuffer, pcbActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProfileBytes(uint cbBuffer, ref byte pbBuffer, uint* pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProfileBytes(uint cbBuffer, ref byte pbBuffer, ref uint pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetProfileBytes(uint cbBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, uint* pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActual);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetProfileBytes(uint cbBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref uint pcbActual)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint, byte*, uint*, int>)@this->LpVtbl[7])(@this, cbBuffer, pbBufferPtr, pcbActualPtr);
            }
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetExifColorSpace(uint* pValue)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)@this->LpVtbl[8])(@this, pValue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetExifColorSpace(ref uint pValue)
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pValuePtr = &pValue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICColorContext*, uint*, int>)@this->LpVtbl[8])(@this, pValuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICColorContext*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
