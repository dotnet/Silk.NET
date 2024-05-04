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
    [Guid("688d15c3-02b0-438d-b13a-d1b44c32c39a")]
    [NativeName("Name", "ID2D1ResourceTexture")]
    public unsafe partial struct ID2D1ResourceTexture : IComVtbl<ID2D1ResourceTexture>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("688d15c3-02b0-438d-b13a-d1b44c32c39a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ResourceTexture val)
            => Unsafe.As<ID2D1ResourceTexture, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ResourceTexture
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
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, data, dataCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, dataPtr, dataCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, strides, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, data, dataCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* stridesPtr = &strides)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, data, dataCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, data, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* maximimumExtentsPtr = &maximimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtents, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, data, dataCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, dataPtr, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, strides, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, data, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* stridesPtr = &strides)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtents, stridesPtr, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, data, dataCount);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
                    fixed (byte* dataPtr = &data)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, strides, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, data, dataCount);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
                        fixed (byte* dataPtr = &data)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Update([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint minimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint maximimumExtents, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint strides, uint dimensions, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataCount)
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* minimumExtentsPtr = &minimumExtents)
            {
                fixed (uint* maximimumExtentsPtr = &maximimumExtents)
                {
                    fixed (uint* stridesPtr = &strides)
                    {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1ResourceTexture*, uint*, uint*, uint*, uint, byte*, uint, int>)@this->LpVtbl[3])(@this, minimumExtentsPtr, maximimumExtentsPtr, stridesPtr, dimensions, dataPtr, dataCount);
            SilkMarshal.Free((nint)dataPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1ResourceTexture*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
