// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IXmlDocumentType"/> struct.</summary>
public static unsafe partial class IXmlDocumentTypeTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IXmlDocumentType"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IXmlDocumentType).GUID, Is.EqualTo(IID_IXmlDocumentType));
    }

    /// <summary>Validates that the <see cref = "IXmlDocumentType"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IXmlDocumentType>(), Is.EqualTo(sizeof(IXmlDocumentType)));
    }

    /// <summary>Validates that the <see cref = "IXmlDocumentType"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IXmlDocumentType).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IXmlDocumentType"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IXmlDocumentType), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IXmlDocumentType), Is.EqualTo(4));
        }
    }
}
