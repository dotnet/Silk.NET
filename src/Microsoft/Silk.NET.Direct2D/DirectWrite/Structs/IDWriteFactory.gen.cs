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
    [Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48")]
    [NativeName("Name", "IDWriteFactory")]
    public unsafe partial struct IDWriteFactory : IComVtbl<IDWriteFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b859ee5a-d838-4b5b-a2e8-1adc7d93db48");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFactory val)
            => Unsafe.As<IDWriteFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFactory
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
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontCollection(IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontCollection(ref IDWriteFontCollection* fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollectionPtr, checkForUpdates);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontCollectionLoader(ref IDWriteFontCollectionLoader fontCollectionLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontCollectionLoader(ref IDWriteFontCollectionLoader fontCollectionLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
                }
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFace);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                fixed (IDWriteFontFace** fontFacePtr = &fontFace)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderingParams(ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMonitorRenderingParams(nint monitor, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMonitorRenderingParams(nint monitor, ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontFileLoader(ref IDWriteFontFileLoader fontFileLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontFileLoader(ref IDWriteFontFileLoader fontFileLoader)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypography(IDWriteTypography** typography)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypography(ref IDWriteTypography* typography)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTypography** typographyPtr = &typography)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typographyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiInterop(ref IDWriteGdiInterop* gdiInterop)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteGdiInterop** gdiInteropPtr = &gdiInterop)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInteropPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Matrix* transformPtr = &transform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Matrix* transformPtr = &transform)
                    {
                        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(ref IDWriteTextFormat textFormat, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(ref IDWriteTextFormat textFormat, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextAnalyzer(ref IDWriteTextAnalyzer* textAnalyzer)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalyzer** textAnalyzerPtr = &textAnalyzer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitutionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSystemFontCollection<TI0>(ref ComPtr<TI0> fontCollection, Silk.NET.Core.Bool32 checkForUpdates) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSystemFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf(), checkForUpdates);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0, TI1>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, ref fontCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontCollection<T0, TI0, TI1>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0, TI0>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, ref fontCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection(ref collectionLoader, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontCollection<T0, TI0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection(ref collectionLoader, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontCollectionLoader<TI0>(ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontCollectionLoader<TI0>(ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnregisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(in filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(in filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontFileReference<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontFileReference<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0, TI1>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI1> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace<TI0>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, ref fontFace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace<TI0>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, in fontFiles, faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRenderingParams<TI0>(ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRenderingParams((IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMonitorRenderingParams<TI0>(nint monitor, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMonitorRenderingParams(monitor, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomRenderingParams<TI0>(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomRenderingParams(gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontFileLoader<TI0>(ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontFileLoader<TI0>(ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnregisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTypography<TI0>(ref ComPtr<TI0> typography) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTypography((IDWriteTypography**) typography.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiInterop<TI0>(ref ComPtr<TI0> gdiInterop) where TI0 : unmanaged, IComVtbl<IDWriteGdiInterop>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiInterop((IDWriteGdiInterop**) gdiInterop.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipsisTrimmingSign<TI0, TI1>(ComPtr<TI0> textFormat, ref ComPtr<TI1> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign<TI0>(ComPtr<TI0> textFormat, ref IDWriteInlineObject* trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, ref trimmingSign);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipsisTrimmingSign<TI0>(ref IDWriteTextFormat textFormat, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign(ref textFormat, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextAnalyzer<TI0>(ref ComPtr<TI0> textAnalyzer) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalyzer>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextAnalyzer((IDWriteTextAnalyzer**) textAnalyzer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, in localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
