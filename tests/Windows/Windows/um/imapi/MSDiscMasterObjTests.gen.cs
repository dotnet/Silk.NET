// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MSDiscMasterObj"/> struct.</summary>
public static unsafe partial class MSDiscMasterObjTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "MSDiscMasterObj"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MSDiscMasterObj).GUID, Is.EqualTo(CLSID_MSDiscMasterObj));
    }

    /// <summary>Validates that the <see cref = "MSDiscMasterObj"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSDiscMasterObj>(), Is.EqualTo(sizeof(MSDiscMasterObj)));
    }

    /// <summary>Validates that the <see cref = "MSDiscMasterObj"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSDiscMasterObj).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MSDiscMasterObj"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MSDiscMasterObj), Is.EqualTo(1));
    }
}