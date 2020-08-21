// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_name_gen_delete")]
    public unsafe partial class AmdNameGenDelete : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_name_gen_delete";
        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        public unsafe partial void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] uint* names);

        [NativeApi(EntryPoint = "glDeleteNamesAMD")]
        public partial void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] in uint names);

        [NativeApi(EntryPoint = "glGenNamesAMD")]
        public unsafe partial void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] uint* names);

        [NativeApi(EntryPoint = "glGenNamesAMD")]
        public partial void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] out uint names);

        [NativeApi(EntryPoint = "glIsNameAMD")]
        public partial bool IsName([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint name);

        public AmdNameGenDelete(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

