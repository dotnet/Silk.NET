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
    [Guid("7836d248-68cc-4df6-b9e8-de991bf62eb7")]
    [NativeName("Name", "ID2D1DeviceContext5")]
    public unsafe partial struct ID2D1DeviceContext5
    {
        public static readonly Guid Guid = new("7836d248-68cc-4df6-b9e8-de991bf62eb7");

        public static implicit operator ID2D1DeviceContext4(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1DeviceContext4>(ref val);

        public static implicit operator ID2D1DeviceContext3(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1DeviceContext3>(ref val);

        public static implicit operator ID2D1DeviceContext2(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1DeviceContext2>(ref val);

        public static implicit operator ID2D1DeviceContext1(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1DeviceContext1>(ref val);

        public static implicit operator ID2D1DeviceContext(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1DeviceContext>(ref val);

        public static implicit operator ID2D1RenderTarget(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1RenderTarget>(ref val);

        public static implicit operator ID2D1Resource(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1DeviceContext5 val)
            => Unsafe.As<ID2D1DeviceContext5, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1DeviceContext5
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
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap(Silk.NET.Maths.Vector2D<uint> size, void* srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcData, pitch, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmap<T0>(Silk.NET.Maths.Vector2D<uint> size, ref T0 srcData, uint pitch, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* srcDataPtr = &srcData)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>, void*, uint, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[4])(@this, size, srcDataPtr, pitch, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSource, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromWicBitmap(ref IWICBitmapSource wicBitmapSource, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[5])(@this, wicBitmapSourcePtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(Guid* riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, data, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(Guid* riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void* dataPtr = &data)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riid, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap(ref Guid riid, void* data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, data, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, BitmapProperties* bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapProperties, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ID2D1Bitmap** bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmap);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSharedBitmap<T0>(ref Guid riid, ref T0 data, ref BitmapProperties bitmapProperties, ref ID2D1Bitmap* bitmap) where T0 : unmanaged
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void* dataPtr = &data)
                {
                    fixed (BitmapProperties* bitmapPropertiesPtr = &bitmapProperties)
                    {
                        fixed (ID2D1Bitmap** bitmapPtr = &bitmap)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, void*, BitmapProperties*, ID2D1Bitmap**, int>)LpVtbl[6])(@this, riidPtr, dataPtr, bitmapPropertiesPtr, bitmapPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ID2D1Bitmap* bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmap, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushProperties, bitmapBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, BitmapBrushProperties* bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushProperties, brushPropertiesPtr, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, BrushProperties* brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushProperties, bitmapBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapBrush(ref ID2D1Bitmap bitmap, ref BitmapBrushProperties bitmapBrushProperties, ref BrushProperties brushProperties, ref ID2D1BitmapBrush* bitmapBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (BitmapBrushProperties* bitmapBrushPropertiesPtr = &bitmapBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        fixed (ID2D1BitmapBrush** bitmapBrushPtr = &bitmapBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, BitmapBrushProperties*, BrushProperties*, ID2D1BitmapBrush**, int>)LpVtbl[7])(@this, bitmapPtr, bitmapBrushPropertiesPtr, brushPropertiesPtr, bitmapBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushProperties, solidColorBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushProperties, solidColorBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(Silk.NET.DXGI.D3Dcolorvalue* color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, color, brushPropertiesPtr, solidColorBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, BrushProperties* brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushProperties, solidColorBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSolidColorBrush(ref Silk.NET.DXGI.D3Dcolorvalue color, ref BrushProperties brushProperties, ref ID2D1SolidColorBrush* solidColorBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1SolidColorBrush** solidColorBrushPtr = &solidColorBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, BrushProperties*, ID2D1SolidColorBrush**, int>)LpVtbl[8])(@this, colorPtr, brushPropertiesPtr, solidColorBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(GradientStop* gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientStop* gradientStopsPtr = &gradientStops)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientStopCollection(ref GradientStop gradientStops, uint gradientStopsCount, Gamma colorInterpolationGamma, ExtendMode extendMode, ref ID2D1GradientStopCollection* gradientStopCollection)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientStop* gradientStopsPtr = &gradientStops)
            {
                fixed (ID2D1GradientStopCollection** gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientStop*, uint, Gamma, ExtendMode, ID2D1GradientStopCollection**, int>)LpVtbl[9])(@this, gradientStopsPtr, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollectionPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(LinearGradientBrushProperties* linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, linearGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, linearGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLinearGradientBrush(ref LinearGradientBrushProperties linearGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1LinearGradientBrush* linearGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LinearGradientBrushProperties* linearGradientBrushPropertiesPtr = &linearGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        fixed (ID2D1LinearGradientBrush** linearGradientBrushPtr = &linearGradientBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LinearGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)LpVtbl[10])(@this, linearGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, linearGradientBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(RadialGradientBrushProperties* radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushProperties, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollection, radialGradientBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, BrushProperties* brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushProperties, gradientStopCollectionPtr, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollection, radialGradientBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateRadialGradientBrush(ref RadialGradientBrushProperties radialGradientBrushProperties, ref BrushProperties brushProperties, ref ID2D1GradientStopCollection gradientStopCollection, ref ID2D1RadialGradientBrush* radialGradientBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RadialGradientBrushProperties* radialGradientBrushPropertiesPtr = &radialGradientBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1GradientStopCollection* gradientStopCollectionPtr = &gradientStopCollection)
                    {
                        fixed (ID2D1RadialGradientBrush** radialGradientBrushPtr = &radialGradientBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RadialGradientBrushProperties*, BrushProperties*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)LpVtbl[11])(@this, radialGradientBrushPropertiesPtr, brushPropertiesPtr, gradientStopCollectionPtr, radialGradientBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(Silk.NET.Maths.Vector2D<float>* desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSize, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormat, options, bitmapRenderTargetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, Silk.NET.Maths.Vector2D<uint>* desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSize, desiredFormatPtr, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTarget);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, PixelFormat* desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormat, options, bitmapRenderTargetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTarget);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCompatibleRenderTarget(ref Silk.NET.Maths.Vector2D<float> desiredSize, ref Silk.NET.Maths.Vector2D<uint> desiredPixelSize, ref PixelFormat desiredFormat, CompatibleRenderTargetOptions options, ref ID2D1BitmapRenderTarget* bitmapRenderTarget)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* desiredSizePtr = &desiredSize)
            {
                fixed (Silk.NET.Maths.Vector2D<uint>* desiredPixelSizePtr = &desiredPixelSize)
                {
                    fixed (PixelFormat* desiredFormatPtr = &desiredFormat)
                    {
                        fixed (ID2D1BitmapRenderTarget** bitmapRenderTargetPtr = &bitmapRenderTarget)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<uint>*, PixelFormat*, CompatibleRenderTargetOptions, ID2D1BitmapRenderTarget**, int>)LpVtbl[12])(@this, desiredSizePtr, desiredPixelSizePtr, desiredFormatPtr, options, bitmapRenderTargetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(Silk.NET.Maths.Vector2D<float>* size, ID2D1Layer** layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, size, layer);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(Silk.NET.Maths.Vector2D<float>* size, ref ID2D1Layer* layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Layer** layerPtr = &layer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, size, layerPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(ref Silk.NET.Maths.Vector2D<float> size, ID2D1Layer** layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, sizePtr, layer);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLayer(ref Silk.NET.Maths.Vector2D<float> size, ref ID2D1Layer* layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<float>* sizePtr = &size)
            {
                fixed (ID2D1Layer** layerPtr = &layer)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, ID2D1Layer**, int>)LpVtbl[13])(@this, sizePtr, layerPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMesh(ID2D1Mesh** mesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh**, int>)LpVtbl[14])(@this, mesh);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateMesh(ref ID2D1Mesh* mesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Mesh** meshPtr = &mesh)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh**, int>)LpVtbl[14])(@this, meshPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawLine(Silk.NET.Maths.Vector2D<float> point0, Silk.NET.Maths.Vector2D<float> point1, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Maths.Vector2D<float>, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[15])(@this, point0, point1, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rect, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[16])(@this, rectPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(Silk.NET.Maths.Box2D<float>* rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rect, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(Silk.NET.Maths.Box2D<float>* rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rect, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRectangle(ref Silk.NET.Maths.Box2D<float> rect, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rectPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillRectangle(ref Silk.NET.Maths.Box2D<float> rect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* rectPtr = &rect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, void>)LpVtbl[17])(@this, rectPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRect, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[18])(@this, roundedRectPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(RoundedRect* roundedRect, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRect, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(RoundedRect* roundedRect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRect, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillRoundedRectangle(ref RoundedRect roundedRect, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRectPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillRoundedRectangle(ref RoundedRect roundedRect, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RoundedRect* roundedRectPtr = &roundedRect)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RoundedRect*, ID2D1Brush*, void>)LpVtbl[19])(@this, roundedRectPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(Ellipse* ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipse, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawEllipse(ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawEllipse(ref Ellipse ellipse, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[20])(@this, ellipsePtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(Ellipse* ellipse, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipse, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(Ellipse* ellipse, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipse, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillEllipse(ref Ellipse ellipse, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipsePtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillEllipse(ref Ellipse ellipse, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Ellipse* ellipsePtr = &ellipse)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Ellipse*, ID2D1Brush*, void>)LpVtbl[21])(@this, ellipsePtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brush, strokeWidth, strokeStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometry, brushPtr, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brush, strokeWidth, strokeStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle* strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, float strokeWidth, ref ID2D1StrokeStyle strokeStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)LpVtbl[22])(@this, geometryPtr, brushPtr, strokeWidth, strokeStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brush, opacityBrush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brush, opacityBrushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brushPtr, opacityBrush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ID2D1Geometry* geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometry, brushPtr, opacityBrushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brush, opacityBrush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ID2D1Brush* brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brush, opacityBrushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ID2D1Brush* opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrush);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillGeometry(ref ID2D1Geometry geometry, ref ID2D1Brush brush, ref ID2D1Brush opacityBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1Brush* opacityBrushPtr = &opacityBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)LpVtbl[23])(@this, geometryPtr, brushPtr, opacityBrushPtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, mesh, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ID2D1Mesh* mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, mesh, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillMesh(ref ID2D1Mesh mesh, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, meshPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillMesh(ref ID2D1Mesh mesh, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Mesh* meshPtr = &mesh)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Mesh*, ID2D1Brush*, void>)LpVtbl[24])(@this, meshPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectangle, sourceRectanglePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ID2D1Bitmap* opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMask, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectangle, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ID2D1Brush* brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brush, content, destinationRectanglePtr, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, Silk.NET.Maths.Box2D<float>* destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectangle, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectangle);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void FillOpacityMask(ref ID2D1Bitmap opacityMask, ref ID2D1Brush brush, OpacityMaskContent content, ref Silk.NET.Maths.Box2D<float> destinationRectangle, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* opacityMaskPtr = &opacityMask)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                    {
                        fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                        {
                            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, ID2D1Brush*, OpacityMaskContent, Silk.NET.Maths.Box2D<float>*, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[25])(@this, opacityMaskPtr, brushPtr, content, destinationRectanglePtr, sourceRectanglePtr);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ID2D1Bitmap* bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmap, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectangle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, Silk.NET.Maths.Box2D<float>* destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectangle, opacity, interpolationMode, sourceRectanglePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawBitmap(ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, Silk.NET.Maths.Box2D<float>* sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectangle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawBitmap(ref ID2D1Bitmap bitmap, ref Silk.NET.Maths.Box2D<float> destinationRectangle, float opacity, BitmapInterpolationMode interpolationMode, ref Silk.NET.Maths.Box2D<float> sourceRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                fixed (Silk.NET.Maths.Box2D<float>* destinationRectanglePtr = &destinationRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* sourceRectanglePtr = &sourceRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Bitmap*, Silk.NET.Maths.Box2D<float>*, float, BitmapInterpolationMode, Silk.NET.Maths.Box2D<float>*, void>)LpVtbl[26])(@this, bitmapPtr, destinationRectanglePtr, opacity, interpolationMode, sourceRectanglePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(char* @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @string, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextA(ref char @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (char* @stringPtr = &@string)
            {
                fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                    {
                        fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                        {
                            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                        }
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRect, defaultFillBrushPtr, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrush, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, IDWriteTextFormat* textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormat, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrush, options, measuringMode);
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, Silk.NET.Maths.Box2D<float>* layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRect, defaultFillBrushPtr, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ID2D1Brush* defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrush, options, measuringMode);
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextA([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string @string, uint stringLength, ref IDWriteTextFormat textFormat, ref Silk.NET.Maths.Box2D<float> layoutRect, ref ID2D1Brush defaultFillBrush, DrawTextOptions options, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            var @stringPtr = (byte*) SilkMarshal.StringToPtr(@string, NativeStringEncoding.UTF8);
            fixed (IDWriteTextFormat* textFormatPtr = &textFormat)
            {
                fixed (Silk.NET.Maths.Box2D<float>* layoutRectPtr = &layoutRect)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, uint, IDWriteTextFormat*, Silk.NET.Maths.Box2D<float>*, ID2D1Brush*, DrawTextOptions, DwriteMeasuringMode, void>)LpVtbl[27])(@this, @stringPtr, stringLength, textFormatPtr, layoutRectPtr, defaultFillBrushPtr, options, measuringMode);
                    }
                }
            }
            SilkMarshal.Free((nint)@stringPtr);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayout, defaultFillBrush, options);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, IDWriteTextLayout* textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayout, defaultFillBrushPtr, options);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ID2D1Brush* defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrush, options);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawTextLayout(Silk.NET.Maths.Vector2D<float> origin, ref IDWriteTextLayout textLayout, ref ID2D1Brush defaultFillBrush, DrawTextOptions options)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteTextLayout* textLayoutPtr = &textLayout)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteTextLayout*, ID2D1Brush*, DrawTextOptions, void>)LpVtbl[28])(@this, origin, textLayoutPtr, defaultFillBrushPtr, options);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRun, foregroundBrushPtr, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ID2D1Brush* foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrush, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ref ID2D1Brush foregroundBrush, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (ID2D1Brush* foregroundBrushPtr = &foregroundBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, DwriteMeasuringMode, void>)LpVtbl[29])(@this, baselineOrigin, glyphRunPtr, foregroundBrushPtr, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[30])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[30])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTransform(Silk.NET.Maths.Matrix3X2<float>* transform)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[31])(@this, transform);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetTransform(ref Silk.NET.Maths.Matrix3X2<float> transform)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Matrix3X2<float>* transformPtr = &transform)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Matrix3X2<float>*, void>)LpVtbl[31])(@this, transformPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetAntialiasMode(AntialiasMode antialiasMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, AntialiasMode, void>)LpVtbl[32])(@this, antialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly AntialiasMode GetAntialiasMode()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            AntialiasMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, AntialiasMode>)LpVtbl[33])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTextAntialiasMode(TextAntialiasMode textAntialiasMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, TextAntialiasMode, void>)LpVtbl[34])(@this, textAntialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly TextAntialiasMode GetTextAntialiasMode()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            TextAntialiasMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, TextAntialiasMode>)LpVtbl[35])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams*, void>)LpVtbl[36])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTextRenderingParams(ref IDWriteRenderingParams textRenderingParams)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams* textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams*, void>)LpVtbl[36])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams**, void>)LpVtbl[37])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(ref IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IDWriteRenderingParams**, void>)LpVtbl[37])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTags(ulong tag1, ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong, ulong, void>)LpVtbl[38])(@this, tag1, tag2);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1, tag2);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag2Ptr = &tag2)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1, tag2Ptr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTags(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag1Ptr = &tag1)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1Ptr, tag2);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetTags(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, void>)LpVtbl[39])(@this, tag1Ptr, tag2Ptr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(LayerParameters* layerParameters, ID2D1Layer* layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParameters, layer);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(LayerParameters* layerParameters, ref ID2D1Layer layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Layer* layerPtr = &layer)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParameters, layerPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushLayer(ref LayerParameters layerParameters, ID2D1Layer* layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (LayerParameters* layerParametersPtr = &layerParameters)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParametersPtr, layer);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PushLayer(ref LayerParameters layerParameters, ref ID2D1Layer layer)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (LayerParameters* layerParametersPtr = &layerParameters)
            {
                fixed (ID2D1Layer* layerPtr = &layer)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, LayerParameters*, ID2D1Layer*, void>)LpVtbl[40])(@this, layerParametersPtr, layerPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PopLayer()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)LpVtbl[41])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1, tag2Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Flush(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1Ptr, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Flush(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[42])(@this, tag1Ptr, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)LpVtbl[43])(@this, drawingStateBlock);
        }

        /// <summary>To be documented.</summary>
        public readonly void SaveDrawingState(ref ID2D1DrawingStateBlock drawingStateBlock)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)LpVtbl[43])(@this, drawingStateBlockPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)LpVtbl[44])(@this, drawingStateBlock);
        }

        /// <summary>To be documented.</summary>
        public readonly void RestoreDrawingState(ref ID2D1DrawingStateBlock drawingStateBlock)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1DrawingStateBlock* drawingStateBlockPtr = &drawingStateBlock)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1DrawingStateBlock*, void>)LpVtbl[44])(@this, drawingStateBlockPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void PushAxisAlignedClip(Silk.NET.Maths.Box2D<float>* clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)LpVtbl[45])(@this, clipRect, antialiasMode);
        }

        /// <summary>To be documented.</summary>
        public readonly void PushAxisAlignedClip(ref Silk.NET.Maths.Box2D<float> clipRect, AntialiasMode antialiasMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* clipRectPtr = &clipRect)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Box2D<float>*, AntialiasMode, void>)LpVtbl[45])(@this, clipRectPtr, antialiasMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void PopAxisAlignedClip()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)LpVtbl[46])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void Clear(Silk.NET.DXGI.D3Dcolorvalue* clearColor)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[47])(@this, clearColor);
        }

        /// <summary>To be documented.</summary>
        public readonly void Clear(ref Silk.NET.DXGI.D3Dcolorvalue clearColor)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.DXGI.D3Dcolorvalue* clearColorPtr = &clearColor)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.D3Dcolorvalue*, void>)LpVtbl[47])(@this, clearColorPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void BeginDraw()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, void>)LpVtbl[48])(@this);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1, tag2Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int EndDraw(ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1Ptr, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw(ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ulong*, ulong*, int>)LpVtbl[49])(@this, tag1Ptr, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PixelFormat GetPixelFormat()
        {
            PixelFormat silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PixelFormat* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, PixelFormat*, PixelFormat*>)LpVtbl[50])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDpi(float dpiX, float dpiY)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float, float, void>)LpVtbl[51])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, float* dpiY)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float*, float*, void>)LpVtbl[52])(@this, dpiX, dpiY);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(float* dpiX, ref float dpiY)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiYPtr = &dpiY)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float*, float*, void>)LpVtbl[52])(@this, dpiX, dpiYPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDpi(ref float dpiX, float* dpiY)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float*, float*, void>)LpVtbl[52])(@this, dpiXPtr, dpiY);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDpi(ref float dpiX, ref float dpiY)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (float* dpiXPtr = &dpiX)
            {
                fixed (float* dpiYPtr = &dpiY)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, float*, float*, void>)LpVtbl[52])(@this, dpiXPtr, dpiYPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetSize()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)LpVtbl[53])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<uint> GetPixelSize()
        {
            Silk.NET.Maths.Vector2D<uint> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<uint>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<uint>*, Silk.NET.Maths.Vector2D<uint>*>)LpVtbl[54])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetMaximumBitmapSize()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, uint>)LpVtbl[55])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int IsSupported(RenderTargetProperties* renderTargetProperties)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderTargetProperties*, int>)LpVtbl[56])(@this, renderTargetProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsSupported(ref RenderTargetProperties renderTargetProperties)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (RenderTargetProperties* renderTargetPropertiesPtr = &renderTargetProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderTargetProperties*, int>)LpVtbl[56])(@this, renderTargetPropertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profile, profileSize, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, byte* profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profile, profileSize, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profilePtr, profileSize, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, ref byte profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* profilePtr = &profile)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profilePtr, profileSize, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profilePtr, profileSize, colorContext);
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContext(ColorSpace space, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string profile, uint profileSize, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var profilePtr = (byte*) SilkMarshal.StringToPtr(profile, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ColorSpace, byte*, uint, ID2D1ColorContext**, int>)LpVtbl[57])(@this, space, profilePtr, profileSize, colorContextPtr);
            }
            SilkMarshal.Free((nint)profilePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filename, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(char* filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filename, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filenamePtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename(ref char filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* filenamePtr = &filename)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, char*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filenamePtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filenamePtr, colorContext);
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromFilename([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var filenamePtr = (byte*) SilkMarshal.StringToPtr(filename, NativeStringEncoding.UTF8);
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, byte*, ID2D1ColorContext**, int>)LpVtbl[58])(@this, filenamePtr, colorContextPtr);
            }
            SilkMarshal.Free((nint)filenamePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[59])(@this, wicColorContext, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[59])(@this, wicColorContext, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ID2D1ColorContext** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[59])(@this, wicColorContextPtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromWicColorContext(ref IWICColorContext wicColorContext, ref ID2D1ColorContext* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICColorContext* wicColorContextPtr = &wicColorContext)
            {
                fixed (ID2D1ColorContext** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICColorContext*, ID2D1ColorContext**, int>)LpVtbl[59])(@this, wicColorContextPtr, colorContextPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(Silk.NET.DXGI.IDXGISurface* surface, BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surface, bitmapProperties, bitmap);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(Silk.NET.DXGI.IDXGISurface* surface, BitmapProperties1* bitmapProperties, ref ID2D1Bitmap1* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surface, bitmapProperties, bitmapPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(Silk.NET.DXGI.IDXGISurface* surface, ref BitmapProperties1 bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surface, bitmapPropertiesPtr, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(Silk.NET.DXGI.IDXGISurface* surface, ref BitmapProperties1 bitmapProperties, ref ID2D1Bitmap1* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
            {
                fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surface, bitmapPropertiesPtr, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(ref Silk.NET.DXGI.IDXGISurface surface, BitmapProperties1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surfacePtr, bitmapProperties, bitmap);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(ref Silk.NET.DXGI.IDXGISurface surface, BitmapProperties1* bitmapProperties, ref ID2D1Bitmap1* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
            {
                fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surfacePtr, bitmapProperties, bitmapPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(ref Silk.NET.DXGI.IDXGISurface surface, ref BitmapProperties1 bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
            {
                fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surfacePtr, bitmapPropertiesPtr, bitmap);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateBitmapFromDxgiSurface(ref Silk.NET.DXGI.IDXGISurface surface, ref BitmapProperties1 bitmapProperties, ref ID2D1Bitmap1* bitmap)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface* surfacePtr = &surface)
            {
                fixed (BitmapProperties1* bitmapPropertiesPtr = &bitmapProperties)
                {
                    fixed (ID2D1Bitmap1** bitmapPtr = &bitmap)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface*, BitmapProperties1*, ID2D1Bitmap1**, int>)LpVtbl[60])(@this, surfacePtr, bitmapPropertiesPtr, bitmapPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, ID2D1Effect**, int>)LpVtbl[61])(@this, effectId, effect);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(Guid* effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect** effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, ID2D1Effect**, int>)LpVtbl[61])(@this, effectId, effectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ID2D1Effect** effect)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, ID2D1Effect**, int>)LpVtbl[61])(@this, effectIdPtr, effect);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateEffect(ref Guid effectId, ref ID2D1Effect* effect)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* effectIdPtr = &effectId)
            {
                fixed (ID2D1Effect** effectPtr = &effect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Guid*, ID2D1Effect**, int>)LpVtbl[61])(@this, effectIdPtr, effectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushProperties, brushProperties, imageBrush);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushProperties, brushProperties, imageBrushPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ImageBrushProperties* imageBrushProperties, ref BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushProperties, brushPropertiesPtr, imageBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ImageBrushProperties* imageBrushProperties, ref BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushProperties, brushPropertiesPtr, imageBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ref ImageBrushProperties imageBrushProperties, BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushPropertiesPtr, brushProperties, imageBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ref ImageBrushProperties imageBrushProperties, BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushPropertiesPtr, brushProperties, imageBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ref ImageBrushProperties imageBrushProperties, ref BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ID2D1Image* image, ref ImageBrushProperties imageBrushProperties, ref BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, image, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushProperties, brushProperties, imageBrush);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ImageBrushProperties* imageBrushProperties, BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushProperties, brushProperties, imageBrushPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ImageBrushProperties* imageBrushProperties, ref BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushProperties, brushPropertiesPtr, imageBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ImageBrushProperties* imageBrushProperties, ref BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                {
                    fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushProperties, brushPropertiesPtr, imageBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ref ImageBrushProperties imageBrushProperties, BrushProperties* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushPropertiesPtr, brushProperties, imageBrush);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ref ImageBrushProperties imageBrushProperties, BrushProperties* brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
                {
                    fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushPropertiesPtr, brushProperties, imageBrushPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ref ImageBrushProperties imageBrushProperties, ref BrushProperties brushProperties, ID2D1ImageBrush** imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrush);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageBrush(ref ID2D1Image image, ref ImageBrushProperties imageBrushProperties, ref BrushProperties brushProperties, ref ID2D1ImageBrush* imageBrush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (ImageBrushProperties* imageBrushPropertiesPtr = &imageBrushProperties)
                {
                    fixed (BrushProperties* brushPropertiesPtr = &brushProperties)
                    {
                        fixed (ID2D1ImageBrush** imageBrushPtr = &imageBrush)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, ImageBrushProperties*, BrushProperties*, ID2D1ImageBrush**, int>)LpVtbl[62])(@this, imagePtr, imageBrushPropertiesPtr, brushPropertiesPtr, imageBrushPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(ID2D1CommandList** commandList)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1CommandList**, int>)LpVtbl[63])(@this, commandList);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateCommandList(ref ID2D1CommandList* commandList)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList** commandListPtr = &commandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1CommandList**, int>)LpVtbl[63])(@this, commandListPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsDxgiFormatSupported(Silk.NET.DXGI.Format format)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.Format, int>)LpVtbl[64])(@this, format);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int IsBufferPrecisionSupported(BufferPrecision bufferPrecision)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, int>)LpVtbl[65])(@this, bufferPrecision);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageLocalBounds(ID2D1Image* image, Silk.NET.Maths.Box2D<float>* localBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[66])(@this, image, localBounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageLocalBounds(ID2D1Image* image, ref Silk.NET.Maths.Box2D<float> localBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* localBoundsPtr = &localBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[66])(@this, image, localBoundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageLocalBounds(ref ID2D1Image image, Silk.NET.Maths.Box2D<float>* localBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[66])(@this, imagePtr, localBounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetImageLocalBounds(ref ID2D1Image image, ref Silk.NET.Maths.Box2D<float> localBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Box2D<float>* localBoundsPtr = &localBounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[66])(@this, imagePtr, localBoundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageWorldBounds(ID2D1Image* image, Silk.NET.Maths.Box2D<float>* worldBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[67])(@this, image, worldBounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageWorldBounds(ID2D1Image* image, ref Silk.NET.Maths.Box2D<float> worldBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* worldBoundsPtr = &worldBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[67])(@this, image, worldBoundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetImageWorldBounds(ref ID2D1Image image, Silk.NET.Maths.Box2D<float>* worldBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[67])(@this, imagePtr, worldBounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetImageWorldBounds(ref ID2D1Image image, ref Silk.NET.Maths.Box2D<float> worldBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Box2D<float>* worldBoundsPtr = &worldBounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[67])(@this, imagePtr, worldBoundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunWorldBounds(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[68])(@this, baselineOrigin, glyphRun, measuringMode, bounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunWorldBounds(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[68])(@this, baselineOrigin, glyphRun, measuringMode, boundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGlyphRunWorldBounds(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, DwriteMeasuringMode measuringMode, Silk.NET.Maths.Box2D<float>* bounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[68])(@this, baselineOrigin, glyphRunPtr, measuringMode, bounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGlyphRunWorldBounds(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, DwriteMeasuringMode measuringMode, ref Silk.NET.Maths.Box2D<float> bounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (Silk.NET.Maths.Box2D<float>* boundsPtr = &bounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[68])(@this, baselineOrigin, glyphRunPtr, measuringMode, boundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ID2D1Device** device)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Device**, void>)LpVtbl[69])(@this, device);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDevice(ref ID2D1Device* device)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Device** devicePtr = &device)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Device**, void>)LpVtbl[69])(@this, devicePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTarget(ID2D1Image* image)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, void>)LpVtbl[70])(@this, image);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetTarget(ref ID2D1Image image)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* imagePtr = &image)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, void>)LpVtbl[70])(@this, imagePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTarget(ID2D1Image** image)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image**, void>)LpVtbl[71])(@this, image);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTarget(ref ID2D1Image* image)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image** imagePtr = &image)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image**, void>)LpVtbl[71])(@this, imagePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetRenderingControls(RenderingControls* renderingControls)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderingControls*, void>)LpVtbl[72])(@this, renderingControls);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetRenderingControls(ref RenderingControls renderingControls)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RenderingControls* renderingControlsPtr = &renderingControls)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderingControls*, void>)LpVtbl[72])(@this, renderingControlsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRenderingControls(RenderingControls* renderingControls)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderingControls*, void>)LpVtbl[73])(@this, renderingControls);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetRenderingControls(ref RenderingControls renderingControls)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (RenderingControls* renderingControlsPtr = &renderingControls)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, RenderingControls*, void>)LpVtbl[73])(@this, renderingControlsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void SetPrimitiveBlend(PrimitiveBlend primitiveBlend)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, PrimitiveBlend, void>)LpVtbl[74])(@this, primitiveBlend);
        }

        /// <summary>To be documented.</summary>
        public readonly PrimitiveBlend GetPrimitiveBlend()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PrimitiveBlend ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, PrimitiveBlend>)LpVtbl[75])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetUnitMode(UnitMode unitMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, UnitMode, void>)LpVtbl[76])(@this, unitMode);
        }

        /// <summary>To be documented.</summary>
        public readonly UnitMode GetUnitMode()
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            UnitMode ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, UnitMode>)LpVtbl[77])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ID2D1Image* image, Silk.NET.Maths.Vector2D<float>* targetOffset, Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ID2D1Image* image, Silk.NET.Maths.Vector2D<float>* targetOffset, ref Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, image, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ID2D1Image* image, ref Silk.NET.Maths.Vector2D<float> targetOffset, Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, image, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ID2D1Image* image, ref Silk.NET.Maths.Vector2D<float> targetOffset, ref Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, image, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ref ID2D1Image image, Silk.NET.Maths.Vector2D<float>* targetOffset, Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* imagePtr = &image)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, imagePtr, targetOffset, imageRectangle, interpolationMode, compositeMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ref ID2D1Image image, Silk.NET.Maths.Vector2D<float>* targetOffset, ref Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, imagePtr, targetOffset, imageRectanglePtr, interpolationMode, compositeMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawImage(ref ID2D1Image image, ref Silk.NET.Maths.Vector2D<float> targetOffset, Silk.NET.Maths.Box2D<float>* imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, imagePtr, targetOffsetPtr, imageRectangle, interpolationMode, compositeMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawImage(ref ID2D1Image image, ref Silk.NET.Maths.Vector2D<float> targetOffset, ref Silk.NET.Maths.Box2D<float> imageRectangle, InterpolationMode interpolationMode, CompositeMode compositeMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* imagePtr = &image)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* imageRectanglePtr = &imageRectangle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Image*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Box2D<float>*, InterpolationMode, CompositeMode, void>)LpVtbl[78])(@this, imagePtr, targetOffsetPtr, imageRectanglePtr, interpolationMode, compositeMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, Silk.NET.Maths.Vector2D<float>* targetOffset)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)LpVtbl[79])(@this, gdiMetafile, targetOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, ref Silk.NET.Maths.Vector2D<float> targetOffset)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)LpVtbl[79])(@this, gdiMetafile, targetOffsetPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGdiMetafile(ref ID2D1GdiMetafile gdiMetafile, Silk.NET.Maths.Vector2D<float>* targetOffset)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)LpVtbl[79])(@this, gdiMetafilePtr, targetOffset);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGdiMetafile(ref ID2D1GdiMetafile gdiMetafile, ref Silk.NET.Maths.Vector2D<float> targetOffset)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GdiMetafile* gdiMetafilePtr = &gdiMetafile)
            {
                fixed (Silk.NET.Maths.Vector2D<float>* targetOffsetPtr = &targetOffset)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GdiMetafile*, Silk.NET.Maths.Vector2D<float>*, void>)LpVtbl[79])(@this, gdiMetafilePtr, targetOffsetPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InvalidateEffectInputRectangle(ID2D1Effect* effect, uint input, Silk.NET.Maths.Box2D<float>* inputRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[80])(@this, effect, input, inputRectangle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InvalidateEffectInputRectangle(ID2D1Effect* effect, uint input, ref Silk.NET.Maths.Box2D<float> inputRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* inputRectanglePtr = &inputRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[80])(@this, effect, input, inputRectanglePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int InvalidateEffectInputRectangle(ref ID2D1Effect effect, uint input, Silk.NET.Maths.Box2D<float>* inputRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[80])(@this, effectPtr, input, inputRectangle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int InvalidateEffectInputRectangle(ref ID2D1Effect effect, uint input, ref Silk.NET.Maths.Box2D<float> inputRectangle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* inputRectanglePtr = &inputRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[80])(@this, effectPtr, input, inputRectanglePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangleCount(ID2D1Effect* effect, uint* rectangleCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint*, int>)LpVtbl[81])(@this, effect, rectangleCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangleCount(ID2D1Effect* effect, ref uint rectangleCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* rectangleCountPtr = &rectangleCount)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint*, int>)LpVtbl[81])(@this, effect, rectangleCountPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangleCount(ref ID2D1Effect effect, uint* rectangleCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint*, int>)LpVtbl[81])(@this, effectPtr, rectangleCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectInvalidRectangleCount(ref ID2D1Effect effect, ref uint rectangleCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                fixed (uint* rectangleCountPtr = &rectangleCount)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, uint*, int>)LpVtbl[81])(@this, effectPtr, rectangleCountPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangles(ID2D1Effect* effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[82])(@this, effect, rectangles, rectanglesCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangles(ID2D1Effect* effect, ref Silk.NET.Maths.Box2D<float> rectangles, uint rectanglesCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* rectanglesPtr = &rectangles)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[82])(@this, effect, rectanglesPtr, rectanglesCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectInvalidRectangles(ref ID2D1Effect effect, Silk.NET.Maths.Box2D<float>* rectangles, uint rectanglesCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[82])(@this, effectPtr, rectangles, rectanglesCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectInvalidRectangles(ref ID2D1Effect effect, ref Silk.NET.Maths.Box2D<float> rectangles, uint rectanglesCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* effectPtr = &effect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* rectanglesPtr = &rectangles)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[82])(@this, effectPtr, rectanglesPtr, rectanglesCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectangle, inputDescriptions, requiredInputRectsPtr, inputCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, ref EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectangle, inputDescriptionsPtr, requiredInputRects, inputCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, ref EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectangle, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectanglePtr, inputDescriptions, requiredInputRects, inputCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectanglePtr, inputDescriptions, requiredInputRectsPtr, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, ref EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRects, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, ref EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffect, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectangle, inputDescriptions, requiredInputRectsPtr, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, ref EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectangle, inputDescriptionsPtr, requiredInputRects, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, Silk.NET.Maths.Box2D<float>* renderImageRectangle, ref EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectangle, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, EffectInputDescription* inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptions, requiredInputRects, inputCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, EffectInputDescription* inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
                {
                    fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptions, requiredInputRectsPtr, inputCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, ref EffectInputDescription inputDescriptions, Silk.NET.Maths.Box2D<float>* requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
                {
                    fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRects, inputCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetEffectRequiredInputRectangles(ref ID2D1Effect renderEffect, ref Silk.NET.Maths.Box2D<float> renderImageRectangle, ref EffectInputDescription inputDescriptions, ref Silk.NET.Maths.Box2D<float> requiredInputRects, uint inputCount)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Effect* renderEffectPtr = &renderEffect)
            {
                fixed (Silk.NET.Maths.Box2D<float>* renderImageRectanglePtr = &renderImageRectangle)
                {
                    fixed (EffectInputDescription* inputDescriptionsPtr = &inputDescriptions)
                    {
                        fixed (Silk.NET.Maths.Box2D<float>* requiredInputRectsPtr = &requiredInputRects)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Effect*, Silk.NET.Maths.Box2D<float>*, EffectInputDescription*, Silk.NET.Maths.Box2D<float>*, uint, int>)LpVtbl[83])(@this, renderEffectPtr, renderImageRectanglePtr, inputDescriptionsPtr, requiredInputRectsPtr, inputCount);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFilledGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)LpVtbl[84])(@this, geometry, flatteningTolerance, geometryRealization);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFilledGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)LpVtbl[84])(@this, geometry, flatteningTolerance, geometryRealizationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFilledGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)LpVtbl[84])(@this, geometryPtr, flatteningTolerance, geometryRealization);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateFilledGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, ID2D1GeometryRealization**, int>)LpVtbl[84])(@this, geometryPtr, flatteningTolerance, geometryRealizationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometry, flatteningTolerance, strokeWidth, strokeStyle, geometryRealizationPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometry, flatteningTolerance, strokeWidth, strokeStylePtr, geometryRealization);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ID2D1Geometry* geometry, float flatteningTolerance, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
            {
                fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometry, flatteningTolerance, strokeWidth, strokeStylePtr, geometryRealizationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometryPtr, flatteningTolerance, strokeWidth, strokeStyle, geometryRealization);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, ID2D1StrokeStyle* strokeStyle, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometryPtr, flatteningTolerance, strokeWidth, strokeStyle, geometryRealizationPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ID2D1GeometryRealization** geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometryPtr, flatteningTolerance, strokeWidth, strokeStylePtr, geometryRealization);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokedGeometryRealization(ref ID2D1Geometry geometry, float flatteningTolerance, float strokeWidth, ref ID2D1StrokeStyle strokeStyle, ref ID2D1GeometryRealization* geometryRealization)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Geometry* geometryPtr = &geometry)
            {
                fixed (ID2D1StrokeStyle* strokeStylePtr = &strokeStyle)
                {
                    fixed (ID2D1GeometryRealization** geometryRealizationPtr = &geometryRealization)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Geometry*, float, float, ID2D1StrokeStyle*, ID2D1GeometryRealization**, int>)LpVtbl[85])(@this, geometryPtr, flatteningTolerance, strokeWidth, strokeStylePtr, geometryRealizationPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometryRealization(ID2D1GeometryRealization* geometryRealization, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GeometryRealization*, ID2D1Brush*, void>)LpVtbl[86])(@this, geometryRealization, brush);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometryRealization(ID2D1GeometryRealization* geometryRealization, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GeometryRealization*, ID2D1Brush*, void>)LpVtbl[86])(@this, geometryRealization, brushPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGeometryRealization(ref ID2D1GeometryRealization geometryRealization, ID2D1Brush* brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GeometryRealization* geometryRealizationPtr = &geometryRealization)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GeometryRealization*, ID2D1Brush*, void>)LpVtbl[86])(@this, geometryRealizationPtr, brush);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGeometryRealization(ref ID2D1GeometryRealization geometryRealization, ref ID2D1Brush brush)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GeometryRealization* geometryRealizationPtr = &geometryRealization)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GeometryRealization*, ID2D1Brush*, void>)LpVtbl[86])(@this, geometryRealizationPtr, brushPtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInk(InkPoint* startPoint, ID2D1Ink** ink)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkPoint*, ID2D1Ink**, int>)LpVtbl[87])(@this, startPoint, ink);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInk(InkPoint* startPoint, ref ID2D1Ink* ink)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Ink** inkPtr = &ink)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkPoint*, ID2D1Ink**, int>)LpVtbl[87])(@this, startPoint, inkPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInk(ref InkPoint startPoint, ID2D1Ink** ink)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkPoint* startPointPtr = &startPoint)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkPoint*, ID2D1Ink**, int>)LpVtbl[87])(@this, startPointPtr, ink);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInk(ref InkPoint startPoint, ref ID2D1Ink* ink)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkPoint* startPointPtr = &startPoint)
            {
                fixed (ID2D1Ink** inkPtr = &ink)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkPoint*, ID2D1Ink**, int>)LpVtbl[87])(@this, startPointPtr, inkPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInkStyle(InkStyleProperties* inkStyleProperties, ID2D1InkStyle** inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkStyleProperties*, ID2D1InkStyle**, int>)LpVtbl[88])(@this, inkStyleProperties, inkStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInkStyle(InkStyleProperties* inkStyleProperties, ref ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1InkStyle** inkStylePtr = &inkStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkStyleProperties*, ID2D1InkStyle**, int>)LpVtbl[88])(@this, inkStyleProperties, inkStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInkStyle(ref InkStyleProperties inkStyleProperties, ID2D1InkStyle** inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkStyleProperties* inkStylePropertiesPtr = &inkStyleProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkStyleProperties*, ID2D1InkStyle**, int>)LpVtbl[88])(@this, inkStylePropertiesPtr, inkStyle);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateInkStyle(ref InkStyleProperties inkStyleProperties, ref ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkStyleProperties* inkStylePropertiesPtr = &inkStyleProperties)
            {
                fixed (ID2D1InkStyle** inkStylePtr = &inkStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, InkStyleProperties*, ID2D1InkStyle**, int>)LpVtbl[88])(@this, inkStylePropertiesPtr, inkStylePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientMesh(GradientMeshPatch* patches, uint patchesCount, ID2D1GradientMesh** gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientMeshPatch*, uint, ID2D1GradientMesh**, int>)LpVtbl[89])(@this, patches, patchesCount, gradientMesh);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientMesh(GradientMeshPatch* patches, uint patchesCount, ref ID2D1GradientMesh* gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientMesh** gradientMeshPtr = &gradientMesh)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientMeshPatch*, uint, ID2D1GradientMesh**, int>)LpVtbl[89])(@this, patches, patchesCount, gradientMeshPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientMesh(ref GradientMeshPatch patches, uint patchesCount, ID2D1GradientMesh** gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientMeshPatch* patchesPtr = &patches)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientMeshPatch*, uint, ID2D1GradientMesh**, int>)LpVtbl[89])(@this, patchesPtr, patchesCount, gradientMesh);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateGradientMesh(ref GradientMeshPatch patches, uint patchesCount, ref ID2D1GradientMesh* gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (GradientMeshPatch* patchesPtr = &patches)
            {
                fixed (ID2D1GradientMesh** gradientMeshPtr = &gradientMesh)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, GradientMeshPatch*, uint, ID2D1GradientMesh**, int>)LpVtbl[89])(@this, patchesPtr, patchesCount, gradientMeshPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromWic(IWICBitmapSource* wicBitmapSource, ImageSourceLoadingOptions loadingOptions, AlphaMode alphaMode, ID2D1ImageSourceFromWic** imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, ImageSourceLoadingOptions, AlphaMode, ID2D1ImageSourceFromWic**, int>)LpVtbl[90])(@this, wicBitmapSource, loadingOptions, alphaMode, imageSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromWic(IWICBitmapSource* wicBitmapSource, ImageSourceLoadingOptions loadingOptions, AlphaMode alphaMode, ref ID2D1ImageSourceFromWic* imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSourceFromWic** imageSourcePtr = &imageSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, ImageSourceLoadingOptions, AlphaMode, ID2D1ImageSourceFromWic**, int>)LpVtbl[90])(@this, wicBitmapSource, loadingOptions, alphaMode, imageSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromWic(ref IWICBitmapSource wicBitmapSource, ImageSourceLoadingOptions loadingOptions, AlphaMode alphaMode, ID2D1ImageSourceFromWic** imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, ImageSourceLoadingOptions, AlphaMode, ID2D1ImageSourceFromWic**, int>)LpVtbl[90])(@this, wicBitmapSourcePtr, loadingOptions, alphaMode, imageSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromWic(ref IWICBitmapSource wicBitmapSource, ImageSourceLoadingOptions loadingOptions, AlphaMode alphaMode, ref ID2D1ImageSourceFromWic* imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IWICBitmapSource* wicBitmapSourcePtr = &wicBitmapSource)
            {
                fixed (ID2D1ImageSourceFromWic** imageSourcePtr = &imageSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, IWICBitmapSource*, ImageSourceLoadingOptions, AlphaMode, ID2D1ImageSourceFromWic**, int>)LpVtbl[90])(@this, wicBitmapSourcePtr, loadingOptions, alphaMode, imageSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, data, dataCount, strides, lookupTable);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, data, dataCount, strides, lookupTablePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, data, dataCount, stridesPtr, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, byte* data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, data, dataCount, stridesPtr, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, strides, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, strides, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, ref byte data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, strides, lookupTable);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, strides, lookupTablePtr);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTable);
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, uint* extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            fixed (uint* stridesPtr = &strides)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extents, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                }
            }
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, data, dataCount, strides, lookupTable);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, data, dataCount, strides, lookupTablePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, data, dataCount, stridesPtr, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, byte* data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, data, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTable);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTablePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTable);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, ref byte data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
                fixed (byte* dataPtr = &data)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTable);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, uint* strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, strides, lookupTablePtr);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ID2D1LookupTable3D** lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTable);
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateLookupTable3D(BufferPrecision precision, ref uint extents, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount, ref uint strides, ref ID2D1LookupTable3D* lookupTable)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* extentsPtr = &extents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (ID2D1LookupTable3D** lookupTablePtr = &lookupTable)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, BufferPrecision, uint*, byte*, uint, uint*, ID2D1LookupTable3D**, int>)LpVtbl[91])(@this, precision, extentsPtr, dataPtr, dataCount, stridesPtr, lookupTablePtr);
                    }
                }
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromDxgi(Silk.NET.DXGI.IDXGISurface** surfaces, uint surfaceCount, Silk.NET.DXGI.ColorSpaceType colorSpace, ImageSourceFromDxgiOptions options, ID2D1ImageSource** imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface**, uint, Silk.NET.DXGI.ColorSpaceType, ImageSourceFromDxgiOptions, ID2D1ImageSource**, int>)LpVtbl[92])(@this, surfaces, surfaceCount, colorSpace, options, imageSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromDxgi(Silk.NET.DXGI.IDXGISurface** surfaces, uint surfaceCount, Silk.NET.DXGI.ColorSpaceType colorSpace, ImageSourceFromDxgiOptions options, ref ID2D1ImageSource* imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSource** imageSourcePtr = &imageSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface**, uint, Silk.NET.DXGI.ColorSpaceType, ImageSourceFromDxgiOptions, ID2D1ImageSource**, int>)LpVtbl[92])(@this, surfaces, surfaceCount, colorSpace, options, imageSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromDxgi(ref Silk.NET.DXGI.IDXGISurface* surfaces, uint surfaceCount, Silk.NET.DXGI.ColorSpaceType colorSpace, ImageSourceFromDxgiOptions options, ID2D1ImageSource** imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface** surfacesPtr = &surfaces)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface**, uint, Silk.NET.DXGI.ColorSpaceType, ImageSourceFromDxgiOptions, ID2D1ImageSource**, int>)LpVtbl[92])(@this, surfacesPtr, surfaceCount, colorSpace, options, imageSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateImageSourceFromDxgi(ref Silk.NET.DXGI.IDXGISurface* surfaces, uint surfaceCount, Silk.NET.DXGI.ColorSpaceType colorSpace, ImageSourceFromDxgiOptions options, ref ID2D1ImageSource* imageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.IDXGISurface** surfacesPtr = &surfaces)
            {
                fixed (ID2D1ImageSource** imageSourcePtr = &imageSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.IDXGISurface**, uint, Silk.NET.DXGI.ColorSpaceType, ImageSourceFromDxgiOptions, ID2D1ImageSource**, int>)LpVtbl[92])(@this, surfacesPtr, surfaceCount, colorSpace, options, imageSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGradientMeshWorldBounds(ID2D1GradientMesh* gradientMesh, Silk.NET.Maths.Box2D<float>* pBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[93])(@this, gradientMesh, pBounds);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGradientMeshWorldBounds(ID2D1GradientMesh* gradientMesh, ref Silk.NET.Maths.Box2D<float> pBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<float>* pBoundsPtr = &pBounds)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[93])(@this, gradientMesh, pBoundsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetGradientMeshWorldBounds(ref ID2D1GradientMesh gradientMesh, Silk.NET.Maths.Box2D<float>* pBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientMesh* gradientMeshPtr = &gradientMesh)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[93])(@this, gradientMeshPtr, pBounds);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetGradientMeshWorldBounds(ref ID2D1GradientMesh gradientMesh, ref Silk.NET.Maths.Box2D<float> pBounds)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1GradientMesh* gradientMeshPtr = &gradientMesh)
            {
                fixed (Silk.NET.Maths.Box2D<float>* pBoundsPtr = &pBounds)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, Silk.NET.Maths.Box2D<float>*, int>)LpVtbl[93])(@this, gradientMeshPtr, pBoundsPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ID2D1Ink* ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, ink, brush, inkStyle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ID2D1Ink* ink, ID2D1Brush* brush, ref ID2D1InkStyle inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, ink, brush, inkStylePtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ID2D1Ink* ink, ref ID2D1Brush brush, ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, ink, brushPtr, inkStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ID2D1Ink* ink, ref ID2D1Brush brush, ref ID2D1InkStyle inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* brushPtr = &brush)
            {
                fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, ink, brushPtr, inkStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ref ID2D1Ink ink, ID2D1Brush* brush, ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Ink* inkPtr = &ink)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, inkPtr, brush, inkStyle);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ref ID2D1Ink ink, ID2D1Brush* brush, ref ID2D1InkStyle inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Ink* inkPtr = &ink)
            {
                fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, inkPtr, brush, inkStylePtr);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawInk(ref ID2D1Ink ink, ref ID2D1Brush brush, ID2D1InkStyle* inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Ink* inkPtr = &ink)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, inkPtr, brushPtr, inkStyle);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawInk(ref ID2D1Ink ink, ref ID2D1Brush brush, ref ID2D1InkStyle inkStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Ink* inkPtr = &ink)
            {
                fixed (ID2D1Brush* brushPtr = &brush)
                {
                    fixed (ID2D1InkStyle* inkStylePtr = &inkStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1Ink*, ID2D1Brush*, ID2D1InkStyle*, void>)LpVtbl[94])(@this, inkPtr, brushPtr, inkStylePtr);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawGradientMesh(ID2D1GradientMesh* gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, void>)LpVtbl[95])(@this, gradientMesh);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawGradientMesh(ref ID2D1GradientMesh gradientMesh)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1GradientMesh* gradientMeshPtr = &gradientMesh)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1GradientMesh*, void>)LpVtbl[95])(@this, gradientMeshPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ID2D1ImageSource* imageSource, TransformedImageSourceProperties* properties, ID2D1TransformedImageSource** transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSource, properties, transformedImageSource);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ID2D1ImageSource* imageSource, TransformedImageSourceProperties* properties, ref ID2D1TransformedImageSource* transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1TransformedImageSource** transformedImageSourcePtr = &transformedImageSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSource, properties, transformedImageSourcePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ID2D1ImageSource* imageSource, ref TransformedImageSourceProperties properties, ID2D1TransformedImageSource** transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TransformedImageSourceProperties* propertiesPtr = &properties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSource, propertiesPtr, transformedImageSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ID2D1ImageSource* imageSource, ref TransformedImageSourceProperties properties, ref ID2D1TransformedImageSource* transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (TransformedImageSourceProperties* propertiesPtr = &properties)
            {
                fixed (ID2D1TransformedImageSource** transformedImageSourcePtr = &transformedImageSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSource, propertiesPtr, transformedImageSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ref ID2D1ImageSource imageSource, TransformedImageSourceProperties* properties, ID2D1TransformedImageSource** transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSource* imageSourcePtr = &imageSource)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSourcePtr, properties, transformedImageSource);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ref ID2D1ImageSource imageSource, TransformedImageSourceProperties* properties, ref ID2D1TransformedImageSource* transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSource* imageSourcePtr = &imageSource)
            {
                fixed (ID2D1TransformedImageSource** transformedImageSourcePtr = &transformedImageSource)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSourcePtr, properties, transformedImageSourcePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ref ID2D1ImageSource imageSource, ref TransformedImageSourceProperties properties, ID2D1TransformedImageSource** transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSource* imageSourcePtr = &imageSource)
            {
                fixed (TransformedImageSourceProperties* propertiesPtr = &properties)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSourcePtr, propertiesPtr, transformedImageSource);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateTransformedImageSource(ref ID2D1ImageSource imageSource, ref TransformedImageSourceProperties properties, ref ID2D1TransformedImageSource* transformedImageSource)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ImageSource* imageSourcePtr = &imageSource)
            {
                fixed (TransformedImageSourceProperties* propertiesPtr = &properties)
                {
                    fixed (ID2D1TransformedImageSource** transformedImageSourcePtr = &transformedImageSource)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1ImageSource*, TransformedImageSourceProperties*, ID2D1TransformedImageSource**, int>)LpVtbl[96])(@this, imageSourcePtr, propertiesPtr, transformedImageSourcePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSpriteBatch(ID2D1SpriteBatch** spriteBatch)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch**, int>)LpVtbl[97])(@this, spriteBatch);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSpriteBatch(ref ID2D1SpriteBatch* spriteBatch)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SpriteBatch** spriteBatchPtr = &spriteBatch)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch**, int>)LpVtbl[97])(@this, spriteBatchPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSpriteBatch(ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, void>)LpVtbl[98])(@this, spriteBatch, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSpriteBatch(ID2D1SpriteBatch* spriteBatch, uint startIndex, uint spriteCount, ref ID2D1Bitmap bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, void>)LpVtbl[98])(@this, spriteBatch, startIndex, spriteCount, bitmapPtr, interpolationMode, spriteOptions);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSpriteBatch(ref ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ID2D1Bitmap* bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SpriteBatch* spriteBatchPtr = &spriteBatch)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, void>)LpVtbl[98])(@this, spriteBatchPtr, startIndex, spriteCount, bitmap, interpolationMode, spriteOptions);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawSpriteBatch(ref ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, ref ID2D1Bitmap bitmap, BitmapInterpolationMode interpolationMode, SpriteOptions spriteOptions)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SpriteBatch* spriteBatchPtr = &spriteBatch)
            {
                fixed (ID2D1Bitmap* bitmapPtr = &bitmap)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SpriteBatch*, uint, uint, ID2D1Bitmap*, BitmapInterpolationMode, SpriteOptions, void>)LpVtbl[98])(@this, spriteBatchPtr, startIndex, spriteCount, bitmapPtr, interpolationMode, spriteOptions);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgGlyphStyle(ID2D1SvgGlyphStyle** svgGlyphStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgGlyphStyle**, int>)LpVtbl[99])(@this, svgGlyphStyle);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgGlyphStyle(ref ID2D1SvgGlyphStyle* svgGlyphStyle)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgGlyphStyle** svgGlyphStylePtr = &svgGlyphStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgGlyphStyle**, int>)LpVtbl[99])(@this, svgGlyphStylePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawColorBitmapGlyphRun(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, DwriteMeasuringMode measuringMode, ColorBitmapGlyphSnapOption bitmapSnapOption)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, ColorBitmapGlyphSnapOption, void>)LpVtbl[100])(@this, glyphImageFormat, baselineOrigin, glyphRun, measuringMode, bitmapSnapOption);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawColorBitmapGlyphRun(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, DwriteMeasuringMode measuringMode, ColorBitmapGlyphSnapOption bitmapSnapOption)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, DwriteMeasuringMode, ColorBitmapGlyphSnapOption, void>)LpVtbl[100])(@this, glyphImageFormat, baselineOrigin, glyphRunPtr, measuringMode, bitmapSnapOption);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRun, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, measuringMode);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRun, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRun, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, DwriteGlyphRun* glyphRun, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRun, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRunPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, measuringMode);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRunPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRunPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, measuringMode);
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawSvgGlyphRun(Silk.NET.Maths.Vector2D<float> baselineOrigin, ref DwriteGlyphRun glyphRun, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DwriteMeasuringMode measuringMode)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DwriteGlyphRun* glyphRunPtr = &glyphRun)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, DwriteGlyphRun*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, DwriteMeasuringMode, void>)LpVtbl[101])(@this, baselineOrigin, glyphRunPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, measuringMode);
                    }
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Image** glyphImagePtr = &glyphImage)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransformPtr, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
            {
                fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransformPtr, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, dpiX, dpiY, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1Image** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetColorBitmapGlyphImage(DwriteGlyphImageFormats glyphImageFormat, Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, float dpiX, float dpiY, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1Image* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1Image** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, DwriteGlyphImageFormats, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, float, float, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Image**, int>)LpVtbl[102])(@this, glyphImageFormat, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, dpiX, dpiY, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
            {
                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
            {
                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, IDWriteFontFace* fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFace, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, Silk.NET.Maths.Matrix3X2<float>* worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransform, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ID2D1Brush* defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrush, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImage);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransform, glyphImagePtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImage);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ID2D1SvgGlyphStyle* svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                        {
                            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStyle, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImage);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, Silk.NET.Maths.Matrix3X2<float>* glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                        {
                            fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransform, glyphImagePtr);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ID2D1CommandList** glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                        {
                            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                            {
                                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImage);
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSvgGlyphImage(Silk.NET.Maths.Vector2D<float> glyphOrigin, ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, int isSideways, ref Silk.NET.Maths.Matrix3X2<float> worldTransform, ref ID2D1Brush defaultFillBrush, ref ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, ref Silk.NET.Maths.Matrix3X2<float> glyphTransform, ref ID2D1CommandList* glyphImage)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteFontFace* fontFacePtr = &fontFace)
            {
                fixed (Silk.NET.Maths.Matrix3X2<float>* worldTransformPtr = &worldTransform)
                {
                    fixed (ID2D1Brush* defaultFillBrushPtr = &defaultFillBrush)
                    {
                        fixed (ID2D1SvgGlyphStyle* svgGlyphStylePtr = &svgGlyphStyle)
                        {
                            fixed (Silk.NET.Maths.Matrix3X2<float>* glyphTransformPtr = &glyphTransform)
                            {
                                fixed (ID2D1CommandList** glyphImagePtr = &glyphImage)
                                {
                                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Maths.Vector2D<float>, IDWriteFontFace*, float, ushort, int, Silk.NET.Maths.Matrix3X2<float>*, ID2D1Brush*, ID2D1SvgGlyphStyle*, uint, Silk.NET.Maths.Matrix3X2<float>*, ID2D1CommandList**, int>)LpVtbl[103])(@this, glyphOrigin, fontFacePtr, fontEmSize, glyphIndex, isSideways, worldTransformPtr, defaultFillBrushPtr, svgGlyphStylePtr, colorPaletteIndex, glyphTransformPtr, glyphImagePtr);
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgDocument(Silk.NET.Core.Native.IStream* inputXmlStream, Silk.NET.Maths.Vector2D<float> viewportSize, ID2D1SvgDocument** svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Core.Native.IStream*, Silk.NET.Maths.Vector2D<float>, ID2D1SvgDocument**, int>)LpVtbl[104])(@this, inputXmlStream, viewportSize, svgDocument);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgDocument(Silk.NET.Core.Native.IStream* inputXmlStream, Silk.NET.Maths.Vector2D<float> viewportSize, ref ID2D1SvgDocument* svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgDocument** svgDocumentPtr = &svgDocument)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Core.Native.IStream*, Silk.NET.Maths.Vector2D<float>, ID2D1SvgDocument**, int>)LpVtbl[104])(@this, inputXmlStream, viewportSize, svgDocumentPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgDocument(ref Silk.NET.Core.Native.IStream inputXmlStream, Silk.NET.Maths.Vector2D<float> viewportSize, ID2D1SvgDocument** svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* inputXmlStreamPtr = &inputXmlStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Core.Native.IStream*, Silk.NET.Maths.Vector2D<float>, ID2D1SvgDocument**, int>)LpVtbl[104])(@this, inputXmlStreamPtr, viewportSize, svgDocument);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateSvgDocument(ref Silk.NET.Core.Native.IStream inputXmlStream, Silk.NET.Maths.Vector2D<float> viewportSize, ref ID2D1SvgDocument* svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* inputXmlStreamPtr = &inputXmlStream)
            {
                fixed (ID2D1SvgDocument** svgDocumentPtr = &svgDocument)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.Core.Native.IStream*, Silk.NET.Maths.Vector2D<float>, ID2D1SvgDocument**, int>)LpVtbl[104])(@this, inputXmlStreamPtr, viewportSize, svgDocumentPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void DrawSvgDocument(ID2D1SvgDocument* svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgDocument*, void>)LpVtbl[105])(@this, svgDocument);
        }

        /// <summary>To be documented.</summary>
        public readonly void DrawSvgDocument(ref ID2D1SvgDocument svgDocument)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgDocument* svgDocumentPtr = &svgDocument)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, ID2D1SvgDocument*, void>)LpVtbl[105])(@this, svgDocumentPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromDxgiColorSpace(Silk.NET.DXGI.ColorSpaceType colorSpace, ID2D1ColorContext1** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.ColorSpaceType, ID2D1ColorContext1**, int>)LpVtbl[106])(@this, colorSpace, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromDxgiColorSpace(Silk.NET.DXGI.ColorSpaceType colorSpace, ref ID2D1ColorContext1* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext1** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, Silk.NET.DXGI.ColorSpaceType, ID2D1ColorContext1**, int>)LpVtbl[106])(@this, colorSpace, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromSimpleColorProfile(SimpleColorProfile* simpleProfile, ID2D1ColorContext1** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, SimpleColorProfile*, ID2D1ColorContext1**, int>)LpVtbl[107])(@this, simpleProfile, colorContext);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromSimpleColorProfile(SimpleColorProfile* simpleProfile, ref ID2D1ColorContext1* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ColorContext1** colorContextPtr = &colorContext)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, SimpleColorProfile*, ID2D1ColorContext1**, int>)LpVtbl[107])(@this, simpleProfile, colorContextPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromSimpleColorProfile(ref SimpleColorProfile simpleProfile, ID2D1ColorContext1** colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SimpleColorProfile* simpleProfilePtr = &simpleProfile)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, SimpleColorProfile*, ID2D1ColorContext1**, int>)LpVtbl[107])(@this, simpleProfilePtr, colorContext);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateColorContextFromSimpleColorProfile(ref SimpleColorProfile simpleProfile, ref ID2D1ColorContext1* colorContext)
        {
            var @this = (ID2D1DeviceContext5*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SimpleColorProfile* simpleProfilePtr = &simpleProfile)
            {
                fixed (ID2D1ColorContext1** colorContextPtr = &colorContext)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext5*, SimpleColorProfile*, ID2D1ColorContext1**, int>)LpVtbl[107])(@this, simpleProfilePtr, colorContextPtr);
                }
            }
            return ret;
        }

    }
}
