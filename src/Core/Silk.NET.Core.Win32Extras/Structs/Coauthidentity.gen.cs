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
    [NativeName("Name", "_COAUTHIDENTITY")]
    public unsafe partial struct Coauthidentity
    {
        public Coauthidentity
        (
            ushort* user = null,
            uint? userLength = null,
            ushort* domain = null,
            uint? domainLength = null,
            ushort* password = null,
            uint? passwordLength = null,
            uint? flags = null
        ) : this()
        {
            if (user is not null)
            {
                User = user;
            }

            if (userLength is not null)
            {
                UserLength = userLength.Value;
            }

            if (domain is not null)
            {
                Domain = domain;
            }

            if (domainLength is not null)
            {
                DomainLength = domainLength.Value;
            }

            if (password is not null)
            {
                Password = password;
            }

            if (passwordLength is not null)
            {
                PasswordLength = passwordLength.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "USHORT *")]
        [NativeName("Type.Name", "USHORT *")]
        [NativeName("Name", "User")]
        public ushort* User;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "UserLength")]
        public uint UserLength;

        [NativeName("Type", "USHORT *")]
        [NativeName("Type.Name", "USHORT *")]
        [NativeName("Name", "Domain")]
        public ushort* Domain;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "DomainLength")]
        public uint DomainLength;

        [NativeName("Type", "USHORT *")]
        [NativeName("Type.Name", "USHORT *")]
        [NativeName("Name", "Password")]
        public ushort* Password;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "PasswordLength")]
        public uint PasswordLength;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Flags")]
        public uint Flags;
    }
}
