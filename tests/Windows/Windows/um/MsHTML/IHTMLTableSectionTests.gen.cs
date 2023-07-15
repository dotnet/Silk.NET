// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLTableSection"/> struct.</summary>
public static unsafe partial class IHTMLTableSectionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLTableSection"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLTableSection).GUID, Is.EqualTo(IID_IHTMLTableSection));
    }

    /// <summary>Validates that the <see cref = "IHTMLTableSection"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLTableSection>(), Is.EqualTo(sizeof(IHTMLTableSection)));
    }

    /// <summary>Validates that the <see cref = "IHTMLTableSection"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLTableSection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLTableSection"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLTableSection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLTableSection), Is.EqualTo(4));
        }
    }
}