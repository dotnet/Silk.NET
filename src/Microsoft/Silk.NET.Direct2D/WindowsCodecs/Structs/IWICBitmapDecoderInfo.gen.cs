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
    [Guid("d8cd007f-d08f-4191-9bfc-236ea7f0e4b5")]
    [NativeName("Name", "IWICBitmapDecoderInfo")]
    public unsafe partial struct IWICBitmapDecoderInfo : IComVtbl<IWICBitmapDecoderInfo>, IComVtbl<IWICBitmapCodecInfo>, IComVtbl<IWICComponentInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("d8cd007f-d08f-4191-9bfc-236ea7f0e4b5");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICBitmapCodecInfo(IWICBitmapDecoderInfo val)
            => Unsafe.As<IWICBitmapDecoderInfo, IWICBitmapCodecInfo>(ref val);

        public static implicit operator IWICComponentInfo(IWICBitmapDecoderInfo val)
            => Unsafe.As<IWICBitmapDecoderInfo, IWICComponentInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICBitmapDecoderInfo val)
            => Unsafe.As<IWICBitmapDecoderInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICBitmapDecoderInfo
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
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetComponentType(ComponentType* pType)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pType);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetComponentType(ref ComponentType pType)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ComponentType* pTypePtr = &pType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, ComponentType*, int>)@this->LpVtbl[3])(@this, pTypePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCLSID(Guid* pclsid)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsid);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCLSID(ref Guid pclsid)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pclsidPtr = &pclsid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[4])(@this, pclsidPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSigningStatus(uint* pStatus)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatus);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSigningStatus(ref uint pStatus)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pStatusPtr = &pStatus)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint*, int>)@this->LpVtbl[5])(@this, pStatusPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, char* wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthor, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, ref char wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, ref char wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzAuthorPtr = &wzAuthor)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActual);
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetAuthor(uint cchAuthor, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzAuthor, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzAuthorPtr = (byte*) SilkMarshal.StringToPtr(wzAuthor, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[6])(@this, cchAuthor, wzAuthorPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzAuthorPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVendorGUID(Guid* pguidVendor)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendor);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVendorGUID(ref Guid pguidVendor)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[7])(@this, pguidVendorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, char* wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, ref char wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, ref char wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzVersionPtr = &wzVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetVersion(uint cchVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzVersionPtr = (byte*) SilkMarshal.StringToPtr(wzVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[8])(@this, cchVersion, wzVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, char* wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, ref char wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzSpecVersionPtr = &wzSpecVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSpecVersion(uint cchSpecVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzSpecVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzSpecVersionPtr = (byte*) SilkMarshal.StringToPtr(wzSpecVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[9])(@this, cchSpecVersion, wzSpecVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzSpecVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, char* wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyName, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, ref char wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFriendlyNamePtr = &wzFriendlyName)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActual);
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFriendlyName(uint cchFriendlyName, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFriendlyName, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFriendlyNamePtr = (byte*) SilkMarshal.StringToPtr(wzFriendlyName, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[10])(@this, cchFriendlyName, wzFriendlyNamePtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFriendlyNamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetContainerFormat(Guid* pguidContainerFormat)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormat);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetContainerFormat(ref Guid pguidContainerFormat)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidContainerFormatPtr = &pguidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Guid*, int>)@this->LpVtbl[11])(@this, pguidContainerFormatPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, ref uint pcActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcActualPtr = &pcActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormats, pcActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPixelFormats(uint cFormats, ref Guid pguidPixelFormats, uint* pcActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPixelFormats(uint cFormats, ref Guid pguidPixelFormats, ref uint pcActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidPixelFormatsPtr = &pguidPixelFormats)
            {
                fixed (uint* pcActualPtr = &pcActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)@this->LpVtbl[12])(@this, cFormats, pguidPixelFormatsPtr, pcActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, char* wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, char* wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersion, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, ref char wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorManagementVersion(uint cchColorManagementVersion, ref char wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzColorManagementVersionPtr = &wzColorManagementVersion)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorManagementVersion(uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActual);
            SilkMarshal.Free((nint)wzColorManagementVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetColorManagementVersion(uint cchColorManagementVersion, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzColorManagementVersion, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzColorManagementVersionPtr = (byte*) SilkMarshal.StringToPtr(wzColorManagementVersion, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[13])(@this, cchColorManagementVersion, wzColorManagementVersionPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzColorManagementVersionPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, char* wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturer, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, ref char wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceManufacturerPtr = &wzDeviceManufacturer)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceManufacturer(uint cchDeviceManufacturer, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceManufacturer, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceManufacturerPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceManufacturer, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[14])(@this, cchDeviceManufacturer, wzDeviceManufacturerPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceManufacturerPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, char* wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModels, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, ref char wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzDeviceModelsPtr = &wzDeviceModels)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActual);
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetDeviceModels(uint cchDeviceModels, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzDeviceModels, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzDeviceModelsPtr = (byte*) SilkMarshal.StringToPtr(wzDeviceModels, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[15])(@this, cchDeviceModels, wzDeviceModelsPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzDeviceModelsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, char* wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, char* wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypes, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, ref char wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypesPtr = &wzMimeTypes)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMimeTypes(uint cchMimeTypes, ref char wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypesPtr = &wzMimeTypes)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetMimeTypes(uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActual);
            SilkMarshal.Free((nint)wzMimeTypesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetMimeTypes(uint cchMimeTypes, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzMimeTypes, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypesPtr = (byte*) SilkMarshal.StringToPtr(wzMimeTypes, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[16])(@this, cchMimeTypes, wzMimeTypesPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzMimeTypesPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, char* wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, char* wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensions, pcchActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, ref char wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileExtensions(uint cchFileExtensions, ref char wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFileExtensionsPtr = &wzFileExtensions)
            {
                fixed (uint* pcchActualPtr = &pcchActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetFileExtensions(uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, uint* pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActual);
            SilkMarshal.Free((nint)wzFileExtensionsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetFileExtensions(uint cchFileExtensions, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string wzFileExtensions, ref uint pcchActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFileExtensionsPtr = (byte*) SilkMarshal.StringToPtr(wzFileExtensions, NativeStringEncoding.UTF8);
            fixed (uint* pcchActualPtr = &pcchActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, byte*, uint*, int>)@this->LpVtbl[17])(@this, cchFileExtensions, wzFileExtensionsPtr, pcchActualPtr);
            }
            SilkMarshal.Free((nint)wzFileExtensionsPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportAnimation(int* pfSupportAnimation)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimation);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportAnimation(ref int pfSupportAnimation)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportAnimationPtr = &pfSupportAnimation)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[18])(@this, pfSupportAnimationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportChromakey(int* pfSupportChromakey)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakey);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportChromakey(ref int pfSupportChromakey)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportChromakeyPtr = &pfSupportChromakey)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[19])(@this, pfSupportChromakeyPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportLossless(int* pfSupportLossless)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLossless);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportLossless(ref int pfSupportLossless)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportLosslessPtr = &pfSupportLossless)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[20])(@this, pfSupportLosslessPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int DoesSupportMultiframe(int* pfSupportMultiframe)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframe);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int DoesSupportMultiframe(ref int pfSupportMultiframe)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfSupportMultiframePtr = &pfSupportMultiframe)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, int*, int>)@this->LpVtbl[21])(@this, pfSupportMultiframePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatches);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeType, pfMatchesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypePtr = &wzMimeType)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzMimeTypePtr = &wzMimeType)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, char*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, int* pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatches);
            SilkMarshal.Free((nint)wzMimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesMimeType([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzMimeType, ref int pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzMimeTypePtr = (byte*) SilkMarshal.StringToPtr(wzMimeType, NativeStringEncoding.LPWStr);
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, byte*, int*, int>)@this->LpVtbl[22])(@this, wzMimeTypePtr, pfMatchesPtr);
            }
            SilkMarshal.Free((nint)wzMimeTypePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, BitmapPattern* pPatterns, uint* pcPatterns, ref uint pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcbPatternsActualPtr = &pcbPatternsActual)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActualPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, uint* pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcPatternsPtr = &pcPatterns)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatterns, pcPatternsPtr, pcbPatternsActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, BitmapPattern* pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* pcPatternsPtr = &pcPatterns)
            {
                fixed (uint* pcbPatternsActualPtr = &pcbPatternsActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatterns, pcPatternsPtr, pcbPatternsActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPattern* pPatternsPtr = &pPatterns)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatternsPtr, pcPatterns, pcbPatternsActual);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, ref BitmapPattern pPatterns, uint* pcPatterns, ref uint pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPattern* pPatternsPtr = &pPatterns)
            {
                fixed (uint* pcbPatternsActualPtr = &pcbPatternsActual)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatternsPtr, pcPatterns, pcbPatternsActualPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPatterns(uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, uint* pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPattern* pPatternsPtr = &pPatterns)
            {
                fixed (uint* pcPatternsPtr = &pcPatterns)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatternsPtr, pcPatternsPtr, pcbPatternsActual);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPatterns(uint cbSizePatterns, ref BitmapPattern pPatterns, ref uint pcPatterns, ref uint pcbPatternsActual)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapPattern* pPatternsPtr = &pPatterns)
            {
                fixed (uint* pcPatternsPtr = &pcPatterns)
                {
                    fixed (uint* pcbPatternsActualPtr = &pcbPatternsActual)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, uint, BitmapPattern*, uint*, uint*, int>)@this->LpVtbl[23])(@this, cbSizePatterns, pPatternsPtr, pcPatternsPtr, pcbPatternsActualPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Silk.NET.Core.Win32Extras.IStream* pIStream, int* pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[24])(@this, pIStream, pfMatches);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(Silk.NET.Core.Win32Extras.IStream* pIStream, ref int pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (int* pfMatchesPtr = &pfMatches)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[24])(@this, pIStream, pfMatchesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern(ref Silk.NET.Core.Win32Extras.IStream pIStream, int* pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[24])(@this, pIStreamPtr, pfMatches);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesPattern(ref Silk.NET.Core.Win32Extras.IStream pIStream, ref int pfMatches)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (int* pfMatchesPtr = &pfMatches)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, Silk.NET.Core.Win32Extras.IStream*, int*, int>)@this->LpVtbl[24])(@this, pIStreamPtr, pfMatchesPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int>)@this->LpVtbl[25])(@this, ppIBitmapDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInstance(ref IWICBitmapDecoder* ppIBitmapDecoder)
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIBitmapDecoderPtr = &ppIBitmapDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int>)@this->LpVtbl[25])(@this, ppIBitmapDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int MatchesPattern<TI0>(ComPtr<TI0> pIStream, int* pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly int MatchesPattern<TI0>(ComPtr<TI0> pIStream, ref int pfMatches) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->MatchesPattern((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref pfMatches);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateInstance<TI0>(ref ComPtr<TI0> ppIBitmapDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateInstance((IWICBitmapDecoder**) ppIBitmapDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICBitmapDecoderInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
