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
    [Guid("eebf1f5b-07c1-4447-a3ab-22acaf78a804")]
    [NativeName("Name", "IWICMetadataReaderInfo")]
    public unsafe partial struct IWICMetadataReaderInfo : IComVtbl<IWICMetadataReaderInfo>, IComVtbl<IWICMetadataHandlerInfo>, IComVtbl<IWICComponentInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("eebf1f5b-07c1-4447-a3ab-22acaf78a804");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICMetadataHandlerInfo(IWICMetadataReaderInfo val)
            => Unsafe.As<IWICMetadataReaderInfo, IWICMetadataHandlerInfo>(ref val);

        public static implicit operator IWICComponentInfo(IWICMetadataReaderInfo val)
            => Unsafe.As<IWICMetadataReaderInfo, IWICComponentInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICMetadataReaderInfo val)
            => Unsafe.As<IWICMetadataReaderInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICMetadataReaderInfo
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
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentType(ComponentType* pType)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComponentType(ref ComponentType pType)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComponentType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCLSID(Guid* pclsid)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCLSID(ref Guid pclsid)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSigningStatus(uint* pStatus)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSigningStatus(ref uint pStatus)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, ref char wzAuthor, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVendorGUID(Guid* pguidVendor)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVendorGUID(ref Guid pguidVendor)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, ref char wzVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, ref char wzVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidMetadataFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMetadataFormat(ref Guid pguidMetadataFormat)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidMetadataFormatPtr = &pguidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidMetadataFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormats, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormats(uint cContainerFormats, Guid* pguidContainerFormats, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormats, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormats(uint cContainerFormats, ref Guid pguidContainerFormats, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatsPtr = &pguidContainerFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormatsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormats(uint cContainerFormats, ref Guid pguidContainerFormats, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatsPtr = &pguidContainerFormats)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cContainerFormats, pguidContainerFormatsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModels, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModels, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesRequireFullStream(int* pfRequiresFullStream)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[15])(@this, pfRequiresFullStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesRequireFullStream(ref int pfRequiresFullStream)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfRequiresFullStreamPtr = &pfRequiresFullStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[15])(@this, pfRequiresFullStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportPadding(int* pfSupportsPadding)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsPadding);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportPadding(ref int pfSupportsPadding)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportsPaddingPtr = &pfSupportsPadding)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[16])(@this, pfSupportsPaddingPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesRequireFixedSize(int* pfFixedSize)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[17])(@this, pfFixedSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesRequireFixedSize(ref int pfFixedSize)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfFixedSizePtr = &pfFixedSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, int*, int>)@this->LpVtbl[17])(@this, pfFixedSizePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCount, pcbActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbActualPtr = &pcbActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCount, pcbActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcCountPtr = &pcCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCountPtr, pcbActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcCountPtr = &pcCount)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPattern, pcCountPtr, pcbActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCount, pcbActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCount, pcbActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCountPtr, pcbActual);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(Guid* guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (MetadataPattern* pPatternPtr = &pPattern)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    fixed (uint* pcbActualPtr = &pcbActual)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormat, cbSize, pPatternPtr, pcCountPtr, pcbActualPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCount, pcbActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, uint* pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (uint* pcbActualPtr = &pcbActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCount, pcbActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCountPtr, pcbActual);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, MetadataPattern* pPattern, ref uint pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (uint* pcCountPtr = &pcCount)
                {
                    fixed (uint* pcbActualPtr = &pcbActual)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPattern, pcCountPtr, pcbActualPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (MetadataPattern* pPatternPtr = &pPattern)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCount, pcbActual);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, uint* pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (MetadataPattern* pPatternPtr = &pPattern)
                {
                    fixed (uint* pcbActualPtr = &pcbActual)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCount, pcbActualPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, uint* pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (MetadataPattern* pPatternPtr = &pPattern)
                {
                    fixed (uint* pcCountPtr = &pcCount)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCountPtr, pcbActual);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPatterns(ref Guid guidContainerFormat, uint cbSize, ref MetadataPattern pPattern, ref uint pcCount, ref uint pcbActual)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (MetadataPattern* pPatternPtr = &pPattern)
                {
                    fixed (uint* pcCountPtr = &pcCount)
                    {
                        fixed (uint* pcbActualPtr = &pcbActual)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, uint, MetadataPattern*, uint*, uint*, int>)@this->LpVtbl[18])(@this, guidContainerFormatPtr, cbSize, pPatternPtr, pcCountPtr, pcbActualPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Guid* guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStream, pfMatches);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Guid* guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, ref int pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStream, pfMatchesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Guid* guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, int* pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStreamPtr, pfMatches);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Guid* guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref int pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormat, pIStreamPtr, pfMatchesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(ref Guid guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStream, pfMatches);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(ref Guid guidContainerFormat, Silk.NET.Core.Win32Extras.IStream* pIStream, ref int pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStream, pfMatchesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(ref Guid guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, int* pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStreamPtr, pfMatches);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesPattern(ref Guid guidContainerFormat, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref int pfMatches)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    fixed (int* pfMatchesPtr = &pfMatches)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, Guid*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[19])(@this, guidContainerFormatPtr, pIStreamPtr, pfMatchesPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(IWICMetadataReader** ppIReader)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)@this->LpVtbl[20])(@this, ppIReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICMetadataReaderInfo*, IWICMetadataReader**, int>)@this->LpVtbl[20])(@this, ppIReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern<TI0>(Guid* guidContainerFormat, ComPtr<TI0> pIStream, int* pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern(guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern<TI0>(Guid* guidContainerFormat, ComPtr<TI0> pIStream, ref int pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern(guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern<TI0>(ref Guid guidContainerFormat, ComPtr<TI0> pIStream, int* pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern(ref guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesPattern<TI0>(ref Guid guidContainerFormat, ComPtr<TI0> pIStream, ref int pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern(ref guidContainerFormat, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0>(ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance((IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICMetadataReaderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
