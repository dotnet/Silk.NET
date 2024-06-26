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
    [Guid("dc102f47-a12d-4b1c-822d-9e117e33043f")]
    [NativeName("Name", "IDWriteInMemoryFontFileLoader")]
    public unsafe partial struct IDWriteInMemoryFontFileLoader : IComVtbl<IDWriteInMemoryFontFileLoader>, IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("dc102f47-a12d-4b1c-822d-9e117e33043f");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileLoader(IDWriteInMemoryFontFileLoader val)
            => Unsafe.As<IDWriteInMemoryFontFileLoader, IDWriteFontFileLoader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteInMemoryFontFileLoader val)
            => Unsafe.As<IDWriteInMemoryFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteInMemoryFontFileLoader
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
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObject, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObjectPtr, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontData, fontDataSize, ownerObjectPtr, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontDataPtr = &fontData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObject, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObject, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObjectPtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(IDWriteFactory* factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontDataPtr = &fontData)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factory, fontDataPtr, fontDataSize, ownerObjectPtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObject, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObject, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObjectPtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontData, fontDataSize, ownerObjectPtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* fontDataPtr = &fontData)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObject, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, Silk.NET.Core.Native.IUnknown* ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* fontDataPtr = &fontData)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObject, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* fontDataPtr = &fontData)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObjectPtr, fontFile);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFactory* factoryPtr = &factory)
            {
                fixed (void* fontDataPtr = &fontData)
                {
                    fixed (Silk.NET.Core.Native.IUnknown* ownerObjectPtr = &ownerObject)
                    {
                        fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, IDWriteFactory*, void*, uint, Silk.NET.Core.Native.IUnknown*, IDWriteFontFile**, int>)@this->LpVtbl[4])(@this, factoryPtr, fontDataPtr, fontDataSize, ownerObjectPtr, fontFilePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFileCount()
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteInMemoryFontFileLoader*, uint>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStreamFromKey<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0, TI1, TI2>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref ComPtr<TI2> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI2>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, fontData, fontDataSize, ref ownerObject, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInMemoryFontFileReference<T0, TI0, TI1, TI2>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref ComPtr<TI2> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1> where TI2 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI2>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0, TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI1> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInMemoryFontFileReference<T0, TI0, TI1>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0, TI0>(ComPtr<TI0> factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFactory>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference((IDWriteFactory*) factory.Handle, in fontData, fontDataSize, ref ownerObject, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0, TI1>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInMemoryFontFileReference<T0, TI0, TI1>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileReference<T0, TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ComPtr<TI0> ownerObject, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, (Silk.NET.Core.Native.IUnknown*) ownerObject.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInMemoryFontFileReference<T0, TI0>(ref IDWriteFactory factory, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontData, uint fontDataSize, ref Silk.NET.Core.Native.IUnknown ownerObject, ref ComPtr<TI0> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileReference(ref factory, in fontData, fontDataSize, ref ownerObject, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteInMemoryFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
