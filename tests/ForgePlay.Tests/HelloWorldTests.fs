module HelloWorldTest

open NUnit.Framework

open ForgePlay

[<Test>]
let ``Say hi!`` () =
    Assert.That(HelloWorld.hello, Is.EqualTo("Hello, World!"))
