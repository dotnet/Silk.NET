// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "MODLOAD_PDBGUID_PDBAGE"/> struct.</summary>
public static unsafe partial class MODLOAD_PDBGUID_PDBAGETests
{
    /// <summary>Validates that the <see cref = "MODLOAD_PDBGUID_PDBAGE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<MODLOAD_PDBGUID_PDBAGE>(),
            Is.EqualTo(sizeof(MODLOAD_PDBGUID_PDBAGE))
        );
    }

    /// <summary>Validates that the <see cref = "MODLOAD_PDBGUID_PDBAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MODLOAD_PDBGUID_PDBAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MODLOAD_PDBGUID_PDBAGE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MODLOAD_PDBGUID_PDBAGE), Is.EqualTo(20));
    }
}
