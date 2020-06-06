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
    [Extension("AMD_framebuffer_multisample_advanced")]
    public unsafe partial class AmdFramebufferMultisampleAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_multisample_advanced";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="storageSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisampleAdvance(renderbuffer, samples, storageSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="storageSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisampleAdvance(target, samples, storageSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="renderbuffer">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="storageSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplNamedRenderbufferStorageMultisampleAdvance(renderbuffer, samples, storageSamples, internalformat, width, height);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="samples">
        /// To be added.
        /// </param>
        /// <param name="storageSamples">
        /// To be added.
        /// </param>
        /// <param name="internalformat">
        /// To be added.
        /// </param>
        /// <param name="width">
        /// To be added.
        /// </param>
        /// <param name="height">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height)
            => ImplRenderbufferStorageMultisampleAdvance(target, samples, storageSamples, internalformat, width, height);

        public AmdFramebufferMultisampleAdvanced(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

