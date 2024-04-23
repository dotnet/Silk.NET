using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    public partial class D2D
    {
        public static D2D GetApi()
        {
             return new(CreateDefaultContext(new D2DLibraryNameContainer().GetLibraryNames()));
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<D2D>
        {
            throw new NotImplementedException();
        }

        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 5 in d2d1_3.h")]
        [NativeApi(EntryPoint = "D2D1GetGradientMeshInteriorPointsFromCoonsPatch", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(Silk.NET.Maths.Vector2D<float>* pPoint0, Silk.NET.Maths.Vector2D<float>* pPoint1, Silk.NET.Maths.Vector2D<float>* pPoint2, Silk.NET.Maths.Vector2D<float>* pPoint3, Silk.NET.Maths.Vector2D<float>* pPoint4, Silk.NET.Maths.Vector2D<float>* pPoint5, Silk.NET.Maths.Vector2D<float>* pPoint6, Silk.NET.Maths.Vector2D<float>* pPoint7, Silk.NET.Maths.Vector2D<float>* pPoint8, Silk.NET.Maths.Vector2D<float>* pPoint9, Silk.NET.Maths.Vector2D<float>* pPoint10, Silk.NET.Maths.Vector2D<float>* pPoint11, Silk.NET.Maths.Vector2D<float>* pTensorPoint11, Silk.NET.Maths.Vector2D<float>* pTensorPoint12, Silk.NET.Maths.Vector2D<float>* pTensorPoint21, Silk.NET.Maths.Vector2D<float>* pTensorPoint22);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1831, Column 5 in d2d1_3.h")]
        [NativeApi(EntryPoint = "D2D1GetGradientMeshInteriorPointsFromCoonsPatch", Convention = CallingConvention.StdCall)]
        public unsafe partial void D2D1GetGradientMeshInteriorPointsFromCoonsPatch(ref Silk.NET.Maths.Vector2D<float> pPoint0, ref Silk.NET.Maths.Vector2D<float> pPoint1, ref Silk.NET.Maths.Vector2D<float> pPoint2, ref Silk.NET.Maths.Vector2D<float> pPoint3, ref Silk.NET.Maths.Vector2D<float> pPoint4, ref Silk.NET.Maths.Vector2D<float> pPoint5, ref Silk.NET.Maths.Vector2D<float> pPoint6, ref Silk.NET.Maths.Vector2D<float> pPoint7, ref Silk.NET.Maths.Vector2D<float> pPoint8, ref Silk.NET.Maths.Vector2D<float> pPoint9, ref Silk.NET.Maths.Vector2D<float> pPoint10, ref Silk.NET.Maths.Vector2D<float> pPoint11, ref Silk.NET.Maths.Vector2D<float> pTensorPoint11, ref Silk.NET.Maths.Vector2D<float> pTensorPoint12, ref Silk.NET.Maths.Vector2D<float> pTensorPoint21, ref Silk.NET.Maths.Vector2D<float> pTensorPoint22);
    }
}

