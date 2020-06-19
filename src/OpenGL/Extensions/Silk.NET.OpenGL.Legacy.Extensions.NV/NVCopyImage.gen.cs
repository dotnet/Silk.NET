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
    [Extension("NV_copy_image")]
    public abstract unsafe partial class NVCopyImage : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_copy_image";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcName">
        /// To be added.
        /// </param>
        /// <param name="srcTarget">
        /// To be added.
        /// </param>
        /// <param name="srcLevel">
        /// To be added.
        /// </param>
        /// <param name="srcX">
        /// To be added.
        /// </param>
        /// <param name="srcY">
        /// To be added.
        /// </param>
        /// <param name="srcZ">
        /// To be added.
        /// </param>
        /// <param name="dstName">
        /// To be added.
        /// </param>
        /// <param name="dstTarget">
        /// To be added.
        /// </param>
        /// <param name="dstLevel">
        /// To be added.
        /// </param>
        /// <param name="dstX">
        /// To be added.
        /// </param>
        /// <param name="dstY">
        /// To be added.
        /// </param>
        /// <param name="dstZ">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyImageSubDataNV")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NV srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NV dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcName">
        /// To be added.
        /// </param>
        /// <param name="srcTarget">
        /// To be added.
        /// </param>
        /// <param name="srcLevel">
        /// To be added.
        /// </param>
        /// <param name="srcX">
        /// To be added.
        /// </param>
        /// <param name="srcY">
        /// To be added.
        /// </param>
        /// <param name="srcZ">
        /// To be added.
        /// </param>
        /// <param name="dstName">
        /// To be added.
        /// </param>
        /// <param name="dstTarget">
        /// To be added.
        /// </param>
        /// <param name="dstLevel">
        /// To be added.
        /// </param>
        /// <param name="dstX">
        /// To be added.
        /// </param>
        /// <param name="dstY">
        /// To be added.
        /// </param>
        /// <param name="dstZ">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        /// <param name="depth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyImageSubDataNV")]
        public abstract void CopyImageSubData([Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] CopyBufferSubDataTarget srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] CopyBufferSubDataTarget dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        public NVCopyImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

