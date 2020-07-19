// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_shading_language_include")]
    public abstract unsafe partial class ArbShadingLanguageInclude : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shading_language_include";
        [NativeApi(EntryPoint = "glCompileShaderIncludeARB")]
        public abstract unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        [NativeApi(EntryPoint = "glCompileShaderIncludeARB")]
        public abstract unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] byte** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract unsafe void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<byte> name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> @string);

        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<byte> name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract unsafe bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<byte> name);

        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte* name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] byte* @string);

        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<byte> name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] Span<byte> @string);

        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string @string);

        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In)] string @string);

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var path = (byte**) SilkMarshal.MarshalStringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) path, pathSa);
        }

        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var path = (byte**) SilkMarshal.MarshalStringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) path, pathSa);
        }

        public unsafe void DeleteNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] byte name)
        {
            // ArrayParameterOverloader
            DeleteNamedString(1, &name);
        }

        public ArbShadingLanguageInclude(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

