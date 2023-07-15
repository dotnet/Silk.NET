// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus;
public static unsafe partial class Gdiplus
{
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdiplusStartup"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::Status")]
    public static extern GpStatus GdiplusStartup([NativeTypeName("ULONG_PTR *")] nuint* token, [NativeTypeName("const GdiplusStartupInput *")] GdiplusStartupInput* input, [NativeTypeName("Gdiplus::GdiplusStartupOutput *")] GdiplusStartupOutput* output);
    /// <include file='Gdiplus.xml' path='doc/member[@name="Gdiplus.GdiplusShutdown"]/*'/>
    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern void GdiplusShutdown([NativeTypeName("ULONG_PTR")] nuint token);
}