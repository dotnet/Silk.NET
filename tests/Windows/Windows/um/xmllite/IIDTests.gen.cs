// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IXmlReader"/> property is correct.</summary>
    [Test]
    public static void IID_IXmlReaderTest()
    {
        Assert.That(IID_IXmlReader, Is.EqualTo(new Guid(0x7279FC81, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IXmlWriter"/> property is correct.</summary>
    [Test]
    public static void IID_IXmlWriterTest()
    {
        Assert.That(IID_IXmlWriter, Is.EqualTo(new Guid(0x7279FC88, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_IXmlResolver"/> property is correct.</summary>
    [Test]
    public static void IID_IXmlResolverTest()
    {
        Assert.That(IID_IXmlResolver, Is.EqualTo(new Guid(0x7279FC82, 0x709D, 0x4095, 0xB6, 0x3D, 0x69, 0xFE, 0x4B, 0x0D, 0x90, 0x30)));
    }
}