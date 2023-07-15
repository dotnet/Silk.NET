// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IDocViewSite"/> struct.</summary>
public static unsafe partial class IDocViewSiteTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDocViewSite"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDocViewSite).GUID, Is.EqualTo(IID_IDocViewSite));
    }

    /// <summary>Validates that the <see cref = "IDocViewSite"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDocViewSite>(), Is.EqualTo(sizeof(IDocViewSite)));
    }

    /// <summary>Validates that the <see cref = "IDocViewSite"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDocViewSite).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDocViewSite"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDocViewSite), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDocViewSite), Is.EqualTo(4));
        }
    }
}