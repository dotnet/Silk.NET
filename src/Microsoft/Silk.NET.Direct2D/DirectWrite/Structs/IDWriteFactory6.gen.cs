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
    [Guid("f3744d80-21f7-42eb-b35d-995bc72fc223")]
    [NativeName("Name", "IDWriteFactory6")]
    public unsafe partial struct IDWriteFactory6 : IComVtbl<IDWriteFactory6>, IComVtbl<IDWriteFactory5>, IComVtbl<IDWriteFactory4>, IComVtbl<IDWriteFactory3>, IComVtbl<IDWriteFactory2>, IComVtbl<IDWriteFactory1>, IComVtbl<IDWriteFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("f3744d80-21f7-42eb-b35d-995bc72fc223");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFactory5(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory5>(ref val);

        public static implicit operator IDWriteFactory4(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory4>(ref val);

        public static implicit operator IDWriteFactory3(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory3>(ref val);

        public static implicit operator IDWriteFactory2(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory2>(ref val);

        public static implicit operator IDWriteFactory1(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory1>(ref val);

        public static implicit operator IDWriteFactory(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, IDWriteFactory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFactory6 val)
            => Unsafe.As<IDWriteFactory6, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFactory6
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
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontCollection(IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollection, checkForUpdates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontCollection(ref IDWriteFontCollection* fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[3])(@this, fontCollectionPtr, checkForUpdates);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKey, collectionKeySize, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(IDWriteFontCollectionLoader* collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* collectionKeyPtr = &collectionKey)
            {
                fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoader, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKey, collectionKeySize, fontCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, IDWriteFontCollection** fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollection);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* collectionLoaderPtr = &collectionLoader)
            {
                fixed (void* collectionKeyPtr = &collectionKey)
                {
                    fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, void*, uint, IDWriteFontCollection**, int>)@this->LpVtbl[4])(@this, collectionLoaderPtr, collectionKeyPtr, collectionKeySize, fontCollectionPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontCollectionLoader(ref IDWriteFontCollectionLoader fontCollectionLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[5])(@this, fontCollectionLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontCollectionLoader(IDWriteFontCollectionLoader* fontCollectionLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontCollectionLoader(ref IDWriteFontCollectionLoader fontCollectionLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollectionLoader* fontCollectionLoaderPtr = &fontCollectionLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollectionLoader*, int>)@this->LpVtbl[6])(@this, fontCollectionLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTime, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePath, lastWriteTimePtr, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFile);
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTime, fontFilePtr);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFile);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, IDWriteFontFile**, int>)@this->LpVtbl[7])(@this, filePathPtr, lastWriteTimePtr, fontFilePtr);
                }
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFile);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFile);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileLoader* fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoader, fontFilePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, IDWriteFontFile** fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFile);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
                {
                    fixed (IDWriteFontFile** fontFilePtr = &fontFile)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, IDWriteFontFileLoader*, IDWriteFontFile**, int>)@this->LpVtbl[8])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileLoaderPtr, fontFilePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFace);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IDWriteFontFile** fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace** fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFiles, faceIndex, fontFaceSimulationFlags, fontFacePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, IDWriteFontFace** fontFace)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFace);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile** fontFilesPtr = &fontFiles)
            {
                fixed (IDWriteFontFace** fontFacePtr = &fontFace)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, FontFaceType, uint, IDWriteFontFile**, uint, FontSimulations, IDWriteFontFace**, int>)@this->LpVtbl[9])(@this, fontFaceType, numberOfFiles, fontFilesPtr, faceIndex, fontFaceSimulationFlags, fontFacePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderingParams(IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRenderingParams(ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteRenderingParams**, int>)@this->LpVtbl[10])(@this, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMonitorRenderingParams(nint monitor, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMonitorRenderingParams(nint monitor, ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, nint, IDWriteRenderingParams**, int>)@this->LpVtbl[11])(@this, monitor, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, IDWriteRenderingParams** renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParams);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref IDWriteRenderingParams* renderingParams)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRenderingParams** renderingParamsPtr = &renderingParams)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, float, PixelGeometry, RenderingMode, IDWriteRenderingParams**, int>)@this->LpVtbl[12])(@this, gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, renderingParamsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int RegisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontFileLoader(ref IDWriteFontFileLoader fontFileLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[13])(@this, fontFileLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnregisterFontFileLoader(IDWriteFontFileLoader* fontFileLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontFileLoader(ref IDWriteFontFileLoader fontFileLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileLoader* fontFileLoaderPtr = &fontFileLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFileLoader*, int>)@this->LpVtbl[14])(@this, fontFileLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyName, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* fontFamilyNamePtr = &fontFamilyName)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, IDWriteFontCollection* fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormat);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeName, textFormatPtr);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, char*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, IDWriteTextFormat** textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormat);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var fontFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(fontFamilyName, NativeStringEncoding.UTF8);
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (IDWriteTextFormat** textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, IDWriteFontCollection*, FontWeight, FontStyle, FontStretch, float, byte*, IDWriteTextFormat**, int>)@this->LpVtbl[15])(@this, fontFamilyNamePtr, fontCollectionPtr, fontWeight, fontStyle, fontStretch, fontSize, localeNamePtr, textFormatPtr);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            SilkMarshal.Free((nint)fontFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypography(IDWriteTypography** typography)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typography);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTypography(ref IDWriteTypography* typography)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTypography** typographyPtr = &typography)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTypography**, int>)@this->LpVtbl[16])(@this, typographyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiInterop(IDWriteGdiInterop** gdiInterop)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInterop);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGdiInterop(ref IDWriteGdiInterop* gdiInterop)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteGdiInterop** gdiInteropPtr = &gdiInterop)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteGdiInterop**, int>)@this->LpVtbl[17])(@this, gdiInteropPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @string, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayout);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormat, maxWidth, maxHeight, textLayoutPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, IDWriteTextLayout**, int>)@this->LpVtbl[18])(@this, @stringPtr, stringLength, textFormatPtr, maxWidth, maxHeight, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @string, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Matrix* transformPtr = &transform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Matrix* transformPtr = &transform)
                    {
                        fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormat, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayout);
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, textLayoutPtr);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, IDWriteTextLayout** textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayout);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteTextLayout** textLayoutPtr = &textLayout)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, uint, IDWriteTextFormat*, float, float, float, Matrix*, Silk.NET.Core.Bool32, IDWriteTextLayout**, int>)@this->LpVtbl[19])(@this, @stringPtr, stringLength, textFormatPtr, layoutWidth, layoutHeight, pixelsPerDip, transformPtr, useGdiNatural, textLayoutPtr);
                    }
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSign);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(IDWriteTextFormat* textFormat, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormat, trimmingSignPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(ref IDWriteTextFormat textFormat, IDWriteInlineObject** trimmingSign)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSign);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign(ref IDWriteTextFormat textFormat, ref IDWriteInlineObject* trimmingSign)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (IDWriteInlineObject** trimmingSignPtr = &trimmingSign)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextFormat*, IDWriteInlineObject**, int>)@this->LpVtbl[20])(@this, textFormatPtr, trimmingSignPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextAnalyzer(IDWriteTextAnalyzer** textAnalyzer)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextAnalyzer(ref IDWriteTextAnalyzer* textAnalyzer)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteTextAnalyzer** textAnalyzerPtr = &textAnalyzer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteTextAnalyzer**, int>)@this->LpVtbl[21])(@this, textAnalyzerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeName, ignoreUserOverride, numberSubstitutionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, char*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitution);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (IDWriteNumberSubstitution** numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, NumberSubstitutionMethod, byte*, Silk.NET.Core.Bool32, IDWriteNumberSubstitution**, int>)@this->LpVtbl[22])(@this, substitutionMethod, localeNamePtr, ignoreUserOverride, numberSubstitutionPtr);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* transformPtr = &transform)
            {
                fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRun, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, IDWriteGlyphRunAnalysis** glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysis);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref IDWriteGlyphRunAnalysis* glyphRunAnalysis)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* transformPtr = &transform)
                {
                    fixed (IDWriteGlyphRunAnalysis** glyphRunAnalysisPtr = &glyphRunAnalysis)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, float, Matrix*, RenderingMode, MeasuringMode, float, float, IDWriteGlyphRunAnalysis**, int>)@this->LpVtbl[23])(@this, glyphRunPtr, pixelsPerDip, transformPtr, renderingMode, measuringMode, baselineOriginX, baselineOriginY, glyphRunAnalysisPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEudcFontCollection(IDWriteFontCollection** fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollection, checkForUpdates);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEudcFontCollection(ref IDWriteFontCollection* fontCollection, Silk.NET.Core.Bool32 checkForUpdates)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontCollection**, Silk.NET.Core.Bool32, int>)@this->LpVtbl[24])(@this, fontCollectionPtr, checkForUpdates);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontFallback(ref IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallback** fontFallbackPtr = &fontFallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallback**, int>)@this->LpVtbl[26])(@this, fontFallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallbackBuilder(IDWriteFontFallbackBuilder** fontFallbackBuilder)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallbackBuilder(ref IDWriteFontFallbackBuilder* fontFallbackBuilder)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallbackBuilder** fontFallbackBuilderPtr = &fontFallbackBuilder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFallbackBuilder**, int>)@this->LpVtbl[27])(@this, fontFallbackBuilderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRun, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                {
                    fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescription, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayers);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransform, colorPaletteIndex, colorLayersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, IDWriteColorGlyphRunEnumerator** colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayers);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref IDWriteColorGlyphRunEnumerator* colorLayers)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (GlyphRunDescription* glyphRunDescriptionPtr = &glyphRunDescription)
                {
                    fixed (Matrix* worldToDeviceTransformPtr = &worldToDeviceTransform)
                    {
                        fixed (IDWriteColorGlyphRunEnumerator** colorLayersPtr = &colorLayers)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, float, float, GlyphRun*, GlyphRunDescription*, MeasuringMode, Matrix*, uint, IDWriteColorGlyphRunEnumerator**, int>)@this->LpVtbl[28])(@this, baselineOriginX, baselineOriginY, glyphRunPtr, glyphRunDescriptionPtr, measuringMode, worldToDeviceTransformPtr, colorPaletteIndex, colorLayersPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTime, faceIndex, fontSimulations, fontFaceReferencePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReference);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePath, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReferencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTime, faceIndex, fontSimulations, fontFaceReferencePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReference);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReferencePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTime, faceIndex, fontSimulations, fontFaceReference);
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTime, faceIndex, fontSimulations, fontFaceReferencePtr);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, IDWriteFontFaceReference** fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReference);
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref IDWriteFontFaceReference* fontFaceReference)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                fixed (IDWriteFontFaceReference** fontFaceReferencePtr = &fontFaceReference)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, Silk.NET.Core.Win32Extras.Filetime*, uint, FontSimulations, IDWriteFontFaceReference**, int>)@this->LpVtbl[34])(@this, filePathPtr, lastWriteTimePtr, faceIndex, fontSimulations, fontFaceReferencePtr);
                }
            }
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontSet(IDWriteFontSet** fontSet)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet**, int>)@this->LpVtbl[35])(@this, fontSet);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSystemFontSet(ref IDWriteFontSet* fontSet)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet** fontSetPtr = &fontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet**, int>)@this->LpVtbl[35])(@this, fontSetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontSetBuilder(IDWriteFontSetBuilder** fontSetBuilder)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder**, int>)@this->LpVtbl[36])(@this, fontSetBuilder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontSetBuilder(ref IDWriteFontSetBuilder* fontSetBuilder)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSetBuilder** fontSetBuilderPtr = &fontSetBuilder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSetBuilder**, int>)@this->LpVtbl[36])(@this, fontSetBuilderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, IDWriteFontCollection1** fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSet, fontCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet(IDWriteFontSet* fontSet, ref IDWriteFontCollection1* fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection1** fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSet, fontCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet(ref IDWriteFontSet fontSet, IDWriteFontCollection1** fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet* fontSetPtr = &fontSet)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSetPtr, fontCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet(ref IDWriteFontSet fontSet, ref IDWriteFontCollection1* fontCollection)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontSet* fontSetPtr = &fontSet)
            {
                fixed (IDWriteFontCollection1** fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontSet*, IDWriteFontCollection1**, int>)@this->LpVtbl[37])(@this, fontSetPtr, fontCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontDownloadQueue(IDWriteFontDownloadQueue** fontDownloadQueue)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontDownloadQueue**, int>)@this->LpVtbl[39])(@this, fontDownloadQueue);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontDownloadQueue(ref IDWriteFontDownloadQueue* fontDownloadQueue)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontDownloadQueue** fontDownloadQueuePtr = &fontDownloadQueue)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontDownloadQueue**, int>)@this->LpVtbl[39])(@this, fontDownloadQueuePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, ref Silk.NET.Maths.Vector2D<float> glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* glyphOriginsPtr = &glyphOrigins)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOriginsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* worldAndDpiTransformPtr = &worldAndDpiTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransformPtr, glyphOrigins);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldAndDpiTransform, ref Silk.NET.Maths.Vector2D<float> glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Matrix* worldAndDpiTransformPtr = &worldAndDpiTransform)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* glyphOriginsPtr = &glyphOrigins)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRun, measuringMode, baselineOrigin, worldAndDpiTransformPtr, glyphOriginsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRunPtr, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOrigins);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldAndDpiTransform, ref Silk.NET.Maths.Vector2D<float> glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* glyphOriginsPtr = &glyphOrigins)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRunPtr, measuringMode, baselineOrigin, worldAndDpiTransform, glyphOriginsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldAndDpiTransform, Silk.NET.Maths.Vector2D<float>* glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* worldAndDpiTransformPtr = &worldAndDpiTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRunPtr, measuringMode, baselineOrigin, worldAndDpiTransformPtr, glyphOrigins);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ComputeGlyphOrigins([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, MeasuringMode measuringMode, Silk.NET.Maths.Vector2D<float> baselineOrigin, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldAndDpiTransform, ref Silk.NET.Maths.Vector2D<float> glyphOrigins)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Matrix* worldAndDpiTransformPtr = &worldAndDpiTransform)
                {
                    fixed (Silk.NET.Maths.Vector2D<float>* glyphOriginsPtr = &glyphOrigins)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, GlyphRun*, MeasuringMode, Silk.NET.Maths.Vector2D<float>, Matrix*, Silk.NET.Maths.Vector2D<float>*, int>)@this->LpVtbl[42])(@this, glyphRunPtr, measuringMode, baselineOrigin, worldAndDpiTransformPtr, glyphOriginsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileLoader(IDWriteInMemoryFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteInMemoryFontFileLoader**, int>)@this->LpVtbl[44])(@this, newLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInMemoryFontFileLoader(ref IDWriteInMemoryFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteInMemoryFontFileLoader** newLoaderPtr = &newLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteInMemoryFontFileLoader**, int>)@this->LpVtbl[44])(@this, newLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeaders, newLoader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeaders, newLoaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* extraHeadersPtr = &extraHeaders)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeadersPtr, newLoader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* extraHeadersPtr = &extraHeaders)
            {
                fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeadersPtr, newLoaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeadersPtr, newLoader);
            SilkMarshal.Free((nint)extraHeadersPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
            fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrl, extraHeadersPtr, newLoaderPtr);
            }
            SilkMarshal.Free((nint)extraHeadersPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeaders, newLoader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
                fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeaders, newLoaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
                fixed (char* extraHeadersPtr = &extraHeaders)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
                fixed (char* extraHeadersPtr = &extraHeaders)
                {
                    fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoader);
            SilkMarshal.Free((nint)extraHeadersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* referrerUrlPtr = &referrerUrl)
            {
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
                fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, char*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoaderPtr);
                }
            SilkMarshal.Free((nint)extraHeadersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeaders, newLoader);
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeaders, newLoaderPtr);
            }
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            fixed (char* extraHeadersPtr = &extraHeaders)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoader);
            }
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            fixed (char* extraHeadersPtr = &extraHeaders)
            {
                fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, char*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoaderPtr);
                }
            }
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, IDWriteRemoteFontFileLoader** newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoader);
            SilkMarshal.Free((nint)extraHeadersPtr);
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref IDWriteRemoteFontFileLoader* newLoader)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var referrerUrlPtr = (byte*) SilkMarshal.StringToPtr(referrerUrl, NativeStringEncoding.UTF8);
            var extraHeadersPtr = (byte*) SilkMarshal.StringToPtr(extraHeaders, NativeStringEncoding.UTF8);
            fixed (IDWriteRemoteFontFileLoader** newLoaderPtr = &newLoader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, byte*, byte*, IDWriteRemoteFontFileLoader**, int>)@this->LpVtbl[45])(@this, referrerUrlPtr, extraHeadersPtr, newLoaderPtr);
            }
            SilkMarshal.Free((nint)extraHeadersPtr);
            SilkMarshal.Free((nint)referrerUrlPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ContainerType AnalyzeContainerType([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ContainerType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, ContainerType>)@this->LpVtbl[46])(@this, fileData, fileDataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ContainerType AnalyzeContainerType<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fileData, uint fileDataSize) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ContainerType ret = default;
            fixed (void* fileDataPtr = &fileData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, void*, uint, ContainerType>)@this->LpVtbl[46])(@this, fileDataPtr, fileDataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnpackFontFile(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize, IDWriteFontFileStream** unpackedFontStream)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[47])(@this, containerType, fileData, fileDataSize, unpackedFontStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnpackFontFile(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize, ref IDWriteFontFileStream* unpackedFontStream)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileStream** unpackedFontStreamPtr = &unpackedFontStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[47])(@this, containerType, fileData, fileDataSize, unpackedFontStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnpackFontFile<T0>(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fileData, uint fileDataSize, IDWriteFontFileStream** unpackedFontStream) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fileDataPtr = &fileData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[47])(@this, containerType, fileDataPtr, fileDataSize, unpackedFontStream);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnpackFontFile<T0>(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fileData, uint fileDataSize, ref IDWriteFontFileStream* unpackedFontStream) where T0 : unmanaged
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fileDataPtr = &fileData)
            {
                fixed (IDWriteFontFileStream** unpackedFontStreamPtr = &unpackedFontStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, ContainerType, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[47])(@this, containerType, fileDataPtr, fileDataSize, unpackedFontStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(IDWriteFontFile* fontFile, uint faceIndex, IDWriteFontResource** fontResource)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)@this->LpVtbl[49])(@this, fontFile, faceIndex, fontResource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(IDWriteFontFile* fontFile, uint faceIndex, ref IDWriteFontResource* fontResource)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontResource** fontResourcePtr = &fontResource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)@this->LpVtbl[49])(@this, fontFile, faceIndex, fontResourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(ref IDWriteFontFile fontFile, uint faceIndex, IDWriteFontResource** fontResource)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile* fontFilePtr = &fontFile)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)@this->LpVtbl[49])(@this, fontFilePtr, faceIndex, fontResource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource(ref IDWriteFontFile fontFile, uint faceIndex, ref IDWriteFontResource* fontResource)
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFile* fontFilePtr = &fontFile)
            {
                fixed (IDWriteFontResource** fontResourcePtr = &fontResource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFactory6*, IDWriteFontFile*, uint, IDWriteFontResource**, int>)@this->LpVtbl[49])(@this, fontFilePtr, faceIndex, fontResourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSystemFontCollection<TI0>(ref ComPtr<TI0> fontCollection, Silk.NET.Core.Bool32 checkForUpdates) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSystemFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf(), checkForUpdates);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0, TI1>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, collectionKey, collectionKeySize, ref fontCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontCollection<T0, TI0, TI1>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref ComPtr<TI1> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<T0, TI0>(ComPtr<TI0> collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref IDWriteFontCollection* fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection((IDWriteFontCollectionLoader*) collectionLoader.Handle, in collectionKey, collectionKeySize, ref fontCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontCollection<TI0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection(ref collectionLoader, collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontCollection<T0, TI0>(ref IDWriteFontCollectionLoader collectionLoader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 collectionKey, uint collectionKeySize, ref ComPtr<TI0> fontCollection) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontCollection(ref collectionLoader, in collectionKey, collectionKeySize, (IDWriteFontCollection**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontCollectionLoader<TI0>(ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontCollectionLoader<TI0>(ComPtr<TI0> fontCollectionLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontCollectionLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnregisterFontCollectionLoader((IDWriteFontCollectionLoader*) fontCollectionLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(in filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(in filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFileReference(filePath, in lastWriteTime, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontFileReference<T0, TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref ComPtr<TI1> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCustomFontFileReference<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ComPtr<TI0> fontFileLoader, ref IDWriteFontFile* fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileLoader*) fontFileLoader.Handle, ref fontFile);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomFontFileReference<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileLoader fontFileLoader, ref ComPtr<TI0> fontFile) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomFontFileReference(in fontFileReferenceKey, fontFileReferenceKeySize, ref fontFileLoader, (IDWriteFontFile**) fontFile.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFace<TI0, TI1>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI1> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace<TI0>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref ComPtr<TI0> fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref IDWriteFontFace* fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, (IDWriteFontFile**) fontFiles.GetAddressOf(), faceIndex, fontFaceSimulationFlags, ref fontFace);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFace<TI0>(FontFaceType fontFaceType, uint numberOfFiles, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly IDWriteFontFile* fontFiles, uint faceIndex, FontSimulations fontFaceSimulationFlags, ref ComPtr<TI0> fontFace) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFace(fontFaceType, numberOfFiles, in fontFiles, faceIndex, fontFaceSimulationFlags, (IDWriteFontFace**) fontFace.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateRenderingParams<TI0>(ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateRenderingParams((IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMonitorRenderingParams<TI0>(nint monitor, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMonitorRenderingParams(monitor, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateCustomRenderingParams<TI0>(float gamma, float enhancedContrast, float clearTypeLevel, PixelGeometry pixelGeometry, RenderingMode renderingMode, ref ComPtr<TI0> renderingParams) where TI0 : unmanaged, IComVtbl<IDWriteRenderingParams>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateCustomRenderingParams(gamma, enhancedContrast, clearTypeLevel, pixelGeometry, renderingMode, (IDWriteRenderingParams**) renderingParams.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int RegisterFontFileLoader<TI0>(ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->RegisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int UnregisterFontFileLoader<TI0>(ComPtr<TI0> fontFileLoader) where TI0 : unmanaged, IComVtbl<IDWriteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnregisterFontFileLoader((IDWriteFontFileLoader*) fontFileLoader.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(in fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, in localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI1> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ComPtr<TI0> fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref IDWriteTextFormat* textFormat) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, (IDWriteFontCollection*) fontCollection.Handle, fontWeight, fontStyle, fontStretch, fontSize, localeName, ref textFormat);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, in localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextFormat<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string fontFamilyName, ref IDWriteFontCollection fontCollection, FontWeight fontWeight, FontStyle fontStyle, FontStretch fontStretch, float fontSize, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, ref ComPtr<TI0> textFormat) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextFormat(fontFamilyName, ref fontCollection, fontWeight, fontStyle, fontStretch, fontSize, localeName, (IDWriteTextFormat**) textFormat.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTypography<TI0>(ref ComPtr<TI0> typography) where TI0 : unmanaged, IComVtbl<IDWriteTypography>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTypography((IDWriteTypography**) typography.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGdiInterop<TI0>(ref ComPtr<TI0> gdiInterop) where TI0 : unmanaged, IComVtbl<IDWriteGdiInterop>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetGdiInterop((IDWriteGdiInterop**) gdiInterop.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(in @string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float maxWidth, float maxHeight, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, maxWidth, maxHeight, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float maxWidth, float maxHeight, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextLayout(@string, stringLength, ref textFormat, maxWidth, maxHeight, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(in @string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0, TI1>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI1> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ComPtr<TI0> textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref IDWriteTextLayout* textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, (IDWriteTextFormat*) textFormat.Handle, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, ref textLayout);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGdiCompatibleTextLayout<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, Silk.NET.Core.Bool32 useGdiNatural, ref ComPtr<TI0> textLayout) where TI0 : unmanaged, IComVtbl<IDWriteTextLayout>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGdiCompatibleTextLayout(@string, stringLength, ref textFormat, layoutWidth, layoutHeight, pixelsPerDip, in transform, useGdiNatural, (IDWriteTextLayout**) textLayout.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipsisTrimmingSign<TI0, TI1>(ComPtr<TI0> textFormat, ref ComPtr<TI1> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEllipsisTrimmingSign<TI0>(ComPtr<TI0> textFormat, ref IDWriteInlineObject* trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteTextFormat>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign((IDWriteTextFormat*) textFormat.Handle, ref trimmingSign);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEllipsisTrimmingSign<TI0>(ref IDWriteTextFormat textFormat, ref ComPtr<TI0> trimmingSign) where TI0 : unmanaged, IComVtbl<IDWriteInlineObject>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEllipsisTrimmingSign(ref textFormat, (IDWriteInlineObject**) trimmingSign.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateTextAnalyzer<TI0>(ref ComPtr<TI0> textAnalyzer) where TI0 : unmanaged, IComVtbl<IDWriteTextAnalyzer>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateTextAnalyzer((IDWriteTextAnalyzer**) textAnalyzer.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, in localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateNumberSubstitution<TI0>(NumberSubstitutionMethod substitutionMethod, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, Silk.NET.Core.Bool32 ignoreUserOverride, ref ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateNumberSubstitution(substitutionMethod, localeName, ignoreUserOverride, (IDWriteNumberSubstitution**) numberSubstitution.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateGlyphRunAnalysis<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, float pixelsPerDip, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix transform, RenderingMode renderingMode, MeasuringMode measuringMode, float baselineOriginX, float baselineOriginY, ref ComPtr<TI0> glyphRunAnalysis) where TI0 : unmanaged, IComVtbl<IDWriteGlyphRunAnalysis>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateGlyphRunAnalysis(in glyphRun, pixelsPerDip, in transform, renderingMode, measuringMode, baselineOriginX, baselineOriginY, (IDWriteGlyphRunAnalysis**) glyphRunAnalysis.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEudcFontCollection<TI0>(ref ComPtr<TI0> fontCollection, Silk.NET.Core.Bool32 checkForUpdates) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetEudcFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf(), checkForUpdates);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSystemFontFallback<TI0>(ref ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSystemFontFallback((IDWriteFontFallback**) fontFallback.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFallbackBuilder<TI0>(ref ComPtr<TI0> fontFallbackBuilder) where TI0 : unmanaged, IComVtbl<IDWriteFontFallbackBuilder>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFallbackBuilder((IDWriteFontFallbackBuilder**) fontFallbackBuilder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRun* glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, glyphRun, in glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphRunDescription* glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Matrix* worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, in glyphRunDescription, measuringMode, worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int TranslateColorGlyphRun<TI0>(float baselineOriginX, float baselineOriginY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRun glyphRun, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly GlyphRunDescription glyphRunDescription, MeasuringMode measuringMode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Matrix worldToDeviceTransform, uint colorPaletteIndex, ref ComPtr<TI0> colorLayers) where TI0 : unmanaged, IComVtbl<IDWriteColorGlyphRunEnumerator>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->TranslateColorGlyphRun(baselineOriginX, baselineOriginY, in glyphRun, in glyphRunDescription, measuringMode, in worldToDeviceTransform, colorPaletteIndex, (IDWriteColorGlyphRunEnumerator**) colorLayers.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(filePath, lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(filePath, in lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(in filePath, lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(in filePath, in lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Win32Extras.Filetime* lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(filePath, lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFaceReference<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Core.Win32Extras.Filetime lastWriteTime, uint faceIndex, FontSimulations fontSimulations, ref ComPtr<TI0> fontFaceReference) where TI0 : unmanaged, IComVtbl<IDWriteFontFaceReference>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFaceReference(filePath, in lastWriteTime, faceIndex, fontSimulations, (IDWriteFontFaceReference**) fontFaceReference.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSystemFontSet<TI0>(ref ComPtr<TI0> fontSet) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetSystemFontSet((IDWriteFontSet**) fontSet.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontSetBuilder<TI0>(ref ComPtr<TI0> fontSetBuilder) where TI0 : unmanaged, IComVtbl<IDWriteFontSetBuilder>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontSetBuilder((IDWriteFontSetBuilder**) fontSetBuilder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontCollectionFromFontSet<TI0, TI1>(ComPtr<TI0> fontSet, ref ComPtr<TI1> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontCollection1>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontCollectionFromFontSet((IDWriteFontSet*) fontSet.Handle, (IDWriteFontCollection1**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontCollectionFromFontSet<TI0>(ComPtr<TI0> fontSet, ref IDWriteFontCollection1* fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontSet>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontCollectionFromFontSet((IDWriteFontSet*) fontSet.Handle, ref fontCollection);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontCollectionFromFontSet<TI0>(ref IDWriteFontSet fontSet, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection1>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontCollectionFromFontSet(ref fontSet, (IDWriteFontCollection1**) fontCollection.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontDownloadQueue<TI0>(ref ComPtr<TI0> fontDownloadQueue) where TI0 : unmanaged, IComVtbl<IDWriteFontDownloadQueue>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontDownloadQueue((IDWriteFontDownloadQueue**) fontDownloadQueue.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInMemoryFontFileLoader<TI0>(ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteInMemoryFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInMemoryFontFileLoader((IDWriteInMemoryFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, in extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(in referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(in referrerUrl, in extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(in referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly char extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, in extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateHttpFontFileLoader<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string referrerUrl, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extraHeaders, ref ComPtr<TI0> newLoader) where TI0 : unmanaged, IComVtbl<IDWriteRemoteFontFileLoader>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateHttpFontFileLoader(referrerUrl, extraHeaders, (IDWriteRemoteFontFileLoader**) newLoader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UnpackFontFile<TI0>(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fileData, uint fileDataSize, ref ComPtr<TI0> unpackedFontStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnpackFontFile(containerType, fileData, fileDataSize, (IDWriteFontFileStream**) unpackedFontStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int UnpackFontFile<T0, TI0>(ContainerType containerType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly T0 fileData, uint fileDataSize, ref ComPtr<TI0> unpackedFontStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->UnpackFontFile(containerType, in fileData, fileDataSize, (IDWriteFontFileStream**) unpackedFontStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontResource<TI0, TI1>(ComPtr<TI0> fontFile, uint faceIndex, ref ComPtr<TI1> fontResource) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFontResource>, IComVtbl<TI1>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontResource((IDWriteFontFile*) fontFile.Handle, faceIndex, (IDWriteFontResource**) fontResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontResource<TI0>(ComPtr<TI0> fontFile, uint faceIndex, ref IDWriteFontResource* fontResource) where TI0 : unmanaged, IComVtbl<IDWriteFontFile>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontResource((IDWriteFontFile*) fontFile.Handle, faceIndex, ref fontResource);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontResource<TI0>(ref IDWriteFontFile fontFile, uint faceIndex, ref ComPtr<TI0> fontResource) where TI0 : unmanaged, IComVtbl<IDWriteFontResource>, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontResource(ref fontFile, faceIndex, (IDWriteFontResource**) fontResource.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFactory6*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
