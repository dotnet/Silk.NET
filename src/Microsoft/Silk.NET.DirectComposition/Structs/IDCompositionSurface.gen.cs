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

namespace Silk.NET.DirectComposition
{
    [Guid("bb8a4953-2c99-4f5a-96f5-4819027fa3ac")]
    [NativeName("Name", "IDCompositionSurface")]
    public unsafe partial struct IDCompositionSurface : IComVtbl<IDCompositionSurface>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("bb8a4953-2c99-4f5a-96f5-4819027fa3ac");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionSurface val)
            => Unsafe.As<IDCompositionSurface, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionSurface
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
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffsetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** updateObjectPtr = &updateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** updateObjectPtr = &updateObject)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** updateObjectPtr = &updateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffset);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** updateObjectPtr = &updateObject)
                    {
                        fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)@this->LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffsetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw()
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SuspendDraw()
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResumeDraw()
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, int>)@this->LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRect, clipRect, offsetX, offsetY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* clipRectPtr = &clipRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRect, clipRectPtr, offsetX, offsetY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* scrollRectPtr = &scrollRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRectPtr, clipRect, offsetX, offsetY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Scroll([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> scrollRect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Box2D<int>* scrollRectPtr = &scrollRect)
            {
                fixed (Silk.NET.Maths.Box2D<int>* clipRectPtr = &clipRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionSurface*, Silk.NET.Maths.Box2D<int>*, Silk.NET.Maths.Box2D<int>*, int, int, int>)@this->LpVtbl[7])(@this, scrollRectPtr, clipRectPtr, offsetX, offsetY);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref ComPtr<TI0> updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDraw(updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), updateOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* updateRect, ref ComPtr<TI0> updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDraw(updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), ref updateOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref ComPtr<TI0> updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDraw(in updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), updateOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly int BeginDraw<TI0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly Silk.NET.Maths.Box2D<int> updateRect, ref ComPtr<TI0> updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->BeginDraw(in updateRect, SilkMarshal.GuidPtrOf<TI0>(), (void**) updateObject.GetAddressOf(), ref updateOffset);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
