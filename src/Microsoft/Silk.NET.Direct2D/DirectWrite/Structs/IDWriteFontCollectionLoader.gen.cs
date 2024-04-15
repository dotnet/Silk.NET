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
    [Guid("cca920e4-52f0-492b-bfa8-29c72ee0a468")]
    [NativeName("Name", "IDWriteFontCollectionLoader")]
    public unsafe partial struct IDWriteFontCollectionLoader : IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("cca920e4-52f0-492b-bfa8-29c72ee0a468");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontCollectionLoader val)
            => Unsafe.As<IDWriteFontCollectionLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontCollectionLoader
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
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKey, collectionKeySize, fontFileEnumerator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKey, collectionKeySize, fontFileEnumeratorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKeyPtr, collectionKeySize, fontFileEnumerator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factory, collectionKeyPtr, collectionKeySize, fontFileEnumeratorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKey, collectionKeySize, fontFileEnumerator);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator)
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKey, collectionKeySize, fontFileEnumeratorPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator) where T0 : unmanaged
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKeyPtr, collectionKeySize, fontFileEnumerator);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    fixed (IDWriteFontFileEnumerator** fontFileEnumeratorPtr = &fontFileEnumerator)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)@this->LpVtbl[3])(@this, factoryPtr, collectionKeyPtr, collectionKeySize, fontFileEnumeratorPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<TI0>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, collectionKey, collectionKeySize, ref fontFileEnumerator);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEnumeratorFromKey<T0, TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, in collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<T0, TI0>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref IDWriteFontFileEnumerator* fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey((IDWriteFactory*) factory.Handle, in collectionKey, collectionKeySize, ref fontFileEnumerator);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEnumeratorFromKey<TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontFileEnumerator) where TI0 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey(ref factory, collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEnumeratorFromKey<T0, TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontFileEnumerator) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEnumeratorFromKey(ref factory, in collectionKey, collectionKeySize, (IDWriteFontFileEnumerator**) fontFileEnumerator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollectionLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
