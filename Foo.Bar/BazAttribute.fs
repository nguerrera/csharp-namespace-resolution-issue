namespace Foo.Bar

open System

[<AttributeUsage(AttributeTargets.All)>]
type BazAttribute() = 
    inherit Attribute()
