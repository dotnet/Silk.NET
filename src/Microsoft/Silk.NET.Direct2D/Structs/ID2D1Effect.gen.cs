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
    [Guid("28211a43-7d89-476f-8181-2d6159b220ad")]
    [NativeName("Name", "ID2D1Effect")]
    public unsafe partial struct ID2D1Effect
    {
        public static readonly Guid Guid = new("28211a43-7d89-476f-8181-2d6159b220ad");

        public static implicit operator ID2D1Properties(ID2D1Effect val)
            => Unsafe.As<ID2D1Effect, ID2D1Properties>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Effect val)
            => Unsafe.As<ID2D1Effect, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Effect
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
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyCount()
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyName(uint index, char* name, uint nameCount)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, char*, uint, int>)LpVtbl[4])(@this, index, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyName(uint index, ref char name, uint nameCount)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, char*, uint, int>)LpVtbl[4])(@this, index, namePtr, nameCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetPropertyName(uint index, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, uint nameCount)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, byte*, uint, int>)LpVtbl[4])(@this, index, namePtr, nameCount);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyNameLength(uint index)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)LpVtbl[5])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PropertyType GetType(uint index)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PropertyType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType>)LpVtbl[6])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetPropertyIndex(char* name)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, uint>)LpVtbl[7])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyIndex(ref char name)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, uint>)LpVtbl[7])(@this, namePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyIndex([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, uint>)LpVtbl[7])(@this, namePtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName(char* name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, name, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName(char* name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, name, type, dataPtr, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName(char* name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, name, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName(ref char name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, data, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValueByName(ref char name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValueByName(ref char name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, data, dataSize);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[8])(@this, namePtr, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue(uint index, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[9])(@this, index, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValue(uint index, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[9])(@this, index, type, dataPtr, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetValue(uint index, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[9])(@this, index, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName(char* name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, name, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName(char* name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, name, type, dataPtr, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName(char* name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, name, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName(ref char name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, data, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValueByName(ref char name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
                fixed (byte* dataPtr = &data)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValueByName(ref char name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (char* namePtr = &name)
            {
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, char*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, data, dataSize);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
            }
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValueByName([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string name, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var namePtr = (byte*) SilkMarshal.StringToPtr(name, NativeStringEncoding.UTF8);
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, byte*, PropertyType, byte*, uint, int>)LpVtbl[10])(@this, namePtr, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            SilkMarshal.Free((nint)namePtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue(uint index, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[11])(@this, index, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValue(uint index, PropertyType type, ref byte data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[11])(@this, index, type, dataPtr, dataSize);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetValue(uint index, PropertyType type, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string data, uint dataSize)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var dataPtr = (byte*) SilkMarshal.StringToPtr(data, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, PropertyType, byte*, uint, int>)LpVtbl[11])(@this, index, type, dataPtr, dataSize);
            SilkMarshal.Free((nint)dataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetValueSize(uint index)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, uint>)LpVtbl[12])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubProperties(uint index, ID2D1Properties** subProperties)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)LpVtbl[13])(@this, index, subProperties);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubProperties(uint index, ref ID2D1Properties* subProperties)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1Properties** subPropertiesPtr = &subProperties)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Properties**, int>)LpVtbl[13])(@this, index, subPropertiesPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetInput(uint index, ID2D1Image* input, int invalidate)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, int, void>)LpVtbl[14])(@this, index, input, invalidate);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetInput(uint index, ref ID2D1Image input, int invalidate)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image* inputPtr = &input)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image*, int, void>)LpVtbl[14])(@this, index, inputPtr, invalidate);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInputCount(uint inputCount)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, int>)LpVtbl[15])(@this, inputCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetInput(uint index, ID2D1Image** input)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)LpVtbl[16])(@this, index, input);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetInput(uint index, ref ID2D1Image* input)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image** inputPtr = &input)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint, ID2D1Image**, void>)LpVtbl[16])(@this, index, inputPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Effect*, uint>)LpVtbl[17])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutput(ID2D1Image** outputImage)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)LpVtbl[18])(@this, outputImage);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetOutput(ref ID2D1Image* outputImage)
        {
            var @this = (ID2D1Effect*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Image** outputImagePtr = &outputImage)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1Effect*, ID2D1Image**, void>)LpVtbl[18])(@this, outputImagePtr);
            }
        }

    }
}
