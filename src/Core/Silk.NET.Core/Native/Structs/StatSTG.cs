// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Text;

namespace Silk.NET.Core.Native
{
    public unsafe partial struct StatSTG
    {
        public char* pwcsName;
        public uint type;
        public ulong cbSize;
        public FileTime mtime;
        public FileTime ctime;
        public FileTime atime;
        public uint grfMode;
        public uint grfLocksSupported;
        public Guid clsid;
        public uint grfStateBits;
        public uint reserved;
    }
}
