// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define DiaTable_Symbols ( L\"Symbols\" )")]
    public const string DiaTable_Symbols = ("Symbols");

    [NativeTypeName("#define DiaTable_Sections ( L\"Sections\" )")]
    public const string DiaTable_Sections = ("Sections");

    [NativeTypeName("#define DiaTable_SrcFiles ( L\"SourceFiles\" )")]
    public const string DiaTable_SrcFiles = ("SourceFiles");

    [NativeTypeName("#define DiaTable_LineNums ( L\"LineNumbers\" )")]
    public const string DiaTable_LineNums = ("LineNumbers");

    [NativeTypeName("#define DiaTable_SegMap ( L\"SegmentMap\" )")]
    public const string DiaTable_SegMap = ("SegmentMap");

    [NativeTypeName("#define DiaTable_Dbg ( L\"Dbg\" )")]
    public const string DiaTable_Dbg = ("Dbg");

    [NativeTypeName("#define DiaTable_InjSrc ( L\"InjectedSource\" )")]
    public const string DiaTable_InjSrc = ("InjectedSource");

    [NativeTypeName("#define DiaTable_FrameData ( L\"FrameData\" )")]
    public const string DiaTable_FrameData = ("FrameData");

    [NativeTypeName("#define DiaTable_InputAssemblyFiles ( L\"InputAssemblyFiles\" )")]
    public const string DiaTable_InputAssemblyFiles = ("InputAssemblyFiles");
}
