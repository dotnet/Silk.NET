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
    [Guid("04c75bf8-3ce1-473b-acc5-3cc4f5e94999")]
    [NativeName("Name", "IWICImageEncoder")]
    public unsafe partial struct IWICImageEncoder : IComVtbl<IWICImageEncoder>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("04c75bf8-3ce1-473b-acc5-3cc4f5e94999");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IWICImageEncoder val)
            => Unsafe.As<IWICImageEncoder, Silk.NET.Core.Native.IUnknown>(ref val);

        public IWICImageEncoder
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
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncode, pImageParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncode, pImageParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncodePtr, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImage, pFrameEncodePtr, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncode, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncode, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncodePtr, pImageParameters);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteFrame(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
                {
                    fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[3])(@this, pImagePtr, pFrameEncodePtr, pImageParametersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncode, pImageParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncode, pImageParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncodePtr, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImage, pFrameEncodePtr, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncode, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapFrameEncode* pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncode, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncodePtr, pImageParameters);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteFrameThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapFrameEncode pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapFrameEncode* pFrameEncodePtr = &pFrameEncode)
                {
                    fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapFrameEncode*, ImageParameters*, int>)@this->LpVtbl[4])(@this, pImagePtr, pFrameEncodePtr, pImageParametersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoder, pImageParameters);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoder, pImageParametersPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoderPtr, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(Silk.NET.Direct2D.ID2D1Image* pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImage, pEncoderPtr, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoder, pImageParameters);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, IWICBitmapEncoder* pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoder, pImageParametersPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoderPtr, pImageParameters);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteThumbnail(ref Silk.NET.Direct2D.ID2D1Image pImage, ref IWICBitmapEncoder pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters)
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Direct2D.ID2D1Image* pImagePtr = &pImage)
            {
                fixed (IWICBitmapEncoder* pEncoderPtr = &pEncoder)
                {
                    fixed (ImageParameters* pImageParametersPtr = &pImageParameters)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IWICImageEncoder*, Silk.NET.Direct2D.ID2D1Image*, IWICBitmapEncoder*, ImageParameters*, int>)@this->LpVtbl[5])(@this, pImagePtr, pEncoderPtr, pImageParametersPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrame(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrame(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrame<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrame(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteFrame<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrame(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrameThumbnail(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrameThumbnail(pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteFrameThumbnail<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrameThumbnail(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteFrameThumbnail<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pFrameEncode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapFrameEncode>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteFrameThumbnail(ref pImage, (IWICBitmapFrameEncode*) pFrameEncode.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteThumbnail(pImage, (IWICBitmapEncoder*) pEncoder.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail<TI0>(Silk.NET.Direct2D.ID2D1Image* pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteThumbnail(pImage, (IWICBitmapEncoder*) pEncoder.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int WriteThumbnail<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ImageParameters* pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteThumbnail(ref pImage, (IWICBitmapEncoder*) pEncoder.Handle, pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly int WriteThumbnail<TI0>(ref Silk.NET.Direct2D.ID2D1Image pImage, ComPtr<TI0> pEncoder, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ImageParameters pImageParameters) where TI0 : unmanaged, IComVtbl<IWICBitmapEncoder>, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->WriteThumbnail(ref pImage, (IWICBitmapEncoder*) pEncoder.Handle, in pImageParameters);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IWICImageEncoder*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
