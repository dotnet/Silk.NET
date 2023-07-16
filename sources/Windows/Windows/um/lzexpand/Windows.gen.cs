// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/lzexpand.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZStart"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int LZStart();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZDone"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern void LZDone();
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CopyLZFile"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int CopyLZFile(int hfSource, int hfDest);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZCopy"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int LZCopy(int hfSource, int hfDest);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZInit"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int LZInit(int hfSource);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetExpandedNameA"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int GetExpandedNameA([NativeTypeName("LPSTR")] sbyte* lpszSource, [NativeTypeName("LPSTR")] sbyte* lpszBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetExpandedNameW"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int GetExpandedNameW([NativeTypeName("LPWSTR")] ushort* lpszSource, [NativeTypeName("LPWSTR")] ushort* lpszBuffer);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZOpenFileA"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int LZOpenFileA([NativeTypeName("LPSTR")] sbyte* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuf, [NativeTypeName("WORD")] ushort wStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZOpenFileW"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int LZOpenFileW([NativeTypeName("LPWSTR")] ushort* lpFileName, [NativeTypeName("LPOFSTRUCT")] OFSTRUCT* lpReOpenBuf, [NativeTypeName("WORD")] ushort wStyle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZSeek"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    [return: NativeTypeName("LONG")]
    public static extern int LZSeek(int hFile, [NativeTypeName("LONG")] int lOffset, int iOrigin);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZRead"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern int LZRead(int hFile, [NativeTypeName("CHAR *")] sbyte* lpBuffer, int cbRead);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.LZClose"]/*'/>
    [DllImport("lz32", ExactSpelling = true)]
    public static extern void LZClose(int hFile);
    [NativeTypeName("#define LZERROR_BADINHANDLE (-1)")]
    public const int LZERROR_BADINHANDLE = (-1);
    [NativeTypeName("#define LZERROR_BADOUTHANDLE (-2)")]
    public const int LZERROR_BADOUTHANDLE = (-2);
    [NativeTypeName("#define LZERROR_READ (-3)")]
    public const int LZERROR_READ = (-3);
    [NativeTypeName("#define LZERROR_WRITE (-4)")]
    public const int LZERROR_WRITE = (-4);
    [NativeTypeName("#define LZERROR_GLOBALLOC (-5)")]
    public const int LZERROR_GLOBALLOC = (-5);
    [NativeTypeName("#define LZERROR_GLOBLOCK (-6)")]
    public const int LZERROR_GLOBLOCK = (-6);
    [NativeTypeName("#define LZERROR_BADVALUE (-7)")]
    public const int LZERROR_BADVALUE = (-7);
    [NativeTypeName("#define LZERROR_UNKNOWNALG (-8)")]
    public const int LZERROR_UNKNOWNALG = (-8);
    [NativeTypeName("#define GetExpandedName GetExpandedNameW")]
    public static delegate*<ushort*, ushort*, int> GetExpandedName => &GetExpandedNameW;

    [NativeTypeName("#define LZOpenFile LZOpenFileW")]
    public static delegate*<ushort*, OFSTRUCT*, ushort, int> LZOpenFile => &LZOpenFileW;
}