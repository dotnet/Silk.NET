// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPersistStreamInit"/> struct.</summary>
public static unsafe partial class IPersistStreamInitTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPersistStreamInit"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPersistStreamInit).GUID, Is.EqualTo(IID_IPersistStreamInit));
    }

    /// <summary>Validates that the <see cref = "IPersistStreamInit"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPersistStreamInit>(), Is.EqualTo(sizeof(IPersistStreamInit)));
    }

    /// <summary>Validates that the <see cref = "IPersistStreamInit"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPersistStreamInit).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPersistStreamInit"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPersistStreamInit), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPersistStreamInit), Is.EqualTo(4));
        }
    }
}