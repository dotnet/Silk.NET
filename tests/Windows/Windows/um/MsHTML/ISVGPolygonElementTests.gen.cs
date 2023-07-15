// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISVGPolygonElement"/> struct.</summary>
public static unsafe partial class ISVGPolygonElementTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISVGPolygonElement"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGPolygonElement).GUID, Is.EqualTo(IID_ISVGPolygonElement));
    }

    /// <summary>Validates that the <see cref = "ISVGPolygonElement"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGPolygonElement>(), Is.EqualTo(sizeof(ISVGPolygonElement)));
    }

    /// <summary>Validates that the <see cref = "ISVGPolygonElement"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGPolygonElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISVGPolygonElement"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGPolygonElement), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGPolygonElement), Is.EqualTo(4));
        }
    }
}