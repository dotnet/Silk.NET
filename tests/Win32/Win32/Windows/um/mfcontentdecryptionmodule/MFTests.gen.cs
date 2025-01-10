// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.MF;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MF"/> class.</summary>
public static partial class MFTests
{
    /// <summary>Validates that the value of the <see cref = "MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH"/> property is correct.</summary>

    [Test]
    public static void MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATHTest()
    {
        Assert.That(
            MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH.fmtid,
            Is.EqualTo(
                new Guid(0x730cb3ac, 0x51dc, 0x49da, 0xa5, 0x78, 0xb9, 0x53, 0x86, 0xb6, 0x2a, 0xfe)
            )
        );
        Assert.That(MF_CONTENTDECRYPTIONMODULE_INPRIVATESTOREPATH.pid, Is.EqualTo(0x01));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CONTENTDECRYPTIONMODULE_STOREPATH"/> property is correct.</summary>

    [Test]
    public static void MF_CONTENTDECRYPTIONMODULE_STOREPATHTest()
    {
        Assert.That(
            MF_CONTENTDECRYPTIONMODULE_STOREPATH.fmtid,
            Is.EqualTo(
                new Guid(0x77d993b9, 0xba61, 0x4bb7, 0x92, 0xc6, 0x18, 0xc8, 0x6a, 0x18, 0x9c, 0x06)
            )
        );
        Assert.That(MF_CONTENTDECRYPTIONMODULE_STOREPATH.pid, Is.EqualTo(0x02));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT"/> property is correct.</summary>

    [Test]
    public static void MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXTTest()
    {
        Assert.That(
            MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT.fmtid,
            Is.EqualTo(
                new Guid(0x6d2a2835, 0xc3a9, 0x4681, 0x97, 0xf2, 0x0a, 0xf5, 0x6b, 0xe9, 0x34, 0x46)
            )
        );
        Assert.That(MF_CONTENTDECRYPTIONMODULE_PMPSTORECONTEXT.pid, Is.EqualTo(0x03));
    }

    /// <summary>Validates that the value of the <see cref = "MF_CONTENTDECRYPTIONMODULE_SERVICE"/> property is correct.</summary>

    [Test]
    public static void MF_CONTENTDECRYPTIONMODULE_SERVICETest()
    {
        Assert.That(
            MF_CONTENTDECRYPTIONMODULE_SERVICE,
            Is.EqualTo(
                new Guid(0x15320c45, 0xff80, 0x484a, 0x9d, 0xcb, 0xd, 0xf8, 0x94, 0xe6, 0x9a, 0x1)
            )
        );
    }
}
