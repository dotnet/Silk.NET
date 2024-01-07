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
    [Guid("fd882d06-8aba-4fb8-b849-8be8b73e14de")]
    [NativeName("Name", "IDWriteFontFallbackBuilder")]
    public unsafe partial struct IDWriteFontFallbackBuilder : IComVtbl<IDWriteFontFallbackBuilder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("fd882d06-8aba-4fb8-b849-8be8b73e14de");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteFontFallbackBuilder val)
            => Unsafe.As<IDWriteFontFallbackBuilder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteFontFallbackBuilder
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
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* localeNamePtr = &localeName)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            fixed (char* baseFamilyNamePtr = &baseFamilyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            }
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
                fixed (char* localeNamePtr = &localeName)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (char* localeNamePtr = &localeName)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, ranges, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char* localeNamePtr = &localeName)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char* localeNamePtr = &localeName)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                fixed (char* baseFamilyNamePtr = &baseFamilyName)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                }
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                    }
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (char* localeNamePtr = &localeName)
                    {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                    fixed (char* baseFamilyNamePtr = &baseFamilyName)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
                    }
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollection, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyName, scale);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeName, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
                        fixed (char* localeNamePtr = &localeName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
                        fixed (char* localeNamePtr = &localeName)
                        {
                            fixed (char* baseFamilyNamePtr = &baseFamilyName)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
                        fixed (char* localeNamePtr = &localeName)
                        {
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, char*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyName, scale);
            SilkMarshal.Free((nint)localeNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
                        fixed (char* baseFamilyNamePtr = &baseFamilyName)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, char*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
                        }
            SilkMarshal.Free((nint)localeNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (UnicodeRange* rangesPtr = &ranges)
            {
                fixed (char** targetFamilyNamesPtr = &targetFamilyNames)
                {
                    fixed (IDWriteFontCollection* fontCollectionPtr = &fontCollection)
                    {
            var localeNamePtr = (byte*) SilkMarshal.StringToPtr(localeName, NativeStringEncoding.UTF8);
            var baseFamilyNamePtr = (byte*) SilkMarshal.StringToPtr(baseFamilyName, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, UnicodeRange*, uint, char**, uint, IDWriteFontCollection*, byte*, byte*, float, int>)@this->LpVtbl[3])(@this, rangesPtr, rangesCount, targetFamilyNamesPtr, targetFamilyNamesCount, fontCollectionPtr, localeNamePtr, baseFamilyNamePtr, scale);
            SilkMarshal.Free((nint)baseFamilyNamePtr);
            SilkMarshal.Free((nint)localeNamePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMappings(IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMappings(ref IDWriteFontFallback fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallback* fontFallbackPtr = &fontFallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback*, int>)@this->LpVtbl[4])(@this, fontFallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallback(IDWriteFontFallback** fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallback);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFontFallback(ref IDWriteFontFallback* fontFallback)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFallback** fontFallbackPtr = &fontFallback)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFallbackBuilder*, IDWriteFontFallback**, int>)@this->LpVtbl[5])(@this, fontFallbackPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] UnicodeRange* ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, IDWriteFontCollection* fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, in localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, in baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMapping([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] string[] targetFamilyNamesSa, uint targetFamilyNamesCount, ref IDWriteFontCollection fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale)
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // StringArrayOverloader
            var targetFamilyNames = (char**) SilkMarshal.StringArrayToPtr(targetFamilyNamesSa);
            var ret = @this->AddMapping(in ranges, rangesCount, targetFamilyNames, targetFamilyNamesCount, ref fontCollection, localeName, baseFamilyName, scale);
            SilkMarshal.CopyPtrToStringArray((nint) targetFamilyNames, targetFamilyNamesSa);
            SilkMarshal.Free((nint) targetFamilyNames);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, in localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, in baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddMapping<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UnicodeRange ranges, uint rangesCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char* targetFamilyNames, uint targetFamilyNamesCount, ComPtr<TI0> fontCollection, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string localeName, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string baseFamilyName, float scale) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMapping(in ranges, rangesCount, in targetFamilyNames, targetFamilyNamesCount, (IDWriteFontCollection*) fontCollection.Handle, localeName, baseFamilyName, scale);
        }

        /// <summary>To be documented.</summary>
        public readonly int AddMappings<TI0>(ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->AddMappings((IDWriteFontFallback*) fontFallback.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFontFallback<TI0>(ref ComPtr<TI0> fontFallback) where TI0 : unmanaged, IComVtbl<IDWriteFontFallback>, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFontFallback((IDWriteFontFallback**) fontFallback.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteFontFallbackBuilder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
