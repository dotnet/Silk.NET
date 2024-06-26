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
    [Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc")]
    [NativeName("Name", "IDWriteFontCollection")]
    public unsafe partial struct IDWriteFontCollection : IComVtbl<IDWriteFontCollection>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a84cee02-3eea-4eee-a827-87c1a02a0fcc");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontCollection val)
            => Unsafe.As<IDWriteFontCollection, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontCollection
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
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetFontFamilyCount()
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(uint index, IDWriteFontFamily** fontFamily)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamily);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFamily(uint index, ref IDWriteFontFamily* fontFamily)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFamily** fontFamilyPtr = &fontFamily)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, uint, IDWriteFontFamily**, int>)@this->LpVtbl[4])(@this, index, fontFamilyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, exists);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, uint* index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, index, existsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, ref uint index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* indexPtr = &index)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, indexPtr, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* familyName, ref uint index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* indexPtr = &index)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyName, indexPtr, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* familyNamePtr = &familyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, exists);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, uint* index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* familyNamePtr = &familyName)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, existsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, ref uint index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* familyNamePtr = &familyName)
            {
                fixed (uint* indexPtr = &index)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, exists);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char familyName, ref uint index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* familyNamePtr = &familyName)
            {
                fixed (uint* indexPtr = &index)
                {
                    fixed (int* existsPtr = &exists)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, char*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, existsPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, uint* index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, exists);
            SilkMarshal.Free((nint)familyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, uint* index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
            fixed (int* existsPtr = &exists)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, index, existsPtr);
            }
            SilkMarshal.Free((nint)familyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, ref uint index, int* exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
            fixed (uint* indexPtr = &index)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, exists);
            }
            SilkMarshal.Free((nint)familyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int FindFamilyName([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string familyName, ref uint index, ref int exists)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var familyNamePtr = (byte*) SilkMarshal.StringToPtr(familyName, NativeStringEncoding.UTF8);
            fixed (uint* indexPtr = &index)
            {
                fixed (int* existsPtr = &exists)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, byte*, uint*, int*, int>)@this->LpVtbl[5])(@this, familyNamePtr, indexPtr, existsPtr);
                }
            }
            SilkMarshal.Free((nint)familyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(IDWriteFontFace* fontFace, IDWriteFont** font)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, font);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(IDWriteFontFace* fontFace, ref IDWriteFont* font)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFont** fontPtr = &font)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFace, fontPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(ref IDWriteFontFace fontFace, IDWriteFont** font)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFacePtr, font);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace(ref IDWriteFontFace fontFace, ref IDWriteFont* font)
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (IDWriteFont** fontPtr = &font)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontCollection*, IDWriteFontFace*, IDWriteFont**, int>)@this->LpVtbl[6])(@this, fontFacePtr, fontPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFamily<TI0>(uint index, ref ComPtr<TI0> fontFamily) where TI0 : unmanaged, IComVtbl<IDWriteFontFamily>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFamily(index, (IDWriteFontFamily**) fontFamily.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFromFontFace<TI0, TI1>(ComPtr<TI0> fontFace, ref ComPtr<TI1> font) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI1>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFromFontFace((IDWriteFontFace*) fontFace.Handle, (IDWriteFont**) font.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFontFromFontFace<TI0>(ComPtr<TI0> fontFace, ref IDWriteFont* font) where TI0 : unmanaged, IComVtbl<IDWriteFontFace>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFromFontFace((IDWriteFontFace*) fontFace.Handle, ref font);
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFontFromFontFace<TI0>(ref IDWriteFontFace fontFace, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetFontFromFontFace(ref fontFace, (IDWriteFont**) font.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontCollection*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
