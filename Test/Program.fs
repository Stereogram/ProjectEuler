// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
module Module

[<EntryPoint>]
let main argv = 
    
    printfn "%d" (SumSquareDifference.Run 100)
            
    0 // return an integer exit code
