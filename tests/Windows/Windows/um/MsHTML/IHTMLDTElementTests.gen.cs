// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IHTMLDTElement"/> struct.</summary>
public static unsafe partial class IHTMLDTElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHTMLDTElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHTMLDTElement).GUID, Is.EqualTo(IID_IHTMLDTElement));
    }

    /// <summary>Validates that the <see cref = "IHTMLDTElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHTMLDTElement>(), Is.EqualTo(sizeof(IHTMLDTElement)));
    }

    /// <summary>Validates that the <see cref = "IHTMLDTElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHTMLDTElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHTMLDTElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHTMLDTElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHTMLDTElement), Is.EqualTo(4));
        }
    }
}