// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PSINJECT
{
    [NativeTypeName("#define PSINJECT_BEGINSTREAM 1")]
    public const int PSINJECT_BEGINSTREAM = 1;
    [NativeTypeName("#define PSINJECT_PSADOBE 2")]
    public const int PSINJECT_PSADOBE = 2;
    [NativeTypeName("#define PSINJECT_PAGESATEND 3")]
    public const int PSINJECT_PAGESATEND = 3;
    [NativeTypeName("#define PSINJECT_PAGES 4")]
    public const int PSINJECT_PAGES = 4;
    [NativeTypeName("#define PSINJECT_DOCNEEDEDRES 5")]
    public const int PSINJECT_DOCNEEDEDRES = 5;
    [NativeTypeName("#define PSINJECT_DOCSUPPLIEDRES 6")]
    public const int PSINJECT_DOCSUPPLIEDRES = 6;
    [NativeTypeName("#define PSINJECT_PAGEORDER 7")]
    public const int PSINJECT_PAGEORDER = 7;
    [NativeTypeName("#define PSINJECT_ORIENTATION 8")]
    public const int PSINJECT_ORIENTATION = 8;
    [NativeTypeName("#define PSINJECT_BOUNDINGBOX 9")]
    public const int PSINJECT_BOUNDINGBOX = 9;
    [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORS 10")]
    public const int PSINJECT_DOCUMENTPROCESSCOLORS = 10;
    [NativeTypeName("#define PSINJECT_COMMENTS 11")]
    public const int PSINJECT_COMMENTS = 11;
    [NativeTypeName("#define PSINJECT_BEGINDEFAULTS 12")]
    public const int PSINJECT_BEGINDEFAULTS = 12;
    [NativeTypeName("#define PSINJECT_ENDDEFAULTS 13")]
    public const int PSINJECT_ENDDEFAULTS = 13;
    [NativeTypeName("#define PSINJECT_BEGINPROLOG 14")]
    public const int PSINJECT_BEGINPROLOG = 14;
    [NativeTypeName("#define PSINJECT_ENDPROLOG 15")]
    public const int PSINJECT_ENDPROLOG = 15;
    [NativeTypeName("#define PSINJECT_BEGINSETUP 16")]
    public const int PSINJECT_BEGINSETUP = 16;
    [NativeTypeName("#define PSINJECT_ENDSETUP 17")]
    public const int PSINJECT_ENDSETUP = 17;
    [NativeTypeName("#define PSINJECT_TRAILER 18")]
    public const int PSINJECT_TRAILER = 18;
    [NativeTypeName("#define PSINJECT_EOF 19")]
    public const int PSINJECT_EOF = 19;
    [NativeTypeName("#define PSINJECT_ENDSTREAM 20")]
    public const int PSINJECT_ENDSTREAM = 20;
    [NativeTypeName("#define PSINJECT_DOCUMENTPROCESSCOLORSATEND 21")]
    public const int PSINJECT_DOCUMENTPROCESSCOLORSATEND = 21;
    [NativeTypeName("#define PSINJECT_PAGENUMBER 100")]
    public const int PSINJECT_PAGENUMBER = 100;
    [NativeTypeName("#define PSINJECT_BEGINPAGESETUP 101")]
    public const int PSINJECT_BEGINPAGESETUP = 101;
    [NativeTypeName("#define PSINJECT_ENDPAGESETUP 102")]
    public const int PSINJECT_ENDPAGESETUP = 102;
    [NativeTypeName("#define PSINJECT_PAGETRAILER 103")]
    public const int PSINJECT_PAGETRAILER = 103;
    [NativeTypeName("#define PSINJECT_PLATECOLOR 104")]
    public const int PSINJECT_PLATECOLOR = 104;
    [NativeTypeName("#define PSINJECT_SHOWPAGE 105")]
    public const int PSINJECT_SHOWPAGE = 105;
    [NativeTypeName("#define PSINJECT_PAGEBBOX 106")]
    public const int PSINJECT_PAGEBBOX = 106;
    [NativeTypeName("#define PSINJECT_ENDPAGECOMMENTS 107")]
    public const int PSINJECT_ENDPAGECOMMENTS = 107;
    [NativeTypeName("#define PSINJECT_VMSAVE 200")]
    public const int PSINJECT_VMSAVE = 200;
    [NativeTypeName("#define PSINJECT_VMRESTORE 201")]
    public const int PSINJECT_VMRESTORE = 201;
    [NativeTypeName("#define PSINJECT_DLFONT 0xdddddddd")]
    public const uint PSINJECT_DLFONT = 0xdddddddd;
}