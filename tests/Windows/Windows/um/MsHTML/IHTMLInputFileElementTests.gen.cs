// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLInputFileElement"/> struct.</summary>
public static unsafe partial class IHTMLInputFileElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLInputFileElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLInputFileElement).GUID, Is.EqualTo(IID_IHTMLInputFileElement));
    }

    /// <summary>Validates that the <see cref = "IHTMLInputFileElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLInputFileElement>(), Is.EqualTo(sizeof(IHTMLInputFileElement)));
    }

    /// <summary>Validates that the <see cref = "IHTMLInputFileElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLInputFileElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLInputFileElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLInputFileElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLInputFileElement), Is.EqualTo(4));
        }
    }
}