// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLTimeRanges"/> struct.</summary>
public static unsafe partial class HTMLTimeRangesTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLTimeRanges"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLTimeRanges).GUID, Is.EqualTo(IID_HTMLTimeRanges));
    }

    /// <summary>Validates that the <see cref = "HTMLTimeRanges"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLTimeRanges>(), Is.EqualTo(sizeof(HTMLTimeRanges)));
    }

    /// <summary>Validates that the <see cref = "HTMLTimeRanges"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLTimeRanges).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLTimeRanges"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLTimeRanges), Is.EqualTo(1));
    }
}