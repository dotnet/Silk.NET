// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SHChangeNotifyEntry.xml' path='doc/member[@name="SHChangeNotifyEntry"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHChangeNotifyEntry
{
    /// <include file='SHChangeNotifyEntry.xml' path='doc/member[@name="SHChangeNotifyEntry.pidl"]/*'/>
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl;
    /// <include file='SHChangeNotifyEntry.xml' path='doc/member[@name="SHChangeNotifyEntry.fRecursive"]/*'/>
    public BOOL fRecursive;
}