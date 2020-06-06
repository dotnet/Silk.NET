// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_blend_func_extended")]
    public unsafe partial class ExtBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_extended";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplBindFragDataLocation(program, color, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplBindFragDataLocation(program, color, name);

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
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] char* name)
            => ImplBindFragDataLocationIndexed(program, colorNumber, index, name);

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
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] Span<char> name)
            => ImplBindFragDataLocationIndexed(program, colorNumber, index, name);

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
        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] char* name)
            => ImplGetFragDataIndex(program, name);

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
        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] Span<char> name)
            => ImplGetFragDataIndex(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] char* name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is computed from name.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] ref char name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="color">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name)
            => ImplBindFragDataLocation(program, color, name);

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
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name)
            => ImplBindFragDataLocationIndexed(program, colorNumber, index, name);

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
        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name)
            => ImplGetFragDataIndex(program, name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="program">
        /// To be added.
        /// </param>
        /// <param name="programInterface">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name)
            => ImplGetProgramResourceLocationIndex(program, programInterface, name);

        public ExtBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

