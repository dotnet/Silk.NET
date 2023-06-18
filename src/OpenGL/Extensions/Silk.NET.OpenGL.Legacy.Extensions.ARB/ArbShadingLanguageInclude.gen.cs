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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shading_language_include")]
    public unsafe partial class ArbShadingLanguageInclude : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shading_language_include";
        [NativeApi(EntryPoint = "glCompileShaderIncludeARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void CompileShaderInclude([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint shader, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteNamedString([Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedString([Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glIsNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial bool IsNamedString([Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glNamedStringARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedString([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* @string);

        public ArbShadingLanguageInclude(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

