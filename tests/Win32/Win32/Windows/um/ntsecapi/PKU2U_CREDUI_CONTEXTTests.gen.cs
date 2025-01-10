// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "PKU2U_CREDUI_CONTEXT"/> struct.</summary>
public static unsafe partial class PKU2U_CREDUI_CONTEXTTests
{
    /// <summary>Validates that the <see cref = "PKU2U_CREDUI_CONTEXT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<PKU2U_CREDUI_CONTEXT>(),
            Is.EqualTo(sizeof(PKU2U_CREDUI_CONTEXT))
        );
    }

    /// <summary>Validates that the <see cref = "PKU2U_CREDUI_CONTEXT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PKU2U_CREDUI_CONTEXT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "PKU2U_CREDUI_CONTEXT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PKU2U_CREDUI_CONTEXT), Is.EqualTo(24));
    }
}
