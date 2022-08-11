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

namespace Silk.NET.Direct2D
{
    [Guid("2cd90695-12e2-11dc-9fed-001143a055f9")]
    [NativeName("Name", "ID2D1BitmapRenderTarget")]
    public unsafe partial struct ID2D1BitmapRenderTarget
    {
        public static readonly Guid Guid = new("2cd90695-12e2-11dc-9fed-001143a055f9");

        public static implicit operator ID2D1RenderTarget(ID2D1BitmapRenderTarget val)
            => Unsafe.As<ID2D1BitmapRenderTarget, ID2D1RenderTarget>(ref val);

        public static implicit operator ID2D1Resource(ID2D1BitmapRenderTarget val)
            => Unsafe.As<ID2D1BitmapRenderTarget, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1BitmapRenderTarget val)
            => Unsafe.As<ID2D1BitmapRenderTarget, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1BitmapRenderTarget
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
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                    {
                        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushProperties, solidColorBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientStop* gradientStopsPtr = &gradientStops)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientStop* gradientStopsPtr = &gradientStops)
            {
                fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                    {
                        fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, size, layer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(Silk.NET.Maths.Vector2D<float>* size, ref ID2D1Layer* layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Layer** layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, size, layerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(ref Silk.NET.Maths.Vector2D<float> size, ID2D1Layer** layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, sizePtr, layer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(ref Silk.NET.Maths.Vector2D<float> size, ref ID2D1Layer* layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
            {
                fixed (ID2D1Layer** layerPtr = &layer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, sizePtr, layerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMesh(ID2D1Mesh** mesh)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh**, int>)LpVtbl[14])(@this, mesh);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMesh(ref ID2D1Mesh* mesh)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Mesh** meshPtr = &mesh)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh**, int>)LpVtbl[14])(@this, meshPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rect, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rect, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rectPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rectPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRect, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRect, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRectPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRectPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawEllipse(ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(Ellipse* ellipse, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipse, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(Ellipse* ellipse, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipse, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(ref Ellipse ellipse, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipsePtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillEllipse(ref Ellipse ellipse, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipsePtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brush, opacityBrush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brush, opacityBrushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brushPtr, opacityBrush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brushPtr, opacityBrushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brush, opacityBrush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brush, opacityBrushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrush);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, mesh, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ID2D1Mesh* mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, mesh, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ref ID2D1Mesh mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, meshPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillMesh(ref ID2D1Mesh mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, meshPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectanglePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                        {
                            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawBitmap(ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                    {
                        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                        {
                            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayout, defaultFillBrushPtr, options);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrush, options);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrushPtr, options);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrushPtr, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrush, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrushPtr, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[30])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[30])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[31])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[31])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetAntialiasMode(AntialiasMode antialiasMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, AntialiasMode, void>)LpVtbl[32])(@this, antialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly AntialiasMode GetAntialiasMode()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            AntialiasMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, AntialiasMode>)LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, TextAntialiasMode, void>)LpVtbl[34])(@this, textAntialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly TextAntialiasMode GetTextAntialiasMode()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAntialiasMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, TextAntialiasMode>)LpVtbl[35])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IDWriteRenderingParams*, void>)LpVtbl[36])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTextRenderingParams(ref IDWriteRenderingParams textRenderingParams)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IDWriteRenderingParams*, void>)LpVtbl[36])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IDWriteRenderingParams**, void>)LpVtbl[37])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(ref IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, IDWriteRenderingParams**, void>)LpVtbl[37])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTags(ulong tag1, ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong, ulong, void>)LpVtbl[38])(@this, tag1, tag2);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1, tag2);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag2Ptr = &tag2)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1, tag2Ptr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag1Ptr = &tag1)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1Ptr, tag2);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetTags(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1Ptr, tag2Ptr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(LayerParameters* layerParameters, ID2D1Layer* layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParameters, layer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(LayerParameters* layerParameters, ref ID2D1Layer layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParameters, layerPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(ref LayerParameters layerParameters, ID2D1Layer* layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (LayerParameters* layerParametersPtr = &layerParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParametersPtr, layer);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PushLayer(ref LayerParameters layerParameters, ref ID2D1Layer layer)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (LayerParameters* layerParametersPtr = &layerParameters)
            {
                fixed (ID2D1Layer* layerPtr = &layer)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParametersPtr, layerPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PopLayer()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)LpVtbl[41])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1, tag2Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1Ptr, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Flush(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1Ptr, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)LpVtbl[43])(@this, drawingStateBlock);
        }

        /// <summary>To be documented.</summary>
        public readonly void SaveDrawingState(ref ID2D1DrawingStateBlock drawingStateBlock)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)LpVtbl[43])(@this, drawingStateBlockPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)LpVtbl[44])(@this, drawingStateBlock);
        }

        /// <summary>To be documented.</summary>
        public readonly void RestoreDrawingState(ref ID2D1DrawingStateBlock drawingStateBlock)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1DrawingStateBlock*, void>)LpVtbl[44])(@this, drawingStateBlockPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushAxisAlignedClip(Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)LpVtbl[45])(@this, clipRect, antialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void PushAxisAlignedClip(ref Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)LpVtbl[45])(@this, clipRectPtr, antialiasMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PopAxisAlignedClip()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)LpVtbl[46])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Clear(Silk.NET.DXGI.D3Dcolorvalue* clearColor)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[47])(@this, clearColor);
        }

        /// <summary>To be documented.</summary>
        public readonly void Clear(ref Silk.NET.DXGI.D3Dcolorvalue clearColor)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.D3Dcolorvalue* clearColorPtr = &clearColor)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[47])(@this, clearColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginDraw()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, void>)LpVtbl[48])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1, tag2Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1Ptr, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1Ptr, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelFormat GetPixelFormat()
        {
            PixelFormat silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelFormat* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, PixelFormat*, PixelFormat*>)LpVtbl[50])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDpi(float dpiX, float dpiY)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float, float, void>)LpVtbl[51])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float*, float*, void>)LpVtbl[52])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float*, float*, void>)LpVtbl[52])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float*, float*, void>)LpVtbl[52])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, float*, float*, void>)LpVtbl[52])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetSize()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)LpVtbl[53])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<uint> GetPixelSize()
        {
            Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<uint>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)LpVtbl[54])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMaximumBitmapSize()
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, uint>)LpVtbl[55])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsSupported(RenderTargetProperties* renderTargetProperties)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RenderTargetProperties*, int>)LpVtbl[56])(@this, renderTargetProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsSupported(ref RenderTargetProperties renderTargetProperties)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, RenderTargetProperties*, int>)LpVtbl[56])(@this, renderTargetPropertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBitmap(ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap**, int>)LpVtbl[57])(@this, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBitmap(ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1BitmapRenderTarget*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BitmapRenderTarget*, ID2D1Bitmap**, int>)LpVtbl[57])(@this, bitmapPtr);
            }
            return ret;
        }

    }
}
