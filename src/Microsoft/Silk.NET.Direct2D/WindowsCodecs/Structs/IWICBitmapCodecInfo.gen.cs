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
    [Guid("e87a44c4-b76e-4c47-8b09-298eb12a2714")]
    [NativeName("Name", "IWICBitmapCodecInfo")]
    public unsafe partial struct IWICBitmapCodecInfo : IComVtbl<IWICBitmapCodecInfo>, IComVtbl<IWICComponentInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e87a44c4-b76e-4c47-8b09-298eb12a2714");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICComponentInfo(IWICBitmapCodecInfo val)
            => Unsafe.As<IWICBitmapCodecInfo, IWICComponentInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapCodecInfo val)
            => Unsafe.As<IWICBitmapCodecInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapCodecInfo
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
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentType(ComponentType* pType)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComponentType(ref ComponentType pType)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComponentType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCLSID(Guid* pclsid)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCLSID(ref Guid pclsid)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSigningStatus(uint* pStatus)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSigningStatus(ref uint pStatus)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, ref char wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVendorGUID(Guid* pguidVendor)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVendorGUID(ref Guid pguidVendor)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, ref char wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, ref char wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, ref uint pcActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualPtr = &pcActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, ref Guid pguidPixelFormats, uint* pcActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormats(uint cFormats, ref Guid pguidPixelFormats, ref uint pcActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
            {
                fixed (uint* pcActualPtr = &pcActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, char* wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, char* wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, ref char wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorManagementVersion(uint cchColorManagementVersion, ref char wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzColorManagementVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorManagementVersion(uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzColorManagementVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, char* wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, char* wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, ref char wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypesPtr = &wzMimeTypes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMimeTypes(uint cchMimeTypes, ref char wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypesPtr = &wzMimeTypes)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
            SilkMarshal.Free((nint)wzMimeTypesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMimeTypes(uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzMimeTypesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, char* wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, char* wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, ref char wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileExtensions(uint cchFileExtensions, ref char wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
            SilkMarshal.Free((nint)wzFileExtensionsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileExtensions(uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFileExtensionsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportAnimation(int* pfSupportAnimation)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportAnimation(ref int pfSupportAnimation)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportAnimationPtr = &pfSupportAnimation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportChromakey(int* pfSupportChromakey)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportChromakey(ref int pfSupportChromakey)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportChromakeyPtr = &pfSupportChromakey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportLossless(int* pfSupportLossless)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLossless);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportLossless(ref int pfSupportLossless)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportLosslessPtr = &pfSupportLossless)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLosslessPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportMultiframe(int* pfSupportMultiframe)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframe);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportMultiframe(ref int pfSupportMultiframe)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportMultiframePtr = &pfSupportMultiframe)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatches);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatchesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypePtr = &wzMimeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypePtr = &wzMimeType)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
            SilkMarshal.Free((nint)wzMimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
            }
            SilkMarshal.Free((nint)wzMimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapCodecInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
