// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_EVENT_DESCRIPTOR")]
    public unsafe partial struct EventDescriptor
    {
        public EventDescriptor
        (
            ushort? id = null,
            byte? version = null,
            byte? channel = null,
            byte? level = null,
            byte? opcode = null,
            ushort? task = null,
            ulong? keyword = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }

            if (channel is not null)
            {
                Channel = channel.Value;
            }

            if (level is not null)
            {
                Level = level.Value;
            }

            if (opcode is not null)
            {
                Opcode = opcode.Value;
            }

            if (task is not null)
            {
                Task = task.Value;
            }

            if (keyword is not null)
            {
                Keyword = keyword.Value;
            }
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Id")]
        public ushort Id;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Version")]
        public byte Version;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Channel")]
        public byte Channel;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Level")]
        public byte Level;

        [NativeName("Type", "UCHAR")]
        [NativeName("Type.Name", "UCHAR")]
        [NativeName("Name", "Opcode")]
        public byte Opcode;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Task")]
        public ushort Task;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "Keyword")]
        public ulong Keyword;
    }
}
