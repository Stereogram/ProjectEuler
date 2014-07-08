// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module Module

[<EntryPoint>]
let main argv = 
    
    printfn "%d" (MultiplesOf3And5.test 1000)
            
    0 // return an integer exit code
