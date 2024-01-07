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
    [Guid("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2")]
    [NativeName("Name", "IDWriteLocalFontFileLoader")]
    public unsafe partial struct IDWriteLocalFontFileLoader : IComVtbl<IDWriteLocalFontFileLoader>, IComVtbl<IDWriteFontFileLoader>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b2d9f3ec-c9fe-4a11-a2ec-d86208f7c0a2");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteFontFileLoader(IDWriteLocalFontFileLoader val)
            => Unsafe.As<IDWriteLocalFontFileLoader, IDWriteFontFileLoader>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteLocalFontFileLoader val)
            => Unsafe.As<IDWriteLocalFontFileLoader, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteLocalFontFileLoader
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
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKey, fontFileReferenceKeySize, fontFileStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, IDWriteFontFileStream** fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStream);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref IDWriteFontFileStream* fontFileStream) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (IDWriteFontFileStream** fontFileStreamPtr = &fontFileStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, IDWriteFontFileStream**, int>)@this->LpVtbl[3])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, fontFileStreamPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathLengthFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathLengthFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref uint filePathLength)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* filePathLengthPtr = &filePathLength)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathLengthPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathLengthFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, uint* filePathLength) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, filePathLength);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilePathLengthFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref uint filePathLength) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (uint* filePathLengthPtr = &filePathLength)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, uint*, int>)@this->LpVtbl[4])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, filePathLengthPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePath, filePathSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref char filePath, uint filePathSize)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filePathPtr = &filePath)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathPtr, filePathSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, uint filePathSize)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, byte*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKey, fontFileReferenceKeySize, filePathPtr, filePathSize);
            SilkMarshal.Free((nint)filePathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFilePathFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, char* filePath, uint filePathSize) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, filePath, filePathSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilePathFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref char filePath, uint filePathSize) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (char* filePathPtr = &filePath)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, char*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, filePathPtr, filePathSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFilePathFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filePath, uint filePathSize) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
            var filePathPtr = (byte*) SilkMarshal.StringToPtr(filePath, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, byte*, uint, int>)@this->LpVtbl[5])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, filePathPtr, filePathSize);
            SilkMarshal.Free((nint)filePathPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTimeFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, Silk.NET.Core.Win32Extras.Filetime* lastWriteTime)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTime);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTimeFromKey([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref Silk.NET.Core.Win32Extras.Filetime lastWriteTime)
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKey, fontFileReferenceKeySize, lastWriteTimePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLastWriteTimeFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, Silk.NET.Core.Win32Extras.Filetime* lastWriteTime) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, lastWriteTime);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetLastWriteTimeFromKey<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref Silk.NET.Core.Win32Extras.Filetime lastWriteTime) where T0 : unmanaged
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* fontFileReferenceKeyPtr = &fontFileReferenceKey)
            {
                fixed (Silk.NET.Core.Win32Extras.Filetime* lastWriteTimePtr = &lastWriteTime)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteLocalFontFileLoader*, void*, uint, Silk.NET.Core.Win32Extras.Filetime*, int>)@this->LpVtbl[6])(@this, fontFileReferenceKeyPtr, fontFileReferenceKeySize, lastWriteTimePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStreamFromKey<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] void* fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStreamFromKey<T0, TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 fontFileReferenceKey, uint fontFileReferenceKeySize, ref ComPtr<TI0> fontFileStream) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IDWriteFontFileStream>, IComVtbl<TI0>
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStreamFromKey(in fontFileReferenceKey, fontFileReferenceKeySize, (IDWriteFontFileStream**) fontFileStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteLocalFontFileLoader*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
