module Fsharp.Xunit.Theory.MemberData
open Xunit

let someVals = ["abba"]

type Fixture() =
    [<Fact>]
    member _.AssertIsOnlyAbba() = Assert.Equal<string>(["abba"], someVals)

// uncomment the code below - tests should start working

//[<EntryPoint>]
//let main (args:string[]) = 0