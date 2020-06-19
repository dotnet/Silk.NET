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
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="path">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glCompileShaderIncludeARB")]
        public abstract unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="path">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        [NativeApi(EntryPoint = "glCompileShaderIncludeARB")]
        public abstract unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract unsafe void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract unsafe bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from stringlen.
        /// </param>
        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] char* @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// This parameter's element count is taken from stringlen.
        /// </param>
        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] Span<char> @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDeleteNamedStringARB")]
        public abstract void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, 1)] out string @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, 1)] out string @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedStringivARB")]
        public abstract void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsNamedStringARB")]
        public abstract bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="stringlen">
        /// To be added.
        /// </param>
        /// <param name="@string">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedStringARB")]
        public abstract void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In)] string @string);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="path">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
        {
            // StringArrayOverloader
            var path = (char**) SilkMarshal.MarshalStringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) path, pathSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="shader">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="path">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] string[] pathSa, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
        {
            // StringArrayOverloader
            var path = (char**) SilkMarshal.MarshalStringArrayToPtr(pathSa);
            CompileShaderInclude(shader, count, path, length);
            SilkMarshal.CopyPtrToStringArray((IntPtr) path, pathSa);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="namelen">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// This parameter's element count is taken from namelen.
        /// </param>
        public unsafe void DeleteNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] char name)
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

