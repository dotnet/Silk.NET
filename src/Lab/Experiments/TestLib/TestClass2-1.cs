// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace TestLib
{
    [PInvokeOverride(1, "user32.dll")]
    public partial class TestClass2 : NativeApiContainer
    {

        [NativeApi(EntryPoint = "MessageBoxA")]
        [Inject(SilkTouchStage.Begin, "System.Console.WriteLine(\"Stage: Begin\");")]
        [Inject(SilkTouchStage.PostInit, "System.Console.WriteLine(\"Stage: PostInit\");")]
        [Inject(SilkTouchStage.PreLoad, "System.Console.WriteLine(\"Stage: PreLoad\");")]
        [Inject(SilkTouchStage.PostLoad, "System.Console.WriteLine(\"Stage: PostLoad\");")]
        [Inject(SilkTouchStage.End, "System.Console.WriteLine(\"Stage: End\");")]
        public unsafe partial int MessageBox(nint hwnd, char* text, char* caption, uint buttons);
        
        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(nint hwnd, string text, string caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(nint hwnd, string text, Span<char> caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        public unsafe partial int MessageBox(nint hwnd, string text, char* caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        [ExcludeFromOverride(1)]
        public partial int MessageBox<T>(nint hwnd, string text, Span<T> caption, uint buttons) where T:unmanaged;
        
        public unsafe partial nint CreateWindowExA(
            uint     dwExStyle,
            string    lpClassName,
            string    lpWindowName,
            uint     dwStyle,
            int       X,
            int       Y,
            int       nWidth,
            int       nHeight,
            nint      hWndParent,
            nint     hMenu,
            nint hInstance,
            void*    lpParam
        );

        // public partial int GetWindowTextA(IntPtr hwnd, [Count(Parameter = "hwnd")] ref string str, int maxCount);

        public TestClass2() : base(CreateDefaultContext(new[] { "user32.dll" })) { }
    }
}
