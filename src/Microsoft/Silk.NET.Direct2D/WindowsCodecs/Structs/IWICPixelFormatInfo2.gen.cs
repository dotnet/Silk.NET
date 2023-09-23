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
    [Guid("a9db33a2-af5f-43c7-b679-74f5984b5aa4")]
    [NativeName("Name", "IWICPixelFormatInfo2")]
    public unsafe partial struct IWICPixelFormatInfo2 : IComVtbl<IWICPixelFormatInfo2>, IComVtbl<IWICPixelFormatInfo>, IComVtbl<IWICComponentInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("a9db33a2-af5f-43c7-b679-74f5984b5aa4");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICPixelFormatInfo(IWICPixelFormatInfo2 val)
            => Unsafe.As<IWICPixelFormatInfo2, IWICPixelFormatInfo>(ref val);

        public static implicit operator IWICComponentInfo(IWICPixelFormatInfo2 val)
            => Unsafe.As<IWICPixelFormatInfo2, IWICComponentInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICPixelFormatInfo2 val)
            => Unsafe.As<IWICPixelFormatInfo2, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICPixelFormatInfo2
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
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentType(ComponentType* pType)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComponentType(ref ComponentType pType)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComponentType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCLSID(Guid* pclsid)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCLSID(ref Guid pclsid)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSigningStatus(uint* pStatus)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSigningStatus(ref uint pStatus)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, ref char wzAuthor, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVendorGUID(Guid* pguidVendor)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVendorGUID(ref Guid pguidVendor)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, ref char wzVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, ref char wzVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFormatGUID(Guid* pFormat)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[11])(@this, pFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFormatGUID(ref Guid pFormat)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pFormatPtr = &pFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, Guid*, int>)@this->LpVtbl[11])(@this, pFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContext(IWICColorContext** ppIColorContext)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, IWICColorContext**, int>)@this->LpVtbl[12])(@this, ppIColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorContext(ref IWICColorContext* ppIColorContext)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIColorContextPtr = &ppIColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, IWICColorContext**, int>)@this->LpVtbl[12])(@this, ppIColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBitsPerPixel(uint* puiBitsPerPixel)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[13])(@this, puiBitsPerPixel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBitsPerPixel(ref uint puiBitsPerPixel)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiBitsPerPixelPtr = &puiBitsPerPixel)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[13])(@this, puiBitsPerPixelPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetChannelCount(uint* puiChannelCount)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[14])(@this, puiChannelCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetChannelCount(ref uint puiChannelCount)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* puiChannelCountPtr = &puiChannelCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint*, int>)@this->LpVtbl[14])(@this, puiChannelCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, uint* pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, byte* pbMaskBuffer, ref uint pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, ref byte pbMaskBuffer, uint* pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbMaskBufferPtr = &pbMaskBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, ref byte pbMaskBuffer, ref uint pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbMaskBufferPtr = &pbMaskBuffer)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMaskBuffer, uint* pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbMaskBufferPtr = (byte*) SilkMarshal.StringToPtr(pbMaskBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActual);
            SilkMarshal.Free((nint)pbMaskBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetChannelMask(uint uiChannelIndex, uint cbMaskBuffer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbMaskBuffer, ref uint pcbActual)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbMaskBufferPtr = (byte*) SilkMarshal.StringToPtr(pbMaskBuffer, NativeStringEncoding.UTF8);
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, uiChannelIndex, cbMaskBuffer, pbMaskBufferPtr, pcbActualPtr);
            }
            SilkMarshal.Free((nint)pbMaskBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SupportsTransparency(int* pfSupportsTransparency)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsTransparency);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SupportsTransparency(ref int pfSupportsTransparency)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportsTransparencyPtr = &pfSupportsTransparency)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsTransparencyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumericRepresentation(PixelFormatNumericRepresentation* pNumericRepresentation)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, PixelFormatNumericRepresentation*, int>)@this->LpVtbl[17])(@this, pNumericRepresentation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetNumericRepresentation(ref PixelFormatNumericRepresentation pNumericRepresentation)
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PixelFormatNumericRepresentation* pNumericRepresentationPtr = &pNumericRepresentation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICPixelFormatInfo2*, PixelFormatNumericRepresentation*, int>)@this->LpVtbl[17])(@this, pNumericRepresentationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorContext<TI0>(ref ComPtr<TI0> ppIColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetColorContext((IWICColorContext**) ppIColorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICPixelFormatInfo2*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
