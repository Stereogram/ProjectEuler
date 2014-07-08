module MultiplesOf3And5

    let test n =
        [0..n-1]
        |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
        |> List.sum