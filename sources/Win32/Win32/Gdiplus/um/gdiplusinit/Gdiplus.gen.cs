// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static unsafe partial class Gdiplus
{
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdiplusStartup(
        [NativeTypeName("ULONG_PTR *")] nuint* token,
        [NativeTypeName("const GdiplusStartupInput *")] GdiplusStartupInput* input,
        [NativeTypeName("Gdiplus::GdiplusStartupOutput *")] GdiplusStartupOutput* output
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern void GdiplusShutdown([NativeTypeName("ULONG_PTR")] nuint token);
}
