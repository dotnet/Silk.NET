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
    [Guid("727cad4e-d6af-4c9e-8a08-d695b11caa49")]
    [NativeName("Name", "IDWriteFontFileLoader")]
    public unsafe partial struct IDWriteFontFileLoader : IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("727cad4e-d6af-4c9e-8a08-d695b11caa49");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFileLoader val)
            => Unsafe.As<IDWriteFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFileLoader
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
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream)
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStreamFromKey<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
