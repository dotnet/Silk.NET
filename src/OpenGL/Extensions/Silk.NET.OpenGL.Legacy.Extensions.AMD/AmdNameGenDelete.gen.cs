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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_name_gen_delete")]
    public unsafe partial class AmdNameGenDelete : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_name_gen_delete";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="names">
        /// To be added.
        /// This parameter's element count is taken from num.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] uint* names)
            => ImplDeleteNames(identifier, num, names);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="names">
        /// To be added.
        /// This parameter's element count is taken from num.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] Span<uint> names)
            => ImplDeleteNames(identifier, num, names);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="names">
        /// To be added.
        /// This parameter's element count is taken from num.
        /// </param>
        [NativeApi(EntryPoint = "glGenNamesAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] uint* names)
            => ImplGenNames(identifier, num, names);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="num">
        /// To be added.
        /// </param>
        /// <param name="names">
        /// To be added.
        /// This parameter's element count is taken from num.
        /// </param>
        [NativeApi(EntryPoint = "glGenNamesAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] Span<uint> names)
            => ImplGenNames(identifier, num, names);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsNameAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsName([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint name)
            => ImplIsName(identifier, name);

        public AmdNameGenDelete(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

