module SumSquareDifference

    let Run n =
        let a = [1..n] |> List.sumBy (fun x -> x*x)
        let b = [1..n] |> List.sum |> (fun x -> x*x)
        b - a