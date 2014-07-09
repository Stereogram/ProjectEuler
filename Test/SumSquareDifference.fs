module SumSquareDifference

    let Run n =
        [1..n]
        |>let a = List.sumBy (fun x -> x*x)
        

        