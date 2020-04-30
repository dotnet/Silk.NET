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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_name_gen_delete")]
    public abstract unsafe partial class AmdNameGenDelete : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        public abstract unsafe void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] uint* names);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        public abstract void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] Span<uint> names);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenNamesAMD")]
        public abstract unsafe void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] uint* names);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGenNamesAMD")]
        public abstract void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] Span<uint> names);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIsNameAMD")]
        public abstract bool IsName([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint name);

        public AmdNameGenDelete(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

