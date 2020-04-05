// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_index_material")]
    public abstract unsafe partial class ExtIndexMaterial : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIndexMaterialEXT")]
        public abstract void IndexMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] EXT mode);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIndexMaterialEXT")]
        public abstract void IndexMaterial([Flow(FlowDirection.In)] EXT face, [Flow(FlowDirection.In)] IndexMaterialParameterEXT mode);

        public ExtIndexMaterial(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

