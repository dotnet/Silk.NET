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

namespace Silk.NET.DirectStorage
{
    [Guid("6924ea0c-c3cd-4826-b10a-f64f4ed927c1")]
    [NativeName("Name", "IDStorageFactory")]
    public unsafe partial struct IDStorageFactory : IComVtbl<IDStorageFactory>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("6924ea0c-c3cd-4826-b10a-f64f4ed927c1");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDStorageFactory val)
            => Unsafe.As<IDStorageFactory, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDStorageFactory
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
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] QueueDesc* desc, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, desc, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateQueue([Flow(FlowDirection.In)] in QueueDesc desc, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (QueueDesc* descPtr = &desc)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, QueueDesc*, Guid*, void**, int>)@this->LpVtbl[3])(@this, descPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(char* path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, path, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile(ref char path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* pathPtr = &path)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, char*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppv);
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riid, ppvPtr);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppv);
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int OpenFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string path, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pathPtr = (byte*) SilkMarshal.StringToPtr(path, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, byte*, Guid*, void**, int>)@this->LpVtbl[4])(@this, pathPtr, riidPtr, ppvPtr);
                }
            }
            SilkMarshal.Free((nint)pathPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppv);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riid, ppvPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riidPtr, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, byte* name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, name, riidPtr, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, ref byte name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* namePtr = &name)
            {
                fixed (Guid* riidPtr = &riid)
                {
                    fixed (void** ppvPtr = &ppv)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppv);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, Guid* riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (void** ppvPtr = &ppv)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riid, ppvPtr);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, void** ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppv);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStatusArray(uint capacity, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, ref Guid riid, ref void* ppv)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvPtr = &ppv)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, byte*, Guid*, void**, int>)@this->LpVtbl[5])(@this, capacity, namePtr, riidPtr, ppvPtr);
                }
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDebugFlags(uint flags)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, void>)@this->LpVtbl[6])(@this, flags);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetStagingBufferSize(uint size)
        {
            var @this = (IDStorageFactory*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDStorageFactory*, uint, int>)@this->LpVtbl[7])(@this, size);
            return ret;
        }

    }
}
