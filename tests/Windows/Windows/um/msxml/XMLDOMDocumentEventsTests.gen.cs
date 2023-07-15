// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "XMLDOMDocumentEvents"/> struct.</summary>
public static unsafe partial class XMLDOMDocumentEventsTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "XMLDOMDocumentEvents"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(XMLDOMDocumentEvents).GUID, Is.EqualTo(DIID_XMLDOMDocumentEvents));
    }

    /// <summary>Validates that the <see cref = "XMLDOMDocumentEvents"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XMLDOMDocumentEvents>(), Is.EqualTo(sizeof(XMLDOMDocumentEvents)));
    }

    /// <summary>Validates that the <see cref = "XMLDOMDocumentEvents"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XMLDOMDocumentEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "XMLDOMDocumentEvents"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XMLDOMDocumentEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(XMLDOMDocumentEvents), Is.EqualTo(4));
        }
    }
}