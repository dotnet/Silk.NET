// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLTableRow"/> struct.</summary>
public static unsafe partial class HTMLTableRowTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLTableRow"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLTableRow).GUID, Is.EqualTo(IID_HTMLTableRow));
    }

    /// <summary>Validates that the <see cref = "HTMLTableRow"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLTableRow>(), Is.EqualTo(sizeof(HTMLTableRow)));
    }

    /// <summary>Validates that the <see cref = "HTMLTableRow"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLTableRow).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLTableRow"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLTableRow), Is.EqualTo(1));
    }
}