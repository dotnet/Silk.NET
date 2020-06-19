// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.QCOM
{
    [Extension("QCOM_alpha_test")]
    public abstract unsafe partial class QComAlphaTest : NativeExtension<GL>
    {
        public const string ExtensionName = "QCOM_alpha_test";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="func">
        /// To be added.
        /// </param>
        /// <param name="@ref">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glAlphaFuncQCOM")]
        public abstract void AlphaFunc([Flow(FlowDirection.In)] QCOM func, [Flow(FlowDirection.In)] float @ref);

        public QComAlphaTest(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

