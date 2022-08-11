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
    [Guid("2c1d867d-c290-41c8-ae7e-34a98702e9a5")]
    [NativeName("Name", "ID2D1PrintControl")]
    public unsafe partial struct ID2D1PrintControl
    {
        public static readonly Guid Guid = new("2c1d867d-c290-41c8-ae7e-34a98702e9a5");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1PrintControl val)
            => Unsafe.As<ID2D1PrintControl, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1PrintControl
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
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1, tag2);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag2Ptr = &tag2)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1, tag2Ptr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1Ptr, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* tag1Ptr = &tag1)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStream, tag1Ptr, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ID2D1CommandList* commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    fixed (ulong* tag2Ptr = &tag2)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandList, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1, tag2);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (ulong* tag2Ptr = &tag2)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1, tag2Ptr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1Ptr, tag2);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, Silk.NET.Core.Native.IStream* pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (ulong* tag1Ptr = &tag1)
                {
                    fixed (ulong* tag2Ptr = &tag2)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStream, tag1Ptr, tag2Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ulong* tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1, tag2);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ulong* tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
                {
                    fixed (ulong* tag2Ptr = &tag2)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1, tag2Ptr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ref ulong tag1, ulong* tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
                {
                    fixed (ulong* tag1Ptr = &tag1)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddPage(ref ID2D1CommandList commandList, Silk.NET.Maths.Vector2D<float> pageSize, ref Silk.NET.Core.Native.IStream pagePrintTicketStream, ref ulong tag1, ref ulong tag2)
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1CommandList* commandListPtr = &commandList)
            {
                fixed (Silk.NET.Core.Native.IStream* pagePrintTicketStreamPtr = &pagePrintTicketStream)
                {
                    fixed (ulong* tag1Ptr = &tag1)
                    {
                        fixed (ulong* tag2Ptr = &tag2)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, ID2D1CommandList*, Silk.NET.Maths.Vector2D<float>, Silk.NET.Core.Native.IStream*, ulong*, ulong*, int>)LpVtbl[3])(@this, commandListPtr, pageSize, pagePrintTicketStreamPtr, tag1Ptr, tag2Ptr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Close()
        {
            var @this = (ID2D1PrintControl*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1PrintControl*, int>)LpVtbl[4])(@this);
            return ret;
        }

    }
}
