// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_index_material")]
    public unsafe partial class ExtIndexMaterial : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_index_material";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexMaterialEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void IndexMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT mode)
            => ImplIndexMaterial(face, mode);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="face">
        /// To be added.
        /// </param>
        /// <param name="mode">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexMaterialEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void IndexMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] IndexMaterialParameterEXT mode)
            => ImplIndexMaterial(face, mode);

        public ExtIndexMaterial(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

