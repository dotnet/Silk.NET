// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using UnmanagedType = Silk.NET.Core.Native.UnmanagedType;

namespace TestLib
{
    [PInvokeOverride("user32.dll")]
    public partial class TestClass2 : NativeApiContainer
    {

        [NativeApi(EntryPoint = "MessageBoxA")]
        public unsafe partial int MessageBox(IntPtr hwnd, char* text, char* caption, uint buttons);
        
        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(IntPtr hwnd, string text, string caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(IntPtr hwnd, string text, string caption,
            [UnmanagedType(UnmanagedType.U4)] bool buttons);
        
        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(IntPtr hwnd, string text, Span<char> caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        public unsafe partial int MessageBox(IntPtr hwnd, string text, char* caption, uint buttons);

        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox<T>(IntPtr hwnd, string text, Span<T> caption, uint buttons) where T:unmanaged;
        
        public unsafe partial IntPtr CreateWindowExA(
            uint     dwExStyle,
            string    lpClassName,
            string    lpWindowName,
            uint     dwStyle,
            int       X,
            int       Y,
            int       nWidth,
            int       nHeight,
            IntPtr      hWndParent,
            IntPtr     hMenu,
            IntPtr hInstance,
            void*    lpParam
        );

        // public partial int GetWindowTextA(IntPtr hwnd, [Count(Parameter = "hwnd")] ref string str, int maxCount);

        public TestClass2() : base(CreateDefaultContext("user32.dll")) { }
    }
}
