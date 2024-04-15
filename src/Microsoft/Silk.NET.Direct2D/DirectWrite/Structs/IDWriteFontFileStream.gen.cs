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

namespace Silk.NET.DirectWrite
{
    [Guid("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0")]
    [NativeName("Name", "IDWriteFontFileStream")]
    public unsafe partial struct IDWriteFontFileStream : IComVtbl<IDWriteFontFileStream>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6d4865fe-0ab8-4d91-8f62-5dd6be34a3e0");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFileStream val)
            => Unsafe.As<IDWriteFontFileStream, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFileStream
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
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] void** fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentContextPtr = &fragmentContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStart, fileOffset, fragmentSize, fragmentContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, void** fragmentContext)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentStartPtr = &fragmentStart)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ReadFileFragment([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in void* fragmentStart, ulong fileOffset, ulong fragmentSize, ref void* fragmentContext)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** fragmentStartPtr = &fragmentStart)
            {
                fixed (void** fragmentContextPtr = &fragmentContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void**, ulong, ulong, void**, int>)@this->LpVtbl[3])(@this, fragmentStartPtr, fileOffset, fragmentSize, fragmentContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void ReleaseFileFragment(void* fragmentContext)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContext);
        }

        /// <summary>To be documented.</summary>
        public readonly void ReleaseFileFragment<T0>(ref T0 fragmentContext) where T0 : unmanaged
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (void* fragmentContextPtr = &fragmentContext)
            {
                ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, void*, void>)@this->LpVtbl[4])(@this, fragmentContextPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileSize(ulong* fileSize)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileSize(ref ulong fileSize)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* fileSizePtr = &fileSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[5])(@this, fileSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTime(ulong* lastWriteTime)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastWriteTime(ref ulong lastWriteTime)
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileStream*, ulong*, int>)@this->LpVtbl[6])(@this, lastWriteTimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileStream*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
