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
    [Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d")]
    [NativeName("Name", "ID2D1Properties")]
    public unsafe partial struct ID2D1Properties : IComVtbl<ID2D1Properties>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("483473d7-cd46-4f9d-9d3a-3112aa80159d");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1Properties val)
            => Unsafe.As<ID2D1Properties, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1Properties
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
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyCount()
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetPropertyName(uint index, char* name, uint nameCount)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, char*, uint, int>)@this->LpVtbl[4])(@this, index, name, nameCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetPropertyNameLength(uint index)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, uint>)@this->LpVtbl[5])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly PropertyType GetType(uint index)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            PropertyType ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType>)@this->LpVtbl[6])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe uint GetPropertyIndex([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, char*, uint>)@this->LpVtbl[7])(@this, name);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValueByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[8])(@this, name, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetValue(uint index, PropertyType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* data, uint dataSize)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[9])(@this, index, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValueByName([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* name, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, char*, PropertyType, byte*, uint, int>)@this->LpVtbl[10])(@this, name, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetValue(uint index, PropertyType type, byte* data, uint dataSize)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, PropertyType, byte*, uint, int>)@this->LpVtbl[11])(@this, index, type, data, dataSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetValueSize(uint index)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, uint>)@this->LpVtbl[12])(@this, index);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSubProperties(uint index, ID2D1Properties** subProperties)
        {
            var @this = (ID2D1Properties*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1Properties*, uint, ID2D1Properties**, int>)@this->LpVtbl[13])(@this, index, subProperties);
            return ret;
        }

    }
}
