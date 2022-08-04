//https://www.codewars.com/kata/514b92a657cdc65150000006/train/fsharp
//https://www.codewars.com/users/MrAliSalehi
let TotalSum(numbers : int32 list) =
    let mutable total = 0
    for num in numbers do
        total <- total + num;
    total

let solution x =
    let subNumbers = Seq.toList(seq{
        for i in 0..x - 1 ->
            if i % 3 = 0 || i % 5 = 0 then i
            else 0
    })
    TotalSum subNumbers


    
[<EntryPoint>]
let main argv = solution 10
