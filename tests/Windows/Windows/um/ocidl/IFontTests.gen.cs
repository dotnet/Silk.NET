// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IFont"/> struct.</summary>
public static unsafe partial class IFontTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IFont"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFont).GUID, Is.EqualTo(IID_IFont));
    }

    /// <summary>Validates that the <see cref = "IFont"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFont>(), Is.EqualTo(sizeof(IFont)));
    }

    /// <summary>Validates that the <see cref = "IFont"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFont).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IFont"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFont), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFont), Is.EqualTo(4));
        }
    }
}