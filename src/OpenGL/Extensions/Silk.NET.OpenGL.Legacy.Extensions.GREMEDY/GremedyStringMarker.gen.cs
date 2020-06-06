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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    [Extension("GREMEDY_string_marker")]
    public unsafe partial class GremedyStringMarker : NativeExtension<GL>
    {
        public const string ExtensionName = "GREMEDY_string_marker";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void StringMarker([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] void* @string)
            => ImplStringMarker(len, @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="len">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from len.
        /// </param>
        [NativeApi(EntryPoint = "glStringMarkerGREMEDY")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void StringMarker<T0>([Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] Span<T0> @string) where T0 : unmanaged
            => ImplStringMarker<T0>(len, @string);

        public GremedyStringMarker(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

