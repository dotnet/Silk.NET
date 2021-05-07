// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;

namespace TestLib
{
    partial class TestClass2
    {
        [NativeApi(EntryPoint = "MessageBoxA")]
        public partial int MessageBox(nint hwnd, string text, string caption,
            [UnmanagedType(UnmanagedType.U4)] bool buttons);
    }
}
