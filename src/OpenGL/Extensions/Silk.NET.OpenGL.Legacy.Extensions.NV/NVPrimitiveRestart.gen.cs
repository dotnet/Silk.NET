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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_primitive_restart")]
    public abstract unsafe partial class NVPrimitiveRestart : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_primitive_restart";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPrimitiveRestartNV")]
        public abstract void PrimitiveRestart();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPrimitiveRestartIndexNV")]
        public abstract void PrimitiveRestartIndex([Flow(FlowDirection.In)] uint index);

        public NVPrimitiveRestart(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

