// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLDivPosition"/> struct.</summary>
public static unsafe partial class HTMLDivPositionTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLDivPosition"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLDivPosition).GUID, Is.EqualTo(IID_HTMLDivPosition));
    }

    /// <summary>Validates that the <see cref = "HTMLDivPosition"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLDivPosition>(), Is.EqualTo(sizeof(HTMLDivPosition)));
    }

    /// <summary>Validates that the <see cref = "HTMLDivPosition"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLDivPosition).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLDivPosition"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLDivPosition), Is.EqualTo(1));
    }
}