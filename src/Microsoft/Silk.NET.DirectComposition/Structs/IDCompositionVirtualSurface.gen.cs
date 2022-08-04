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
    [NativeName("Name", "IDCompositionVirtualSurface")]
    public unsafe partial struct IDCompositionVirtualSurface
    {
        public static implicit operator IDCompositionSurface(IDCompositionVirtualSurface val)
            => Unsafe.As<IDCompositionVirtualSurface, IDCompositionSurface>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionVirtualSurface val)
            => Unsafe.As<IDCompositionVirtualSurface, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionVirtualSurface
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
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iid, updateObject, updateOffsetPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** updateObjectPtr = &updateObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** updateObjectPtr = &updateObject)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iid, updateObjectPtr, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iidPtr, updateObject, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(Silk.NET.Maths.Rectangle<int>* updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRect, iidPtr, updateObjectPtr, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, Guid* iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffset);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, Guid* iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iid, updateObject, updateOffsetPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, Guid* iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, Guid* iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (void** updateObjectPtr = &updateObject)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iid, updateObjectPtr, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, ref Guid iid, void** updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffset);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, ref Guid iid, void** updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObject, updateOffsetPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, ref Guid iid, ref void* updateObject, Silk.NET.Maths.Vector2D<int>* updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** updateObjectPtr = &updateObject)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffset);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int BeginDraw(ref Silk.NET.Maths.Rectangle<int> updateRect, ref Guid iid, ref void* updateObject, ref Silk.NET.Maths.Vector2D<int> updateOffset)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* updateRectPtr = &updateRect)
            {
                fixed (Guid* iidPtr = &iid)
                {
                    fixed (void** updateObjectPtr = &updateObject)
                    {
                        fixed (Silk.NET.Maths.Vector2D<int>* updateOffsetPtr = &updateOffset)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Guid*, void**, Silk.NET.Maths.Vector2D<int>*, int>)LpVtbl[3])(@this, updateRectPtr, iidPtr, updateObjectPtr, updateOffsetPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int EndDraw()
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)LpVtbl[4])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SuspendDraw()
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ResumeDraw()
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, int>)LpVtbl[6])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll(Silk.NET.Maths.Rectangle<int>* scrollRect, Silk.NET.Maths.Rectangle<int>* clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int, int, int>)LpVtbl[7])(@this, scrollRect, clipRect, offsetX, offsetY);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll(Silk.NET.Maths.Rectangle<int>* scrollRect, ref Silk.NET.Maths.Rectangle<int> clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* clipRectPtr = &clipRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int, int, int>)LpVtbl[7])(@this, scrollRect, clipRectPtr, offsetX, offsetY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Scroll(ref Silk.NET.Maths.Rectangle<int> scrollRect, Silk.NET.Maths.Rectangle<int>* clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* scrollRectPtr = &scrollRect)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int, int, int>)LpVtbl[7])(@this, scrollRectPtr, clipRect, offsetX, offsetY);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Scroll(ref Silk.NET.Maths.Rectangle<int> scrollRect, ref Silk.NET.Maths.Rectangle<int> clipRect, int offsetX, int offsetY)
        {
            var @this = (IDCompositionVirtualSurface*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.Maths.Rectangle<int>* scrollRectPtr = &scrollRect)
            {
                fixed (Silk.NET.Maths.Rectangle<int>* clipRectPtr = &clipRect)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionVirtualSurface*, Silk.NET.Maths.Rectangle<int>*, Silk.NET.Maths.Rectangle<int>*, int, int, int>)LpVtbl[7])(@this, scrollRectPtr, clipRectPtr, offsetX, offsetY);
                }
            }
            return ret;
        }

    }
}
