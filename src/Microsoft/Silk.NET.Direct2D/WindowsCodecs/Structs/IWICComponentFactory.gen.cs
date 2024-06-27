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
    [Guid("412d0c3a-9650-44fa-af5b-dd2a06c8e8fb")]
    [NativeName("Name", "IWICComponentFactory")]
    public unsafe partial struct IWICComponentFactory : IComVtbl<IWICComponentFactory>, IComVtbl<IWICImagingFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("412d0c3a-9650-44fa-af5b-dd2a06c8e8fb");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IWICImagingFactory(IWICComponentFactory val)
            => Unsafe.As<IWICComponentFactory, IWICImagingFactory>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICComponentFactory val)
            => Unsafe.As<IWICComponentFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICComponentFactory
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
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilename, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* wzFilenamePtr = &wzFilename)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, char*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoder);
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendor, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoder);
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var wzFilenamePtr = (byte*) SilkMarshal.StringToPtr(wzFilename, NativeStringEncoding.LPWStr);
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, byte*, Guid*, uint, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[3])(@this, wzFilenamePtr, pguidVendorPtr, dwDesiredAccess, metadataOptions, ppIDecoderPtr);
                }
            }
            SilkMarshal.Free((nint)wzFilenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendor, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(Silk.NET.Core.Win32Extras.IStream* pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStream, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendor, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.IStream*, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[4])(@this, pIStreamPtr, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendor, metadataOptions, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, nuint, Guid*, DecodeOptions, IWICBitmapDecoder**, int>)@this->LpVtbl[5])(@this, hFile, pguidVendorPtr, metadataOptions, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(Guid* clsidComponent, IWICComponentInfo** ppIInfo)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfo);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(Guid* clsidComponent, ref IWICComponentInfo* ppIInfo)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponent, ppIInfoPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(ref Guid clsidComponent, IWICComponentInfo** ppIInfo)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidComponentPtr = &clsidComponent)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfo);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentInfo(ref Guid clsidComponent, ref IWICComponentInfo* ppIInfo)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* clsidComponentPtr = &clsidComponent)
            {
                fixed (IWICComponentInfo** ppIInfoPtr = &ppIInfo)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, IWICComponentInfo**, int>)@this->LpVtbl[6])(@this, clsidComponentPtr, ppIInfoPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendor, ppIDecoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormat, pguidVendorPtr, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendor, ppIDecoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapDecoder** ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapDecoder* ppIDecoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapDecoder** ppIDecoderPtr = &ppIDecoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapDecoder**, int>)@this->LpVtbl[7])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIDecoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendor, ppIEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormat, pguidVendorPtr, ppIEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendor, ppIEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICBitmapEncoder** ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoder);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICBitmapEncoder* ppIEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICBitmapEncoder** ppIEncoderPtr = &ppIEncoder)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICBitmapEncoder**, int>)@this->LpVtbl[8])(@this, guidContainerFormatPtr, pguidVendorPtr, ppIEncoderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePalette(IWICPalette** ppIPalette)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalette);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePalette(ref IWICPalette* ppIPalette)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICPalette** ppIPalettePtr = &ppIPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICPalette**, int>)@this->LpVtbl[9])(@this, ppIPalettePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFormatConverter(IWICFormatConverter** ppIFormatConverter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFormatConverter(ref IWICFormatConverter* ppIFormatConverter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFormatConverter** ppIFormatConverterPtr = &ppIFormatConverter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICFormatConverter**, int>)@this->LpVtbl[10])(@this, ppIFormatConverterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapScaler(IWICBitmapScaler** ppIBitmapScaler)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScaler);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapScaler(ref IWICBitmapScaler* ppIBitmapScaler)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapScaler** ppIBitmapScalerPtr = &ppIBitmapScaler)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapScaler**, int>)@this->LpVtbl[11])(@this, ppIBitmapScalerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapClipper(IWICBitmapClipper** ppIBitmapClipper)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipper);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapClipper(ref IWICBitmapClipper* ppIBitmapClipper)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapClipper** ppIBitmapClipperPtr = &ppIBitmapClipper)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapClipper**, int>)@this->LpVtbl[12])(@this, ppIBitmapClipperPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFlipRotator(IWICBitmapFlipRotator** ppIBitmapFlipRotator)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotator);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFlipRotator(ref IWICBitmapFlipRotator* ppIBitmapFlipRotator)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFlipRotator** ppIBitmapFlipRotatorPtr = &ppIBitmapFlipRotator)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFlipRotator**, int>)@this->LpVtbl[13])(@this, ppIBitmapFlipRotatorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStream(IWICStream** ppIWICStream)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStream);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStream(ref IWICStream* ppIWICStream)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICStream** ppIWICStreamPtr = &ppIWICStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICStream**, int>)@this->LpVtbl[14])(@this, ppIWICStreamPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(IWICColorContext** ppIWICColorContext)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ref IWICColorContext* ppIWICColorContext)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext** ppIWICColorContextPtr = &ppIWICColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICColorContext**, int>)@this->LpVtbl[15])(@this, ppIWICColorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorTransformer(IWICColorTransform** ppIWICColorTransform)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransform);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorTransformer(ref IWICColorTransform* ppIWICColorTransform)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorTransform** ppIWICColorTransformPtr = &ppIWICColorTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICColorTransform**, int>)@this->LpVtbl[16])(@this, ppIWICColorTransformPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormat, option, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[17])(@this, uiWidth, uiHeight, pixelFormatPtr, option, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(IWICBitmapSource* pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSource, option, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, BitmapCreateCacheOption, IWICBitmap**, int>)@this->LpVtbl[18])(@this, pIBitmapSourcePtr, option, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(IWICBitmapSource* pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSource, x, y, width, height, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* pIBitmapSourcePtr = &pIBitmapSource)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapSource*, uint, uint, uint, uint, IWICBitmap**, int>)@this->LpVtbl[19])(@this, pIBitmapSourcePtr, x, y, width, height, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pbBufferPtr = &pbBuffer)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
            }
            SilkMarshal.Free((nint)pbBufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBuffer, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
                fixed (byte* pbBufferPtr = &pbBuffer)
                {
                    fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmap);
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pixelFormatPtr = &pixelFormat)
            {
            var pbBufferPtr = (byte*) SilkMarshal.StringToPtr(pbBuffer, NativeStringEncoding.UTF8);
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Guid*, uint, uint, byte*, IWICBitmap**, int>)@this->LpVtbl[20])(@this, uiWidth, uiHeight, pixelFormatPtr, cbStride, cbBufferSize, pbBufferPtr, ppIBitmapPtr);
                }
            SilkMarshal.Free((nint)pbBufferPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP(void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalette, options, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0>(void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hPalettePtr = &hPalette)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0>(void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hPalettePtr = &hPalette)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmap, hPalettePtr, options, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0>(ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hBitmapPtr = &hBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0>(ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hBitmapPtr = &hBitmap)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalette, options, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0, T1>(ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, IWICBitmap** ppIBitmap) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hBitmapPtr = &hBitmap)
            {
                fixed (void* hPalettePtr = &hPalette)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0, T1>(ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, ref IWICBitmap* ppIBitmap) where T0 : unmanaged where T1 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hBitmapPtr = &hBitmap)
            {
                fixed (void* hPalettePtr = &hPalette)
                {
                    fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, void*, BitmapAlphaChannelOption, IWICBitmap**, int>)@this->LpVtbl[21])(@this, hBitmapPtr, hPalettePtr, options, ppIBitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(void* hIcon, IWICBitmap** ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON(void* hIcon, ref IWICBitmap* ppIBitmap)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIcon, ppIBitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON<T0>(ref T0 hIcon, IWICBitmap** ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hIconPtr = &hIcon)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON<T0>(ref T0 hIcon, ref IWICBitmap* ppIBitmap) where T0 : unmanaged
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* hIconPtr = &hIcon)
            {
                fixed (IWICBitmap** ppIBitmapPtr = &ppIBitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, void*, IWICBitmap**, int>)@this->LpVtbl[22])(@this, hIconPtr, ppIBitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentEnumerator(uint componentTypes, uint options, Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknown)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknown);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateComponentEnumerator(uint componentTypes, uint options, ref Silk.NET.Core.Win32Extras.IEnumUnknown* ppIEnumUnknown)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IEnumUnknown** ppIEnumUnknownPtr = &ppIEnumUnknown)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, uint, uint, Silk.NET.Core.Win32Extras.IEnumUnknown**, int>)@this->LpVtbl[23])(@this, componentTypes, options, ppIEnumUnknownPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(IWICBitmapDecoder* pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoder, ppIFastEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(ref IWICBitmapDecoder pIDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder(ref IWICBitmapDecoder pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapDecoder* pIDecoderPtr = &pIDecoder)
            {
                fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapDecoder*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[24])(@this, pIDecoderPtr, ppIFastEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoder);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(IWICBitmapFrameDecode* pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoder, ppIFastEncoderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(ref IWICBitmapFrameDecode pIFrameDecoder, IWICFastMetadataEncoder** ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoder);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode(ref IWICBitmapFrameDecode pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameDecode* pIFrameDecoderPtr = &pIFrameDecoder)
            {
                fixed (IWICFastMetadataEncoder** ppIFastEncoderPtr = &ppIFastEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICBitmapFrameDecode*, IWICFastMetadataEncoder**, int>)@this->LpVtbl[25])(@this, pIFrameDecoderPtr, ppIFastEncoderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendor, ppIQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormat, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendor, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[26])(@this, guidMetadataFormatPtr, pguidVendorPtr, ppIQueryWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendor, ppIQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(IWICMetadataQueryReader* pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReader, pguidVendorPtr, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendor, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader* pIQueryReaderPtr = &pIQueryReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataQueryReader*, Guid*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[27])(@this, pIQueryReaderPtr, pguidVendorPtr, ppIQueryWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendor, dwOptions, pIStream, ppIReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendor, dwOptions, pIStreamPtr, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendor, dwOptions, pIStreamPtr, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendorPtr, dwOptions, pIStream, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendorPtr, dwOptions, pIStream, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormat, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendor, dwOptions, pIStream, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendor, dwOptions, pIStream, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendor, dwOptions, pIStreamPtr, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendor, dwOptions, pIStreamPtr, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwOptions, pIStream, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwOptions, pIStream, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReader);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                    {
                        fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[28])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReaderPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendor, dwOptions, pIStream, ppIReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendor, dwOptions, pIStreamPtr, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendor, dwOptions, pIStreamPtr, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendorPtr, dwOptions, pIStream, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendorPtr, dwOptions, pIStream, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormat, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendor, dwOptions, pIStream, ppIReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendor, dwOptions, pIStream, ppIReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendor, dwOptions, pIStreamPtr, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendor, dwOptions, pIStreamPtr, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendorPtr, dwOptions, pIStream, ppIReader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, Silk.NET.Core.Win32Extras.IStream* pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendorPtr, dwOptions, pIStream, ppIReaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, IWICMetadataReader** ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReader);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref IWICMetadataReader* ppIReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidContainerFormatPtr = &guidContainerFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (Silk.NET.Core.Win32Extras.IStream* pIStreamPtr = &pIStream)
                    {
                        fixed (IWICMetadataReader** ppIReaderPtr = &ppIReader)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, Silk.NET.Core.Win32Extras.IStream*, IWICMetadataReader**, int>)@this->LpVtbl[29])(@this, guidContainerFormatPtr, pguidVendorPtr, dwOptions, pIStreamPtr, ppIReaderPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormat, pguidVendor, dwMetadataOptions, ppIWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormat, pguidVendorPtr, dwMetadataOptions, ppIWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormat, pguidVendorPtr, dwMetadataOptions, ppIWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormatPtr, pguidVendor, dwMetadataOptions, ppIWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormatPtr, pguidVendor, dwMetadataOptions, ppIWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwMetadataOptions, ppIWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* guidMetadataFormatPtr = &guidMetadataFormat)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Guid*, Guid*, uint, IWICMetadataWriter**, int>)@this->LpVtbl[30])(@this, guidMetadataFormatPtr, pguidVendorPtr, dwMetadataOptions, ppIWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReader, pguidVendor, ppIWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReader, pguidVendor, ppIWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReader, pguidVendorPtr, ppIWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(IWICMetadataReader* pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* pguidVendorPtr = &pguidVendor)
            {
                fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReader, pguidVendorPtr, ppIWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(ref IWICMetadataReader pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader* pIReaderPtr = &pIReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReaderPtr, pguidVendor, ppIWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(ref IWICMetadataReader pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader* pIReaderPtr = &pIReader)
            {
                fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReaderPtr, pguidVendor, ppIWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(ref IWICMetadataReader pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, IWICMetadataWriter** ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader* pIReaderPtr = &pIReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReaderPtr, pguidVendorPtr, ppIWriter);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader(ref IWICMetadataReader pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataWriter* ppIWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataReader* pIReaderPtr = &pIReader)
            {
                fixed (Guid* pguidVendorPtr = &pguidVendor)
                {
                    fixed (IWICMetadataWriter** ppIWriterPtr = &ppIWriter)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataReader*, Guid*, IWICMetadataWriter**, int>)@this->LpVtbl[31])(@this, pIReaderPtr, pguidVendorPtr, ppIWriterPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)@this->LpVtbl[32])(@this, pIBlockReader, ppIQueryReader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryReaderFromBlockReader(IWICMetadataBlockReader* pIBlockReader, ref IWICMetadataQueryReader* ppIQueryReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryReader** ppIQueryReaderPtr = &ppIQueryReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)@this->LpVtbl[32])(@this, pIBlockReader, ppIQueryReaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryReaderFromBlockReader(ref IWICMetadataBlockReader pIBlockReader, IWICMetadataQueryReader** ppIQueryReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataBlockReader* pIBlockReaderPtr = &pIBlockReader)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)@this->LpVtbl[32])(@this, pIBlockReaderPtr, ppIQueryReader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryReaderFromBlockReader(ref IWICMetadataBlockReader pIBlockReader, ref IWICMetadataQueryReader* ppIQueryReader)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataBlockReader* pIBlockReaderPtr = &pIBlockReader)
            {
                fixed (IWICMetadataQueryReader** ppIQueryReaderPtr = &ppIQueryReader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockReader*, IWICMetadataQueryReader**, int>)@this->LpVtbl[32])(@this, pIBlockReaderPtr, ppIQueryReaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[33])(@this, pIBlockWriter, ppIQueryWriter);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromBlockWriter(IWICMetadataBlockWriter* pIBlockWriter, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[33])(@this, pIBlockWriter, ppIQueryWriterPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromBlockWriter(ref IWICMetadataBlockWriter pIBlockWriter, IWICMetadataQueryWriter** ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataBlockWriter* pIBlockWriterPtr = &pIBlockWriter)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[33])(@this, pIBlockWriterPtr, ppIQueryWriter);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromBlockWriter(ref IWICMetadataBlockWriter pIBlockWriter, ref IWICMetadataQueryWriter* ppIQueryWriter)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICMetadataBlockWriter* pIBlockWriterPtr = &pIBlockWriter)
            {
                fixed (IWICMetadataQueryWriter** ppIQueryWriterPtr = &ppIQueryWriter)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, IWICMetadataBlockWriter*, IWICMetadataQueryWriter**, int>)@this->LpVtbl[33])(@this, pIBlockWriterPtr, ppIQueryWriterPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoderPropertyBag(Silk.NET.Core.Win32Extras.PropBag2* ppropOptions, uint cCount, Silk.NET.Core.Win32Extras.IPropertyBag2** ppIPropertyBag)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.PropBag2*, uint, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[34])(@this, ppropOptions, cCount, ppIPropertyBag);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoderPropertyBag(Silk.NET.Core.Win32Extras.PropBag2* ppropOptions, uint cCount, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppIPropertyBag)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppIPropertyBagPtr = &ppIPropertyBag)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.PropBag2*, uint, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[34])(@this, ppropOptions, cCount, ppIPropertyBagPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoderPropertyBag(ref Silk.NET.Core.Win32Extras.PropBag2 ppropOptions, uint cCount, Silk.NET.Core.Win32Extras.IPropertyBag2** ppIPropertyBag)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropBag2* ppropOptionsPtr = &ppropOptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.PropBag2*, uint, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[34])(@this, ppropOptionsPtr, cCount, ppIPropertyBag);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoderPropertyBag(ref Silk.NET.Core.Win32Extras.PropBag2 ppropOptions, uint cCount, ref Silk.NET.Core.Win32Extras.IPropertyBag2* ppIPropertyBag)
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Win32Extras.PropBag2* ppropOptionsPtr = &ppropOptions)
            {
                fixed (Silk.NET.Core.Win32Extras.IPropertyBag2** ppIPropertyBagPtr = &ppIPropertyBag)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICComponentFactory*, Silk.NET.Core.Win32Extras.PropBag2*, uint, Silk.NET.Core.Win32Extras.IPropertyBag2**, int>)@this->LpVtbl[34])(@this, ppropOptionsPtr, cCount, ppIPropertyBagPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(in wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in char wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(in wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFilename<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPWStr)] string wzFilename, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwDesiredAccess, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFilename(wzFilename, in pguidVendor, dwDesiredAccess, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0, TI1>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, pguidVendor, metadataOptions, ref ppIDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromStream<TI0, TI1>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI1> ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ComPtr<TI0> pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref IWICBitmapDecoder* ppIDecoder) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream((Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, in pguidVendor, metadataOptions, ref ppIDecoder);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromStream<TI0>(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream(ref pIStream, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromStream<TI0>(ref Silk.NET.Core.Win32Extras.IStream pIStream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromStream(ref pIStream, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoderFromFileHandle<TI0>(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFileHandle(hFile, pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoderFromFileHandle<TI0>(nuint hFile, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, DecodeOptions metadataOptions, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoderFromFileHandle(hFile, in pguidVendor, metadataOptions, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateComponentInfo<TI0>(out ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIInfo = default;
            return @this->CreateComponentInfo(SilkMarshal.GuidPtrOf<TI0>(), (IWICComponentInfo**) ppIInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateComponentInfo<TI0>(ref Guid clsidComponent, ref ComPtr<TI0> ppIInfo) where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateComponentInfo(ref clsidComponent, (IWICComponentInfo**) ppIInfo.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder<TI0>(Guid* guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIDecoder = default;
            return @this->CreateDecoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateDecoder<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoder(guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoder<TI0>(ref Guid guidContainerFormat, out ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIDecoder = default;
            return @this->CreateDecoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateDecoder<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIDecoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateDecoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapDecoder**) ppIDecoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder<TI0>(Guid* guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIEncoder = default;
            return @this->CreateEncoder(guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEncoder<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEncoder(guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEncoder<TI0>(ref Guid guidContainerFormat, out ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIEncoder = default;
            return @this->CreateEncoder(ref guidContainerFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateEncoder<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateEncoder(ref guidContainerFormat, in pguidVendor, (IWICBitmapEncoder**) ppIEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePalette<TI0>(ref ComPtr<TI0> ppIPalette) where TI0 : unmanaged, IComVtbl<IWICPalette>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePalette((IWICPalette**) ppIPalette.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFormatConverter<TI0>(ref ComPtr<TI0> ppIFormatConverter) where TI0 : unmanaged, IComVtbl<IWICFormatConverter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFormatConverter((IWICFormatConverter**) ppIFormatConverter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapScaler<TI0>(ref ComPtr<TI0> ppIBitmapScaler) where TI0 : unmanaged, IComVtbl<IWICBitmapScaler>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapScaler((IWICBitmapScaler**) ppIBitmapScaler.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapClipper<TI0>(ref ComPtr<TI0> ppIBitmapClipper) where TI0 : unmanaged, IComVtbl<IWICBitmapClipper>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapClipper((IWICBitmapClipper**) ppIBitmapClipper.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFlipRotator<TI0>(ref ComPtr<TI0> ppIBitmapFlipRotator) where TI0 : unmanaged, IComVtbl<IWICBitmapFlipRotator>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFlipRotator((IWICBitmapFlipRotator**) ppIBitmapFlipRotator.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateStream<TI0>(ref ComPtr<TI0> ppIWICStream) where TI0 : unmanaged, IComVtbl<IWICStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateStream((IWICStream**) ppIWICStream.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorContext<TI0>(ref ComPtr<TI0> ppIWICColorContext) where TI0 : unmanaged, IComVtbl<IWICColorContext>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorContext((IWICColorContext**) ppIWICColorContext.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateColorTransformer<TI0>(ref ComPtr<TI0> ppIWICColorTransform) where TI0 : unmanaged, IComVtbl<IWICColorTransform>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateColorTransformer((IWICColorTransform**) ppIWICColorTransform.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmap(uiWidth, uiHeight, pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmap<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmap(uiWidth, uiHeight, ref pixelFormat, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSource<TI0, TI1>(ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSource<TI0>(ComPtr<TI0> pIBitmapSource, BitmapCreateCacheOption option, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource((IWICBitmapSource*) pIBitmapSource.Handle, option, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSource<TI0>(ref IWICBitmapSource pIBitmapSource, BitmapCreateCacheOption option, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSource(ref pIBitmapSource, option, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSourceRect<TI0, TI1>(ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI1> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromSourceRect<TI0>(ComPtr<TI0> pIBitmapSource, uint x, uint y, uint width, uint height, ref IWICBitmap* ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmapSource>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect((IWICBitmapSource*) pIBitmapSource.Handle, x, y, width, height, ref ppIBitmap);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromSourceRect<TI0>(ref IWICBitmapSource pIBitmapSource, uint x, uint y, uint width, uint height, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromSourceRect(ref pIBitmapSource, x, y, width, height, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, Guid* pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, byte* pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, ref byte pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, ref pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromMemory<TI0>(uint uiWidth, uint uiHeight, ref Guid pixelFormat, uint cbStride, uint cbBufferSize, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pbBuffer, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromMemory(uiWidth, uiHeight, ref pixelFormat, cbStride, cbBufferSize, pbBuffer, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<TI0>(void* hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0, TI0>(void* hBitmap, ref T0 hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHBITMAP<T0, TI0>(ref T0 hBitmap, void* hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(ref hBitmap, hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromHBITMAP<T0, T1, TI0>(ref T0 hBitmap, ref T1 hPalette, BitmapAlphaChannelOption options, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where T1 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHBITMAP(ref hBitmap, ref hPalette, options, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromHICON<TI0>(void* hIcon, ref ComPtr<TI0> ppIBitmap) where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHICON(hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateBitmapFromHICON<T0, TI0>(ref T0 hIcon, ref ComPtr<TI0> ppIBitmap) where T0 : unmanaged where TI0 : unmanaged, IComVtbl<IWICBitmap>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateBitmapFromHICON(ref hIcon, (IWICBitmap**) ppIBitmap.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromDecoder<TI0, TI1>(ComPtr<TI0> pIDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromDecoder<TI0>(ComPtr<TI0> pIDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder((IWICBitmapDecoder*) pIDecoder.Handle, ref ppIFastEncoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromDecoder<TI0>(ref IWICBitmapDecoder pIDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromDecoder(ref pIDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromFrameDecode<TI0, TI1>(ComPtr<TI0> pIFrameDecoder, ref ComPtr<TI1> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFastMetadataEncoderFromFrameDecode<TI0>(ComPtr<TI0> pIFrameDecoder, ref IWICFastMetadataEncoder* ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameDecode>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode((IWICBitmapFrameDecode*) pIFrameDecoder.Handle, ref ppIFastEncoder);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateFastMetadataEncoderFromFrameDecode<TI0>(ref IWICBitmapFrameDecode pIFrameDecoder, ref ComPtr<TI0> ppIFastEncoder) where TI0 : unmanaged, IComVtbl<IWICFastMetadataEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateFastMetadataEncoderFromFrameDecode(ref pIFrameDecoder, (IWICFastMetadataEncoder**) ppIFastEncoder.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter<TI0>(Guid* guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriter(guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriter<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriter(guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriter<TI0>(ref Guid guidMetadataFormat, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriter(ref guidMetadataFormat, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriter<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriter(ref guidMetadataFormat, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader, out ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader<TI0>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, pguidVendor, ref ppIQueryWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromReader<TI0>(ComPtr<TI0> pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader((IWICMetadataQueryReader*) pIQueryReader.Handle, in pguidVendor, ref ppIQueryWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader, out ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIQueryWriter = default;
            return @this->CreateQueryWriterFromReader(ref pIQueryReader, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromReader(ref pIQueryReader, in pguidVendor, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0, TI1>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0, TI1>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(guidMetadataFormat, in pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0, TI1>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataReader<TI0, TI1>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReader<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataReader<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReader(ref guidMetadataFormat, in pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0, TI1>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0, TI1>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(Guid* guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(guidContainerFormat, in pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0, TI1>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataReaderFromContainer<TI0, TI1>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref ComPtr<TI1> ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataReaderFromContainer<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ComPtr<TI0> pIStream, ref IWICMetadataReader* ppIReader) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Win32Extras.IStream>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, in pguidVendor, dwOptions, (Silk.NET.Core.Win32Extras.IStream*) pIStream.Handle, ref ppIReader);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataReaderFromContainer<TI0>(ref Guid guidContainerFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwOptions, ref Silk.NET.Core.Win32Extras.IStream pIStream, ref ComPtr<TI0> ppIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataReaderFromContainer(ref guidContainerFormat, in pguidVendor, dwOptions, ref pIStream, (IWICMetadataReader**) ppIReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, ref ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriter(guidMetadataFormat, pguidVendor, dwMetadataOptions, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter<TI0>(Guid* guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, ref ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriter(guidMetadataFormat, in pguidVendor, dwMetadataOptions, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriter<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, uint dwMetadataOptions, ref ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriter(ref guidMetadataFormat, pguidVendor, dwMetadataOptions, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataWriter<TI0>(ref Guid guidMetadataFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, uint dwMetadataOptions, ref ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriter(ref guidMetadataFormat, in pguidVendor, dwMetadataOptions, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataWriterFromReader<TI0, TI1>(ComPtr<TI0> pIReader, out ComPtr<TI1> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIWriter = default;
            return @this->CreateMetadataWriterFromReader((IWICMetadataReader*) pIReader.Handle, SilkMarshal.GuidPtrOf<TI1>(), (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader<TI0>(ComPtr<TI0> pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* pguidVendor, ref IWICMetadataWriter* ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriterFromReader((IWICMetadataReader*) pIReader.Handle, pguidVendor, ref ppIWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataWriterFromReader<TI0, TI1>(ComPtr<TI0> pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI1> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriterFromReader((IWICMetadataReader*) pIReader.Handle, in pguidVendor, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMetadataWriterFromReader<TI0>(ComPtr<TI0> pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref IWICMetadataWriter* ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriterFromReader((IWICMetadataReader*) pIReader.Handle, in pguidVendor, ref ppIWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataWriterFromReader<TI0>(ref IWICMetadataReader pIReader, out ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppIWriter = default;
            return @this->CreateMetadataWriterFromReader(ref pIReader, SilkMarshal.GuidPtrOf<TI0>(), (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateMetadataWriterFromReader<TI0>(ref IWICMetadataReader pIReader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid pguidVendor, ref ComPtr<TI0> ppIWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateMetadataWriterFromReader(ref pIReader, in pguidVendor, (IWICMetadataWriter**) ppIWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryReaderFromBlockReader<TI0, TI1>(ComPtr<TI0> pIBlockReader, ref ComPtr<TI1> ppIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataBlockReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryReaderFromBlockReader((IWICMetadataBlockReader*) pIBlockReader.Handle, (IWICMetadataQueryReader**) ppIQueryReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryReaderFromBlockReader<TI0>(ComPtr<TI0> pIBlockReader, ref IWICMetadataQueryReader* ppIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataBlockReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryReaderFromBlockReader((IWICMetadataBlockReader*) pIBlockReader.Handle, ref ppIQueryReader);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryReaderFromBlockReader<TI0>(ref IWICMetadataBlockReader pIBlockReader, ref ComPtr<TI0> ppIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryReaderFromBlockReader(ref pIBlockReader, (IWICMetadataQueryReader**) ppIQueryReader.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromBlockWriter<TI0, TI1>(ComPtr<TI0> pIBlockWriter, ref ComPtr<TI1> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataBlockWriter>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromBlockWriter((IWICMetadataBlockWriter*) pIBlockWriter.Handle, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueryWriterFromBlockWriter<TI0>(ComPtr<TI0> pIBlockWriter, ref IWICMetadataQueryWriter* ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataBlockWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromBlockWriter((IWICMetadataBlockWriter*) pIBlockWriter.Handle, ref ppIQueryWriter);
        }

        /// <summary>To be documented.</summary>
        public readonly int CreateQueryWriterFromBlockWriter<TI0>(ref IWICMetadataBlockWriter pIBlockWriter, ref ComPtr<TI0> ppIQueryWriter) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreateQueryWriterFromBlockWriter(ref pIBlockWriter, (IWICMetadataQueryWriter**) ppIQueryWriter.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateComponentInfo<TI0>() where TI0 : unmanaged, IComVtbl<IWICComponentInfo>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateComponentInfo(out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateDecoder<TI0>(Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDecoder(guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateDecoder<TI0>(ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapDecoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateDecoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateEncoder<TI0>(Guid* guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateEncoder(guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateEncoder<TI0>(ref Guid guidContainerFormat) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateEncoder(ref guidContainerFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe ComPtr<TI0> CreateQueryWriter<TI0>(Guid* guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriter(guidMetadataFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateQueryWriter<TI0>(ref Guid guidMetadataFormat) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriter(ref guidMetadataFormat, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateQueryWriterFromReader<TI0, TI1>(ComPtr<TI0> pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(pIQueryReader, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateQueryWriterFromReader<TI0>(ref IWICMetadataQueryReader pIQueryReader) where TI0 : unmanaged, IComVtbl<IWICMetadataQueryWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateQueryWriterFromReader(ref pIQueryReader, out ComPtr<TI0> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI1> CreateMetadataWriterFromReader<TI0, TI1>(ComPtr<TI0> pIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataReader>, IComVtbl<TI0> where TI1 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI1>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetadataWriterFromReader(pIReader, out ComPtr<TI1> silkRet));
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> CreateMetadataWriterFromReader<TI0>(ref IWICMetadataReader pIReader) where TI0 : unmanaged, IComVtbl<IWICMetadataWriter>, IComVtbl<TI0>
        {
            var @this = (IWICComponentFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->CreateMetadataWriterFromReader(ref pIReader, out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
