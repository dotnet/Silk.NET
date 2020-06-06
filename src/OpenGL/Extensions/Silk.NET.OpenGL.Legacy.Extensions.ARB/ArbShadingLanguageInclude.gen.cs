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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shading_language_include")]
    public unsafe partial class ArbShadingLanguageInclude : NativeExtension<GL>
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] int* length)
            => ImplCompileShaderInclude(shader, count, path, length);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CompileShaderInclude([Flow(FlowDirection.In)] uint shader, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] char** path, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<int> length)
            => ImplCompileShaderInclude(shader, count, path, length);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name)
            => ImplDeleteNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name)
            => ImplDeleteNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* @string)
            => ImplGetNamedString(namelen, name, bufSize, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> @string)
            => ImplGetNamedString(namelen, name, bufSize, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedString(namelen, name, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedString(namelen, name, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name)
            => ImplIsNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name)
            => ImplIsNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] char* name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] char* @string)
            => ImplNamedString(type, namelen, name, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Count(Parameter = "namelen"), Flow(FlowDirection.In)] Span<char> name, [Flow(FlowDirection.In)] int stringlen, [Count(Parameter = "stringlen"), Flow(FlowDirection.In)] Span<char> @string)
            => ImplNamedString(type, namelen, name, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DeleteNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name)
            => ImplDeleteNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] int* stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, 1)] out string @string)
            => ImplGetNamedString(namelen, name, bufSize, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out int stringlen, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, 1)] out string @string)
            => ImplGetNamedString(namelen, name, bufSize, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetNamedString(namelen, name, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetNamedString(namelen, name, pname, @params);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsNamedString([Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name)
            => ImplIsNamedString(namelen, name);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NamedString([Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] int namelen, [Flow(FlowDirection.In)] string name, [Flow(FlowDirection.In)] int stringlen, [Flow(FlowDirection.In)] string @string)
            => ImplNamedString(type, namelen, name, stringlen, @string);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DeleteNamedString([Count(Parameter = "namelen"), Flow(FlowDirection.In)] char name)
        {
            // ArrayParameterOverloader
            DeleteNamedString(1, &name);
        }

        public ArbShadingLanguageInclude(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

