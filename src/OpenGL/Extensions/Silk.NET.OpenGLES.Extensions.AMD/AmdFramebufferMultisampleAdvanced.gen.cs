// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.AMD
{
    [Extension("AMD_framebuffer_multisample_advanced")]
    public unsafe partial class AmdFramebufferMultisampleAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_multisample_advanced";
        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glNamedRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void NamedRenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] uint renderbuffer, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] AMD internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        [NativeApi(EntryPoint = "glRenderbufferStorageMultisampleAdvancedAMD", Convention = CallingConvention.Winapi)]
        public partial void RenderbufferStorageMultisampleAdvance([Flow(FlowDirection.In)] RenderbufferTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint storageSamples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height);

        public AmdFramebufferMultisampleAdvanced(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

