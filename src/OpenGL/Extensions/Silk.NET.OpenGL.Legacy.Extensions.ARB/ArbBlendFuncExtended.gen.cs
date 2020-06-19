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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_blend_func_extended")]
    public abstract unsafe partial class ArbBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_blend_func_extended";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="colorNumber">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="colorNumber">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="colorNumber">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public abstract void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public abstract int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        public ArbBlendFuncExtended(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

