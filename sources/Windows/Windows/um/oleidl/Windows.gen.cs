// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define UPDFCACHE_NODATACACHE ( 0x1 )")]
    public const int UPDFCACHE_NODATACACHE = (0x1);
    [NativeTypeName("#define UPDFCACHE_ONSAVECACHE ( 0x2 )")]
    public const int UPDFCACHE_ONSAVECACHE = (0x2);
    [NativeTypeName("#define UPDFCACHE_ONSTOPCACHE ( 0x4 )")]
    public const int UPDFCACHE_ONSTOPCACHE = (0x4);
    [NativeTypeName("#define UPDFCACHE_NORMALCACHE ( 0x8 )")]
    public const int UPDFCACHE_NORMALCACHE = (0x8);
    [NativeTypeName("#define UPDFCACHE_IFBLANK ( 0x10 )")]
    public const int UPDFCACHE_IFBLANK = (0x10);
    [NativeTypeName("#define UPDFCACHE_ONLYIFBLANK ( 0x80000000 )")]
    public const uint UPDFCACHE_ONLYIFBLANK = (0x80000000);
    [NativeTypeName("#define UPDFCACHE_IFBLANKORONSAVECACHE ( ( UPDFCACHE_IFBLANK | UPDFCACHE_ONSAVECACHE )  )")]
    public const int UPDFCACHE_IFBLANKORONSAVECACHE = (((0x10) | (0x2)));
    [NativeTypeName("#define UPDFCACHE_ALL ( ( DWORD  )~UPDFCACHE_ONLYIFBLANK )")]
    public const uint UPDFCACHE_ALL = ((uint)(~(0x80000000)));
    [NativeTypeName("#define UPDFCACHE_ALLBUTNODATACACHE ( ( UPDFCACHE_ALL & ( DWORD  )~UPDFCACHE_NODATACACHE )  )")]
    public const uint UPDFCACHE_ALLBUTNODATACACHE = unchecked((((uint)(~(0x80000000))) & (uint)(~(0x1))));
    [NativeTypeName("#define DROPEFFECT_NONE ( 0 )")]
    public const int DROPEFFECT_NONE = (0);
    [NativeTypeName("#define DROPEFFECT_COPY ( 1 )")]
    public const int DROPEFFECT_COPY = (1);
    [NativeTypeName("#define DROPEFFECT_MOVE ( 2 )")]
    public const int DROPEFFECT_MOVE = (2);
    [NativeTypeName("#define DROPEFFECT_LINK ( 4 )")]
    public const int DROPEFFECT_LINK = (4);
    [NativeTypeName("#define DROPEFFECT_SCROLL ( 0x80000000 )")]
    public const uint DROPEFFECT_SCROLL = (0x80000000);
    [NativeTypeName("#define DD_DEFSCROLLINSET ( 11 )")]
    public const int DD_DEFSCROLLINSET = (11);
    [NativeTypeName("#define DD_DEFSCROLLDELAY ( 50 )")]
    public const int DD_DEFSCROLLDELAY = (50);
    [NativeTypeName("#define DD_DEFSCROLLINTERVAL ( 50 )")]
    public const int DD_DEFSCROLLINTERVAL = (50);
    [NativeTypeName("#define DD_DEFDRAGDELAY ( 200 )")]
    public const int DD_DEFDRAGDELAY = (200);
    [NativeTypeName("#define DD_DEFDRAGMINDIST ( 2 )")]
    public const int DD_DEFDRAGMINDIST = (2);
}